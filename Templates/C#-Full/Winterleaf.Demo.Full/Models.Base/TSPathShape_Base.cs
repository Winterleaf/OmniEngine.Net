


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
    [TypeConverter(typeof(TypeConverterGeneric<TSPathShape_Base>))]
    public partial class TSPathShape_Base: TSDynamic
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TSPathShape_Base ts, string simobjectid)
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
        public static bool operator !=(TSPathShape_Base ts, string simobjectid)
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
        public static implicit operator string( TSPathShape_Base ts)
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
        public static implicit operator TSPathShape_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TSPathShape_Base) Omni.self.getSimObject(simobjectid,typeof(TSPathShape_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TSPathShape_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TSPathShape_Base(int simobjectid)
            {
            return  (TSPathShape) Omni.self.getSimObject((uint)simobjectid,typeof(TSPathShape_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TSPathShape_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TSPathShape_Base(uint simobjectid)
            {
            return  (TSPathShape_Base) Omni.self.getSimObject(simobjectid,typeof(TSPathShape_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The shape movement direction/state. 
/// </summary>
[MemberGroup("Movement")]
public TypePathShapeState movementState
       {
       get
          {          return (TypePathShapeState) Omni.self.GetVar(_ID + ".movementState");
          }
       set
          {
          Omni.self.SetVar(_ID + ".movementState", value.ToString());
          }
       }
/// <summary>
/// Name of a Path to follow. 
/// </summary>
[MemberGroup("Movement")]
public Path Path
       {
       get
          {
          return Omni.self.GetVar(_ID + ".Path");
          }
       set
          {
          Omni.self.SetVar(_ID + ".Path", value.ToString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Returns the looping state for the shape.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getLooping(){

return pInvokes.m_ts.fnTSPathShape_getLooping(_ID);
}
/// <summary>
/// Returns the number of nodes on the shape's path.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNodeCount(){

return pInvokes.m_ts.fnTSPathShape_getNodeCount(_ID);
}
/// <summary>
/// Get the current position of the shape along the path (0.0 - lastNode - 1).)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getPathPosition(){

return pInvokes.m_ts.fnTSPathShape_getPathPosition(_ID);
}
/// <summary>
/// Removes the knot at the front of the shape's path.
/// 													@tsexample
/// 														// Remove the first knot in the shape's path.
/// 														%pathShape.popFront();
/// 													@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void popFront(){

pInvokes.m_ts.fnTSPathShape_popFront(_ID);
}
/// <summary>
/// Normal, Linear), 
/// 											      @brief Adds a new knot to the back of a shape's path.
/// 													@param transform Transform for the new knot.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()
/// 													@param speed Speed setting for this knot.
/// 													@param type Knot type (Normal, Position Only, Kink).
/// 													@param path %Path type (Linear, Spline).
/// 													@tsexample
/// 														// Transform vector for new knot. (Pos_X Pos_Y Pos_Z Rot_X Rot_Y Rot_Z Angle)
/// 														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"
/// 														// Speed setting for knot.
/// 														%speed = \"1.0\"
/// 														// Knot type. (Normal, Position Only, Kink)
/// 														%type = \"Normal\";
/// 														// Path Type. (Linear, Spline)
/// 														%path = \"Linear\";
/// 														// Inform the shape to add a new knot to the back of its path
/// 														%pathShape.pushBack(%transform,%speed,%type,%path);
/// 													@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pushBack(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear"){

pInvokes.m_ts.fnTSPathShape_pushBack(_ID, transform.AsString(), speed, type, path);
}
/// <summary>
/// Normal, Linear), 
/// 											      @brief Adds a new knot to the front of a path shape's path.
/// 													@param transform Transform for the new knot. In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()
/// 													@param speed Speed setting for this knot.
/// 													@param type Knot type (Normal, Position Only, Kink).
/// 													@param path %Path type (Linear, Spline).
/// 													@tsexample
/// 														// Transform vector for new knot. (Pos_X,Pos_Y,Pos_Z,Rot_X,Rot_Y,Rot_Z,Angle)
/// 														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"
/// 														// Speed setting for knot.
/// 														%speed = \"1.0\";
/// 														// Knot type. (Normal, Position Only, Kink)
/// 														%type = \"Normal\";
/// 														// Path Type. (Linear, Spline)
/// 														%path = \"Linear\";
/// 														// Inform the shape to add a new knot to the front of its path
/// 														%pathShape.pushFront(%transform, %speed, %type, %path);
/// 													@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pushFront(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear"){

pInvokes.m_ts.fnTSPathShape_pushFront(_ID, transform.AsString(), speed, type, path);
}
/// <summary>
/// @brief Clear the shapes's path and optionally initializes the first node with the shapes current transform and speed.
///          The shapes movement is stopped and any current path is cleared. The target and position values are both reset to 0. 
///          When makeFirstKnot is true a new knot is created and pushed onto the path.
///          @param speed Speed for the first knot if created.
///          @param makeFirstKnot Initialize a new path with the current shape transform.
///          @param initFromPath Initialize the knot type and smoothing values from the current path.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reset(float speed = 1.0f, bool makeFirstKnot = true, bool initFromPath = true){

pInvokes.m_ts.fnTSPathShape_reset(_ID, speed, makeFirstKnot, initFromPath);
}
/// <summary>
/// Sets whether the path should loop or stop at the last node.
/// 													@param isLooping New loop flag true/false.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setLooping(bool isLooping = true){

pInvokes.m_ts.fnTSPathShape_setLooping(_ID, isLooping);
}
/// <summary>
/// Set the movement state for this shape.
/// 													@param newState New movement state type for this shape. Forward, Backward or Stop.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMoveState(TypePathShapeState newState = null ){
if (newState== null) {newState = TypePathShapeState.Forward;}

pInvokes.m_ts.fnTSPathShape_setMoveState(_ID, (int)newState );
}
/// <summary>
/// Set the current position of the shape along the path.
/// 													@param position Position along the path, from 0.0 (path start) - 1.0 (path end), to place the shape.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPathPosition(float position = 0.0f){

pInvokes.m_ts.fnTSPathShape_setPathPosition(_ID, position);
}
/// <summary>
/// @brief Set the movement target for this shape along its path.
///                                        The shape will attempt to move along the path to the given target without going past the loop node. 
///                                        Once the shape arrives at the target,the onTargetReached() callback will be triggered and the target 
///                                        state will be cleared.
/// 													@param position Target position, between 0.0 (path start) and nodeCount - 1 (path end), for the 
///                                        shape to move to along its path.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTarget(float position = 1.0f){

pInvokes.m_ts.fnTSPathShape_setTarget(_ID, position);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when this TSPathShape is added to the system.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(){}

        /// <summary>
        /// Called when the path variable for this this TSPathShape has been changed from script or editor.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPathChange(){}

        /// <summary>
        /// A script callback that indicates the path shape has arrived at a specific node in its path.  Server side only.					@param Node The index number for the node reached.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onNode(int node){}

        /// <summary>
        /// A script callback that indicates the path shape has arrived at it's target value.  Server side only.					@param value The current position value.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTargetReached(float value){}

#endregion
public TSPathShape_Base (){}
}}
