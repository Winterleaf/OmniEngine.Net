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
using System.ComponentModel;
using System.Globalization;
using WinterLeaf.Engine.Classes.Extensions;

namespace WinterLeaf.Engine.Classes.Helpers
{
    /// <summary>
    /// Static class used for casting T3D objects to different types.
    /// </summary>
    public static class myReflections
    {
        public static T ChangeType<T>(object value)
        {
            return (T) ChangeType(value, typeof (T));
        }

        /// <summary>
        ///   The Microsoft ChangeType method doesn't always work, especially when your dealling with constructor base object types. or, when your trying to deal with enumerations. This function overrides the buggy ones Microsoft wrote with work arounds, and leaves the functioning Microsoft ones in tack.
        /// </summary>
        /// <param name="value"> The value to be converted </param>
        /// <param name="type"> The target type </param>
        /// <returns>The passed object as the target type. </returns>
        /// 
        /// 
        public static object ChangeType(object value, Type type)
        {
            if (value == null)
                return null;
            if (value.GetType() == type)
                return value;
            if (type == null)
                return value;

            if (type != typeof (float))
                return _ChangeType(value, type);

            double retval = (double) _ChangeType(value, typeof (double));

            return (float) retval;
        }

        private static object _ChangeType(object value, Type type)
        {
            if (value is string && (string) value == "(null)")
                value = "0";

            if (type == typeof (bool) && value is string)
                return ((string) value).AsBool();

            if (!type.IsPrimitive)
                {
                if (TypeDescriptor.GetConverter(type).CanConvertFrom(value.GetType()))
                    return TypeDescriptor.GetConverter(type).ConvertFrom(value);
                }

            if (type.IsEnum)
                {
                if (value is string)
                    return Enum.Parse(type, value as string, true);
                return Enum.ToObject(type, value);
                }
            if (!type.IsInterface && type.IsGenericType)
                return Activator.CreateInstance(type, new[] {ChangeType(value, type.GetGenericArguments()[0])});
            if (value is string && type == typeof (Guid))
                return new Guid(value as string);
            if (value is string && type == typeof (Version))
                return new Version(value as string);
            if (!(value is IConvertible))
                return value;
            if (!(value is string))
                return Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
            if ((value.ToString().Trim() == string.Empty) && ((type == typeof (decimal)) || (type == typeof (double)) || (type == typeof (float)) || (type == typeof (int)) || (type == typeof (long)) || (type == typeof (short)) || (type == typeof (uint)) || (type == typeof (ulong)) || (type == typeof (ushort))))
                value = "0";

            return Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
        }

        public static bool IsSameOrSubclass(this Type potentialBase, Type potentialDescendant)
        {
            return potentialDescendant.IsSubclassOf(potentialBase) || potentialDescendant == potentialBase;
        }
    }
}