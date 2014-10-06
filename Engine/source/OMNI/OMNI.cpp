// Copyright (C) 2012 Winterleaf Entertainment L,L,C.

#include "torqueConfig.h"
#include <string>

#include "console/engineAPI.h"
#include "platform/platform.h" 
#include "core/util/path.h"
#include "core/volume.h" 
#include "console/engineapi.h"
#include "math/mPoint3.h"
#include "sim/netObject.h"
#include "core/stream/bitStream.h" 
#include "core/stream/fileStream.h"
#include "core/strings/findMatch.h"
#include "core/strings/stringUnit.h"
#include "core/strings/unicode.h"
#include "sim/netConnection.h" 
#include "T3D/gameBase/gameConnection.h"
#include "T3D/gameBase/gameConnectionEvents.h"
#include "T3D/gameBase/gameProcess.h"
#include "console/consoleInternal.h"
#include "scene/simPath.h"
#include "T3D/CameraSpline.h"
#include "T3D/Player.h"
#include "console/ast.h"
#include "Scene/pathManager.h"
#include "T3D/Physics/physicsPlugin.h"
#include "math/mTransform.h"

static S32 sChaseQueueSize = 0;
static MatrixF* sChaseQueue = 0;
static S32 sChaseQueueHead = 0;
static S32 sChaseQueueTail = 0;

static Vector<String> sgFindFilesResults;
static U32 sgFindFilesPos = 0;
static char scriptFilenameBuffer[1024];
static U32 execDepth = 0;
static U32 journalDepth = 1;
static const U32 MaxPlayerNameLength = 16;
static U32 sgServerQueryIndex = 0;
static SimpleQueryList sgServerQueryList;
static char sgScriptFilenameBuffer[1024];



namespace Winterleaf_EngineCallback
{



	typedef void (__stdcall * WLE_ExportVariablesAsSettings)(const char* filename, const char* variablename, const char* value, bool clearfile);
	typedef void (__stdcall * WLE_GlobalFunction)(S32 argc,const char** argv,const char * buffer);
	typedef void (__stdcall * WLE_EngineCallBack)(S32 simobjectid,S32 WLE_OMNI_ARRAY_POSTION,S32 argc,const char** argv,const char * buffer);
	typedef S32 (__stdcall * WLE_IsFunction)(S32 simobjectid,S32 WLE_OMNI_ARRAY_POSTION,const char* function);
	typedef S32 (__stdcall * WLE_gIsFunction)(const char* function);
	typedef void (__stdcall * WLE_setIcon)(void * hinst);
	typedef void (__stdcall * WLE_RegisterSimObject)(S32 arrayposition,bool addObject,const char *classnamespace,const char *classname);



	WLE_EngineCallBack mWLE_EngineCallBack;
	WLE_GlobalFunction mWLE_GlobalFunction;
	WLE_ExportVariablesAsSettings mWLE_ExportVariablesAsSettings;
	WLE_IsFunction mWLE_IsFunction;
	WLE_gIsFunction mWLE_gIsFunction;
	WLE_setIcon mWLE_setIcon;
	WLE_RegisterSimObject mWLERegisterSimObject_Callback;

	extern "C" __declspec(dllexport) void __cdecl SetHandler_SimIdDictionary(void* handler)
	{
	mWLERegisterSimObject_Callback = (WLE_RegisterSimObject)handler;
	}
extern "C" __declspec(dllexport) void __cdecl ClearHandler_SimIdDictionary()
	{
	mWLERegisterSimObject_Callback = 0;
	}

	void _SetWLE_setIcon(void* handler)
	{
		Winterleaf_EngineCallback::mWLE_setIcon = (WLE_setIcon)handler;
	}

	void _ClearWLE_setIcon()
	{
		Winterleaf_EngineCallback::mWLE_setIcon = 0;
	}

	void _SetWLE_IsFunction(void* handler)
	{
		Winterleaf_EngineCallback::mWLE_IsFunction = (WLE_IsFunction)handler;
	}

	void _ClearWLE_IsFunction()
	{
		Winterleaf_EngineCallback::mWLE_IsFunction = 0;
	}

	void _SetWLE_ExportVariablesAsSettings(void* handler)
	{
		Winterleaf_EngineCallback::mWLE_ExportVariablesAsSettings = (WLE_ExportVariablesAsSettings)handler;
	}

	void _ClearWLE_ExportVariablesAsSettings()
	{
		Winterleaf_EngineCallback::mWLE_ExportVariablesAsSettings = 0;
	}

	void _SetWLE_gIsFunction(void* handler)
	{
		Winterleaf_EngineCallback::mWLE_gIsFunction = (WLE_gIsFunction)handler;
	}

	void _ClearWLE_gIsFunction()
	{
		Winterleaf_EngineCallback::mWLE_gIsFunction = 0;
	}


	void _SetEngineCallback(void* handler)
	{
		Winterleaf_EngineCallback::mWLE_EngineCallBack = (WLE_EngineCallBack)handler;
	}

	void _ClearEngineCallback()
	{
		Winterleaf_EngineCallback::mWLE_EngineCallBack = 0;
	}

	void _SetGlobalFunctionCallback(void * handler)
	{
		Winterleaf_EngineCallback::mWLE_GlobalFunction = (WLE_GlobalFunction)handler;
	}

	void _ClearGlobalFunctionCallback()
	{
		Winterleaf_EngineCallback::mWLE_GlobalFunction = 0;
	}
	
}

extern "C" __declspec(dllexport) S32 __cdecl getFileCRC(char * sfileName)
{
	char sgScriptFilenameBuffer[1024];
	String cleanfilename(Torque::Path::CleanSeparators(sfileName));
	Con::expandScriptFilename(sgScriptFilenameBuffer, sizeof(sgScriptFilenameBuffer), cleanfilename.c_str());
	Torque::Path givenPath(Torque::Path::CompressPath(sgScriptFilenameBuffer));
	Torque::FS::FileNodeRef fileRef = Torque::FS::GetFileNode( givenPath );
	if ( fileRef == NULL )
	{
		Con::errorf("getFileCRC() - could not access file: [%s]", givenPath.getFullPath().c_str() );
		return (S32)-1;
	}
	return (S32)fileRef->getChecksum();
}

extern "C" __declspec(dllexport) void __cdecl SetWLE_setIcon(void* handler)
{
	Winterleaf_EngineCallback::_SetWLE_setIcon(handler);
}

extern "C" __declspec(dllexport) void __cdecl ClearWLE_setIcon()
{
	Winterleaf_EngineCallback::_ClearWLE_setIcon();
}


extern "C" __declspec(dllexport) void __cdecl SetWLE_IsFunction(void* handler)
{
	Winterleaf_EngineCallback::_SetWLE_IsFunction(handler);
}

extern "C" __declspec(dllexport) void __cdecl ClearWLE_IsFunction()
{
	Winterleaf_EngineCallback::_ClearWLE_IsFunction();
}

extern "C" __declspec(dllexport) void __cdecl SetExportVariablesAsSettings(void* handler)
{
	Winterleaf_EngineCallback::_SetWLE_ExportVariablesAsSettings(handler);
}

extern "C" __declspec(dllexport) void __cdecl ClearExportVariablesAsSettings()
{
	Winterleaf_EngineCallback::_ClearWLE_ExportVariablesAsSettings();
}


extern "C" __declspec(dllexport) void __cdecl SetWLE_gIsFunction(void* handler)
{
	Winterleaf_EngineCallback::_SetWLE_gIsFunction(handler);
}

extern "C" __declspec(dllexport) void __cdecl ClearWLE_gIsFunction()
{
	Winterleaf_EngineCallback::_ClearWLE_gIsFunction();
}


extern "C" __declspec(dllexport) void __cdecl SetEngineCallback(void* handler)
{
	Winterleaf_EngineCallback::_SetEngineCallback(handler);
}

extern "C" __declspec(dllexport) void __cdecl ClearEngineCallback()
{
	Winterleaf_EngineCallback::_ClearEngineCallback();
}

extern "C" __declspec(dllexport) void __cdecl SetGlobalFunctionCallback(void* handler)
{
	Winterleaf_EngineCallback::_SetGlobalFunctionCallback(handler);
}

extern "C" __declspec(dllexport) void __cdecl ClearGlobalFunctionCallback()
{
	Winterleaf_EngineCallback::_ClearGlobalFunctionCallback();
}


//~~~~~~~~~~~~~~~~~~~~//~~~~~~~~~~~~~~~~~~~~//
// Network Object Identification

//  These useful console methods come from the following code resource:
//
//  How to Identify Objects from Client to Server or Server to Client by Nathan Davies
//    http://www.garagegames.com/index.php?sec=mg&mod=resource&page=view&qid=4852
//

DefineEngineMethod(NetConnection, GetGhostIndex, S32, (NetObject* obj),,
	"Returns the ghost-index for an object.\n\n"
	"@ingroup AFX")
{
	if (obj)
		return object->getGhostIndex(obj);
	return 0;
}

DefineEngineMethod(NetConnection, ResolveGhost, S32, (int ghostIndex),,
	"Resolves a ghost-index into an object ID.\n\n"
	"@ingroup AFX")
{
	if (ghostIndex != -1)
	{
		NetObject* pObject = NULL;
		if( object->isGhostingTo())
			pObject = object->resolveGhost(ghostIndex);
		else if( object->isGhostingFrom())
			pObject = object->resolveObjectFromGhostIndex(ghostIndex);
		if (pObject)
			return pObject->getId();
	}
	return 0;
}

class RCE : public NetEvent
{
public:
	typedef NetEvent Parent;

	enum
	{
		MaxRemoteCommandArgs = 20,
		CommandArgsBits = 5
	};

private:
	S32 mArgc;
	char *mArgv[MaxRemoteCommandArgs + 1];
	NetStringHandle mTagv[MaxRemoteCommandArgs + 1];
	static char mBuf[1024];
public:

	RCE(S32 argc=0, const char **argv=NULL, NetConnection *conn = NULL)
	{
		mArgc = argc;
		for (S32 i = 0; i < argc; i++)
			{
				if(argv[i][0] == StringTagPrefixByte)
				{
					char buffer[256];
					mTagv[i+1] = NetStringHandle(dAtoi(argv[i]+1));
					if(conn)
					{
						dSprintf(buffer + 1, sizeof(buffer) - 1, "%d", conn->getNetSendId(mTagv[i+1]));
						buffer[0] = StringTagPrefixByte;
						mArgv[i+1] = dStrdup(buffer);
					}
				}
				else
					mArgv[i+1] = dStrdup(argv[i]);
			}
	}

	~RCE()
	{
		for (S32 i = 0; i < mArgc; i++)
			dFree(mArgv[i+1]);
	}

	virtual void pack(NetConnection* conn, BitStream *bstream)
	{
		bstream->writeInt(mArgc, CommandArgsBits);
		// write it out reversed... why?
		// automatic string substitution with later arguments -
		// handled automatically by the system.

		for (S32 i = 0; i < mArgc; i++)
			conn->packString(bstream, mArgv[i+1]);
	}

	virtual void write(NetConnection* conn, BitStream *bstream)
	{
		pack(conn, bstream);
	}

	virtual void unpack(NetConnection* conn, BitStream *bstream)
	{
		mArgc = bstream->readInt(CommandArgsBits);
		// read it out backwards
		for (S32 i = 0; i < mArgc; i++)
			{
				conn->unpackString(bstream, mBuf);
				mArgv[i+1] = dStrdup(mBuf);
			}
	}

	virtual void process(NetConnection *conn)
	{
		static char idBuf[10];

		// de-tag the command name
		for (S32 i = mArgc - 1; i >= 0; i--)
			{
				// Con::errorf("nClient--> Param %i '%s'",i, mArgv[i+1]);
				char *arg = mArgv[i+1];
				if(*arg == StringTagPrefixByte)
				{
					// it's a tag:
					U32 localTag = dAtoi(arg + 1);
					NetStringHandle tag = conn->translateRemoteStringId(localTag);
					NetStringTable::expandString( tag,
					                              mBuf,
					                              sizeof(mBuf),
					                              (mArgc - 1) - i,
					                              (const char**)(mArgv + i + 2) );
					dFree(mArgv[i+1]);
					mArgv[i+1] = dStrdup(mBuf);
					//Con::errorf("nClient--> Param %i detag '%s'",i,mBuf);
				}
			}
		const char *rmtCommandName = dStrchr(mArgv[1], ' ') + 1;
		if(conn->isConnectionToServer())
		{
			dStrcpy(mBuf, "clientCmd");
			dStrcat(mBuf, rmtCommandName);

			char *temp = mArgv[1];
			mArgv[1] = mBuf;

			//	 Con::errorf("Client Command is firing!!! '%s' ",mBuf);

			Con::execute(mArgc, (const char **) mArgv+1);
			mArgv[1] = temp;
		}
		else
		{
			//Con::errorf("Server Command is firing!!!");
			dStrcpy(mBuf, "serverCmd");
			dStrcat(mBuf, rmtCommandName);
			char *temp = mArgv[1];

			dSprintf(idBuf, sizeof(idBuf), "%d", conn->getId());
			mArgv[0] = mBuf;
			mArgv[1] = idBuf;

			Con::execute(mArgc+1, (const char **) mArgv);
			mArgv[1] = temp;
		}
	}

	DECLARE_CONOBJECT(RCE);
};

char RCE::mBuf[1024];
IMPLEMENT_CO_NETEVENT_V1(RCE);

static void dnc_sendRemoteCommand(NetConnection *conn, S32 argc, const char **argv)
{
	if(U8(argv[0][0]) != StringTagPrefixByte)
	{
		Con::errorf(ConsoleLogEntry::Script, "Remote Command Error - command must be a tag.");
		return;
	}
	S32 i;
	for (i = argc - 1; i >= 0; i--)
		{
			if(argv[i][0] != 0)
				break;
			argc = i;
		}
	for (i = 0; i < argc; i++)
		{
			//Con::errorf("Param %i = '%s'",i,argv[i]);
			conn->validateSendString(argv[i]);
		}

	RCE *cevt = new RCE(argc, argv, conn);
	conn->postNetEvent(cevt);
}

extern "C" __declspec(dllexport) U32 __cdecl clientGroup_getCount()
{
	SimGroup *clientGroup = Sim::getClientGroup();
	return (U32)clientGroup->sizeRecursive();
}

extern "C" __declspec(dllexport) U32 __cdecl clientGroup_getObject(U32 index)
{
	SimGroup *pClientGroup = Sim::getClientGroup();

	int counter =0;
	SimGroup::iterator itr = pClientGroup->begin();
	for ( ; itr != pClientGroup->end(); itr++ )
		{
			if (counter==index)
			{
				GameConnection* gc = static_cast<GameConnection*>(*itr);
				if ( gc )
					return (U32)gc->getId();
				else
					return (U32)0;
			}
			counter++;
		}
	return (U32)0;
}

extern "C" __declspec(dllexport) U32 __cdecl SceneObject_getTypeMask(char* sceneobject)
{
	SimObject* sb = Sim::findObject(sceneobject);
	SceneObject* object = dynamic_cast<SceneObject *>(sb);
	if (!object)
		return (U32)0;
	return (U32)object->getTypeMask();
}

extern "C" __declspec(dllexport) void __cdecl SceneObject_initContainerRadiusSearch(F32 x,F32 y,F32 z, F32 radius,U32 mask,bool useClientContainer,U32 results[500],F32 distresults[500])
{
	SceneContainer* pContainer = useClientContainer ? &gClientContainer : &gServerContainer;
	Point3F pos = Point3F(x,y,z);
	pContainer->initRadiusSearch( pos, radius, mask );
	int i =0;
	while(SceneObject* t = pContainer->containerSearchNextObject())
	{
		if (i>500)
			return;
		results[i] = t->getId();
		distresults[i] = pContainer->containerSearchCurrRadiusDist();
		i++;
	}
}

extern "C" __declspec(dllexport) F32 __cdecl calcExplosionCoverage(F32 x,F32 y,F32 z,U32 id,U32 covMask)
{
	Point3F pos = Point3F(x,y,z);
	Point3F center;

	SceneObject* sceneObject = NULL;
	if (Sim::findObject(id, sceneObject) == false)
	{
		Con::warnf(ConsoleLogEntry::General, "calcExplosionCoverage: couldn't find object: %s", id);
		return 1.0f;
	}
	if (sceneObject->isClientObject() || sceneObject->getContainer() == NULL)
	{
		Con::warnf(ConsoleLogEntry::General, "calcExplosionCoverage: object is on the client, or not in the container system");
		return 1.0f;
	}

	sceneObject->getObjBox().getCenter(&center);
	center.convolve(sceneObject->getScale());
	sceneObject->getTransform().mulP(center);

	RayInfo rayInfo;
	sceneObject->disableCollision();
	if (sceneObject->getContainer()->castRay(pos, center, covMask, &rayInfo) == true)
	{
		// Try casting up and then out
		if (sceneObject->getContainer()->castRay(pos, pos + Point3F(0.0f, 0.0f, 1.0f), covMask, &rayInfo) == false)
		{
			if (sceneObject->getContainer()->castRay(pos + Point3F(0.0f, 0.0f, 1.0f), center, covMask, &rayInfo) == false)
			{
				sceneObject->enableCollision();
				return 1.0f;
			}
		}

		sceneObject->enableCollision();
		return 0.0f;
	}
	else
	{
		sceneObject->enableCollision();
		return 1.0f;
	}
}

extern "C" __declspec(dllexport) bool __cdecl doDismount(char * playerDataBlock)
{
	SimObject* sb = Sim::findObject(playerDataBlock);
	Player* object = dynamic_cast<Player *>(sb);
	if (!object)
		return false;
	PlayerData *pd = dynamic_cast<PlayerData *>(object->getDataBlock());
	if (!pd)
		return false;
	pd->doDismount_callback( object );


	return true;
}

extern "C" __declspec(dllexport) bool __cdecl SimObject_isField(char * simobject,char * fieldname)
{
	SimObject* object = Sim::findObject(simobject);
	if (!object)
		return false;
	return object->isField( fieldname );
}

extern "C" __declspec(dllexport) bool __cdecl NameSpace_isMethod(const char * _sns,const char* _method)
{
	Namespace* ns = Namespace::find(StringTable->insert( _sns ) );
	Namespace::Entry* nse = ns->lookup(StringTable->insert( _method) );
	if( !nse )
		return false;
	return true;
}

extern "C" __declspec(dllexport) bool __cdecl NameSpace_isInNamespaceHierarchy(char* shapebase, char* name)
{
	SimObject* object = Sim::findObject(shapebase);
	if (!object)
		return false;
	Namespace* nspace = object->getNamespace();
	while( nspace && dStricmp( nspace->mName, name ) != 0 )
		nspace = nspace->mParent;
	return ( nspace != NULL );
}

extern "C" __declspec(dllexport) S32 Console_getSimTime()
{
	return (S32)Sim::getCurrentTime();
}

extern "C" __declspec(dllexport) bool __cdecl isObject(char * simobj_id)
{
	return (Sim::findObject(simobj_id) != NULL);
}

extern "C" __declspec(dllexport) void __cdecl Console_printf(char * message)
{
	Con::printf("%s",message);
}

extern "C" __declspec(dllexport) void __cdecl Console_warnf(char * message)
{
	Con::warnf("%s",message);
}

extern "C" __declspec(dllexport) void __cdecl Console_errorf(char * message)
{
	Con::errorf("%s",message);
}

extern "C" __declspec(dllexport) void __cdecl ConsoleCall(char * cmd,char * result,bool echo)
{
	const char* r = Con::evaluate( cmd,echo);
	if (r)
		dSprintf(result,4096,"%s",r);
	else
		dSprintf(result,4096,"%s","");
}


extern "C" __declspec(dllexport) void __cdecl cs_torque_getvariable(char* name,char* result)
{
	dSprintf(result,4096,"%s",Con::getVariable(StringTable->insert(name)));
}

extern "C" __declspec(dllexport) void __cdecl cs_torque_setvariable(char* name, char* value)
{
	Con::setVariable(StringTable->insert(name), StringTable->insert(value));
}

extern "C" __declspec(dllexport) void __cdecl wle_script_simobject_getfield_string(U32 id, char* _fieldName,char * retval)
{
	dSprintf(retval,4096,"");
	const char* fieldName =NULL;
	fieldName = StringTable->insert(_fieldName);
	SimObject *object = Sim::findObject( id );
	if( object )
		dSprintf(retval,4096,"%s", object->getDataField(fieldName, ""));
}

extern "C" __declspec(dllexport) void __cdecl wle_script_simobject_setfield_string(U32 objectId, char* _fieldName, char* v)
{
	const char* fieldName =NULL;
	fieldName = StringTable->insert(_fieldName);
	SimObject *object = Sim::findObject( objectId );
	if( object )
	{
		object->setDataField(fieldName, "",(const char*) v);
	}
}


extern "C" __declspec(dllexport) void __cdecl deleteVariables(char * pattern)
{
	Con::removeVariable(pattern);
}

extern "C" __declspec(dllexport) bool __cdecl objectHasMethod(char* name,char* method)
{
	SimObject* _obj = Sim::findObject(name);
	return (_obj->isMethod(method));
}

extern "C" __declspec(dllexport) U32 __cdecl GetObjectID(char * simobj_id)
{
	SimObject* s = Sim::findObject(simobj_id);
	if (!s)
		return 0;
	return s->getId();
}

extern "C" __declspec(dllexport) bool __cdecl isFile(char * sfileName)
{
	char sgScriptFilenameBuffer[1024];
	String cleanfilename(Torque::Path::CleanSeparators(sfileName));
	Con::expandScriptFilename(sgScriptFilenameBuffer, sizeof(sgScriptFilenameBuffer), cleanfilename.c_str());
	Torque::Path givenPath(Torque::Path::CompressPath(sgScriptFilenameBuffer));
	return Torque::FS::IsFile(givenPath);
}



extern "C" __declspec(dllexport) void __cdecl pathOnMissionLoadDone()
{
	// Need to load subobjects for all loaded interiors...
	SimGroup* pMissionGroup = dynamic_cast<SimGroup*>(Sim::findObject("MissionGroup"));
	AssertFatal(pMissionGroup != NULL, "Error, mission done loading and no mission group?");

	U32 currStart = 0;
	U32 currEnd = 1;
	Vector<SimGroup*> groups;
	groups.push_back(pMissionGroup);

	while (true)
	{
		for (U32 i = currStart; i < currEnd; i++)
			{
				for (SimGroup::iterator itr = groups[i]->begin(); itr != groups[i]->end(); itr++)
					{
						if (dynamic_cast<SimGroup*>(*itr) != NULL)
							groups.push_back(static_cast<SimGroup*>(*itr));
					}
			}

		if (groups.size() == currEnd)
		{
			break;
		}
		else
		{
			currStart = currEnd;
			currEnd = groups.size();
		}
	}

	for (U32 i = 0; i < groups.size(); i++)
		{
			SimPath::Path* pPath = dynamic_cast<SimPath::Path*>(groups[i]);
			if (pPath)
				pPath->updatePath();
		}
}

extern "C" __declspec(dllexport) void __cdecl clearServerPaths()
{
	gServerPathManager->clearPaths();
}

extern "C" __declspec(dllexport) void __cdecl getAddress(char * client,char * _buffer)
{
	SimObject* _conn_obj = Sim::findObject(client);
	NetConnection* object = dynamic_cast<NetConnection *>(_conn_obj);
	if (object)
	{
		if(object->isLocalConnection())
		{
			dSprintf(_buffer,256,"%s","local");
			return;
		}
		Net::addressToString(object->getNetAddress(), _buffer);
	}
	else
		dSprintf(_buffer,256,"%s","");
	return;
}

extern "C" __declspec(dllexport) void __cdecl physicsStartSimulation(char * variable)
{
	if ( PHYSICSMGR )
	PHYSICSMGR->enableSimulation((const char*)variable, true );
}

extern "C" __declspec(dllexport) void __cdecl physicsStopSimulation(char * variable)
{
	if ( PHYSICSMGR )
	PHYSICSMGR->enableSimulation( (const char*)variable, false );
}

extern "C" __declspec(dllexport) U32 __cdecl getDataBlock(char * simobject)
{
	SimObject* _simobject = Sim::findObject(simobject);
	GameBase* gb = dynamic_cast<GameBase *>(_simobject);
	if (gb)
	{
		return (U32)(gb->getDataBlock()? gb->getDataBlock()->getId(): 0);
	}
	return (U32)0;
}

extern "C" __declspec(dllexport) bool __cdecl isFunction(char * functionname)
{
	return Con::isFunction((const char*)functionname);
}

extern "C" __declspec(dllexport) U32 __cdecl spawnObject(char * _spawnClass, char * _spawnDataBlock, char * _spawnName, char * _spawnProperties, char* _spawnScript)
{
	SimObject* spawnObject = Sim::spawnObject((const char*)_spawnClass, (const char*)_spawnDataBlock, (const char*)_spawnName, (const char*)_spawnProperties, (const char*)_spawnScript);
	if (spawnObject)
		return (U32)spawnObject->getId();
	else
		return (U32)-1;
}

extern "C" __declspec(dllexport) bool __cdecl isMemberOfClass (char * className, char* superClassName)
{
	AbstractClassRep *pRep = AbstractClassRep::findClassRep( className );
	while (pRep)
	{
		if( !dStricmp( pRep->getClassName(), superClassName ) )
			return true;
		pRep = pRep->getParentClass();
	}
	return false;
}

extern "C" __declspec(dllexport) void __cdecl getTaggedString (char * tag,char* ret)
{
	const char *indexPtr = tag;
	if (*indexPtr == StringTagPrefixByte)
		indexPtr++;

	dSprintf(ret,4096,gNetStringTable->lookupString(dAtoi(indexPtr)));
}

extern "C" __declspec(dllexport) void __cdecl addTaggedString (char * inString,char * ret)
{
	NetStringHandle s(inString);
	gNetStringTable->incStringRefScript(s.getIndex());
	ret[0] = StringTagPrefixByte;
	dSprintf(ret + 1, 9, "%d", s.getIndex());
}

extern "C" __declspec(dllexport) S32 __cdecl nameToID (char * name)
{
	SimObject *obj = Sim::findObject(name);
	if(obj)
		return (S32)obj->getId();
	else
		return (S32)-1;
}

extern "C" __declspec(dllexport) U32 __cdecl getParent (char* simobject)
{
	SimObject *parent;
	if(Sim::findObject(simobject, parent))
	{
		return (U32)parent->getId();
	}
	return (U32)0;
}

extern "C" __declspec(dllexport) void __cdecl getName (U32 simobject,char * ret)
{
	SimObject* _simobject = Sim::findObject(simobject);
	if (!_simobject)
	{
		dSprintf(ret,1024, "%s","");
		return;
	}

	const char *ret1 = _simobject->getName();
	//Con::errorf("-----------> Get Name '%s' ",ret1);
	if (ret1)
		dSprintf(ret,1024, "%s",ret1);
	else
		dSprintf(ret,1024, "%s","");
}

extern "C" __declspec(dllexport) void __cdecl getClassName (char* simobject,char * ret)
{
	SimObject* _simobject = Sim::findObject(simobject);
	if (!_simobject)
		return;
	const char *ret1 = _simobject->getClassName();
	if (ret1)
		dSprintf(ret,4096, "%s",ret1);
	else
		dSprintf(ret,4096, "%s","");
}

extern "C" __declspec(dllexport) void __cdecl containerRayCast(F64 start_x,F64 start_y,F64 start_z,F64 end_x,F64 end_y,F64 end_z,U32 mask,U32 exempt,bool useClientContainer,char* result)
{
	Point3F start = Point3F(start_x,start_y,start_z);
	Point3F end = Point3F(end_x,end_y,end_z);
	SceneObject *pExempt;
	if (exempt!=0)
		pExempt = dynamic_cast<SceneObject*>(Sim::findObject(exempt));
	else
		pExempt = NULL;

	if (pExempt)
		pExempt->enableCollision();

	SceneContainer* pContainer = useClientContainer ? &gClientContainer : &gServerContainer;

	RayInfo rinfo;
	S32 ret = 0;
	if (pContainer->castRay(start, end, mask, &rinfo) == true)
		ret = rinfo.object->getId();
	if (pExempt)
		pExempt->enableCollision();
	// add the hit position and normal?
	if(ret)
	{
		dSprintf(result, 256, "%d %g %g %g %g %g %g",
		         ret, rinfo.point.x, rinfo.point.y, rinfo.point.z,
		         rinfo.normal.x, rinfo.normal.y, rinfo.normal.z);
	}
	else
		dSprintf(result, 256,"");
}

extern "C" __declspec(dllexport) S32 __cdecl ContainerRadiusSearch(F32 x,F32 y,F32 z,F32 searchRadius, U32 searchMask, bool useClientContainer,U32 foundobjectIds[100])
{
	Point3F searchPoint = Point3F(x, y, z);
	Point3F mSearchReferencePoint = Point3F(x, y, z);
	Vector<SimObjectPtr<SceneObject>*> mSearchList;
	SceneContainer* pContainer = useClientContainer ? &gClientContainer : &gServerContainer;
	Box3F queryBox(searchPoint, searchPoint);
	queryBox.minExtents -= Point3F(searchRadius, searchRadius, searchRadius);
	queryBox.maxExtents += Point3F(searchRadius, searchRadius, searchRadius);
	SimpleQueryList queryList;
	pContainer->findObjects(queryBox, searchMask, SimpleQueryList::insertionCallback, &queryList);
	F32 radiusSquared = searchRadius * searchRadius;
	const F32* pPoint = &searchPoint.x;
	for (U32 i = 0; i < queryList.mList.size(); i++)
		{
			const F32* bMins;
			const F32* bMaxs;
			bMins = &queryList.mList[i]->getWorldBox().minExtents.x;
			bMaxs = &queryList.mList[i]->getWorldBox().maxExtents.x;
			F32 sum = 0;
			for (U32 j = 0; j < 3; j++)
				{
					if (pPoint[j] < bMins[j])
						sum += (pPoint[j] - bMins[j])*(pPoint[j] - bMins[j]);
					else if (pPoint[j] > bMaxs[j])
						sum += (pPoint[j] - bMaxs[j])*(pPoint[j] - bMaxs[j]);
				}
			if (sum < radiusSquared || queryList.mList[i]->isGlobalBounds())
			{
				mSearchList.push_back(new SimObjectPtr<SceneObject>);
				*(mSearchList.last()) = queryList.mList[i];
			}
		}

	S32 countofrecords = 0;

	if (mSearchList.size() != 0)
	{
		countofrecords =mSearchList.size();
		for (int i = 0;i<mSearchList.size();i++)
			{
				if (i<100)
					foundobjectIds[i] = mSearchList[i]->getObject()->getId();
				else
					i = mSearchList.size()+1;
			}
	}
	return (S32)countofrecords;
}

/*Console*/

/*Math*/
extern "C" __declspec(dllexport) void __cdecl Math_MatrixMulVector(F32 x,F32 y,F32 z,F32 ang,F32 ax,F32 ay,F32 az,F32 XX,F32 YY,F32 ZZ,char* retval)
{
	TransformF txfm;
	Point3F p3f;
	p3f.x = x;
	p3f.y = y;
	p3f.z = z;

	//Point3D
	Point3F aap3f;
	aap3f.x = ax;
	aap3f.y = ay;
	aap3f.z = az;
	AngAxisF aaf;
	aaf.axis = aap3f;
	aaf.angle =ang;
	txfm.mPosition = p3f;
	txfm.mOrientation = aaf;
	VectorF vector = VectorF(XX,YY,ZZ);
	MatrixF m = txfm.getMatrix();
	Box3F f;
	//f.
	//TransformF h = TransformF(m);

	m.mulV( vector );

	dSprintf(retval,1024, "%f %f %f ",vector.x,vector.y,vector.z);

	//Con::errorf(" %f %f %f ",vector.x,vector.y,vector.z);
	//RXX = vector.x;
	//RYY = vector.y;
	//RZZ = vector.z;
}

extern "C" __declspec(dllexport) void __cdecl Math_MatrixCreateFromEuler(F32 x,F32 y,F32 z,char* ret)
{
	Point3F angles = Point3F(x,y,z);
	QuatF rotQ( angles );
	AngAxisF aa;
	aa.set(rotQ);

	TransformF tret = TransformF( Point3F::Zero, aa );
	dSprintf(ret,1024,"%f %f %f %f %f %f %f ",tret.getPosition().x,tret.getPosition().y,tret.getPosition().z,tret.getOrientation().axis.x,tret.getOrientation().axis.y,tret.getOrientation().axis.z,tret.getOrientation().angle);
}

extern "C" __declspec(dllexport) void __cdecl getEulerRotation (char* simobject, F32 x,F32 y, F32 z)
{
	SimObject* _simobject = Sim::findObject(simobject);
	if (!_simobject)
		return;
	ShapeBase* sb = dynamic_cast<ShapeBase *>(_simobject);
	if (!sb)
		return;

	Point3F euler = sb->getTransform().toEuler();

	// Convert to degrees.
	x = mRadToDeg( euler.x );
	y = mRadToDeg( euler.y );
	z = mRadToDeg( euler.z );
}

/*Math*/

/*Net*/
extern "C" __declspec(dllexport) void __cdecl commandToServer(S32 argc,char ** _argv)
{
	std::vector<const char*> arguments;
	for (int i =0;i<argc;i++)
		{
			arguments.push_back(_argv[i]);
		}
	const char** argv = &arguments[0];


	NetConnection *conn = NetConnection::getConnectionToServer();
	if(!conn)
		return;
	dnc_sendRemoteCommand(conn, argc - 1, argv + 1);
	arguments.clear();
}

extern "C" __declspec(dllexport) void __cdecl commandToClient(S32 argc,char ** _argv)
{
	std::vector<const char*> arguments;
	for (int i =0;i<argc;i++)
		arguments.push_back(_argv[i]);
	const char** argv = &arguments[0];
	NetConnection *conn;
	if(!Sim::findObject(argv[1], conn))
	{
		Con::errorf("Unable to find connection %s" ,argv[1] );
		for (int i =0;i<argc;i++)
			Con::errorf("%s",_argv[i]);
		return;
	}
	dnc_sendRemoteCommand(conn, argc - 2, argv + 2);
	arguments.clear();
}

/*Net*/

/*SimObject*/
extern "C" __declspec(dllexport) void __cdecl removeTaggedString(char* tag)
{
	gNetStringTable->removeString(dAtoi(tag), true);
}

extern "C" __declspec(dllexport) void __cdecl SimObject_CallScript(char* simobject, S32 argc,char ** _argv,char* ret)
{
	dSprintf(ret,4096, "");
	SimObject* object = Sim::findObject(simobject);
	if (!object)
	{
		Con::errorf("------------------------------------>WARNING Cannot Find object '%s'.%s.",simobject,_argv[0]);
		return;
	}
	std::vector<const char*> arguments;
	for (int i =0;i<argc;i++)
		arguments.push_back(_argv[i]);
	const char** argv = &arguments[0];
	const char* r = Con::executeScript( object, argc, argv );
	if (r)
		dSprintf(ret,4096, "%s",r);
	arguments.clear();
}

extern "C" __declspec(dllexport) void __cdecl SimObject_Call(char* simobject, S32 argc,char ** _argv,char* ret)
{
	dSprintf(ret,4096, "");
	SimObject* object = Sim::findObject(simobject);
	if (!object)
	{
		Con::errorf("------------------------------------>WARNING Cannot Find object '%s'.%s.",simobject,_argv[0]);
		return;
	}
	std::vector<const char*> arguments;
	for (int i =0;i<argc;i++)
		arguments.push_back(_argv[i]);
	const char** argv = &arguments[0];
	const char* r = Con::execute( object, argc, argv );
	if (r)
		dSprintf(ret,4096, "%s",r);
	arguments.clear();
}

extern "C" __declspec(dllexport) void __cdecl execute (S32 argc,char ** _argv,char* ret)
{
	dSprintf(ret,4096, "");
	std::vector<const char*> arguments;
	for (int i =0;i<argc;i++)
		arguments.push_back(StringTable->insert(_argv[i]));
	const char** argv = &arguments[0];
	const char* r = Con::execute(argc,argv);
	if (r)
		dSprintf(ret,4096, "%s",r);
	arguments.clear();
}

extern "C" __declspec(dllexport) void __cdecl executeScript (S32 argc,char ** _argv,char* ret)
{
	dSprintf(ret,8000, "");
	std::vector<const char*> arguments;
	for (int i =0;i<argc;i++)
		arguments.push_back(StringTable->insert(_argv[i]));
	const char** argv = &arguments[0];
	const char* r = Con::executeScript(argc,argv);
	if (r)
		dSprintf(ret,8000, "%s",r);
	arguments.clear();
}

extern "C" __declspec(dllexport) void __cdecl Classname_Call(char* className,char* function, S32 argc,char ** _argv,char* ret,bool debug)
{
	dSprintf(ret,1024,"%s","");
	StringTableEntry nameSpace = StringTable->insert(className);
	StringTableEntry name = StringTable->insert(function);

	Namespace* ns = NULL;

	if (!nameSpace || !dStrlen(nameSpace))
		ns = Namespace::mGlobalNamespace;
	else
	{
		nameSpace = StringTable->insert(nameSpace);
		ns = Namespace::find(nameSpace); //can specify a package here, maybe need, maybe not
	}

	if (!ns)
	{
		Con::errorf("ERROR: Unable call function (%s) because Namespace (%s) not found.",name,nameSpace);
		return ;
	}
	name = StringTable->insert(name);

	Namespace::Entry* entry = ns->lookupRecursive(name);

	if (!entry)
	{
		Con::errorf("ERROR: Unable to call function (%s::%s), cannot find entry for function.",nameSpace,name);
		return;
	}

	std::vector<const char*> arguments;
	for (int i =0;i<argc;i++)
		{
#ifdef TORQUE_DEBUG
			Con::errorf("Adding '%s' to vector",_argv[i]);
#endif
			arguments.push_back(_argv[i]);
		}

	const char** argv = &arguments[0];
	if (debug)
		Con::errorf("Calling function %s::%s",nameSpace,name);
	const char* resultstring = entry->execute( argc,argv, &gEvalState);
	if (resultstring)
		if (dStrlen(resultstring)>0)
			dSprintf(ret,1024,"%s",resultstring);

	arguments.clear();
}

extern "C" __declspec(dllexport) void __cdecl ParentCall(char* sim_object,char* function,S32 namespacedepth,char* ret,S32 argc,char ** _argv,bool debug)
{
	dSprintf(ret,1024,"%s","");
	SimObject* object = Sim::findObject(sim_object);
	if (!object)
	{
		Con::errorf("Cannot find simobject");
		return;
	}
	Namespace* ns = object->getNamespace();
	for (int i = 0;i<=namespacedepth;i++)
		{
			ns = ns->getParent();
			if (!ns)
			{
				Con::errorf("OOOPS... NAMESPACE NOT FOUND");
				return;
			}
			if (debug)
				Con::errorf("Digging NameSpace for object (%s), Found NameSpace (%s) at a depth of (%i) on way to destination (%i)",sim_object,ns->getName(), i,namespacedepth-1);
		}
	if (!ns)
	{
		Con::errorf("WARNING!!!! --->Cannot Find Namespace");
		return;
	}

	std::vector<const char*> arguments;
	for (int i =0;i<argc;i++)
		{
#ifdef TORQUE_DEBUG
			if (debug)
			Con::errorf("Adding '%s' to vector",_argv[i]);
#endif
			arguments.push_back(_argv[i]);
		}

	const char** argv = &arguments[0];
	StringTableEntry callMethod = StringTable->insert( function );
	Namespace::Entry* funct = ns->lookup(callMethod);
	if (!funct)
	{
		Con::errorf("Cannot find parent");
		return;
	}
	const char* resultstring = funct->execute( argc,argv, &gEvalState);

	if (dStrlen(resultstring)>0)
		dSprintf(ret,1024,"%s",resultstring);
	arguments.clear();
}

extern "C" __declspec(dllexport) void __cdecl ParentCallFunct(char* function,S32 namespacedepth,char* ret,S32 argc,char ** _argv,bool debug)
{
	dSprintf(ret,1024,"%s","");
	StringTableEntry callMethod = StringTable->insert( function );
	if (!Con::isFunction(callMethod))
	{
		Con::errorf("Function Does not exist!");
		return;
	}
	else if (debug)
		Con::errorf("------>Found Function!!!");
	Namespace* ns =Namespace::global()->lookup(callMethod)->mNamespace;
	if (!ns)
	{
		Con::errorf("Namespace not working");
		return;
	}
	for (int i = 0;i<=namespacedepth;i++)
		{
			ns = ns->getParent();
			if (!ns)
			{
				Con::errorf("OOOPS... NAMESPACE NOT FOUND");
				return;
			}
			if (debug)
				Con::errorf("Digging NameSpace for object (%s), Found NameSpace (%s) at a depth of (%i) on way to destination (%i)",function,ns->getName(), i,namespacedepth-1);
		}
	if (debug)
		Con::errorf("Current NameSpace is %s",ns->mName);

	std::vector<const char*> arguments;
	for (int i =0;i<argc;i++)
		{
#ifdef TORQUE_DEBUG
			if (debug)
			Con::errorf("Adding '%s' to vector",_argv[i]);
#endif
			arguments.push_back(_argv[i]);
		}
	const char** argv = &arguments[0];
	Namespace::Entry* funct = ns->lookup(callMethod);
	if (!funct)
	{
		Con::errorf("Cannot find parent Function!!!!!!!!!!!");
		return;
	}
	//Con::errorf("Calling Function");
	const char* resultstring = funct->execute( argc,argv, &gEvalState);
	if (resultstring)
		if (dStrlen(resultstring)>0)
			dSprintf(ret,1024,"%s",resultstring);
	arguments.clear();
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) S32  __cdecl wle_fnNetConnection_GetGhostIndex(char * x__object, char * x__obj)
{
NetConnection* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);
NetObject* obj; Sim::findObject(x__obj, obj ); 
{
	if (obj)
		return object->getGhostIndex(obj);
	return 0;
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fnNetConnection_ResolveGhost(char * x__object, int ghostIndex)
{
NetConnection* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);
{
	if (ghostIndex != -1)
	{
		NetObject* pObject = NULL;
		if( object->isGhostingTo())
			pObject = object->resolveGhost(ghostIndex);
		else if( object->isGhostingFrom())
			pObject = object->resolveObjectFromGhostIndex(ghostIndex);
		if (pObject)
			return pObject->getId();
	}
	return 0;
};
}
//---------------END DNTC AUTO-GENERATED-----------//

