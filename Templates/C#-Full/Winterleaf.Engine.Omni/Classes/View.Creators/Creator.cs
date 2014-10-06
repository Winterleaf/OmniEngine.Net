using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Classes.View.Creators
    {
    /// <summary>
    /// Abstract class that all creators share.
    /// </summary>
    public abstract class Creator
        {
        /// <summary>
        /// The C# proxy class to use for this singleton(Optional)
        /// </summary>
        protected string mModel { get; set; }

        /// <summary>
        /// The name of the instance of the object
        /// </summary>
        protected string mDatablockName { get; set; }

        /// <summary>
        /// The name of the TorqueScript class.
        /// </summary>
        protected string mClassName { get; set; }

        /// <summary>
        ///   The name of the instance of the object
        /// </summary>
        protected string mInstanceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object this[string key]
            {
            get { return _mParams[key]; }
            set
                {
                string tval = ((string)myReflections.ChangeType(value, typeof(string))).Trim();
                if (_mParams.ContainsKey(key))
                    _mParams.Remove(key);

                if (tval.StartsWith("\""))
                    _mParams.Add(key, tval.Trim());
                else
                    {
                    if ((value is SingletonCreator) || (value is ObjectCreator) || (value is StringNoQuote))
                        _mParams.Add(key, tval.Trim());
                    else
                        _mParams.Add(key, '"' + tval.Trim() + '"');
                    }
                }
            }

        /// <summary>
        /// Object Properties.
        /// </summary>
        protected readonly Dictionary<string, string> _mParams = new Dictionary<string, string>();

        public class StringNoQuote : IConvertible
            {
            public StringNoQuote(string value)
                {
                this.Value = value;
                }

            #region iInterface

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
                return Value;
                }

            public object ToType(Type conversionType, IFormatProvider provider)
                {
                throw new NotImplementedException();
                }

            public override string ToString()
                {
                return Value;
                }

            #endregion

            public string Value { get; set; }
            }


        /// <summary>
        ///   This will return the TorqueScript code that will be executed when Create is called.
        /// </summary>
        /// <returns> </returns>
        public override string ToString()
            {
            StringBuilder result = new StringBuilder();
            result.Append(")\r\n{\r\n");
            foreach (KeyValuePair<string, string> ele in _mParams)
                {
                if (ele.Key.StartsWith("#"))
                    {
                    result.Append("\r\n");
                    result.Append(ele.Value);
                    result.Append("\r\n");
                    }
                else
                    {
                    result.Append(ele.Key);
                    result.Append(" = ");
                    result.Append(ele.Value.Trim() != string.Empty ? ele.Value : @"""""");
                    result.Append(";\r\n");
                    }
                }
            result.Append("};\r\n");
            return (result.ToString());
            }
        #region iInterface

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
            return ToString();
            }

        public object ToType(Type conversionType, IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        #endregion
        }
    }
