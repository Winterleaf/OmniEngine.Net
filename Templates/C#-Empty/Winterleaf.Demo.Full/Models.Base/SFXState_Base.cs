


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXState_Base>))]
    public partial class SFXState_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXState_Base ts, string simobjectid)
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
        public static bool operator !=(SFXState_Base ts, string simobjectid)
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
        public static implicit operator string( SFXState_Base ts)
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
        public static implicit operator SFXState_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXState_Base) Omni.self.getSimObject(simobjectid,typeof(SFXState_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXState_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXState_Base(int simobjectid)
            {
            return  (SFXState) Omni.self.getSimObject((uint)simobjectid,typeof(SFXState_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXState_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXState_Base(uint simobjectid)
            {
            return  (SFXState_Base) Omni.self.getSimObject(simobjectid,typeof(SFXState_Base));
            }
#endregion
#region Init Persists
[MemberGroup("State")]
public arrayObject<TypeSFXStateName> excludedStates;
[MemberGroup("State")]
public arrayObject<TypeSFXStateName> includedStates;

#endregion
#region Member Functions
/// <summary>
/// Increase the activation count on the state.
///    If the state isn't already active and it is not disabled, the state will be activated.
///    @see isActive
///    @see deactivate )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void activate(){

pInvokes.m_ts.fnSFXState_activate(_ID);
}
/// <summary>
/// Decrease the activation count on the state.
///    If the count reaches zero and the state was not disabled, the state will be deactivated.
///    @see isActive
///    @see activate )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deactivate(){

pInvokes.m_ts.fnSFXState_deactivate(_ID);
}
/// <summary>
/// Increase the disabling count of the state.
///    If the state is currently active, it will be deactivated.
///    @see isDisabled )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void disable(){

pInvokes.m_ts.fnSFXState_disable(_ID);
}
/// <summary>
/// Decrease the disabling count of the state.
///    If the disabling count reaches zero while the activation count is still non-zero, 
///       the state will be reactivated again.
///    @see isDisabled )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void enable(){

pInvokes.m_ts.fnSFXState_enable(_ID);
}
/// <summary>
/// Test whether the state is currently active.
///    This is true when the activation count is >0 and the disabling count is =0.
///    @return True if the state is currently active.
///    @see activate )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isActive(){

return pInvokes.m_ts.fnSFXState_isActive(_ID);
}
/// <summary>
/// Test whether the state is currently disabled.
///    This is true when the disabling count of the state is non-zero.
///    @return True if the state is disabled.
///    @see disable )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isDisabled(){

return pInvokes.m_ts.fnSFXState_isDisabled(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the state goes from inactive to active. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onActivate(){}

        /// <summary>
        /// called when the state goes from active to deactive. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDeactivate(){}

#endregion
public SFXState_Base (){excludedStates = new arrayObject<TypeSFXStateName>(4,"excludedStates","TypeVariable",false,this);    
includedStates = new arrayObject<TypeSFXStateName>(4,"includedStates","TypeVariable",false,this);    
}
}}
