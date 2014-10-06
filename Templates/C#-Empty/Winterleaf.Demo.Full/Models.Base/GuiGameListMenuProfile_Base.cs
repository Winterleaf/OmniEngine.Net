


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiGameListMenuProfile_Base>))]
    public partial class GuiGameListMenuProfile_Base: GuiControlProfile
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiGameListMenuProfile_Base ts, string simobjectid)
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
        public static bool operator !=(GuiGameListMenuProfile_Base ts, string simobjectid)
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
        public static implicit operator string( GuiGameListMenuProfile_Base ts)
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
        public static implicit operator GuiGameListMenuProfile_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiGameListMenuProfile_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGameListMenuProfile_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiGameListMenuProfile_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiGameListMenuProfile_Base(int simobjectid)
            {
            return  (GuiGameListMenuProfile) Omni.self.getSimObject((uint)simobjectid,typeof(GuiGameListMenuProfile_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiGameListMenuProfile_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiGameListMenuProfile_Base(uint simobjectid)
            {
            return  (GuiGameListMenuProfile_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGameListMenuProfile_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Position of the lower right corner of the row hit area (relative to row's top left corner) 
/// </summary>
[MemberGroup("")]
public Point2I hitAreaLowerRight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hitAreaLowerRight").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hitAreaLowerRight", value.AsString());
          }
       }
/// <summary>
/// Position of the upper left corner of the row hit area (relative to row's top left corner) 
/// </summary>
[MemberGroup("")]
public Point2I hitAreaUpperLeft
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hitAreaUpperLeft").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hitAreaUpperLeft", value.AsString());
          }
       }
/// <summary>
/// Offset from the row's top left corner at which to render the row icon 
/// </summary>
[MemberGroup("")]
public Point2I iconOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".iconOffset").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".iconOffset", value.AsString());
          }
       }
/// <summary>
/// The base size (\width height\) of a row 
/// </summary>
[MemberGroup("")]
public Point2I rowSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rowSize").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rowSize", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiGameListMenuProfile_Base (){}
}}
