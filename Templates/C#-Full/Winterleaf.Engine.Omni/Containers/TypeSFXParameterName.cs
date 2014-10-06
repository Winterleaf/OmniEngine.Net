using System.Collections.Generic;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGeneric<TypeSFXParameterName>))]
    public class TypeSFXParameterName : TypeStringBase<TypeSFXParameterName>, iTypeStringBase
        {
        private static volatile List<string> _values;

        public TypeSFXParameterName()
            {
            if (Values == null)
                LoadValues();
            }

        public TypeSFXParameterName(string value)
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
                ModelBase group = "SFXParameterGroup";
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
        /// Converts a string toa SFX Parameter Name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeSFXParameterName AsTypeSFXParameterName(this string value)
            {
            return new TypeSFXParameterName(value);
            }
        }
    }