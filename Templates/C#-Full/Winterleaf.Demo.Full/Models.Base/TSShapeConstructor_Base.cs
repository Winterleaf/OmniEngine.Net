


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
    [TypeConverter(typeof(TypeConverterGeneric<TSShapeConstructor_Base>))]
    public partial class TSShapeConstructor_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TSShapeConstructor_Base ts, string simobjectid)
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
        public static bool operator !=(TSShapeConstructor_Base ts, string simobjectid)
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
        public static implicit operator string( TSShapeConstructor_Base ts)
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
        public static implicit operator TSShapeConstructor_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TSShapeConstructor_Base) Omni.self.getSimObject(simobjectid,typeof(TSShapeConstructor_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TSShapeConstructor_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TSShapeConstructor_Base(int simobjectid)
            {
            return  (TSShapeConstructor) Omni.self.getSimObject((uint)simobjectid,typeof(TSShapeConstructor_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TSShapeConstructor_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TSShapeConstructor_Base(uint simobjectid)
            {
            return  (TSShapeConstructor_Base) Omni.self.getSimObject(simobjectid,typeof(TSShapeConstructor_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Autofit a mesh primitive or set of convex hulls to the shape geometry. Hulls 
///    may optionally be converted to boxes, spheres and/or capsules based on their 
///    volume.
///    @param size size for this detail level
///    @param type one of: box, sphere, capsule, 10-dop x, 10-dop y, 10-dop z, 18-dop, 
///       26-dop, convex hulls. See the Shape Editor documentation for more details 
///       about these types.
///    @param target geometry to fit collision mesh(es) to; either \"bounds\" (for the 
///       whole shape), or the name of an object in the shape
///    @param depth maximum split recursion depth (hulls only)
///    @param merge volume % threshold used to merge hulls together (hulls only)
///    @param concavity volume % threshold used to detect concavity (hulls only)
///    @param maxVerts maximum number of vertices per hull (hulls only)
///    @param boxMaxError max % volume difference for a hull to be converted to a 
///       box (hulls only)
///    @param sphereMaxError max % volume difference for a hull to be converted to 
///       a sphere (hulls only)
///    @param capsuleMaxError max % volume difference for a hull to be converted to 
///       a capsule (hulls only)
///    @return true if successful, false otherwise
///    @tsexample
///    %this.addCollisionDetail( -1, \"box\", \"bounds\" );
///    %this.addCollisionDetail( -1, \"convex hulls\", \"bounds\", 4, 30, 30, 32, 0, 0, 0 );
///    %this.addCollisionDetail( -1, \"convex hulls\", \"bounds\", 4, 30, 30, 32, 50, 50, 50 );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool addCollisionDetail(int size, string type, string target, int depth = 4, float merge = 30, float concavity = 30, int maxVerts = 32, float boxMaxError = 0, float sphereMaxError = 0, float capsuleMaxError = 0){

return pInvokes.m_ts.fnTSShapeConstructor_addCollisionDetail(_ID, size, type, target, depth, merge, concavity, maxVerts, boxMaxError, sphereMaxError, capsuleMaxError);
}
/// <summary>
/// Add (or edit) an imposter detail level to the shape.
///    If the shape already contains an imposter detail level, this command will 
///    simply change the imposter settings
///    @param size size of the imposter detail level
///    @param equatorSteps defines the number of snapshots to take around the 
///    equator. Imagine the object being rotated around the vertical axis, then 
///    a snapshot taken at regularly spaced intervals.
///    @param polarSteps defines the number of snapshots taken between the poles 
///    (top and bottom), at each equator step. eg. At each equator snapshot, 
///    snapshots are taken at regular intervals between the poles.
///    @param dl the detail level to use when generating the snapshots. Note that 
///    this is an array index rather than a detail size. So if an object has detail 
///    sizes of: 200, 150, and 40, then setting @a dl to 1 will generate the snapshots 
///    using detail size 150.
///    @param dim defines the size of the imposter images in pixels. The larger the 
///    number, the more detailed the billboard will be.
///    @param includePoles flag indicating whether to include the \"pole\" snapshots. 
///    ie. the views from the top and bottom of the object.
///    @param polar_angle if pole snapshots are active (@a includePoles is true), this 
///    parameter defines the camera angle (in degrees) within which to render the 
///    pole snapshot. eg. if polar_angle is set to 25 degrees, then the snapshot 
///    taken at the pole (looking directly down or up at the object) will be rendered 
///    when the camera is within 25 degrees of the pole.
///    @return true if successful, false otherwise
///    @tsexample
///    %this.addImposter( 2, 4, 0, 0, 64, false, 0 );
///    %this.addImposter( 2, 4, 2, 0, 64, true, 10 );   // this command would edit the existing imposter detail level
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int addImposter(int size, int equatorSteps, int polarSteps, int dl, int dim, bool includePoles, float polarAngle){

return pInvokes.m_ts.fnTSShapeConstructor_addImposter(_ID, size, equatorSteps, polarSteps, dl, dim, includePoles, polarAngle);
}
/// <summary>
/// Add geometry from another DTS or DAE shape file into this shape.
///    Any materials required by the source mesh are also copied into this shape.br>
///    @param meshName full name (object name + detail size) of the new mesh. If 
///       no detail size is present at the end of the name, a value of 2 is used.br>
///       An underscore before the number at the end of the name will be interpreted as 
///       a negative sign. eg. \"MyMesh_4\" will be interpreted as \"MyMesh-4\".
///    @param srcShape name of a shape file (DTS or DAE) that contains the mesh
///    @param srcMesh the full name (object name + detail size) of the mesh to 
///       copy from the DTS/DAE file into this shape/li>
///    @return true if successful, false otherwise
///    @tsexample
///    %this.addMesh( \"ColMesh-1\", \"./collision.dts\", \"ColMesh\", \"Col-1\" );
///    %this.addMesh( \"SimpleShape10\", \"./testShape.dae\", \"MyMesh2\",  );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool addMesh(string meshName, string srcShape, string srcMesh){

return pInvokes.m_ts.fnTSShapeConstructor_addMesh(_ID, meshName, srcShape, srcMesh);
}
/// <summary>
/// Add a new node.
///    @param name name for the new node (must not already exist)
///    @param parentName name of an existing node to be the parent of the new node. 
///    If empty (\"\"), the new node will be at the root level of the node hierarchy.
///    @param txfm (optional) transform string of the form: \"pos.x pos.y pos.z rot.x rot.y rot.z rot.angle\"
///    @param isworld (optional) flag to set the local-to-parent or the global 
///    transform. If false, or not specified, the position and orientation are 
///    treated as relative to the node's parent.
///    @return true if successful, false otherwise
///    @tsexample
///    %this.addNode( \"Nose\", \"Bip01 Head\", \"0 2 2 0 0 1 0\" );
///    %this.addNode( \"myRoot\", \"\", \"0 0 4 0 0 1 1.57\" );
///    %this.addNode( \"Nodes\", \"Bip01 Head\", \"0 2 0 0 0 1 0\", true );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool addNode(string name, string parentName, TransformF txfm = null , bool isWorld = false){
if (txfm== null) {txfm = new TransformF(0,0,0,0,0,1,0);}

return pInvokes.m_ts.fnTSShapeConstructor_addNode(_ID, name, parentName, txfm.AsString(), isWorld);
}
/// <summary>
/// Add a new mesh primitive to the shape.
///    @param meshName full name (object name + detail size) of the new mesh. If 
///       no detail size is present at the end of the name, a value of 2 is used.br>
///       An underscore before the number at the end of the name will be interpreted as 
///       a negative sign. eg. \"MyMesh_4\" will be interpreted as \"MyMesh-4\".
///    @param type one of: \"box\", \"sphere\", \"capsule\"
///    @param params mesh primitive parameters:
///       ul>
///          li>for box: \"size_x size_y size_z\"/li>
///          li>for sphere: \"radius\"/li>
///          li>for capsule: \"height radius\"/li>
///       /ul>
///    /ul>
///    @param txfm local transform offset from the node for this mesh
///    @param nodeName name of the node to attach the new mesh to (will change the 
///    object's node if adding a new mesh to an existing object)
///    @return true if successful, false otherwise
///    @tsexample
///    %this.addMesh( \"Box4\", \"box\", \"2 4 2\", \"0 2 0 0 0 1 0\", \"eye\" );
///    %this.addMesh( \"Sphere256\", \"sphere\", \"2\", \"0 0 0 0 0 1 0\", \"root\" );
///    %this.addMesh( \"MyCapsule-1\", \"capsule\", \"2 5\", \"0 0 2 0 0 1 0\", \"base01\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool addPrimitive(string meshName, string type, string paramsx, TransformF txfm, string nodeName){

return pInvokes.m_ts.fnTSShapeConstructor_addPrimitive(_ID, meshName, type, paramsx, txfm.AsString(), nodeName);
}
/// <summary>
/// Add a new sequence to the shape.
///    @param source the name of an existing sequence, or the name of a DTS or DAE 
///    shape or DSQ sequence file. When the shape file contains more than one 
///    sequence, the desired sequence can be specified by appending the name to the 
///    end of the shape file. eg. \"myShape.dts run\" would select the \"run\" 
///    sequence from the \"myShape.dts\" file.
///    @param name name of the new sequence
///    @param start (optional) first frame to copy. Defaults to 0, the first frame in the sequence.
///    @param end (optional) last frame to copy. Defaults to -1, the last frame in the sequence.
///    @param padRot (optional) copy root-pose rotation keys for non-animated nodes. This is useful if 
///    the source sequence data has a different root-pose to the target shape, such as if one character was 
///    in the T pose, and the other had arms at the side. Normally only nodes that are actually rotated by 
///    the source sequence have keyframes added, but setting this flag will also add keyframes for nodes 
///    that are not animated, but have a different root-pose rotation to the target shape root pose.
///    @param padTrans (optional) copy root-pose translation keys for non-animated nodes.  This is useful if 
///    the source sequence data has a different root-pose to the target shape, such as if one character was 
///    in the T pose, and the other had arms at the side. Normally only nodes that are actually moved by 
///    the source sequence have keyframes added, but setting this flag will also add keyframes for nodes 
///    that are not animated, but have a different root-pose position to the target shape root pose.
///    @return true if successful, false otherwise
///    @tsexample
///    %this.addSequence( \"./testShape.dts ambient\", \"ambient\" );
///    %this.addSequence( \"./myPlayer.dae run\", \"run\" );
///    %this.addSequence( \"./player_look.dsq\", \"look\", 0, -1 );     // start to end
///    %this.addSequence( \"walk\", \"walk_shortA\", 0, 4 );            // start to frame 4
///    %this.addSequence( \"walk\", \"walk_shortB\", 4, -1 );           // frame 4 to end
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool addSequence(string source, string name, int start = 0, int end = -1, bool padRot = true, bool padTrans = false){

return pInvokes.m_ts.fnTSShapeConstructor_addSequence(_ID, source, name, start, end, padRot, padTrans);
}
/// <summary>
/// Add a new trigger to the sequence.
///    @param name name of the sequence to modify
///    @param keyframe keyframe of the new trigger
///    @param state of the new trigger
///    @return true if successful, false otherwise
///    @tsexample
///    %this.addTrigger( \"walk\", 3, 1 );
///    %this.addTrigger( \"walk\", 5, -1 );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool addTrigger(string name, int keyframe, int state){

return pInvokes.m_ts.fnTSShapeConstructor_addTrigger(_ID, name, keyframe, state);
}
/// <summary>
/// Dump the shape hierarchy to the console or to a file. Useful for reviewing 
///    the result of a series of construction commands.
///    @param filename Destination filename. If not specified, dump to console.
///    @tsexample
///    %this.dumpShape();               // dump to console
///    %this.dumpShape( \"./dump.txt\" ); // dump to file
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void dumpShape(string filename = ""){

pInvokes.m_ts.fnTSShapeConstructor_dumpShape(_ID, filename);
}
/// <summary>
/// Get the bounding box for the shape.
///    @return Bounding box \"minX minY minZ maxX maxY maxZ\" )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Box3F getBounds(){

return new Box3F ( pInvokes.m_ts.fnTSShapeConstructor_getBounds(_ID));
}
/// <summary>
/// Get the total number of detail levels in the shape.
///    @return the number of detail levels in the shape )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getDetailLevelCount(){

return pInvokes.m_ts.fnTSShapeConstructor_getDetailLevelCount(_ID);
}
/// <summary>
/// Get the index of the detail level with a given size.
///    @param size size of the detail level to lookup
///    @return index of the detail level with the desired size, or -1 if no such 
///    detail exists
///    @tsexample
///    if ( %this.getDetailLevelSize( 32 ) == -1 )
///       echo( \"Error: This shape does not have a detail level at size 32\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getDetailLevelIndex(int size){

return pInvokes.m_ts.fnTSShapeConstructor_getDetailLevelIndex(_ID, size);
}
/// <summary>
/// Get the name of the indexed detail level.
///    @param index detail level index (valid range is 0 - getDetailLevelCount()-1)
///    @return the detail level name
///    @tsexample
///    // print the names of all detail levels in the shape
///    %count = %this.getDetailLevelCount();
///    for ( %i = 0; %i  %count; %i++ )
///       echo( %i SPC %this.getDetailLevelName( %i ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getDetailLevelName(int index){

return pInvokes.m_ts.fnTSShapeConstructor_getDetailLevelName(_ID, index);
}
/// <summary>
/// Get the size of the indexed detail level.
///    @param index detail level index (valid range is 0 - getDetailLevelCount()-1)
///    @return the detail level size
///    @tsexample
///    // print the sizes of all detail levels in the shape
///    %count = %this.getDetailLevelCount();
///    for ( %i = 0; %i  %count; %i++ )
///       echo( \"Detail\" @ %i @ \" has size \" @ %this.getDetailLevelSize( %i ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getDetailLevelSize(int index){

return pInvokes.m_ts.fnTSShapeConstructor_getDetailLevelSize(_ID, index);
}
/// <summary>
/// Get the index of the imposter (auto-billboard) detail level (if any).
///    @return imposter detail level index, or -1 if the shape does not use 
///    imposters. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getImposterDetailLevel(){

return pInvokes.m_ts.fnTSShapeConstructor_getImposterDetailLevel(_ID);
}
/// <summary>
/// Get the settings used to generate imposters for the indexed detail level.
///    @param index index of the detail level to query (does not need to be an 
///    imposter detail level
///    @return string of the form: \"valid eqSteps pSteps dl dim poles angle\", where:
///    dl>
///       dt>valid/dt>dd>1 if this detail level generates imposters, 0 otherwise/dd>
///       dt>eqSteps/dt>dd>number of steps around the equator/dd>
///       dt>pSteps/dt>dd>number of steps between the poles/dd>
///       dt>dl/dt>dd>index of the detail level used to generate imposters/dd>
///       dt>dim/dt>dd>size (in pixels) of each imposter image/dd>
///       dt>poles/dt>dd>1 to include pole images, 0 otherwise/dd>
///       dt>angle/dt>dd>angle at which to display pole images/dd>
///    /dl>
///    @tsexample
///    // print the imposter detail level settings
///    %index = %this.getImposterDetailLevel();
///    if ( %index != -1 )
///       echo( \"Imposter settings: \" @ %this.getImposterSettings( %index ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getImposterSettings(int index){

return pInvokes.m_ts.fnTSShapeConstructor_getImposterSettings(_ID, index);
}
/// <summary>
/// Get the number of meshes (detail levels) for the specified object.
///    @param name name of the object to query
///    @return the number of meshes for this object.
///    @tsexample
///    %count = %this.getMeshCount( \"SimpleShape\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMeshCount(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getMeshCount(_ID, name);
}
/// <summary>
/// Get the name of the material attached to a mesh. Note that only the first 
///    material used by the mesh is returned.
///    @param name full name (object name + detail size) of the mesh to query
///    @return name of the material attached to the mesh (suitable for use with the Material mapTo field)
///    @tsexample
///    echo( \"Mesh material is \" @ %this.sgetMeshMaterial( \"SimpleShape128\" ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMeshMaterial(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getMeshMaterial(_ID, name);
}
/// <summary>
/// Get the name of the indexed mesh (detail level) for the specified object.
///    @param name name of the object to query
///    @param index index of the mesh (valid range is 0 - getMeshCount()-1)
///    @return the mesh name.
///    @tsexample
///    // print the names of all meshes in the shape
///    %objCount = %this.getObjectCount();
///    for ( %i = 0; %i  %objCount; %i++ )
///    {
///       %objName = %this.getObjectName( %i );
///       %meshCount = %this.getMeshCount( %objName );
///       for ( %j = 0; %j  %meshCount; %j++ )
///          echo( %this.getMeshName( %objName, %j ) );
///    }
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMeshName(string name, int index){

return pInvokes.m_ts.fnTSShapeConstructor_getMeshName(_ID, name, index);
}
/// <summary>
/// Get the detail level size of the indexed mesh for the specified object.
///    @param name name of the object to query
///    @param index index of the mesh (valid range is 0 - getMeshCount()-1)
///    @return the mesh detail level size.
///    @tsexample
///    // print sizes for all detail levels of this object
///    %objName = \"trunk\";
///    %count = %this.getMeshCount( %objName );
///    for ( %i = 0; %i  %count; %i++ )
///       echo( %this.getMeshSize( %objName, %i ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMeshSize(string name, int index){

return pInvokes.m_ts.fnTSShapeConstructor_getMeshSize(_ID, name, index);
}
/// <summary>
/// Get the display type of the mesh.
///    @param name name of the mesh to query
///    @return the string returned is one of:
///    dl>dt>normal/dt>dd>a normal 3D mesh/dd>
///    dt>billboard/dt>dd>a mesh that always faces the camera/dd>
///    dt>billboardzaxis/dt>dd>a mesh that always faces the camera in the Z-axis/dd>/dl>
///    @tsexample
///    echo( \"Mesh type is \" @ %this.getMeshType( \"SimpleShape128\" ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMeshType(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getMeshType(_ID, name);
}
/// <summary>
/// Get the number of children of this node.
///    @param name name of the node to query.
///    @return the number of child nodes.
///    @tsexample
///    %count = %this.getNodeChildCount( \"Bip01 Pelvis\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNodeChildCount(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getNodeChildCount(_ID, name);
}
/// <summary>
/// Get the name of the indexed child node.
///    @param name name of the parent node to query.
///    @param index index of the child node (valid range is 0 - getNodeChildName()-1).
///    @return the name of the indexed child node.
///    @tsexample
///    function dumpNode( %shape, %name, %indent )
///    {
///       echo( %indent @ %name );
///       %count = %shape.getNodeChildCount( %name );
///       for ( %i = 0; %i  %count; %i++ )
///          dumpNode( %shape, %shape.getNodeChildName( %name, %i ), %indent @ \"   \" );
///    }
///    function dumpShape( %shape )
///    {
///       // recursively dump node hierarchy
///       %count = %shape.getNodeCount();
///       for ( %i = 0; %i  %count; %i++ )
///       {
///          // dump top level nodes
///          %name = %shape.getNodeName( %i );
///          if ( %shape.getNodeParentName( %name ) $=  )
///             dumpNode( %shape, %name, \"\" );
///       }
///    }
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getNodeChildName(string name, int index){

return pInvokes.m_ts.fnTSShapeConstructor_getNodeChildName(_ID, name, index);
}
/// <summary>
/// Get the total number of nodes in the shape.
///    @return the number of nodes in the shape.
///    @tsexample
///    %count = %this.getNodeCount();
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNodeCount(){

return pInvokes.m_ts.fnTSShapeConstructor_getNodeCount(_ID);
}
/// <summary>
/// Get the index of the node.
///    @param name name of the node to lookup.
///    @return the index of the named node, or -1 if no such node exists.
///    @tsexample
///    // get the index of Bip01 Pelvis node in the shape
///    %index = %this.getNodeIndex( \"Bip01 Pelvis\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNodeIndex(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getNodeIndex(_ID, name);
}
/// <summary>
/// Get the name of the indexed node.
///    @param index index of the node to lookup (valid range is 0 - getNodeCount()-1).
///    @return the name of the indexed node, or \"\" if no such node exists.
///    @tsexample
///    // print the names of all the nodes in the shape
///    %count = %this.getNodeCount();
///    for (%i = 0; %i  %count; %i++)
///       echo(%i SPC %this.getNodeName(%i));
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getNodeName(int index){

return pInvokes.m_ts.fnTSShapeConstructor_getNodeName(_ID, index);
}
/// <summary>
/// Get the number of geometry objects attached to this node.
///    @param name name of the node to query.
///    @return the number of attached objects.
///    @tsexample
///    %count = %this.getNodeObjectCount( \"Bip01 Head\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNodeObjectCount(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getNodeObjectCount(_ID, name);
}
/// <summary>
/// Get the name of the indexed object.
///    @param name name of the node to query.
///    @param index index of the object (valid range is 0 - getNodeObjectCount()-1).
///    @return the name of the indexed object.
///    @tsexample
///    // print the names of all objects attached to the node
///    %count = %this.getNodeObjectCount( \"Bip01 Head\" );
///    for ( %i = 0; %i  %count; %i++ )
///       echo( %this.getNodeObjectName( \"Bip01 Head\", %i ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getNodeObjectName(string name, int index){

return pInvokes.m_ts.fnTSShapeConstructor_getNodeObjectName(_ID, name, index);
}
/// <summary>
/// Get the name of the node's parent. If the node has no parent (ie. it is at 
///    the root level), return an empty string.
///    @param name name of the node to query.
///    @return the name of the node's parent, or \"\" if the node is at the root level
///    @tsexample
///    echo( \"Bip01 Pelvis parent = \" @ %this.getNodeParentName( \"Bip01 Pelvis \") );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getNodeParentName(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getNodeParentName(_ID, name);
}
/// <summary>
/// Get the base (ie. not animated) transform of a node.
///    @param name name of the node to query.
///    @param isWorld true to get the global transform, false (or omitted) to get 
///    the local-to-parent transform.
///    @return the node transform in the form \"pos.x pos.y pos.z rot.x rot.y rot.z rot.angle\".
///    @tsexample
///    %ret = %this.getNodeTransform( \"mount0\" );
///    %this.setNodeTransform( \"mount4\", %ret );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  TransformF getNodeTransform(string name, bool isWorld = false){

return new TransformF ( pInvokes.m_ts.fnTSShapeConstructor_getNodeTransform(_ID, name, isWorld));
}
/// <summary>
/// Get the total number of objects in the shape.
///    @return the number of objects in the shape.
///    @tsexample
///    %count = %this.getObjectCount();
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getObjectCount(){

return pInvokes.m_ts.fnTSShapeConstructor_getObjectCount(_ID);
}
/// <summary>
/// Get the index of the first object with the given name.
///    @param name name of the object to get.
///    @return the index of the named object.
///    @tsexample
///    %index = %this.getObjectIndex( \"Head\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getObjectIndex(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getObjectIndex(_ID, name);
}
/// <summary>
/// Get the name of the indexed object.
///    @param index index of the object to get (valid range is 0 - getObjectCount()-1).
///    @return the name of the indexed object.
///    @tsexample
///    // print the names of all objects in the shape
///    %count = %this.getObjectCount();
///    for ( %i = 0; %i  %count; %i++ )
///       echo( %i SPC %this.getObjectName( %i ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getObjectName(int index){

return pInvokes.m_ts.fnTSShapeConstructor_getObjectName(_ID, index);
}
/// <summary>
/// Get the name of the node this object is attached to.
///    @param name name of the object to get.
///    @return the name of the attached node, or an empty string if this 
///    object is not attached to a node (usually the case for skinned meshes).
///    @tsexample
///    echo( \"Hand is attached to \" @ %this.getObjectNode( \"Hand\" ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getObjectNode(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getObjectNode(_ID, name);
}
/// <summary>
/// Get information about blended sequences.
///    @param name name of the sequence to query
///    @return TAB delimited string of the form: \"isBlend blendSeq blendFrame\", where:
///    dl>
///    dt>blend_flag/dt>dd>a boolean flag indicating whether this sequence is a blend/dd>
///    dt>blend_seq_name/dt>dd>the name of the sequence that contains the reference 
///    frame (empty for blend sequences embedded in DTS files)/dd>
///    dt>blend_seq_frame/dt>dd>the blend reference frame (empty for blend sequences 
///    embedded in DTS files)/dd>
///    /dl>
///    @note Note that only sequences set to be blends using the setSequenceBlend 
///    command will contain the blendSeq and blendFrame information.
///    @tsexample
///    %blendData = %this.getSequenceBlend( \"look\" );
///    if ( getField( %blendData, 0 ) )
///       echo( \"look is a blend, reference: \" @ getField( %blendData, 1 ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSequenceBlend(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getSequenceBlend(_ID, name);
}
/// <summary>
/// Get the total number of sequences in the shape.
///    @return the number of sequences in the shape )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSequenceCount(){

return pInvokes.m_ts.fnTSShapeConstructor_getSequenceCount(_ID);
}
/// <summary>
/// Check if this sequence is cyclic (looping).
///    @param name name of the sequence to query
///    @return true if this sequence is cyclic, false if not
///    @tsexample
///    if ( !%this.getSequenceCyclic( \"ambient\" ) )
///       error( \"ambient sequence is not cyclic!\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getSequenceCyclic(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getSequenceCyclic(_ID, name);
}
/// <summary>
/// Get the number of keyframes in the sequence.
///    @param name name of the sequence to query
///    @return number of keyframes in the sequence
///    @tsexample
///    echo( \"Run has \" @ %this.getSequenceFrameCount( \"run\" ) @ \" keyframes\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSequenceFrameCount(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getSequenceFrameCount(_ID, name);
}
/// <summary>
/// Get the ground speed of the sequence.
///    @note Note that only the first 2 ground frames of the sequence are 
///    examined; the speed is assumed to be constant throughout the sequence.
///    @param name name of the sequence to query
///    @return string of the form: \"trans.x trans.y trans.z rot.x rot.y rot.z\"
///    @tsexample
///    %speed = VectorLen( getWords( %this.getSequenceGroundSpeed( \"run\" ), 0, 2 ) );
///       echo( \"Run moves at \" @ %speed @ \" units per frame\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSequenceGroundSpeed(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getSequenceGroundSpeed(_ID, name);
}
/// <summary>
/// Find the index of the sequence with the given name.
///    @param name name of the sequence to lookup
///    @return index of the sequence with matching name, or -1 if not found
///    @tsexample
///    // Check if a given sequence exists in the shape
///    if ( %this.getSequenceIndex( \"walk\" ) == -1 )
///       echo( \"Could not find 'walk' sequence\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSequenceIndex(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getSequenceIndex(_ID, name);
}
/// <summary>
/// Get the name of the indexed sequence.
///    @param index index of the sequence to query (valid range is 0 - getSequenceCount()-1)
///    @return the name of the sequence
///    @tsexample
///    // print the name of all sequences in the shape
///    %count = %this.getSequenceCount();
///    for ( %i = 0; %i  %count; %i++ )
///       echo( %i SPC %this.getSequenceName( %i ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSequenceName(int index){

return pInvokes.m_ts.fnTSShapeConstructor_getSequenceName(_ID, index);
}
/// <summary>
/// Get the priority setting of the sequence.
///    @param name name of the sequence to query
///    @return priority value of the sequence )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getSequencePriority(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getSequencePriority(_ID, name);
}
/// <summary>
/// Get information about where the sequence data came from.
///    For example, whether it was loaded from an external DSQ file.
///    @param name name of the sequence to query
///    @return TAB delimited string of the form: \"from reserved start end total\", where:
///    dl>
///       dt>from/dt>dd>the source of the animation data, such as the path to 
///       a DSQ file, or the name of an existing sequence in the shape. This field 
///       will be empty for sequences already embedded in the DTS or DAE file./dd>
///       dt>reserved/dt>dd>reserved value/dd>
///       dt>start/dt>dd>the first frame in the source sequence used to create this sequence/dd>
///       dt>end/dt>dd>the last frame in the source sequence used to create this sequence/dd>
///       dt>total/dt>dd>the total number of frames in the source sequence/dd>
///    /dl>
///    @tsexample
///    // print the source for the walk animation
///    echo( \"walk source:\" SPC getField( %this.getSequenceSource( \"walk\" ), 0 ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSequenceSource(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getSequenceSource(_ID, name);
}
/// <summary>
/// Get the number of materials in the shape.
///    @return the number of materials in the shape.
///    @tsexample
///    %count = %this.getTargetCount();
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getTargetCount(){

return pInvokes.m_ts.fnTSShapeConstructor_getTargetCount(_ID);
}
/// <summary>
/// Get the name of the indexed shape material.
///    @param index index of the material to get (valid range is 0 - getTargetCount()-1).
///    @return the name of the indexed material.
///    @tsexample
///    %count = %this.getTargetCount();
///    for ( %i = 0; %i  %count; %i++ )
///       echo( \"Target \" @ %i @ \": \" @ %this.getTargetName( %i ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTargetName(int index){

return pInvokes.m_ts.fnTSShapeConstructor_getTargetName(_ID, index);
}
/// <summary>
/// Get information about the indexed trigger
///    @param name name of the sequence to query
///    @param index index of the trigger (valid range is 0 - getTriggerCount()-1)
///    @return string of the form \"frame state\"
///    @tsexample
///    // print all triggers in the sequence
///    %count = %this.getTriggerCount( \"back\" );
///    for ( %i = 0; %i  %count; %i++ )
///       echo( %i SPC %this.getTrigger( \"back\", %i ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTrigger(string name, int index){

return pInvokes.m_ts.fnTSShapeConstructor_getTrigger(_ID, name, index);
}
/// <summary>
/// Get the number of triggers in the specified sequence.
///    @param name name of the sequence to query
///    @return number of triggers in the sequence )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getTriggerCount(string name){

return pInvokes.m_ts.fnTSShapeConstructor_getTriggerCount(_ID, name);
}
/// <summary>
/// Notify game objects that this shape file has changed, allowing them to update 
///    internal data if needed. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void notifyShapeChanged(){

pInvokes.m_ts.fnTSShapeConstructor_notifyShapeChanged(_ID);
}
/// <summary>
/// Remove the detail level (including all meshes in the detail level)
///    @param size size of the detail level to remove
///    @return true if successful, false otherwise
///    @tsexample
///    %this.removeDetailLevel( 2 );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool removeDetailLevel(int index){

return pInvokes.m_ts.fnTSShapeConstructor_removeDetailLevel(_ID, index);
}
/// <summary>
/// () Remove the imposter detail level (if any) from the shape.
///    @return true if successful, false otherwise )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool removeImposter(){

return pInvokes.m_ts.fnTSShapeConstructor_removeImposter(_ID);
}
/// <summary>
/// Remove a mesh from the shape.
///    If all geometry is removed from an object, the object is also removed.
///    @param name full name (object name + detail size) of the mesh to remove
///    @return true if successful, false otherwise
///    @tsexample
///    %this.removeMesh( \"SimpleShape128\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool removeMesh(string name){

return pInvokes.m_ts.fnTSShapeConstructor_removeMesh(_ID, name);
}
/// <summary>
/// Remove a node from the shape.
///    The named node is removed from the shape, including from any sequences that 
///    use the node. Child nodes and objects attached to the node are re-assigned 
///    to the node's parent.
///    @param name name of the node to remove.
///    @return true if successful, false otherwise.
///    @tsexample
///    %this.removeNode( \"Nose\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool removeNode(string name){

return pInvokes.m_ts.fnTSShapeConstructor_removeNode(_ID, name);
}
/// <summary>
/// Remove an object (including all meshes for that object) from the shape.
///    @param name name of the object to remove.
///    @return true if successful, false otherwise.
///    @tsexample
///    // clear all objects in the shape
///    %count = %this.getObjectCount();
///    for ( %i = %count-1; %i >= 0; %i-- )
///       %this.removeObject( %this.getObjectName(%i) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool removeObject(string name){

return pInvokes.m_ts.fnTSShapeConstructor_removeObject(_ID, name);
}
/// <summary>
/// Remove the sequence from the shape.
///    @param name name of the sequence to remove
///    @return true if successful, false otherwise )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool removeSequence(string name){

return pInvokes.m_ts.fnTSShapeConstructor_removeSequence(_ID, name);
}
/// <summary>
/// Remove a trigger from the sequence.
///    @param name name of the sequence to modify
///    @param keyframe keyframe of the trigger to remove
///    @param state of the trigger to remove
///    @return true if successful, false otherwise
///    @tsexample
///    %this.removeTrigger( \"walk\", 3, 1 );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool removeTrigger(string name, int keyframe, int state){

return pInvokes.m_ts.fnTSShapeConstructor_removeTrigger(_ID, name, keyframe, state);
}
/// <summary>
/// Rename a detail level.
///    @note Note that detail level names must be unique, so this command will 
///    fail if there is already a detail level with the desired name
///    @param oldName current name of the detail level
///    @param newName new name of the detail level
///    @return true if successful, false otherwise
///    @tsexample
///    %this.renameDetailLevel( \"detail-1\", \"collision-1\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool renameDetailLevel(string oldName, string newName){

return pInvokes.m_ts.fnTSShapeConstructor_renameDetailLevel(_ID, oldName, newName);
}
/// <summary>
/// Rename a node.
///    @note Note that node names must be unique, so this command will fail if 
///    there is already a node with the desired name
///    @param oldName current name of the node
///    @param newName new name of the node
///    @return true if successful, false otherwise
///    @tsexample
///    %this.renameNode( \"Bip01 L Hand\", \"mount5\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool renameNode(string oldName, string newName){

return pInvokes.m_ts.fnTSShapeConstructor_renameNode(_ID, oldName, newName);
}
/// <summary>
/// Rename an object.
///    @note Note that object names must be unique, so this command will fail if 
///    there is already an object with the desired name
///    @param oldName current name of the object
///    @param newName new name of the object
///    @return true if successful, false otherwise
///    @tsexample
///    %this.renameObject( \"MyBox\", \"Box\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool renameObject(string oldName, string newName){

return pInvokes.m_ts.fnTSShapeConstructor_renameObject(_ID, oldName, newName);
}
/// <summary>
/// Rename a sequence.
///    @note Note that sequence names must be unique, so this command will fail 
///    if there is already a sequence with the desired name
///    @param oldName current name of the sequence
///    @param newName new name of the sequence
///    @return true if successful, false otherwise
///    @tsexample
///    %this.renameSequence( \"walking\", \"walk\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool renameSequence(string oldName, string newName){

return pInvokes.m_ts.fnTSShapeConstructor_renameSequence(_ID, oldName, newName);
}
/// <summary>
/// Save the shape (with all current changes) to a new DTS file.
///    @param filename Destination filename.
///    @tsexample
///    %this.saveShape( \"./myShape.dts\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void saveShape(string filename){

pInvokes.m_ts.fnTSShapeConstructor_saveShape(_ID, filename);
}
/// <summary>
/// Set the shape bounds to the given bounding box.
///    @param Bounding box \"minX minY minZ maxX maxY maxZ\"
///    @return true if successful, false otherwise )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setBounds(Box3F bbox){

return pInvokes.m_ts.fnTSShapeConstructor_setBounds(_ID, bbox.AsString());
}
/// <summary>
/// Change the size of a detail level.
///    @note Note that detail levels are always sorted in decreasing size order, 
///    so this command may cause detail level indices to change.
///    @param index index of the detail level to modify
///    @param newSize new size for the detail level
///    @return new index for this detail level
///    @tsexample
///    %this.setDetailLevelSize( 2, 256 );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int setDetailLevelSize(int index, int newSize){

return pInvokes.m_ts.fnTSShapeConstructor_setDetailLevelSize(_ID, index, newSize);
}
/// <summary>
/// Set the name of the material attached to the mesh.
///    @param meshName full name (object name + detail size) of the mesh to modify
///    @param matName name of the material to attach. This could be the base name of 
///    the diffuse texture (eg. \"test_mat\" for \"test_mat.jpg\"), or the name of a 
///    Material object already defined in script.
///    @return true if successful, false otherwise
///    @tsexample
///    // set the mesh material
///    %this.setMeshMaterial( \"SimpleShape128\", \"test_mat\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setMeshMaterial(string meshName, string matName){

return pInvokes.m_ts.fnTSShapeConstructor_setMeshMaterial(_ID, meshName, matName);
}
/// <summary>
/// Change the detail level size of the named mesh.
///    @param name full name (object name + current size ) of the mesh to modify
///    @param size new detail level size
///    @return true if successful, false otherwise.
///    @tsexample
///    %this.setMeshSize( \"SimpleShape128\", 64 );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setMeshSize(string name, int size){

return pInvokes.m_ts.fnTSShapeConstructor_setMeshSize(_ID, name, size);
}
/// <summary>
/// Set the display type for the mesh.
///    @param name full name (object name + detail size) of the mesh to modify
///    @param type the new type for the mesh: \"normal\", \"billboard\" or \"billboardzaxis\"
///    @return true if successful, false otherwise
///    @tsexample
///    // set the mesh to be a billboard
///    %this.setMeshType( \"SimpleShape64\", \"billboard\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setMeshType(string name, string type){

return pInvokes.m_ts.fnTSShapeConstructor_setMeshType(_ID, name, type);
}
/// <summary>
/// Set the parent of a node.
///   @param name name of the node to modify
///   @param parentName name of the parent node to set (use \"\" to move the node to the root level)
///   @return true if successful, false if failed
///   @tsexample
///   %this.setNodeParent( \"Bip01 Pelvis\", \"start01\" );
///   @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setNodeParent(string name, string parentName){

return pInvokes.m_ts.fnTSShapeConstructor_setNodeParent(_ID, name, parentName);
}
/// <summary>
/// Set the base transform of a node. That is, the transform of the node when 
///    in the root (not-animated) pose.
///    @param name name of the node to modify
///    @param txfm transform string of the form: \"pos.x pos.y pos.z rot.x rot.y rot.z rot.angle\"
///    @param isworld (optional) flag to set the local-to-parent or the global 
///    transform. If false, or not specified, the position and orientation are 
///    treated as relative to the node's parent.
///    @return true if successful, false otherwise
///    @tsexample
///    %this.setNodeTransform( \"mount0\", \"0 0 1 0 0 1 0\" );
///    %this.setNodeTransform( \"mount0\", \"0 0 0 0 0 1 1.57\" );
///    %this.setNodeTransform( \"mount0\", \"1 0 0 0 0 1 0\", true );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setNodeTransform(string name, TransformF txfm, bool isWorld = false){

return pInvokes.m_ts.fnTSShapeConstructor_setNodeTransform(_ID, name, txfm.AsString(), isWorld);
}
/// <summary>
/// Set the node an object is attached to.
///    When the shape is rendered, the object geometry is rendered at the node's 
///    current transform.
///    @param objName name of the object to modify
///    @param nodeName name of the node to attach the object to
///    @return true if successful, false otherwise
///    @tsexample
///    %this.setObjectNode( \"Hand\", \"Bip01 LeftHand\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setObjectNode(string objName, string nodeName){

return pInvokes.m_ts.fnTSShapeConstructor_setObjectNode(_ID, objName, nodeName);
}
/// <summary>
/// Mark a sequence as a blend or non-blend.
///    A blend sequence is one that will be added on top of any other playing 
///    sequences. This is done by storing the animated node transforms relative 
///    to a reference frame, rather than as absolute transforms.
///    @param name name of the sequence to modify
///    @param blend true to make the sequence a blend, false for a non-blend
///    @param blendSeq the name of the sequence that contains the blend reference frame
///    @param blendFrame the reference frame in the blendSeq sequence
///    @return true if successful, false otherwise
///    @tsexample
///    %this.setSequenceBlend( \"look\", true, \"root\", 0 );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setSequenceBlend(string name, bool blend, string blendSeq, int blendFrame){

return pInvokes.m_ts.fnTSShapeConstructor_setSequenceBlend(_ID, name, blend, blendSeq, blendFrame);
}
/// <summary>
/// Mark a sequence as cyclic or non-cyclic.
///    @param name name of the sequence to modify
///    @param cyclic true to make the sequence cyclic, false for non-cyclic
///    @return true if successful, false otherwise
///    @tsexample
///    %this.setSequenceCyclic( \"ambient\", true );
///    %this.setSequenceCyclic( \"shoot\", false );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setSequenceCyclic(string name, bool cyclic){

return pInvokes.m_ts.fnTSShapeConstructor_setSequenceCyclic(_ID, name, cyclic);
}
/// <summary>
/// Set the translation and rotation ground speed of the sequence.
///    The ground speed of the sequence is set by generating ground transform 
///    keyframes. The ground translational and rotational speed is assumed to 
///    be constant for the duration of the sequence. Existing ground frames for 
///    the sequence (if any) will be replaced.
///    @param name name of the sequence to modify
///    @param transSpeed translational speed (trans.x trans.y trans.z) in 
///    Torque units per frame
///    @param rotSpeed (optional) rotational speed (rot.x rot.y rot.z) in 
///    radians per frame. Default is \"0 0 0\"
///    @return true if successful, false otherwise
///    @tsexample
///    %this.setSequenceGroundSpeed( \"run\", \"5 0 0\" );
///    %this.setSequenceGroundSpeed( \"spin\", \"0 0 0\", \"4 0 0\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setSequenceGroundSpeed(string name, Point3F transSpeed, Point3F rotSpeed = null ){
if (rotSpeed== null) {rotSpeed = new Point3F(0.0f, 0.0f, 0.0f);}

return pInvokes.m_ts.fnTSShapeConstructor_setSequenceGroundSpeed(_ID, name, transSpeed.AsString(), rotSpeed.AsString());
}
/// <summary>
/// Set the sequence priority.
///    @param name name of the sequence to modify
///    @param priority new priority value
///    @return true if successful, false otherwise )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setSequencePriority(string name, float priority){

return pInvokes.m_ts.fnTSShapeConstructor_setSequencePriority(_ID, name, priority);
}
/// <summary>
/// Write the current change set to a TSShapeConstructor script file. The 
///    name of the script file is the same as the model, but with .cs extension. 
///    eg. myShape.cs for myShape.dts or myShape.dae. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void writeChangeSet(){

pInvokes.m_ts.fnTSShapeConstructor_writeChangeSet(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the DTS or DAE resource is flushed from memory. Not normally    required, but may be useful to perform cleanup. )ImplementEnumType( TSShapeConstructorUpAxis,   Axis to use for upwards direction when importing from Collada.   @ingroup TSShapeConstructor )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onUnload(){}

#endregion
public TSShapeConstructor_Base (){}
}}
