


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
    [TypeConverter(typeof(TypeConverterGeneric<WalkableShape_Base>))]
    public partial class WalkableShape_Base: TSDynamic
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WalkableShape_Base ts, string simobjectid)
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
        public static bool operator !=(WalkableShape_Base ts, string simobjectid)
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
        public static implicit operator string( WalkableShape_Base ts)
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
        public static implicit operator WalkableShape_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (WalkableShape_Base) Omni.self.getSimObject(simobjectid,typeof(WalkableShape_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( WalkableShape_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WalkableShape_Base(int simobjectid)
            {
            return  (WalkableShape) Omni.self.getSimObject((uint)simobjectid,typeof(WalkableShape_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( WalkableShape_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WalkableShape_Base(uint simobjectid)
            {
            return  (WalkableShape_Base) Omni.self.getSimObject(simobjectid,typeof(WalkableShape_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Length of ray to use when checking if objects can attach or should be detached from this shape.      The ray is cast this distance directly below each object scanned. 
/// </summary>
[MemberGroup("Attachments")]
public float RayLength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".RayLength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".RayLength", value.AsString());
          }
       }
/// <summary>
/// Scan for objects and automatically attach any that are within RayLength and directly above. 
/// </summary>
[MemberGroup("Attachments")]
public bool UseAutoAttach
       {
       get
          {
          return Omni.self.GetVar(_ID + ".UseAutoAttach").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".UseAutoAttach", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Attaches an object to this one.
///       @param obj The scene object to attach to us
///       @return true if successful, false if failed. This function will fail if the object passed 
///       is invalid or is not located directly above and within RayLength of this shape.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool attachObject(string obj){

return pInvokes.m_ts.fnWalkableShape_attachObject(_ID, obj);
}
/// <summary>
/// Detaches all attached objects. Note: if UseAutoAttach is true when this is called, all of
///        the objects may be re-attached on the next tick.
///       @tsexample
///          // Dump all riders
///          %attachableObj.UseAutoAttach = false
///          %attachableObj.detachAll(); = false
///       @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void detachAll(){

pInvokes.m_ts.fnWalkableShape_detachAll(_ID);
}
/// <summary>
/// Detaches an object from this one.
///       @param obj The scene object to be detached
///       @return true if successful, false if failed. This function will fail if the object passed 
///       is invalid or is not currently attached to this shape.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool detachObject(string obj){

return pInvokes.m_ts.fnWalkableShape_detachObject(_ID, obj);
}
/// <summary>
/// Returns the attachment at the passed index value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getAttachment(int index = 0){

return pInvokes.m_ts.fnWalkableShape_getAttachment(_ID, index);
}
/// <summary>
/// Returns the number of objects that are currently attached.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNumAttachments(){

return pInvokes.m_ts.fnWalkableShape_getNumAttachments(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when an object is attached to this one via script call or automatic attachment.   @param obj the SceneObject object being attached)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onObjectAttached(SceneObject obj){}

        /// <summary>
        /// @brief Called when an object is detached and will no longer move with the attachable shape.   @param obj the SceneObject object that has been detached.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onObjectDetached(SceneObject obj){}

#endregion
public WalkableShape_Base (){}
}}
