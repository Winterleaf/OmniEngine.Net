


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiEaseViewCtrl_Base>))]
    public partial class GuiEaseViewCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEaseViewCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiEaseViewCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiEaseViewCtrl_Base ts)
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
        public static implicit operator GuiEaseViewCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiEaseViewCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiEaseViewCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiEaseViewCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEaseViewCtrl_Base(int simobjectid)
            {
            return  (GuiEaseViewCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiEaseViewCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiEaseViewCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEaseViewCtrl_Base(uint simobjectid)
            {
            return  (GuiEaseViewCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiEaseViewCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public ColorF axisColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".axisColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".axisColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public EaseF ease
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ease").AsEaseF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ease", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public ColorF easeColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".easeColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".easeColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public float easeWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".easeWidth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".easeWidth", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiEaseViewCtrl_Base (){}
}}
