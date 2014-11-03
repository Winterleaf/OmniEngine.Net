


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiMenuBar_Base>))]
    public partial class GuiMenuBar_Base: GuiTickCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiMenuBar_Base ts, string simobjectid)
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
        public static bool operator !=(GuiMenuBar_Base ts, string simobjectid)
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
        public static implicit operator string( GuiMenuBar_Base ts)
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
        public static implicit operator GuiMenuBar_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiMenuBar_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMenuBar_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiMenuBar_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiMenuBar_Base(int simobjectid)
            {
            return  (GuiMenuBar) Omni.self.getSimObject((uint)simobjectid,typeof(GuiMenuBar_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiMenuBar_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiMenuBar_Base(uint simobjectid)
            {
            return  (GuiMenuBar_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMenuBar_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Extra padding to add to the bounds of the control.\n
/// </summary>
[MemberGroup("")]
public int padding
       {
       get
          {
          return Omni.self.GetVar(_ID + ".padding").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".padding", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Adds a new menu to the menu bar.
///    @param menuText Text to display for the new menu item.
///    @param menuId ID for the new menu item.
///    @tsexample
///    // Define the menu text
///    %menuText = \"New Menu\";
///    // Define the menu ID.
///    %menuId = \"2\";
///    // Inform the GuiMenuBar control to add the new menu
///    %thisGuiMenuBar.addMenu(%menuText,%menuId);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addMenu(string menuText, int menuId){

pInvokes.m_ts.fnGuiMenuBar_addMenu(_ID, menuText, menuId);
}
/// <summary>
/// ,,0,,-1),
///    @brief Adds a menu item to the specified menu.  The menu argument can be either the text of a menu or its id.
///    @param menu Menu name or menu Id to add the new item to.
///    @param menuItemText Text for the new menu item.
///    @param menuItemId Id for the new menu item.
///    @param accelerator Accelerator key for the new menu item.
///    @param checkGroup Check group to include this menu item in.
///    @tsexample
///    // Define the menu we wish to add the item to
///    %targetMenu = \"New Menu\";  or  %menu = \"4\";
///    // Define the text for the new menu item
///    %menuItemText = \"Menu Item\";
///    // Define the id for the new menu item
///    %menuItemId = \"3\";
///    // Set the accelerator key to toggle this menu item with
///    %accelerator = \"n\";
///    // Define the Check Group that this menu item will be in, if we want it to be in a check group. -1 sets it in no check group.
///    %checkGroup = \"4\";
///    // Inform the GuiMenuBar control to add the new menu item with the defined fields
///    %thisGuiMenuBar.addMenuItem(%menu,%menuItemText,%menuItemId,%accelerator,%checkGroup);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addMenuItem(string targetMenu = "", string menuItemText = "", int menuItemId = 0, string accelerator = "", int checkGroup = -1){

pInvokes.m_ts.fnGuiMenuBar_addMenuItem(_ID, targetMenu, menuItemText, menuItemId, accelerator, checkGroup);
}
/// <summary>
/// @brief Adds a menu item to the specified menu.  The menu argument can be either the text of a menu or its id.
///    @param menuTarget Menu to affect a submenu in
///    @param menuItem Menu item to affect
///    @param submenuItemText Text to show for the new submenu
///    @param submenuItemId Id for the new submenu
///    @param accelerator Accelerator key for the new submenu
///    @param checkGroup Which check group the new submenu should be in, or -1 for none.
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Define the text for the new submenu
///    %submenuItemText = \"New Submenu Item\";
///    // Define the id for the new submenu
///    %submenuItemId = \"4\";
///    // Define the accelerator key for the new submenu
///    %accelerator = \"n\";
///    // Define the checkgroup for the new submenu
///    %checkgroup = \"7\";
///    // Request the GuiMenuBar control to add the new submenu with the defined information
///    %thisGuiMenuBar.addSubmenuItem(%menuTarget,%menuItem,%submenuItemText,%submenuItemId,%accelerator,%checkgroup);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addSubmenuItem(string menuTarget, string menuItem, string submenuItemText, int submenuItemId, string accelerator, int checkGroup){

pInvokes.m_ts.fnGuiMenuBar_addSubmenuItem(_ID, menuTarget, menuItem, submenuItemText, submenuItemId, accelerator, checkGroup);
}
/// <summary>
/// @brief Removes all the menu items from the specified menu.
///    @param menuTarget Menu to remove all items from  
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Inform the GuiMenuBar control to clear all menu items from the defined menu
///    %thisGuiMenuBar.clearMenuItems(%menuTarget);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearMenuItems(string menuTarget){

pInvokes.m_ts.fnGuiMenuBar_clearMenuItems(_ID, menuTarget);
}
/// <summary>
/// @brief Clears all the menus from the menu bar.
///    @tsexample
///    // Inform the GuiMenuBar control to clear all menus from itself.
///    %thisGuiMenuBar.clearMenus();
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearMenus(int param1, int param2){

pInvokes.m_ts.fnGuiMenuBar_clearMenus(_ID, param1, param2);
}
/// <summary>
/// @brief Removes all the menu items from the specified submenu.
///    @param menuTarget Menu to affect a submenu in
///    @param menuItem Menu item to affect
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Inform the GuiMenuBar to remove all submenu items from the defined menu item
///    %thisGuiMenuBar.clearSubmenuItems(%menuTarget,%menuItem);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearSubmenuItems(string menuTarget, string menuItem){

pInvokes.m_ts.fnGuiMenuBar_clearSubmenuItems(_ID, menuTarget, menuItem);
}
/// <summary>
/// @brief Removes the specified menu from the menu bar.
///    @param menuTarget Menu to remove from the menu bar  
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Inform the GuiMenuBar to remove the defined menu from the menu bar
///    %thisGuiMenuBar.removeMenu(%menuTarget);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeMenu(string menuTarget){

pInvokes.m_ts.fnGuiMenuBar_removeMenu(_ID, menuTarget);
}
/// <summary>
/// @brief Removes the specified menu item from the menu.
///    @param menuTarget Menu to affect the menu item in
///    @param menuItem Menu item to affect
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Request the GuiMenuBar control to remove the define menu item
///    %thisGuiMenuBar.removeMenuItem(%menuTarget,%menuItem);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeMenuItem(string menuTarget, string menuItemTarget){

pInvokes.m_ts.fnGuiMenuBar_removeMenuItem(_ID, menuTarget, menuItemTarget);
}
/// <summary>
/// @brief Sets the menu bitmap index for the check mark image.
///    @param bitmapIndex Bitmap index for the check mark image.
///    @tsexample
///    // Define the bitmap index
///    %bitmapIndex = \"2\";
///    // Inform the GuiMenuBar control of the proper bitmap index for the check mark image
///    %thisGuiMenuBar.setCheckmarkBitmapIndex(%bitmapIndex);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCheckmarkBitmapIndex(int bitmapindex){

pInvokes.m_ts.fnGuiMenuBar_setCheckmarkBitmapIndex(_ID, bitmapindex);
}
/// <summary>
/// @brief Sets the bitmap index for the menu and toggles rendering only the bitmap.
///    @param menuTarget Menu to affect
///    @param bitmapindex Bitmap index to set for the menu
///    @param bitmaponly If true, only the bitmap will be rendered
///    @param drawborder If true, a border will be drawn around the menu.
///    @tsexample
///    // Define the menuTarget to affect
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Set the bitmap index
///    %bitmapIndex = \"5\";
///    // Set if we are only to render the bitmap or not
///    %bitmaponly = \"true\";
///    // Set if we are rendering a border or not
///    %drawborder = \"true\";
///    // Inform the GuiMenuBar of the bitmap and rendering changes
///    %thisGuiMenuBar.setMenuBitmapIndex(%menuTarget,%bitmapIndex,%bitmapOnly,%drawBorder);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuBitmapIndex(string menuTarget, int bitmapindex, bool bitmaponly, bool drawborder){

pInvokes.m_ts.fnGuiMenuBar_setMenuBitmapIndex(_ID, menuTarget, bitmapindex, bitmaponly, drawborder);
}
/// <summary>
/// @brief Sets the specified menu item bitmap index in the bitmap array.  Setting the item's index to -1 will remove any bitmap.
///    @param menuTarget Menu to affect the menuItem in
///    @param menuItem Menu item to affect
///    @param bitmapIndex Bitmap index to set the menu item to
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"3\";
///    // Define the menuItem\"
///    %menuItem = \"New Menu Item\";  or %menuItem = \"2\";
///    // Define the bitmapIndex
///    %bitmapIndex = \"6\";
///    // Inform the GuiMenuBar control to set the menu item to the defined bitmap
///    %thisGuiMenuBar.setMenuItemBitmap(%menuTarget,%menuItem,%bitmapIndex);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuItemBitmap(string menuTarget, string menuItemTarget, int bitmapIndex){

pInvokes.m_ts.fnGuiMenuBar_setMenuItemBitmap(_ID, menuTarget, menuItemTarget, bitmapIndex);
}
/// <summary>
/// @brief Sets the menu item bitmap to a check mark, which by default is the first element in
///    the bitmap array (although this may be changed with setCheckmarkBitmapIndex()).
///    Any other menu items in the menu with the same check group become unchecked if they are checked.
///    @param menuTarget Menu to work in
///    @param menuItem Menu item to affect
///    @param checked Whether we are setting it to checked or not
///    @tsexample
///    
///    @endtsexample
///    @return If not void, return value and description
///    @see References)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuItemChecked(string menuTarget, string menuItemTarget, bool checkedx){

pInvokes.m_ts.fnGuiMenuBar_setMenuItemChecked(_ID, menuTarget, menuItemTarget, checkedx);
}
/// <summary>
/// @brief sets the menu item to enabled or disabled based on the enable parameter.
///    The specified menu and menu item can either be text or ids.
///    Detailed description
///    @param menuTarget Menu to work in
///    @param menuItemTarget The menu item inside of the menu to enable or disable
///    @param enabled Boolean enable / disable value.
///    @tsexample
///    // Define the menu
///    %menu = \"New Menu\";  or  %menu = \"4\";
///    // Define the menu item
///    %menuItem = \"New Menu Item\";  or %menuItem = \"2\";
///    // Define the enabled state
///    %enabled = \"true\";
///    // Inform the GuiMenuBar control to set the enabled state of the requested menu item
///    %thisGuiMenuBar.setMenuItemEnable(%menu,%menuItme,%enabled);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuItemEnable(string menuTarget, string menuItemTarget, bool enabled){

pInvokes.m_ts.fnGuiMenuBar_setMenuItemEnable(_ID, menuTarget, menuItemTarget, enabled);
}
/// <summary>
/// @brief Sets the given menu item to be a submenu.
///    @param menuTarget Menu to affect a submenu in
///    @param menuItem Menu item to affect
///    @param isSubmenu Whether or not the menuItem will become a subMenu or not
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Define whether or not the Menu Item is a sub menu or not
///    %isSubmenu = \"true\";
///    // Inform the GuiMenuBar control to set the defined menu item to be a submenu or not.
///    %thisGuiMenuBar.setMenuItemSubmenuState(%menuTarget,%menuItem,%isSubmenu);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuItemSubmenuState(string menuTarget, string menuItem, bool isSubmenu){

pInvokes.m_ts.fnGuiMenuBar_setMenuItemSubmenuState(_ID, menuTarget, menuItem, isSubmenu);
}
/// <summary>
/// @brief Sets the text of the specified menu item to the new string.
///    @param menuTarget Menu to affect
///    @param menuItem Menu item in the menu to change the text at
///    @param newMenuItemText New menu text
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"4\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"2\";
///    // Define the new text for the menu item
///    %newMenuItemText = \"Very New Menu Item\";
///    // Inform the GuiMenuBar control to change the defined menu item with the new text
///    %thisGuiMenuBar.setMenuItemText(%menuTarget,%menuItem,%newMenuItemText);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuItemText(string menuTarget, string menuItemTarget, string newMenuItemText){

pInvokes.m_ts.fnGuiMenuBar_setMenuItemText(_ID, menuTarget, menuItemTarget, newMenuItemText);
}
/// <summary>
/// @brief Brief Description.
///    Detailed description
///    @param menuTarget Menu to affect the menu item in
///    @param menuItem Menu item to affect
///    @param isVisible Visible state to set the menu item to.
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"2\";
///    // Define the visibility state
///    %isVisible = \"true\";
///    // Inform the GuiMenuBarControl of the visibility state of the defined menu item
///    %thisGuiMenuBar.setMenuItemVisible(%menuTarget,%menuItem,%isVisible);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuItemVisible(string menuTarget, string menuItemTarget, bool isVisible){

pInvokes.m_ts.fnGuiMenuBar_setMenuItemVisible(_ID, menuTarget, menuItemTarget, isVisible);
}
/// <summary>
/// @brief Sets the menu rendering margins: horizontal, vertical, bitmap spacing.
///    Detailed description
///    @param horizontalMargin Number of pixels on the left and right side of a menu's text.
///    @param verticalMargin Number of pixels on the top and bottom of a menu's text.
///    @param bitmapToTextSpacing Number of pixels between a menu's bitmap and text.
///    @tsexample
///    // Define the horizontalMargin
///    %horizontalMargin = \"5\";
///    // Define the verticalMargin
///    %verticalMargin = \"5\";
///    // Define the bitmapToTextSpacing
///    %bitmapToTextSpacing = \"12\";
///    // Inform the GuiMenuBar control to set its margins based on the defined values.
///    %thisGuiMenuBar.setMenuMargins(%horizontalMargin,%verticalMargin,%bitmapToTextSpacing);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuMargins(int horizontalMargin, int verticalMargin, int bitmapToTextSpacing){

pInvokes.m_ts.fnGuiMenuBar_setMenuMargins(_ID, horizontalMargin, verticalMargin, bitmapToTextSpacing);
}
/// <summary>
/// @brief Sets the text of the specified menu to the new string.
///    @param menuTarget Menu to affect
///    @param newMenuText New menu text
///    @tsexample
///    // Define the menu to affect
///    %menu = \"New Menu\";  or %menu = \"3\";
///    // Define the text to change the menu to
///    %newMenuText = \"Still a New Menu\";
///    // Inform the GuiMenuBar control to change the defined menu to the defined text
///    %thisGuiMenuBar.setMenuText(%menu,%newMenuText);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuText(string menuTarget, string newMenuText){

pInvokes.m_ts.fnGuiMenuBar_setMenuText(_ID, menuTarget, newMenuText);
}
/// <summary>
/// @brief Sets the whether or not to display the specified menu.
///    @param menuTarget Menu item to affect
///    @param visible Whether the menu item will be visible or not
///    @tsexample
///    // Define the menu to work with
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"4\";
///    // Define if the menu should be visible or not
///    %visible = \"true\";
///    // Inform the GuiMenuBar control of the new visibility state for the defined menu
///    %thisGuiMenuBar.setMenuVisible(%menuTarget,%visible);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMenuVisible(string menuTarget, bool visible){

pInvokes.m_ts.fnGuiMenuBar_setMenuVisible(_ID, menuTarget, visible);
}
/// <summary>
/// @brief Sets the menu item bitmap to a check mark, which by default is the first element in the
///    bitmap array (although this may be changed with setCheckmarkBitmapIndex()).
///    Any other menu items in the menu with the same check group become unchecked if they are checked.
///    @param menuTarget Menu to affect a submenu in
///    @param menuItem Menu item to affect
///    @param submenuItemText Text to show for submenu
///    @param checked Whether or not this submenu item will be checked.
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Define the text for the new submenu
///    %submenuItemText = \"Submenu Item\";
///    // Define if this submenu item should be checked or not
///    %checked = \"true\";
///    // Inform the GuiMenuBar control to set the checked state of the defined submenu item
///    %thisGuiMenuBar.setSubmenuItemChecked(%menuTarget,%menuItem,%submenuItemText,%checked);
///    @endtsexample
///    @return If not void, return value and description
///    @see References)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSubmenuItemChecked(string menuTarget, string menuItemTarget, string submenuItemText, bool checkedx){

pInvokes.m_ts.fnGuiMenuBar_setSubmenuItemChecked(_ID, menuTarget, menuItemTarget, submenuItemText, checkedx);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called whenever the mouse enters, or persists is in the menu.   @param isInMenu True if the mouse has entered the menu, otherwise is false.   @note To receive this callback, call setProcessTicks(true) on the menu bar.   @tsexample   // Mouse enters or persists within the menu, causing the callback to occur.   GuiMenuBar::onMouseInMenu(%this,%hasLeftMenu)   {   	// Code to run when the callback occurs   }   @endtsexample   @see GuiTickCtrl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseInMenu(bool isInMenu){}

        /// <summary>
        /// @brief Called whenever a menu is selected.   @param menuId Index id of the clicked menu   @param menuText Text of the clicked menu   @tsexample   // A menu has been selected, causing the callback to occur.   GuiMenuBar::onMenuSelect(%this,%menuId,%menuText)   {   	// Code to run when the callback occurs   }   @endtsexample   @see GuiTickCtrl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMenuSelect(string menuId, string menuText){}

        /// <summary>
        /// @brief Called whenever an item in a menu is selected.   @param menuId Index id of the menu which contains the selected menu item   @param menuText Text of the menu which contains the selected menu item   @param menuItemId Index id of the selected menu item   @param menuItemText Text of the selected menu item   @tsexample   // A menu item has been selected, causing the callback to occur.   GuiMenuBar::onMenuItemSelect(%this,%menuId,%menuText,%menuItemId,%menuItemText)   {   	// Code to run when the callback occurs   }   @endtsexample   @see GuiTickCtrl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMenuItemSelect(string menuId, string menuText, string menuItemId, string menuItemText){}

        /// <summary>
        /// @brief Called whenever a submenu is selected.   @param submenuId Id of the selected submenu   @param submenuText Text of the selected submenu   @tsexample   GuiMenuBar::onSubmenuSelect(%this,%submenuId,%submenuText)   {   	// Code to run when the callback occurs   }   @endtsexample   @see GuiTickCtrl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSubmenuSelect(string submenuId, string submenuText){}

#endregion
public GuiMenuBar_Base (){}
}}
