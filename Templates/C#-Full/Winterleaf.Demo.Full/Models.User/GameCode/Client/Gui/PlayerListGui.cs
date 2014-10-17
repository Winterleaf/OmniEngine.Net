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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
{
    [TypeConverter(typeof (TypeConverterGeneric<PlayerListGui>))]
    internal class PlayerListGui : GuiControl
    {

        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public static void initializeGui()
        {
            #region GuiControl (PlayerListGui)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "PlayerListGui", typeof (PlayerListGui));
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "GuiModelessDialogProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "0 0";
            oc_Newobject8["Extent"] = "1024 768";
            oc_Newobject8["MinExtent"] = "8 8";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["noCursor"] = new Creator.StringNoQuote("true");

            #region GuiBitmapBorderCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ChatHudBorderProfile";
            oc_Newobject7["HorizSizing"] = "center";
            oc_Newobject7["VertSizing"] = "center";
            oc_Newobject7["Position"] = "362 263";
            oc_Newobject7["Extent"] = "299 242";
            oc_Newobject7["MinExtent"] = "8 8";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";

            #region GuiBitmapCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ChatHudScrollProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "8 8";
            oc_Newobject6["Extent"] = "283 226";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["bitmap"] = "art/gui/hudfill.png";
            oc_Newobject6["wrap"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ChatHudScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["Position"] = "0 24";
            oc_Newobject2["Extent"] = "228 202";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = "true";
            oc_Newobject2["lockVertScroll"] = "false";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";
            oc_Newobject2["mouseWheelScrollSpeed"] = "-1";

            #region GuiTextListCtrl (PlayerListGuiList)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextListCtrl", "PlayerListGuiList");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "HudTextNormalProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "height";
            oc_Newobject1["Position"] = "1 1";
            oc_Newobject1["Extent"] = "226 9";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["enumerate"] = "0";
            oc_Newobject1["resizeCell"] = "1";
            oc_Newobject1["columns"] = "0 98 153 200";
            oc_Newobject1["fitParentWidth"] = "1";
            oc_Newobject1["clipColumnText"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "HudTextBoldProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "104 2";
            oc_Newobject3["Extent"] = "33 18";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["text"] = "Score";
            oc_Newobject3["maxLength"] = "255";

            #endregion

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "HudTextBoldProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "158 2";
            oc_Newobject4["Extent"] = "30 18";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["text"] = "Kills";
            oc_Newobject4["maxLength"] = "255";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "HudTextBoldProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "206 2";
            oc_Newobject5["Extent"] = "37 18";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["text"] = "Deaths";
            oc_Newobject5["maxLength"] = "255";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject8.Create();
        }

        public static void initialize()
        {
            message.addMessageCallback("MsgClientJoin", "handleClientJoin");
            message.addMessageCallback("MsgClientDrop", "handleClientDrop");
            message.addMessageCallback("MsgClientScoreChanged", "handleClientScoreChanged");
        }

        public static void HandleClientJoin(string msgType, string msgString, string ClientName, GameConnection clientID, string guid, int score, int kills, int deaths, bool isAI, bool isAdmin, bool isSuperAdmin)
        {
            ((PlayerListGui) "PlayerListGui").update(clientID, omni.Util.detag(ClientName), isSuperAdmin, isAdmin, isAI, score, kills, deaths);
        }

        public static void HandleClientDrop(string msgType, string msgString, string clientName, GameConnection clientId)
        {
            ((PlayerListGui) "PlayerListGui").remove(clientId);
        }

        public static void HandleClientScoreChanged(string msgType, string msgString, int score, int kills, int deaths, GameConnection clientId)
        {
            ((PlayerListGui) "PlayerListGui").updateScore(clientId, score, kills, deaths);

            omni.console.print(string.Format(" score:{0} kills:{1} deaths: {2}", score, kills, deaths));
        }

        [ConsoleInteraction(true)]
        public virtual void update(GameConnection clientId, string name, bool isSuperAdmin, bool isAdmin, bool isAI, int score, int kills, int deaths)
        {
            // Build the row to display.  The name can have ML control tags, including
            // color and font.  Since we're not using an ML control here, we need to
            // strip them off.

            string tag = isSuperAdmin ? "[Super]" : (isAdmin ? "[Admin]" : (isAI ? "[Bot]" : ""));

            string text = string.Format("{0} {1}\t{2}\t{3}\t{4}", Util.StripMLControlChars(name), tag, score, kills, deaths);
            // Update or add the player to the control

            GuiTextListCtrl PlayerListGuiList = "PlayerListGuiList";

            if (clientId == -1)
                PlayerListGuiList.addRow(clientId, text, -1);
            else
                PlayerListGuiList.setRowById(clientId, text);

            // Sorts by score

            PlayerListGuiList.sortNumerical(1, false);
            PlayerListGuiList.clearSelection();
        }

        [ConsoleInteraction(true)]
        public virtual void updateScore(GameConnection clientId, int score, int kills, int deaths)
        {
            GuiTextListCtrl PlayerListGuiList = "PlayerListGuiList";

            string text = PlayerListGuiList.getRowTextById(clientId);

            //Since I'm lazy and I don't feel like writing a csharp function...

            text = Util.setField(text, 1, score.AsString());
            text = Util.setField(text, 2, kills.AsString());
            text = Util.setField(text, 3, deaths.AsString());

            PlayerListGuiList.setRowById(clientId, text);

            // Sorts by score
            PlayerListGuiList.sortNumerical(1, false);
            PlayerListGuiList.clearSelection();
        }

        [ConsoleInteraction(true)]
        public virtual void remove(GameConnection clientId)
        {
            ((GuiTextListCtrl) "PlayerListGuiList").removeRowById(clientId);
        }

        [ConsoleInteraction(true)]
        public virtual void toggle()
        {
            if (isAwake())
                ((GuiCanvas) "Canvas").popDialog(this);
            else
                ((GuiCanvas) "Canvas").pushDialog(this);
        }

        [ConsoleInteraction(true)]
        public new void clear()
        {
            ((GuiTextListCtrl) "PlayerListGuiList").clear();
        }

        [ConsoleInteraction(true)]
        public virtual void zeroScores()
        {
            GuiTextListCtrl PlayerListGuiList = "PlayerListGuiList";

            for (int i = 0; i < PlayerListGuiList.rowCount(); i++)
                {
                string text = PlayerListGuiList.getRowText(i);
                text = Util.setField(text, 1, "0");
                text = Util.setField(text, 2, "0");
                text = Util.setField(text, 3, "0");
                PlayerListGuiList.setRowById(PlayerListGuiList.getRowId(i), text);
                }
            PlayerListGuiList.clearSelection();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PlayerListGui ts, string simobjectid)
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
        public static bool operator !=(PlayerListGui ts, string simobjectid)
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
        public static implicit operator string(PlayerListGui ts)
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
        public static implicit operator PlayerListGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (PlayerListGui) Omni.self.getSimObject(simobjectid, typeof (PlayerListGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(PlayerListGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PlayerListGui(int simobjectid)
        {
            return (PlayerListGui) Omni.self.getSimObject((uint) simobjectid, typeof (PlayerListGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(PlayerListGui ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PlayerListGui(uint simobjectid)
        {
            return (PlayerListGui) Omni.self.getSimObject(simobjectid, typeof (PlayerListGui));
        }

        #endregion
    }
}