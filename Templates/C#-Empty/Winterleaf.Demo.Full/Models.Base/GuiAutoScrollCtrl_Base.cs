


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiAutoScrollCtrl_Base>))]
    public partial class GuiAutoScrollCtrl_Base: GuiTickCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiAutoScrollCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiAutoScrollCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiAutoScrollCtrl_Base ts)
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
        public static implicit operator GuiAutoScrollCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiAutoScrollCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiAutoScrollCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiAutoScrollCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiAutoScrollCtrl_Base(int simobjectid)
            {
            return  (GuiAutoScrollCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiAutoScrollCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiAutoScrollCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiAutoScrollCtrl_Base(uint simobjectid)
            {
            return  (GuiAutoScrollCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiAutoScrollCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Padding to put around child control (in pixels). 
/// </summary>
[MemberGroup("Scrolling")]
public int childBorder
       {
       get
          {
          return Omni.self.GetVar(_ID + ".childBorder").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".childBorder", value.AsString());
          }
       }
/// <summary>
/// If true, the scrolling will reset to the beginning once completing a cycle. 
/// </summary>
[MemberGroup("Scrolling")]
public bool isLooping
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isLooping").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isLooping", value.AsString());
          }
       }
/// <summary>
/// Seconds to wait after scrolling completes before resetting and starting over.\n\n     @note Only takes effect if #isLooping is true. 
/// </summary>
[MemberGroup("Scrolling")]
public float resetDelay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".resetDelay").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".resetDelay", value.AsString());
          }
       }
/// <summary>
/// Direction in which the child control is moved. 
/// </summary>
[MemberGroup("Scrolling")]
public TypeGuiAutoScrollDirection scrollDirection
       {
       get
          {          return (TypeGuiAutoScrollDirection) Omni.self.GetVar(_ID + ".scrollDirection");
          }
       set
          {
          Omni.self.SetVar(_ID + ".scrollDirection", value.ToString());
          }
       }
/// <summary>
/// If true, the child control will be completely scrolled out of sight; otherwise it will only scroll      until the other end becomes visible. 
/// </summary>
[MemberGroup("Scrolling")]
public bool scrollOutOfSight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scrollOutOfSight").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scrollOutOfSight", value.AsString());
          }
       }
/// <summary>
/// Scrolling speed in pixels per second. 
/// </summary>
[MemberGroup("Scrolling")]
public float scrollSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scrollSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scrollSpeed", value.AsString());
          }
       }
/// <summary>
/// Seconds to wait before starting to scroll. 
/// </summary>
[MemberGroup("Scrolling")]
public float startDelay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".startDelay").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".startDelay", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Reset scrolling. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reset(){

pInvokes.m_ts.fnGuiAutoScrollCtrl_reset(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called every 32ms on the control. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTick(){}

        /// <summary>
        /// Called when the control starts to scroll. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onStart(){}

        /// <summary>
        /// Called when the child control has been scrolled in entirety. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onComplete(){}

        /// <summary>
        /// Called when the child control is reset to its initial position and the cycle starts again. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onReset(){}

#endregion
public GuiAutoScrollCtrl_Base (){}
}}
