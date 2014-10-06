using System.Collections.Generic;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGeneric<TypeSFXDescriptionName>))]
    public class TypeSFXDescriptionName : TypeStringBase<TypeSFXDescriptionName>, iTypeStringBase
        {
        private static volatile List<string> _values;

        public TypeSFXDescriptionName()
            {
            if (Values == null)
                LoadValues();
            }

        public TypeSFXDescriptionName(string value)
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
                ModelBase group = "SFXDescriptionSet";
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
        /// Converts a string to SFX Description Name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeSFXDescriptionName AsTypeSFXDescriptionName(this string value)
            {
            return new TypeSFXDescriptionName(value);
            }
        }
    }