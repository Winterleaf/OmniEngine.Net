


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
    [TypeConverter(typeof(TypeConverterGeneric<ShapeBase_Base>))]
    public partial class ShapeBase_Base: GameBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ShapeBase_Base ts, string simobjectid)
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
        public static bool operator !=(ShapeBase_Base ts, string simobjectid)
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
        public static implicit operator string( ShapeBase_Base ts)
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
        public static implicit operator ShapeBase_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ShapeBase_Base) Omni.self.getSimObject(simobjectid,typeof(ShapeBase_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ShapeBase_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeBase_Base(int simobjectid)
            {
            return  (ShapeBase) Omni.self.getSimObject((uint)simobjectid,typeof(ShapeBase_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ShapeBase_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeBase_Base(uint simobjectid)
            {
            return  (ShapeBase_Base) Omni.self.getSimObject(simobjectid,typeof(ShapeBase_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Is this object AI controlled.\n\n   If True then this object is considered AI controlled and not player controlled.\n 
/// </summary>
[MemberGroup("")]
public bool isAiControlled
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isAiControlled").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isAiControlled", value.AsString());
          }
       }
/// <summary>
/// @brief The skin applied to the shape.\n\n   'Skinning' the shape effectively renames the material targets, allowing    different materials to be used on different instances of the same model.    Using getSkinName() and setSkinName() is equivalent to reading and    writing the skin field directly.\n\n   Any material targets that start with the old skin name have that part    of the name replaced with the new skin name. The initial old skin name is    \base\. For example, if a new skin of \blue\ was applied to a model    that had material targets ibase_body/i and iface/i, the new targets    would be iblue_body/i and iface/i. Note that iface/i was not    renamed since it did not start with the old skin name of \base\.\n\n   To support models that do not use the default \base\ naming convention,    you can also specify the part of the name to replace in the skin field    itself. For example, if a model had a material target called ishapemat/i,    we could apply a new skin \shape=blue\, and the material target would be    renamed to ibluemat/i (note \shape\ has been replaced with \blue\).\n\n   Multiple skin updates can also be applied at the same time by separating    them with a semicolon. For example: \base=blue;face=happy_face\.\n\n   Material targets are only renamed if an existing Material maps to that    name, or if there is a diffuse texture in the model folder with the same    name as the new target.\n\n 
/// </summary>
[MemberGroup("")]
public String skin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".skin").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".skin", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Increment the current damage level by the specified amount.
/// 
///    @param amount value to add to current damage level )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void applyDamage(float amount){

pInvokes.m_ts.fnShapeBase_applyDamage(_ID, amount);
}
/// <summary>
/// @brief Apply an impulse to the object.
/// 
///    @param pos world position of the impulse
///    @param vec impulse momentum (velocity * mass)
///    @return true )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  bool applyImpulse(Point3F pos, Point3F vec){

return pInvokes.m_ts.fnShapeBase_applyImpulse(_ID, pos.AsString(), vec.AsString());
}
/// <summary>
/// @brief Repair damage by the specified amount.
/// 
///    Note that the damage level is only reduced by repairRate per tick, so it may 
///    take several ticks for the total repair to complete.
/// 
///    @param amount total repair value (subtracted from damage level over time) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void applyRepair(float amount){

pInvokes.m_ts.fnShapeBase_applyRepair(_ID, amount);
}
/// <summary>
/// @brief Explodes an object into pieces.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void blowUp(){

pInvokes.m_ts.fnShapeBase_blowUp(_ID);
}
/// <summary>
/// @brief Check if this object can cloak.
///    @return true
///    
///    @note Not implemented as it always returns true.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool canCloak(){

return pInvokes.m_ts.fnShapeBase_canCloak(_ID);
}
/// <summary>
/// @brief Change one of the materials on the shape.
/// 
///    This method changes materials per mapTo with others. The material that 
///    is being replaced is mapped to unmapped_mat as a part of this transition.
/// 
///    @note Warning, right now this only sort of works. It doesn't do a live 
///    update like it should.
/// 
///    @param mapTo the name of the material target to remap (from getTargetName)
///    @param oldMat the old Material that was mapped 
///    @param newMat the new Material to map
/// 
///    @tsexample
///    // remap the first material in the shape
///    %mapTo = %obj.getTargetName( 0 );
///    %obj.changeMaterial( %mapTo, 0, MyMaterial );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void changeMaterial(string mapTo, string oldMat, string newMat){

pInvokes.m_ts.fnShapeBase_changeMaterial(_ID, mapTo, oldMat, newMat);
}
/// <summary>
/// @brief Destroy an animation thread, which prevents it from playing.
/// 
///    @param slot thread slot to destroy
///    @return true if successful, false if failed
///    
///    @see playThread )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool destroyThread(int slot){

return pInvokes.m_ts.fnShapeBase_destroyThread(_ID, slot);
}
/// <summary>
/// @brief Print a list of visible and hidden meshes in the shape to the console 
///    for debugging purposes.
///    @note Only in a SHIPPING build.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void dumpMeshVisibility(){

pInvokes.m_ts.fnShapeBase_dumpMeshVisibility(_ID);
}
/// <summary>
/// @brief Get the position at which the AI should stand to repair things.
/// 
///    If the shape defines a node called \"AIRepairNode\", this method will 
///    return the current world position of that node, otherwise \"0 0 0\".
///    @return the AI repair position )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getAIRepairPoint(){

return new Point3F ( pInvokes.m_ts.fnShapeBase_getAIRepairPoint(_ID));
}
/// <summary>
/// @brief Returns the vertical field of view in degrees for this object if used as a camera.
/// 
///    @return current FOV as defined in ShapeBaseData::cameraDefaultFov )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getCameraFov(){

return pInvokes.m_ts.fnShapeBase_getCameraFov(_ID);
}
/// <summary>
/// @brief Get the client (if any) that controls this object.
/// 
///    The controlling client is the one that will send moves to us to act on.
/// 
///    @return the ID of the controlling GameConnection, or 0 if this object is not 
///    controlled by any client.
///    
///    @see GameConnection)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getControllingClient(){

return pInvokes.m_ts.fnShapeBase_getControllingClient(_ID);
}
/// <summary>
/// @brief Get the object (if any) that controls this object.
/// 
///    @return the ID of the controlling ShapeBase object, or 0 if this object is 
///    not controlled by another object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getControllingObject(){

return pInvokes.m_ts.fnShapeBase_getControllingObject(_ID);
}
/// <summary>
/// @brief Get the damage flash level.
/// 
///    @return flash level
/// 
///    @see setDamageFlash )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getDamageFlash(){

return pInvokes.m_ts.fnShapeBase_getDamageFlash(_ID);
}
/// <summary>
/// @brief Get the object's current damage level.
/// 
///    @return damage level
///    
///    @see setDamageLevel())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getDamageLevel(){

return pInvokes.m_ts.fnShapeBase_getDamageLevel(_ID);
}
/// <summary>
/// @brief Get the object's current damage level as a percentage of maxDamage.
/// 
///    @return damageLevel / datablock.maxDamage
///    
///    @see setDamageLevel())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getDamagePercent(){

return pInvokes.m_ts.fnShapeBase_getDamagePercent(_ID);
}
/// <summary>
/// @brief Get the object's damage state.
/// 
///    @return the damage state; one of \"Enabled\", \"Disabled\", \"Destroyed\"
///    
///    @see setDamageState())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getDamageState(){

return pInvokes.m_ts.fnShapeBase_getDamageState(_ID);
}
/// <summary>
/// @brief Returns the default vertical field of view in degrees for this object if used as a camera.
/// 
///    @return Default FOV )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getDefaultCameraFov(){

return pInvokes.m_ts.fnShapeBase_getDefaultCameraFov(_ID);
}
/// <summary>
/// @brief Get the object's current energy level.
/// 
///    @return energy level
///    
///    @see setEnergyLevel())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getEnergyLevel(){

return pInvokes.m_ts.fnShapeBase_getEnergyLevel(_ID);
}
/// <summary>
/// @brief Get the object's current energy level as a percentage of maxEnergy.
///    @return energyLevel / datablock.maxEnergy
/// 
///    @see setEnergyLevel())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getEnergyPercent(){

return pInvokes.m_ts.fnShapeBase_getEnergyPercent(_ID);
}
/// <summary>
/// @brief Get the position of the 'eye' for this object.
/// 
///    If the object model has a node called 'eye', this method will return that 
///    node's current world position, otherwise it will return the object's current 
///    world position.
/// 
///    @return the eye position for this object
/// 
///    @see getEyeVector
///    @see getEyeTransform )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getEyePoint(){

return new Point3F ( pInvokes.m_ts.fnShapeBase_getEyePoint(_ID));
}
/// <summary>
/// @brief Get the 'eye' transform for this object.
/// 
///    If the object model has a node called 'eye', this method will return that 
///    node's current transform, otherwise it will return the object's current 
///    transform.
/// 
///    @return the eye transform for this object
/// 
///    @see getEyeVector
///    @see getEyePoint )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  TransformF getEyeTransform(){

return new TransformF ( pInvokes.m_ts.fnShapeBase_getEyeTransform(_ID));
}
/// <summary>
/// @brief Get the forward direction of the 'eye' for this object.
/// 
///    If the object model has a node called 'eye', this method will return that 
///    node's current forward direction vector, otherwise it will return the 
///    object's current forward direction vector.
/// 
///    @return the eye vector for this object
/// 
///    @see getEyePoint
///    @see getEyeTransform )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getEyeVector(){

return new Point3F ( pInvokes.m_ts.fnShapeBase_getEyeVector(_ID));
}
/// <summary>
/// @brief Get the alt trigger state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to query
///    @return the Image's current alt trigger state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getImageAltTrigger(int slot){

return pInvokes.m_ts.fnShapeBase_getImageAltTrigger(_ID, slot);
}
/// <summary>
/// @brief Get the ammo state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to query
///    @return the Image's current ammo state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getImageAmmo(int slot){

return pInvokes.m_ts.fnShapeBase_getImageAmmo(_ID, slot);
}
/// <summary>
/// @brief Get the generic trigger state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to query
///    @param trigger Generic trigger number
///    @return the Image's current generic trigger state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getImageGenericTrigger(int slot, int trigger){

return pInvokes.m_ts.fnShapeBase_getImageGenericTrigger(_ID, slot, trigger);
}
/// <summary>
/// @brief Get the loaded state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to query
///    @return the Image's current loaded state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getImageLoaded(int slot){

return pInvokes.m_ts.fnShapeBase_getImageLoaded(_ID, slot);
}
/// <summary>
/// @brief Get the script animation prefix of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to query
///    @return the Image's current script animation prefix )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getImageScriptAnimPrefix(int slot){

return pInvokes.m_ts.fnShapeBase_getImageScriptAnimPrefix(_ID, slot);
}
/// <summary>
/// @brief Get the skin tag ID for the Image mounted in the specified slot.
/// 
///    @param slot Image slot to query
///    @return the skinTag value passed to mountImage when the image was 
///    mounted )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getImageSkinTag(int slot){

return pInvokes.m_ts.fnShapeBase_getImageSkinTag(_ID, slot);
}
/// <summary>
/// @brief Get the name of the current state of the Image in the specified slot.
/// 
///    @param slot Image slot to query
///    @return name of the current Image state, or \"Error\" if slot is invalid )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getImageState(int slot){

return pInvokes.m_ts.fnShapeBase_getImageState(_ID, slot);
}
/// <summary>
/// @brief Get the target state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to query
///    @return the Image's current target state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getImageTarget(int slot){

return pInvokes.m_ts.fnShapeBase_getImageTarget(_ID, slot);
}
/// <summary>
/// @brief Get the trigger state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to query
///    @return the Image's current trigger state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getImageTrigger(int slot){

return pInvokes.m_ts.fnShapeBase_getImageTrigger(_ID, slot);
}
/// <summary>
/// @brief Get the world position this object is looking at.
/// 
///    Casts a ray from the eye and returns information about what the ray hits.
/// 
///    @param distance maximum distance of the raycast
///    @param typeMask typeMask of objects to include for raycast collision testing
///    @return look-at information as \"Object HitX HitY HitZ [Material]\" or empty string for no hit
/// 
///    @tsexample
///    %lookat = %obj.getLookAtPoint();
///    echo( \"Looking at: \" @ getWords( %lookat, 1, 3 ) );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getLookAtPoint(float distance = 2000, uint typeMask = 0xFFFFFFFF){

return pInvokes.m_ts.fnShapeBase_getLookAtPoint(_ID, distance, typeMask);
}
/// <summary>
/// Get the object's maxDamage level.  
///    @return datablock.maxDamage)    
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getMaxDamage(){

return pInvokes.m_ts.fnShapeBase_getMaxDamage(_ID);
}
/// <summary>
/// @brief Get the model filename used by this shape.
/// 
///    @return the shape filename )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getModelFile(){

return pInvokes.m_ts.fnShapeBase_getModelFile(_ID);
}
/// <summary>
/// @brief Get the Image mounted in the specified slot.
/// 
///    @param slot Image slot to query
///    @return ID of the ShapeBaseImageData datablock mounted in the slot, or 0 
///    if no Image is mounted there. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMountedImage(int slot){

return pInvokes.m_ts.fnShapeBase_getMountedImage(_ID, slot);
}
/// <summary>
/// @brief Get the first slot the given datablock is mounted to on this object.
/// 
///    @param image ShapeBaseImageData datablock to query
///    @return index of the first slot the Image is mounted in, or -1 if the Image 
///    is not mounted in any slot on this object. )
/// 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMountSlot(string image){

return pInvokes.m_ts.fnShapeBase_getMountSlot(_ID, image);
}
/// <summary>
/// @brief Get the muzzle position of the Image mounted in the specified slot.
/// 
///    If the Image shape contains a node called 'muzzlePoint', then the muzzle 
///    position is the position of that node in world space. If no such node 
///    is specified, the slot's mount node is used instead.
/// 
///    @param slot Image slot to query
///    @return the muzzle position, or \"0 0 0\" if the slot is invalid )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getMuzzlePoint(int slot){

return new Point3F ( pInvokes.m_ts.fnShapeBase_getMuzzlePoint(_ID, slot));
}
/// <summary>
/// @brief Get the muzzle vector of the Image mounted in the specified slot.
/// 
///    If the Image shape contains a node called 'muzzlePoint', then the muzzle 
///    vector is the forward direction vector of that node's transform in world 
///    space. If no such node is specified, the slot's mount node is used 
///    instead.
/// 
///    If the correctMuzzleVector flag (correctMuzzleVectorTP in 3rd person) 
///    is set in the Image, the muzzle vector is computed to point at whatever 
///    object is right in front of the object's 'eye' node.
/// 
///    @param slot Image slot to query
///    @return the muzzle vector, or \"0 1 0\" if the slot is invalid )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getMuzzleVector(int slot){

return new Point3F ( pInvokes.m_ts.fnShapeBase_getMuzzleVector(_ID, slot));
}
/// <summary>
/// @brief Get the Image that will be mounted next in the specified slot.
/// 
///    Calling mountImage when an Image is already mounted does one of two things: 
///    ol>li>Mount the new Image immediately, the old Image is discarded and 
///    whatever state it was in is ignored./li>
///    li>If the current Image state does not allow Image changes, the new 
///    Image is marked as pending, and will not be mounted until the current 
///    state completes. eg. if the user changes weapons, you may wish to ensure 
///    that the current weapon firing state plays to completion first./li>/ol>
///    This command retrieves the ID of the pending Image (2nd case above).
///    
///    @param slot Image slot to query
///    @return ID of the pending ShapeBaseImageData datablock, or 0 if none. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getPendingImage(int slot){

return pInvokes.m_ts.fnShapeBase_getPendingImage(_ID, slot);
}
/// <summary>
/// @brief Get the current recharge rate.
/// 
///    @return the recharge rate (per tick)
///    
///    @see setRechargeRate())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getRechargeRate(){

return pInvokes.m_ts.fnShapeBase_getRechargeRate(_ID);
}
/// <summary>
/// @brief Get the per-tick repair amount.
/// 
///    @return the current value to be subtracted from damage level each tick
/// 
///    @see setRepairRate )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getRepairRate(){

return pInvokes.m_ts.fnShapeBase_getRepairRate(_ID);
}
/// <summary>
/// @brief Get the name of the shape.
/// 
///    @note This is the name of the shape object that is sent to the client, 
///    not the DTS or DAE model filename.
/// 
///    @return the name of the shape 
///    
///    @see setShapeName())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getShapeName(){

return pInvokes.m_ts.fnShapeBase_getShapeName(_ID);
}
/// <summary>
/// @brief Get the name of the skin applied to this shape.
/// 
///    @return the name of the skin 
/// 
///    @see skin
///    @see setSkinName())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSkinName(){

return pInvokes.m_ts.fnShapeBase_getSkinName(_ID);
}
/// <summary>
/// @brief Get the world transform of the specified mount slot.
/// 
///    @param slot Image slot to query
///    @return the mount transform )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  TransformF getSlotTransform(int slot){

return new TransformF ( pInvokes.m_ts.fnShapeBase_getSlotTransform(_ID, slot));
}
/// <summary>
/// @brief Get the number of materials in the shape.
/// 
///    @return the number of materials in the shape. 
///    
///    @see getTargetName())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getTargetCount(){

return pInvokes.m_ts.fnShapeBase_getTargetCount(_ID);
}
/// <summary>
/// @brief Get the name of the indexed shape material.
/// 
///    @param index index of the material to get (valid range is 0 - getTargetCount()-1).
///    @return the name of the indexed material.
///    
///    @see getTargetCount())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTargetName(int index){

return pInvokes.m_ts.fnShapeBase_getTargetName(_ID, index);
}
/// <summary>
/// @brief Get the object's current velocity.
/// 
///    @return the current velocity )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getVelocity(){

return new Point3F ( pInvokes.m_ts.fnShapeBase_getVelocity(_ID));
}
/// <summary>
/// @brief Get the white-out level.
/// 
///    @return white-out level
/// 
///    @see setWhiteOut )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getWhiteOut(){

return pInvokes.m_ts.fnShapeBase_getWhiteOut(_ID);
}
/// <summary>
/// @brief Check if the given state exists on the mounted Image.
/// 
///    @param slot Image slot to query
///    @param state Image state to check for
///    @return true if the Image has the requested state defined. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool hasImageState(int slot, string state){

return pInvokes.m_ts.fnShapeBase_hasImageState(_ID, slot, state);
}
/// <summary>
/// @brief Check if this object is cloaked.
/// 
///    @return true if cloaked, false if not 
///    
///    @see setCloaked())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isCloaked(){

return pInvokes.m_ts.fnShapeBase_isCloaked(_ID);
}
/// <summary>
/// @brief Check if the object is in the Destroyed damage state.
/// 
///    @return true if damage state is \"Destroyed\", false if not 
///    
///    @see isDisabled()
///    @see isEnabled())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isDestroyed(){

return pInvokes.m_ts.fnShapeBase_isDestroyed(_ID);
}
/// <summary>
/// @brief Check if the object is in the Disabled or Destroyed damage state.
/// 
///    @return true if damage state is not \"Enabled\", false if it is
///    
///    @see isDestroyed()
///    @see isEnabled())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isDisabled(){

return pInvokes.m_ts.fnShapeBase_isDisabled(_ID);
}
/// <summary>
/// @brief Check if the object is in the Enabled damage state.
/// 
///    @return true if damage state is \"Enabled\", false if not
///    
///    @see isDestroyed()
///    @see isDisabled())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  bool isEnabled(){

return pInvokes.m_ts.fnShapeBase_isEnabled(_ID);
}
/// <summary>
/// Check if the object is hidden.
///    @return true if the object is hidden, false if visible. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isHidden(){

return pInvokes.m_ts.fnShapeBase_isHidden(_ID);
}
/// <summary>
/// @brief Check if the current Image state is firing.
/// 
///    @param slot Image slot to query
///    @return true if the current Image state in this slot has the 'stateFire' flag set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isImageFiring(int slot){

return pInvokes.m_ts.fnShapeBase_isImageFiring(_ID, slot);
}
/// <summary>
/// @brief Check if the given datablock is mounted to any slot on this object.
/// 
///    @param image ShapeBaseImageData datablock to query
///    @return true if the Image is mounted to any slot, false otherwise. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isImageMounted(string image){

return pInvokes.m_ts.fnShapeBase_isImageMounted(_ID, image);
}
/// <summary>
///  ),
///    @brief Mount a new Image.
/// 
///    @param image the Image to mount
///    @param slot Image slot to mount into (valid range is 0 - 3)
///    @param loaded initial loaded state for the Image
///    @param skinTag tagged string to reskin the mounted Image
///    @return true if successful, false if failed
/// 
///    @tsexample
///    %player.mountImage( PistolImage, 1 );
///    %player.mountImage( CrossbowImage, 0, false );
///    %player.mountImage( RocketLauncherImage, 0, true, 'blue' );
///    @endtsexample
///    
///    @see unmountImage()
///    @see getMountedImage()
///    @see getPendingImage()
///    @see isImageMounted())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool mountImage(string image, int slot, bool loaded = true, string skinTag = ""){

return pInvokes.m_ts.fnShapeBase_mountImage(_ID, image, slot, loaded, skinTag);
}
/// <summary>
/// @brief Pause an animation thread.
///    
///    If restarted using playThread, the animation 
///    will resume from the paused position.
///    @param slot thread slot to stop
///    @return true if successful, false if failed
///    
///    @see playThread )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool pauseThread(int slot){

return pInvokes.m_ts.fnShapeBase_pauseThread(_ID, slot);
}
/// <summary>
/// @brief Attach a sound to this shape and start playing it.
/// 
///    @param slot Audio slot index for the sound (valid range is 0 - 3)    @param track SFXTrack to play
///    @return true if the sound was attached successfully, false if failed
///    
///    @see stopAudio())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool playAudio(int slot, string track){

return pInvokes.m_ts.fnShapeBase_playAudio(_ID, slot, track);
}
/// <summary>
///  ),
///    @brief Start a new animation thread, or restart one that has been paused or 
///    stopped.
/// 
///    @param slot thread slot to play. Valid range is 0 - 3)     @param name name of the animation sequence to play in this slot. If not 
///    specified, the paused or stopped thread in this slot will be resumed.
///    @return true if successful, false if failed
/// 
///    @tsexample
///    %obj.playThread( 0, \"ambient\" );      // Play the ambient sequence in slot 0
///    %obj.setThreadTimeScale( 0, 0.5 );    // Play at half-speed
///    %obj.pauseThread( 0 );                // Pause the sequence
///    %obj.playThread( 0 );                 // Resume playback
///    %obj.playThread( 0, \"spin\" );         // Replace the sequence in slot 0
///    @endtsexample
///    
///    @see pauseThread()
///    @see stopThread()
///    @see setThreadDir()
///    @see setThreadTimeScale()
///    @see destroyThread())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool playThread(int slot, string name = ""){

return pInvokes.m_ts.fnShapeBase_playThread(_ID, slot, name);
}
/// <summary>
/// @brief Set the hidden state on all the shape meshes.
/// 
///    This allows you to hide all meshes in the shape, for example, and then only 
///    enable a few.
/// 
///    @param hide new hidden state for all meshes )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAllMeshesHidden(bool hide){

pInvokes.m_ts.fnShapeBase_setAllMeshesHidden(_ID, hide);
}
/// <summary>
/// @brief Set the vertical field of view in degrees for this object if used as a camera.
/// 
///    @param fov new FOV value )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCameraFov(float fov){

pInvokes.m_ts.fnShapeBase_setCameraFov(_ID, fov);
}
/// <summary>
/// @brief Set the cloaked state of this object.
/// 
///    When an object is cloaked it is not rendered.
/// 
///    @param cloak true to cloak the object, false to uncloak
///    
///    @see isCloaked())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCloaked(bool cloak){

pInvokes.m_ts.fnShapeBase_setCloaked(_ID, cloak);
}
/// <summary>
/// @brief Set the damage flash level.
/// 
///    Damage flash may be used as a postfx effect to flash the screen when the 
///    client is damaged.
/// 
///    @note Relies on the flash postFx.
/// 
///    @param level flash level (0-1)
///    
///    @see getDamageFlash())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDamageFlash(float level){

pInvokes.m_ts.fnShapeBase_setDamageFlash(_ID, level);
}
/// <summary>
/// @brief Set the object's current damage level.
/// 
///    @param level new damage level
///    
///    @see getDamageLevel()
///    @see getDamagePercent())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDamageLevel(float level){

pInvokes.m_ts.fnShapeBase_setDamageLevel(_ID, level);
}
/// <summary>
/// @brief Set the object's damage state.
/// 
///    @param state should be one of \"Enabled\", \"Disabled\", \"Destroyed\"
///    @return true if successful, false if failed
///    
///    @see getDamageState())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setDamageState(string state){

return pInvokes.m_ts.fnShapeBase_setDamageState(_ID, state);
}
/// <summary>
/// @brief Set the damage direction vector.
/// 
///    Currently this is only used to initialise the explosion if this object 
///    is blown up.
/// 
///    @param vec damage direction vector
/// 
///    @tsexample
///    %obj.setDamageVector( \"0 0 1\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDamageVector(Point3F vec){

pInvokes.m_ts.fnShapeBase_setDamageVector(_ID, vec.AsString());
}
/// <summary>
/// @brief Set this object's current energy level.
/// 
///    @param level new energy level
///    
///    @see getEnergyLevel()
///    @see getEnergyPercent())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setEnergyLevel(float level){

pInvokes.m_ts.fnShapeBase_setEnergyLevel(_ID, level);
}
/// <summary>
/// @brief Add or remove this object from the scene.
///    When removed from the scene, the object will not be processed or rendered.
///    @param show False to hide the object, true to re-show it )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void setHidden(bool show){

pInvokes.m_ts.fnShapeBase_setHidden(_ID, show);
}
/// <summary>
/// @brief Set the alt trigger state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to modify
///    @param state new alt trigger state for the Image
///    @return the Image's new alt trigger state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setImageAltTrigger(int slot, bool state){

return pInvokes.m_ts.fnShapeBase_setImageAltTrigger(_ID, slot, state);
}
/// <summary>
/// @brief Set the ammo state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to modify
///    @param state new ammo state for the Image
///    @return the Image's new ammo state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setImageAmmo(int slot, bool state){

return pInvokes.m_ts.fnShapeBase_setImageAmmo(_ID, slot, state);
}
/// <summary>
/// @brief Set the generic trigger state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to modify
///    @param trigger Generic trigger number
///    @param state new generic trigger state for the Image
///    @return the Image's new generic trigger state or -1 if there was a problem. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int setImageGenericTrigger(int slot, int trigger, bool state){

return pInvokes.m_ts.fnShapeBase_setImageGenericTrigger(_ID, slot, trigger, state);
}
/// <summary>
/// @brief Set the loaded state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to modify
///    @param state new loaded state for the Image
///    @return the Image's new loaded state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setImageLoaded(int slot, bool state){

return pInvokes.m_ts.fnShapeBase_setImageLoaded(_ID, slot, state);
}
/// <summary>
/// @brief Set the script animation prefix for the Image mounted in the specified slot.
///    This is used to further modify the prefix used when deciding which animation sequence to 
///    play while this image is mounted.
/// 
///    @param slot Image slot to modify
///    @param prefix The prefix applied to the image )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setImageScriptAnimPrefix(int slot, string prefix){

pInvokes.m_ts.fnShapeBase_setImageScriptAnimPrefix(_ID, slot, prefix);
}
/// <summary>
/// @brief Set the target state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to modify
///    @param state new target state for the Image
///    @return the Image's new target state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setImageTarget(int slot, bool state){

return pInvokes.m_ts.fnShapeBase_setImageTarget(_ID, slot, state);
}
/// <summary>
/// @brief Set the trigger state of the Image mounted in the specified slot.
/// 
///    @param slot Image slot to modify
///    @param state new trigger state for the Image
///    @return the Image's new trigger state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setImageTrigger(int slot, bool state){

return pInvokes.m_ts.fnShapeBase_setImageTrigger(_ID, slot, state);
}
/// <summary>
/// @brief Set the hidden state on the named shape mesh.
/// 
///    @param name name of the mesh to hide/show
///    @param hide new hidden state for the mesh )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMeshHidden(string name, bool hide){

pInvokes.m_ts.fnShapeBase_setMeshHidden(_ID, name, hide);
}
/// <summary>
/// @brief Set the recharge rate.
/// 
///    The recharge rate is added to the object's current energy level each tick, 
///    up to the maxEnergy level set in the ShapeBaseData datablock.
///    
///    @param rate the recharge rate (per tick)
///    
///    @see getRechargeRate())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRechargeRate(float rate){

pInvokes.m_ts.fnShapeBase_setRechargeRate(_ID, rate);
}
/// <summary>
/// @brief Set amount to repair damage by each tick.
/// 
///    Note that this value is separate to the repairRate field in ShapeBaseData. 
///    This value will be subtracted from the damage level each tick, whereas the 
///    ShapeBaseData field limits how much of the applyRepair value is subtracted 
///    each tick. Both repair types can be active at the same time.
///    
///    @param rate value to subtract from damage level each tick (must be > 0)
///    
///    @see getRepairRate())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRepairRate(float rate){

pInvokes.m_ts.fnShapeBase_setRepairRate(_ID, rate);
}
/// <summary>
/// @brief Set the name of this shape.
/// 
///    @note This is the name of the shape object that is sent to the client, 
///    not the DTS or DAE model filename.
/// 
///    @param name new name for the shape
///    
///    @see getShapeName())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setShapeName(string name){

pInvokes.m_ts.fnShapeBase_setShapeName(_ID, name);
}
/// <summary>
/// @brief Apply a new skin to this shape.
/// 
///    'Skinning' the shape effectively renames the material targets, allowing 
///    different materials to be used on different instances of the same model.
/// 
///    @param name name of the skin to apply
/// 
///    @see skin
///    @see getSkinName())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSkinName(string name){

pInvokes.m_ts.fnShapeBase_setSkinName(_ID, name);
}
/// <summary>
/// @brief Set the playback direction of an animation thread.
/// 
///    @param slot thread slot to modify
///    @param fwd true to play the animation forwards, false to play backwards
///    @return true if successful, false if failed
///    
///    @see playThread() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setThreadDir(int slot, bool fwd){

return pInvokes.m_ts.fnShapeBase_setThreadDir(_ID, slot, fwd);
}
/// <summary>
/// @brief Set the position within an animation thread.
/// 
///    @param slot thread slot to modify
///    @param pos position within thread
///    @return true if successful, false if failed
///    
///    @see playThread )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setThreadPosition(int slot, float pos){

return pInvokes.m_ts.fnShapeBase_setThreadPosition(_ID, slot, pos);
}
/// <summary>
/// @brief Set the playback time scale of an animation thread.
/// 
///    @param slot thread slot to modify
///    @param scale new thread time scale (1=normal speed, 0.5=half speed etc)
///    @return true if successful, false if failed
///    
///    @see playThread )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setThreadTimeScale(int slot, float scale){

return pInvokes.m_ts.fnShapeBase_setThreadTimeScale(_ID, slot, scale);
}
/// <summary>
/// @brief Set the object's velocity.
/// 
///    @param vel new velocity for the object
///    @return true )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setVelocity(Point3F vel){

return pInvokes.m_ts.fnShapeBase_setVelocity(_ID, vel.AsString());
}
/// <summary>
/// @brief Set the white-out level.
/// 
///    White-out may be used as a postfx effect to brighten the screen in response 
///    to a game event.
/// 
///    @note Relies on the flash postFx.
/// 
///    @param level flash level (0-1)
///    
///    @see getWhiteOut())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setWhiteOut(float level){

pInvokes.m_ts.fnShapeBase_setWhiteOut(_ID, level);
}
/// <summary>
/// @brief Fade the object in or out without removing it from the scene.
/// 
///    A faded out object is still in the scene and can still be collided with, 
///    so if you want to disable collisions for this shape after it fades out 
///    use setHidden to temporarily remove this shape from the scene.
///   
///    @note Items have the ability to light their surroundings. When an Item with 
///    an active light is fading out, the light it emits is correspondingly 
///    reduced until it goes out. Likewise, when the item fades in, the light is 
///    turned-up till it reaches it's normal brightntess.
/// 
///    @param time duration of the fade effect in ms
///    @param delay delay in ms before the fade effect begins
///    @param fadeOut true to fade-out to invisible, false to fade-in to full visibility )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void startFade(int time, int delay, bool fadeOut){

pInvokes.m_ts.fnShapeBase_startFade(_ID, time, delay, fadeOut);
}
/// <summary>
/// @brief Stop a sound started with playAudio.
/// 
///    @param slot audio slot index (started with playAudio)
///    @return true if the sound was stopped successfully, false if failed
///    
///    @see playAudio())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool stopAudio(int slot){

return pInvokes.m_ts.fnShapeBase_stopAudio(_ID, slot);
}
/// <summary>
/// @brief Stop an animation thread.
/// 
///    If restarted using playThread, the animation 
///    will start from the beginning again.
///    @param slot thread slot to stop
///    @return true if successful, false if failed
///    
///    @see playThread )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool stopThread(int slot){

return pInvokes.m_ts.fnShapeBase_stopThread(_ID, slot);
}
/// <summary>
/// @brief Unmount the mounted Image in the specified slot.
/// 
///    @param slot Image slot to unmount
///    @return true if successful, false if failed
///    
///    @see mountImage())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool unmountImage(int slot){

return pInvokes.m_ts.fnShapeBase_unmountImage(_ID, slot);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called on the server when the client has requested a FOV change.   When the client requests that its field of view should be changed (because    they want to use a sniper scope, for example) this new FOV needs to be validated    by the server.  This method is called if it exists (it is optional) to validate    the requested FOV, and modify it if necessary.  This could be as simple as checking    that the FOV falls within a correct range, to making sure that the FOV matches the    capabilities of the current weapon.   Following this method, ShapeBase ensures that the given FOV still falls within    the datablock's cameraMinFov and cameraMaxFov.  If that is good enough for your    purposes, then you do not need to define the validateCameraFov() callback for    your ShapeBase.   @param fov The FOV that has been requested by the client.   @return The FOV as validated by the server.   @see ShapeBaseData)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  float validateCameraFov(float fov){return "0".AsFloat();}

#endregion
public ShapeBase_Base (){}
}}
