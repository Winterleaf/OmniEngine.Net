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

#include "component/dynamicConsoleMethodComponent.h"

IMPLEMENT_CO_NETOBJECT_V1(DynamicConsoleMethodComponent);

ConsoleDocClass( DynamicConsoleMethodComponent,
				"@brief Console object used for calling methods defined in script, from within other classes.\n\n"
				"Not intended for game development, for editors or internal use only.\n\n "
				"@internal");

//-----------------------------------------------------------
// Function name:  SimComponent::handlesConsoleMethod
// Summary:
//-----------------------------------------------------------
bool DynamicConsoleMethodComponent::handlesConsoleMethod( const char *fname, S32 *routingId )
{
   // CodeReview: Host object is now given priority over components for method
   // redirection. [6/23/2007 Pat]

   // On this object?
   if( isMethod( fname ) )
   {
      *routingId = -1; // -1 denotes method on object
#ifdef TORQUE_DEBUG
      // Inject Method.
      injectMethodCall( fname );
#endif
      return true;
   }

   // on this objects components?
   S32 nI = 0;
   VectorPtr<SimComponent*> &componentList = lockComponentList();
   for( SimComponentIterator nItr = componentList.begin(); nItr != componentList.end(); nItr++, nI++ )
   {
      SimObject *pComponent = dynamic_cast<SimObject*>(*nItr);
      if( pComponent != NULL && pComponent->isMethod( fname ) )
      {
         *routingId = -2; // -2 denotes method on component
         unlockComponentList();

#ifdef TORQUE_DEBUG
         // Inject Method.
         injectMethodCall( fname );
#endif
         return true;
      }
   }
   unlockComponentList();

   return false;
}

const char *DynamicConsoleMethodComponent::callMethod( S32 argc, const char* methodName, ... )
{
   const char *argv[128];
   methodName = StringTable->insert( methodName );

   argc++;

   va_list args;
   va_start(args, methodName);
   for(S32 i = 0; i < argc; i++)
      argv[i+2] = va_arg(args, const char *);
   va_end(args);

   // FIXME: the following seems a little excessive. I wonder why it's needed?
   argv[0] = methodName;
   argv[1] = methodName;
   argv[2] = methodName;

   return callMethodArgList( argc , argv );
}

#ifdef TORQUE_DEBUG
/// Inject Method Call.
void DynamicConsoleMethodComponent::injectMethodCall( const char* method )
{
   // Get Call Method.
   StringTableEntry callMethod = StringTable->insert( method );

   // Find Call Method Metric.
   callMethodMetricType::Iterator itr = mCallMethodMetrics.find( callMethod );

   // Did we find the method?
   if ( itr == mCallMethodMetrics.end() )
   {
      // No, so set the call count to initially be 1.
      itr = mCallMethodMetrics.insert( callMethod, 1 );
   }
   else
   {
      // Increment Call Count.
      itr->value++;
   }
}
#endif

const char* DynamicConsoleMethodComponent::callMethodArgList( U32 argc, const char *argv[], bool callThis /* = true  */ )
{
#ifdef TORQUE_DEBUG
   injectMethodCall( argv[0] );
#endif

   return _callMethod( argc, argv, callThis );
}

// Call all components that implement methodName giving them a chance to operate
// Components are called in reverse order of addition
const char *DynamicConsoleMethodComponent::_callMethod( U32 argc, const char *argv[], bool callThis /* = true  */ )
{
   // Set Owner
   SimObject *pThis = dynamic_cast<SimObject *>( this );
   AssertFatal( pThis, "DynamicConsoleMethodComponent::callMethod : this should always exist!" );

   const char *cbName = StringTable->insert(argv[0]);

   if( getComponentCount() > 0 )
   {
      lockComponentList();
      for( int i = getComponentCount() - 1; i >= 0; i-- )
      //for( SimComponentIterator nItr = componentList.end();  nItr != componentList.begin(); nItr-- )
      {
         argv[0] = cbName;

         SimComponent *pComponent = dynamic_cast<SimComponent *>( getComponent( i ) );
         AssertFatal( pComponent, "DynamicConsoleMethodComponent::callMethod - NULL component in list!" );

         DynamicConsoleMethodComponent *pThisComponent = dynamic_cast<DynamicConsoleMethodComponent*>( pComponent );
         AssertFatal( pThisComponent, "DynamicConsoleMethodComponent::callMethod - Non DynamicConsoleMethodComponent component attempting to callback!");

         // Only call on first depth components
         // Should isMethod check these calls?  [11/22/2006 justind]
         if(pComponent->isEnabled())
            Con::execute( pThisComponent, argc, argv );

         // Bail if this was the first element
         //if( nItr == componentList.begin() )
         //   break;
      }
      unlockComponentList();
   }
   
   // Set Owner Field
   const char* result = "";
   if(callThis)
      result = Con::execute( pThis, argc, argv, true ); // true - exec method onThisOnly, not on DCMCs

   return result;
}

ConsoleMethod( DynamicConsoleMethodComponent, callMethod, void, 3, 64 , "(methodName, argi) Calls script defined method\n"
			  "@param methodName The method's name as a string\n"
			  "@param argi Any arguments to pass to the method\n"
			  "@return No return value"
			  "@note %obj.callMethod( %methodName, %arg1, %arg2, ... );\n")

{
   object->callMethodArgList( argc - 1, argv + 2 );
}

//////////////////////////////////////////////////////////////////////////


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) void  __cdecl wle_fnDynamicConsoleMethodComponent_callMethod(char * x__object, char * x__a2, char * x__a3, char * x__a4, char * x__a5, char * x__a6, char * x__a7, char * x__a8, char * x__a9, char * x__a10, char * x__a11, char * x__a12, char * x__a13, char * x__a14, char * x__a15, char * x__a16, char * x__a17, char * x__a18, char * x__a19, char * x__a20, char * x__a21, char * x__a22, char * x__a23, char * x__a24, char * x__a25, char * x__a26, char * x__a27, char * x__a28, char * x__a29, char * x__a30, char * x__a31, char * x__a32, char * x__a33, char * x__a34, char * x__a35, char * x__a36, char * x__a37, char * x__a38, char * x__a39, char * x__a40, char * x__a41, char * x__a42, char * x__a43, char * x__a44, char * x__a45, char * x__a46, char * x__a47, char * x__a48, char * x__a49, char * x__a50, char * x__a51, char * x__a52, char * x__a53, char * x__a54, char * x__a55, char * x__a56, char * x__a57, char * x__a58, char * x__a59, char * x__a60, char * x__a61, char * x__a62, char * x__a63)
{
DynamicConsoleMethodComponent* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
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
const char* a20 = (const char*)x__a20;
const char* a21 = (const char*)x__a21;
const char* a22 = (const char*)x__a22;
const char* a23 = (const char*)x__a23;
const char* a24 = (const char*)x__a24;
const char* a25 = (const char*)x__a25;
const char* a26 = (const char*)x__a26;
const char* a27 = (const char*)x__a27;
const char* a28 = (const char*)x__a28;
const char* a29 = (const char*)x__a29;
const char* a30 = (const char*)x__a30;
const char* a31 = (const char*)x__a31;
const char* a32 = (const char*)x__a32;
const char* a33 = (const char*)x__a33;
const char* a34 = (const char*)x__a34;
const char* a35 = (const char*)x__a35;
const char* a36 = (const char*)x__a36;
const char* a37 = (const char*)x__a37;
const char* a38 = (const char*)x__a38;
const char* a39 = (const char*)x__a39;
const char* a40 = (const char*)x__a40;
const char* a41 = (const char*)x__a41;
const char* a42 = (const char*)x__a42;
const char* a43 = (const char*)x__a43;
const char* a44 = (const char*)x__a44;
const char* a45 = (const char*)x__a45;
const char* a46 = (const char*)x__a46;
const char* a47 = (const char*)x__a47;
const char* a48 = (const char*)x__a48;
const char* a49 = (const char*)x__a49;
const char* a50 = (const char*)x__a50;
const char* a51 = (const char*)x__a51;
const char* a52 = (const char*)x__a52;
const char* a53 = (const char*)x__a53;
const char* a54 = (const char*)x__a54;
const char* a55 = (const char*)x__a55;
const char* a56 = (const char*)x__a56;
const char* a57 = (const char*)x__a57;
const char* a58 = (const char*)x__a58;
const char* a59 = (const char*)x__a59;
const char* a60 = (const char*)x__a60;
const char* a61 = (const char*)x__a61;
const char* a62 = (const char*)x__a62;
const char* a63 = (const char*)x__a63;
{
S32 argc = 64;
if ( dStrlen(a63) == 0 )
if ( dStrlen(a62) == 0 )
if ( dStrlen(a61) == 0 )
if ( dStrlen(a60) == 0 )
if ( dStrlen(a59) == 0 )
if ( dStrlen(a58) == 0 )
if ( dStrlen(a57) == 0 )
if ( dStrlen(a56) == 0 )
if ( dStrlen(a55) == 0 )
if ( dStrlen(a54) == 0 )
if ( dStrlen(a53) == 0 )
if ( dStrlen(a52) == 0 )
if ( dStrlen(a51) == 0 )
if ( dStrlen(a50) == 0 )
if ( dStrlen(a49) == 0 )
if ( dStrlen(a48) == 0 )
if ( dStrlen(a47) == 0 )
if ( dStrlen(a46) == 0 )
if ( dStrlen(a45) == 0 )
if ( dStrlen(a44) == 0 )
if ( dStrlen(a43) == 0 )
if ( dStrlen(a42) == 0 )
if ( dStrlen(a41) == 0 )
if ( dStrlen(a40) == 0 )
if ( dStrlen(a39) == 0 )
if ( dStrlen(a38) == 0 )
if ( dStrlen(a37) == 0 )
if ( dStrlen(a36) == 0 )
if ( dStrlen(a35) == 0 )
if ( dStrlen(a34) == 0 )
if ( dStrlen(a33) == 0 )
if ( dStrlen(a32) == 0 )
if ( dStrlen(a31) == 0 )
if ( dStrlen(a30) == 0 )
if ( dStrlen(a29) == 0 )
if ( dStrlen(a28) == 0 )
if ( dStrlen(a27) == 0 )
if ( dStrlen(a26) == 0 )
if ( dStrlen(a25) == 0 )
if ( dStrlen(a24) == 0 )
if ( dStrlen(a23) == 0 )
if ( dStrlen(a22) == 0 )
if ( dStrlen(a21) == 0 )
if ( dStrlen(a20) == 0 )
if ( dStrlen(a19) == 0 )
if ( dStrlen(a18) == 0 )
if ( dStrlen(a17) == 0 )
if ( dStrlen(a16) == 0 )
if ( dStrlen(a15) == 0 )
if ( dStrlen(a14) == 0 )
if ( dStrlen(a13) == 0 )
if ( dStrlen(a12) == 0 )
if ( dStrlen(a11) == 0 )
if ( dStrlen(a10) == 0 )
if ( dStrlen(a9) == 0 )
if ( dStrlen(a8) == 0 )
if ( dStrlen(a7) == 0 )
if ( dStrlen(a6) == 0 )
if ( dStrlen(a5) == 0 )
if ( dStrlen(a4) == 0 )
if ( dStrlen(a3) == 0 )
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
else
argc=21;
else
argc=22;
else
argc=23;
else
argc=24;
else
argc=25;
else
argc=26;
else
argc=27;
else
argc=28;
else
argc=29;
else
argc=30;
else
argc=31;
else
argc=32;
else
argc=33;
else
argc=34;
else
argc=35;
else
argc=36;
else
argc=37;
else
argc=38;
else
argc=39;
else
argc=40;
else
argc=41;
else
argc=42;
else
argc=43;
else
argc=44;
else
argc=45;
else
argc=46;
else
argc=47;
else
argc=48;
else
argc=49;
else
argc=50;
else
argc=51;
else
argc=52;
else
argc=53;
else
argc=54;
else
argc=55;
else
argc=56;
else
argc=57;
else
argc=58;
else
argc=59;
else
argc=60;
else
argc=61;
else
argc=62;
else
argc=63;
else
argc=64;
std::vector<const char*> arguments;
arguments.push_back("");
arguments.push_back("");
arguments.push_back(a2);
if ( argc >3 )
arguments.push_back(a3);
if ( argc >4 )
arguments.push_back(a4);
if ( argc >5 )
arguments.push_back(a5);
if ( argc >6 )
arguments.push_back(a6);
if ( argc >7 )
arguments.push_back(a7);
if ( argc >8 )
arguments.push_back(a8);
if ( argc >9 )
arguments.push_back(a9);
if ( argc >10 )
arguments.push_back(a10);
if ( argc >11 )
arguments.push_back(a11);
if ( argc >12 )
arguments.push_back(a12);
if ( argc >13 )
arguments.push_back(a13);
if ( argc >14 )
arguments.push_back(a14);
if ( argc >15 )
arguments.push_back(a15);
if ( argc >16 )
arguments.push_back(a16);
if ( argc >17 )
arguments.push_back(a17);
if ( argc >18 )
arguments.push_back(a18);
if ( argc >19 )
arguments.push_back(a19);
if ( argc >20 )
arguments.push_back(a20);
if ( argc >21 )
arguments.push_back(a21);
if ( argc >22 )
arguments.push_back(a22);
if ( argc >23 )
arguments.push_back(a23);
if ( argc >24 )
arguments.push_back(a24);
if ( argc >25 )
arguments.push_back(a25);
if ( argc >26 )
arguments.push_back(a26);
if ( argc >27 )
arguments.push_back(a27);
if ( argc >28 )
arguments.push_back(a28);
if ( argc >29 )
arguments.push_back(a29);
if ( argc >30 )
arguments.push_back(a30);
if ( argc >31 )
arguments.push_back(a31);
if ( argc >32 )
arguments.push_back(a32);
if ( argc >33 )
arguments.push_back(a33);
if ( argc >34 )
arguments.push_back(a34);
if ( argc >35 )
arguments.push_back(a35);
if ( argc >36 )
arguments.push_back(a36);
if ( argc >37 )
arguments.push_back(a37);
if ( argc >38 )
arguments.push_back(a38);
if ( argc >39 )
arguments.push_back(a39);
if ( argc >40 )
arguments.push_back(a40);
if ( argc >41 )
arguments.push_back(a41);
if ( argc >42 )
arguments.push_back(a42);
if ( argc >43 )
arguments.push_back(a43);
if ( argc >44 )
arguments.push_back(a44);
if ( argc >45 )
arguments.push_back(a45);
if ( argc >46 )
arguments.push_back(a46);
if ( argc >47 )
arguments.push_back(a47);
if ( argc >48 )
arguments.push_back(a48);
if ( argc >49 )
arguments.push_back(a49);
if ( argc >50 )
arguments.push_back(a50);
if ( argc >51 )
arguments.push_back(a51);
if ( argc >52 )
arguments.push_back(a52);
if ( argc >53 )
arguments.push_back(a53);
if ( argc >54 )
arguments.push_back(a54);
if ( argc >55 )
arguments.push_back(a55);
if ( argc >56 )
arguments.push_back(a56);
if ( argc >57 )
arguments.push_back(a57);
if ( argc >58 )
arguments.push_back(a58);
if ( argc >59 )
arguments.push_back(a59);
if ( argc >60 )
arguments.push_back(a60);
if ( argc >61 )
arguments.push_back(a61);
if ( argc >62 )
arguments.push_back(a62);
if ( argc >63 )
arguments.push_back(a63);
const char** argv = &arguments[0];
{
   object->callMethodArgList( argc - 1, argv + 2 );
}
}
}
//---------------END DNTC AUTO-GENERATED-----------//

