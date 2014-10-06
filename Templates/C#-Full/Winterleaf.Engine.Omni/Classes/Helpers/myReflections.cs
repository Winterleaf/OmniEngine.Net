

using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using WinterLeaf.Engine.Classes.Extensions;

namespace WinterLeaf.Engine.Classes.Helpers
    {
    /// <summary>
    /// Static class used for casting T3D objects to different types.
    /// </summary>
    public static class myReflections
        {
        public static T ChangeType<T>(object value)
            {
            return (T)ChangeType(value, typeof(T));
            }

        /// <summary>
        ///   The Microsoft ChangeType method doesn't always work, especially when your dealling with constructor base object types. or, when your trying to deal with enumerations. This function overrides the buggy ones Microsoft wrote with work arounds, and leaves the functioning Microsoft ones in tack.
        /// </summary>
        /// <param name="value"> The value to be converted </param>
        /// <param name="type"> The target type </param>
        /// <returns>The passed object as the target type. </returns>
        /// 
        /// 
        public static object ChangeType(object value, Type type)
            {

            if (value == null)
                return null;
            if (value.GetType() == type)
                return value;
            if (type == null)
                return value;

            if (type != typeof(float)) return _ChangeType(value, type);

            double retval = (double)_ChangeType(value, typeof(double));

            return (float)retval;
            }

        private static object _ChangeType(object value, Type type)
            {
            if (value is string && (string)value == "(null)")
                value = "0";

            if (type == typeof(bool) && value is string)
                return ((string)value).AsBool();

            if (!type.IsPrimitive)
                if (TypeDescriptor.GetConverter(type).CanConvertFrom(value.GetType()))
                    return TypeDescriptor.GetConverter(type).ConvertFrom(value);

            if (type.IsEnum)
                {
                if (value is string)
                    return Enum.Parse(type, value as string, true);
                return Enum.ToObject(type, value);
                }
            if (!type.IsInterface && type.IsGenericType)
                return Activator.CreateInstance(type, new[] { ChangeType(value, type.GetGenericArguments()[0]) });
            if (value is string && type == typeof(Guid))
                return new Guid(value as string);
            if (value is string && type == typeof(Version))
                return new Version(value as string);
            if (!(value is IConvertible))
                return value;
            if (!(value is string)) return Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
            if ((value.ToString().Trim() == string.Empty) &&
                (
                    (type == typeof(decimal)) ||
                    (type == typeof(double)) ||
                    (type == typeof(float)) ||
                    (type == typeof(int)) ||
                    (type == typeof(long)) ||
                    (type == typeof(short)) ||
                    (type == typeof(uint)) ||
                    (type == typeof(ulong)) ||
                    (type == typeof(ushort)))
                )
                value = "0";

            return Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
            }

        public static bool IsSameOrSubclass(this Type potentialBase, Type potentialDescendant)
            {
            return potentialDescendant.IsSubclassOf(potentialBase)
                 || potentialDescendant == potentialBase;
            }
        }
    }
