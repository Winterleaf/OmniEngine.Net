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
using System.Text;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Classes.View.Creators
{
    /// <summary>
    /// This is a helper class to attempt to clean up the code
    /// when creating a object inside of torque.
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<ObjectCreator>))]
    public sealed class ObjectCreator : Creator, IConvertible
    {
        /// <summary>
        ///   Creates an object to template a torquescript class with.
        /// </summary>
        /// <param name="className"> The name of the object type </param>
        /// <param name="instanceName"> The name of this instance of the object </param>
        /// <param name="model">The C# proxy class to use for this singleton(Optional)</param>
        public ObjectCreator(string className, string instanceName, Type model)
        {
            mClassName = className;
            mInstanceName = instanceName;

            mModel = model != null ? model.FullName.ToLower() : string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
        }

        public ObjectCreator(string className, string instanceName, String model)
        {
            mClassName = className;
            mInstanceName = instanceName;

            mModel = model != null ? model.ToLower() : string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
        }

        public ObjectCreator(string className, string instanceName)
        {
            mClassName = className;
            mInstanceName = instanceName;

            mModel = string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
        }

        public ObjectCreator(string className)
        {
            mClassName = className;
            mInstanceName = string.Empty;

            mModel = string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
        }

        /// <summary>
        ///   This will return the TorqueScript code that will be executed when Create is called.
        /// </summary>
        /// <returns> </returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(" new ");
            result.Append(mClassName);
            result.Append("(");
            result.Append(mInstanceName);
            result.Append(base.ToString());
            return (result.ToString());
        }

        /// <summary>
        ///   Passes the ToString() TorqueScript to the Eval statement capturing the id of the object created
        /// </summary>
        /// <returns> </returns>
        public UInt32 Create()
        {
            UInt32 r;
            string id = Omni.self.Evaluate("%tempvar = " + ToString() + " return %tempvar;", true);
            return UInt32.TryParse(id, out r) ? r : 0;
        }

    }
}