#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class RectIIConverter : TypeConverter
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
                return new RectI(value as string);
                }

            return null;
            }
        }

    /// <summary>
    /// RectI container
    /// </summary>
    [TypeConverter(typeof (RectIIConverter))]
    public class RectI : IConvertible
        {
        private readonly int _mExtent_x;
        private readonly int _mExtent_y;

        private readonly int _mPoint_x;
        private readonly int _mPoint_y;

        public static bool operator ==(RectI x, RectI _test)
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
        public static bool operator !=(RectI x, RectI _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return false;

            if (((object)_test) == null)
                return true;

            if (((object)x) == null)
                return true;

            return x != (_test) == false;
            }

        //private Point2I _mExtent;
        //private Point2I _mPoint;

        /// <summary>
        /// Creates RectI from string
        /// </summary>
        /// <param name="recti"></param>
        public RectI(string recti)
            {
            string[] vals = recti.Split(' ');
            _mPoint_x = vals[0].AsInt();
            _mPoint_y = vals[1].AsInt();
            _mExtent_x = vals[2].AsInt();
            _mExtent_y = vals[3].AsInt();

            //_mPoint = new Point2I(vals[0].AsInt(), vals[1].AsInt());
            //_mExtent = new Point2I(vals[2].AsInt(), vals[3].AsInt());
            //_mPoint.OnChangeNotification += __OnChangeNotification;
            //_mExtent.OnChangeNotification += __OnChangeNotification;
            }

        /// <summary>
        /// Creates RectI
        /// </summary>
        /// <param name="point"></param>
        /// <param name="extent"></param>
        public RectI(Point2I point, Point2I extent)
            {
            _mPoint_x = point.x;
            _mPoint_y = point.y;
            _mExtent_x = extent.x;
            _mExtent_y = extent.y;
            //_mPoint = point;
            //_mPoint.DetachAllEvents();
            //_mExtent = extent;
            //_mExtent.DetachAllEvents();
            //_mPoint.OnChangeNotification += __OnChangeNotification;
            //_mExtent.OnChangeNotification += __OnChangeNotification;
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
        //public Point2I mPoint
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
        //public Point2I mExtent
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
        ~RectI()
            {
            // this.DetachAllEvents();
            }

        //private void __OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
        //    {
        //    /Notify(AsString());
        //    }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} {3} ", _mPoint_x, _mPoint_y, _mExtent_x, _mExtent_y);

            //if ((mPoint) != null && (mExtent) != null)
            //    return string.Format("{0} {1} {2} {3} ", _mPoint.x, _mPoint.y, _mExtent.x, _mExtent.y);
            //return "";
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
        /// Converts string to a RectI
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RectI AsRectI(this string value)
            {
            return new RectI(value);
            }
        }
    }