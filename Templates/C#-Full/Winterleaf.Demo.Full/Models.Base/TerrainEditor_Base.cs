


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
    [TypeConverter(typeof(TypeConverterGeneric<TerrainEditor_Base>))]
    public partial class TerrainEditor_Base: EditTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainEditor_Base ts, string simobjectid)
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
        public static bool operator !=(TerrainEditor_Base ts, string simobjectid)
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
        public static implicit operator string( TerrainEditor_Base ts)
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
        public static implicit operator TerrainEditor_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TerrainEditor_Base) Omni.self.getSimObject(simobjectid,typeof(TerrainEditor_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TerrainEditor_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainEditor_Base(int simobjectid)
            {
            return  (TerrainEditor) Omni.self.getSimObject((uint)simobjectid,typeof(TerrainEditor_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TerrainEditor_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainEditor_Base(uint simobjectid)
            {
            return  (TerrainEditor_Base) Omni.self.getSimObject(simobjectid,typeof(TerrainEditor_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public float adjustHeightMouseScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".adjustHeightMouseScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".adjustHeightMouseScale", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public float adjustHeightVal
       {
       get
          {
          return Omni.self.GetVar(_ID + ".adjustHeightVal").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".adjustHeightVal", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public ColorI borderFillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderFillColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderFillColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public ColorI borderFrameColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderFrameColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderFrameColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public float borderHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderHeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderHeight", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public bool borderLineMode
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderLineMode").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderLineMode", value.AsString());
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
[MemberGroup("Misc")]
public bool isMissionDirty
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isMissionDirty").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isMissionDirty", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public int materialGroup
       {
       get
          {
          return Omni.self.GetVar(_ID + ".materialGroup").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".materialGroup", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public Point2I maxBrushSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxBrushSize").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxBrushSize", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public float noiseFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".noiseFactor").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".noiseFactor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public int paintIndex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".paintIndex").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".paintIndex", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public bool processUsesBrush
       {
       get
          {
          return Omni.self.GetVar(_ID + ".processUsesBrush").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".processUsesBrush", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public bool renderBorder
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderBorder").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderBorder", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public bool renderSolidBrush
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderSolidBrush").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderSolidBrush", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public bool renderVertexSelection
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderVertexSelection").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderVertexSelection", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public float scaleVal
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scaleVal").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scaleVal", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public bool selectionHidden
       {
       get
          {
          return Omni.self.GetVar(_ID + ".selectionHidden").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".selectionHidden", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public float setHeightVal
       {
       get
          {
          return Omni.self.GetVar(_ID + ".setHeightVal").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".setHeightVal", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public float smoothFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".smoothFactor").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".smoothFactor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public String softSelectDefaultFilter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".softSelectDefaultFilter").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".softSelectDefaultFilter", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public String softSelectFilter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".softSelectFilter").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".softSelectFilter", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public float softSelectRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".softSelectRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".softSelectRadius", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ( string matName )
///    Adds a new material. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int addMaterial(string matName){

return pInvokes.m_ts.fn_TerrainEditor_addMaterial(_ID, matName);
}
/// <summary>
/// ), (TerrainBlock terrain))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void attachTerrain(string terrain = ""){

pInvokes.m_ts.fn_TerrainEditor_attachTerrain(_ID, terrain);
}
/// <summary>
/// (F32 minHeight, F32 maxHeight, F32 minSlope, F32 maxSlope , F32 coverage))  
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void autoMaterialLayer(float minHeight, float maxHeight, float minSlope, float maxSlope, float coverage){

pInvokes.m_ts.fn_TerrainEditor_autoMaterialLayer(_ID, minHeight, maxHeight, minSlope, maxSlope, coverage);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearSelection(){

pInvokes.m_ts.fn_TerrainEditor_clearSelection(_ID);
}
/// <summary>
/// (int num))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getActionName(uint index){

return pInvokes.m_ts.fn_TerrainEditor_getActionName(_ID, index);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getActiveTerrain(){

return pInvokes.m_ts.fn_TerrainEditor_getActiveTerrain(_ID);
}
/// <summary>
/// Returns a Point2I.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getBrushPos(){

return pInvokes.m_ts.fn_TerrainEditor_getBrushPos(_ID);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getBrushPressure(){

return pInvokes.m_ts.fn_TerrainEditor_getBrushPressure(_ID);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getBrushSize(){

return pInvokes.m_ts.fn_TerrainEditor_getBrushSize(_ID);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getBrushSoftness(){

return pInvokes.m_ts.fn_TerrainEditor_getBrushSoftness(_ID);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getBrushType(){

return pInvokes.m_ts.fn_TerrainEditor_getBrushType(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getCurrentAction(){

return pInvokes.m_ts.fn_TerrainEditor_getCurrentAction(_ID);
}
/// <summary>
/// Returns the current material count. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMaterialCount(){

return pInvokes.m_ts.fn_TerrainEditor_getMaterialCount(_ID);
}
/// <summary>
/// ( string name ) - Returns the index of the material with the given name or -1. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMaterialIndex(string name){

return pInvokes.m_ts.fn_TerrainEditor_getMaterialIndex(_ID, name);
}
/// <summary>
/// ( int index ) - Returns the name of the material at the given index. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMaterialName(int index){

return pInvokes.m_ts.fn_TerrainEditor_getMaterialName(_ID, index);
}
/// <summary>
/// () gets the list of current terrain materials.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMaterials(){

return pInvokes.m_ts.fn_TerrainEditor_getMaterials(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNumActions(){

return pInvokes.m_ts.fn_TerrainEditor_getNumActions(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNumTextures(){

return pInvokes.m_ts.fn_TerrainEditor_getNumTextures(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getSlopeLimitMaxAngle(){

return pInvokes.m_ts.fn_TerrainEditor_getSlopeLimitMaxAngle(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getSlopeLimitMinAngle(){

return pInvokes.m_ts.fn_TerrainEditor_getSlopeLimitMinAngle(_ID);
}
/// <summary>
/// (S32 index))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getTerrainBlock(int index){

return pInvokes.m_ts.fn_TerrainEditor_getTerrainBlock(_ID, index);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getTerrainBlockCount(){

return pInvokes.m_ts.fn_TerrainEditor_getTerrainBlockCount(_ID);
}
/// <summary>
/// () gets the list of current terrain materials for all terrain blocks.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTerrainBlocksMaterialList(){

return pInvokes.m_ts.fn_TerrainEditor_getTerrainBlocksMaterialList(_ID);
}
/// <summary>
/// , , ), 
///                                                                            (x/y/z) Gets the terrain block that is located under the given world point.
///                                                                            @param x/y/z The world coordinates (floating point values) you wish to query at.  
///                                                                            These can be formatted as either a string (\"x y z\") or separately as (x, y, z)
///                                                                            @return Returns the ID of the requested terrain block (0 if not found).)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getTerrainUnderWorldPoint(string ptOrX = "", string Y = "", string Z = ""){

return pInvokes.m_ts.fn_TerrainEditor_getTerrainUnderWorldPoint(_ID, ptOrX, Y, Z);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void markEmptySquares(){

pInvokes.m_ts.fn_TerrainEditor_markEmptySquares(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void mirrorTerrain(int mirrorIndex){

pInvokes.m_ts.fn_TerrainEditor_mirrorTerrain(_ID, mirrorIndex);
}
/// <summary>
/// ), (string action=NULL))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void processAction(string action = ""){

pInvokes.m_ts.fn_TerrainEditor_processAction(_ID, action);
}
/// <summary>
/// ( int index ) - Remove the material at the given index. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeMaterial(int index){

pInvokes.m_ts.fn_TerrainEditor_removeMaterial(_ID, index);
}
/// <summary>
/// ( int index, int order ) 
///   - Reorder material at the given index to the new position, changing the order in which it is rendered / blended. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reorderMaterial(int index, int orderPos){

pInvokes.m_ts.fn_TerrainEditor_reorderMaterial(_ID, index, orderPos);
}
/// <summary>
/// (bool clear))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void resetSelWeights(bool clear){

pInvokes.m_ts.fn_TerrainEditor_resetSelWeights(_ID, clear);
}
/// <summary>
/// (string action_name))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAction(string action_name){

pInvokes.m_ts.fn_TerrainEditor_setAction(_ID, action_name);
}
/// <summary>
/// Location)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBrushPos(Point2I pos){

pInvokes.m_ts.fn_TerrainEditor_setBrushPos(_ID, pos.AsString());
}
/// <summary>
/// (float pressure))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBrushPressure(float pressure){

pInvokes.m_ts.fn_TerrainEditor_setBrushPressure(_ID, pressure);
}
/// <summary>
/// (int w [, int h]))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBrushSize(int w, int h = 0){

pInvokes.m_ts.fn_TerrainEditor_setBrushSize(_ID, w, h);
}
/// <summary>
/// (float softness))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBrushSoftness(float softness){

pInvokes.m_ts.fn_TerrainEditor_setBrushSoftness(_ID, softness);
}
/// <summary>
/// (string type)
///               One of box, ellipse, selection.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBrushType(string type){

pInvokes.m_ts.fn_TerrainEditor_setBrushType(_ID, type);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float setSlopeLimitMaxAngle(float angle){

return pInvokes.m_ts.fn_TerrainEditor_setSlopeLimitMaxAngle(_ID, angle);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float setSlopeLimitMinAngle(float angle){

return pInvokes.m_ts.fn_TerrainEditor_setSlopeLimitMinAngle(_ID, angle);
}
/// <summary>
/// (bool overlayEnable) - sets the terraformer current heightmap to draw as an overlay over the current terrain.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTerraformOverlay(bool overlayEnable){

pInvokes.m_ts.fn_TerrainEditor_setTerraformOverlay(_ID, overlayEnable);
}
/// <summary>
/// ( int index, string matName )
///    Changes the material name at the index. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool updateMaterial(uint index, string matName){

return pInvokes.m_ts.fn_TerrainEditor_updateMaterial(_ID, index, matName);
}

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onBrushChanged(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMaterialUndo(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onGuiUpdate(string text){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onActiveTerrainChange(string newTerrain){}

#endregion
public TerrainEditor_Base (){}
}}
