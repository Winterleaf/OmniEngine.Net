


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiShapeNameHud_Base>))]
    public partial class GuiShapeNameHud_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiShapeNameHud_Base ts, string simobjectid)
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
        public static bool operator !=(GuiShapeNameHud_Base ts, string simobjectid)
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
        public static implicit operator string( GuiShapeNameHud_Base ts)
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
        public static implicit operator GuiShapeNameHud_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiShapeNameHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiShapeNameHud_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiShapeNameHud_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiShapeNameHud_Base(int simobjectid)
            {
            return  (GuiShapeNameHud) Omni.self.getSimObject((uint)simobjectid,typeof(GuiShapeNameHud_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiShapeNameHud_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiShapeNameHud_Base(uint simobjectid)
            {
            return  (GuiShapeNameHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiShapeNameHud_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Visibility distance (how far the player must be from the ShapeBase object in focus) for this control to render. 
/// </summary>
[MemberGroup("Misc")]
public float distanceFade
       {
       get
          {
          return Omni.self.GetVar(_ID + ".distanceFade").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".distanceFade", value.AsString());
          }
       }
/// <summary>
/// Standard color for the background of the control. 
/// </summary>
[MemberGroup("Colors")]
public ColorF fillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fillColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fillColor", value.AsString());
          }
       }
/// <summary>
/// Color for the control's frame. 
/// </summary>
[MemberGroup("Colors")]
public ColorF frameColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".frameColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".frameColor", value.AsString());
          }
       }
/// <summary>
/// Color for the background of each shape name label. 
/// </summary>
[MemberGroup("Colors")]
public ColorF labelFillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".labelFillColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".labelFillColor", value.AsString());
          }
       }
/// <summary>
/// Color for the frames around each shape name label. 
/// </summary>
[MemberGroup("Colors")]
public ColorF labelFrameColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".labelFrameColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".labelFrameColor", value.AsString());
          }
       }
/// <summary>
/// The padding (in pixels) between the label text and the frame. 
/// </summary>
[MemberGroup("Misc")]
public Point2I labelPadding
       {
       get
          {
          return Omni.self.GetVar(_ID + ".labelPadding").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".labelPadding", value.AsString());
          }
       }
/// <summary>
/// If true, we draw the background color of the control. 
/// </summary>
[MemberGroup("Misc")]
public bool showFill
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showFill").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showFill", value.AsString());
          }
       }
/// <summary>
/// If true, we draw the frame of the control. 
/// </summary>
[MemberGroup("Misc")]
public bool showFrame
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showFrame").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showFrame", value.AsString());
          }
       }
/// <summary>
/// If true, we draw a background for each shape name label. 
/// </summary>
[MemberGroup("Misc")]
public bool showLabelFill
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showLabelFill").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showLabelFill", value.AsString());
          }
       }
/// <summary>
/// If true, we draw a frame around each shape name label. 
/// </summary>
[MemberGroup("Misc")]
public bool showLabelFrame
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showLabelFrame").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showLabelFrame", value.AsString());
          }
       }
/// <summary>
/// Color for the text on this control. 
/// </summary>
[MemberGroup("Colors")]
public ColorF textColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textColor", value.AsString());
          }
       }
/// <summary>
/// Amount to vertically offset the control in relation to the ShapeBase object in focus. 
/// </summary>
[MemberGroup("Misc")]
public float verticalOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".verticalOffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".verticalOffset", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiShapeNameHud_Base (){}
}}
