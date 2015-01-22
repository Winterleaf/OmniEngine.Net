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
    public class Box3FIConverter : TypeConverter
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
                return new Box3F(value as string);

            return null;
        }
    }

    /// <summary>
    /// Used to hold the CSharp Equiv of the Box3F Torque Class.
    /// </summary>
    [TypeConverter(typeof (Box3FIConverter))]
    public sealed class Box3F : IConvertible
    {
        private float _maxExtents_x;
        private float _maxExtents_y;
        private float _maxExtents_z;

        private float _minExtents_x;
        private float _minExtents_y;
        private float _minExtents_z;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="box"></param>
        public Box3F(string box)
        {
            string[] parts = box.Split(' ');
            if (parts.GetUpperBound(0) < 5)
                throw new Exception("Bad Bounding!");

            mMinExtentsX = parts[0].AsFloat();
            mMinExtentsY = parts[1].AsFloat();
            mMinExtentsZ = parts[2].AsFloat();

            mMaxExtentsX = parts[3].AsFloat();
            mMaxExtentsY = parts[4].AsFloat();
            mMaxExtentsZ = parts[5].AsFloat();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minExtens_x"></param>
        /// <param name="minExtens_y"></param>
        /// <param name="minExtens_z"></param>
        /// <param name="maxExtens_x"></param>
        /// <param name="maxExtens_y"></param>
        /// <param name="maxExtens_z"></param>
        public Box3F(float minExtens_x, float minExtens_y, float minExtens_z, float maxExtens_x, float maxExtens_y, float maxExtens_z)
        {
            mMinExtentsX = minExtens_x;
            mMinExtentsY = minExtens_y;
            mMinExtentsZ = minExtens_z;
            mMaxExtentsX = maxExtens_x;
            mMaxExtentsY = maxExtens_y;
            mMaxExtentsZ = maxExtens_z;
        }

        /// <summary>
        /// 
        /// </summary>
        public Box3F()
        {
            mMinExtentsX = 0;
            mMinExtentsY = 0;
            mMinExtentsZ = 0;
            mMaxExtentsX = 0;
            mMaxExtentsY = 0;
            mMaxExtentsZ = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public float mMaxExtentsX
        {
            get { return _maxExtents_x; }
            set { _maxExtents_x = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mMaxExtentsY
        {
            get { return _maxExtents_y; }
            set { _maxExtents_y = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mMaxExtentsZ
        {
            get { return _maxExtents_z; }
            set { _maxExtents_z = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mMinExtentsX
        {
            get { return _minExtents_x; }
            set { _minExtents_x = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mMinExtentsY
        {
            get { return _minExtents_y; }
            set { _minExtents_y = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mMinExtentsZ
        {
            get { return _minExtents_z; }
            set { _minExtents_z = value; }
        }

        #region IConvertible Members

        /// <summary>
        /// 
        /// </summary>
        //public Point3F maxExtents
        //    {
        //    get { return _maxExtents; }
        //    set
        //        {
        //        _maxExtents = value;
        //        _maxExtents.DetachAllEvents();
        //        _maxExtents.OnChangeNotification += minExtents_OnChangeNotification;
        //        Notify(AsString());
        //        }
        //    }

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

        public static bool operator ==(Box3F x, Box3F _test)
        {
            if (((object) _test) == null && ((object) x == null))
                return true;

            if (((object) _test) == null)
                return false;

            if (((object) x) == null)
                return false;

            return (x._maxExtents_x == _test._maxExtents_x) && (x._maxExtents_y == _test._maxExtents_y) && (x._maxExtents_z == _test._maxExtents_z) && (x._minExtents_x == _test._minExtents_x) && (x._minExtents_y == _test._minExtents_y) && (x._minExtents_z == _test._minExtents_z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(Box3F x, Box3F _test)
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
        public Point3F Get_MaxExtents()
        {
            return new Point3F(mMaxExtentsX, mMaxExtentsY, mMaxExtentsZ);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Point3F Get_MinExtents()
        {
            return new Point3F(mMinExtentsX, mMinExtentsY, mMinExtentsZ);
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} ", mMinExtentsX.AsString(), mMinExtentsY.AsString(), mMinExtentsZ.AsString(), mMaxExtentsX.AsString(), mMaxExtentsY.AsString(), mMaxExtentsZ.AsString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return AsString();
        }

    }

    public static partial class Extension
    {
        /// <summary>
        /// Returns string as Box3F
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Box3F AsBox3F(this string value)
        {
            return new Box3F(value);
        }
    }
}