//using WinterLeaf.userObjects.ProxyObjects;
using System.Collections.Generic;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Containers
    {
    [TypeConverter(typeof (TypeConverterGeneric<TypeMaterialName>))]
    public class TypeMaterialName : TypeStringBase<TypeMaterialName>, iTypeStringBase
        {
        private static volatile List<string> _values;

        public TypeMaterialName()
            {
            //if (Values == null)
            //    LoadValues();
            }

        public TypeMaterialName(string value)
            {
            //if (Values == null)
            //    LoadValues();
            this.Value = value;
            }

        public static List<string> Values
            {
            get { return _values; }
            }

        //private void LoadValues()
        //    {
        //    List<string> values = new List<string>();
        //    lock (Omni.self.tick)
        //        {
        //        ProxyObject group = "rootgroup";
        //        for (uint i = 0; i < group.getCount(); i++)
        //            {
        //            ProxyObject o = group.getObject(i);
        //            if (o.getClassName() == "CubemapData")
        //                values.Add(o.getName());
        //            }
        //        }
        //    _values = values;
        //    }
        }

    public static partial class Extension
        {
        /// <summary>
        /// Converts a string to a Material Name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeMaterialName AsTypeMaterialName(this string value)
            {
            return new TypeMaterialName(value);
            }

        }
    }