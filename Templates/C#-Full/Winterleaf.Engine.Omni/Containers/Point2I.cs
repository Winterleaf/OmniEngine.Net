#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class Point2IIConverter : TypeConverter
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
                return new Point2I(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// Used to hold CSharp equiv of the Point2I Torque Class.
    /// </summary>
    [TypeConverter(typeof (Point2IIConverter))]
    public sealed class Point2I : IConvertible
        {
        private int _x;
        private int _y;

        public static bool operator ==(Point2I x, Point2I _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object)_test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return
                (x.x == _test.x) &&
                (x.y == _test.y);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(Point2I x, Point2I _test)
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
        /// <param name="mx"></param>
        /// <param name="my"></param>
        public Point2I(int mx, int my)
            {
            x = mx;
            y = my;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public Point2I(string val)
            {
            string[] v = val.Split(' ');
            if (v.GetUpperBound(0) < 1)
                return;
            x = v[0].AsInt();
            y = v[1].AsInt();
            }

        /// <summary>
        /// 
        /// </summary>
        public int x
            {
            get { return _x; }
            set
                {
                _x = value;
                // Notify(AsString());
                }
            }

        /// <summary>
        /// 
        /// </summary>
        public int y
            {
            get { return _y; }
            set
                {
                _y = value;
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
        ~Point2I()
            {
            //    this.DetachAllEvents();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} ", x, y);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            return string.Format("{0} {1} ", x, y);
            }
        }
    public static partial class Extension
        {
        /// <summary>
        /// Returns string as Point2I
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Point2I AsPoint2I(this string value)
            {
            return new Point2I(value);
            }
        }
    }