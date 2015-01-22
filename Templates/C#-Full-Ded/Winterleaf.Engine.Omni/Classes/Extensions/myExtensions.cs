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

using System;
using System.Globalization;
using System.Linq;

namespace WinterLeaf.Engine.Classes.Extensions
{
    /// <summary>
    ///   This class is used to extend primary data types for ease with the Torque Engine.
    /// </summary>
    public static class MyExtensions
    {
        /// <summary>
        /// Checks if the string is an object in the engine.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool isObject(this string value)
        {
            string tvalue = value.Trim();
            if (tvalue == string.Empty)
                return false;

            if (tvalue.Contains(" "))
                return false;

            return (ModelBase) value != null && ((ModelBase) value).isObject();
        }

        /// <summary>
        /// If it is a simobject, it will call delete.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void delete(this string value)
        {
            string tvalue = value.Trim();
            if (tvalue == string.Empty)
                return;

            if (tvalue.Contains(" "))
                return;

            if (value.isObject())
                ((ModelBase) value).delete();
        }

        /// <summary>
        /// If it is a simobject, it will call delete.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string getName(this string value)
        {
            if (value.Trim() == string.Empty)
                return string.Empty;

            if (value.Trim().Contains(" "))
                return string.Empty;

            if (value.isObject())
                ((ModelBase) value).getName();

            return string.Empty;
        }

        /// <summary>
        /// If it is a simobject, it will getname.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int getID(this string value)
        {
            if (value.Trim() == string.Empty)
                return -1;

            if (value.Trim().Contains(" "))
                return -1;

            if (value.isObject())
                return ((ModelBase) value).GetID().AsInt();

            return -1;
        }

        /// <summary>
        /// Returns the simobject id as a uint
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static uint getUID(this string value)
        {
            if (value.Trim() == string.Empty)
                return 0;

            if (value.Trim().Contains(" "))
                return 0;

            if (value.isObject())
                ((ModelBase) value).GetID();

            return 0;
        }

        /// <summary>
        /// Calls a member function on the simobject
        /// </summary>
        /// <param name="value"></param>
        /// <param name="function"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static string call(this string value, string function, string[] parameters)
        {
            return value.isObject() ? ((ModelBase) value).call(function, parameters) : "";
        }

        /// <summary>
        /// Calls a member function on a simobject.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static string call(this string value, string function)
        {
            return value.isObject() ? ((ModelBase) value).call(function, new string[] {}) : "";
        }

        /// <summary>
        /// Converts string to a sByte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static sbyte AsSbyte(this string value)
        {
            if (value.Trim().ToLower() == "true")
                return 1;
            if (value.Trim().ToLower() == "false")
                return 0;
            if (value.Trim() == string.Empty)
                value = "0";

            sbyte s;
            if (sbyte.TryParse(value, out s))
                return s;
            throw new Exception("Failed to parse sbyte.");
        }

        /// <summary>
        ///   Converts a string to a string, done for consistency.
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> </returns>
        public static string AsString(this string value)
        {
            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ModelBase AsTsObject(this string value)
        {
            ModelBase t = value;
            return t;
            //return new tsObject(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ModelBase AsTsObject(this Int32 value)
        {
            ModelBase t = value;
            return t;
            //return new tsObject(value);
        }

        /// <summary>
        ///   Returns the int as a string
        /// </summary>
        /// <param name="value"> int </param>
        /// <returns> </returns>
        public static string AsString(this Int32 value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts sByte to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsString(this sbyte value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///   Returns the uint as a string
        /// </summary>
        /// <param name="value"> uint </param>
        /// <returns> </returns>
        public static string AsString(this UInt32 value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///   Returns the double as a string
        /// </summary>
        /// <param name="value"> double </param>
        /// <returns> </returns>
        public static string AsString(this double value)
        {
            return value.ToString("0.000000", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Returns the long as a string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsString(this Int64 value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Returns the long as a string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsString(this UInt64 value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsString(this Int16 value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///   Returns the float as a string
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> float </returns>
        public static string AsString(this UInt16 value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///   Returns the float as a string
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> float </returns>
        public static string AsString(this float value)
        {
            return ((double) value).ToString("0.000", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a bool to a string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsString(this bool value)
        {
            return value ? "1" : "0";
        }

        /// <summary>
        ///   if the value is >=1 returns true.
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> float </returns>
        public static bool AsBool(this float value)
        {
            return value >= 1;
        }

        /// <summary>
        ///   if the value is >=1 returns true.
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> double </returns>
        public static bool AsBool(this double value)
        {
            return value >= 1;
        }

        /// <summary>
        ///   if the value is >=1 returns true.
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> int </returns>
        public static bool AsBool(this int value)
        {
            return value >= 1;
        }

        /// <summary>
        ///   if the value is >=1 returns true.
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> uint </returns>
        public static bool AsBool(this uint value)
        {
            return value >= 1;
        }

        /// <summary>
        ///   if the string is numerical and the value is >1 it returns true If the string = "true" it returns true.
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> string </returns>
        public static bool AsBool(this string value)
        {
            if (value.Trim() == string.Empty)
                return false;
            if (value == "1")
                return true;
            if (value.ToLower() == "true")
                return true;

            double r;
            if (double.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out r))
                {
                if (r > 0)
                    return true;
                }
            return false;
        }

        /// <summary>
        ///   returns the string as a int.
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> int </returns>
        public static int AsInt(this string value)
        {
            if (value.Trim() == string.Empty)
                return 0;
            if (value.ToLower() == "false")
                return 0;
            if (value.ToLower() == "true")
                return 1;
            if (!IsNumeric(value))
                {
                try
                    {
                    return (int) ((ModelBase) value)._iID;
                    }
                catch
                    {
                    }
                }
            int i;
            //if (int.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out i))
            if (int.TryParse(value, out i))
                return i;

            double d;
            if (double.TryParse(value, out d))
                return (int) d;

            throw new Exception("Failed to cast string to int");
        }

        /// <summary>
        ///   returns the string as a int.
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> int </returns>
        public static uint AsUint(this string value)
        {
            if (value.Trim() == string.Empty)
                return 0;
            if (value.ToLower() == "false")
                return 0;
            if (value.ToLower() == "true")
                return 1;
            if (!IsNumeric(value))
                {
                try
                    {
                    return ((ModelBase) value)._iID;
                    }
                catch
                    {
                    }
                }
            uint i;
            //if (int.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out i))
            if (uint.TryParse(value, out i))
                return i;

            double d;
            if (double.TryParse(value, out d))
                return (uint) d;

            throw new Exception("Failed to cast string to int");
        }

        /// <summary>
        /// Converts a string of one character to a byte.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Byte AsByte(this string value)
        {
            if (value.Trim() == string.Empty)
                return 0;
            Byte i;
            return Byte.TryParse(value, out i) ? i : (byte) 0;
        }

        /// <summary>
        ///   Returns the string as a float.
        /// </summary>
        /// <param name="value"> float </param>
        /// <returns> </returns>
        public static float AsFloat(this string value)
        {
            if (value.Trim() == string.Empty)
                return 0;
            double v;
            if (double.TryParse(value, NumberStyles.Number | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out v))
                return (float) v;
            float f;
            if (float.TryParse(value, NumberStyles.Number | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out f))
                return f;
            throw new Exception("Failed to cast string to float");
        }

        /// <summary>
        ///   Returns the string as a double.
        /// </summary>
        /// <param name="value"> double </param>
        /// <returns> </returns>
        public static double AsDouble(this string value)
        {
            if (value.Trim() == string.Empty)
                return 0;
            double v;
            if (double.TryParse(value, NumberStyles.Number | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out v))
                return v;
            float f;
            if (float.TryParse(value, NumberStyles.Number | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out f))
                {
                v = f;
                return v;
                }
            throw new Exception("Failed to cast string to float");
        }

        /// <summary>
        ///   Converts a string to a long.
        /// </summary>
        /// <param name="value"> </param>
        /// <returns> </returns>
        public static long AsLong(this string value)
        {
            if (value.Trim() == string.Empty)
                return 0;
            long v;
            if (long.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out v))
                return v;
            throw new Exception("Failed to cast String to long.");
        }

        /// <summary>
        ///   Checks the string to ensure it is a valid numeric string.
        /// </summary>
        /// <param name="numberString"> </param>
        /// <returns> </returns>
        public static bool IsNumeric(this string numberString)
        {
            foreach (byte c in numberString.ToArray())
                {
                if ((((c < 48) || (c > 57)) && (c != 46) && (c != 44) && c != '-' && c != '+'))
                    return false;
                }
            return true;
        }
    }
}