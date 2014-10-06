using System;
using System.ComponentModel;

namespace WinterLeaf.Engine.Classes.Helpers
    {
    /// <summary>
    /// This class provides a generic template for setting up a type converter for casting.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TypeConverterGeneric<T> : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return ((typeof(string) == sourceType) || (typeof(uint) == sourceType) || (typeof(int) == sourceType));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            object value)
            {
            uint simobjectid = 0;
            if (value is string)
                simobjectid = ModelBase.resolveobject(value.ToString());
            else if (value is int)
                simobjectid = (uint)value;
            else if (value is uint)
                simobjectid = (uint)value;

            return Omni.self.getSimObject(simobjectid, typeof(T));
            }
        }
    }