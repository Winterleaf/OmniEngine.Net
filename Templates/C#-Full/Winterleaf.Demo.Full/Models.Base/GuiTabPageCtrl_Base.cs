


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiTabPageCtrl_Base>))]
    public partial class GuiTabPageCtrl_Base: GuiTextCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTabPageCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTabPageCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiTabPageCtrl_Base ts)
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
        public static implicit operator GuiTabPageCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTabPageCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTabPageCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTabPageCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTabPageCtrl_Base(int simobjectid)
            {
            return  (GuiTabPageCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTabPageCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTabPageCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTabPageCtrl_Base(uint simobjectid)
            {
            return  (GuiTabPageCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTabPageCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Determines whether to resize this page when it is added to the tab book.    If true, the page will be resized according to the tab book extents and    itabPosition/i property. 
/// </summary>
[MemberGroup("")]
public bool fitBook
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fitBook").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fitBook", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Select this page in its tab book. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void select(){

pInvokes.m_ts.fnGuiTabPageCtrl_select(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiTabPageCtrl_Base (){}
}}
