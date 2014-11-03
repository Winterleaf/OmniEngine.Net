


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiCursor_Base>))]
    public partial class GuiCursor_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiCursor_Base ts, string simobjectid)
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
        public static bool operator !=(GuiCursor_Base ts, string simobjectid)
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
        public static implicit operator string( GuiCursor_Base ts)
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
        public static implicit operator GuiCursor_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiCursor_Base) Omni.self.getSimObject(simobjectid,typeof(GuiCursor_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiCursor_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiCursor_Base(int simobjectid)
            {
            return  (GuiCursor) Omni.self.getSimObject((uint)simobjectid,typeof(GuiCursor_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiCursor_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiCursor_Base(uint simobjectid)
            {
            return  (GuiCursor_Base) Omni.self.getSimObject(simobjectid,typeof(GuiCursor_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// File name of the bitmap for the cursor.
/// </summary>
[MemberGroup("")]
public String bitmapName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bitmapName").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bitmapName", value.AsString());
          }
       }
/// <summary>
/// The location of the cursor's hot spot (which pixel carries the click).
/// </summary>
[MemberGroup("")]
public Point2I hotSpot
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hotSpot").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hotSpot", value.AsString());
          }
       }
/// <summary>
/// Offset of the bitmap, where 0 signifies left edge of the bitmap, 1, the right. Similarly for the Y-component.
/// </summary>
[MemberGroup("")]
public Point2F renderOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderOffset").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderOffset", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiCursor_Base (){}
}}
