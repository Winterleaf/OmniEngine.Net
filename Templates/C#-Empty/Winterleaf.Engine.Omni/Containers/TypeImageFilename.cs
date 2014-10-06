using System;
using System.ComponentModel;

namespace WinterLeaf.Engine.Containers
    {
    public class TypeImageFilenameIConverter : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof (string) == sourceType);
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
            if (value is string)
                {
                return new TypeImageFilename(value as string);
                }

            return null;
            }
        }

    [TypeConverter(typeof (TypeImageFilenameIConverter))]
    public class TypeImageFilename : TypeStringBase<TypeImageFilename>, iTypeStringBase
        {
        public TypeImageFilename()
            {
            }

        public TypeImageFilename(string value)
            {
            this.Value = value;
            }

        //Empty
        }

    public static partial class Extension
        {
        /// <summary>
        /// Converts a string to a Image Filename
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeImageFilename AsTypeImageFilename(this string value)
            {
            return new TypeImageFilename(value);
            }
        }
    }