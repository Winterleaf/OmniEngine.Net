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

#include "platform/platform.h"
#include "app/version.h"
#include "console/console.h"
#include "console/engineAPI.h"

static const U32 csgVersionNumber = TORQUE_GAME_ENGINE;
static const U32 appVersionNumber = TORQUE_APP_VERSION;

U32 getVersionNumber()
{
   return csgVersionNumber;
}

U32 getAppVersionNumber()
{
   return appVersionNumber;
}

const char* getVersionString()
{
   return TORQUE_GAME_ENGINE_VERSION_STRING;
}

const char* getAppVersionString()
{
   return TORQUE_APP_VERSION_STRING;
}

/// TGE       0001
/// TGEA      0002
/// TGB       0003
/// TGEA 360  0004
/// TGE  WII  0005
/// Torque 3D 0006
/// Torque 3D MIT 0007

const char* getEngineProductString()
{
#ifndef TORQUE_ENGINE_PRODUCT
   return "Torque Engine";
#else
   switch (TORQUE_ENGINE_PRODUCT)
   {
      case 0001:
         return "Torque Game Engine";
      case 0002:
         return "Torque Game Engine Advanced";
      case 0003:
         return "Torque 2D";
      case 0004:
         return "Torque 360";
      case 0005:
         return "Torque for Wii";
      case 0006:
         return "Torque 3D";
      case 0007:
	     return "OMNI";
		 
      default:
         return "Torque Engine";
   };
#endif
}

const char* getCompileTimeString()
{
   return __DATE__ " at " __TIME__;
}
//----------------------------------------------------------------

ConsoleFunctionGroupBegin( CompileInformation, "Functions to get version information about the current executable." );

DefineConsoleFunction( getVersionNumber, S32, (), , "Get the version of the engine build, as a string.\n\n" 
				"@ingroup Debugging")
{
   return getVersionNumber();
}

DefineConsoleFunction( getAppVersionNumber, S32, (), , "Get the version of the application build, as a string.\n\n" 
            "@ingroup Debugging")
{
   return getAppVersionNumber();
}


DefineConsoleFunction( getVersionString, const char*, (), , "Get the version of the engine build, as a human readable string.\n\n" 
				"@ingroup Debugging")
{
   return getVersionString();
}

DefineConsoleFunction( getAppVersionString, const char*, (), , "Get the version of the aplication build, as a human readable string.\n\n" 
            "@ingroup Debugging")
{
   return getAppVersionString();
}

DefineConsoleFunction( getEngineName, const char*, (), , "Get the name of the engine product that this is running from, as a string.\n\n" 
				"@ingroup Debugging")
{
   return getEngineProductString();
}

DefineConsoleFunction( getCompileTimeString, const char*, (), , "Get the time of compilation.\n\n" 
				"@ingroup Debugging")
{
   return getCompileTimeString();
}

DefineConsoleFunction( getBuildString, const char*, (), , "Get the type of build, \"Debug\" or \"Release\".\n\n"
				"@ingroup Debugging")
{
#ifdef TORQUE_DEBUG
   return "Debug";
#else
   return "Release";
#endif
}

ConsoleFunctionGroupEnd( CompileInformation );

DefineConsoleFunction( isDemo, bool, (), , "")
{
#ifdef TORQUE_DEMO
   return true;
#else
   return false;
#endif
}

DefineConsoleFunction( isWebDemo, bool, (), , "")
{
#ifdef TORQUE_DEMO
   return Platform::getWebDeployment();
#else
   return false;
#endif
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) S32  __cdecl wle_fn_getAppVersionNumber()
{
{
  return (S32)( getAppVersionNumber());
};
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_getAppVersionString(char* retval)
{
dSprintf(retval,16384,"");
const char* wle_returnObject;
{
   {wle_returnObject =getAppVersionString();
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_getBuildString(char* retval)
{
dSprintf(retval,16384,"");
const char* wle_returnObject;
{
#ifdef TORQUE_DEBUG
   {wle_returnObject ="Debug";
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
#else
   {wle_returnObject ="Release";
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
#endif
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_getCompileTimeString(char* retval)
{
dSprintf(retval,16384,"");
const char* wle_returnObject;
{
   {wle_returnObject =getCompileTimeString();
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_getEngineName(char* retval)
{
dSprintf(retval,16384,"");
const char* wle_returnObject;
{
   {wle_returnObject =getEngineProductString();
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_getVersionNumber()
{
{
  return (S32)( getVersionNumber());
};
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_getVersionString(char* retval)
{
dSprintf(retval,16384,"");
const char* wle_returnObject;
{
   {wle_returnObject =getVersionString();
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_isDemo()
{
bool wle_returnObject;
{
#ifdef TORQUE_DEMO
   {wle_returnObject =true;
return (S32)(wle_returnObject);}
#else
   {wle_returnObject =false;
return (S32)(wle_returnObject);}
#endif
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_isWebDemo()
{
bool wle_returnObject;
{
#ifdef TORQUE_DEMO
   {wle_returnObject =Platform::getWebDeployment();
return (S32)(wle_returnObject);}
#else
   {wle_returnObject =false;
return (S32)(wle_returnObject);}
#endif
}
}
//---------------END DNTC AUTO-GENERATED-----------//

