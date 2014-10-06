using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

namespace WinterLeaf.Engine.Containers
    {
    public class MatrixFIConverter : TypeConverter
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
                return new MatrixF(value as string);
                }

            return null;
            }
        }

    [TypeConverter(typeof (MatrixFIConverter))]
    public class MatrixF : IConvertible
        {
        private float _c0x;
        private float _c0y;
        private float _c0z;

        private float _c1x;
        private float _c1y;
        private float _c1z;

        private float _c2x;
        private float _c2y;
        private float _c2z;

        public static bool operator ==(MatrixF x, MatrixF _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object)_test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return (x._c0x == _test._c0x) &&
                (x._c0y == _test._c0y) &&
                (x._c0z == _test._c0z) &&
                (x._c1x == _test._c1x) &&
                (x._c1y == _test._c1y) &&
                (x._c1z == _test._c1z) &&
                (x._c2x == _test._c2x) &&
                (x._c2y == _test._c2y) &&
                (x._c2z == _test._c2z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(MatrixF x, MatrixF _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return false;

            if (((object)_test) == null)
                return true;

            if (((object)x) == null)
                return true;

            return x != (_test) == false;
            }

        #region Properties

        public float C0X
            {
            get { return _c0x; }
            set { _c0x = value; }
            }

        public float C0Y
            {
            get { return _c0y; }
            set { _c0y = value; }
            }

        public float C0Z
            {
            get { return _c0z; }
            set { _c0z = value; }
            }

        public float C1X
            {
            get { return _c1x; }
            set { _c1x = value; }
            }

        public float C1Y
            {
            get { return _c1y; }
            set { _c1y = value; }
            }

        public float C1Z
            {
            get { return _c1z; }
            set { _c1z = value; }
            }

        public float C2X
            {
            get { return _c2x; }
            set { _c2x = value; }
            }

        public float C2Y
            {
            get { return _c2y; }
            set { _c2y = value; }
            }

        public float C2Z
            {
            get { return _c2z; }
            set { _c2z = value; }
            }

        #endregion

        public MatrixF(string matrixf)
            {
            // matrixf += " ";
            string[] parts = matrixf.Split(' ');
            if (parts.GetUpperBound(0) >= 1)
                _c0x = parts[0].AsFloat();
            if (parts.GetUpperBound(0) >= 2)
                _c0y = parts[1].AsFloat();
            if (parts.GetUpperBound(0) >= 3)
                _c0z = parts[2].AsFloat();

            if (parts.GetUpperBound(0) >= 4)
                _c1x = parts[3].AsFloat();
            if (parts.GetUpperBound(0) >= 5)
                _c1y = parts[4].AsFloat();
            if (parts.GetUpperBound(0) >= 6)
                _c1z = parts[5].AsFloat();

            if (parts.GetUpperBound(0) >= 7)
                _c2x = parts[6].AsFloat();
            if (parts.GetUpperBound(0) >= 8)
                _c2y = parts[7].AsFloat();
            if (parts.GetUpperBound(0) >= 9)
                _c2z = parts[8].AsFloat();
            }

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

        public string ToString(IFormatProvider provider)
            {
            return AsString();
            }

        public object ToType(Type conversionType, IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public string AsString()
            {
            return _c0x.AsString() + " " + _c0y.AsString() + " " + C0Z.AsString() +
                   _c1x.AsString() + " " + _c1y.AsString() + " " + C1Z.AsString() +
                   _c2x.AsString() + " " + _c2y.AsString() + " " + C2Z.AsString();
            }
        }

    public static partial class Extension
        {
        /// <summary>
        /// Converts a string to a MatrixF
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MatrixF AsMatrixF(this string value)
            {
            return new MatrixF(value);
            }
        }
    }