#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class AngAxisFIConverter : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof(string) == sourceType);
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
                return new AngAxisF(value as string);
                }

            return null;
            }
        }

    [TypeConverter(typeof(AngAxisFIConverter))]
    public class AngAxisF : IConvertible
        {
        private float _mAngle;

        private float _mAxis_x;
        private float _mAxis_y;
        private float _mAxis_z;


        public static bool operator ==(AngAxisF x, AngAxisF _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object)_test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return (x.x == _test.x) && (x.y == _test.y) && (x.z == _test.z) && (x._mAngle == _test.mAngle);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(AngAxisF x, AngAxisF _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return false;

            if (((object)_test) == null)
                return true;

            if (((object)x) == null)
                return true;

            return x != (_test) == false;
            }


        // private Point3F _mAxis;

        /// <summary>
        /// Constructor From String
        /// </summary>
        /// <param name="angaxisf"></param>
        public AngAxisF(string angaxisf)
            {
            string[] parts = angaxisf.Split(' ');
            if (parts.GetUpperBound(0) >= 0)
                _mAxis_x = parts[0].AsFloat();
            if (parts.GetUpperBound(0) >= 1)
                _mAxis_y = parts[1].AsFloat();
            if (parts.GetUpperBound(0) >= 2)
                _mAxis_z = parts[2].AsFloat();
            if (parts.GetUpperBound(0) >= 3)
                _mAngle = parts[3].AsFloat();
            }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="angle"></param>
        public AngAxisF(Point3F axis, float angle)
            {
            _mAngle = angle;
            }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="angle"></param>
        public AngAxisF(float x, float y, float z, float angle)
            {
            _mAngle = angle;
            }

        /// <summary>
        /// Angle
        /// </summary>
        public float mAngle
            {
            get { return _mAngle; }
            set { _mAngle = value; }
            }

        /// <summary>
        /// X
        /// </summary>
        public float x
            {
            get { return _mAxis_x; }
            set { _mAxis_x = value; }
            }

        /// <summary>
        /// Y
        /// </summary>
        public float y
            {
            get { return _mAxis_y; }
            set { _mAxis_y = value; }
            }

        /// <summary>
        /// Z
        /// </summary>
        public float z
            {
            get { return _mAxis_z; }
            set { _mAxis_z = value; }
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
        /// Converts To String
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
            return string.Format("{0} {1} {2} {3} ", _mAxis_x, _mAxis_y, _mAxis_z, _mAngle);
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
        /// Converts a string to a AngAxisF
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static AngAxisF AsAngAxisF(this string value)
            {
            return new AngAxisF(value);
            }
        }

    }