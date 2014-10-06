#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class Point4FIConverter : TypeConverter
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
                return new Point4F(value as string);
                }

            return null;
            }
        }

    /// <summary>
    /// Point4F Container
    /// </summary>
    [TypeConverter(typeof (Point4FIConverter))]
    public class Point4F : IConvertible
        {
        private float _mW;
        private float _mX;
        private float _mY;
        private float _mZ;

        public static bool operator ==(Point4F x, Point4F _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object)_test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return
                (x._mW == _test._mW) &&
                (x._mX == _test._mX) &&
                (x._mZ == _test._mZ) &&
                (x._mY == _test._mY);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(Point4F x, Point4F _test)
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
        /// Creates a Point4F from a string.
        /// </summary>
        /// <param name="point4f"></param>
        public Point4F(string point4f)
            {
            string[] val = point4f.Split(' ');
            X = val[0].AsFloat();
            Y = val[1].AsFloat();
            Z = val[2].AsFloat();
            W = val[3].AsFloat();
            }

        /// <summary>
        /// Creates a Point4F
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public Point4F(float x, float y, float z, float w)
            {
            X = x;
            Y = y;
            Z = z;
            W = w;
            }

        /// <summary>
        /// X
        /// </summary>
        public float X
            {
            get { return _mX; }
            set
                {
                _mX = value;
                // Notify(AsString());
                }
            }

        /// <summary>
        /// Y
        /// </summary>
        public float Y
            {
            get { return _mY; }
            set
                {
                _mY = value;
                //    Notify(AsString());
                }
            }

        /// <summary>
        /// Z
        /// </summary>
        public float Z
            {
            get { return _mZ; }
            set
                {
                _mZ = value;
                //    Notify(AsString());
                }
            }

        /// <summary>
        /// W
        /// </summary>
        public float W
            {
            get { return _mW; }
            set
                {
                _mW = value;
                //  Notify(AsString());
                }
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
        ~Point4F()
            {
            //     this.DetachAllEvents();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} {3} ", X.AsString(), Y.AsString(), Z.AsString(), W.AsString());
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
            {
            return string.Format("{0} {1} {2} {3} ", X.AsString(), Y.AsString(), Z.AsString(), W.AsString());
            }
        }

    public static partial class Extension
        {
        /// <summary>
        /// Returns string as Point4F
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Point4F AsPoint4F(this string value)
            {
            return new Point4F(value);
            }
        }
    }