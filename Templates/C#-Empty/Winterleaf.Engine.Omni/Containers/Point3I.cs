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
using WinterLeaf.Engine.Properties;

#endregion

namespace WinterLeaf.Engine.Containers
{
    public class Point3IIConverter : TypeConverter
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
                return new Point3I(value as string);

            return null;
        }
    }

    /// <summary>
    /// Used to hold the CSharp equiv of the Point3F class.
    /// </summary>
    [TypeConverter(typeof (Point3IIConverter))]
    public sealed class Point3I : IConvertible
    {
        /// <summary>
        /// 
        /// </summary>
        private const double POINT_EPSILON = (1e-4);

        private int _x;
        private int _y;
        private int _z;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transform"></param>
        public Point3I(string transform)
        {
            string[] parts = transform.Split(' ');
            if (parts.GetUpperBound(0) >= 2)
                {
                x = parts[0].AsInt();
                y = parts[1].AsInt();
                z = parts[2].AsInt();
                }
            else
                {
                Console.WriteLine(Resources.Point3F_Point3F_Point3F___Error_Invalid_Transform_ + transform);
                x = 0;
                y = 0;
                z = 0;
                }
        }

        /// <summary>
        /// 
        /// </summary>
        public Point3I()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Empty"></param>
        public Point3I(bool Empty)
        {
            x = 0;
            y = 0;
            z = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public Point3I(Point3I p)
        {
            x = p.x;
            y = p.y;
            z = p.z;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xyz"></param>
        public Point3I(int xyz)
        {
            x = xyz;
            y = xyz;
            z = xyz;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="in_x"></param>
        /// <param name="in_y"></param>
        /// <param name="in_z"></param>
        public Point3I(int in_x, int in_y, int in_z)
        {
            x = in_x;
            y = in_y;
            z = in_z;
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
                //   Notify(AsString());
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
                //     Notify(AsString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int z
        {
            get { return _z; }
            set
            {
                _z = value;
                //     Notify(AsString());
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

        public static bool operator ==(Point3I x, Point3I _test)
        {
            if (((object) _test) == null && ((object) x == null))
                return true;

            if (((object) _test) == null)
                return false;

            if (((object) x) == null)
                return false;

            return (x.x == _test.x) && (x.z == _test.z) && (x.y == _test.y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(Point3I x, Point3I _test)
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
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
        {
            return string.Format("{0} {1} {2} ", x.AsString(), y.AsString(), z.AsString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {
            return string.Format("{0} {1} {2} ", x.AsString(), y.AsString(), z.AsString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_test"></param>
        public void SetMin(Point3I _test)
        {
            x = (_test.x < x) ? _test.x : x;
            y = (_test.y < y) ? _test.y : y;
            z = (_test.z < z) ? _test.z : z;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_test"></param>
        public void SetMax(Point3I _test)
        {
            x = (_test.x > x) ? _test.x : x;
            y = (_test.y > y) ? _test.y : y;
            z = (_test.z > z) ? _test.z : z;
        }

        /// <summary>
        /// 
        /// </summary>
        public void neg()
        {
            x = -x;
            y = -y;
            z = -z;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_testo"></param>
        /// <returns></returns>
        public override bool Equals(object _testo)
        {
            Point3F _test = (Point3F) _testo;
            return (x == _test.x) && (y == _test.y) && (z == _test.z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_add"></param>
        /// <returns></returns>
        public static Point3I operator +(Point3I x, Point3I _add)
        {
            return new Point3I(x.x + _add.x, x.y + _add.y, x.z + _add.z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_rSub"></param>
        /// <returns></returns>
        public static Point3I operator -(Point3I x, Point3I _rSub)
        {
            return new Point3I(x.x - _rSub.x, x.y - _rSub.y, x.z - _rSub.z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_mul"></param>
        /// <returns></returns>
        public static Point3I operator *(Point3I x, int _mul)
        {
            return new Point3I(x.x*_mul, x.y*_mul, x.z*_mul);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_div"></param>
        /// <returns></returns>
        public static Point3I operator /(Point3I x, int _div)
        {
            if (_div == 0.0)
                throw new Exception("Error, Divide by Zero");
            int inv = 1/_div;
            return new Point3I(x.x*inv, x.y*inv, x.z*inv);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Point3I operator -(Point3I x)
        {
            return new Point3I(-x.x, -x.y, -x.z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double getMin(int a, int b)
        {
            return a > b ? b : a;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double getMax(int a, int b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double mDegToRad(double d)
        {
            return ((d*Math.PI)/180.0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static double mRadToDeg(int r)
        {
            return ((r*180.0)/Math.PI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public static Point3I vectorScale(Point3I point, int scalar)
        {
            return point*scalar;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static float vectorDot(Point3I p1, Point3I p2)
        {
            return (p1.x*p2.x + p1.y*p2.y + p1.z*p2.z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public Point3I vecotrScale(int scalar)
        {
            return this*scalar;
        }
    }

    public static partial class Extension
    {
        /// <summary>
        /// Returns string as Point3F
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Point3I AsPoint3I(this string value)
        {
            return new Point3I(value);
        }
    }
}