using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

namespace WinterLeaf.Engine.Containers
    {
    public class MatrixPositionIConverter : TypeConverter
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
                return new MatrixPosition(value as string);
                }

            return null;
            }
        }

    [TypeConverter(typeof (MatrixPositionIConverter))]
    public class MatrixPosition : IConvertible
        {
        private float w;
        private float x;
        private float y;
        private float z;


        public static bool operator ==(MatrixPosition x, MatrixPosition _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object)_test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return (x.w == _test.w) &&
                (x.x == _test.x) &&
                (x.y == _test.y) &&
                (x.z == _test.z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(MatrixPosition x, MatrixPosition _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return false;

            if (((object)_test) == null)
                return true;

            if (((object)x) == null)
                return true;

            return x != (_test) == false;
            }


        public MatrixPosition(string matrixf)
            {
            // matrixf += " ";
            string[] parts = matrixf.Split(' ');
            if (parts.GetUpperBound(0) >= 0)
                x = parts[0].AsFloat();
            if (parts.GetUpperBound(0) >= 1)
                y = parts[1].AsFloat();
            if (parts.GetUpperBound(0) >= 2)
                z = parts[2].AsFloat();
            if (parts.GetUpperBound(0) >= 3)
                w = parts[3].AsFloat();
            }

        public float X
            {
            get { return x; }
            set { x = value; }
            }

        public float Y
            {
            get { return y; }
            set { y = value; }
            }

        public float Z
            {
            get { return z; }
            set { z = value; }
            }

        public float W
            {
            get { return w; }
            set { w = value; }
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
            return x.AsString() + " " + y.AsString() + " " + z.AsString() + " " + w.AsString();
            }

        public override string ToString()
            {
            return AsString();
            }
        }
    public static partial class Extension
        {
        /// <summary>
        /// Converts a string to a Matrix Position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MatrixPosition AsMatrixPosition(this string value)
            {
            return new MatrixPosition(value);
            }
        }
    }