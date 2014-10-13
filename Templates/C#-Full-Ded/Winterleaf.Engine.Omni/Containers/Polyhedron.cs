// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using System;
using System.ComponentModel;
using System.Globalization;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Engine.Containers
{
    public class PolyhedronIConverter : TypeConverter
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
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
                return new Polyhedron(value as string);

            return null;
        }
    }

    /// <summary>
    /// Polyhedron Container
    /// </summary>
    [TypeConverter(typeof (PolyhedronIConverter))]
    public class Polyhedron : IConvertible
    {
        /// <summary>
        /// Initializes a new instance of the Polyhedron class.
        /// </summary>
        private Point3F _mOrigin; // = new Point3F();

        private Point3F _mVector1; // = new Point3F(0, 0, 0);

        private Point3F _mVector2; // = new Point3F(0, 0, 0);

        private Point3F _mVector3; // = new Point3F(0, 0, 0);

        /// <summary>
        /// Constructor
        /// </summary>
        public Polyhedron()
        {
            _mOrigin = new Point3F();
            //_mOrigin.OnChangeNotification += __OnChangeNotification;
            _mVector1 = new Point3F();
            //_mVector1.OnChangeNotification += __OnChangeNotification;
            _mVector2 = new Point3F();
            // _mVector2.OnChangeNotification += __OnChangeNotification;
            _mVector3 = new Point3F();
            //  _mVector3.OnChangeNotification += __OnChangeNotification;
        }

        /// <summary>
        /// Constructor Taking String
        /// </summary>
        /// <param name="poly"></param>
        public Polyhedron(string poly)
        {
            string[] pa = poly.Split(',');
            if (pa.Length >= 11)
                {
                _mOrigin = new Point3F();
                mOrigin.x = pa[0].AsFloat();
                mOrigin.y = pa[1].AsFloat();
                mOrigin.z = pa[2].AsFloat();
                _mVector1 = new Point3F();
                mVector1.x = pa[3].AsFloat();
                mVector1.y = pa[4].AsFloat();
                mVector1.z = pa[5].AsFloat();
                _mVector2 = new Point3F();
                mVector2.x = pa[6].AsFloat();
                mVector2.y = pa[7].AsFloat();
                mVector2.z = pa[8].AsFloat();
                _mVector3 = new Point3F();
                mVector3.x = pa[9].AsFloat();
                mVector3.y = pa[10].AsFloat();
                mVector3.z = pa[11].AsFloat();
                //_mOrigin.OnChangeNotification += __OnChangeNotification;
                //_mVector1.OnChangeNotification += __OnChangeNotification;
                //_mVector2.OnChangeNotification += __OnChangeNotification;
                //_mVector3.OnChangeNotification += __OnChangeNotification;
                }
            else
                throw new Exception("Bad Source Data for Polyhedron '" + poly + "'");
        }

        /// <summary>
        /// Vector 1
        /// </summary>
        public Point3F mVector1
        {
            get { return _mVector1; }
            set
            {
                _mVector1 = value;
                //_mVector1.DetachAllEvents();
                //_mVector1.OnChangeNotification += __OnChangeNotification;
                //Notify(AsString());
            }
        }

        /// <summary>
        /// Vector 2
        /// </summary>
        public Point3F mVector2
        {
            get { return _mVector2; }
            set
            {
                _mVector2 = value;
                //_mVector2.DetachAllEvents();
                //_mVector2.OnChangeNotification += __OnChangeNotification;
                //Notify(AsString());
            }
        }

        /// <summary>
        /// Vector 3
        /// </summary>
        public Point3F mVector3
        {
            get { return _mVector3; }
            set
            {
                _mVector3 = value;
                //_mVector3.DetachAllEvents();
                //_mVector3.OnChangeNotification += __OnChangeNotification;
                //Notify(AsString());
            }
        }

        /// <summary>
        /// Origin
        /// </summary>
        public Point3F mOrigin
        {
            get { return _mOrigin; }
            set
            {
                _mOrigin = value;
                //_mOrigin.DetachAllEvents();
                //_mOrigin.OnChangeNotification += __OnChangeNotification;
                //Notify(AsString());
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
        public char ToChar(IFormatProvider provider)
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
        public byte ToByte(IFormatProvider provider)
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
        public ushort ToUInt16(IFormatProvider provider)
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
        public uint ToUInt32(IFormatProvider provider)
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
        public ulong ToUInt64(IFormatProvider provider)
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
        public decimal ToDecimal(IFormatProvider provider)
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
        /// Converts to string
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public string ToString(IFormatProvider provider)
        {
            return AsString();
        }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        #endregion

        public static bool operator ==(Polyhedron x, Polyhedron _test)
        {
            if (((object) _test) == null && ((object) x == null))
                return true;

            if (((object) _test) == null)
                return false;

            if (((object) x) == null)
                return false;

            return (x._mOrigin == _test._mOrigin) && (x._mVector1 == _test._mVector1) && (x._mVector2 == _test._mVector2) && (x._mVector3 == _test._mVector3);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(Polyhedron x, Polyhedron _test)
        {
            if (((object) _test) == null && ((object) x == null))
                return false;

            if (((object) _test) == null)
                return true;

            if (((object) x) == null)
                return true;

            return x != (_test) == false;
        }

        /// <summary>
        /// 
        /// </summary>
        ~Polyhedron()
        {
            //this.DetachAllEvents();
        }

        //private void __OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
        //    {
        //    Notify(AsString());
        //    }

        /// <summary>
        /// Converts Polyhedron to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return AsString();
        }

        /// <summary>
        /// Converts Polyhedron to string
        /// </summary>
        /// <returns></returns>
        public string AsString()
        {
            if ((((object) mOrigin) != null) && (((object) mVector1) != null) && (((object) mVector2) != null) && (((object) mVector3) != null))
                return mOrigin.x.AsString() + " " + mOrigin.y.AsString() + " " + mOrigin.z.AsString() + " " + mVector1.x.AsString() + " " + mVector1.y.AsString() + " " + mVector1.z.AsString() + " " + mVector2.x.AsString() + " " + mVector2.y.AsString() + " " + mVector2.z.AsString() + " " + mVector3.x.AsString() + " " + mVector3.y.AsString() + " " + mVector3.z.AsString() + " ";
            return "";
        }
    }

    public static partial class Extension
    {
        /// <summary>
        /// Converts a Polyhedron to a string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsPolyhedron(this Polyhedron value)
        {
            return value.AsString();
        }

        /// <summary>
        /// Converts string to a Polyhedron
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Polyhedron AsPolyhedron(this string value)
        {
            return new Polyhedron(value);
        }
    }
}