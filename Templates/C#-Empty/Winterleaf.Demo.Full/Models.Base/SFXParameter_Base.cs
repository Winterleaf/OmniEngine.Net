


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXParameter_Base>))]
    public partial class SFXParameter_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXParameter_Base ts, string simobjectid)
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
        public static bool operator !=(SFXParameter_Base ts, string simobjectid)
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
        public static implicit operator string( SFXParameter_Base ts)
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
        public static implicit operator SFXParameter_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXParameter_Base) Omni.self.getSimObject(simobjectid,typeof(SFXParameter_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXParameter_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXParameter_Base(int simobjectid)
            {
            return  (SFXParameter) Omni.self.getSimObject((uint)simobjectid,typeof(SFXParameter_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXParameter_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXParameter_Base(uint simobjectid)
            {
            return  (SFXParameter_Base) Omni.self.getSimObject(simobjectid,typeof(SFXParameter_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Channel that the parameter controls.\n     This controls which property of the sources it is attached to the parameter controls. 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXChannel channel
       {
       get
          {          return (TypeSFXChannel) Omni.self.GetVar(_ID + ".channel");
          }
       set
          {
          Omni.self.SetVar(_ID + ".channel", value.ToString());
          }
       }
/// <summary>
/// Value to which the parameter is initially set.\n     When the parameter is first added to the system, #value will be set to #defaultValue. 
/// </summary>
[MemberGroup("Sound")]
public float defaultValue
       {
       get
          {
          return Omni.self.GetVar(_ID + ".defaultValue").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".defaultValue", value.AsString());
          }
       }
/// <summary>
/// Textual description of the parameter.\n     Primarily for use in the Audio Parameters dialog of the editor to allow for easier identification      of parameters. 
/// </summary>
[MemberGroup("Sound")]
public String description
       {
       get
          {
          return Omni.self.GetVar(_ID + ".description").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".description", value.AsString());
          }
       }
/// <summary>
/// Permitted range for #value.\n     Minimum and maximum allowed value for the parameter. Both inclusive.\n\n     For all but the User0-3 channels, this property is automatically set up by SFXParameter. 
/// </summary>
[MemberGroup("Sound")]
public Point2F range
       {
       get
          {
          return Omni.self.GetVar(_ID + ".range").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".range", value.AsString());
          }
       }
/// <summary>
/// Current value of the audio parameter.\n     All attached sources are notified when this value changes. 
/// </summary>
[MemberGroup("Sound")]
public float value
       {
       get
          {
          return Omni.self.GetVar(_ID + ".value").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".value", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Get the name of the parameter.
///    @return The paramete name. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getParameterName(){

return pInvokes.m_ts.fnSFXParameter_getParameterName(_ID);
}
/// <summary>
/// Reset the parameter's value to its default.
///    @see SFXParameter::defaultValue )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reset(){

pInvokes.m_ts.fnSFXParameter_reset(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the sound system triggers an update on the parameter.   This occurs periodically during system operation. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onUpdate(){}

#endregion
public SFXParameter_Base (){}
}}
