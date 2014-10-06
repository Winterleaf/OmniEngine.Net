#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class ColorIIConverter : TypeConverter
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
                return new ColorI(value as string);
                }

            return null;
            }
        }

    /// <summary>
    /// Used to hold the CSharp Equiv of the ColorI torque class.
    /// </summary>
    /// 
    [TypeConverter(typeof (ColorIIConverter))]
    public sealed class ColorI : IConvertible
        {
        public static readonly ColorI ZERO = new ColorI(0, 0, 0, 0);
        public static readonly ColorI ONE = new ColorI(255, 255, 255, 255);
        public static readonly ColorI WHITE = new ColorI(255, 255, 255);
        public static readonly ColorI BLACK = new ColorI(0, 0, 0);
        public static readonly ColorI RED = new ColorI(255, 0, 0);
        public static readonly ColorI GREEN = new ColorI(0, 255, 0);
        public static readonly ColorI BLUE = new ColorI(0, 0, 255);

        //const ColorI ColorI::ZERO( 0, 0, 0, 0 );
        //const ColorI ColorI::ONE( 255, 255, 255, 255 );
        //const ColorI ColorI::WHITE( 255, 255, 255 );
        //const ColorI ColorI::BLACK( 0, 0, 0 );
        //const ColorI ColorI::RED( 255, 0, 0 );
        //const ColorI ColorI::GREEN( 0, 255, 0 );
        //const ColorI ColorI::BLUE( 0, 0, 255 );

        private byte _alpha;
        private byte _blue;
        private byte _green;
        private byte _red;

        public static bool operator ==(ColorI x, ColorI _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object)_test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return (x._alpha == _test._alpha) &&
                (x._blue == _test._blue) &&
                (x._green == _test._green) &&
                (x._red == _test._red);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(ColorI x, ColorI _test)
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
        /// 
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        public ColorI(byte r, byte g, byte b, byte a)
            {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
            }

        public ColorI(byte r, byte g, byte b)
            {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = 255;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public ColorI(string val)
            {
            string[] v = val.Split(' ');
            if (v.GetUpperBound(0) < 3)
                return;
            Red = v[0].AsByte();
            Green = v[1].AsByte();
            Blue = v[2].AsByte();
            Alpha = v[3].AsByte();
            }

        /// <summary>
        /// 
        /// </summary>
        public byte Red
            {
            get { return _red; }
            set { _red = value; }
            }

        /// <summary>
        /// 
        /// </summary>
        public byte Green
            {
            get { return _green; }
            set { _green = value; }
            }

        /// <summary>
        /// 
        /// </summary>
        public byte Blue
            {
            get { return _blue; }
            set { _blue = value; }
            }

        /// <summary>
        /// 
        /// </summary>
        public byte Alpha
            {
            get { return _alpha; }
            set { _alpha = value; }
            }

        #region IConvertible Members

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public TypeCode GetTypeCode()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public bool ToBoolean(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public byte ToByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public char ToChar(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public DateTime ToDateTime(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public decimal ToDecimal(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public double ToDouble(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public short ToInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public int ToInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public long ToInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public sbyte ToSByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public float ToSingle(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToString(IFormatProvider provider)
            {
            return this.AsString();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public object ToType(Type conversionType, IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public ushort ToUInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public uint ToUInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public ulong ToUInt64(IFormatProvider provider)
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
            return string.Format("{0} {1} {2} {3} ", Red, Green, Blue, Alpha);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            return string.Format("{0} {1} {2} {3} ", Red, Green, Blue, Alpha);
            }
        }
    public static partial class Extension
        {
        /// <summary>
        /// Returns String as ColorI
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ColorI AsColorI(this string value)
            {
            return new ColorI(value);
            }
        }
    }