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

#include "platform/menus/popupMenu.h"
#include "console/consoleTypes.h"
#include "console/engineAPI.h"
#include "gui/core/guiCanvas.h"
#include "core/util/safeDelete.h"

static U32 sMaxPopupGUID = 0;
PopupMenuEvent PopupMenu::smPopupMenuEvent;
bool PopupMenu::smSelectionEventHandled = false;

/// Event class used to remove popup menus from the event notification in a safe way
class PopUpNotifyRemoveEvent : public SimEvent
{   
public:
   void process(SimObject *object)
   {
      PopupMenu::smPopupMenuEvent.remove((PopupMenu *)object, &PopupMenu::handleSelectEvent);
   }
};

//-----------------------------------------------------------------------------
// Constructor/Destructor
//-----------------------------------------------------------------------------

PopupMenu::PopupMenu() : mCanvas(NULL)
{
   createPlatformPopupMenuData();

   mSubmenus = new SimSet;
   mSubmenus->registerObject();

   mBarTitle = StringTable->insert("");
   mIsPopup = false;

	mPopupGUID = sMaxPopupGUID++;
}

PopupMenu::~PopupMenu()
{
   // This searches the menu bar so is safe to call for menus
   // that aren't on it, since nothing will happen.
   removeFromMenuBar();

   SimSet::iterator i;
   while((i = mSubmenus->begin()) != mSubmenus->end())
   {
      (*i)->deleteObject();
   }

   mSubmenus->deleteObject();
   deletePlatformPopupMenuData();

   PopupMenu::smPopupMenuEvent.remove(this, &PopupMenu::handleSelectEvent);
}

IMPLEMENT_CONOBJECT(PopupMenu);

IMPLEMENT_CALLBACK(PopupMenu, onAdd, void, (), (),"");
IMPLEMENT_CALLBACK(PopupMenu, onRemove, void, (), (),"");
IMPLEMENT_CALLBACK(PopupMenu, onMenuSelect, void, (), (),"");
IMPLEMENT_CALLBACK(PopupMenu, onRemoveFromMenuBar, void, (const char* canvas), (canvas),"");
IMPLEMENT_CALLBACK(PopupMenu, onAttachToMenuBar, void, (const char* canvas, const char* pos, const char* title), (canvas, pos, title),"");
IMPLEMENT_CALLBACK(PopupMenu, onMessageReceived, bool, (const char* queue, const char* event, const char* data), (queue, event, data),"");

IMPLEMENT_CALLBACK(PopupMenu, onSelectItem, bool, (S32 pos,const char* text), (pos, text),"");

ConsoleDocClass( PopupMenu,
   "@brief PopupMenu represents a system menu.\n\n"
   "You can add menu items to the menu, but there is no torque object associated "
   "with these menu items, they exist only in a  platform specific manner.\n\n"
   "@note Internal use only\n\n"
   "@internal"
);


//-----------------------------------------------------------------------------

void PopupMenu::initPersistFields()
{
   addField("isPopup",     TypeBool,         Offset(mIsPopup, PopupMenu),  "true if this is a pop-up/context menu. defaults to false.");
   addField("barTitle",    TypeCaseString,   Offset(mBarTitle, PopupMenu), "the title of this menu when attached to a menu bar");

   Parent::initPersistFields();
}

//-----------------------------------------------------------------------------

bool PopupMenu::onAdd()
{
   if(! Parent::onAdd())
      return false;

   createPlatformMenu();

   onAdd_callback();
   return true;
}

void PopupMenu::onRemove()
{
   onRemove_callback();

   Parent::onRemove();
}

//-----------------------------------------------------------------------------

void PopupMenu::onMenuSelect()
{
   onMenuSelect_callback();
}

//-----------------------------------------------------------------------------

void PopupMenu::handleSelectEvent(U32 popID, U32 command)
{	
	if (popID == mPopupGUID && canHandleID(command))	
		if (handleSelect(command))
			smSelectionEventHandled = true;
}

//-----------------------------------------------------------------------------

void PopupMenu::onAttachToMenuBar(GuiCanvas *canvas, S32 pos, const char *title)
{
   mCanvas = canvas;

	// Attached menus must be notified of menu events
	smPopupMenuEvent.notify(this, &PopupMenu::handleSelectEvent);
   
   // Pass on to sub menus
   for(SimSet::iterator i = mSubmenus->begin();i != mSubmenus->end();++i)
   {
      PopupMenu *mnu = dynamic_cast<PopupMenu *>(*i);
      if(mnu == NULL)
         continue;

      mnu->onAttachToMenuBar(canvas, pos, title);
   }

   // Call script
   if(isProperlyAdded())
   { onAttachToMenuBar_callback( Con::getIntArg(canvas ? canvas->getId() : 0), Con::getIntArg(pos), title); }
      
}

void PopupMenu::onRemoveFromMenuBar(GuiCanvas *canvas)
{
   mCanvas = NULL;

	// We are no longer interested in select events, remove ourselves from the notification list in a safe way
	Sim::postCurrentEvent(this, new PopUpNotifyRemoveEvent());
      
   // Pass on to sub menus
   for(SimSet::iterator i = mSubmenus->begin();i != mSubmenus->end();++i)
   {
      PopupMenu *mnu = dynamic_cast<PopupMenu *>(*i);
      if(mnu == NULL)
         continue;

      mnu->onRemoveFromMenuBar(canvas);
   }

   // Call script
   if(isProperlyAdded())
   { onRemoveFromMenuBar_callback( Con::getIntArg(canvas ? canvas->getId() : 0) ); }
      
}

//-----------------------------------------------------------------------------

bool PopupMenu::onMessageReceived(StringTableEntry queue, const char* event, const char* data)
{
   return onMessageReceived_callback( queue, event, data );
}


bool PopupMenu::onMessageObjectReceived(StringTableEntry queue, Message *msg )
{
   return onMessageReceived_callback( queue, Con::getIntArg(msg->getId()), "" );
}

//-----------------------------------------------------------------------------
// Console Methods
//-----------------------------------------------------------------------------

//ConsoleMethod(PopupMenu, insertItem, S32, 3, 5, "(pos[, title][, accelerator])")
DefineConsoleMethod(PopupMenu, insertItem, S32, (S32 pos, const char * title, const char * accelerator), ("", ""), "(pos[, title][, accelerator])")
{
   //return object->insertItem(dAtoi(argv[2]), argc < 4 ? NULL : argv[3], argc < 5 ? "" : argv[4]);
   return object->insertItem(pos, title, accelerator);
}

//ConsoleMethod(PopupMenu, removeItem, void, 3, 3, "(pos)")
DefineConsoleMethod(PopupMenu, removeItem, void, (S32 pos), , "(pos)")
{
   //object->removeItem(dAtoi(argv[2]));
   object->removeItem(pos);
}

//ConsoleMethod(PopupMenu, insertSubMenu, S32, 5, 5, "(pos, title, subMenu)")
DefineConsoleMethod(PopupMenu, insertSubMenu, S32, (S32 pos, String title, String subMenu), , "(pos, title, subMenu)")
{
   //PopupMenu *mnu = dynamic_cast<PopupMenu *>(Sim::findObject(argv[4]));
   PopupMenu *mnu = dynamic_cast<PopupMenu *>(Sim::findObject(subMenu));
   if(mnu == NULL)
   {
      Con::errorf("PopupMenu::insertSubMenu - Invalid PopupMenu object specified for submenu");
      return -1;
   }
   //return object->insertSubMenu(dAtoi(argv[2]), argv[3], mnu);
   return object->insertSubMenu(pos, title, mnu);
}

//ConsoleMethod(PopupMenu, setItem, bool, 4, 5, "(pos, title[, accelerator])")
DefineConsoleMethod(PopupMenu, setItem, bool, (S32 pos, const char * title, const char * accelerator), (""), "(pos, title[, accelerator])")
{
   //return object->setItem(dAtoi(argv[2]), argv[3], argc < 5 ? "" : argv[4]);
   return object->setItem(pos, title, accelerator);
}

//-----------------------------------------------------------------------------

//ConsoleMethod(PopupMenu, enableItem, void, 4, 4, "(pos, enabled)")
DefineConsoleMethod(PopupMenu, enableItem, void, (S32 pos, bool enabled), , "(pos, enabled)")
{
   //object->enableItem(dAtoi(argv[2]), dAtob(argv[3]));
   object->enableItem(pos, enabled);
}

//ConsoleMethod(PopupMenu, checkItem, void, 4, 4, "(pos, checked)")
DefineConsoleMethod(PopupMenu, checkItem, void, (S32 pos, bool checked), , "(pos, checked)")
{
   //object->checkItem(dAtoi(argv[2]), dAtob(argv[3]));
   object->checkItem(pos, checked);
}

//ConsoleMethod(PopupMenu, checkRadioItem, void, 5, 5, "(firstPos, lastPos, checkPos)")
DefineConsoleMethod(PopupMenu, checkRadioItem, void, (S32 firstPos, S32 lastPos, S32 checkPos), , "(firstPos, lastPos, checkPos)")
{
   //object->checkRadioItem(dAtoi(argv[2]), dAtoi(argv[3]), dAtoi(argv[4]));
   object->checkRadioItem(firstPos, lastPos, checkPos);
}

//ConsoleMethod(PopupMenu, isItemChecked, bool, 3, 3, "(pos)")
DefineConsoleMethod(PopupMenu, isItemChecked, bool, (S32 pos), , "(pos)")
{
   //return object->isItemChecked(dAtoi(argv[2]));
   return object->isItemChecked(pos);
}

//ConsoleMethod(PopupMenu, getItemCount, S32, 2, 2, "()")
DefineConsoleMethod(PopupMenu, getItemCount, S32, (), , "()")
{
   return object->getItemCount();
}

//-----------------------------------------------------------------------------

//ConsoleMethod(PopupMenu, attachToMenuBar, void, 5, 5, "(GuiCanvas, pos, title)")
DefineConsoleMethod(PopupMenu, attachToMenuBar, void, (const char * canvasName, S32 pos, const char * title), , "(GuiCanvas, pos, title)")
{
   //object->attachToMenuBar(dynamic_cast<GuiCanvas*>(Sim::findObject(argv[2])),dAtoi(argv[3]), argv[4]);
   object->attachToMenuBar(dynamic_cast<GuiCanvas*>(Sim::findObject(canvasName)), pos, title);
}

//ConsoleMethod(PopupMenu, removeFromMenuBar, void, 2, 2, "()")
DefineConsoleMethod(PopupMenu, removeFromMenuBar, void, (), , "()")
{
   object->removeFromMenuBar();
}

//-----------------------------------------------------------------------------

//ConsoleMethod(PopupMenu, showPopup, void, 3, 5, "(Canvas,[x, y])")
DefineConsoleMethod(PopupMenu, showPopup, void, (const char * canvasName, S32 x, S32 y), ( -1, -1), "(Canvas,[x, y])")
{
   //GuiCanvas *pCanvas = dynamic_cast<GuiCanvas*>(Sim::findObject(argv[2]));
   GuiCanvas *pCanvas = dynamic_cast<GuiCanvas*>(Sim::findObject(canvasName));
   //S32 x = argc >= 4 ? dAtoi(argv[3]) : -1;
   //S32 y = argc >= 5 ? dAtoi(argv[4]) : -1;
   object->showPopup(pCanvas, x, y);
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) void  __cdecl wle_fn_PopupMenu_attachToMenuBar(char * x__object, char * x__canvasName, S32 pos, char * x__title)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
const char* canvasName = (const char*)x__canvasName;

const char* title = (const char*)x__title;
{
      object->attachToMenuBar(dynamic_cast<GuiCanvas*>(Sim::findObject(canvasName)), pos, title);
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_PopupMenu_checkItem(char * x__object, S32 pos, bool checked)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;

{
      object->checkItem(pos, checked);
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_PopupMenu_checkRadioItem(char * x__object, S32 firstPos, S32 lastPos, S32 checkPos)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;

{
      object->checkRadioItem(firstPos, lastPos, checkPos);
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_PopupMenu_enableItem(char * x__object, S32 pos, bool enabled)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;

{
      object->enableItem(pos, enabled);
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_PopupMenu_getItemCount(char * x__object)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);
{
  return (S32)( object->getItemCount());
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_PopupMenu_insertItem(char * x__object, S32 pos, char * x__title, char * x__accelerator)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);

const char* title = (const char*)x__title;
const char* accelerator = (const char*)x__accelerator;
{
     return (S32)( object->insertItem(pos, title, accelerator));
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_PopupMenu_insertSubMenu(char * x__object, S32 pos, char * x__title, char * x__subMenu)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);

String title = String( x__title);
String subMenu = String( x__subMenu);
{
      PopupMenu *mnu = dynamic_cast<PopupMenu *>(Sim::findObject(subMenu));
   if(mnu == NULL)
   {
      Con::errorf("PopupMenu::insertSubMenu - Invalid PopupMenu object specified for submenu");
     return (S32)( -1);
   }
     return (S32)( object->insertSubMenu(pos, title, mnu));
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_PopupMenu_isItemChecked(char * x__object, S32 pos)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;
bool wle_returnObject;
{
      {wle_returnObject =object->isItemChecked(pos);
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_PopupMenu_removeFromMenuBar(char * x__object)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
{
   object->removeFromMenuBar();
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_PopupMenu_removeItem(char * x__object, S32 pos)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
{
      object->removeItem(pos);
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_PopupMenu_setItem(char * x__object, S32 pos, char * x__title, char * x__accelerator)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;

const char* title = (const char*)x__title;
const char* accelerator = (const char*)x__accelerator;
bool wle_returnObject;
{
      {wle_returnObject =object->setItem(pos, title, accelerator);
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_PopupMenu_showPopup(char * x__object, char * x__canvasName, S32 x, S32 y)
{
PopupMenu* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
const char* canvasName = (const char*)x__canvasName;

{
      GuiCanvas *pCanvas = dynamic_cast<GuiCanvas*>(Sim::findObject(canvasName));
         object->showPopup(pCanvas, x, y);
}
}
//---------------END DNTC AUTO-GENERATED-----------//

