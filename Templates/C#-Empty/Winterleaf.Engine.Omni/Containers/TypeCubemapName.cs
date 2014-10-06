using System.Collections.Generic;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGeneric<TypeCubemapName>))]
    public class TypeCubemapName : TypeStringBase<TypeCubemapName>, iTypeStringBase
        {
        private static volatile List<string> _values;

        public TypeCubemapName()
            {
            if (Values == null)
                LoadValues();
            }

        public TypeCubemapName(string value)
            {
            if (Values == null)
                LoadValues();
            this.Value = value;
            }

        public static List<string> Values
            {
            get { return _values; }
            }

        private void LoadValues()
            {
            List<string> values = new List<string>();
            lock (Omni.self.tick)
                {
                ModelBase group = "rootgroup";
                for (uint i = 0; i < group.getCount(); i++)
                    {
                    ModelBase o = group.getObject(i);
                    if (o.getClassName() == "CubemapData")
                        values.Add(o.getName());
                    }
                }
            _values = values;
            }
        }

    public static partial class Extension
        {
        /// <summary>
        /// Converts a string to a CubeMapName
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeCubemapName AsTypeCubemapName(this string value)
            {
            return new TypeCubemapName(value);
            }
        }
    }