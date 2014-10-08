using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui
{
    public class NavEditorConsoleDlg
    {
        public static void initialize()
        {
            ObjectCreator oc_Newobject00004;
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
            {

                #region GuiWindowCtrl (NavEditorConsoleDlg)        oc_Newobject00004
                oc_Newobject00004 = new ObjectCreator("GuiWindowCtrl", "NavEditorConsoleDlg");
                oc_Newobject00004["text"] = "Nav Console";
                oc_Newobject00004["resizeWidth"] = "1";
                oc_Newobject00004["resizeHeight"] = "1";
                oc_Newobject00004["canMove"] = "1";
                oc_Newobject00004["canClose"] = "1";
                oc_Newobject00004["canMinimize"] = "1";
                oc_Newobject00004["canMaximize"] = "1";
                oc_Newobject00004["canCollapse"] = "0";
                oc_Newobject00004["closeCommand"] = "NavEditorConsoleDlg.setVisible(false);";
                oc_Newobject00004["edgeSnap"] = "1";
                oc_Newobject00004["margin"] = "0 0 0 0";
                oc_Newobject00004["padding"] = "0 0 0 0";
                oc_Newobject00004["anchorTop"] = "1";
                oc_Newobject00004["anchorBottom"] = "0";
                oc_Newobject00004["anchorLeft"] = "1";
                oc_Newobject00004["anchorRight"] = "0";
                oc_Newobject00004["position"] = "238 170";
                oc_Newobject00004["extent"] = "320 240";
                oc_Newobject00004["minExtent"] = "8 2";
                oc_Newobject00004["horizSizing"] = "right";
                oc_Newobject00004["vertSizing"] = "bottom";
                oc_Newobject00004["profile"] = "GuiWindowProfile";
                oc_Newobject00004["visible"] = "1";
                oc_Newobject00004["active"] = "1";
                oc_Newobject00004["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject00004["hovertime"] = "1000";
                oc_Newobject00004["isContainer"] = "1";
                oc_Newobject00004["canSave"] = "1";
                oc_Newobject00004["canSaveDynamicFields"] = "1";
                if (true)
                {

                    #region GuiTextCtrl ()        oc_Newobject00001
                    oc_Newobject00001 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00001["maxLength"] = "1024";
                    oc_Newobject00001["margin"] = "0 0 0 0";
                    oc_Newobject00001["padding"] = "0 0 0 0";
                    oc_Newobject00001["anchorTop"] = "1";
                    oc_Newobject00001["anchorBottom"] = "0";
                    oc_Newobject00001["anchorLeft"] = "1";
                    oc_Newobject00001["anchorRight"] = "0";
                    oc_Newobject00001["position"] = "3 222";
                    oc_Newobject00001["extent"] = "149 13";
                    oc_Newobject00001["minExtent"] = "8 2";
                    oc_Newobject00001["horizSizing"] = "right";
                    oc_Newobject00001["vertSizing"] = "top";
                    oc_Newobject00001["profile"] = "GuiTextProfile";
                    oc_Newobject00001["visible"] = "1";
                    oc_Newobject00001["active"] = "1";
                    oc_Newobject00001["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00001["hovertime"] = "1000";
                    oc_Newobject00001["isContainer"] = "1";
                    oc_Newobject00001["internalName"] = "StatusLeft";
                    oc_Newobject00001["canSave"] = "1";
                    oc_Newobject00001["canSaveDynamicFields"] = "0";
                    #endregion

                    oc_Newobject00004["#Newobject00001"] = oc_Newobject00001;

                    #region GuiScrollCtrl ()        oc_Newobject00003
                    oc_Newobject00003 = new ObjectCreator("GuiScrollCtrl", "");
                    oc_Newobject00003["willFirstRespond"] = "1";
                    oc_Newobject00003["hScrollBar"] = "dynamic";
                    oc_Newobject00003["vScrollBar"] = "dynamic";
                    oc_Newobject00003["lockHorizScroll"] = "1";
                    oc_Newobject00003["lockVertScroll"] = "0";
                    oc_Newobject00003["constantThumbHeight"] = "0";
                    oc_Newobject00003["childMargin"] = "0 0";
                    oc_Newobject00003["mouseWheelScrollSpeed"] = "-1";
                    oc_Newobject00003["margin"] = "-14 41 3 3";
                    oc_Newobject00003["padding"] = "0 0 0 0";
                    oc_Newobject00003["anchorTop"] = "0";
                    oc_Newobject00003["anchorBottom"] = "0";
                    oc_Newobject00003["anchorLeft"] = "0";
                    oc_Newobject00003["anchorRight"] = "0";
                    oc_Newobject00003["position"] = "3 23";
                    oc_Newobject00003["extent"] = "314 194";
                    oc_Newobject00003["minExtent"] = "8 2";
                    oc_Newobject00003["horizSizing"] = "relative";
                    oc_Newobject00003["vertSizing"] = "relative";
                    oc_Newobject00003["profile"] = "GuiEditorScrollProfile";
                    oc_Newobject00003["visible"] = "1";
                    oc_Newobject00003["active"] = "1";
                    oc_Newobject00003["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00003["hovertime"] = "1000";
                    oc_Newobject00003["isContainer"] = "1";
                    oc_Newobject00003["internalName"] = "OutputScroll";
                    oc_Newobject00003["canSave"] = "1";
                    oc_Newobject00003["canSaveDynamicFields"] = "0";
                    if (true)
                    {

                        #region GuiListBoxCtrl ()        oc_Newobject00002
                        oc_Newobject00002 = new ObjectCreator("GuiListBoxCtrl", "");
                        oc_Newobject00002["allowMultipleSelections"] = "0";
                        oc_Newobject00002["fitParentWidth"] = "1";
                        oc_Newobject00002["colorBullet"] = "1";
                        oc_Newobject00002["position"] = "1 1";
                        oc_Newobject00002["extent"] = "312 16";
                        oc_Newobject00002["minExtent"] = "8 2";
                        oc_Newobject00002["horizSizing"] = "relative";
                        oc_Newobject00002["vertSizing"] = "relative";
                        oc_Newobject00002["profile"] = "GuiListBoxProfile";
                        oc_Newobject00002["visible"] = "1";
                        oc_Newobject00002["active"] = "1";
                        oc_Newobject00002["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00002["hovertime"] = "1000";
                        oc_Newobject00002["isContainer"] = "0";
                        oc_Newobject00002["internalName"] = "Output";
                        oc_Newobject00002["canSave"] = "1";
                        oc_Newobject00002["canSaveDynamicFields"] = "0";
                        #endregion

                        oc_Newobject00003["#Newobject00002"] = oc_Newobject00002;

                    }
                    #endregion

                    oc_Newobject00004["#Newobject00003"] = oc_Newobject00003;

                }
                #endregion
                oc_Newobject00004.Create();

            }
        }
    }
}
