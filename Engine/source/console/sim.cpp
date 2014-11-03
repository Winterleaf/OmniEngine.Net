//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

#include "console/console.h"
#include "console/engineAPI.h"
#include "console/sim.h"
#include "console/simEvents.h"
#include "console/simObject.h"
#include "console/simSet.h"
#include "core/module.h"


MODULE_BEGIN( Sim )

   // Note: tho the SceneGraphs are created after the Manager, delete them after, rather
   //  than before to make sure that all the objects are removed from the graph.
   MODULE_INIT_AFTER( GFX )
   MODULE_SHUTDOWN_BEFORE( GFX )

   MODULE_INIT
   {
      Sim::init();
   }
   
   MODULE_SHUTDOWN
   {
      Sim::shutdown();
   }

MODULE_END;



namespace Sim
{
   // Don't forget to InstantiateNamed* in simManager.cc - DMM
   ImplementNamedSet(ActiveActionMapSet)
   ImplementNamedSet(GhostAlwaysSet)
   ImplementNamedSet(WayPointSet)
   ImplementNamedSet(fxReplicatorSet)
   ImplementNamedSet(fxFoliageSet)
   ImplementNamedSet(BehaviorSet)
   ImplementNamedSet(MaterialSet)
   ImplementNamedSet(SFXSourceSet)
   ImplementNamedSet(SFXDescriptionSet)
   ImplementNamedSet(SFXTrackSet)
   ImplementNamedSet(SFXEnvironmentSet)
   ImplementNamedSet(SFXStateSet)
   ImplementNamedSet(SFXAmbienceSet)
   ImplementNamedSet(TerrainMaterialSet)
   ImplementNamedSet(DataBlockSet);
   ImplementNamedGroup(ActionMapGroup)
   ImplementNamedGroup(ClientGroup)
   ImplementNamedGroup(GuiGroup)
   ImplementNamedGroup(GuiDataGroup)
   ImplementNamedGroup(TCPGroup)
   ImplementNamedGroup(SFXParameterGroup);

   //groups created on the client
   ImplementNamedGroup(ClientConnectionGroup)
   ImplementNamedSet(sgMissionLightingFilterSet)
}

//-----------------------------------------------------------------------------
// Console Functions
//-----------------------------------------------------------------------------

ConsoleFunctionGroupBegin ( SimFunctions, "Functions relating to Sim.");

DefineConsoleFunction( nameToID, S32, (const char * objectName), ,"nameToID(object)")
{
   SimObject *obj = Sim::findObject(objectName);
   if(obj)
      return obj->getId();
   else
      return -1;
}

DefineConsoleFunction( isObject, bool, (const char * objectName), ,"isObject(object)")
{
   if (!dStrcmp(objectName, "0") || !dStrcmp(objectName, ""))
      return false;
   else
      return (Sim::findObject(objectName) != NULL);
}

ConsoleDocFragment _spawnObject1(
   "@brief Global function used for spawning any type of object.\n\n"

   "Note: This is separate from SpawnSphere::spawnObject(). This function is not called off any "
   "other class and uses different parameters than the SpawnSphere's function. In the source, "
   "SpawnSphere::spawnObject() actually calls this function and passes its properties "
   "(spawnClass, spawnDatablock, etc).\n\n"

   "@param class Mandatory field specifying the object class, such as Player or TSStatic.\n\n"
   "@param datablock Field specifying the object's datablock, optional for objects such as TSStatic, mandatory for game objects like Player.\n\n"
   "@param name Optional field specifying a name for this instance of the object.\n\n"
   "@param properties Optional set of parameters applied to the spawn object during creation.\n\n"
   "@param script Optional command(s) to execute when spawning an object.\n\n"

   "@tsexample\n"
      "// Set the parameters for the spawn function\n"
      "%objectClass = \"Player\";\n"
      "%objectDatablock = \"DefaultPlayerData\";\n"
      "%objectName = \"PlayerName\";\n"
      "%additionalProperties = \"health = \\\"0\\\";\"; // Note the escape sequence \\ in front of quotes\n"
      "%spawnScript = \"echo(\\\"Player Spawned\\\");\" // Note the escape sequence \\ in front of quotes\n"
      "// Spawn with the engine's Sim::spawnObject() function\n"
      "%player = spawnObject(%objectClass, %objectDatablock, %objectName, %additionalProperties, %spawnScript);\n"
   "@endtsexample\n\n"

   "@ingroup Game",
   NULL,
   "bool spawnObject(class [, dataBlock, name, properties, script]);"
);

DefineConsoleFunction( spawnObject, S32, (   const char * spawnClass
                                         ,   const char * spawnDataBlock
                                         ,   const char * spawnName
                                         ,   const char * spawnProperties
                                         ,   const char * spawnScript 
										 ,   const char * modelName
                                         ),("","","","","") ,"spawnObject(class [, dataBlock, name, properties, script,modelName])"
				"@hide")
{

   SimObject* spawnObject = Sim::spawnObject(spawnClass, spawnDataBlock, spawnName, spawnProperties, spawnScript,modelName);

   if (spawnObject)
      return spawnObject->getId();
   else
      return -1;
}

DefineConsoleFunction( cancel, void, (S32 eventId), ,"cancel(eventId)")
{
   Sim::cancelEvent(eventId);
}

DefineConsoleFunction( cancelAll, void, (const char * objectId), ,"cancelAll(objectId): cancel pending events on the specified object.  Events will be automatically cancelled if object is deleted.")
{
   Sim::cancelPendingEvents(Sim::findObject(objectId));
}

DefineConsoleFunction( isEventPending, bool, (S32 scheduleId), ,"isEventPending(%scheduleId);")
{
   return Sim::isEventPending(scheduleId);
}

DefineConsoleFunction( getEventTimeLeft, S32, (S32 scheduleId), ,"getEventTimeLeft(scheduleId) Get the time left in ms until this event will trigger.")
{
   return Sim::getEventTimeLeft(scheduleId);
}

DefineConsoleFunction( getScheduleDuration, S32, (S32 scheduleId), ,"getScheduleDuration(%scheduleId);" )
{
   S32 ret = Sim::getScheduleDuration(scheduleId);
   return ret;
}

DefineConsoleFunction( getTimeSinceStart, S32, (S32 scheduleId), ,"getTimeSinceStart(%scheduleId);" )
{
   S32 ret = Sim::getTimeSinceStart(scheduleId);
   return ret;
}

ConsoleFunction(schedule, S32, 4, 0, "schedule(time, refobject|0, command, <arg1...argN>)")
{
   U32 timeDelta = U32(dAtof(argv[1]));
   SimObject *refObject = Sim::findObject(argv[2]);
   if(!refObject)
   {
      if(argv[2][0] != '0')
         return 0;

      refObject = Sim::getRootGroup();
   }
   SimConsoleEvent *evt = new SimConsoleEvent(argc - 3, argv + 3, false);

   S32 ret = Sim::postEvent(refObject, evt, Sim::getCurrentTime() + timeDelta);
   // #ifdef DEBUG
   //    Con::printf("ref %s schedule(%s) = %d", argv[2], argv[3], ret);
   //    Con::executef( "backtrace");
   // #endif
   return ret;
}

DefineConsoleFunction( getUniqueName, const char*, (const char * baseName), ,
	"( String baseName )\n"
	"@brief Returns a unique unused SimObject name based on a given base name.\n\n"
	"@baseName Name to conver to a unique string if another instance exists\n"
	"@note Currently only used by editors\n"
	"@ingroup Editors\n"
	"@internal")
{
   String outName = Sim::getUniqueName( baseName );
   
   if ( outName.isEmpty() )
      return NULL;

   char *buffer = Con::getReturnBuffer( outName.size() );
   dStrcpy( buffer, outName );

   return buffer;
}

DefineConsoleFunction( getUniqueInternalName, const char*, (const char * baseName, const char * setString, bool searchChildren), ,
   "( String baseName, SimSet set, bool searchChildren )\n"
   "@brief Returns a unique unused internal name within the SimSet/Group based on a given base name.\n\n"
   "@note Currently only used by editors\n"
   "@ingroup Editors\n"
   "@internal")
{
   SimSet *set;
   if ( !Sim::findObject( setString, set ) )
   {
      Con::errorf( "getUniqueInternalName() - invalid parameter for SimSet." );
      return NULL;
   }

   String outName = Sim::getUniqueInternalName( baseName, set, searchChildren );

   if ( outName.isEmpty() )
      return NULL;

   char *buffer = Con::getReturnBuffer( outName.size() );
   dStrcpy( buffer, outName );

   return buffer;
}

DefineConsoleFunction( isValidObjectName, bool, (const char * name), , "( string name )"
				"@brief Return true if the given name makes for a valid object name.\n\n"
				"@param name Name of object\n"
				"@return True if name is allowed, false if denied (usually because it starts with a number, _, or invalid character"
				"@ingroup Console")
{
   return Sim::isValidObjectName( name );
}

ConsoleFunctionGroupEnd( SimFunctions );


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) S32  __cdecl wle_fn__schedule(char * x__a1, char * x__a2, char * x__a3, char * x__a4, char * x__a5, char * x__a6, char * x__a7, char * x__a8, char * x__a9, char * x__a10, char * x__a11, char * x__a12, char * x__a13, char * x__a14, char * x__a15, char * x__a16, char * x__a17, char * x__a18, char * x__a19)
{
const char* a1 = (const char*)x__a1;
const char* a2 = (const char*)x__a2;
const char* a3 = (const char*)x__a3;
const char* a4 = (const char*)x__a4;
const char* a5 = (const char*)x__a5;
const char* a6 = (const char*)x__a6;
const char* a7 = (const char*)x__a7;
const char* a8 = (const char*)x__a8;
const char* a9 = (const char*)x__a9;
const char* a10 = (const char*)x__a10;
const char* a11 = (const char*)x__a11;
const char* a12 = (const char*)x__a12;
const char* a13 = (const char*)x__a13;
const char* a14 = (const char*)x__a14;
const char* a15 = (const char*)x__a15;
const char* a16 = (const char*)x__a16;
const char* a17 = (const char*)x__a17;
const char* a18 = (const char*)x__a18;
const char* a19 = (const char*)x__a19;
{
S32 argc = 20;
if (dStrlen(a19)==0)
if (dStrlen(a18)==0)
if (dStrlen(a17)==0)
if (dStrlen(a16)==0)
if (dStrlen(a15)==0)
if (dStrlen(a14)==0)
if (dStrlen(a13)==0)
if (dStrlen(a12)==0)
if (dStrlen(a11)==0)
if (dStrlen(a10)==0)
if (dStrlen(a9)==0)
if (dStrlen(a8)==0)
if (dStrlen(a7)==0)
if (dStrlen(a6)==0)
if (dStrlen(a5)==0)
argc=5;
else
argc=6;
else
argc=7;
else
argc=8;
else
argc=9;
else
argc=10;
else
argc=11;
else
argc=12;
else
argc=13;
else
argc=14;
else
argc=15;
else
argc=16;
else
argc=17;
else
argc=18;
else
argc=19;
else
argc=20;
std::vector<const char*> arguments;
arguments.push_back("");
arguments.push_back(a1);
arguments.push_back(a2);
arguments.push_back(a3);
if (argc>=5)
arguments.push_back(a4);
if (argc>=6)
arguments.push_back(a5);
if (argc>=7)
arguments.push_back(a6);
if (argc>=8)
arguments.push_back(a7);
if (argc>=9)
arguments.push_back(a8);
if (argc>=10)
arguments.push_back(a9);
if (argc>=11)
arguments.push_back(a10);
if (argc>=12)
arguments.push_back(a11);
if (argc>=13)
arguments.push_back(a12);
if (argc>=14)
arguments.push_back(a13);
if (argc>=15)
arguments.push_back(a14);
if (argc>=16)
arguments.push_back(a15);
if (argc>=17)
arguments.push_back(a16);
if (argc>=18)
arguments.push_back(a17);
if (argc>=19)
arguments.push_back(a18);
if (argc>=20)
arguments.push_back(a19);
const char** argv = &arguments[0];
{
   U32 timeDelta = U32(dAtof(argv[1]));
   SimObject *refObject = Sim::findObject(argv[2]);
   if(!refObject)
   {
      if(argv[2][0] != '0')
        return (S32)( 0);
      refObject = Sim::getRootGroup();
   }
   SimConsoleEvent *evt = new SimConsoleEvent(argc - 3, argv + 3, false);
   S32 ret = Sim::postEvent(refObject, evt, Sim::getCurrentTime() + timeDelta);
              return (S32)( ret);
}
}
;
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_cancel(S32 eventId)
{
{
   Sim::cancelEvent(eventId);
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_cancelAll(char * x__objectId)
{
const char* objectId = (const char*)x__objectId;
{
   Sim::cancelPendingEvents(Sim::findObject(objectId));
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_getEventTimeLeft(S32 scheduleId)
{
{
  return (S32)( Sim::getEventTimeLeft(scheduleId));
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_getScheduleDuration(S32 scheduleId)
{
{
   S32 ret = Sim::getScheduleDuration(scheduleId);
  return (S32)( ret);
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_getTimeSinceStart(S32 scheduleId)
{
{
   S32 ret = Sim::getTimeSinceStart(scheduleId);
  return (S32)( ret);
};
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_getUniqueInternalName(char * x__baseName, char * x__setString, bool searchChildren,  char* retval)
{
dSprintf(retval,16384,"");
const char* baseName = (const char*)x__baseName;
const char* setString = (const char*)x__setString;

const char* wle_returnObject;
{
   SimSet *set;
   if ( !Sim::findObject( setString, set ) )
   {
      Con::errorf( "getUniqueInternalName() - invalid parameter for SimSet." );
      {wle_returnObject =NULL;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
   }
   String outName = Sim::getUniqueInternalName( baseName, set, searchChildren );
   if ( outName.isEmpty() )
      {wle_returnObject =NULL;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
   char *buffer = Con::getReturnBuffer( outName.size() );
   dStrcpy( buffer, outName );
   {wle_returnObject =buffer;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_getUniqueName(char * x__baseName,  char* retval)
{
dSprintf(retval,16384,"");
const char* baseName = (const char*)x__baseName;
const char* wle_returnObject;
{
   String outName = Sim::getUniqueName( baseName );
   
   if ( outName.isEmpty() )
      {wle_returnObject =NULL;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
   char *buffer = Con::getReturnBuffer( outName.size() );
   dStrcpy( buffer, outName );
   {wle_returnObject =buffer;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_isEventPending(S32 scheduleId)
{
bool wle_returnObject;
{
   {wle_returnObject =Sim::isEventPending(scheduleId);
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_isObject(char * x__objectName)
{
const char* objectName = (const char*)x__objectName;
bool wle_returnObject;
{
   if (!dStrcmp(objectName, "0") || !dStrcmp(objectName, ""))
      {wle_returnObject =false;
return (S32)(wle_returnObject);}
   else
      {wle_returnObject =(Sim::findObject(objectName) != NULL);
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_isValidObjectName(char * x__name)
{
const char* name = (const char*)x__name;
bool wle_returnObject;
{
   {wle_returnObject =Sim::isValidObjectName( name );
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_nameToID(char * x__objectName)
{
const char* objectName = (const char*)x__objectName;
{
   SimObject *obj = Sim::findObject(objectName);
   if(obj)
     return (S32)( obj->getId());
   else
     return (S32)( -1);
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_spawnObject(char * x__spawnClass, char * x__spawnDataBlock, char * x__spawnName, char * x__spawnProperties, char * x__spawnScript, char * x__modelName)
{
const char* spawnClass = (const char*)x__spawnClass;
const char* spawnDataBlock = (const char*)x__spawnDataBlock;
const char* spawnName = (const char*)x__spawnName;
const char* spawnProperties = (const char*)x__spawnProperties;
const char* spawnScript = (const char*)x__spawnScript;
const char* modelName = (const char*)x__modelName;
{
   SimObject* spawnObject = Sim::spawnObject(spawnClass, spawnDataBlock, spawnName, spawnProperties, spawnScript,modelName);
   if (spawnObject)
     return (S32)( spawnObject->getId());
   else
     return (S32)( -1);
};
}
//---------------END DNTC AUTO-GENERATED-----------//

