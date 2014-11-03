


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
    [TypeConverter(typeof(TypeConverterGeneric<TheoraTextureObject_Base>))]
    public partial class TheoraTextureObject_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TheoraTextureObject_Base ts, string simobjectid)
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
        public static bool operator !=(TheoraTextureObject_Base ts, string simobjectid)
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
        public static implicit operator string( TheoraTextureObject_Base ts)
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
        public static implicit operator TheoraTextureObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TheoraTextureObject_Base) Omni.self.getSimObject(simobjectid,typeof(TheoraTextureObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TheoraTextureObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TheoraTextureObject_Base(int simobjectid)
            {
            return  (TheoraTextureObject) Omni.self.getSimObject((uint)simobjectid,typeof(TheoraTextureObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TheoraTextureObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TheoraTextureObject_Base(uint simobjectid)
            {
            return  (TheoraTextureObject_Base) Omni.self.getSimObject(simobjectid,typeof(TheoraTextureObject_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Should the video loop. 
/// </summary>
[MemberGroup("Theora")]
public bool loop
       {
       get
          {
          return Omni.self.GetVar(_ID + ".loop").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".loop", value.AsString());
          }
       }
/// <summary>
/// Sound description to use for the video's audio channel.\n\n     If not set, will use a default one. 
/// </summary>
[MemberGroup("Theora")]
public TypeSFXDescriptionName sfxDescription
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sfxDescription").AsTypeSFXDescriptionName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sfxDescription", value.AsString());
          }
       }
/// <summary>
/// Name of the texture target by which the texture can be referenced in materials. 
/// </summary>
[MemberGroup("Theora")]
public String texTargetName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".texTargetName").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".texTargetName", value.AsString());
          }
       }
/// <summary>
/// Theora video file to play. 
/// </summary>
[MemberGroup("Theora")]
public String theoraFile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".theoraFile").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".theoraFile", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Pause playback of the video. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pause(){

pInvokes.m_ts.fn_TheoraTextureObject_pause(_ID);
}
/// <summary>
/// Start playback of the video. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void play(){

pInvokes.m_ts.fn_TheoraTextureObject_play(_ID);
}
/// <summary>
/// Stop playback of the video. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void stop(){

pInvokes.m_ts.fn_TheoraTextureObject_stop(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public TheoraTextureObject_Base (){}
}}
