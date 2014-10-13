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

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
{
    [TypeConverter(typeof (TypeConverterGeneric<MessageHud>))]
    public class MessageHud : GuiControl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        [ConsoleInteraction(true)]
        public void open()
        {
            const int offset = 6;

            if (isVisible())
                return;

            string text = this[this + ".isTeamMsg"].AsBool() ? "TEAM:" : "GLOBAL:";

            GuiTextCtrl MessageHud_Text = "MessageHud_Text";

            MessageHud_Text.setValue(text);

            GuiBitmapBorderCtrl outerChatHud = "outerChatHud";
            GuiBitmapBorderCtrl MessageHud_Frame = "MessageHud_Frame";

            Point2I windowPos = new Point2I(0, (outerChatHud.position.y + outerChatHud.extent.y + 1));

            Point2I windowExt = new Point2I(outerChatHud.extent.x, MessageHud_Frame.extent.y);

            int textExtent = MessageHud_Text.extent.x + 14;

            int ctrlExtent = MessageHud_Frame.extent.x;

            ((GuiCanvas) "Canvas").pushDialog(this);

            MessageHud_Frame.position = windowPos;

            MessageHud_Frame.extent = windowExt;

            GuiTextEditCtrl MessageHud_Edit = "MessageHud_Edit";

            MessageHud_Edit.position = new Point2I(textExtent + offset, MessageHud_Edit.position.y);

            MessageHud_Edit.extent = new Point2I(ctrlExtent - textExtent - (2*offset), MessageHud_Edit.extent.y);

            setVisible(true);

            MessageHud_Edit.makeFirstResponder(true);
        }

        [ConsoleInteraction(true)]
        public void close()
        {
            if (!isVisible())
                return;
            ((GuiCanvas) "Canvas").popDialog(this);
            setVisible(false);
            ((GuiTextEditCtrl) "MessageHud_Edit").setValue("");
        }

        [ConsoleInteraction(true)]
        public void toggleState()
        {
            if (this.isVisible())
                close();
            else
                open();
        }

        [ConsoleInteraction(true)]
        public static void toggleMessageHud(bool make)
        {
            if (make)
                {
                MessageHud MessageHud = "MessageHud";
                MessageHud["isTeamMsg"] = false.AsString();
                MessageHud.toggleState();
                }
        }

        [ConsoleInteraction(true)]
        public static void teamMessageHud(bool make)
        {
            if (make)
                {
                MessageHud MessageHud = "MessageHud";
                MessageHud["isTeamMsg"] = true.AsString();
                MessageHud.toggleState();
                }
        }

        public static void initialize()
        {
            #region GuiControl (MessageHud)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiControl", "MessageHud", typeof (MessageHud));
            oc_Newobject5["profile"] = "GuiDefaultProfile";
            oc_Newobject5["horizSizing"] = "width";
            oc_Newobject5["vertSizing"] = "height";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["extent"] = "640 480";
            oc_Newobject5["minExtent"] = "8 8";
            oc_Newobject5["visible"] = "0";
            oc_Newobject5["noCursor"] = new Creator.StringNoQuote("true");

            #region GuiBitmapBorderCtrl (MessageHud_Frame)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapBorderCtrl", "MessageHud_Frame");
            oc_Newobject4["profile"] = "ChatHudBorderProfile";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "120 375";
            oc_Newobject4["extent"] = "400 40";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["visible"] = "1";

            #region GuiBitmapCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject1["profile"] = "GuiDefaultProfile";
            oc_Newobject1["horizSizing"] = "width";
            oc_Newobject1["vertSizing"] = "height";
            oc_Newobject1["position"] = "8 8";
            oc_Newobject1["extent"] = "384 24";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["bitmap"] = "core/art/gui/images/hudfill.png";
            oc_Newobject1["wrap"] = "0";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiTextCtrl (MessageHud_Text)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "MessageHud_Text");
            oc_Newobject2["profile"] = "ChatHudTextProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "14 12";
            oc_Newobject2["extent"] = "10 22";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "1";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiTextEditCtrl (MessageHud_Edit)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextEditCtrl", "MessageHud_Edit", typeof (MessageHud_Edit));
            oc_Newobject3["profile"] = "ChatHudEditProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "0 13";
            oc_Newobject3["extent"] = "10 22";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["altCommand"] = "$ThisControl.eval();";
            oc_Newobject3["escapeCommand"] = "MessageHud_Edit.onEscape();";
            oc_Newobject3["historySize"] = "5";
            oc_Newobject3["maxLength"] = "120";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject5.Create();

            #region GuiControl (MainChatHud)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "MainChatHud", typeof (MainChatHud));
            oc_Newobject12["profile"] = "GuiModelessDialogProfile";
            oc_Newobject12["horizSizing"] = "width";
            oc_Newobject12["vertSizing"] = "height";
            oc_Newobject12["position"] = "0 0";
            oc_Newobject12["extent"] = "640 480";
            oc_Newobject12["minExtent"] = "8 8";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["helpTag"] = "0";
            oc_Newobject12["noCursor"] = "1";

            #region GuiControl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiControl", "");
            oc_Newobject11["profile"] = "GuiModelessDialogProfile";
            oc_Newobject11["horizSizing"] = "relative";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["position"] = "0 0";
            oc_Newobject11["extent"] = "400 300";
            oc_Newobject11["minExtent"] = "8 8";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["helpTag"] = "0";

            #region GuiBitmapBorderCtrl (OuterChatHud)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapBorderCtrl", "OuterChatHud");
            oc_Newobject10["profile"] = "ChatHudBorderProfile";
            oc_Newobject10["horizSizing"] = "width";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["position"] = "0 0";
            oc_Newobject10["extent"] = "272 88";
            oc_Newobject10["minExtent"] = "8 8";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["helpTag"] = "0";
            oc_Newobject10["useVariable"] = "0";
            oc_Newobject10["tile"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject6["profile"] = "GuiDefaultProfile";
            oc_Newobject6["horizSizing"] = "width";
            oc_Newobject6["vertSizing"] = "height";
            oc_Newobject6["position"] = "8 8";
            oc_Newobject6["extent"] = "256 72";
            oc_Newobject6["minExtent"] = "8 8";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["helpTag"] = "0";
            oc_Newobject6["bitmap"] = "core/art/gui/images/hudfill.png";
            oc_Newobject6["wrap"] = "0";

            #endregion

            oc_Newobject10["#Newobject6"] = oc_Newobject6;

            #region GuiButtonCtrl (chatPageDown)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiButtonCtrl", "chatPageDown");
            oc_Newobject7["profile"] = "GuiButtonProfile";
            oc_Newobject7["horizSizing"] = "left";
            oc_Newobject7["vertSizing"] = "top";
            oc_Newobject7["position"] = "220 58";
            oc_Newobject7["extent"] = "36 14";
            oc_Newobject7["minExtent"] = "8 8";
            oc_Newobject7["visible"] = "0";
            oc_Newobject7["helpTag"] = "0";
            oc_Newobject7["text"] = "Dwn";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "PushButton";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiScrollCtrl (ChatScrollHud)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiScrollCtrl", "ChatScrollHud");
            oc_Newobject9["profile"] = "ChatHudScrollProfile";
            oc_Newobject9["horizSizing"] = "width";
            oc_Newobject9["vertSizing"] = "height";
            oc_Newobject9["position"] = "8 8";
            oc_Newobject9["extent"] = "256 72";
            oc_Newobject9["minExtent"] = "8 8";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["helpTag"] = "0";
            oc_Newobject9["willFirstRespond"] = "1";
            oc_Newobject9["hScrollBar"] = "alwaysOff";
            oc_Newobject9["vScrollBar"] = "alwaysOff";
            oc_Newobject9["lockHorizScroll"] = "true";
            oc_Newobject9["lockVertScroll"] = "false";
            oc_Newobject9["constantThumbHeight"] = "0";
            oc_Newobject9["childMargin"] = "0 0";

            #region GuiMessageVectorCtrl (ChatHud)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiMessageVectorCtrl", "ChatHud", typeof (chatHud));
            oc_Newobject8["profile"] = "ChatHudMessageProfile";
            oc_Newobject8["horizSizing"] = "width";
            oc_Newobject8["vertSizing"] = "height";
            oc_Newobject8["position"] = "1 1";
            oc_Newobject8["extent"] = "252 16";
            oc_Newobject8["minExtent"] = "8 8";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["helpTag"] = "0";
            oc_Newobject8["lineSpacing"] = "0";
            oc_Newobject8["lineContinuedIndex"] = "10";
            oc_Newobject8["allowedMatches[0]"] = "http";
            oc_Newobject8["allowedMatches[1]"] = "tgeserver";
            oc_Newobject8["matchColor"] = "0 0 255 255";
            oc_Newobject8["maxColorIndex"] = "5";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject12.Create();
        }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MessageHud ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
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
        public static bool operator !=(MessageHud ts, string simobjectid)
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
        public static implicit operator string(MessageHud ts)
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
        public static implicit operator MessageHud(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (MessageHud) Omni.self.getSimObject(simobjectid, typeof (MessageHud));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MessageHud ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MessageHud(int simobjectid)
        {
            return (MessageHud) Omni.self.getSimObject((uint) simobjectid, typeof (MessageHud));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MessageHud ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MessageHud(uint simobjectid)
        {
            return (MessageHud) Omni.self.getSimObject(simobjectid, typeof (MessageHud));
        }

        #endregion
    }
}