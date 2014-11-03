


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiGameListOptionsCtrl_Base>))]
    public partial class GuiGameListOptionsCtrl_Base: GuiGameListMenuCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiGameListOptionsCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiGameListOptionsCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiGameListOptionsCtrl_Base ts)
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
        public static implicit operator GuiGameListOptionsCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiGameListOptionsCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGameListOptionsCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiGameListOptionsCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiGameListOptionsCtrl_Base(int simobjectid)
            {
            return  (GuiGameListOptionsCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiGameListOptionsCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiGameListOptionsCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiGameListOptionsCtrl_Base(uint simobjectid)
            {
            return  (GuiGameListOptionsCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGameListOptionsCtrl_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Add a row to the list control.
///    @param label The text to display on the row as a label.
///    @param options A tab separated list of options.
///    @param wrapOptions Specify true to allow options to wrap at each end or false to prevent wrapping.
///    @param callback Name of a script function to use as a callback when this row is activated.
///    @param icon [optional] Index of the icon to use as a marker.
///    @param yPad [optional] An extra amount of height padding before the row. Does nothing on the first row.
///    @param enabled [optional] If this row is initially enabled. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addRow(string label, string options, bool wrapOptions, string callback, int icon = -1, int yPad = 0, bool enabled = true){

pInvokes.m_ts.fnGuiGameListOptionsCtrl_addRow(_ID, label, options, wrapOptions, callback, icon, yPad, enabled);
}
/// <summary>
/// Gets the text for the currently selected option of the given row.
///    @param row Index of the row to get the option from.
///    @return A string representing the text currently displayed as the selected option on the given row. If there is no such displayed text then the empty string is returned. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getCurrentOption(int row){

return pInvokes.m_ts.fnGuiGameListOptionsCtrl_getCurrentOption(_ID, row);
}
/// <summary>
/// Set the row's current option to the one specified
///    @param row Index of the row to set an option on.
///    @param option The option to be made active.
///    @return True if the row contained the option and was set, false otherwise. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool selectOption(int row, string option){

return pInvokes.m_ts.fnGuiGameListOptionsCtrl_selectOption(_ID, row, option);
}
/// <summary>
/// Sets the list of options on the given row.
///    @param row Index of the row to set options on.
///    @param optionsList A tab separated list of options for the control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setOptions(int row, string optionsList){

pInvokes.m_ts.fnGuiGameListOptionsCtrl_setOptions(_ID, row, optionsList);
}

#endregion
#region T3D Callbacks

#endregion
public GuiGameListOptionsCtrl_Base (){}
}}
