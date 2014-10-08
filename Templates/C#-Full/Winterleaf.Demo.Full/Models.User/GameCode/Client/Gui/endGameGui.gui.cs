using WinterLeaf.Engine.Classes;
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