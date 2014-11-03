


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
    [TypeConverter(typeof(TypeConverterGeneric<EditTSCtrl_Base>))]
    public partial class EditTSCtrl_Base: GuiTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditTSCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(EditTSCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( EditTSCtrl_Base ts)
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
        public static implicit operator EditTSCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (EditTSCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(EditTSCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( EditTSCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditTSCtrl_Base(int simobjectid)
            {
            return  (EditTSCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(EditTSCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( EditTSCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditTSCtrl_Base(uint simobjectid)
            {
            return  (EditTSCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(EditTSCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("BorderMovement")]
public bool allowBorderMove
       {
       get
          {
          return Omni.self.GetVar(_ID + ".allowBorderMove").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".allowBorderMove", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("BorderMovement")]
public int borderMovePixelSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderMovePixelSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderMovePixelSize", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("BorderMovement")]
public float borderMoveSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderMoveSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderMoveSpeed", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public int consoleCircleSegments
       {
       get
          {
          return Omni.self.GetVar(_ID + ".consoleCircleSegments").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".consoleCircleSegments", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public ColorI consoleFillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".consoleFillColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".consoleFillColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public ColorI consoleFrameColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".consoleFrameColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".consoleFrameColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public int consoleLineWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".consoleLineWidth").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".consoleLineWidth", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public int consoleSphereLevel
       {
       get
          {
          return Omni.self.GetVar(_ID + ".consoleSphereLevel").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".consoleSphereLevel", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public GizmoProfile gizmoProfile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gizmoProfile");
          }
       set
          {
          Omni.self.SetVar(_ID + ".gizmoProfile", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Grid")]
public ColorI gridColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Grid")]
public ColorI gridMinorTickColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridMinorTickColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridMinorTickColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Grid")]
public ColorI gridOriginColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridOriginColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridOriginColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Grid")]
public float gridSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridSize", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Mission Area")]
public ColorI missionAreaFillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".missionAreaFillColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".missionAreaFillColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Mission Area")]
public ColorI missionAreaFrameColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".missionAreaFrameColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".missionAreaFrameColor", value.AsString());
          }
       }
/// <summary>
/// How high above and below the terrain to render the mission area bounds. 
/// </summary>
[MemberGroup("Mission Area")]
public float missionAreaHeightAdjust
       {
       get
          {
          return Omni.self.GetVar(_ID + ".missionAreaHeightAdjust").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".missionAreaHeightAdjust", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Mission Area")]
public bool renderMissionArea
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderMissionArea").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderMissionArea", value.AsString());
          }
       }
/// <summary>
/// Whether to render the grid in orthographic axial projections. 
/// </summary>
[MemberGroup("Grid")]
public bool renderOrthoGrid
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderOrthoGrid").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderOrthoGrid", value.AsString());
          }
       }
/// <summary>
/// Grid patch pixel size below which to switch to coarser grid resolutions. 
/// </summary>
[MemberGroup("Grid")]
public float renderOrthoGridPixelBias
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderOrthoGridPixelBias").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderOrthoGridPixelBias", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getDisplayType(){

return pInvokes.m_ts.fnEditTSCtrl_getDisplayType(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getGizmo(){

return pInvokes.m_ts.fnEditTSCtrl_getGizmo(_ID);
}
/// <summary>
/// Return the FOV for orthographic views. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getOrthoFOV(){

return pInvokes.m_ts.fnEditTSCtrl_getOrthoFOV(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isMiddleMouseDown(){

return pInvokes.m_ts.fnEditTSCtrl_isMiddleMouseDown(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void renderBox(Point3F pos, Point3F size){

pInvokes.m_ts.fnEditTSCtrl_renderBox(_ID, pos.AsString(), size.AsString());
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void renderCircle(Point3F pos, Point3F normal, float radius, int segments = 0){

pInvokes.m_ts.fnEditTSCtrl_renderCircle(_ID, pos.AsString(), normal.AsString(), radius, segments);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void renderLine(Point3F start, Point3F end, float lineWidth = 0){

pInvokes.m_ts.fnEditTSCtrl_renderLine(_ID, start.AsString(), end.AsString(), lineWidth);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void renderSphere(Point3F pos, float radius, int sphereLevel = 0){

pInvokes.m_ts.fnEditTSCtrl_renderSphere(_ID, pos.AsString(), radius, sphereLevel);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void renderTriangle(Point3F a, Point3F b, Point3F c){

pInvokes.m_ts.fnEditTSCtrl_renderTriangle(_ID, a.AsString(), b.AsString(), c.AsString());
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDisplayType(int displayType){

pInvokes.m_ts.fnEditTSCtrl_setDisplayType(_ID, displayType);
}
/// <summary>
/// Set the FOV for to use for orthographic views. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setOrthoFOV(float fov){

pInvokes.m_ts.fnEditTSCtrl_setOrthoFOV(_ID, fov);
}

#endregion
#region T3D Callbacks

#endregion
public EditTSCtrl_Base (){}
}}
