using System;
using System.ComponentModel;

namespace WinterLeaf.Engine.Containers
    {
    public class TypeConverterGenericString<T> : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof (string) == sourceType);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            object value)
            {
            if (value is string)
                {
                object ret = Activator.CreateInstance<T>();
                ((iTypeStringBase) ret).Value = value.ToString();
                return ret;
                }

            return null;
            }
        }

    public interface iTypeStringBase
        {
        string Value { get; set; }
        }

    public class TypeStringBase<T> : IConvertible
        {
        private string _Value = "";

        public TypeStringBase(string value)
            {
            _Value = value;
            }

        public TypeStringBase()
            {
            }

        public string Value
            {
            get { return _Value; }
            set { _Value = value; }
            }

        public static implicit operator string(TypeStringBase<T> value)
            {
            return value._Value;
            }

        public static implicit operator TypeStringBase<T>(string value)
            {
            return new TypeStringBase<T>(value);
            }

        public override string ToString()
            {
            return Value;
            }

        public string AsString()
            {
            return _Value;
            }

        #region IConvertable

        public TypeCode GetTypeCode()
            {
            throw new NotImplementedException();
            }

        public bool ToBoolean(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public char ToChar(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public sbyte ToSByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public byte ToByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public short ToInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public ushort ToUInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public int ToInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public uint ToUInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public long ToInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public ulong ToUInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public float ToSingle(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public double ToDouble(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public decimal ToDecimal(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public DateTime ToDateTime(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public object ToType(Type conversionType, IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public string ToString(IFormatProvider provider)
            {
            return Value;
            }

        #endregion
        }
    public static partial class Extension
        {
        }
    }