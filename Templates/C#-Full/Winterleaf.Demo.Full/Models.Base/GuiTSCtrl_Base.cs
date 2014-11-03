


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiTSCtrl_Base>))]
    public partial class GuiTSCtrl_Base: GuiContainer
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTSCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTSCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiTSCtrl_Base ts)
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
        public static implicit operator GuiTSCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTSCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTSCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTSCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTSCtrl_Base(int simobjectid)
            {
            return  (GuiTSCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTSCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTSCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTSCtrl_Base(uint simobjectid)
            {
            return  (GuiTSCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTSCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// . 
/// </summary>
[MemberGroup("Camera")]
public float cameraRoll
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cameraRoll").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cameraRoll", value.AsString());
          }
       }
/// <summary>
/// Z rotation angle of camera. 
/// </summary>
[MemberGroup("Camera")]
public float cameraZRot
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cameraZRot").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cameraZRot", value.AsString());
          }
       }
/// <summary>
/// . 
/// </summary>
[MemberGroup("Camera")]
public bool enableAugmentations
       {
       get
          {
          return Omni.self.GetVar(_ID + ".enableAugmentations").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".enableAugmentations", value.AsString());
          }
       }
/// <summary>
/// . 
/// </summary>
[MemberGroup("Camera")]
public float forceAspect
       {
       get
          {
          return Omni.self.GetVar(_ID + ".forceAspect").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".forceAspect", value.AsString());
          }
       }
/// <summary>
/// The vertical field of view in degrees or zero to use the normal camera FOV. 
/// </summary>
[MemberGroup("Camera")]
public float forceFOV
       {
       get
          {
          return Omni.self.GetVar(_ID + ".forceFOV").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".forceFOV", value.AsString());
          }
       }
/// <summary>
/// . 
/// </summary>
[MemberGroup("Camera")]
public Point4F forceFrustumOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".forceFrustumOffset").AsPoint4F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".forceFrustumOffset", value.AsString());
          }
       }
/// <summary>
/// The share of the per-frame reflection update work this control's rendering should run.\n     The reflect update priorities of all visible GuiTSCtrls are added together and each control is assigned      a share of the per-frame reflection update time according to its percentage of the total priority value. 
/// </summary>
[MemberGroup("Rendering")]
public float reflectPriority
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflectPriority").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflectPriority", value.AsString());
          }
       }
/// <summary>
/// Indicates how this control should render its contents. 
/// </summary>
[MemberGroup("Rendering")]
public TypeGuiTSRenderStyles renderStyle
       {
       get
          {          return (TypeGuiTSRenderStyles) Omni.self.GetVar(_ID + ".renderStyle");
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderStyle", value.ToString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Given the camera's current FOV, get the distance from the camera's viewpoint at which the given radius will fit in the render area.
///    @param radius Radius in world-space units which should fit in the view.
///    @return The distance from the viewpoint at which the given radius would be fully visible. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float calculateViewDistance(float radius){

return pInvokes.m_ts.fnGuiTSCtrl_calculateViewDistance(_ID, radius);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getClickVector(Point2I mousePoint){

return pInvokes.m_ts.fnGuiTSCtrl_getClickVector(_ID, mousePoint.AsString());
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getWorldPosition(Point2I mousePoint){

return pInvokes.m_ts.fnGuiTSCtrl_getWorldPosition(_ID, mousePoint.AsString());
}
/// <summary>
/// Get the ratio between world-space units and pixels.
///    @return The amount of world-space units covered by the extent of a single pixel. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2F getWorldToScreenScale(){

return new Point2F ( pInvokes.m_ts.fnGuiTSCtrl_getWorldToScreenScale(_ID));
}
/// <summary>
/// Transform world-space coordinates to screen-space (x, y, depth) coordinates.
///    @param worldPosition The world-space position to transform to screen-space.
///    @return The  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F project(Point3F worldPosition){

return new Point3F ( pInvokes.m_ts.fnGuiTSCtrl_project(_ID, worldPosition.AsString()));
}
/// <summary>
/// Transform 3D screen-space coordinates (x, y, depth) to world space.
///    This method can be, for example, used to find the world-space position relating to the current mouse cursor position.
///    @param screenPosition The x/y position on the screen plus the depth from the screen-plane outwards.
///    @return The world-space position corresponding to the given screen-space coordinates. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F unproject(Point3F screenPosition){

return new Point3F ( pInvokes.m_ts.fnGuiTSCtrl_unproject(_ID, screenPosition.AsString()));
}

#endregion
#region T3D Callbacks

#endregion
public GuiTSCtrl_Base (){}
}}
