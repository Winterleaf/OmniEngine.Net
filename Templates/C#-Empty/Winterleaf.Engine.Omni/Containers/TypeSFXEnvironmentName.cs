using System.Collections.Generic;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGeneric<TypeSFXEnvironmentName>))]
    public class TypeSFXEnvironmentName : TypeStringBase<TypeSFXEnvironmentName>, iTypeStringBase
        {
        private static volatile List<string> _values;

        public TypeSFXEnvironmentName()
            {
            if (Values == null)
                LoadValues();
            }

        public TypeSFXEnvironmentName(string value)
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
                ModelBase group = "SFXEnvironmentSet";
                for (uint i = 0; i < group.getCount(); i++)
                    {
                    ModelBase o = group.getObject(i);
                    values.Add(o.getName());
                    }
                }
            _values = values;
            }
        }

    public static partial class Extension
        {
        /// <summary>
        /// Converts a string to a SFX Enviroment Name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeSFXEnvironmentName AsTypeSFXEnvironmentName(this string value)
            {
            return new TypeSFXEnvironmentName(value);
            }
        }
    }