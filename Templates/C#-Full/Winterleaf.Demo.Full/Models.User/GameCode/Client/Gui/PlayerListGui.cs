using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
            oc_Newobject8["noCursor"] = new ObjectCreator.StringNoQuote("true");

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


        public static void HandleClientJoin(string msgType, string msgString, string ClientName,
            GameConnection clientID, string guid, int score, int kills, int deaths, bool isAI, bool isAdmin,
            bool isSuperAdmin)
            {
            ((PlayerListGui) "PlayerListGui").update(clientID, omni.Util.detag(ClientName), isSuperAdmin, isAdmin, isAI,
                score, kills, deaths);
            }


        public static void HandleClientDrop(string msgType, string msgString, string clientName,
            GameConnection clientId)
            {
            ((PlayerListGui) "PlayerListGui").remove(clientId);
            }


        public static void HandleClientScoreChanged(string msgType, string msgString, int score, int kills, int deaths,
            GameConnection clientId)
            {
            ((PlayerListGui) "PlayerListGui").updateScore(clientId, score, kills, deaths);

            omni.console.print(string.Format(" score:{0} kills:{1} deaths: {2}", score, kills, deaths));
            }

        [ConsoleInteraction(true)]
        public virtual void update(GameConnection clientId, string name, bool isSuperAdmin, bool isAdmin, bool isAI,
            int score, int kills, int deaths)
            {
            // Build the row to display.  The name can have ML control tags, including
            // color and font.  Since we're not using an ML control here, we need to
            // strip them off.

            string tag = isSuperAdmin ? "[Super]" : (isAdmin ? "[Admin]" : (isAI ? "[Bot]" : ""));

            string text = string.Format("{0} {1}\t{2}\t{3}\t{4}", Util.StripMLControlChars(name), tag, score, kills,
                deaths);
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
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(PlayerListGui ts)
            {
            if (object.ReferenceEquals(ts, null))
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