#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class ColorFIConverter : TypeConverter
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
                return new ColorF(value as string);
                }

            return null;
            }
        }

    /// <summary>
    /// Used to hold the CSharp equiv of the ColorF torque class.
    /// </summary>
    [TypeConverter(typeof (ColorFIConverter))]
    public sealed class ColorF : IConvertible
        {
        public static readonly ColorF ZERO = new ColorF(0.0f, 0.0f, 0.0f, 0.0f);
        public static readonly ColorF ONE = new ColorF(1.0f, 1.0f, 1.0f, 1.0f);
        public static readonly ColorF WHITE = new ColorF(1.0f, 1.0f, 1.0f);
        public static readonly ColorF BLACK = new ColorF(.0f, .0f, .0f);
        public static readonly ColorF RED = new ColorF(1.0f, 0.0f, 0.0f);
        public static readonly ColorF GREEN = new ColorF(0.0f, 1.0f, 0.0f);
        public static readonly ColorF BLUE = new ColorF(0.0f, 0.0f, 1.0f);


        private float _alpha;
        private float _blue;
        private float _green;
        private float _red;

        public static bool operator ==(ColorF x, ColorF _test)
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
                (x._red == _test._red) ;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(ColorF x, ColorF _test)
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
        public ColorF(float r, float g, float b, float a)
            {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
            }

        public ColorF(float r, float g, float b)
            {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = 1;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public ColorF(string val)
            {
            string[] v = val.Split(' ');
            if (v.GetUpperBound(0) < 3)
                return;
            Red = v[0].AsFloat();
            Green = v[1].AsFloat();
            Blue = v[2].AsFloat();
            Alpha = v[3].AsFloat();
            }

        /// <summary>
        /// 
        /// </summary>
        public float Red
            {
            get { return _red; }
            set { _red = value; }
            }

        /// <summary>
        /// 
        /// </summary>
        public float Green
            {
            get { return _green; }
            set { _green = value; }
            }

        /// <summary>
        /// 
        /// </summary>
        public float Blue
            {
            get { return _blue; }
            set { _blue = value; }
            }

        /// <summary>
        /// 
        /// </summary>
        public float Alpha
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
            return string.Format("{0} {1} {2} {3} ", Red.AsString(), Green.AsString(), Blue.AsString(), Alpha.AsString());
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            return string.Format("{0} {1} {2} {3} ", Red.AsString(), Green.AsString(), Blue.AsString(), Alpha.AsString());
            }
        }
    public static partial class Extension
        {
        /// <summary>
        /// Returns string as ColorF
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ColorF AsColorF(this string value)
            {
            return new ColorF(value);
            }
        }
    }