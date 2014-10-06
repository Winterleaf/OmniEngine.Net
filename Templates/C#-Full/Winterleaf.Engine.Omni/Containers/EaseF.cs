#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class EaseFIConverter : TypeConverter
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
                return new EaseF(value as string);
                }

            return null;
            }
        }

    /// <summary>
    /// EaseF Implementation
    /// </summary>
    [TypeConverter(typeof (EaseFIConverter))]
    public class EaseF : IConvertible
        {
        private int _mDirection;
        private int _mParam1;
        private int _mParam2;
        private int _mType;

        public static bool operator ==(EaseF x, EaseF _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object)_test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return (x._mDirection == _test._mDirection) &&
                (x._mParam1 == _test._mParam1) &&
                (x._mParam2 == _test._mParam2) &&
                (x._mType == _test._mType);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(EaseF x, EaseF _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return false;

            if (((object)_test) == null)
                return true;

            if (((object)x) == null)
                return true;

            return x != (_test) == false;
            }

        /// <summary>
        /// Parse EaseF from string
        /// </summary>
        /// <param name="easef"></param>
        public EaseF(string easef)
            {
            string[] v = easef.Split(' ');
            _mDirection = v[0].AsInt();
            _mType = v[1].AsInt();
            try
                {
                _mParam1 = v[2].AsInt();
                _mParam2 = v[3].AsInt();
                }
            catch (Exception)
                {
                }
            }

        /// <summary>
        /// Create EaseF
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="type"></param>
        public EaseF(int direction, int type)
            {
            _mDirection = direction;
            _mType = type;
            }

        /// <summary>
        /// Create EaseF
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="type"></param>
        /// <param name="param1"></param>
        public EaseF(int direction, int type, int param1)
            {
            _mDirection = direction;
            _mType = type;
            _mParam1 = param1;
            }

        /// <summary>
        /// create EaseF
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="type"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        public EaseF(int direction, int type, int param1, int param2)
            {
            _mDirection = direction;
            _mType = type;
            _mParam1 = param1;
            _mParam2 = param2;
            }

        /// <summary>
        /// Direction
        /// </summary>
        public int mDirection
            {
            get { return _mDirection; }
            set { _mDirection = value; }
            }

        /// <summary>
        /// Type
        /// </summary>
        public int mType
            {
            get { return _mType; }
            set { _mType = value; }
            }

        /// <summary>
        /// Param 1
        /// </summary>
        public int mParam1
            {
            get { return _mParam1; }
            set { _mParam1 = value; }
            }

        /// <summary>
        /// Param 2
        /// </summary>
        public int mParam2
            {
            get { return _mParam2; }
            set { _mParam2 = value; }
            }

        #region IConvertible Members

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public TypeCode GetTypeCode()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public bool ToBoolean(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public char ToChar(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public sbyte ToSByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public byte ToByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public short ToInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public ushort ToUInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public int ToInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public uint ToUInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public long ToInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public ulong ToUInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public float ToSingle(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public double ToDouble(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public decimal ToDecimal(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public DateTime ToDateTime(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Converts to string
        /// </summary>
        /// <returns></returns>
        public string ToString(IFormatProvider provider)
            {
            return AsString();
            }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public object ToType(Type conversionType, IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} {3} ", _mDirection, _mType, _mParam1, _mParam2);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
            {
            return AsString();
            }
        }

    public static partial class Extension
        {
        /// <summary>
        /// Converts string to an EaseF
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EaseF AsEaseF(this string value)
            {
            return new EaseF(value);
            }
        }
    }