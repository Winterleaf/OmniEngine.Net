#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class RectFIConverter : TypeConverter
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
                return new RectF(value as string);
                }

            return null;
            }
        }

    /// <summary>
    /// RectF Container
    /// </summary>
    [TypeConverter(typeof (RectFIConverter))]
    public class RectF : IConvertible
        {
        private readonly float _mExtent_x;
        private readonly float _mExtent_y;
        private readonly float _mPoint_x;
        private readonly float _mPoint_y;

        public static bool operator ==(RectF x, RectF _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object)_test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return
                (x._mExtent_x == _test._mExtent_x) &&
                (x._mExtent_y == _test._mExtent_y) &&
                (x._mPoint_x == _test._mPoint_x) &&
                (x._mPoint_y == _test._mPoint_y);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(RectF x, RectF _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return false;

            if (((object)_test) == null)
                return true;

            if (((object)x) == null)
                return true;

            return x != (_test) == false;
            }

        //private Point2F _mExtent; // = new Point2F(0, 0);
        //private Point2F _mPoint; // = new Point2F(0, 0);

        /// <summary>
        /// Creates RectF from string
        /// </summary>
        /// <param name="r"></param>
        public RectF(string r)
            {
            string[] vals = r.Split(' ');
            _mPoint_x = vals[0].AsFloat();
            _mPoint_y = vals[1].AsFloat();
            _mExtent_x = vals[2].AsFloat();
            _mExtent_y = vals[3].AsFloat();

            //_mExtent = new Point2F(vals[2].AsFloat(), vals[3].AsFloat());
            //_mPoint = new Point2F(vals[0].AsFloat(), vals[1].AsFloat());
            //_mExtent.OnChangeNotification += __OnChangeNotification;
            //_mPoint.OnChangeNotification += __OnChangeNotification;
            }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="point"></param>
        /// <param name="extent"></param>
        public RectF(Point2F point, Point2F extent)
            {
            _mPoint_x = point.x;
            _mPoint_y = point.y;
            _mExtent_x = extent.x;
            _mExtent_y = extent.y;

            //_mPoint = point;
            //_mPoint.DetachAllEvents();
            //_mExtent = extent;
            //_mExtent.DetachAllEvents();
            //_mExtent.OnChangeNotification += __OnChangeNotification;
            //_mPoint.OnChangeNotification += __OnChangeNotification;
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
        /// Returns String
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

        ///// <summary>
        ///// Point
        ///// </summary>
        //public Point2F mPoint
        //    {
        //    get { return _mPoint; }
        //    set
        //        {
        //        _mPoint = value;
        //        _mPoint.DetachAllEvents();
        //        _mPoint.OnChangeNotification += __OnChangeNotification;
        //        Notify(AsString());
        //        }
        //    }

        ///// <summary>
        ///// Extent
        ///// </summary>
        //public Point2F mExtent
        //    {
        //    get { return _mExtent; }
        //    set
        //        {
        //        _mExtent = value;
        //        _mExtent.DetachAllEvents();
        //        _mExtent.OnChangeNotification += __OnChangeNotification;
        //        Notify(AsString());
        //        }
        //    }

        /// <summary>
        /// 
        /// </summary>
        ~RectF()
            {
            // this.DetachAllEvents();
            }

        //private void __OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
        //    {
        //    Notify(AsString());
        //    }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} {3} ", _mPoint_x.AsString(), _mPoint_y.AsString(), _mExtent_x.AsString(),
                _mExtent_y.AsString());
            //if (((mPoint) != null) && (mExtent) != null)
            //    return string.Format("{0} {1} {2} {3} ", _mPoint.x.AsString(), _mPoint.y.AsString(), _mExtent.x.AsString(), _mExtent.y.AsString());
            //else
            //    return "";
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
        /// Converts String to a RectF
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RectF AsRectF(this string value)
            {
            return new RectF(value);
            }

        /// <summary>
        /// Converts RectF to a string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsString(this RectF value)
            {
            return value.AsString();
            }
        }
    }