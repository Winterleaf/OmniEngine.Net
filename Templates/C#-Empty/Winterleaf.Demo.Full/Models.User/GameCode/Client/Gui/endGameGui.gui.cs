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

using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
{
    public class endGameGui
    {
        public static void initialize()
        {
            #region GuiChunkedBitmapCtrl (EndGameGui)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiChunkedBitmapCtrl", "EndGameGui");
            oc_Newobject5["profile"] = "GuiContentProfile";
            oc_Newobject5["horizSizing"] = "width";
            oc_Newobject5["vertSizing"] = "height";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["extent"] = "640 480";
            oc_Newobject5["minExtent"] = "8 8";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["helpTag"] = "0";
            oc_Newobject5["bitmap"] = "art/gui/background";
            oc_Newobject5["useVariable"] = "0";
            oc_Newobject5["tile"] = "0";

            #region GuiControl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "");
            oc_Newobject4["profile"] = "GuiWindowProfile";
            oc_Newobject4["horizSizing"] = "center";
            oc_Newobject4["vertSizing"] = "center";
            oc_Newobject4["position"] = "92 86";
            oc_Newobject4["extent"] = "455 308";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["helpTag"] = "0";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "GuiMediumTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "101 15";
            oc_Newobject1["extent"] = "251 28";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["text"] = "Game Over - Final Scores:";
            oc_Newobject1["maxLength"] = "255";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiScrollCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject3["profile"] = "GuiScrollProfile";
            oc_Newobject3["horizSizing"] = "width";
            oc_Newobject3["vertSizing"] = "height";
            oc_Newobject3["position"] = "5 51";
            oc_Newobject3["extent"] = "444 251";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["willFirstRespond"] = "1";
            oc_Newobject3["hScrollBar"] = "alwaysOff";
            oc_Newobject3["vScrollBar"] = "dynamic";
            oc_Newobject3["lockHorizScroll"] = "true";
            oc_Newobject3["lockVertScroll"] = "false";
            oc_Newobject3["constantThumbHeight"] = "0";
            oc_Newobject3["childMargin"] = "0 0";
            oc_Newobject3["defaultLineHeight"] = "15";

            #region GuiTextListCtrl (EndGameGuiList)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextListCtrl", "EndGameGuiList");
            oc_Newobject2["profile"] = "GuiTextProfile";
            oc_Newobject2["horizSizing"] = "width";
            oc_Newobject2["vertSizing"] = "height";
            oc_Newobject2["position"] = "2 2";
            oc_Newobject2["extent"] = "440 16";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["enumerate"] = "0";
            oc_Newobject2["resizeCell"] = "1";
            oc_Newobject2["columns"] = "0 256";
            oc_Newobject2["fitParentWidth"] = "1";
            oc_Newobject2["clipColumnText"] = "0";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject5.Create();
        }
    }
}