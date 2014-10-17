

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
    [TypeConverter(typeof(TypeConverterGeneric<SimResponseCurve>))]
     public  partial class SimResponseCurve: SimResponseCurve_Base
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SimResponseCurve ts, string simobjectid)
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
        public static bool operator !=(SimResponseCurve ts, string simobjectid)
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
        public static implicit operator string( SimResponseCurve ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator SimResponseCurve(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SimResponseCurve) Omni.self.getSimObject(simobjectid,typeof(SimResponseCurve));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SimResponseCurve ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SimResponseCurve(int simobjectid)
            {
            return  (SimResponseCurve) Omni.self.getSimObject((uint)simobjectid,typeof(SimResponseCurve));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SimResponseCurve ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SimResponseCurve(uint simobjectid)
            {
            return  (SimResponseCurve) Omni.self.getSimObject(simobjectid,typeof(SimResponseCurve));
            }
#endregion

}}
