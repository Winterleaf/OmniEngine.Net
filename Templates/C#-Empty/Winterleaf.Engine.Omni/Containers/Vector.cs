#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
    {

    #region Vector Int

    #region IConverter

    /// <summary>
    /// 
    /// </summary>
    /// 
    internal class VectorIntIConverter : TypeConverter
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
                return new VectorInt(value as string);
                }

            return null;
            }
        }

    #endregion

    /// <summary>
    /// Supports Vectors of Ints
    /// </summary>
    [TypeConverter(typeof (VectorIntIConverter))]
    public class VectorInt : IConvertible
        {
        private List<int> _mData = new List<int>();

        /// <summary>
        /// Loads an array into the object
        /// </summary>
        /// <param name="v"></param>
        public VectorInt(int[] v)
            {
            _mData.Clear();
            foreach (int b in v)
                _mData.Add(b);
            }

        /// <summary>
        /// Loads a space delimited string into the vector
        /// </summary>
        /// <param name="v"></param>
        public VectorInt(string v)
            {
            _mData.Clear();
            string[] vals = v.Split(' ');
            foreach (string s in vals)
                {
                if (s.Trim() != "")
                    _mData.Add(s.AsInt());
                }
            }

        /// <summary>
        /// The data represented as an array
        /// </summary>
        public int[] vector
            {
            get { return _mData.ToArray(); }
            set
                {
                _mData = value.ToList();
                //   Notify(AsString());
                }
            }

        /// <summary>
        /// The data represented as a list
        /// </summary>
        public List<int> list
            {
            get { return _mData; }
            set
                {
                _mData = value;
                //      Notify(AsString());
                }
            }

        /// <summary>
        /// Gets or sets value at index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
            {
            get { return _mData[index]; }
            set
                {
                _mData[index] = value;
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
        ~VectorInt()
            {
            //   this.DetachAllEvents();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            string r = "";
            foreach (int i in _mData)
                {
                if (r == "")
                    r = i.AsString();
                else
                    r += " " + i.AsString();
                }
            return r;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return ToString();
            }
        }

    #endregion

    #region Vector Float

    #region IConvertable

    /// <summary>
    /// 
    /// </summary>
    /// 
    internal class VectorFloatIConverter : TypeConverter
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
                return new VectorFloat(value as string);
                }

            return null;
            }
        }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (VectorFloatIConverter))]
    public class VectorFloat : IConvertible
        {
        private List<float> _mData = new List<float>();

        /// <summary>
        /// Loads an array into the object
        /// </summary>
        /// <param name="v"></param>
        public VectorFloat(float[] v)
            {
            _mData.Clear();
            foreach (float b in v)
                _mData.Add(b);
            }

        /// <summary>
        /// Loads a space delimited string into the vector
        /// </summary>
        /// <param name="v"></param>
        public VectorFloat(string v)
            {
            _mData.Clear();
            string[] vals = v.Split(' ');
            foreach (string s in vals)
                {
                if (s.Trim() != "")
                    _mData.Add(s.AsFloat());
                }
            }

        /// <summary>
        /// The data represented as an array
        /// </summary>
        public float[] vector
            {
            get { return _mData.ToArray(); }
            set
                {
                _mData = value.ToList();
                //  Notify(AsString());
                }
            }

        /// <summary>
        /// The data represented as a list
        /// </summary>
        public List<float> list
            {
            get { return _mData; }
            set
                {
                _mData = value;
                //    Notify(AsString());
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

        /// <summary>
        /// 
        /// </summary>
        ~VectorFloat()
            {
            //    this.DetachAllEvents();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            string r = "";
            foreach (float i in _mData)
                {
                if (r == "")
                    r = i.AsString();
                else
                    r += " " + i.AsString();
                }
            return r;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return ToString();
            }
        }

    #endregion

    #region Vector Bool

    #region IConvert

    /// <summary>
    /// 
    /// </summary>
    /// 
    internal class VectorBoolIConverter : TypeConverter
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
                return new VectorBool(value as string);
                }

            return null;
            }
        }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (VectorBoolIConverter))]
    public class VectorBool : IConvertible
        {
        private List<bool> _mData = new List<bool>();

        /// <summary>
        /// Loads an array into the object
        /// </summary>
        /// <param name="v"></param>
        public VectorBool(bool[] v)
            {
            _mData.Clear();
            foreach (bool b in v)
                _mData.Add(b);
            }

        /// <summary>
        /// Loads a space delimited string into the vector
        /// </summary>
        /// <param name="v"></param>
        public VectorBool(string v)
            {
            _mData.Clear();
            string[] vals = v.Split(' ');
            foreach (string s in vals.Where(s => s.Trim() != ""))
                _mData.Add(s.AsBool());
            }


        /// <summary>
        /// The data represented as an array
        /// </summary>
        public bool[] vector
            {
            get { return _mData.ToArray(); }
            set
                {
                _mData = value.ToList();
                //      Notify(AsString());
                }
            }

        /// <summary>
        /// The data represented as a list
        /// </summary>
        public List<bool> list
            {
            get { return _mData; }
            set
                {
                _mData = value;
                //      Notify(AsString());
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

        /// <summary>
        /// 
        /// </summary>
        ~VectorBool()
            {
            //   this.DetachAllEvents();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            string r = "";
            foreach (bool i in _mData)
                {
                if (r == "")
                    r = i.AsString();
                else
                    r += " " + i.AsString();
                }
            return r;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return ToString();
            }
        }

    #endregion

    public static partial class Extension
        {
        /// <summary>
        /// Converts string to a Vector of Bools
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VectorBool AsVectorBool(this string value)
            {
            return new VectorBool(value);
            }

        /// <summary>
        /// Converts string to a Vector of Ints
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VectorInt AsVectorInt(this string value)
            {
            return new VectorInt(value);
            }

        /// <summary>
        /// Converts string to a Vector of Floats.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VectorFloat AsVectorFloat(this string value)
            {
            return new VectorFloat(value);
            }
        }
    }