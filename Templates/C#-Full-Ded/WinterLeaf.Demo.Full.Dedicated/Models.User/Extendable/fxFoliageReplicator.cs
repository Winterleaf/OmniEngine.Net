

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
using Winterleaf.Demo.Full.Dedicated.Models.Base;
#endregion

namespace Winterleaf.Demo.Full.Dedicated.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<fxFoliageReplicator>))]
     public  partial class fxFoliageReplicator: fxFoliageReplicator_Base
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(fxFoliageReplicator ts, string simobjectid)
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
        public static bool operator !=(fxFoliageReplicator ts, string simobjectid)
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
        public static implicit operator string( fxFoliageReplicator ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator fxFoliageReplicator(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (fxFoliageReplicator) Omni.self.getSimObject(simobjectid,typeof(fxFoliageReplicator));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( fxFoliageReplicator ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator fxFoliageReplicator(int simobjectid)
            {
            return  (fxFoliageReplicator) Omni.self.getSimObject((uint)simobjectid,typeof(fxFoliageReplicator));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( fxFoliageReplicator ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator fxFoliageReplicator(uint simobjectid)
            {
            return  (fxFoliageReplicator) Omni.self.getSimObject(simobjectid,typeof(fxFoliageReplicator));
            }
#endregion

}}
