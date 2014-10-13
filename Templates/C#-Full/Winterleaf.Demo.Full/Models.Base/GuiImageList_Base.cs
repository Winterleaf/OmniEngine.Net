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

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiImageList_Base>))]
    public partial class GuiImageList_Base : SimObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiImageList_Base ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(GuiImageList_Base ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(GuiImageList_Base ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiImageList_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiImageList_Base) Omni.self.getSimObject(simobjectid, typeof (GuiImageList_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiImageList_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiImageList_Base(int simobjectid)
        {
            return (GuiImageList) Omni.self.getSimObject((uint) simobjectid, typeof (GuiImageList_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiImageList_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiImageList_Base(uint simobjectid)
        {
            return (GuiImageList_Base) Omni.self.getSimObject(simobjectid, typeof (GuiImageList_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Clears the imagelist   @tsexample   // Inform the GuiImageList control to clear itself.   %isFinished = %thisGuiImageList.clear();   @endtsexample   @return Returns true when finished.   @see SimObject)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool clear()
        {
            return m_ts.fnGuiImageList_clear(_ID);
        }

        /// <summary>
        /// @brief Gets the number of images in the list.   @tsexample   // Request the number of images from the GuiImageList control.   %imageCount = %thisGuiImageList.count();   @endtsexample   @return Number of images in the control.   @see SimObject)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int count()
        {
            return m_ts.fnGuiImageList_count(_ID);
        }

        /// <summary>
        /// @brief Get a path to the texture at the specified index.   @param index Index of the image in the list.   @tsexample   // Define the image index/n   %index = \"5\";   // Request the image path location from the control.   %imagePath = %thisGuiImageList.getImage(%index);   @endtsexample   @return File path to the image map for the specified index.   @see SimObject)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getImage(int index)
        {
            return m_ts.fnGuiImageList_getImage(_ID, index);
        }

        /// <summary>
        /// @brief Retrieves the imageindex of a specified texture in the list.   @param imagePath Imagemap including filepath of image to search for   @tsexample   // Define the imagemap to search for   %imagePath = \"./game/client/data/images/thisImage\";   // Request the index entry for the defined imagemap   %imageIndex = %thisGuiImageList.getIndex(%imagePath);   @endtsexample   @return Index of the imagemap matching the defined image path.   @see SimObject)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getIndex(string imagePath)
        {
            return m_ts.fnGuiImageList_getIndex(_ID, imagePath);
        }

        /// <summary>
        /// @brief Insert an image into imagelist- returns the image index or -1 for failure.   @param imagePath Imagemap, with path, to add to the list.   @tsexample   // Define the imagemap to add to the list   %imagePath = \"./game/client/data/images/thisImage\";   // Request the GuiImageList control to add the defined image to its list.   %imageIndex = %thisGuiImageList.insert(%imagePath);   @endtsexample   @return The index of the newly inserted imagemap, or -1 if the insertion failed.   @see SimObject)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int insert(string imagePath)
        {
            return m_ts.fnGuiImageList_insert(_ID, imagePath);
        }

        /// <summary>
        /// @brief Removes an image from the list by index.   @param index Image index to remove.   @tsexample   // Define the image index.   %imageIndex = \"4\";   // Inform the GuiImageList control to remove the image at the defined index.   %wasSuccessful = %thisGuiImageList.remove(%imageIndex);   @endtsexample   @return True if the operation was successful, false if it was not.   @see SimObject)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool remove(int index)
        {
            return m_ts.fnGuiImageList_remove(_ID, index);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public GuiImageList_Base()
        {
        }
    }
}