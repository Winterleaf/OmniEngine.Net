


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiGameListMenuCtrl_Base>))]
    public partial class GuiGameListMenuCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiGameListMenuCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiGameListMenuCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiGameListMenuCtrl_Base ts)
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
        public static implicit operator GuiGameListMenuCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiGameListMenuCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGameListMenuCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiGameListMenuCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiGameListMenuCtrl_Base(int simobjectid)
            {
            return  (GuiGameListMenuCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiGameListMenuCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiGameListMenuCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiGameListMenuCtrl_Base(uint simobjectid)
            {
            return  (GuiGameListMenuCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGameListMenuCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Script callback when the 'A' button is pressed. 'A' inputs are Keyboard: A, Return, Space; Gamepad: A, Start 
/// </summary>
[MemberGroup("")]
public String callbackOnA
       {
       get
          {
          return Omni.self.GetVar(_ID + ".callbackOnA").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".callbackOnA", value.AsString());
          }
       }
/// <summary>
/// Script callback when the 'B' button is pressed. 'B' inputs are Keyboard: B, Esc, Backspace, Delete; Gamepad: B, Back 
/// </summary>
[MemberGroup("")]
public String callbackOnB
       {
       get
          {
          return Omni.self.GetVar(_ID + ".callbackOnB").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".callbackOnB", value.AsString());
          }
       }
/// <summary>
/// Script callback when the 'X' button is pressed. 'X' inputs are Keyboard: X; Gamepad: X 
/// </summary>
[MemberGroup("")]
public String callbackOnX
       {
       get
          {
          return Omni.self.GetVar(_ID + ".callbackOnX").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".callbackOnX", value.AsString());
          }
       }
/// <summary>
/// Script callback when the 'Y' button is pressed. 'Y' inputs are Keyboard: Y; Gamepad: Y 
/// </summary>
[MemberGroup("")]
public String callbackOnY
       {
       get
          {
          return Omni.self.GetVar(_ID + ".callbackOnY").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".callbackOnY", value.AsString());
          }
       }
/// <summary>
/// Enable debug rendering 
/// </summary>
[MemberGroup("")]
public bool debugRender
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debugRender").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".debugRender", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Activates the current row. The script callback of  the current row will be called (if it has one). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void activateRow(){

pInvokes.m_ts.fnGuiGameListMenuCtrl_activateRow(_ID);
}
/// <summary>
/// Add a row to the list control.
///    @param label The text to display on the row as a label.
///    @param callback Name of a script function to use as a callback when this row is activated.
///    @param icon [optional] Index of the icon to use as a marker.
///    @param yPad [optional] An extra amount of height padding before the row. Does nothing on the first row.
///    @param useHighlightIcon [optional] Does this row use the highlight icon?.
///    @param enabled [optional] If this row is initially enabled. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addRow(string label, string callback, int icon = -1, int yPad = 0, bool useHighlightIcon = true, bool enabled = true){

pInvokes.m_ts.fnGuiGameListMenuCtrl_addRow(_ID, label, callback, icon, yPad, useHighlightIcon, enabled);
}
/// <summary>
/// Gets the number of rows on the control.
///    @return (int) The number of rows on the control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getRowCount(){

return pInvokes.m_ts.fnGuiGameListMenuCtrl_getRowCount(_ID);
}
/// <summary>
/// Gets the label displayed on the specified row.
///    @param row Index of the row to get the label of.
///    @return The label for the row. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getRowLabel(int row){

return pInvokes.m_ts.fnGuiGameListMenuCtrl_getRowLabel(_ID, row);
}
/// <summary>
/// Gets the index of the currently selected row.
///    @return Index of the selected row. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedRow(){

return pInvokes.m_ts.fnGuiGameListMenuCtrl_getSelectedRow(_ID);
}
/// <summary>
/// Determines if the specified row is enabled or disabled.
///    @param row The row to set the enabled status of.
///    @return True if the specified row is enabled. False if the row is not enabled or the given index was not valid. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isRowEnabled(int row){

return pInvokes.m_ts.fnGuiGameListMenuCtrl_isRowEnabled(_ID, row);
}
/// <summary>
/// Sets a row's enabled status according to the given parameters.
///    @param row The index to check for validity.
///    @param enabled Indicate true to enable the row or false to disable it. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRowEnabled(int row, bool enabled){

pInvokes.m_ts.fnGuiGameListMenuCtrl_setRowEnabled(_ID, row, enabled);
}
/// <summary>
/// Sets the label on the given row.
///    @param row Index of the row to set the label on.
///    @param label Text to set as the label of the row. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRowLabel(int row, string label){

pInvokes.m_ts.fnGuiGameListMenuCtrl_setRowLabel(_ID, row, label);
}
/// <summary>
/// Sets the selected row. Only rows that are enabled can be selected.
///    @param row Index of the row to set as selected. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelected(int row){

pInvokes.m_ts.fnGuiGameListMenuCtrl_setSelected(_ID, row);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the selected row changes. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onChange(){}

#endregion
public GuiGameListMenuCtrl_Base (){}
}}
