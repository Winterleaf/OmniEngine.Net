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

#include "T3D/aiConnection.h"
#include "console/engineAPI.h"

IMPLEMENT_CONOBJECT( AIConnection );

ConsoleDocClass( AIConnection,
   "@brief Special client connection driven by an AI, rather than a human.\n\n"

   "Unlike other net connections, AIConnection is intended to run unmanned. Rather than "
   "gathering input from a human using a device, move events, triggers, and look events "
   "are driven through functions like AIConnection::setMove.\n\n"

   "In addition to having its own set of functions for managing client move events, "
   "a member variable inherited by GameConnection is toggle: mAIControlled. This is useful "
   "for a server to determine if a connection is AI driven via the function GameConnection::isAIControlled\n\n"

   "AIConnection is an alternative to manually creating an AI driven game object. When you "
   "want the server to manage AI, you will create a specific one from script using a "
   "class like AIPlayer. If you do not want the server managing the AI and wish to simulate "
   "a complete client connection, you will use AIConnection\n\n."

   "To get more specific, if you want a strong alternative to AIPlayer (and wish to make use "
   "of the AIConnection structure), consider AIClient. AIClient inherits from AIConnection, "
   "contains quite a bit of functionality you will find in AIPlayer, and has its own Player "
   "object.\n\n"

   "@tsexample\n"
   "// Create a new AI client connection\n"
   "%botConnection = aiConnect(\"MasterBlaster\" @ %i, -1, 0.5, false, \"SDF\", 1.0);\n\n"
   "// In another area of the code, you can locate this and any other AIConnections\n"
   "// using the isAIControlled function\n"
   "for(%i = 0; %i < ClientGroup.getCount(); %i++)\n"
   "{\n"
   "   %client = ClientGroup.getObject(%i);\n"
   "   if(%client.isAIControlled())\n"
   "   {\n"
   "      // React to this AI controlled client\n"
   "   }\n"
   "}\n"
   "@endtsexample\n\n"

   "@note This is a legacy class, which you are discouraged from using as it will "
   "most likely be deprecated in a future version. For now it has been left in for "
   "backwards compatibility with TGE and the old RTS Kit. Use GameConnection "
   "and AIPlayer instead.\n\n"

   "@see GameConnection, NetConnection, AIClient\n\n"

   "@ingroup AI\n"
   "@ingroup Networking\n"
);
//-----------------------------------------------------------------------------

AIConnection::AIConnection() {
   mAIControlled = true;
   mMove = NullMove;
}


//-----------------------------------------------------------------------------

void AIConnection::clearMoves( U32 )
{
   // Clear the pending move list. This connection generates moves
   // on the fly, so there are never any pending moves.
}

void AIConnection::setMove(Move* m)
{
   mMove = *m;
}

const Move& AIConnection::getMove()
{
   return mMove;
}

/// Retrive the pending moves
/**
 * The GameConnection base class queues moves for delivery to the
 * controll object.  This function is normally used to retrieve the
 * queued moves recieved from the client.  The AI connection does not
 * have a connected client and simply generates moves on-the-fly
 * base on it's current state.
 */
U32 AIConnection::getMoveList( Move **lngMove, U32 *numMoves )
{
   *numMoves = 1;
   *lngMove = &mMove;
   return *numMoves;
}


//-----------------------------------------------------------------------------
// Console functions & methods
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

static inline F32 moveClamp(F32 v)
{
   // Support function to convert/clamp the input into a move rotation
   // which only allows 0 -> M_2PI.
   F32 a = mClampF(v, -M_2PI_F, M_2PI_F);
   return (a < 0) ? a + M_2PI_F : a;
}


//-----------------------------------------------------------------------------
/// Construct and connect an AI connection object
ConsoleFunction(aiConnect, S32 , 2, 20, "(...)"
   "@brief Creates a new AIConnection, and passes arguments to its onConnect script callback.\n\n"
   "@returns The newly created AIConnection\n"
   "@see GameConnection for parameter information\n"
   "@ingroup AI")
{
   // Create the connection
   AIConnection *aiConnection = new AIConnection();
   aiConnection->registerObject();

   // Add the connection to the client group
   SimGroup *g = Sim::getClientGroup();
   g->addObject( aiConnection );

   // Prep the arguments for the console exec...
   // Make sure and leav args[1] empty.
   const char* args[21];
   args[0] = "onConnect";
   for (S32 i = 1; i < argc; i++)
      args[i + 1] = argv[i];

   // Execute the connect console function, this is the same
   // onConnect function invoked for normal client connections
   Con::execute(aiConnection, argc + 1, args);
   return aiConnection->getId();
}


//-----------------------------------------------------------------------------
DefineConsoleMethod(AIConnection, setMove, void, (const char * field, F32 value), ,"(string field, float value)"
              "Set a field on the current move.\n\n"
              "@param   field One of {'x','y','z','yaw','pitch','roll'}\n"
              "@param   value Value to set field to.")
{
   Move move = object->getMove();

   // Ok, a little slow for now, but this is just an example..
   if (!dStricmp(field,"x"))
      move.x = mClampF(value,-1,1);
      else
   if (!dStricmp(field,"y"))
      move.y = mClampF(value,-1,1);
      else
   if (!dStricmp(field,"z"))
      move.z = mClampF(value,-1,1);
      else
   if (!dStricmp(field,"yaw"))
      move.yaw = moveClamp(value);
      else
   if (!dStricmp(field,"pitch"))
      move.pitch = moveClamp(value);
      else
   if (!dStricmp(field,"roll"))
      move.roll = moveClamp(value);

   //
   object->setMove(&move);
}

DefineConsoleMethod(AIConnection,getMove,F32, (const char * field), ,"(string field)"
              "Get the given field of a move.\n\n"
              "@param field One of {'x','y','z','yaw','pitch','roll'}\n"
              "@returns The requested field on the current move.")
{
   const Move& move = object->getMove();
   if (!dStricmp(field,"x"))
      return move.x;
   if (!dStricmp(field,"y"))
      return move.y;
   if (!dStricmp(field,"z"))
      return move.z;
   if (!dStricmp(field,"yaw"))
      return move.yaw;
   if (!dStricmp(field,"pitch"))
      return move.pitch;
   if (!dStricmp(field,"roll"))
      return move.roll;
   return 0;
}


DefineConsoleMethod(AIConnection,setFreeLook,void,(bool isFreeLook), ,"(bool isFreeLook)"
              "Enable/disable freelook on the current move.")
{
   Move move = object->getMove();
   move.freeLook = isFreeLook;
   object->setMove(&move);
}

DefineConsoleMethod(AIConnection, getFreeLook, bool, (), ,"getFreeLook()"
              "Is freelook on for the current move?")
{
   return object->getMove().freeLook;
}


//-----------------------------------------------------------------------------

DefineConsoleMethod(AIConnection,setTrigger,void, (S32 idx, bool set), ,"(int trigger, bool set)"
              "Set a trigger.")
{
   if (idx >= 0 && idx < MaxTriggerKeys)  
   {
      Move move = object->getMove();
      move.trigger[idx] = set;
      object->setMove(&move);
   }
}

DefineConsoleMethod(AIConnection,getTrigger,bool, (S32 idx), ,"(int trigger)"
              "Is the given trigger set?")
{
   if (idx >= 0 && idx < MaxTriggerKeys)
      return object->getMove().trigger[idx];
   return false;
}


//-----------------------------------------------------------------------------

DefineConsoleMethod(AIConnection,getAddress,const char*,(), ,"")
{
   // Override the netConnection method to return to indicate
   // this is an ai connection.
   return "ai:local";
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) S32  __cdecl wle_fn__aiConnect(char * x__a1, char * x__a2, char * x__a3, char * x__a4, char * x__a5, char * x__a6, char * x__a7, char * x__a8, char * x__a9, char * x__a10, char * x__a11, char * x__a12, char * x__a13, char * x__a14, char * x__a15, char * x__a16, char * x__a17, char * x__a18, char * x__a19)
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
if (dStrlen(a4)==0)
if (dStrlen(a3)==0)
argc=3;
else
argc=4;
else
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
if (argc>=3)
arguments.push_back(a2);
if (argc>=4)
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
      AIConnection *aiConnection = new AIConnection();
   aiConnection->registerObject();
      SimGroup *g = Sim::getClientGroup();
   g->addObject( aiConnection );
         const char* args[21];
   args[0] = "onConnect";
   for (S32 i = 1; i < argc; i++)
      args[i + 1] = argv[i];
         Con::execute(aiConnection, argc + 1, args);
  return (S32)( aiConnection->getId());
}
}
;
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_AIConnection_getAddress(char * x__object,  char* retval)
{
dSprintf(retval,16384,"");
AIConnection* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
const char* wle_returnObject;
{
         {wle_returnObject ="ai:local";
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_AIConnection_getFreeLook(char * x__object)
{
AIConnection* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;
bool wle_returnObject;
{
   {wle_returnObject =object->getMove().freeLook;
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_AIConnection_getMove(char * x__object, char * x__field)
{
AIConnection* object; Sim::findObject(x__object, object ); 
if (!object)
	return (F32)( 0);
const char* field = (const char*)x__field;
{
   const Move& move = object->getMove();
   if (!dStricmp(field,"x"))
     return (F32)( move.x);
   if (!dStricmp(field,"y"))
     return (F32)( move.y);
   if (!dStricmp(field,"z"))
     return (F32)( move.z);
   if (!dStricmp(field,"yaw"))
     return (F32)( move.yaw);
   if (!dStricmp(field,"pitch"))
     return (F32)( move.pitch);
   if (!dStricmp(field,"roll"))
     return (F32)( move.roll);
  return (F32)( 0);
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_AIConnection_getTrigger(char * x__object, S32 idx)
{
AIConnection* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;
bool wle_returnObject;
{
   if (idx >= 0 && idx < MaxTriggerKeys)
      {wle_returnObject =object->getMove().trigger[idx];
return (S32)(wle_returnObject);}
   {wle_returnObject =false;
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_AIConnection_setFreeLook(char * x__object, bool isFreeLook)
{
AIConnection* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
{
   Move move = object->getMove();
   move.freeLook = isFreeLook;
   object->setMove(&move);
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_AIConnection_setMove(char * x__object, char * x__field, F32 value)
{
AIConnection* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
const char* field = (const char*)x__field;

{
   Move move = object->getMove();
      if (!dStricmp(field,"x"))
      move.x = mClampF(value,-1,1);
      else
   if (!dStricmp(field,"y"))
      move.y = mClampF(value,-1,1);
      else
   if (!dStricmp(field,"z"))
      move.z = mClampF(value,-1,1);
      else
   if (!dStricmp(field,"yaw"))
      move.yaw = moveClamp(value);
      else
   if (!dStricmp(field,"pitch"))
      move.pitch = moveClamp(value);
      else
   if (!dStricmp(field,"roll"))
      move.roll = moveClamp(value);
      object->setMove(&move);
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_AIConnection_setTrigger(char * x__object, S32 idx, bool set)
{
AIConnection* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;

{
   if (idx >= 0 && idx < MaxTriggerKeys)  
   {
      Move move = object->getMove();
      move.trigger[idx] = set;
      object->setMove(&move);
   }
}
}
//---------------END DNTC AUTO-GENERATED-----------//

