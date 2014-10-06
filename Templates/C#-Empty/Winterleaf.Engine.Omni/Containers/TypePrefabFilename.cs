using System.ComponentModel;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGenericString<TypePrefabFilename>))]
    public class TypePrefabFilename : TypeStringBase<TypePrefabFilename>, iTypeStringBase
        {
        public TypePrefabFilename()
            {
            }

        public TypePrefabFilename(string value)
            {
            this.Value = value;
            }

        //Empty
        }
    public static partial class Extension
        {


        /// <summary>
        /// Converts a string to a PreFame Filename
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypePrefabFilename AsTypePrefabFilename(this string value)
            {
            return new TypePrefabFilename(value);
            }
        }
    }