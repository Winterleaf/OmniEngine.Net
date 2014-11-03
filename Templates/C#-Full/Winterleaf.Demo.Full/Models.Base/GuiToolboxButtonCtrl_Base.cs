


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiToolboxButtonCtrl_Base>))]
    public partial class GuiToolboxButtonCtrl_Base: GuiButtonCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiToolboxButtonCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiToolboxButtonCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiToolboxButtonCtrl_Base ts)
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
        public static implicit operator GuiToolboxButtonCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiToolboxButtonCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiToolboxButtonCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiToolboxButtonCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiToolboxButtonCtrl_Base(int simobjectid)
            {
            return  (GuiToolboxButtonCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiToolboxButtonCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiToolboxButtonCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiToolboxButtonCtrl_Base(uint simobjectid)
            {
            return  (GuiToolboxButtonCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiToolboxButtonCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String hoverBitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hoverBitmap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hoverBitmap", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String loweredBitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".loweredBitmap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".loweredBitmap", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String normalBitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".normalBitmap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".normalBitmap", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ( filepath name ) sets the bitmap that shows when the button is disabled)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setHoverBitmap(string name){

pInvokes.m_ts.fn_GuiToolboxButtonCtrl_setHoverBitmap(_ID, name);
}
/// <summary>
/// ( filepath name ) sets the bitmap that shows when the button is disabled)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setLoweredBitmap(string name){

pInvokes.m_ts.fn_GuiToolboxButtonCtrl_setLoweredBitmap(_ID, name);
}
/// <summary>
/// ( filepath name ) sets the bitmap that shows when the button is active)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNormalBitmap(string name){

pInvokes.m_ts.fn_GuiToolboxButtonCtrl_setNormalBitmap(_ID, name);
}

#endregion
#region T3D Callbacks

#endregion
public GuiToolboxButtonCtrl_Base (){}
}}
