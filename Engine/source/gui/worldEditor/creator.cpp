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
#include "console/engineAPI.h"
#include "gui/worldEditor/creator.h"

#include "gfx/gfxDrawUtil.h"


IMPLEMENT_CONOBJECT(CreatorTree);

ConsoleDocClass( CreatorTree,
   "@brief Creator tree from old editor.  Not used in current editor.\n\n"
   "@internal"
);

//------------------------------------------------------------------------------
// Class CreatorTree::Node
//------------------------------------------------------------------------------

CreatorTree::Node::Node() :
   mFlags(0),
   mParent(0),
   mName(0),
   mValue(0),
   mId(0),
   mTab(0)
{
   VECTOR_SET_ASSOCIATION(mChildren);
}

CreatorTree::Node::~Node()
{
   for(U32 i = 0; i < mChildren.size(); i++)
      delete mChildren[i];
}

//------------------------------------------------------------------------------

void CreatorTree::Node::expand(bool exp)
{
   if(exp)
   {
      if(mParent)
         mParent->expand(exp);
      mFlags.set(Node::Expanded);
   }
   else if(!isRoot())
   {
      if(isGroup())
         for(U32 i = 0; i < mChildren.size(); i++)
            mChildren[i]->expand(exp);

      mFlags.clear(Selected);
      mFlags.clear(Expanded);
   }
}

//------------------------------------------------------------------------------

CreatorTree::Node * CreatorTree::Node::find(S32 id)
{
   if(mId == id)
      return(this);

   if(!isGroup())
      return(0);

   for(U32 i = 0; i < mChildren.size(); i++)
   {
      Node * node = mChildren[i]->find(id);
      if(node)
         return(node);
   }

   return(0);
}

//------------------------------------------------------------------------------

bool CreatorTree::Node::isFirst()
{
   AssertFatal(!isRoot(), "CreatorTree::Node::isFirst - cannot call on root node");
   return(this == mParent->mChildren[0]);
}

bool CreatorTree::Node::isLast()
{
   AssertFatal(!isRoot(), "CreatorTree::Node::isLast - cannot call on root node");
   return(this == mParent->mChildren[mParent->mChildren.size()-1]);
}

bool CreatorTree::Node::hasChildItem()
{
   for(U32 i = 0; i < mChildren.size(); i++)
   {
      if(mChildren[i]->isGroup() && mChildren[i]->hasChildItem())
         return(true);

      if(!mChildren[i]->isGroup())
         return(true);
   }

   return(false);
}

S32 CreatorTree::Node::getSelected()
{
   for(U32 i = 0; i < mChildren.size(); i++)
   {
      if(mChildren[i]->isSelected())
         return(mChildren[i]->mId);
      else if(mChildren[i]->isGroup())
      {
         S32 ret = mChildren[i]->getSelected();
         if(ret != -1)
            return(ret);
      }
   }
   return(-1);
}

//------------------------------------------------------------------------------
// Class CreatorTree
//------------------------------------------------------------------------------
CreatorTree::CreatorTree() :
   mCurId(0),
   mTxtOffset(5),
   mRoot(0)
{
   VECTOR_SET_ASSOCIATION(mNodeList);
   clear();
}

CreatorTree::~CreatorTree()
{
   delete mRoot;
}

//------------------------------------------------------------------------------

CreatorTree::Node * CreatorTree::createNode(const char * name, const char * value, bool group, Node * parent)
{
   Node * node = new Node();
   node->mId = mCurId++;
   node->mName = name ? StringTable->insert(name) : 0;
   node->mValue = value ? StringTable->insert(value) : 0;
   node->mFlags.set(Node::Group, group);

   // add to the parent group
   if(parent)
   {
      node->mParent = parent;
      if(!addNode(parent, node))
      {
         delete node;
         return(0);
      }
   }

   return(node);
}

//------------------------------------------------------------------------------

void CreatorTree::clear()
{
   delete mRoot;
   mCurId = 0;
   mRoot = createNode(0, 0, true);
   mRoot->mFlags.set(Node::Root | Node::Expanded);
   mSize = Point2I(1,0);
}

//------------------------------------------------------------------------------

bool CreatorTree::addNode(Node * parent, Node * node)
{
   if(!parent->isGroup())
      return(false);

   //
   parent->mChildren.push_back(node);
   return(true);
}

//------------------------------------------------------------------------------

CreatorTree::Node * CreatorTree::findNode(S32 id)
{
   return(mRoot->find(id));
}

//------------------------------------------------------------------------------

void CreatorTree::sort()
{
   // groups then items by alpha
}

//------------------------------------------------------------------------------
//ConsoleMethod( CreatorTree, addGroup, S32, 4, 4, "(string group, string name, string value)")
DefineConsoleMethod( CreatorTree, addGroup, S32, (S32 group, const char * name, const char * value), , "(string group, string name, string value)")
{
   //CreatorTree::Node * grp = object->findNode(dAtoi(argv[2]));
   CreatorTree::Node * grp = object->findNode(group);

   if(!grp || !grp->isGroup())
      return(-1);

   // return same named group if found...
   for(U32 i = 0; i < grp->mChildren.size(); i++)
      //if(!dStricmp(argv[3], grp->mChildren[i]->mName))
      if(!dStricmp(name, grp->mChildren[i]->mName))
         return(grp->mChildren[i]->mId);

   // CreatorTree::Node * node = object->createNode(argv[3], 0, true, grp);
   CreatorTree::Node * node = object->createNode(name, 0, true, grp);
   object->build();
   return(node ? node->getId() : -1);
}

//ConsoleMethod( CreatorTree, addItem, S32, 5, 5, "(Node group, string name, string value)")
DefineConsoleMethod( CreatorTree, addItem, S32, (S32 group, const char * name, const char * value), , "(Node group, string name, string value)")
{
   //CreatorTree::Node * grp = object->findNode(dAtoi(argv[2]));
   CreatorTree::Node * grp = object->findNode(group);

   if(!grp || !grp->isGroup())
      return -1;

   //CreatorTree::Node * node = object->createNode(argv[3], argv[4], false, grp);
   CreatorTree::Node * node = object->createNode(name, value, false, grp);
   object->build();
   return(node ? node->getId() : -1);
}

//------------------------------------------------------------------------------
//ConsoleMethod( CreatorTree, fileNameMatch, bool, 5, 5, "(string world, string type, string filename)")
DefineConsoleMethod( CreatorTree, fileNameMatch, bool, (const char * world, const char * type, const char * filename), , "(string world, string type, string filename)")
{
   // argv[2] - world short
   // argv[3] - type short
   // argv[4] - filename

   // interior filenames
   // 0     - world short ('b', 'x', ...)
   // 1->   - type short ('towr', 'bunk', ...)
   //U32 typeLen = dStrlen(argv[3]);
   U32 typeLen = dStrlen(type);
   //if(dStrlen(argv[4]) < (typeLen + 1))
   if(dStrlen(filename) < (typeLen + 1))
      return(false);

   // world
   //if(dToupper(argv[4][0]) != dToupper(argv[2][0]))
   if(dToupper(filename[0]) != dToupper(world[0]))
      return(false);

   //return(!dStrnicmp(argv[4]+1, argv[3], typeLen));
   return(!dStrnicmp(filename+1, type, typeLen));
}

//ConsoleMethod( CreatorTree, getSelected, S32, 2, 2, "Return a handle to the currently selected item.")
DefineConsoleMethod( CreatorTree, getSelected, S32, (), , "Return a handle to the currently selected item.")
{
   return(object->getSelected());
}

//ConsoleMethod( CreatorTree, isGroup, bool, 3, 3, "(Group g)")
DefineConsoleMethod( CreatorTree, isGroup, bool, (const char * group), , "(Group g)")
{
   //CreatorTree::Node * node = object->findNode(dAtoi(argv[2]));
   CreatorTree::Node * node = object->findNode(dAtoi(group));
   if(node && node->isGroup())
      return(true);
   return(false);
}

//ConsoleMethod( CreatorTree, getName, const char*, 3, 3, "(Node item)")
DefineConsoleMethod( CreatorTree, getName, const char*, (const char * item), , "(Node item)")
{
   //CreatorTree::Node * node = object->findNode(dAtoi(argv[2]));
   CreatorTree::Node * node = object->findNode(dAtoi(item));
   return(node ? node->mName : 0);
}

//ConsoleMethod( CreatorTree, getValue, const char*, 3, 3, "(Node n)")
DefineConsoleMethod( CreatorTree, getValue, const char*, (S32 nodeValue), , "(Node n)")
{
   //CreatorTree::Node * node = object->findNode(dAtoi(argv[2]));
   CreatorTree::Node * node = object->findNode(nodeValue);
   return(node ? node->mValue : 0);
}

//ConsoleMethod( CreatorTree, clear, void, 2, 2, "Clear the tree.")
DefineConsoleMethod( CreatorTree, clear, void, (), , "Clear the tree.")
{
   object->clear();
}

//ConsoleMethod( CreatorTree, getParent, S32, 3, 3, "(Node n)")
DefineConsoleMethod( CreatorTree, getParent, S32, (S32 nodeValue), , "(Node n)")
{
   //CreatorTree::Node * node = object->findNode(dAtoi(argv[2]));
   CreatorTree::Node * node = object->findNode(nodeValue);
   if(node && node->mParent)
      return(node->mParent->getId());

   return(-1);
}
//------------------------------------------------------------------------------

void CreatorTree::buildNode(Node * node, U32 tab)
{
   if(node->isExpanded())
      for(U32 i = 0; i < node->mChildren.size(); i++)
      {
         Node * child = node->mChildren[i];
         child->mTab = tab;
         child->select(false);
         mNodeList.push_back(child);

         // grab width
         if(bool(mProfile->mFont) && child->mName)
         {
            S32 width = (tab + 1) * mTabSize + mProfile->mFont->getStrWidth(child->mName) + mTxtOffset;
            if(width > mMaxWidth)
               mMaxWidth = width;
         }

         if(node->mChildren[i]->isGroup())
            buildNode(node->mChildren[i], tab+1);
      }
}

//------------------------------------------------------------------------------

void CreatorTree::build()
{
   mMaxWidth = 0;
   mNodeList.clear();
   buildNode(mRoot, 0);
   mCellSize.set( mMaxWidth + 1, 11 );
   setSize(Point2I(1, mNodeList.size()));
}

//------------------------------------------------------------------------------
bool CreatorTree::onWake()
{
   if(!Parent::onWake())
      return(false);

   mTabSize = 11;


   //
   build();
   mCellSize.set( mMaxWidth + 1, 11 );
   setSize(Point2I(1, mNodeList.size()));
   return true;
}

//------------------------------------------------------------------------------

void CreatorTree::onMouseUp(const GuiEvent & event)
{
	onAction();
}

void CreatorTree::onMouseDown(const GuiEvent & event)
{
   Point2I pos = globalToLocalCoord(event.mousePoint);

   bool dblClick = event.mouseClickCount > 1;

   // determine cell
   Point2I cell(pos.x < 0 ? -1 : pos.x / mCellSize.x, pos.y < 0 ? -1 : pos.y / mCellSize.y);
   if(cell.x >= 0 && cell.x < mSize.x && cell.y >= 0 && cell.y < mSize.y)
   {
      Node * node = mNodeList[cell.y];
      S32 offset = mTabSize * node->mTab;
      if(node->isGroup() && node->mChildren.size() && pos.x >= offset && pos.x <= (offset + mTabSize))
      {
         node->expand(!node->isExpanded());
         build();
         dblClick = false;
      }

      if(pos.x >= offset)
      {
         if(dblClick)
            node->expand(!node->isExpanded());
         build();
         node->select(true);
      }
   }
}

//------------------------------------------------------------------------------

void CreatorTree::onMouseDragged(const GuiEvent & event)
{
   TORQUE_UNUSED(event);
}

//------------------------------------------------------------------------------
void CreatorTree::onRenderCell(Point2I offset, Point2I cell, bool, bool) 
{
   Point2I cellOffset = offset;

   Node *node =  mNodeList[cell.y];

   // Get our points
   Point2I boxStart( cellOffset.x + mTabSize * node->mTab, cellOffset.y );

   boxStart.x += 2;
   boxStart.y += 1;

   Point2I boxEnd = Point2I( boxStart );

   boxEnd.x += 8;
   boxEnd.y += 8;

   GFXDrawUtil *drawer = GFX->getDrawUtil();

   // Start drawing stuff
   if( node->isGroup() ) 
   { 
      // If we need a box...
      drawer->drawRectFill( boxStart, boxEnd, mProfile->mFillColor ); // Box background
      drawer->drawRect( boxStart, boxEnd, mProfile->mFontColor );     // Border

      // Cross line
      drawer->drawLine( boxStart.x + 2, boxStart.y + 4, boxStart.x + 7, boxStart.y + 4, mProfile->mFontColor );

      if( !node->isExpanded() ) // If it's a [+] draw down line
         drawer->drawLine( boxStart.x + 4, boxStart.y + 2, boxStart.x + 4, boxStart.y + 7, mProfile->mFontColor );
   }
   else 
   {
      // Draw horizontal line
      drawer->drawLine( boxStart.x + 4, boxStart.y + 4, boxStart.x + 9, boxStart.y + 4, mProfile->mFontColor );

      if( !node->isLast() ) // If it's a continuing one, draw a long down line
         drawer->drawLine( boxStart.x + 4, boxStart.y - 6, boxStart.x + 4, boxStart.y + 10, mProfile->mFontColor );
      else  // Otherwise, just a small one
         drawer->drawLine( boxStart.x + 4, boxStart.y - 2, boxStart.x + 4, boxStart.y + 4, mProfile->mFontColor );
   }

   //draw in all the required continuation lines
   Node *parent = node->mParent;

   while( !parent->isRoot() ) 
   {
      if( !parent->isLast() ) 
      {
         drawer->drawLine( cellOffset.x + ( parent->mTab * mTabSize ) + 6,
                      cellOffset.y - 2,
                      cellOffset.x + ( parent->mTab * mTabSize ) + 6,
                      cellOffset.y + 11,
                      mProfile->mFontColor );
      }
      parent = parent->mParent;
   }

   ColorI fontColor = mProfile->mFontColor;
   if( node->isSelected() )
      fontColor = mProfile->mFontColorHL;
   else if( node->isGroup() && node->hasChildItem() )
      fontColor.set( 128, 0, 0 );
   else if( !node->isGroup() )
      fontColor.set( 0, 0, 128 );

   drawer->setBitmapModulation(fontColor); //node->isSelected() ? mProfile->mFontColorHL : mProfile->mFontColor);
   drawer->drawText( mProfile->mFont,
                Point2I( offset.x + mTxtOffset + mTabSize * ( node->mTab + 1 ), offset.y ),
                node->mName);
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) S32  __cdecl wle_fn_CreatorTree_addGroup(char * x__object, S32 group, char * x__name, char * x__value)
{
CreatorTree* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);

const char* name = (const char*)x__name;
const char* value = (const char*)x__value;
{
      CreatorTree::Node * grp = object->findNode(group);

   if(!grp || !grp->isGroup())
     return (S32)((-1));

      for(U32 i = 0; i < grp->mChildren.size(); i++)
            if(!dStricmp(name, grp->mChildren[i]->mName))
        return (S32)((grp->mChildren[i]->mId));

      CreatorTree::Node * node = object->createNode(name, 0, true, grp);
   object->build();
  return (S32)((node ? node->getId() : -1));
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_CreatorTree_addItem(char * x__object, S32 group, char * x__name, char * x__value)
{
CreatorTree* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);

const char* name = (const char*)x__name;
const char* value = (const char*)x__value;
{
      CreatorTree::Node * grp = object->findNode(group);

   if(!grp || !grp->isGroup())
     return (S32)( -1);

      CreatorTree::Node * node = object->createNode(name, value, false, grp);
   object->build();
  return (S32)((node ? node->getId() : -1));
};
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_CreatorTree_clear(char * x__object)
{
CreatorTree* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
{
   object->clear();
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_CreatorTree_fileNameMatch(char * x__object, char * x__world, char * x__type, char * x__filename)
{
CreatorTree* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;
const char* world = (const char*)x__world;
const char* type = (const char*)x__type;
const char* filename = (const char*)x__filename;
bool wle_returnObject;
{
         
               U32 typeLen = dStrlen(type);
      if(dStrlen(filename) < (typeLen + 1))
      {wle_returnObject =(false);
return (S32)(wle_returnObject);}
         if(dToupper(filename[0]) != dToupper(world[0]))
      {wle_returnObject =(false);
return (S32)(wle_returnObject);}
      {wle_returnObject =(!dStrnicmp(filename+1, type, typeLen));
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_CreatorTree_getName(char * x__object, char * x__item,  char* retval)
{
dSprintf(retval,16384,"");
CreatorTree* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
const char* item = (const char*)x__item;
const char* wle_returnObject;
{
      CreatorTree::Node * node = object->findNode(dAtoi(item));
   {wle_returnObject =(node ? node->mName : 0);
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_CreatorTree_getParent(char * x__object, S32 nodeValue)
{
CreatorTree* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);
{
      CreatorTree::Node * node = object->findNode(nodeValue);
   if(node && node->mParent)
     return (S32)((node->mParent->getId()));

  return (S32)((-1));
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_CreatorTree_getSelected(char * x__object)
{
CreatorTree* object; Sim::findObject(x__object, object ); 
if (!object)
	return (S32)( 0);
{
  return (S32)((object->getSelected()));
};
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_CreatorTree_getValue(char * x__object, S32 nodeValue,  char* retval)
{
dSprintf(retval,16384,"");
CreatorTree* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
const char* wle_returnObject;
{
      CreatorTree::Node * node = object->findNode(nodeValue);
   {wle_returnObject =(node ? node->mValue : 0);
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_CreatorTree_isGroup(char * x__object, char * x__group)
{
CreatorTree* object; Sim::findObject(x__object, object ); 
if (!object)
	 return 0;
const char* group = (const char*)x__group;
bool wle_returnObject;
{
      CreatorTree::Node * node = object->findNode(dAtoi(group));
   if(node && node->isGroup())
      {wle_returnObject =(true);
return (S32)(wle_returnObject);}
   {wle_returnObject =(false);
return (S32)(wle_returnObject);}
}
}
//---------------END DNTC AUTO-GENERATED-----------//

