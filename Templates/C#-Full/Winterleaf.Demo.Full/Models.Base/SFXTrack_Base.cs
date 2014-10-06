


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXTrack_Base>))]
    public partial class SFXTrack_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXTrack_Base ts, string simobjectid)
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
        public static bool operator !=(SFXTrack_Base ts, string simobjectid)
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
        public static implicit operator string( SFXTrack_Base ts)
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
        public static implicit operator SFXTrack_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXTrack_Base) Omni.self.getSimObject(simobjectid,typeof(SFXTrack_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXTrack_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXTrack_Base(int simobjectid)
            {
            return  (SFXTrack) Omni.self.getSimObject((uint)simobjectid,typeof(SFXTrack_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXTrack_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXTrack_Base(uint simobjectid)
            {
            return  (SFXTrack_Base) Omni.self.getSimObject(simobjectid,typeof(SFXTrack_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Playback setup description for this track.\n\n     If unassigned, the description named \AudioEffects\ will automatically be assigned to the track. If this description      is not defined, track creation will fail. 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXDescriptionName description
       {
       get
          {
          return Omni.self.GetVar(_ID + ".description").AsTypeSFXDescriptionName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".description", value.AsString());
          }
       }
[MemberGroup("Sound")]
public arrayObject<TypeSFXParameterName> parameters;

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public SFXTrack_Base (){parameters = new arrayObject<TypeSFXParameterName>(8,"parameters","TypeVariable",false,this);    
}
}}
