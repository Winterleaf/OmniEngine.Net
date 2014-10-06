


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiFlexibleArrayControl_Base>))]
    public partial class GuiFlexibleArrayControl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiFlexibleArrayControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiFlexibleArrayControl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiFlexibleArrayControl_Base ts)
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
        public static implicit operator GuiFlexibleArrayControl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiFlexibleArrayControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFlexibleArrayControl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiFlexibleArrayControl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiFlexibleArrayControl_Base(int simobjectid)
            {
            return  (GuiFlexibleArrayControl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiFlexibleArrayControl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiFlexibleArrayControl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiFlexibleArrayControl_Base(uint simobjectid)
            {
            return  (GuiFlexibleArrayControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFlexibleArrayControl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Spacing between columns
/// </summary>
[MemberGroup("")]
public int colSpacing
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colSpacing").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colSpacing", value.AsString());
          }
       }
/// <summary>
/// When true, the array will not update when new children are added or in    response to child resize events. This is useful to prevent unnecessary    resizing when adding, removing or resizing a number of child controls.
/// </summary>
[MemberGroup("")]
public bool frozen
       {
       get
          {
          return Omni.self.GetVar(_ID + ".frozen").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".frozen", value.AsString());
          }
       }
/// <summary>
/// Padding around the top, bottom, left, and right of this control. This    reduces the area available for child controls.
/// </summary>
[MemberGroup("")]
public RectSpacingI padding
       {
       get
          {
          return Omni.self.GetVar(_ID + ".padding").AsRectSpacingI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".padding", value.AsString());
          }
       }
/// <summary>
/// Number of rows the child controls have been arranged into. This value    is calculated automatically when children are added, removed or resized;    writing it directly has no effect.
/// </summary>
[MemberGroup("")]
public int rowCount
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rowCount").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rowCount", value.AsString());
          }
       }
/// <summary>
/// Spacing between rows
/// </summary>
[MemberGroup("")]
public int rowSpacing
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rowSpacing").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rowSpacing", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiFlexibleArrayControl_Base (){}
}}
