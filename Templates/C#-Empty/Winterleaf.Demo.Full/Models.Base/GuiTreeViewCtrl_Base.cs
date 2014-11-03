


#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using System.Threading;
using  WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Demo.Full.Models.User.Extendable;
#endregion

namespace WinterLeaf.Demo.Full.Models.Base
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<GuiTreeViewCtrl_Base>))]
    public partial class GuiTreeViewCtrl_Base: GuiArrayCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTreeViewCtrl_Base ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }
  /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return base.GetHashCode();
            }
  /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            
            return (this._ID ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(GuiTreeViewCtrl_Base ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);

            }


            /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( GuiTreeViewCtrl_Base ts)
            {
            if (object.ReferenceEquals(ts, null))
                 return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiTreeViewCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTreeViewCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTreeViewCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTreeViewCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTreeViewCtrl_Base(int simobjectid)
            {
            return  (GuiTreeViewCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTreeViewCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTreeViewCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTreeViewCtrl_Base(uint simobjectid)
            {
            return  (GuiTreeViewCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTreeViewCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true clicking on a selected item ( that is an object and not the root ) will allow you to rename it. 
/// </summary>
[MemberGroup("Inspector Trees")]
public bool canRenameObjects
       {
       get
          {
          return Omni.self.GetVar(_ID + ".canRenameObjects").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".canRenameObjects", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public bool clearAllOnSingleSelection
       {
       get
          {
          return Omni.self.GetVar(_ID + ".clearAllOnSingleSelection").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".clearAllOnSingleSelection", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Inspector Trees")]
public bool compareToObjectID
       {
       get
          {
          return Omni.self.GetVar(_ID + ".compareToObjectID").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".compareToObjectID", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public bool deleteObjectAllowed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".deleteObjectAllowed").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".deleteObjectAllowed", value.AsString());
          }
       }
/// <summary>
/// If true, the entire tree item hierarchy is deleted when the control goes to sleep. 
/// </summary>
[MemberGroup("TreeView")]
public bool destroyTreeOnSleep
       {
       get
          {
          return Omni.self.GetVar(_ID + ".destroyTreeOnSleep").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".destroyTreeOnSleep", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public bool dragToItemAllowed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dragToItemAllowed").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dragToItemAllowed", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public bool fullRowSelect
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fullRowSelect").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fullRowSelect", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public int itemHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".itemHeight").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".itemHeight", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public bool mouseDragging
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mouseDragging").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mouseDragging", value.AsString());
          }
       }
/// <summary>
/// If true, multiple items can be selected concurrently. 
/// </summary>
[MemberGroup("TreeView")]
public bool multipleSelections
       {
       get
          {
          return Omni.self.GetVar(_ID + ".multipleSelections").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".multipleSelections", value.AsString());
          }
       }
/// <summary>
/// If true then object renaming operates on the internalName rather than the object name. 
/// </summary>
[MemberGroup("Inspector Trees")]
public bool renameInternal
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renameInternal").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renameInternal", value.AsString());
          }
       }
/// <summary>
/// If true, class names will be used as object names for unnamed objects. 
/// </summary>
[MemberGroup("Inspector Trees")]
public bool showClassNameForUnnamedObjects
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showClassNameForUnnamedObjects").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showClassNameForUnnamedObjects", value.AsString());
          }
       }
/// <summary>
/// If true, item text labels for objects will include class names. 
/// </summary>
[MemberGroup("Inspector Trees")]
public bool showClassNames
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showClassNames").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showClassNames", value.AsString());
          }
       }
/// <summary>
/// If true, item text labels for obje ts will include internal names. 
/// </summary>
[MemberGroup("Inspector Trees")]
public bool showInternalNames
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showInternalNames").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showInternalNames", value.AsString());
          }
       }
/// <summary>
/// If true, item text labels for objects will include object IDs. 
/// </summary>
[MemberGroup("Inspector Trees")]
public bool showObjectIds
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showObjectIds").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showObjectIds", value.AsString());
          }
       }
/// <summary>
/// If true, item text labels for objects will include object names. 
/// </summary>
[MemberGroup("Inspector Trees")]
public bool showObjectNames
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showObjectNames").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showObjectNames", value.AsString());
          }
       }
/// <summary>
/// If true, the root item is shown in the tree. 
/// </summary>
[MemberGroup("TreeView")]
public bool showRoot
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showRoot").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showRoot", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public int tabSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tabSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tabSize", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public int textOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textOffset").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textOffset", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public bool tooltipOnWidthOnly
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tooltipOnWidthOnly").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tooltipOnWidthOnly", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("TreeView")]
public bool useInspectorTooltips
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useInspectorTooltips").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useInspectorTooltips", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// addChildSelectionByValue(TreeItemId parent, value))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addChildSelectionByValue(int id, string tableEntry){

pInvokes.m_ts.fn_GuiTreeViewCtrl_addChildSelectionByValue(_ID, id, tableEntry);
}
/// <summary>
/// (builds an icon table))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool buildIconTable(string icons){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_buildIconTable(_ID, icons);
}
/// <summary>
/// Build the visible tree)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void buildVisibleTree(bool forceFullUpdate = false){

pInvokes.m_ts.fn_GuiTreeViewCtrl_buildVisibleTree(_ID, forceFullUpdate);
}
/// <summary>
/// For internal use. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void cancelRename(){

pInvokes.m_ts.fn_GuiTreeViewCtrl_cancelRename(_ID);
}
/// <summary>
/// () - empty tree)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void clear(){

pInvokes.m_ts.fn_GuiTreeViewCtrl_clear(_ID);
}
/// <summary>
/// (TreeItemId item, string newText, string newValue))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool editItem(int item, string newText, string newValue){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_editItem(_ID, item, newText, newValue);
}
/// <summary>
/// (TreeItemId item, bool expand=true))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool expandItem(int id, bool expand = true){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_expandItem(_ID, id, expand);
}
/// <summary>
/// (find item by object id and returns the mId))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findItemByObjectId(int itemId){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_findItemByObjectId(_ID, itemId);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getChild(int itemId){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getChild(_ID, itemId);
}
/// <summary>
/// Get id for root item.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getFirstRootItem(){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getFirstRootItem(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getItemCount(){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getItemCount(_ID);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getItemText(int index){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getItemText(_ID, index);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getItemValue(int itemId){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getItemValue(_ID, itemId);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNextSibling(int itemId){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getNextSibling(_ID, itemId);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getParentItem(int itemId){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getParentItem(_ID, itemId);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getPrevSibling(int itemId){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getPrevSibling(_ID, itemId);
}
/// <summary>
/// ( int index=0 ) - Return the selected item at the given index.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedItem(int index = 0){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getSelectedItem(_ID, index);
}
/// <summary>
/// returns a space seperated list of mulitple item ids)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSelectedItemList(){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getSelectedItemList(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedItemsCount(){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getSelectedItemsCount(_ID);
}
/// <summary>
/// ( int index=0 ) - Return the currently selected SimObject at the given index in inspector mode or -1)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedObject(int index = 0){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getSelectedObject(_ID, index);
}
/// <summary>
/// Returns a space sperated list of all selected object ids.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSelectedObjectList(){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getSelectedObjectList(_ID);
}
/// <summary>
/// (TreeItemId item,Delimiter=none) gets the text from the current node to the root, concatenating at each branch upward, with a specified delimiter optionally)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTextToRoot(int itemId, string delimiter){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_getTextToRoot(_ID, itemId, delimiter);
}
/// <summary>
/// ( int id ) - Returns true if the given item contains child items. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isParentItem(int id){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_isParentItem(_ID, id);
}
/// <summary>
/// (TreeItemId item, bool mark=true))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool markItem(int id, bool mark = true){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_markItem(_ID, id, mark);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void moveItemDown(int index){

pInvokes.m_ts.fn_GuiTreeViewCtrl_moveItemDown(_ID, index);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void moveItemUp(int index){

pInvokes.m_ts.fn_GuiTreeViewCtrl_moveItemUp(_ID, index);
}
/// <summary>
/// For internal use. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void onRenameValidate(){

pInvokes.m_ts.fn_GuiTreeViewCtrl_onRenameValidate(_ID);
}
/// <summary>
/// (SimSet obj, bool okToEdit=true) Set the root of the tree view to the specified object, or to the root set.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void open(string objName, bool okToEdit = true){

pInvokes.m_ts.fn_GuiTreeViewCtrl_open(_ID, objName, okToEdit);
}
/// <summary>
/// removeAllChildren(TreeItemId parent))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeAllChildren(int itemId){

pInvokes.m_ts.fn_GuiTreeViewCtrl_removeAllChildren(_ID, itemId);
}
/// <summary>
/// removeChildSelectionByValue(TreeItemId parent, value))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeChildSelectionByValue(int id, string tableEntry){

pInvokes.m_ts.fn_GuiTreeViewCtrl_removeChildSelectionByValue(_ID, id, tableEntry);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool removeItem(int itemId){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_removeItem(_ID, itemId);
}
/// <summary>
/// (deselects an item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeSelection(int id){

pInvokes.m_ts.fn_GuiTreeViewCtrl_removeSelection(_ID, id);
}
/// <summary>
/// (TreeItemId item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void scrollVisible(int itemId){

pInvokes.m_ts.fn_GuiTreeViewCtrl_scrollVisible(_ID, itemId);
}
/// <summary>
/// (show item by object id. returns true if sucessful.))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int scrollVisibleByObjectId(int itemId){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_scrollVisibleByObjectId(_ID, itemId);
}
/// <summary>
/// (TreeItemId item, bool select=true))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool selectItem(int id, bool select = true){

return pInvokes.m_ts.fn_GuiTreeViewCtrl_selectItem(_ID, id, select);
}
/// <summary>
/// ( bool value=true ) - Enable/disable debug output. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDebug(bool value = true){

pInvokes.m_ts.fn_GuiTreeViewCtrl_setDebug(_ID, value);
}
/// <summary>
/// ( int id, int normalImage, int expandedImage ) - Sets the normal and expanded images to show for the given item. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setItemImages(int id, sbyte normalImage, sbyte expandedImage){

pInvokes.m_ts.fn_GuiTreeViewCtrl_setItemImages(_ID, id, normalImage, expandedImage);
}
/// <summary>
/// ( int id, string text ) - Set the tooltip to show for the given item. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setItemTooltip(int id, string text){

pInvokes.m_ts.fn_GuiTreeViewCtrl_setItemTooltip(_ID, id, text);
}
/// <summary>
/// ( TreeItemId id ) - Show the rename text field for the given item (only one at a time). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void showItemRenameCtrl(int id){

pInvokes.m_ts.fn_GuiTreeViewCtrl_showItemRenameCtrl(_ID, id);
}
/// <summary>
/// ( int parent, bool traverseHierarchy=false, bool parentsFirst=false, bool caseSensitive=true ) - Sorts all items of the given parent (or root).  With 'hierarchy', traverses hierarchy. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sort(int parent = 0, bool traverseHierarchy = false, bool parentsFirst = false, bool caseSensitive = true){

pInvokes.m_ts.fn_GuiTreeViewCtrl_sort(_ID, parent, traverseHierarchy, parentsFirst, caseSensitive);
}
/// <summary>
/// Add an item/object to the current selection.
///    @param id ID of item/object to add to the selection.
///    @param isLastSelection Whether there are more pending items/objects to be added to the selection.  If false, 
///       the control will defer refreshing the tree and wait until addSelection() is called with this parameter set 
///       to true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addSelection(int id, bool isLastSelection = true){

pInvokes.m_ts.fnGuiTreeViewCtrl_addSelection(_ID, id, isLastSelection);
}
/// <summary>
/// Clear the current item filtering pattern.
///    @see setFilterText
///    @see getFilterText )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearFilterText(){

pInvokes.m_ts.fnGuiTreeViewCtrl_clearFilterText(_ID);
}
/// <summary>
/// Unselect all currently selected items. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearSelection(){

pInvokes.m_ts.fnGuiTreeViewCtrl_clearSelection(_ID);
}
/// <summary>
/// Delete all items/objects in the current selection. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteSelection(){

pInvokes.m_ts.fnGuiTreeViewCtrl_deleteSelection(_ID);
}
/// <summary>
/// Get the child item of the given parent item whose text matches @a childName.
///    @param parentId Item ID of the parent in which to look for the child.
///    @param childName Text of the child item to find.
///    @return ID of the child item or -1 if no child in @a parentId has the given text @a childName.
///    @note This method does not recurse, i.e. it only looks for direct children. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findChildItemByName(int parentId, string childName){

return pInvokes.m_ts.fnGuiTreeViewCtrl_findChildItemByName(_ID, parentId, childName);
}
/// <summary>
/// Get the ID of the item whose text matches the given @a text.
///    @param text Item text to match.
///    @return ID of the item or -1 if no item matches the given text. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findItemByName(string text){

return pInvokes.m_ts.fnGuiTreeViewCtrl_findItemByName(_ID, text);
}
/// <summary>
/// Get the ID of the item whose value matches @a value.
///    @param value Value text to match.
///    @return ID of the item or -1 if no item has the given value. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findItemByValue(string value){

return pInvokes.m_ts.fnGuiTreeViewCtrl_findItemByValue(_ID, value);
}
/// <summary>
/// Get the current filter expression.  Only tree items whose text matches this expression 
///    are displayed.  By default, the expression is empty and all items are shown.
///    @return The current filter pattern or an empty string if no filter pattern is currently active.
///    @see setFilterText
///    @see clearFilterText )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getFilterText(){

return pInvokes.m_ts.fnGuiTreeViewCtrl_getFilterText(_ID);
}
/// <summary>
/// Call SimObject::setHidden( @a state ) on all objects in the current selection.
///    @param state Visibility state to set objects in selection to. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void hideSelection(bool state = true){

pInvokes.m_ts.fnGuiTreeViewCtrl_hideSelection(_ID, state);
}
/// <summary>
/// , , 0, 0 ),
///    Add a new item to the tree.
///    @param parentId Item ID of parent to which to add the item as a child.  0 is root item.
///    @param text Text to display on the item in the tree.
///    @param value Behind-the-scenes value of the item.
///    @param icon
///    @param normalImage
///    @param expandedImage
///    @return The ID of the newly added item. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int insertItem(int parentId, string text, string value = "", string icon = "", int normalImage = 0, int expandedImage = 0){

return pInvokes.m_ts.fnGuiTreeViewCtrl_insertItem(_ID, parentId, text, value, icon, normalImage, expandedImage);
}
/// <summary>
/// Inserts object as a child to the given parent. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int insertObject(int parentId, string obj, bool OKToEdit = false){

return pInvokes.m_ts.fnGuiTreeViewCtrl_insertObject(_ID, parentId, obj, OKToEdit);
}
/// <summary>
/// Check whether the given item is currently selected in the tree.
///    @param id Item/object ID.
///    @return True if the given item/object is currently selected in the tree. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isItemSelected(int id){

return pInvokes.m_ts.fnGuiTreeViewCtrl_isItemSelected(_ID, id);
}
/// <summary>
/// Set whether the current selection can be changed by the user or not.
///    @param lock If true, the current selection is frozen and cannot be changed.  If false, 
///       the selection may be modified. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void lockSelection(bool lockx = true){

pInvokes.m_ts.fnGuiTreeViewCtrl_lockSelection(_ID, lockx);
}
/// <summary>
/// Set the pattern by which to filter items in the tree.  Only items in the tree whose text 
///    matches this pattern are displayed.
///    @param pattern New pattern based on which visible items in the tree should be filtered.  If empty, all items become visible.
///    @see getFilterText
///    @see clearFilterText )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFilterText(string pattern){

pInvokes.m_ts.fnGuiTreeViewCtrl_setFilterText(_ID, pattern);
}
/// <summary>
/// Toggle the hidden state of all objects in the current selection. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggleHideSelection(){

pInvokes.m_ts.fnGuiTreeViewCtrl_toggleHideSelection(_ID);
}
/// <summary>
/// Toggle the locked state of all objects in the current selection. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggleLockSelection(){

pInvokes.m_ts.fnGuiTreeViewCtrl_toggleLockSelection(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  bool onDeleteObject(SimObject objectx){return "0".AsBool();}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  bool isValidDragTarget(int id, string value){return "0".AsBool();}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDefineIcons(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAddGroupSelected(SimGroup group){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAddSelection(int itemOrObjectId, bool isLastSelection){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onInspect(int itemOrObjectId){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemoveSelection(int itemOrObjectId){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onUnselect(int itemOrObjectId){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDeleteSelection(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onObjectDeleteCompleted(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onKeyDown(int modifier, int keyCode){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseUp(int hitItemId, int mouseClickCount){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseDragged(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRightMouseUp(int itemId, string mousePos, SimObject objectx){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onBeginReparenting(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEndReparenting(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onReparent(int itemOrObjectId, int oldParentItemOrObjectId, int newParentItemOrObjectId){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDragDropped(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAddMultipleSelectionBegin(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAddMultipleSelectionEnd(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  bool canRenameObject(SimObject objectx){return "0".AsBool();}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  bool handleRenameObject(string newName, SimObject objectx){return "0".AsBool();}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onClearSelection(){}

#endregion
public GuiTreeViewCtrl_Base (){}
}}
