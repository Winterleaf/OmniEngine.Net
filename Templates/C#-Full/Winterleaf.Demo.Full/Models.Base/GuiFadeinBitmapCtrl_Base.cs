


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiFadeinBitmapCtrl_Base>))]
    public partial class GuiFadeinBitmapCtrl_Base: GuiBitmapCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiFadeinBitmapCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiFadeinBitmapCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiFadeinBitmapCtrl_Base ts)
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
        public static implicit operator GuiFadeinBitmapCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiFadeinBitmapCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFadeinBitmapCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiFadeinBitmapCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiFadeinBitmapCtrl_Base(int simobjectid)
            {
            return  (GuiFadeinBitmapCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiFadeinBitmapCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiFadeinBitmapCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiFadeinBitmapCtrl_Base(uint simobjectid)
            {
            return  (GuiFadeinBitmapCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFadeinBitmapCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Whether the fade cycle has finished running. 
/// </summary>
[MemberGroup("Fading")]
public bool done
       {
       get
          {
          return Omni.self.GetVar(_ID + ".done").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".done", value.AsString());
          }
       }
/// <summary>
/// Color to fade in from and fade out to. 
/// </summary>
[MemberGroup("Fading")]
public ColorF fadeColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeColor", value.AsString());
          }
       }
/// <summary>
/// Easing curve for fade-in. 
/// </summary>
[MemberGroup("Fading")]
public EaseF fadeInEase
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeInEase").AsEaseF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeInEase", value.AsString());
          }
       }
/// <summary>
/// Milliseconds for the bitmap to fade in. 
/// </summary>
[MemberGroup("Fading")]
public int fadeInTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeInTime").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeInTime", value.AsString());
          }
       }
/// <summary>
/// Easing curve for fade-out. 
/// </summary>
[MemberGroup("Fading")]
public EaseF fadeOutEase
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeOutEase").AsEaseF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeOutEase", value.AsString());
          }
       }
/// <summary>
/// Milliseconds for the bitmap to fade out. 
/// </summary>
[MemberGroup("Fading")]
public int fadeOutTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeOutTime").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeOutTime", value.AsString());
          }
       }
/// <summary>
/// Milliseconds to wait after fading in before fading out the bitmap. 
/// </summary>
[MemberGroup("Fading")]
public int waitTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".waitTime").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".waitTime", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Informs the script level that this object received a Click event from the cursor or keyboard.   @tsexample   GuiFadeInBitmapCtrl::click(%this)   	{   		// Code to run when click occurs   	}   @endtsexample   @see GuiCore)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void click(){}

        /// <summary>
        /// @brief Informs the script level that this object has completed is fade cycle.   @tsexample   GuiFadeInBitmapCtrl::onDone(%this)   	{   		// Code to run when the fade cycle completes   	}   @endtsexample   @see GuiCore)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDone(){}

#endregion
public GuiFadeinBitmapCtrl_Base (){}
}}
