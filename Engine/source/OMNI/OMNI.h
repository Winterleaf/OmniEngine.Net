
#include "torqueConfig.h"
#include <string>

#include "console/engineAPI.h"
#include "platform/platform.h" 
#include "console/engineapi.h"
#include "console/consoleInternal.h"


namespace Winterleaf_EngineCallback
	{
	typedef void (__stdcall * WLE_setIcon)(void * hinst);
	typedef void (__stdcall * WLE_ExportVariablesAsSettings)(const char* filename, const char* variablename, const char* value, bool clearfile);
	typedef void (__stdcall * WLE_GlobalFunction)(S32 argc,const char** argv,const char * buffer);
	typedef void (__stdcall * WLE_EngineCallBack)(S32 simobjectid,S32 WLE_OMNI_ARRAY_POSTION,S32 argc,const char** argv,const char * buffer);
	typedef S32 (__stdcall * WLE_IsFunction)(S32 simobjectid,S32 WLE_OMNI_ARRAY_POSTION,const char* function);
	typedef S32 (__stdcall * WLE_gIsFunction)(const char* function);
	typedef void (__stdcall * WLE_RegisterSimObject)(S32 arrayposition,bool addObject,const char *classnamespace,const char *classname);

	extern WLE_setIcon                   mWLE_setIcon;
	extern WLE_EngineCallBack      mWLE_EngineCallBack;
	extern WLE_GlobalFunction       mWLE_GlobalFunction;
	extern WLE_ExportVariablesAsSettings mWLE_ExportVariablesAsSettings;
	extern WLE_IsFunction              mWLE_IsFunction;
	extern WLE_gIsFunction            mWLE_gIsFunction;
	extern WLE_RegisterSimObject mWLERegisterSimObject_Callback;
	
	}