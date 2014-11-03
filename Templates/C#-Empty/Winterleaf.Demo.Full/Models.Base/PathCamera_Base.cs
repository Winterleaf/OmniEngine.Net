


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
    [TypeConverter(typeof(TypeConverterGeneric<PathCamera_Base>))]
    public partial class PathCamera_Base: ShapeBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PathCamera_Base ts, string simobjectid)
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
        public static bool operator !=(PathCamera_Base ts, string simobjectid)
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
        public static implicit operator string( PathCamera_Base ts)
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
        public static implicit operator PathCamera_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (PathCamera_Base) Omni.self.getSimObject(simobjectid,typeof(PathCamera_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( PathCamera_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PathCamera_Base(int simobjectid)
            {
            return  (PathCamera) Omni.self.getSimObject((uint)simobjectid,typeof(PathCamera_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( PathCamera_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PathCamera_Base(uint simobjectid)
            {
            return  (PathCamera_Base) Omni.self.getSimObject(simobjectid,typeof(PathCamera_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Removes the knot at the front of the camera's path.
/// 													@tsexample
/// 														// Remove the first knot in the camera's path.
/// 														%pathCamera.popFront();
/// 													@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void popFront(){

pInvokes.m_ts.fnPathCamera_popFront(_ID);
}
/// <summary>
/// Normal, Linear), 
/// 											      @brief Adds a new knot to the back of a path camera's path.
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
/// 														// Inform the path camera to add a new knot to the back of its path
/// 														%pathCamera.pushBack(%transform,%speed,%type,%path);
/// 													@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pushBack(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear"){

pInvokes.m_ts.fnPathCamera_pushBack(_ID, transform.AsString(), speed, type, path);
}
/// <summary>
/// Normal, Linear), 
/// 											      @brief Adds a new knot to the front of a path camera's path.
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
/// 														// Inform the path camera to add a new knot to the front of its path
/// 														%pathCamera.pushFront(%transform, %speed, %type, %path);
/// 													@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pushFront(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear"){

pInvokes.m_ts.fnPathCamera_pushFront(_ID, transform.AsString(), speed, type, path);
}
/// <summary>
/// @brief Clear the camera's path and set the camera's current transform as the start of the new path.
///                                        What specifically occurs is a new knot is created from the camera's current transform.  Then the current path 
///                                        is cleared and the new knot is pushed onto the path.  Any previous target is cleared and the camera's movement 
///                                        state is set to Forward.  The camera is now ready for a new path to be defined.
/// 													@param speed Speed for the camera to move along its path after being reset.
/// 													@tsexample
/// 														//Determine the new movement speed of this camera. If not set, the speed will default to 1.0.
/// 														%speed = \"0.50\";
/// 														// Inform the path camera to start a new path at
///                                           // the camera's current position, and set the new 
///                                           // path's speed value.
/// 														%pathCamera.reset(%speed);
///                                        @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reset(float speed = 1.0f){

pInvokes.m_ts.fnPathCamera_reset(_ID, speed);
}
/// <summary>
/// Set the current position of the camera along the path.
/// 													@param position Position along the path, from 0.0 (path start) - 1.0 (path end), to place the camera.
/// 													@tsexample
///                                           // Set the camera on a position along its path from 0.0 - 1.0.
/// 														%position = \"0.35\";
/// 														// Force the pathCamera to its new position along the path.
/// 														%pathCamera.setPosition(%position);
/// 													@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPosition(float position = 0.0f){

pInvokes.m_ts.fnPathCamera_setPosition(_ID, position);
}
/// <summary>
/// forward), Set the movement state for this path camera.
/// 													@param newState New movement state type for this camera. Forward, Backward or Stop.
/// 													@tsexample
/// 														// Set the state type (forward, backward, stop).
///                                           // In this example, the camera will travel from the first node
///                                           // to the last node (or target if given with setTarget())
/// 														%state = \"forward\";
/// 														// Inform the pathCamera to change its movement state to the defined value.
/// 														%pathCamera.setState(%state);
/// 													@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setState(string newState = "forward"){

pInvokes.m_ts.fnPathCamera_setState(_ID, newState);
}
/// <summary>
/// @brief Set the movement target for this camera along its path.
///                                        The camera will attempt to move along the path to the given target in the direction provided 
///                                        by setState() (the default is forwards).  Once the camera moves past this target it will come 
///                                        to a stop, and the target state will be cleared.
/// 													@param position Target position, between 0.0 (path start) and 1.0 (path end), for the camera to move to along its path.
/// 													@tsexample
///                                           // Set the position target, between 0.0 (path start) and 1.0 (path end), for this camera to move to.
/// 														%position = \"0.50\";
/// 														// Inform the pathCamera of the new target position it will move to.
/// 														%pathCamera.setTarget(%position);
/// 													@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTarget(float position = 1.0f){

pInvokes.m_ts.fnPathCamera_setTarget(_ID, position);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// A script callback that indicates the path camera has arrived at a specific node in its path.  Server side only.					@param Node Unique ID assigned to this node.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onNode(string node){}

#endregion
public PathCamera_Base (){}
}}
