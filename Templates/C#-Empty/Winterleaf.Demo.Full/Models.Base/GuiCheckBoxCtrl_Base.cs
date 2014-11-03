


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiCheckBoxCtrl_Base>))]
    public partial class GuiCheckBoxCtrl_Base: GuiButtonBaseCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiCheckBoxCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiCheckBoxCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiCheckBoxCtrl_Base ts)
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
        public static implicit operator GuiCheckBoxCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiCheckBoxCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiCheckBoxCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiCheckBoxCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiCheckBoxCtrl_Base(int simobjectid)
            {
            return  (GuiCheckBoxCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiCheckBoxCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiCheckBoxCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiCheckBoxCtrl_Base(uint simobjectid)
            {
            return  (GuiCheckBoxCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiCheckBoxCtrl_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Test whether the checkbox is currently checked.
///    @return True if the checkbox is currently ticked, false otherwise. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isStateOn(){

return pInvokes.m_ts.fnGuiCheckBoxCtrl_isStateOn(_ID);
}
/// <summary>
/// Set whether the checkbox is ticked or not.
///    @param newState If true the box will be checked, if false, it will be unchecked.
///    @note This method will @b not trigger the command associated with the control.  To toggle the 
///       checkbox state as if the user had clicked the control, use performClick(). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void setStateOn(bool newState){

pInvokes.m_ts.fnGuiCheckBoxCtrl_setStateOn(_ID, newState);
}

#endregion
#region T3D Callbacks

#endregion
public GuiCheckBoxCtrl_Base (){}
}}
