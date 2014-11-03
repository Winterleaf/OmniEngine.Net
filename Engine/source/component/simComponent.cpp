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
#include "console/simObject.h"
#include "console/consoleTypes.h"
#include "component/simComponent.h"
#include "core/stream/stream.h"
#include "console/SimXMLDocument.h" // Copyright (C) 2013 WinterLeaf Entertainment LLC.
#include "console/engineAPI.h"

SimComponent::SimComponent() : mOwner( NULL )
{
   mComponentList.clear();
   mMutex = Mutex::createMutex();
   
   mEnabled = true;
   mTemplate = false;
}

SimComponent::~SimComponent()
{
   Mutex::destroyMutex( mMutex );
   mMutex = NULL;
}

IMPLEMENT_CO_NETOBJECT_V1(SimComponent);

ConsoleDocClass( SimComponent,
				"@brief Legacy component system, soon to be deprecated.\n\n"
				"Not intended for game development, for editors or internal use only.\n\n "
				"@internal");

IMPLEMENT_CALLBACK(SimComponent, onComponentAdd, void, (const char* targetId), (targetId),
   "Called when a component is removed.\n"
   "@targetId target ID\n"
   );

IMPLEMENT_CALLBACK(SimComponent, onComponentRemove, void, (const char* targetId), (targetId),
   "Called when a component is removed.\n"
   "@targetId target ID\n"
   );

bool SimComponent::onAdd()
{
   if( !Parent::onAdd() )
      return false;

   // Register
   _registerInterfaces( this );

   if( !_registerComponents( this ) )
      return false;

   //Con::executef( this, 1, "onAdd" );

   return true;
}

void SimComponent::_registerInterfaces( SimComponent *owner )
{
   // First call this to expose the interfaces that this component will cache
   // before examining the list of subcomponents
   registerInterfaces( owner );

   // Early out to avoid mutex lock and such
   if( !hasComponents() )
      return;

   VectorPtr<SimComponent *> &components = lockComponentList();
   for( SimComponentIterator i = components.begin(); i != components.end(); i++ )
   {
      (*i)->mOwner = owner;

      // Tell the component itself to register it's interfaces
      (*i)->registerInterfaces( owner );

      (*i)->mOwner = NULL; // This tests to see if the object's onComponentRegister call will call up to the parent.

      // Recurse
      (*i)->_registerInterfaces( owner );
   }

   unlockComponentList();
}

bool SimComponent::_registerComponents( SimComponent *owner )
{
   // This method will return true if the object contains no components. See the
   // documentation for SimComponent::onComponentRegister for more information
   // on this behavior.
   bool ret =  true;

   // If this doesn't contain components, don't even lock the list.
   if( hasComponents() )
   {
      VectorPtr<SimComponent *> &components = lockComponentList();
      for( SimComponentIterator i = components.begin(); i != components.end(); i++ )
      {
         if( !(*i)->onComponentRegister( owner ) )
         {
            ret = false;
            break;
         }

         AssertFatal( (*i)->mOwner == owner, "Component failed to call parent onComponentRegister!" );

         // Recurse
         if( !(*i)->_registerComponents( owner ) )
         {
            ret = false;
            break;
         }
      }

      unlockComponentList();
   }

   return ret;
}

void SimComponent::_unregisterComponents()
{
   if( !hasComponents() )
      return;

   VectorPtr<SimComponent *> &components = lockComponentList();
   for( SimComponentIterator i = components.begin(); i != components.end(); i++ )
   {
      (*i)->onComponentUnRegister();

      AssertFatal( (*i)->mOwner == NULL, "Component failed to call parent onUnRegister" );

      // Recurse
      (*i)->_unregisterComponents();
   }

   unlockComponentList();
}

void SimComponent::onRemove()
{
   //Con::executef(this, 1, "onRemove");

   _unregisterComponents();

   // Delete all components
   VectorPtr<SimComponent *>&componentList = lockComponentList();
   while(componentList.size() > 0)
   {
      SimComponent *c = componentList[0];
      componentList.erase( componentList.begin() );

      if( c->isProperlyAdded() )
         c->deleteObject();
      else if( !c->isRemoved() && !c->isDeleted() )
         delete c;
      // else, something else is deleting this, don't mess with it
   }
   unlockComponentList();

   Parent::onRemove();
}

//////////////////////////////////////////////////////////////////////////

bool SimComponent::processArguments(S32 argc, const char **argv)
{
   for(S32 i = 0; i < argc; i++)
   {
      SimComponent *obj = dynamic_cast<SimComponent*> (Sim::findObject(argv[i]) );
      if(obj)
         addComponent(obj);
      else
         Con::printf("SimComponent::processArguments - Invalid Component Object \"%s\"", argv[i]);
   }
   return true;
}

//////////////////////////////////////////////////////////////////////////

void SimComponent::initPersistFields()
{
    addGroup("Component");

        addProtectedField( "Template", TypeBool, Offset(mTemplate, SimComponent), 
           &setIsTemplate, &defaultProtectedGetFn, 
           "Places the object in a component set for later use in new levels." );

    endGroup("Component");

    // Call Parent.
    Parent::initPersistFields();
} 

//------------------------------------------------------------------------------

bool SimComponent::getInterfaces( ComponentInterfaceList *list, const char *type /* = NULL */, const char *name /* = NULL  */,
                                 const SimComponent *owner /* = NULL */, bool notOwner /* = false */ )
{
   AssertFatal( list != NULL, "Passing NULL for a list is not supported functionality for SimComponents." );
   return ( mInterfaceCache.enumerate( list, type, name, owner, notOwner ) > 0 );
}

bool SimComponent::registerCachedInterface( const char *type, const char *name, SimComponent *interfaceOwner, ComponentInterface *cinterface )
{
   if( mInterfaceCache.add( type, name, interfaceOwner, cinterface ) )
   {
      cinterface->mOwner = interfaceOwner;

      // Recurse
      if( mOwner != NULL )
         return mOwner->registerCachedInterface( type, name, interfaceOwner, cinterface );

      return true;
   }

   // So this is not a good assert, because it will get triggered due to the recursive
   // nature of interface caching. I want to keep it here, though, just so nobody
   // else thinks, "Oh I'll add an assert here."
   //
   //AssertFatal( false, avar( "registerCachedInterface failed, probably because interface with type '%s', name '%s' and owner with SimObjectId '%d' already exists",
   //   type, name, interfaceOwner->getId() ) );

   return false;
}

//////////////////////////////////////////////////////////////////////////
// Component Management
//////////////////////////////////////////////////////////////////////////

bool SimComponent::addComponentFromField( void* obj, const char* data )
{
   SimComponent *pComponent = dynamic_cast<SimComponent*>( Sim::findObject( data ) );
   if( pComponent != NULL )
      static_cast<SimComponent*>(obj)->addComponent( pComponent ); 
   return false;
}

// Add Component to this one
bool SimComponent::addComponent( SimComponent *component )
{
   AssertFatal( dynamic_cast<SimObject*>(component), "SimComponent - Cannot add non SimObject derived components!" );

   MutexHandle mh;
   if( mh.lock( mMutex, true ) )
   {
      for( SimComponentIterator nItr = mComponentList.begin(); nItr != mComponentList.end(); nItr++ )
      {
         SimComponent *pComponent = dynamic_cast<SimComponent*>(*nItr);
         AssertFatal( pComponent, "SimComponent::addComponent - NULL component in list!" );
         if( pComponent == component )
            return true;
      }

      if(component->onComponentAdd(this))
      {
         component->mOwner = this;
         mComponentList.push_back( component );
         return true;
      }
   }

   return false;
}

// Remove Component from this one
bool SimComponent::removeComponent( SimComponent *component )
{
   MutexHandle mh;
   if( mh.lock( mMutex, true ) )
   {
      for( SimComponentIterator nItr = mComponentList.begin(); nItr != mComponentList.end(); nItr++ )
      {
         SimComponent *pComponent = dynamic_cast<SimComponent*>(*nItr);
         AssertFatal( pComponent, "SimComponent::removeComponent - NULL component in list!" );
         if( pComponent == component )
         {
            AssertFatal( component->mOwner == this, "Somehow we contain a component who doesn't think we are it's owner." );
            (*nItr)->onComponentRemove(this);
            component->mOwner = NULL;
            mComponentList.erase( nItr );
            return true;
         }
      }
   }
   return false;
}

//////////////////////////////////////////////////////////////////////////

bool SimComponent::onComponentAdd(SimComponent *target)
{
   onComponentAdd_callback(Con::getIntArg(target->getId()));
   return true;
}

void SimComponent::onComponentRemove(SimComponent *target)
{
   onComponentRemove_callback(Con::getIntArg(target->getId()));
}

//////////////////////////////////////////////////////////////////////////

ComponentInterface *SimComponent::getInterface(const char *type /* = NULL */, const char *name /* = NULL */, 
                                               const SimComponent *owner /* = NULL */, bool notOwner /* = false  */)
{
   ComponentInterfaceList iLst;

   if( getInterfaces( &iLst, type, name, owner, notOwner ) )
      return iLst[0];

   return NULL;
}

//////////////////////////////////////////////////////////////////////////

bool SimComponent::writeField(StringTableEntry fieldname, const char* value)
{
   if (!Parent::writeField(fieldname, value))
      return false;

   if( fieldname == StringTable->insert("owner") )
      return false;

   return true;
}

void SimComponent::write(Stream &stream, U32 tabStop, U32 flags /* = 0 */)
{
   MutexHandle handle;
   handle.lock(mMutex); // When this goes out of scope, it will unlock it

   // export selected only?
   if((flags & SelectedOnly) && !isSelected())
   {
      for(U32 i = 0; i < mComponentList.size(); i++)
         mComponentList[i]->write(stream, tabStop, flags);

      return;
   }

   // Copyright (C) 2013 WinterLeaf Entertainment LLC.
   //  @Copyright start
   /// For XML Output
   if( flags & XmlOutput )
   {
	   getcurrentXML()->pushNewElement(getClassName());
	   if(getName())
		   getcurrentXML()->addData(getName());
	   else
		   getcurrentXML()->addData(" ");

	   writeFields( stream, tabStop + 1, true);

	   if(mComponentList.size())
	   {
		  for(U32 i = 0; i < mComponentList.size(); i++)
			 mComponentList[i]->write(stream, tabStop + 1, flags);
	   }
	   getcurrentXML()->popElement();
	   return;
   }

   // @Copyright end
   
   /// For Stream Output
   stream.writeTabs(tabStop);	
   
   char buffer[1024];
   dSprintf(buffer, sizeof(buffer), "new %s(%s) {\r\n", getClassName(), getName() ? getName() : "");
   
   stream.write(dStrlen(buffer), buffer);

   writeFields(stream, tabStop + 1);

   if(mComponentList.size())
   {
      stream.write(2, "\r\n");

      stream.writeTabs(tabStop+1);
      stream.writeLine((U8 *)"// Note: This is a list of behaviors, not arbitrary SimObjects as in a SimGroup or SimSet.\r\n");

      for(U32 i = 0; i < mComponentList.size(); i++)
         mComponentList[i]->write(stream, tabStop + 1, flags);
   }

   stream.writeTabs(tabStop);
   stream.write(4, "};\r\n");
}

//////////////////////////////////////////////////////////////////////////
// Console Methods
//////////////////////////////////////////////////////////////////////////

ConsoleMethod( SimComponent, addComponents, bool, 3, 64, "%obj.addComponents( %compObjName, %compObjName2, ... );\n"
			  "Adds additional components to current list.\n"
			  "@param Up to 62 component names\n"
			  "@return Returns true on success, false otherwise.")
{
   for(S32 i = 2; i < argc; i++)
   {
      SimComponent *obj = dynamic_cast<SimComponent*> (Sim::findObject(argv[i]) );
      if(obj)
         object->addComponent(obj);
      else
         Con::printf("SimComponent::addComponents - Invalid Component Object \"%s\"", argv[i]);
   }
   return true;
}

ConsoleMethod( SimComponent, removeComponents, bool, 3, 64, "%obj.removeComponents( %compObjName, %compObjName2, ... );\n"
			  "Removes components by name from current list.\n"
			  "@param objNamex Up to 62 component names\n"
			  "@return Returns true on success, false otherwise.")
{
   for(S32 i = 2; i < argc; i++)
   {
      SimComponent *obj = dynamic_cast<SimComponent*> (Sim::findObject(argv[i]) );
      if(obj)
         object->removeComponent(obj);
      else
         Con::printf("SimComponent::removeComponents - Invalid Component Object \"%s\"", argv[i]);
   }
   return true;
}

DefineConsoleMethod( SimComponent, getComponentCount, S32, (), , "() Get the current component count\n"
			  "@return The number of components in the list as an integer")
{
   return object->getComponentCount();
}

DefineConsoleMethod( SimComponent, getComponent, S32, (S32 idx), , "(idx) Get the component corresponding to the given index.\n"
			  "@param idx An integer index value corresponding to the desired component.\n"
			  "@return The id of the component at the given index as an integer")
{
   if(idx < 0 || idx >= object->getComponentCount())
   {
      Con::errorf("SimComponent::getComponent - Invalid index %d", idx);
      return 0;
   }

   SimComponent *c = object->getComponent(idx);
   return c ? c->getId() : 0;
}

DefineConsoleMethod(SimComponent, setEnabled, void, (bool enabled), , "(enabled) Sets or unsets the enabled flag\n"
			  "@param enabled Boolean value\n"
			  "@return No return value")
{
   object->setEnabled(enabled);
}

DefineConsoleMethod(SimComponent, isEnabled, bool, (), , "() Check whether SimComponent is currently enabled\n"
			  "@return true if enabled and false if not")
{
   return object->isEnabled();
}

DefineConsoleMethod(SimComponent, setIsTemplate, void, (bool templateFlag), , "(template) Sets or unsets the template flag\n"
			  "@param template Boolean value\n"
			  "@return No return value")
{
   object->setIsTemplate(templateFlag);
}

DefineConsoleMethod(SimComponent, getIsTemplate, bool, (), , "() Check whether SimComponent is currently a template\n"
			  "@return true if is a template and false if not")
{
   return object->getIsTemplate();
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) S32  __cdecl wle_fn_SimComponent_getComponent(char * x__object, S32 idx)
{
SimComponent* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);
{
   if(idx < 0 || idx >= object->getComponentCount())
   {
      Con::errorf("SimComponent::getComponent - Invalid index %d", idx);
     return (S32)( 0);
   }
   SimComponent *c = object->getComponent(idx);
  return (S32)( c ? c->getId() : 0);
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_SimComponent_getComponentCount(char * x__object)
{
SimComponent* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);
{
  return (S32)( object->getComponentCount());
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_SimComponent_getIsTemplate(char * x__object)
{
SimComponent* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;
bool wle_returnObject;
{
   {wle_returnObject =object->getIsTemplate();
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_SimComponent_isEnabled(char * x__object)
{
SimComponent* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;
bool wle_returnObject;
{
   {wle_returnObject =object->isEnabled();
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_SimComponent_setEnabled(char * x__object, bool enabled)
{
SimComponent* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
{
   object->setEnabled(enabled);
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_SimComponent_setIsTemplate(char * x__object, bool templateFlag)
{
SimComponent* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
{
   object->setIsTemplate(templateFlag);
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fnSimComponent_addComponents(char * x__object, char * x__a2, char * x__a3, char * x__a4, char * x__a5, char * x__a6, char * x__a7, char * x__a8, char * x__a9, char * x__a10, char * x__a11, char * x__a12, char * x__a13, char * x__a14, char * x__a15, char * x__a16, char * x__a17, char * x__a18, char * x__a19, char * x__a20, char * x__a21, char * x__a22, char * x__a23, char * x__a24, char * x__a25, char * x__a26, char * x__a27, char * x__a28, char * x__a29, char * x__a30, char * x__a31, char * x__a32, char * x__a33, char * x__a34, char * x__a35, char * x__a36, char * x__a37, char * x__a38, char * x__a39, char * x__a40, char * x__a41, char * x__a42, char * x__a43, char * x__a44, char * x__a45, char * x__a46, char * x__a47, char * x__a48, char * x__a49, char * x__a50, char * x__a51, char * x__a52, char * x__a53, char * x__a54, char * x__a55, char * x__a56, char * x__a57, char * x__a58, char * x__a59, char * x__a60, char * x__a61, char * x__a62, char * x__a63)
{
SimComponent* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;
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
bool wle_returnObject;
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
   for(S32 i = 2; i < argc; i++)
   {
      SimComponent *obj = dynamic_cast<SimComponent*> (Sim::findObject(argv[i]) );
      if(obj)
         object->addComponent(obj);
      else
         Con::printf("SimComponent::addComponents - Invalid Component Object \"%s\"", argv[i]);
   }
   {wle_returnObject =true;
return (S32)(wle_returnObject);}
}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fnSimComponent_removeComponents(char * x__object, char * x__a2, char * x__a3, char * x__a4, char * x__a5, char * x__a6, char * x__a7, char * x__a8, char * x__a9, char * x__a10, char * x__a11, char * x__a12, char * x__a13, char * x__a14, char * x__a15, char * x__a16, char * x__a17, char * x__a18, char * x__a19, char * x__a20, char * x__a21, char * x__a22, char * x__a23, char * x__a24, char * x__a25, char * x__a26, char * x__a27, char * x__a28, char * x__a29, char * x__a30, char * x__a31, char * x__a32, char * x__a33, char * x__a34, char * x__a35, char * x__a36, char * x__a37, char * x__a38, char * x__a39, char * x__a40, char * x__a41, char * x__a42, char * x__a43, char * x__a44, char * x__a45, char * x__a46, char * x__a47, char * x__a48, char * x__a49, char * x__a50, char * x__a51, char * x__a52, char * x__a53, char * x__a54, char * x__a55, char * x__a56, char * x__a57, char * x__a58, char * x__a59, char * x__a60, char * x__a61, char * x__a62, char * x__a63)
{
SimComponent* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;
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
bool wle_returnObject;
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
   for(S32 i = 2; i < argc; i++)
   {
      SimComponent *obj = dynamic_cast<SimComponent*> (Sim::findObject(argv[i]) );
      if(obj)
         object->removeComponent(obj);
      else
         Con::printf("SimComponent::removeComponents - Invalid Component Object \"%s\"", argv[i]);
   }
   {wle_returnObject =true;
return (S32)(wle_returnObject);}
}
}
}
//---------------END DNTC AUTO-GENERATED-----------//

