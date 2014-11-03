


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXController_Base>))]
    public partial class SFXController_Base: SFXSource
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXController_Base ts, string simobjectid)
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
        public static bool operator !=(SFXController_Base ts, string simobjectid)
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
        public static implicit operator string( SFXController_Base ts)
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
        public static implicit operator SFXController_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXController_Base) Omni.self.getSimObject(simobjectid,typeof(SFXController_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXController_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXController_Base(int simobjectid)
            {
            return  (SFXController) Omni.self.getSimObject((uint)simobjectid,typeof(SFXController_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXController_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXController_Base(uint simobjectid)
            {
            return  (SFXController_Base) Omni.self.getSimObject(simobjectid,typeof(SFXController_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true, the controller logs its operation to the console.\n     This is a non-networked field that will work locally only. 
/// </summary>
[MemberGroup("Debug")]
public bool trace
       {
       get
          {
          return Omni.self.GetVar(_ID + ".trace").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".trace", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Get the index of the playlist slot currently processed by the controller.
///    @return The slot index currently being played.
///    @see SFXPlayList )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getCurrentSlot(){

return pInvokes.m_ts.fnSFXController_getCurrentSlot(_ID);
}
/// <summary>
/// Set the index of the playlist slot to play by the controller.  This can be used to seek in the playlist.
///    @param index Index of the playlist slot. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCurrentSlot(int index){

pInvokes.m_ts.fnSFXController_setCurrentSlot(_ID, index);
}

#endregion
#region T3D Callbacks

#endregion
public SFXController_Base (){}
}}
