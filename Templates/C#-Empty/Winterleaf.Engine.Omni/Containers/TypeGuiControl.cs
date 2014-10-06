using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Containers
    {
    /// <summary>
    /// Required for converting this object type to a string and back.
    /// </summary>
    public class TypeGuiControlIConverter : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof(string) == sourceType);
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

    /// <summary>
    /// The actual class that hold data.
    /// </summary>
    [TypeConverter(typeof(TypeGuiControlIConverter))]
    public class TypeGuiControl : TypeStringBase<TypeGuiControl>, iTypeStringBase
        {
        public TypeGuiControl()
            {
            }

        public TypeGuiControl(string value)
            {
            this.Value = value;
            }

        }
    //This is required for translating a string to this type.
    public  static partial class Extension
        {
        public static TypeGuiControl AsTypeGuiControl(this string value)
            {
            return new TypeGuiControl(value);
            }
        }
    }
