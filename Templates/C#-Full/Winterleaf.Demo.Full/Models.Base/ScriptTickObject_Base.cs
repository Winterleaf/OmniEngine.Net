


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
    [TypeConverter(typeof(TypeConverterGeneric<ScriptTickObject_Base>))]
    public partial class ScriptTickObject_Base: ScriptObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ScriptTickObject_Base ts, string simobjectid)
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
        public static bool operator !=(ScriptTickObject_Base ts, string simobjectid)
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
        public static implicit operator string( ScriptTickObject_Base ts)
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
        public static implicit operator ScriptTickObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ScriptTickObject_Base) Omni.self.getSimObject(simobjectid,typeof(ScriptTickObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ScriptTickObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ScriptTickObject_Base(int simobjectid)
            {
            return  (ScriptTickObject) Omni.self.getSimObject((uint)simobjectid,typeof(ScriptTickObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ScriptTickObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ScriptTickObject_Base(uint simobjectid)
            {
            return  (ScriptTickObject_Base) Omni.self.getSimObject(simobjectid,typeof(ScriptTickObject_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Call the onAdvaceTime() callback.
/// </summary>
[MemberGroup("")]
public bool callOnAdvanceTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".callOnAdvanceTime").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".callOnAdvanceTime", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Is this object wanting to receive tick notifications.
/// 
///    If this object is set to receive tick notifications then its onInterpolateTick() and 
///    onProcessTick() callbacks are called.
///    @return True if object wants tick notifications )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isProcessingTicks(){

return pInvokes.m_ts.fnScriptTickObject_isProcessingTicks(_ID);
}
/// <summary>
/// @brief Sets this object as either tick processing or not.
/// 
///    @param tick This object's onInterpolateTick() and onProcessTick() callbacks are called if set to true.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setProcessTicks(bool tick){

pInvokes.m_ts.fnScriptTickObject_setProcessTicks(_ID, tick);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// This is called every frame, but only if the object is set to process ticks.	@param delta The time delta for this frame.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onInterpolateTick(float delta){}

        /// <summary>
        /// Called once every 32ms if this object is set to process ticks.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onProcessTick(){}

        /// <summary>
        /// This is called every frame regardless if the object is set to process ticks, but only    if the callOnAdvanceTime property is set to true.	@param timeDelta The time delta for this frame.   @see callOnAdvanceTime)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdvanceTime(float timeDelta){}

#endregion
public ScriptTickObject_Base (){}
}}
