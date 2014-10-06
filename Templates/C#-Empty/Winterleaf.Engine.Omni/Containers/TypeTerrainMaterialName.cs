using System.ComponentModel;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGenericString<TypeTerrainMaterialName>))]
    public class TypeTerrainMaterialName : TypeStringBase<TypeTerrainMaterialName>, iTypeStringBase
        {
        public TypeTerrainMaterialName()
            {
            }

        public TypeTerrainMaterialName(string value)
            {
            this.Value = value;
            }
        }
    public static partial class Extension
        {


        /// <summary>
        /// Converts a string to a Terrain Material Name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeTerrainMaterialName asTypeTerrainMaterialName(this string value)
            {
            return new TypeTerrainMaterialName(value);
            }
        }
    }