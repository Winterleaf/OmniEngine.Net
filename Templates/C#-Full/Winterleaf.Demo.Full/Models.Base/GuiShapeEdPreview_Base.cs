


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiShapeEdPreview_Base>))]
    public partial class GuiShapeEdPreview_Base: EditTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiShapeEdPreview_Base ts, string simobjectid)
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
        public static bool operator !=(GuiShapeEdPreview_Base ts, string simobjectid)
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
        public static implicit operator string( GuiShapeEdPreview_Base ts)
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
        public static implicit operator GuiShapeEdPreview_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiShapeEdPreview_Base) Omni.self.getSimObject(simobjectid,typeof(GuiShapeEdPreview_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiShapeEdPreview_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiShapeEdPreview_Base(int simobjectid)
            {
            return  (GuiShapeEdPreview) Omni.self.getSimObject((uint)simobjectid,typeof(GuiShapeEdPreview_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiShapeEdPreview_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiShapeEdPreview_Base(uint simobjectid)
            {
            return  (GuiShapeEdPreview_Base) Omni.self.getSimObject(simobjectid,typeof(GuiShapeEdPreview_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Index of the active thread, or -1 if none 
/// </summary>
[MemberGroup("Animation")]
public int activeThread
       {
       get
          {
          return Omni.self.GetVar(_ID + ".activeThread").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".activeThread", value.AsString());
          }
       }
/// <summary>
/// The number of collision meshes in the shape 
/// </summary>
[MemberGroup("Detail Stats")]
public int colMeshes
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colMeshes").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colMeshes", value.AsString());
          }
       }
/// <summary>
/// The total number of collision polygons (all meshes) in the shape 
/// </summary>
[MemberGroup("Detail Stats")]
public int colPolys
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colPolys").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colPolys", value.AsString());
          }
       }
/// <summary>
/// The current detail level 
/// </summary>
[MemberGroup("Detail Stats")]
public int currentDL
       {
       get
          {
          return Omni.self.GetVar(_ID + ".currentDL").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".currentDL", value.AsString());
          }
       }
/// <summary>
/// Number of polygons in the current detail 
/// </summary>
[MemberGroup("Detail Stats")]
public int detailPolys
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailPolys").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailPolys", value.AsString());
          }
       }
/// <summary>
/// The size of the current detail 
/// </summary>
[MemberGroup("Detail Stats")]
public int detailSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailSize", value.AsString());
          }
       }
/// <summary>
/// If true, dragging the gizmo will rotate the sun direction 
/// </summary>
[MemberGroup("Rendering")]
public bool editSun
       {
       get
          {
          return Omni.self.GetVar(_ID + ".editSun").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".editSun", value.AsString());
          }
       }
/// <summary>
/// If false, the current detail is selected based on camera distance 
/// </summary>
[MemberGroup("Detail Stats")]
public bool fixedDetail
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fixedDetail").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fixedDetail", value.AsString());
          }
       }
/// <summary>
/// Grid dimensions (number of rows and columns) in the form \rows cols\ 
/// </summary>
[MemberGroup("Rendering")]
public Point2I gridDimension
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridDimension").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridDimension", value.AsString());
          }
       }
/// <summary>
/// The number of bones in the current detail level (skins only) 
/// </summary>
[MemberGroup("Detail Stats")]
public int numBones
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numBones").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numBones", value.AsString());
          }
       }
/// <summary>
/// The number of draw calls in the current detail level 
/// </summary>
[MemberGroup("Detail Stats")]
public int numDrawCalls
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numDrawCalls").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numDrawCalls", value.AsString());
          }
       }
/// <summary>
/// The number of materials in the current detail level 
/// </summary>
[MemberGroup("Detail Stats")]
public int numMaterials
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numMaterials").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numMaterials", value.AsString());
          }
       }
/// <summary>
/// The number of vertex weights in the current detail level (skins only) 
/// </summary>
[MemberGroup("Detail Stats")]
public int numWeights
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numWeights").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numWeights", value.AsString());
          }
       }
/// <summary>
/// The current distance from the camera to the model 
/// </summary>
[MemberGroup("Detail Stats")]
public float orbitDist
       {
       get
          {
          return Omni.self.GetVar(_ID + ".orbitDist").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".orbitDist", value.AsString());
          }
       }
/// <summary>
/// The current pixel size of the model 
/// </summary>
[MemberGroup("Detail Stats")]
public float pixelSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".pixelSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".pixelSize", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the shape bounding box 
/// </summary>
[MemberGroup("Rendering")]
public bool renderBounds
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderBounds").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderBounds", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the shape's collision geometry 
/// </summary>
[MemberGroup("Rendering")]
public bool renderColMeshes
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderColMeshes").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderColMeshes", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the shape in 'ghost' mode (transparent) 
/// </summary>
[MemberGroup("Rendering")]
public bool renderGhost
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderGhost").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderGhost", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to draw the grid 
/// </summary>
[MemberGroup("Rendering")]
public bool renderGrid
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderGrid").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderGrid", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render mounted objects 
/// </summary>
[MemberGroup("Rendering")]
public bool renderMounts
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderMounts").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderMounts", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the shape nodes 
/// </summary>
[MemberGroup("Rendering")]
public bool renderNodes
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderNodes").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderNodes", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the selected object's bounding box 
/// </summary>
[MemberGroup("Rendering")]
public bool renderObjBox
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderObjBox").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderObjBox", value.AsString());
          }
       }
/// <summary>
/// Index of the selected node, or -1 if none 
/// </summary>
[MemberGroup("Rendering")]
public int selectedNode
       {
       get
          {
          return Omni.self.GetVar(_ID + ".selectedNode").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".selectedNode", value.AsString());
          }
       }
/// <summary>
/// Index of the selected object detail mesh, or 0 if none 
/// </summary>
[MemberGroup("Rendering")]
public int selectedObjDetail
       {
       get
          {
          return Omni.self.GetVar(_ID + ".selectedObjDetail").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".selectedObjDetail", value.AsString());
          }
       }
/// <summary>
/// Index of the selected object, or -1 if none 
/// </summary>
[MemberGroup("Rendering")]
public int selectedObject
       {
       get
          {
          return Omni.self.GetVar(_ID + ".selectedObject").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".selectedObject", value.AsString());
          }
       }
/// <summary>
/// Diffuse color for the sun 
/// </summary>
[MemberGroup("Sun")]
public ColorI sunAmbient
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sunAmbient").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sunAmbient", value.AsString());
          }
       }
/// <summary>
/// X-axis rotation angle for the sun 
/// </summary>
[MemberGroup("Sun")]
public float sunAngleX
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sunAngleX").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sunAngleX", value.AsString());
          }
       }
/// <summary>
/// Z-axis rotation angle for the sun 
/// </summary>
[MemberGroup("Sun")]
public float sunAngleZ
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sunAngleZ").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sunAngleZ", value.AsString());
          }
       }
/// <summary>
/// Ambient color for the sun 
/// </summary>
[MemberGroup("Sun")]
public ColorI sunDiffuse
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sunDiffuse").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sunDiffuse", value.AsString());
          }
       }
/// <summary>
/// Playback direction of the active thread 
/// </summary>
[MemberGroup("Animation")]
public int threadDirection
       {
       get
          {
          return Omni.self.GetVar(_ID + ".threadDirection").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".threadDirection", value.AsString());
          }
       }
/// <summary>
/// 'PingPong' mode of the active thread 
/// </summary>
[MemberGroup("Animation")]
public bool threadPingPong
       {
       get
          {
          return Omni.self.GetVar(_ID + ".threadPingPong").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".threadPingPong", value.AsString());
          }
       }
/// <summary>
/// Current position of the active thread (0-1) 
/// </summary>
[MemberGroup("Animation")]
public float threadPos
       {
       get
          {
          return Omni.self.GetVar(_ID + ".threadPos").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".threadPos", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Add a new thread (initially without any sequence set) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addThread(){

pInvokes.m_ts.fnGuiShapeEdPreview_addThread(_ID);
}
/// <summary>
/// Compute the bounding box of the shape using the current detail and node transforms
///    @return the bounding box \"min.x min.y min.z max.x max.y max.z\" )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Box3F computeShapeBounds(){

return new Box3F ( pInvokes.m_ts.fnGuiShapeEdPreview_computeShapeBounds(_ID));
}
/// <summary>
/// Export the current shape and all mounted objects to COLLADA (.dae).
///    Note that animation is not exported, and all geometry is combined into a 
///    single mesh.
///    @param path Destination filename )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void exportToCollada(string path){

pInvokes.m_ts.fnGuiShapeEdPreview_exportToCollada(_ID, path);
}
/// <summary>
/// Adjust the camera position and zoom to fit the shape within the view. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void fitToShape(){

pInvokes.m_ts.fnGuiShapeEdPreview_fitToShape(_ID);
}
/// <summary>
/// Return whether the named object is currently hidden )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getMeshHidden(string name){

return pInvokes.m_ts.fnGuiShapeEdPreview_getMeshHidden(_ID, name);
}
/// <summary>
/// Get the playback direction of the sequence playing on this mounted shape
///    @param slot mounted shape slot
///    @return direction of the sequence (-1=reverse, 0=paused, 1=forward) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getMountThreadDir(int slot){

return pInvokes.m_ts.fnGuiShapeEdPreview_getMountThreadDir(_ID, slot);
}
/// <summary>
/// Get the playback position of the sequence playing on this mounted shape
///    @param slot mounted shape slot
///    @return playback position of the sequence (0-1) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getMountThreadPos(int slot){

return pInvokes.m_ts.fnGuiShapeEdPreview_getMountThreadPos(_ID, slot);
}
/// <summary>
/// Get the name of the sequence playing on this mounted shape
///    @param slot mounted shape slot
///    @return name of the sequence (if any) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMountThreadSequence(int slot){

return pInvokes.m_ts.fnGuiShapeEdPreview_getMountThreadSequence(_ID, slot);
}
/// <summary>
/// Get the number of threads
///    @return the number of threads )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getThreadCount(){

return pInvokes.m_ts.fnGuiShapeEdPreview_getThreadCount(_ID);
}
/// <summary>
/// Get the name of the sequence assigned to the active thread )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getThreadSequence(){

return pInvokes.m_ts.fnGuiShapeEdPreview_getThreadSequence(_ID);
}
/// <summary>
/// Mount a shape onto the main shape at the specified node
///    @param shapePath path to the shape to mount
///    @param nodeName name of the node on the main shape to mount to
///    @param type type of mounting to use (Object, Image or Wheel)
///    @param slot mount slot )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool mountShape(string shapePath, string nodeName, string type, int slot){

return pInvokes.m_ts.fnGuiShapeEdPreview_mountShape(_ID, shapePath, nodeName, type, slot);
}
/// <summary>
/// Refresh the shape (used when the shape meshes or nodes have been added or removed) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void refreshShape(){

pInvokes.m_ts.fnGuiShapeEdPreview_refreshShape(_ID);
}
/// <summary>
/// Refreshes thread sequences (in case of removed/renamed sequences )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void refreshThreadSequences(){

pInvokes.m_ts.fnGuiShapeEdPreview_refreshThreadSequences(_ID);
}
/// <summary>
/// Removes the specifed thread
///    @param slot index of the thread to remove )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeThread(int slot){

pInvokes.m_ts.fnGuiShapeEdPreview_removeThread(_ID, slot);
}
/// <summary>
/// Show or hide all objects in the shape )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAllMeshesHidden(bool hidden){

pInvokes.m_ts.fnGuiShapeEdPreview_setAllMeshesHidden(_ID, hidden);
}
/// <summary>
/// Show or hide the named object in the shape )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMeshHidden(string name, bool hidden){

pInvokes.m_ts.fnGuiShapeEdPreview_setMeshHidden(_ID, name, hidden);
}
/// <summary>
/// Sets the model to be displayed in this control
///    @param shapeName Name of the model to display.
///    @return True if the model was loaded successfully, false otherwise. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setModel(string shapePath){

return pInvokes.m_ts.fnGuiShapeEdPreview_setModel(_ID, shapePath);
}
/// <summary>
/// Set the node a shape is mounted to.
///    @param slot mounted shape slot
///    @param nodename name of the node to mount to )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMountNode(int slot, string nodeName){

pInvokes.m_ts.fnGuiShapeEdPreview_setMountNode(_ID, slot, nodeName);
}
/// <summary>
/// Set the playback direction of the shape mounted in the specified slot
///    @param slot mounted shape slot
///    @param dir playback direction (-1=backwards, 0=paused, 1=forwards) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMountThreadDir(int slot, float dir){

pInvokes.m_ts.fnGuiShapeEdPreview_setMountThreadDir(_ID, slot, dir);
}
/// <summary>
/// Set the sequence position of the shape mounted in the specified slot
///    @param slot mounted shape slot
///    @param pos sequence position (0-1) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMountThreadPos(int slot, float pos){

pInvokes.m_ts.fnGuiShapeEdPreview_setMountThreadPos(_ID, slot, pos);
}
/// <summary>
/// Set the sequence to play for the shape mounted in the specified slot
///    @param slot mounted shape slot
///    @param name name of the sequence to play )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMountThreadSequence(int slot, string name){

pInvokes.m_ts.fnGuiShapeEdPreview_setMountThreadSequence(_ID, slot, name);
}
/// <summary>
/// Set the camera orbit position
///    @param pos Position in the form \"x y z\" )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setOrbitPos(Point3F pos){

pInvokes.m_ts.fnGuiShapeEdPreview_setOrbitPos(_ID, pos.AsString());
}
/// <summary>
/// Sets the sequence to play for the active thread.
///    @param name name of the sequence to play
///    @param duration transition duration (0 for no transition)
///    @param pos position in the new sequence to transition to
///    @param play if true, the new sequence will play during the transition )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setThreadSequence(string name, float duration = 0, float pos = 0, bool play = false){

pInvokes.m_ts.fnGuiShapeEdPreview_setThreadSequence(_ID, name, duration, pos, play);
}
/// <summary>
/// Set the time scale of all threads
///    @param scale new time scale value )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTimeScale(float scale){

pInvokes.m_ts.fnGuiShapeEdPreview_setTimeScale(_ID, scale);
}
/// <summary>
/// Unmount all shapes )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void unmountAll(){

pInvokes.m_ts.fnGuiShapeEdPreview_unmountAll(_ID);
}
/// <summary>
/// Unmount the shape in the specified slot
///    @param slot mounted shape slot )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void unmountShape(int slot){

pInvokes.m_ts.fnGuiShapeEdPreview_unmountShape(_ID, slot);
}
/// <summary>
/// Refresh the shape node transforms (used when a node transform has been modified externally) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void updateNodeTransforms(){

pInvokes.m_ts.fnGuiShapeEdPreview_updateNodeTransforms(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the position of the active thread has changed, such as during    playback. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onThreadPosChanged(float pos, bool inTransition){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDetailChanged(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onNodeSelected(string nodeIdx){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEditNodeTransform(string node, string txfm, string gizmoID){}

#endregion
public GuiShapeEdPreview_Base (){}
}}
