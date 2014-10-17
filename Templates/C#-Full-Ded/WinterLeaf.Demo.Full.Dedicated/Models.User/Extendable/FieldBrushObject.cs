

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
    [TypeConverter(typeof(TypeConverterGeneric<FieldBrushObject>))]
     public  partial class FieldBrushObject: FieldBrushObject_Base
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(FieldBrushObject ts, string simobjectid)
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
        public static bool operator !=(FieldBrushObject ts, string simobjectid)
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
        public static implicit operator string( FieldBrushObject ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator FieldBrushObject(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (FieldBrushObject) Omni.self.getSimObject(simobjectid,typeof(FieldBrushObject));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( FieldBrushObject ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FieldBrushObject(int simobjectid)
            {
            return  (FieldBrushObject) Omni.self.getSimObject((uint)simobjectid,typeof(FieldBrushObject));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( FieldBrushObject ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FieldBrushObject(uint simobjectid)
            {
            return  (FieldBrushObject) Omni.self.getSimObject(simobjectid,typeof(FieldBrushObject));
            }
#endregion

}}
