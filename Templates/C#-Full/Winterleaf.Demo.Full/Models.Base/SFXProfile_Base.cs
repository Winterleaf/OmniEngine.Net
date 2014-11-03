


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXProfile_Base>))]
    public partial class SFXProfile_Base: SFXTrack
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXProfile_Base ts, string simobjectid)
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
        public static bool operator !=(SFXProfile_Base ts, string simobjectid)
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
        public static implicit operator string( SFXProfile_Base ts)
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
        public static implicit operator SFXProfile_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXProfile_Base) Omni.self.getSimObject(simobjectid,typeof(SFXProfile_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXProfile_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXProfile_Base(int simobjectid)
            {
            return  (SFXProfile) Omni.self.getSimObject((uint)simobjectid,typeof(SFXProfile_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXProfile_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXProfile_Base(uint simobjectid)
            {
            return  (SFXProfile_Base) Omni.self.getSimObject(simobjectid,typeof(SFXProfile_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// %Path to the sound file.\n     If the extension is left out, it will be inferred by the sound system. This allows to      easily switch the sound format without having to go through the profiles and change the      filenames there, too.\n 
/// </summary>
[MemberGroup("Sound")]
public String filename
       {
       get
          {
          return Omni.self.GetVar(_ID + ".filename").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".filename", value.AsString());
          }
       }
/// <summary>
/// Whether to preload sound data when the profile is added to system.\n     @note This flag is ignored by streamed sounds.\n\n     @ref SFXProfile_loading 
/// </summary>
[MemberGroup("Sound")]
public bool preload
       {
       get
          {
          return Omni.self.GetVar(_ID + ".preload").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".preload", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Return the length of the sound data in seconds.
///    @return The length of the sound data in seconds or 0 if the sound referenced by the profile could not be found. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getSoundDuration(){

return pInvokes.m_ts.fnSFXProfile_getSoundDuration(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public SFXProfile_Base (){}
}}
