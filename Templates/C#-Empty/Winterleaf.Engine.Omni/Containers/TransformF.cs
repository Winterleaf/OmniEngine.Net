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

using System.Globalization;
using WinterLeaf.Engine.Classes.Extensions;

#region

#region

using System;
using System.ComponentModel;

#endregion

namespace WinterLeaf.Engine.Containers
{

    #endregion

    public class TransformFIConverter : TypeConverter
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
                return new TransformF(value as string);

            return null;
        }
    }

    /// <summary>
    /// The CSharp equiv to the TransformF torque class.
    /// </summary>
    [TypeConverter(typeof (TransformFIConverter))]
    public sealed class TransformF : IConvertible
    {
        /// <summary>
        /// 
        /// </summary>
        private const double POINT_EPSILON = (1e-4);

        /// <summary>
        /// 
        /// </summary>
        //private Point3F mOrientation;
        private float _mOrientation_x;

        private float _mOrientation_y;
        private float _mOrientation_z;

        /// <summary>
        /// 
        /// </summary>
        //private Point3F mPosition;
        private float _mPosition_x;

        private float _mPosition_y;
        private float _mPosition_z;

        /// <summary>
        /// 
        /// </summary>
        private float mAngle;

        /// <summary>
        /// 
        /// </summary>
        public TransformF()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transform"></param>
        public TransformF(string transform)
        {
            if (transform.Trim() == "")
                return;
            string[] parts = transform.Split(' ');
            if (parts.GetUpperBound(0) >= 2)
                {
                mPositionX = parts[0].AsFloat();
                mPositionY = parts[1].AsFloat();
                mPositionZ = parts[2].AsFloat();
                }
            //else
            //    {

            //    //throw new Exception("NOT ENOUGH DATA TO INITIALIZE");
            //    }

            if (parts.GetUpperBound(0) <= 6)
                return;

            mOrientationX = parts[3].AsFloat();
            mOrientationY = parts[4].AsFloat();
            mOrientationZ = parts[5].AsFloat();

            mAngle = parts[6].AsFloat();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public TransformF(float x, float y, float z)
        {
            mPositionX = x;
            mPositionY = y;
            mPositionZ = z;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="axis_x"></param>
        /// <param name="axis_y"></param>
        /// <param name="axis_z"></param>
        /// <param name="angle"></param>
        public TransformF(float x, float y, float z, float axis_x, float axis_y, float axis_z, float angle)
        {
            mPositionX = x;
            mPositionY = y;
            mPositionZ = z;
            mOrientationX = axis_x;
            mOrientationY = axis_y;
            mOrientationZ = axis_z;
            mAngle = angle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public TransformF(Point3F p)
        {
            mPositionX = p.x;
            mPositionY = p.y;
            mPositionZ = p.z;
            mAngle = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public float MAngle
        {
            get { return mAngle; }
            set
            {
                mAngle = value;
                //  Notify(AsString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mOrientationX
        {
            get { return _mOrientation_x; }
            set { _mOrientation_x = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mOrientationY
        {
            get { return _mOrientation_y; }
            set { _mOrientation_y = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mOrientationZ
        {
            get { return _mOrientation_z; }
            set { _mOrientation_z = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mPositionX
        {
            get { return _mPosition_x; }
            set { _mPosition_x = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mPositionY
        {
            get { return _mPosition_y; }
            set { _mPosition_y = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float mPositionZ
        {
            get { return _mPosition_z; }
            set { _mPosition_z = value; }
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

        public static bool operator ==(TransformF x, TransformF _test)
        {
            if (((object) _test) == null && ((object) x == null))
                return true;

            if (((object) _test) == null)
                return false;

            if (((object) x) == null)
                return false;

            return (x._mOrientation_x == _test._mOrientation_x) && (x._mOrientation_y == _test._mOrientation_y) && (x._mOrientation_z == _test._mOrientation_z) && (x._mPosition_x == _test._mPosition_x) && (x._mPosition_y == _test._mPosition_y) && (x._mPosition_z == _test._mPosition_z) && (x.mAngle == _test.mAngle);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(TransformF x, TransformF _test)
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
        /// Returns the Position part of the transform
        /// </summary>
        /// <returns></returns>
        public Point3F GetPosition()
        {
            return new Point3F(_mPosition_x, _mPosition_y, _mPosition_z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Point3F GetOrientation()
        {
            return new Point3F(_mOrientation_x, _mOrientation_y, _mOrientation_z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return AsString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", mPositionX.AsString(), mPositionY.AsString(), mPositionZ.AsString(), mOrientationX.AsString(), mOrientationY.AsString(), mOrientationZ.AsString(), mAngle.AsString());
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
        /// <param name="_testo"></param>
        /// <returns></returns>
        public override bool Equals(object _testo)
        {
            TransformF _test = (TransformF) _testo;
            return (mPositionX == _test.mPositionX) && (mPositionY == _test.mPositionY) && (mPositionZ == _test.mPositionZ);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_add"></param>
        /// <returns></returns>
        public static TransformF operator +(TransformF x, TransformF _add)
        {
            return new TransformF(x.mPositionX + _add.mPositionX, x.mPositionY + _add.mPositionY, x.mPositionZ + _add.mPositionZ);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_rSub"></param>
        /// <returns></returns>
        public static TransformF operator -(TransformF x, TransformF _rSub)
        {
            return new TransformF(x.mPositionX - _rSub.mPositionX, x.mPositionY - _rSub.mPositionY, x.mPositionZ - _rSub.mPositionZ);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_mul"></param>
        /// <returns></returns>
        public static TransformF operator *(TransformF x, float _mul)
        {
            return new TransformF(x.mPositionX*_mul, x.mPositionY*_mul, x.mPositionZ*_mul);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_div"></param>
        /// <returns></returns>
        public static TransformF operator /(TransformF x, float _div)
        {
            if (_div == 0.0)
                throw new Exception("Error, Divide by Zero");
            float inv = 1.0f/_div;
            return new TransformF(x.mPositionX*inv, x.mPositionY*inv, x.mPositionZ*inv);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static TransformF operator -(TransformF x)
        {
            return new TransformF(-x.mPositionX, -x.mPositionY, -x.mPositionZ);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TransformF copy()
        {
            TransformF t = new TransformF(mPositionX, mPositionY, mPositionZ, mOrientationX, mOrientationY, mOrientationZ, MAngle);

            return t;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TransformF normalizeSafe()
        {
            double vmag = magnitudeSafe();

            if (vmag > POINT_EPSILON)
                {
                mPositionX *= (float) (1.0/vmag);
                mPositionY *= (float) (1.0/vmag);
                mPositionZ *= (float) (1.0/vmag);
                }
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double magnitudeSafe()
        {
            return isZero() ? 0.0f : len();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isZero()
        {
            return ((mPositionX*mPositionX) <= POINT_EPSILON) && ((mPositionY*mPositionY) <= POINT_EPSILON) && ((mPositionZ*mPositionZ) <= POINT_EPSILON);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double len()
        {
            return Math.Sqrt(mPositionX*mPositionX + mPositionY*mPositionY + mPositionZ*mPositionZ);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public TransformF vectorScale(float scalar)
        {
            return this*scalar;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double getMin(double a, double b)
        {
            return a > b ? b : a;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double getMax(double a, double b)
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
        public static double mRadToDeg(double r)
        {
            return ((r*180.0)/Math.PI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public static TransformF vectorScale(TransformF point, float scalar)
        {
            return point*scalar;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static float vectorDot(TransformF p1, Point3F p2)
        {
            return (p1.mPositionX*p2.x + p1.mPositionY*p2.y + p1.mPositionZ*p2.z);
        }
    }

    public static partial class Extension
    {
        /// <summary>
        /// Returns string as TransformF
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TransformF AsTransformF(this string value)
        {
            return new TransformF(value);
        }
    }
}