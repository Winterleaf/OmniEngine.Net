#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class RectSpacingIConverter : TypeConverter
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
                return new RectSpacingI(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// Used to hold the CSharp equiv of the RectSpacingI torque class.
    /// </summary>
    [TypeConverter(typeof (RectSpacingIConverter))]
    public sealed class RectSpacingI : IConvertible
        {
        private int _bottom;
        private int _left;
        private int _right;
        private int _top;

        public static bool operator ==(RectSpacingI x, RectSpacingI _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object)_test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return
                (x._bottom == _test._bottom) &&
                (x._left == _test._left) &&
                (x._right == _test._right) &&
                (x._top == _test._top);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(RectSpacingI x, RectSpacingI _test)
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
        /// <param name="l"></param>
        /// <param name="t"></param>
        /// <param name="b"></param>
        /// <param name="r"></param>
        public RectSpacingI(int l, int t, int b, int r)
            {
            left = l;
            top = t;
            bottom = b;
            right = r;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public RectSpacingI(string val)
            {
            string[] v = val.Split(' ');
            if (v.GetUpperBound(0) < 3)
                return;
            left = v[0].AsInt();
            top = v[1].AsInt();
            bottom = v[2].AsInt();
            right = v[3].AsInt();
            }

        /// <summary>
        /// 
        /// </summary>
        public int left
            {
            get { return _left; }
            set
                {
                _left = value;
                //   Notify(AsString());
                }
            }

        /// <summary>
        /// 
        /// </summary>
        public int top
            {
            get { return _top; }
            set
                {
                _top = value;
//Notify(AsString());
                }
            }

        /// <summary>
        /// 
        /// </summary>
        public int bottom
            {
            get { return _bottom; }
            set
                {
                _bottom = value;
                //      Notify(AsString());
                }
            }

        /// <summary>
        /// 
        /// </summary>
        public int right
            {
            get { return _right; }
            set
                {
                _right = value;
                //    Notify(AsString());
                }
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
        ~RectSpacingI()
            {
            //     this.DetachAllEvents();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} {3} ", left, top, bottom, right);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            return string.Format("{0} {1} {2} {3} ", left, top, bottom, right);
            }
        }

    public static partial class Extension
        {
        /// <summary>
        /// Returns string as RectSpacingI
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RectSpacingI AsRectSpacingI(this string value)
            {
            return new RectSpacingI(value);
            }
        }
    }