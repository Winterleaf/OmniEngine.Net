


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiSeparatorCtrl_Base>))]
    public partial class GuiSeparatorCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiSeparatorCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiSeparatorCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiSeparatorCtrl_Base ts)
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
        public static implicit operator GuiSeparatorCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiSeparatorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSeparatorCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiSeparatorCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiSeparatorCtrl_Base(int simobjectid)
            {
            return  (GuiSeparatorCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiSeparatorCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiSeparatorCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiSeparatorCtrl_Base(uint simobjectid)
            {
            return  (GuiSeparatorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSeparatorCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public int borderMargin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderMargin").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderMargin", value.AsString());
          }
       }
/// <summary>
/// Optional text label to display. 
/// </summary>
[MemberGroup("")]
public String caption
       {
       get
          {
          return Omni.self.GetVar(_ID + ".caption").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".caption", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool invisible
       {
       get
          {
          return Omni.self.GetVar(_ID + ".invisible").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".invisible", value.AsString());
          }
       }
/// <summary>
/// Left margin of text label. 
/// </summary>
[MemberGroup("")]
public int leftMargin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".leftMargin").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".leftMargin", value.AsString());
          }
       }
/// <summary>
/// Orientation of separator. 
/// </summary>
[MemberGroup("")]
public TypeGuiSeparatorType type
       {
       get
          {          return (TypeGuiSeparatorType) Omni.self.GetVar(_ID + ".type");
          }
       set
          {
          Omni.self.SetVar(_ID + ".type", value.ToString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiSeparatorCtrl_Base (){}
}}
