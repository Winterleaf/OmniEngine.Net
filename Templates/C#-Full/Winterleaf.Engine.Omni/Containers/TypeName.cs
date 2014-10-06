using System.ComponentModel;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGenericString<TypeName>))]
    public class TypeName : TypeStringBase<TypeName>, iTypeStringBase
        {
        public TypeName()
            {
            }

        public TypeName(string value)
            {
            this.Value = value;
            }
        }

    public static partial class Extension
        {

        /// <summary>
        /// Converts a string to a Type Name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeName AsTypeName(this string value)
            {
            return new TypeName(value);
            }
        }
    }