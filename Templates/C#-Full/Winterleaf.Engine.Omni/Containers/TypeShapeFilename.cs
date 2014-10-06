using System.ComponentModel;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGenericString<TypeShapeFilename>))]
    public class TypeShapeFilename : TypeStringBase<TypeShapeFilename>, iTypeStringBase
        {
        public TypeShapeFilename()
            {
            }

        public TypeShapeFilename(string value)
            {
            this.Value = value;
            }

        //Empty
        }
    public static partial class Extension
        {
        /// <summary>
        /// Converts a string to a ShapeFilename
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeShapeFilename AsTypeShapeFilename(this string value)
            {
            return new TypeShapeFilename(value);
            }
        }
    }