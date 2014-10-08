using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;


namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.CenterPrint
    {
    public class centerPrint
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            omni.iGlobal["$centerPrintActive"] = 0;
            omni.iGlobal["$bottomPrintActive"] = 0;
            omni.iGlobal["$CenterPrintSizes[1]"] = 20;
            omni.iGlobal["$CenterPrintSizes[2]"] = 36;
            omni.iGlobal["$CenterPrintSizes[3]"] = 56;
            }

        [ConsoleInteraction(true)]
        public static void clientCmdCenterPrint(string message, string time, string size)
            {
            GuiBitmapCtrl centerPrintDlg = "centerPrintDlg";

            if (omni.bGlobal["$centerPrintActive"])
                {
                if (centerPrintDlg["removePrint"] != "")
                    omni.Util.cancel(centerPrintDlg["removePrint"].AsInt());
                }
            else
                {
                centerPrintDlg["visible"] = "1";
                omni.iGlobal["$centerPrintActive"] = 1;
                }

            ((GuiMLTextCtrl) "CenterPrintText").setText("<just:center>" + message);
            centerPrintDlg.extent.y = omni.iGlobal["$CenterPrintSizes[" + size + "]"];
            if (time.AsInt() > 0)
                centerPrintDlg["removePrint"] =
                    omni.Util._schedule((time.AsInt()*1000).AsString(), "0", "clientCmdClearCenterPrint").AsString();
            }

        [ConsoleInteraction(true)]
        public static void clientCmdBottomPrint(string message, string time, string size)
            {
            GuiBitmapCtrl bottomPrintDlg = "bottomPrintDlg";

            if (omni.bGlobal["$bottomPrintActive"])
                {
                if (bottomPrintDlg["removePrint"] != "")
                    omni.Util.cancel(bottomPrintDlg["removePrint"].AsInt());
                }
            else
                {
                bottomPrintDlg.setVisible(true);
                omni.iGlobal["$bottomPrintActive"] = 1;
                }
            ((GuiMLTextCtrl) "bottomPrintText").setText("<just:center>" + message);
            bottomPrintDlg.extent.y = omni.iGlobal["$CenterPrintSizes[" + size + "]"];
            if (time.AsInt() > 0)
                bottomPrintDlg["removePrint"] =
                    omni.Util._schedule((time.AsInt()*1000).AsString(), "0", "clientCmdClearbottomPrint").AsString();
            }

        //Bottom and Center PrintText resize is controled through proxy object printText.cs


        [ConsoleInteraction(true)]
        public static void clientCmdClearCenterPrint()
            {
            omni.iGlobal["$centerPrintActive"] = 0;
            GuiBitmapCtrl CenterPrintDlg = "CenterPrintDlg";
            CenterPrintDlg.visible = false;
            CenterPrintDlg["removePrint"] = "";
            }

        [ConsoleInteraction(true)]
        public static void clientCmdClearBottomPrint()
            {
            omni.iGlobal["$bottomPrintActive"] = 0;
            GuiBitmapCtrl BottomPrintDlg = "BottomPrintDlg";
            BottomPrintDlg.visible = false;
            BottomPrintDlg["removePrint"] = "";
            }
        }
    }