using System.Collections.Generic;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGeneric<TypeSFXAmbienceName>))]
    public class TypeSFXAmbienceName : TypeStringBase<TypeSFXAmbienceName>, iTypeStringBase
        {
        private static volatile List<string> _values;

        public TypeSFXAmbienceName()
            {
            if (Values == null)
                LoadValues();
            }

        public TypeSFXAmbienceName(string value)
            {
            this.Value = value;
            if (Values == null)
                LoadValues();
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
                ModelBase group = "SFXAmbienceSet";
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
        /// Converts a string to a SFX Ambience Name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeSFXAmbienceName AsTypeSFXAmbienceName(this string value)
            {
            return new TypeSFXAmbienceName(value);
            }
        }
    }