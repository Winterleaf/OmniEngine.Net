


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
    [TypeConverter(typeof(TypeConverterGeneric<WorldEditor_Base>))]
    public partial class WorldEditor_Base: EditTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WorldEditor_Base ts, string simobjectid)
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
        public static bool operator !=(WorldEditor_Base ts, string simobjectid)
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
        public static implicit operator string( WorldEditor_Base ts)
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
        public static implicit operator WorldEditor_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (WorldEditor_Base) Omni.self.getSimObject(simobjectid,typeof(WorldEditor_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( WorldEditor_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WorldEditor_Base(int simobjectid)
            {
            return  (WorldEditor) Omni.self.getSimObject((uint)simobjectid,typeof(WorldEditor_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( WorldEditor_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WorldEditor_Base(uint simobjectid)
            {
            return  (WorldEditor_Base) Omni.self.getSimObject(simobjectid,typeof(WorldEditor_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("Selections")]
public bool boundingBoxCollision
       {
       get
          {
          return Omni.self.GetVar(_ID + ".boundingBoxCollision").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".boundingBoxCollision", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Rendering")]
public String defaultHandle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".defaultHandle").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".defaultHandle", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Colors")]
public ColorI dragRectColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dragRectColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dragRectColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Dropping")]
public bool dropAtBounds
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dropAtBounds").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropAtBounds", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Dropping")]
public float dropAtScreenCenterMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dropAtScreenCenterMax").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropAtScreenCenterMax", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Dropping")]
public float dropAtScreenCenterScalar
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dropAtScreenCenterScalar").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropAtScreenCenterScalar", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Dropping")]
public float dropBelowCameraOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dropBelowCameraOffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropBelowCameraOffset", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Dropping")]
public TypeWorldEditorDropType dropType
       {
       get
          {          return (TypeWorldEditorDropType) Omni.self.GetVar(_ID + ".dropType");
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropType", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Colors")]
public ColorI faceSelectColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".faceSelectColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".faceSelectColor", value.AsString());
          }
       }
/// <summary>
/// Whether object icons should fade out with distance to camera pos. 
/// </summary>
[MemberGroup("Rendering: Icons")]
public bool fadeIcons
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeIcons").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeIcons", value.AsString());
          }
       }
/// <summary>
/// Distance from camera pos at which to start fading out icons. 
/// </summary>
[MemberGroup("Rendering: Icons")]
public float fadeIconsDist
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeIconsDist").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeIconsDist", value.AsString());
          }
       }
/// <summary>
/// If true, transform operations will snap to the grid. 
/// </summary>
[MemberGroup("Grid")]
public bool gridSnap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridSnap").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridSnap", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public bool isDirty
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isDirty").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isDirty", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Rendering")]
public String lockedHandle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lockedHandle").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lockedHandle", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Selections")]
public bool objectMeshCollision
       {
       get
          {
          return Omni.self.GetVar(_ID + ".objectMeshCollision").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".objectMeshCollision", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
[MemberGroup("Selections")]
public bool objectsUseBoxCenter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".objectsUseBoxCenter").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".objectsUseBoxCenter", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Colors")]
public ColorI objectTextColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".objectTextColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".objectTextColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Colors")]
public ColorI objMouseOverColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".objMouseOverColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".objMouseOverColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Colors")]
public ColorI objMouseOverSelectColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".objMouseOverSelectColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".objMouseOverSelectColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Colors")]
public ColorI objSelectColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".objSelectColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".objSelectColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Rendering")]
public String objTextFormat
       {
       get
          {
          return Omni.self.GetVar(_ID + ".objTextFormat").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".objTextFormat", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Colors")]
public ColorI popupBackgroundColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".popupBackgroundColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".popupBackgroundColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Colors")]
public ColorI popupTextColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".popupTextColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".popupTextColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Rendering")]
public bool renderObjHandle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderObjHandle").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderObjHandle", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Rendering")]
public bool renderObjText
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderObjText").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderObjText", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Rendering")]
public bool renderPopupBackground
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderPopupBackground").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderPopupBackground", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Rendering")]
public bool renderSelectionBox
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderSelectionBox").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderSelectionBox", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Rendering")]
public String selectHandle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".selectHandle").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".selectHandle", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Colors")]
public ColorI selectionBoxColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".selectionBoxColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".selectionBoxColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Selections")]
public bool selectionLocked
       {
       get
          {
          return Omni.self.GetVar(_ID + ".selectionLocked").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".selectionLocked", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Rendering")]
public bool showMousePopupInfo
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showMousePopupInfo").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showMousePopupInfo", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public bool stickToGround
       {
       get
          {
          return Omni.self.GetVar(_ID + ".stickToGround").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".stickToGround", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public bool toggleIgnoreList
       {
       get
          {
          return Omni.self.GetVar(_ID + ".toggleIgnoreList").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".toggleIgnoreList", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addUndoState(){

pInvokes.m_ts.fn_WorldEditor_addUndoState(_ID);
}
/// <summary>
/// (int axis)
///               Align all selected objects along the given axis.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void alignByAxis(int boundsAxis){

pInvokes.m_ts.fn_WorldEditor_alignByAxis(_ID, boundsAxis);
}
/// <summary>
/// (int boundsAxis)
///               Align all selected objects against the given bounds axis.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void alignByBounds(int boundsAxis){

pInvokes.m_ts.fn_WorldEditor_alignByBounds(_ID, boundsAxis);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool canPasteSelection(){

return pInvokes.m_ts.fn_WorldEditor_canPasteSelection(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearIgnoreList(){

pInvokes.m_ts.fn_WorldEditor_clearIgnoreList(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearSelection(){

pInvokes.m_ts.fn_WorldEditor_clearSelection(_ID);
}
/// <summary>
/// ( String path ) - Export the combined geometry of all selected objects to the specified path in collada format. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void colladaExportSelection(string path){

pInvokes.m_ts.fn_WorldEditor_colladaExportSelection(_ID, path);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void copySelection(){

pInvokes.m_ts.fn_WorldEditor_copySelection(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void cutSelection(){

pInvokes.m_ts.fn_WorldEditor_cutSelection(_ID);
}
/// <summary>
/// ( bool skipUndo = false ))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void dropSelection(bool skipUndo = false){

pInvokes.m_ts.fn_WorldEditor_dropSelection(_ID, skipUndo);
}
/// <summary>
/// () - Replace selected Prefab objects with a SimGroup containing all children objects defined in the .prefab. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void explodeSelectedPrefab(){

pInvokes.m_ts.fn_WorldEditor_explodeSelectedPrefab(_ID);
}
/// <summary>
/// () - Return the currently active WorldEditorSelection object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getActiveSelection(){

return pInvokes.m_ts.fn_WorldEditor_getActiveSelection(_ID);
}
/// <summary>
/// (int index))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedObject(int index){

return pInvokes.m_ts.fn_WorldEditor_getSelectedObject(_ID, index);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSelectionCentroid(){

return pInvokes.m_ts.fn_WorldEditor_getSelectionCentroid(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getSelectionExtent(){

return new Point3F ( pInvokes.m_ts.fn_WorldEditor_getSelectionExtent(_ID));
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getSelectionRadius(){

return pInvokes.m_ts.fn_WorldEditor_getSelectionRadius(_ID);
}
/// <summary>
/// () - Return the number of objects currently selected in the editor.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectionSize(){

return pInvokes.m_ts.fn_WorldEditor_getSelectionSize(_ID);
}
/// <summary>
/// getSoftSnap()
///               Is soft snapping always on?)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getSoftSnap(){

return pInvokes.m_ts.fn_WorldEditor_getSoftSnap(_ID);
}
/// <summary>
/// getSoftSnapBackfaceTolerance()
///               The fraction of the soft snap radius that backfaces may be included.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getSoftSnapBackfaceTolerance(){

return pInvokes.m_ts.fn_WorldEditor_getSoftSnapBackfaceTolerance(_ID);
}
/// <summary>
/// getSoftSnapSize()
///               Get the absolute size to trigger a soft snap.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getSoftSnapSize(){

return pInvokes.m_ts.fn_WorldEditor_getSoftSnapSize(_ID);
}
/// <summary>
/// (Object obj, bool hide))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void hideObject(string obj, bool hide){

pInvokes.m_ts.fn_WorldEditor_hideObject(_ID, obj, hide);
}
/// <summary>
/// (bool hide))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void hideSelection(bool hide){

pInvokes.m_ts.fn_WorldEditor_hideSelection(_ID, hide);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void invalidateSelectionCentroid(){

pInvokes.m_ts.fn_WorldEditor_invalidateSelectionCentroid(_ID);
}
/// <summary>
/// (bool lock))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void lockSelection(bool lockx){

pInvokes.m_ts.fn_WorldEditor_lockSelection(_ID, lockx);
}
/// <summary>
/// ( string filename ) - Save selected objects to a .prefab file and replace them in the level with a Prefab object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void makeSelectionPrefab(string filename){

pInvokes.m_ts.fn_WorldEditor_makeSelectionPrefab(_ID, filename);
}
/// <summary>
/// ( Object A, Object B ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void mountRelative(string objA, string objB){

pInvokes.m_ts.fn_WorldEditor_mountRelative(_ID, objA, objB);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pasteSelection(){

pInvokes.m_ts.fn_WorldEditor_pasteSelection(_ID);
}
/// <summary>
/// ( int objID ))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void redirectConsole(int objID){

pInvokes.m_ts.fn_WorldEditor_redirectConsole(_ID, objID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void resetSelectedRotation(){

pInvokes.m_ts.fn_WorldEditor_resetSelectedRotation(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void resetSelectedScale(){

pInvokes.m_ts.fn_WorldEditor_resetSelectedScale(_ID);
}
/// <summary>
/// (SimObject obj))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectObject(string objName){

pInvokes.m_ts.fn_WorldEditor_selectObject(_ID, objName);
}
/// <summary>
/// ( id set ) - Set the currently active WorldEditorSelection object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setActiveSelection(string selection){

pInvokes.m_ts.fn_WorldEditor_setActiveSelection(_ID, selection);
}
/// <summary>
/// setSoftSnap(bool)
///               Allow soft snapping all of the time.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSoftSnap(bool enable){

pInvokes.m_ts.fn_WorldEditor_setSoftSnap(_ID, enable);
}
/// <summary>
/// setSoftSnapBackfaceTolerance(F32 with range of 0..1)
///               The fraction of the soft snap radius that backfaces may be included.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSoftSnapBackfaceTolerance(float range){

pInvokes.m_ts.fn_WorldEditor_setSoftSnapBackfaceTolerance(_ID, range);
}
/// <summary>
/// setSoftSnapSize(F32)
///               Set the absolute size to trigger a soft snap.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSoftSnapSize(float size){

pInvokes.m_ts.fn_WorldEditor_setSoftSnapSize(_ID, size);
}
/// <summary>
/// softSnapDebugRender(bool)
///               Toggle soft snapping debug rendering.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void softSnapDebugRender(bool enable){

pInvokes.m_ts.fn_WorldEditor_softSnapDebugRender(_ID, enable);
}
/// <summary>
/// softSnapRender(bool)
///               Render the soft snapping bounds.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void softSnapRender(bool enable){

pInvokes.m_ts.fn_WorldEditor_softSnapRender(_ID, enable);
}
/// <summary>
/// softSnapRenderTriangle(bool)
///               Render the soft snapped triangle.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void softSnapRenderTriangle(bool enable){

pInvokes.m_ts.fn_WorldEditor_softSnapRenderTriangle(_ID, enable);
}
/// <summary>
/// softSnapSizeByBounds(bool)
///               Use selection bounds size as soft snap bounds.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void softSnapSizeByBounds(bool enable){

pInvokes.m_ts.fn_WorldEditor_softSnapSizeByBounds(_ID, enable);
}
/// <summary>
/// transformSelection(...)
///               Transform selection by given parameters.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void transformSelection(bool position, Point3F point, bool relativePos, bool rotate, Point3F rotation, bool relativeRot, bool rotLocal, int scaleType, Point3F scale, bool sRelative, bool sLocal){

pInvokes.m_ts.fn_WorldEditor_transformSelection(_ID, position, point.AsString(), relativePos, rotate, rotation.AsString(), relativeRot, rotLocal, scaleType, scale.AsString(), sRelative, sLocal);
}
/// <summary>
/// (SimObject obj))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void unselectObject(string objName){

pInvokes.m_ts.fn_WorldEditor_unselectObject(_ID, objName);
}
/// <summary>
/// Create a ConvexShape from the given polyhedral object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string createConvexShapeFrom(string polyObject){

return pInvokes.m_ts.fnWorldEditor_createConvexShapeFrom(_ID, polyObject);
}
/// <summary>
/// Grab the geometry from @a geometryProvider, create a @a className object, and assign it the extracted geometry. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string createPolyhedralObject(string className, string geometryProvider){

return pInvokes.m_ts.fnWorldEditor_createPolyhedralObject(_ID, className, geometryProvider);
}
/// <summary>
/// Get the soft snap alignment. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  TypeWorldEditorAlignmentType getSoftSnapAlignment(){

return (TypeWorldEditorAlignmentType)( pInvokes.m_ts.fnWorldEditor_getSoftSnapAlignment(_ID));
}
/// <summary>
/// Get the terrain snap alignment.  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  TypeWorldEditorAlignmentType getTerrainSnapAlignment(){

return (TypeWorldEditorAlignmentType)( pInvokes.m_ts.fnWorldEditor_getTerrainSnapAlignment(_ID));
}
/// <summary>
/// ( WorldEditor, ignoreObjClass, void, 3, 0, (string class_name, ...))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void ignoreObjClass(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){

pInvokes.m_ts.fnWorldEditor_ignoreObjClass(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Set the soft snap alignment. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSoftSnapAlignment(TypeWorldEditorAlignmentType type){

pInvokes.m_ts.fnWorldEditor_setSoftSnapAlignment(_ID, (int)type );
}
/// <summary>
/// Set the terrain snap alignment. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTerrainSnapAlignment(TypeWorldEditorAlignmentType alignment){

pInvokes.m_ts.fnWorldEditor_setTerrainSnapAlignment(_ID, (int)alignment );
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelect(string idString){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onUnSelect(string idString){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onClearSelection(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelectionCentroidChanged(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onWorldEditorUndo(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelectionSetChanged(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMultiSelect(string idString, string addToSelection){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  string getNewObjectGroup(){return "0".AsString();}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onStartSelection(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEndSelection(){}

#endregion
public WorldEditor_Base (){}
}}
