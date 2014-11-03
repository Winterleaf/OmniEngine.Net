


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
    [TypeConverter(typeof(TypeConverterGeneric<Camera_Base>))]
    public partial class Camera_Base: ShapeBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Camera_Base ts, string simobjectid)
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
        public static bool operator !=(Camera_Base ts, string simobjectid)
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
        public static implicit operator string( Camera_Base ts)
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
        public static implicit operator Camera_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Camera_Base) Omni.self.getSimObject(simobjectid,typeof(Camera_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Camera_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Camera_Base(int simobjectid)
            {
            return  (Camera) Omni.self.getSimObject((uint)simobjectid,typeof(Camera_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Camera_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Camera_Base(uint simobjectid)
            {
            return  (Camera_Base) Omni.self.getSimObject(simobjectid,typeof(Camera_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Drag on camera when rotating (Newton mode only). Default value is 2. 
/// </summary>
[MemberGroup("Camera: Newton Mode")]
public float angularDrag
       {
       get
          {
          return Omni.self.GetVar(_ID + ".angularDrag").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".angularDrag", value.AsString());
          }
       }
/// <summary>
/// Force applied on camera when asked to rotate (Newton mode only). Default value is 100. 
/// </summary>
[MemberGroup("Camera: Newton Mode")]
public float angularForce
       {
       get
          {
          return Omni.self.GetVar(_ID + ".angularForce").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".angularForce", value.AsString());
          }
       }
/// <summary>
/// Speed multiplier when triggering the brake (Newton mode only). Default value is 2. 
/// </summary>
[MemberGroup("Camera: Newton Mode")]
public float brakeMultiplier
       {
       get
          {
          return Omni.self.GetVar(_ID + ".brakeMultiplier").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".brakeMultiplier", value.AsString());
          }
       }
/// <summary>
/// The current camera control mode. 
/// </summary>
[MemberGroup("Camera")]
public TypeCameraMotionMode controlMode
       {
       get
          {          return (TypeCameraMotionMode) Omni.self.GetVar(_ID + ".controlMode");
          }
       set
          {
          Omni.self.SetVar(_ID + ".controlMode", value.ToString());
          }
       }
/// <summary>
/// Drag on camera when moving (Newton mode only). Default value is 2. 
/// </summary>
[MemberGroup("Camera: Newton Mode")]
public float drag
       {
       get
          {
          return Omni.self.GetVar(_ID + ".drag").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".drag", value.AsString());
          }
       }
/// <summary>
/// Force applied on camera when asked to move (Newton mode only). Default value is 500. 
/// </summary>
[MemberGroup("Camera: Newton Mode")]
public float force
       {
       get
          {
          return Omni.self.GetVar(_ID + ".force").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".force", value.AsString());
          }
       }
/// <summary>
/// The camera's mass (Newton mode only). Default value is 10. 
/// </summary>
[MemberGroup("Camera: Newton Mode")]
public float mass
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mass").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mass", value.AsString());
          }
       }
/// <summary>
/// Apply smoothing (acceleration and damping) to camera movements. 
/// </summary>
[MemberGroup("Camera: Newton Mode")]
public bool newtonMode
       {
       get
          {
          return Omni.self.GetVar(_ID + ".newtonMode").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".newtonMode", value.AsString());
          }
       }
/// <summary>
/// Apply smoothing (acceleration and damping) to camera rotations. 
/// </summary>
[MemberGroup("Camera: Newton Mode")]
public bool newtonRotation
       {
       get
          {
          return Omni.self.GetVar(_ID + ".newtonRotation").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".newtonRotation", value.AsString());
          }
       }
/// <summary>
/// Speed multiplier when triggering the accelerator (Newton mode only). Default value is 2. 
/// </summary>
[MemberGroup("Camera: Newton Mode")]
public float speedMultiplier
       {
       get
          {
          return Omni.self.GetVar(_ID + ".speedMultiplier").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".speedMultiplier", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Move the camera to fully view the given radius.
///                    @note For this operation to take affect a valid edit orbit point must first be specified.  See Camera::setEditOrbitPoint().
///                    @param radius The radius to view.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void autoFitRadius(float radius){

pInvokes.m_ts.fnCamera_autoFitRadius(_ID, radius);
}
/// <summary>
/// Get the angular velocity for a Newton mode camera.
///                    @returns The angular velocity in the form of \"x y z\".
///                    @note Only returns useful results when Camera::newtonRotation is set to true.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getAngularVelocity(){

return new Point3F ( pInvokes.m_ts.fnCamera_getAngularVelocity(_ID));
}
/// <summary>
/// Returns the current camera control mode.
///                    @see CameraMotionMode)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  TypeCameraMotionMode getMode(){

return (TypeCameraMotionMode)( pInvokes.m_ts.fnCamera_getMode(_ID));
}
/// <summary>
/// Get the camera's offset from its orbit or tracking point.
///                    The offset is added to the camera's position when set to CameraMode::OrbitObject.
///                    @returns The offset in the form of \"x y z\".)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getOffset(){

return new Point3F ( pInvokes.m_ts.fnCamera_getOffset(_ID));
}
/// <summary>
/// Get the camera's position in the world.
///                    @returns The position in the form of \"x y z\".)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  Point3F getPosition(){

return new Point3F ( pInvokes.m_ts.fnCamera_getPosition(_ID));
}
/// <summary>
/// Get the camera's Euler rotation in radians.
///                    @returns The rotation in radians in the form of \"x y z\".)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getRotation(){

return new Point3F ( pInvokes.m_ts.fnCamera_getRotation(_ID));
}
/// <summary>
/// Get the velocity for the camera.
///                    @returns The camera's velocity in the form of \"x y z\".
///                    @note Only useful when the Camera is in Newton mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  Point3F getVelocity(){

return new Point3F ( pInvokes.m_ts.fnCamera_getVelocity(_ID));
}
/// <summary>
/// Is the camera in edit orbit mode?
///                    @returns true if the camera is in edit orbit mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isEditOrbitMode(){

return pInvokes.m_ts.fnCamera_isEditOrbitMode(_ID);
}
/// <summary>
/// Is this a Newton Fly mode camera with damped rotation?
///                     @returns true if the camera uses a damped rotation.  i.e. Camera::newtonRotation is set to true.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isRotationDamped(){

return pInvokes.m_ts.fnCamera_isRotationDamped(_ID);
}
/// <summary>
/// Point the camera at the specified position.  Does not work in Orbit or Track modes.
///                    @param point The position to point the camera at.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void lookAt(Point3F point){

pInvokes.m_ts.fnCamera_lookAt(_ID, point.AsString());
}
/// <summary>
/// Set the angular drag for a Newton mode camera.
///                    @param drag The angular drag applied while the camera is rotating.
///                    @note Only takes affect when Camera::newtonRotation is set to true.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAngularDrag(float drag){

pInvokes.m_ts.fnCamera_setAngularDrag(_ID, drag);
}
/// <summary>
/// Set the angular force for a Newton mode camera.
///                    @param force The angular force applied when attempting to rotate the camera.
///                    @note Only takes affect when Camera::newtonRotation is set to true.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAngularForce(float force){

pInvokes.m_ts.fnCamera_setAngularForce(_ID, force);
}
/// <summary>
/// Set the angular velocity for a Newton mode camera.
///                    @param velocity The angular velocity infor form of \"x y z\".
///                    @note Only takes affect when Camera::newtonRotation is set to true.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAngularVelocity(Point3F velocity){

pInvokes.m_ts.fnCamera_setAngularVelocity(_ID, velocity.AsString());
}
/// <summary>
/// Set the Newton mode camera brake multiplier when trigger[1] is active.
///                    @param multiplier The brake multiplier to apply.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBrakeMultiplier(float multiplier){

pInvokes.m_ts.fnCamera_setBrakeMultiplier(_ID, multiplier);
}
/// <summary>
/// Set the drag for a Newton mode camera.
///                    @param drag The drag applied to the camera while moving.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDrag(float drag){

pInvokes.m_ts.fnCamera_setDrag(_ID, drag);
}
/// <summary>
/// Set the editor camera to orbit around a point set with Camera::setEditOrbitPoint().
///                     @note This method is generally used only within the World Editor and other tools.  To 
///                     orbit about an object or point within a game, see Camera::setOrbitMode() and its helper methods.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setEditOrbitMode(){

pInvokes.m_ts.fnCamera_setEditOrbitMode(_ID);
}
/// <summary>
/// Set the editor camera's orbit point.
///                    @param point The point the camera will orbit in the form of \"x y z\".)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setEditOrbitPoint(Point3F point){

pInvokes.m_ts.fnCamera_setEditOrbitPoint(_ID, point.AsString());
}
/// <summary>
/// Set the force applied to a Newton mode camera while moving.
///                    @param force The force applied to the camera while attempting to move.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFlyForce(float force){

pInvokes.m_ts.fnCamera_setFlyForce(_ID, force);
}
/// <summary>
/// Set the camera to fly freely.
///                    Allows the camera to have 6 degrees of freedom.  Provides for instantaneous motion 
///                    and rotation unless one of the Newton fields has been set to true.  See Camera::newtonMode 
///                    and Camera::newtonRotation.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFlyMode(){

pInvokes.m_ts.fnCamera_setFlyMode(_ID);
}
/// <summary>
/// Set the mass for a Newton mode camera.
///                    @param mass The mass used during ease-in and ease-out calculations.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMass(float mass){

pInvokes.m_ts.fnCamera_setMass(_ID, mass);
}
/// <summary>
/// Set the camera to fly freely, but with ease-in and ease-out.
///                     This method allows for the same 6 degrees of freedom as Camera::setFlyMode() but 
///                     activates the ease-in and ease-out on the camera's movement.  To also activate 
///                     Newton mode for the camera's rotation, set Camera::newtonRotation to true.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNewtonFlyMode(){

pInvokes.m_ts.fnCamera_setNewtonFlyMode(_ID);
}
/// <summary>
/// Set the camera's offset.
///                    The offset is added to the camera's position when set to CameraMode::OrbitObject.
///                    @param offset The distance to offset the camera by in the form of \"x y z\".)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setOffset(Point3F offset){

pInvokes.m_ts.fnCamera_setOffset(_ID, offset.AsString());
}
/// <summary>
/// Set the camera to orbit around the given object, or if none is given, around the given point.
///                     @param orbitObject The object to orbit around.  If no object is given (0 or blank string is passed in) use the orbitPoint instead
///                     @param orbitPoint The point to orbit around when no object is given.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform().
///                     @param minDistance The minimum distance allowed to the orbit object or point.
///                     @param maxDistance The maximum distance allowed from the orbit object or point.
///                     @param initDistance The initial distance from the orbit object or point.
///                     @param ownClientObj [optional] Are we orbiting an object that is owned by us?  Default is false.
///                     @param offset [optional] An offset added to the camera's position.  Default is no offset.
///                     @param locked [optional] Indicates the camera does not receive input from the player.  Default is false.
///                     @see Camera::setOrbitObject()
///                     @see Camera::setOrbitPoint())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setOrbitMode(string orbitObject, TransformF orbitPoint, float minDistance, float maxDistance, float initDistance, bool ownClientObj = false, Point3F offset = null , bool lockedx = false){
if (offset== null) {offset = new Point3F(0.0f, 0.0f, 0.0f);}

pInvokes.m_ts.fnCamera_setOrbitMode(_ID, orbitObject, orbitPoint.AsString(), minDistance, maxDistance, initDistance, ownClientObj, offset.AsString(), lockedx);
}
/// <summary>
/// Set the camera to orbit around a given object.
///                     @param orbitObject The object to orbit around.
///                     @param rotation The initial camera rotation about the object in radians in the form of \"x y z\".
///                     @param minDistance The minimum distance allowed to the orbit object or point.
///                     @param maxDistance The maximum distance allowed from the orbit object or point.
///                     @param initDistance The initial distance from the orbit object or point.
///                     @param ownClientObject [optional] Are we orbiting an object that is owned by us?  Default is false.
///                     @param offset [optional] An offset added to the camera's position.  Default is no offset.
///                     @param locked [optional] Indicates the camera does not receive input from the player.  Default is false.
///                     @returns false if the given object could not be found.
///                     @see Camera::setOrbitMode())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setOrbitObject(string orbitObject, Point3F rotation, float minDistance, float maxDistance, float initDistance, bool ownClientObject = false, Point3F offset = null , bool lockedx = false){
if (offset== null) {offset = new Point3F(0.0f, 0.0f, 0.0f);}

return pInvokes.m_ts.fnCamera_setOrbitObject(_ID, orbitObject, rotation.AsString(), minDistance, maxDistance, initDistance, ownClientObject, offset.AsString(), lockedx);
}
/// <summary>
/// Set the camera to orbit around a given point.
///                     @param orbitPoint The point to orbit around.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform().
///                     @param minDistance The minimum distance allowed to the orbit object or point.
///                     @param maxDistance The maximum distance allowed from the orbit object or point.
///                     @param initDistance The initial distance from the orbit object or point.
///                     @param offset [optional] An offset added to the camera's position.  Default is no offset.
///                     @param locked [optional] Indicates the camera does not receive input from the player.  Default is false.
///                     @see Camera::setOrbitMode())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setOrbitPoint(TransformF orbitPoint, float minDistance, float maxDistance, float initDistance, Point3F offset = null , bool lockedx = false){
if (offset== null) {offset = new Point3F(0.0f, 0.0f, 0.0f);}

pInvokes.m_ts.fnCamera_setOrbitPoint(_ID, orbitPoint.AsString(), minDistance, maxDistance, initDistance, offset.AsString(), lockedx);
}
/// <summary>
/// Set the camera's Euler rotation in radians.
///                    @param rot The rotation in radians in the form of \"x y z\".
///                    @note Rotation around the Y axis is ignored )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRotation(Point3F rot){

pInvokes.m_ts.fnCamera_setRotation(_ID, rot.AsString());
}
/// <summary>
/// Set the Newton mode camera speed multiplier when trigger[0] is active.
///                    @param multiplier The speed multiplier to apply.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSpeedMultiplier(float multiplier){

pInvokes.m_ts.fnCamera_setSpeedMultiplier(_ID, multiplier);
}
/// <summary>
/// Set the camera to track a given object.
///                     @param trackObject The object to track.
///                     @param offset [optional] An offset added to the camera's position.  Default is no offset.
///                     @returns false if the given object could not be found.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setTrackObject(string trackObject, Point3F offset = null ){
if (offset== null) {offset = new Point3F(0.0f, 0.0f, 0.0f);}

return pInvokes.m_ts.fnCamera_setTrackObject(_ID, trackObject, offset.AsString());
}
/// <summary>
/// Set if there is a valid editor camera orbit point.
///                    When validPoint is set to false the Camera operates as if it is 
///                    in Fly mode rather than an Orbit mode.
///                    @param validPoint Indicates the validity of the orbit point.
///                    @note Only used when Camera is in Edit Orbit Mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setValidEditOrbitPoint(bool validPoint){

pInvokes.m_ts.fnCamera_setValidEditOrbitPoint(_ID, validPoint);
}
/// <summary>
/// Set the velocity for the camera.
///                    @param velocity The camera's velocity in the form of \"x y z\".
///                    @note Only affects the Camera when in Newton mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void setVelocity(Point3F velocity){

pInvokes.m_ts.fnCamera_setVelocity(_ID, velocity.AsString());
}

#endregion
#region T3D Callbacks

#endregion
public Camera_Base (){}
}}
