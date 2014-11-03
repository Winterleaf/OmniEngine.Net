


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiDynamicCtrlArrayControl_Base>))]
    public partial class GuiDynamicCtrlArrayControl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiDynamicCtrlArrayControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiDynamicCtrlArrayControl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiDynamicCtrlArrayControl_Base ts)
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
        public static implicit operator GuiDynamicCtrlArrayControl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiDynamicCtrlArrayControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDynamicCtrlArrayControl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiDynamicCtrlArrayControl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiDynamicCtrlArrayControl_Base(int simobjectid)
            {
            return  (GuiDynamicCtrlArrayControl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiDynamicCtrlArrayControl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiDynamicCtrlArrayControl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiDynamicCtrlArrayControl_Base(uint simobjectid)
            {
            return  (GuiDynamicCtrlArrayControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDynamicCtrlArrayControl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// When true, the cell size is set to the widest/tallest child control. 
/// </summary>
[MemberGroup("")]
public bool autoCellSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".autoCellSize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".autoCellSize", value.AsString());
          }
       }
/// <summary>
/// Number of columns the child controls have been arranged into. This    value is calculated automatically when children are added, removed or    resized; writing it directly has no effect. 
/// </summary>
[MemberGroup("")]
public int colCount
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colCount").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colCount", value.AsString());
          }
       }
/// <summary>
/// Width of each column. If iautoCellSize/i is set, this will be    calculated automatically from the widest child control 
/// </summary>
[MemberGroup("")]
public int colSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colSize", value.AsString());
          }
       }
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
/// If true, the width or height of this control will be automatically    calculated based on the number of child controls (width if    ifillRowFirst/i is false, height if ifillRowFirst/i is true). 
/// </summary>
[MemberGroup("")]
public bool dynamicSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dynamicSize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dynamicSize", value.AsString());
          }
       }
/// <summary>
/// Controls whether rows or columns are filled first.\n\nIf true, controls are    added to the grid left-to-right (to fill a row
/// </summary>
[MemberGroup("")]
public bool fillRowFirst
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fillRowFirst").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fillRowFirst", value.AsString());
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
/// Height of each row. If iautoCellSize/i is set, this will be    calculated automatically from the tallest child control 
/// </summary>
[MemberGroup("")]
public int rowSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rowSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rowSize", value.AsString());
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
/// <summary>
/// Recalculates the position and size of this control and all its children. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void refresh(){

pInvokes.m_ts.fnGuiDynamicCtrlArrayControl_refresh(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiDynamicCtrlArrayControl_Base (){}
}}
