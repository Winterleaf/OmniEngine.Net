


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiCrossHairHud_Base>))]
    public partial class GuiCrossHairHud_Base: GuiBitmapCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiCrossHairHud_Base ts, string simobjectid)
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
        public static bool operator !=(GuiCrossHairHud_Base ts, string simobjectid)
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
        public static implicit operator string( GuiCrossHairHud_Base ts)
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
        public static implicit operator GuiCrossHairHud_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiCrossHairHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiCrossHairHud_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiCrossHairHud_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiCrossHairHud_Base(int simobjectid)
            {
            return  (GuiCrossHairHud) Omni.self.getSimObject((uint)simobjectid,typeof(GuiCrossHairHud_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiCrossHairHud_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiCrossHairHud_Base(uint simobjectid)
            {
            return  (GuiCrossHairHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiCrossHairHud_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// As the health bar depletes, this color will represent the health loss amount. 
/// </summary>
[MemberGroup("Damage")]
public ColorF damageFillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".damageFillColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".damageFillColor", value.AsString());
          }
       }
/// <summary>
/// Color for the health bar's frame. 
/// </summary>
[MemberGroup("Damage")]
public ColorF damageFrameColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".damageFrameColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".damageFrameColor", value.AsString());
          }
       }
/// <summary>
/// Offset for drawing the damage portion of the health control. 
/// </summary>
[MemberGroup("Damage")]
public Point2I damageOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".damageOffset").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".damageOffset", value.AsString());
          }
       }
/// <summary>
/// Size for the health bar portion of the control. 
/// </summary>
[MemberGroup("Damage")]
public Point2I damageRect
       {
       get
          {
          return Omni.self.GetVar(_ID + ".damageRect").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".damageRect", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiCrossHairHud_Base (){}
}}
