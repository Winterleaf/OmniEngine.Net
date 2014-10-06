


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiContainer_Base>))]
    public partial class GuiContainer_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiContainer_Base ts, string simobjectid)
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
        public static bool operator !=(GuiContainer_Base ts, string simobjectid)
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
        public static implicit operator string( GuiContainer_Base ts)
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
        public static implicit operator GuiContainer_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiContainer_Base) Omni.self.getSimObject(simobjectid,typeof(GuiContainer_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiContainer_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiContainer_Base(int simobjectid)
            {
            return  (GuiContainer) Omni.self.getSimObject((uint)simobjectid,typeof(GuiContainer_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiContainer_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiContainer_Base(uint simobjectid)
            {
            return  (GuiContainer_Base) Omni.self.getSimObject(simobjectid,typeof(GuiContainer_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("Layout")]
public bool anchorBottom
       {
       get
          {
          return Omni.self.GetVar(_ID + ".anchorBottom").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".anchorBottom", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Layout")]
public bool anchorLeft
       {
       get
          {
          return Omni.self.GetVar(_ID + ".anchorLeft").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".anchorLeft", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Layout")]
public bool anchorRight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".anchorRight").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".anchorRight", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Layout")]
public bool anchorTop
       {
       get
          {
          return Omni.self.GetVar(_ID + ".anchorTop").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".anchorTop", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
[MemberGroup("Layout")]
public TypeGuiDockingType docking
       {
       get
          {          return (TypeGuiDockingType) Omni.self.GetVar(_ID + ".docking");
          }
       set
          {
          Omni.self.SetVar(_ID + ".docking", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Layout")]
public RectSpacingI margin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".margin").AsRectSpacingI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".margin", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Layout")]
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

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiContainer_Base (){}
}}
