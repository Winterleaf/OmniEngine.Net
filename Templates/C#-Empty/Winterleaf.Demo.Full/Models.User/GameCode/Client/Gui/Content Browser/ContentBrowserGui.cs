using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.CustomObjects;
using WinterLeaf.Demo.Full.Models.User.GameCode;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.User.Extendable
{
    public partial class GuiFileTreeCtrl
    {
        [ConsoleInteraction(true)]
        public override void onDefineIcons()
        {
           string icons = "core/art/gui/images/treeview/default:" +
                    "core/art/gui/images/treeview/simgroup:" +
                    "core/art/gui/images/treeview/simgroup_selected:" +
                    "tools/classIcons/tsStatic:" +
                    "tools/gui/images/iconCollada:" +
                    "tools/classIcons/prefab:";
              
           this.buildIconTable(icons);   
        }
    }
}

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.Content_Browser
{
    [TypeConverter(typeof(TypeConverterGeneric<ContentBrowserGui>))]
    public class ContentBrowserGui : GuiWindowCtrl
    {
        internal ArrayObject currentStaticFilter
        {
            get
            {
                return this["currentStaticFilter"];
            }
            set
            {
                this["currentStaticFilter"] = value;
            }
        }

        internal int columnId
        {
            get
            {
                return this["columnId"].AsInt();
            }
            set
            {
                this["columnId"] = value.AsString();
            }
        }

        //private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
        {
            #region GuiWindowCtrl (ContentBrowserGui)        oc_Newobject42
            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiWindowCtrl", "ContentBrowserGui", typeof(ContentBrowserGui));
            oc_Newobject42["text"] = "Content Browser";
            oc_Newobject42["resizeWidth"] = "1";
            oc_Newobject42["resizeHeight"] = "1";
            oc_Newobject42["canMove"] = "1";
            oc_Newobject42["canClose"] = "1";
            oc_Newobject42["canMinimize"] = "1";
            oc_Newobject42["canMaximize"] = "1";
            oc_Newobject42["canCollapse"] = "0";
            oc_Newobject42["edgeSnap"] = "1";
            oc_Newobject42["setTitle"] = "0";
            oc_Newobject42["ShowTitle"] = "1";
            oc_Newobject42["AllowPopWindow"] = "1";
            oc_Newobject42["isInPopup"] = "0";
            oc_Newobject42["LastWindowPosition"] = "-335 126";
            oc_Newobject42["margin"] = "0 0 0 0";
            oc_Newobject42["padding"] = "0 0 0 0";
            oc_Newobject42["anchorTop"] = "1";
            oc_Newobject42["anchorBottom"] = "0";
            oc_Newobject42["anchorLeft"] = "1";
            oc_Newobject42["anchorRight"] = "0";
            oc_Newobject42["position"] = "0 0";
            oc_Newobject42["extent"] = "1024 768";
            oc_Newobject42["minExtent"] = "8 2";
            oc_Newobject42["maxExtent"] = "1920 1080";
            oc_Newobject42["horizSizing"] = "right";
            oc_Newobject42["vertSizing"] = "bottom";
            oc_Newobject42["profile"] = "GuiWindowProfile";
            oc_Newobject42["controlFontColor"] = "0 0 0 0";
            oc_Newobject42["controlFillColor"] = "0 0 0 0";
            oc_Newobject42["backgroundColor"] = "255 255 255 255";
            oc_Newobject42["controlFontSize"] = "14";
            oc_Newobject42["controlModal"] = "1";
            oc_Newobject42["visible"] = "1";
            oc_Newobject42["active"] = "1";
            oc_Newobject42["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["isContainer"] = "1";
            oc_Newobject42["alphaValue"] = "1";
            oc_Newobject42["mouseOverAlphaValue"] = "1";
            oc_Newobject42["alphaFadeTime"] = "1000";
            oc_Newobject42["moveControl"] = "1";
            oc_Newobject42["lockControl"] = "0";
            oc_Newobject42["windowSettings"] = "1";
            oc_Newobject42["alpha"] = "1";
            oc_Newobject42["mouseOverAlpha"] = "1";
            oc_Newobject42["alphaFade"] = "1";
            oc_Newobject42["contextFontColor"] = "0";
            oc_Newobject42["contextBackColor"] = "0";
            oc_Newobject42["contextFillColor"] = "0";
            oc_Newobject42["contextFontSize"] = "0";
            oc_Newobject42["contextModal"] = "0";
            oc_Newobject42["editable"] = "0";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["canSaveDynamicFields"] = "1";

            #region GuiSplitContainer ()        oc_Newobject41
            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiSplitContainer", "");
            oc_Newobject41["orientation"] = "Vertical";
            oc_Newobject41["splitterSize"] = "2";
            oc_Newobject41["splitPoint"] = "225 10";
            oc_Newobject41["fixedPanel"] = "None";
            oc_Newobject41["fixedSize"] = "814";
            oc_Newobject41["docking"] = "None";
            oc_Newobject41["margin"] = "0 0 0 0";
            oc_Newobject41["padding"] = "0 0 0 0";
            oc_Newobject41["anchorTop"] = "1";
            oc_Newobject41["anchorBottom"] = "0";
            oc_Newobject41["anchorLeft"] = "1";
            oc_Newobject41["anchorRight"] = "0";
            oc_Newobject41["position"] = "0 24";
            oc_Newobject41["extent"] = "1020 739";
            oc_Newobject41["minExtent"] = "64 64";
            oc_Newobject41["maxExtent"] = "1920 1080";
            oc_Newobject41["horizSizing"] = "relative";
            oc_Newobject41["vertSizing"] = "relative";
            oc_Newobject41["profile"] = "GuiProgressTextProfile";
            oc_Newobject41["controlFontColor"] = "0 0 0 0";
            oc_Newobject41["controlFillColor"] = "0 0 0 0";
            oc_Newobject41["backgroundColor"] = "255 255 255 255";
            oc_Newobject41["controlFontSize"] = "14";
            oc_Newobject41["controlModal"] = "1";
            oc_Newobject41["visible"] = "1";
            oc_Newobject41["active"] = "1";
            oc_Newobject41["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["isContainer"] = "1";
            oc_Newobject41["alphaValue"] = "1";
            oc_Newobject41["mouseOverAlphaValue"] = "1";
            oc_Newobject41["alphaFadeTime"] = "1000";
            oc_Newobject41["windowSettings"] = "1";
            oc_Newobject41["alpha"] = "1";
            oc_Newobject41["mouseOverAlpha"] = "1";
            oc_Newobject41["alphaFade"] = "1";
            oc_Newobject41["contextFontColor"] = "0";
            oc_Newobject41["contextBackColor"] = "0";
            oc_Newobject41["contextFillColor"] = "0";
            oc_Newobject41["contextFontSize"] = "0";
            oc_Newobject41["contextModal"] = "0";
            oc_Newobject41["editable"] = "0";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["canSaveDynamicFields"] = "0";

            #region GuiPanel ()        oc_Newobject19
            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiPanel", "");
            oc_Newobject19["docking"] = "Client";
            oc_Newobject19["margin"] = "0 0 0 0";
            oc_Newobject19["padding"] = "0 0 0 0";
            oc_Newobject19["anchorTop"] = "1";
            oc_Newobject19["anchorBottom"] = "0";
            oc_Newobject19["anchorLeft"] = "1";
            oc_Newobject19["anchorRight"] = "0";
            oc_Newobject19["position"] = "0 0";
            oc_Newobject19["extent"] = "223 739";
            oc_Newobject19["minExtent"] = "16 16";
            oc_Newobject19["maxExtent"] = "1920 1080";
            oc_Newobject19["horizSizing"] = "right";
            oc_Newobject19["vertSizing"] = "bottom";
            oc_Newobject19["profile"] = "GuiDefaultProfile";
            oc_Newobject19["controlFontColor"] = "0 0 0 0";
            oc_Newobject19["controlFillColor"] = "0 0 0 0";
            oc_Newobject19["backgroundColor"] = "255 255 255 255";
            oc_Newobject19["controlFontSize"] = "14";
            oc_Newobject19["controlModal"] = "1";
            oc_Newobject19["visible"] = "1";
            oc_Newobject19["active"] = "1";
            oc_Newobject19["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["alphaValue"] = "1";
            oc_Newobject19["mouseOverAlphaValue"] = "1";
            oc_Newobject19["alphaFadeTime"] = "1000";
            oc_Newobject19["moveControl"] = "0";
            oc_Newobject19["lockControl"] = "0";
            oc_Newobject19["windowSettings"] = "1";
            oc_Newobject19["alpha"] = "1";
            oc_Newobject19["mouseOverAlpha"] = "1";
            oc_Newobject19["alphaFade"] = "1";
            oc_Newobject19["contextFontColor"] = "0";
            oc_Newobject19["contextBackColor"] = "0";
            oc_Newobject19["contextFillColor"] = "0";
            oc_Newobject19["contextFontSize"] = "0";
            oc_Newobject19["contextModal"] = "0";
            oc_Newobject19["internalName"] = "Panel1";
            oc_Newobject19["editable"] = "0";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["canSaveDynamicFields"] = "0";

            #region GuiFrameSetCtrl (CBLeftFrameSet)        oc_Newobject18
            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiFrameSetCtrl", "CBLeftFrameSet");
            oc_Newobject18["columns"] = "0";
            oc_Newobject18["rows"] = "0 245 490";
            oc_Newobject18["borderWidth"] = "4";
            oc_Newobject18["borderColor"] = "74 74 95 205";
            oc_Newobject18["borderEnable"] = "dynamic";
            oc_Newobject18["borderMovable"] = "dynamic";
            oc_Newobject18["autoBalance"] = "0";
            oc_Newobject18["fudgeFactor"] = "0";
            oc_Newobject18["margin"] = "0 0 0 0";
            oc_Newobject18["padding"] = "0 0 0 0";
            oc_Newobject18["anchorTop"] = "1";
            oc_Newobject18["anchorBottom"] = "0";
            oc_Newobject18["anchorLeft"] = "1";
            oc_Newobject18["anchorRight"] = "0";
            oc_Newobject18["position"] = "3 0";
            oc_Newobject18["extent"] = "218 731";
            oc_Newobject18["minExtent"] = "8 2";
            oc_Newobject18["maxExtent"] = "1920 1080";
            oc_Newobject18["horizSizing"] = "relative";
            oc_Newobject18["vertSizing"] = "relative";
            oc_Newobject18["profile"] = "GuiFrameSetProfile";
            oc_Newobject18["controlFontColor"] = "0 0 0 0";
            oc_Newobject18["controlFillColor"] = "0 0 0 0";
            oc_Newobject18["backgroundColor"] = "255 255 255 255";
            oc_Newobject18["controlFontSize"] = "14";
            oc_Newobject18["controlModal"] = "1";
            oc_Newobject18["visible"] = "1";
            oc_Newobject18["active"] = "1";
            oc_Newobject18["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["alphaValue"] = "1";
            oc_Newobject18["mouseOverAlphaValue"] = "1";
            oc_Newobject18["alphaFadeTime"] = "1000";
            oc_Newobject18["windowSettings"] = "1";
            oc_Newobject18["alpha"] = "1";
            oc_Newobject18["mouseOverAlpha"] = "1";
            oc_Newobject18["alphaFade"] = "1";
            oc_Newobject18["contextFontColor"] = "0";
            oc_Newobject18["contextBackColor"] = "0";
            oc_Newobject18["contextFillColor"] = "0";
            oc_Newobject18["contextFontSize"] = "0";
            oc_Newobject18["contextModal"] = "0";
            oc_Newobject18["editable"] = "0";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["canSaveDynamicFields"] = "0";

            #region GuiObjectView (CBObjectView)        oc_Newobject1
            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiObjectView", "CBObjectView");
            oc_Newobject1["mountedNode"] = "mount0";
            oc_Newobject1["lightColor"] = "1 1 1 1";
            oc_Newobject1["lightAmbient"] = "0.5 0.5 0.5 1";
            oc_Newobject1["lightDirection"] = "0 0.707 -0.707";
            oc_Newobject1["orbitDiststance"] = "5";
            oc_Newobject1["minOrbitDiststance"] = "0.649417";
            oc_Newobject1["maxOrbitDiststance"] = "5";
            oc_Newobject1["cameraSpeed"] = "0.01";
            oc_Newobject1["cameraRotation"] = "0 0 3";
            oc_Newobject1["cameraZRot"] = "0";
            oc_Newobject1["forceFOV"] = "0";
            oc_Newobject1["reflectPriority"] = "0";
            oc_Newobject1["renderStyle"] = "standard";
            oc_Newobject1["margin"] = "0 0 0 0";
            oc_Newobject1["padding"] = "0 0 0 0";
            oc_Newobject1["anchorTop"] = "1";
            oc_Newobject1["anchorBottom"] = "0";
            oc_Newobject1["anchorLeft"] = "1";
            oc_Newobject1["anchorRight"] = "0";
            oc_Newobject1["position"] = "0 0";
            oc_Newobject1["extent"] = "218 241";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["maxExtent"] = "1920 1080";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "GuiDefaultProfile";
            oc_Newobject1["controlFontColor"] = "0 0 0 0";
            oc_Newobject1["controlFillColor"] = "0 0 0 0";
            oc_Newobject1["backgroundColor"] = "255 255 255 255";
            oc_Newobject1["controlFontSize"] = "14";
            oc_Newobject1["controlModal"] = "1";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["alphaValue"] = "1";
            oc_Newobject1["mouseOverAlphaValue"] = "1";
            oc_Newobject1["alphaFadeTime"] = "1000";
            oc_Newobject1["windowSettings"] = "1";
            oc_Newobject1["alpha"] = "1";
            oc_Newobject1["mouseOverAlpha"] = "1";
            oc_Newobject1["alphaFade"] = "1";
            oc_Newobject1["contextFontColor"] = "0";
            oc_Newobject1["contextBackColor"] = "0";
            oc_Newobject1["contextFillColor"] = "0";
            oc_Newobject1["contextFontSize"] = "0";
            oc_Newobject1["contextModal"] = "0";
            oc_Newobject1["editable"] = "0";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject18["#Newobject1"] = oc_Newobject1;

            #region GuiControl ()        oc_Newobject13
            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiControl", "");
            oc_Newobject13["position"] = "0 245";
            oc_Newobject13["extent"] = "218 241";
            oc_Newobject13["minExtent"] = "8 2";
            oc_Newobject13["maxExtent"] = "1920 1080";
            oc_Newobject13["horizSizing"] = "right";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["profile"] = "GuiDefaultProfile";
            oc_Newobject13["controlFontColor"] = "0 0 0 0";
            oc_Newobject13["controlFillColor"] = "0 0 0 0";
            oc_Newobject13["backgroundColor"] = "255 255 255 255";
            oc_Newobject13["controlFontSize"] = "14";
            oc_Newobject13["controlModal"] = "1";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["active"] = "1";
            oc_Newobject13["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["alphaValue"] = "1";
            oc_Newobject13["mouseOverAlphaValue"] = "1";
            oc_Newobject13["alphaFadeTime"] = "1000";
            oc_Newobject13["moveControl"] = "0";
            oc_Newobject13["lockControl"] = "0";
            oc_Newobject13["windowSettings"] = "1";
            oc_Newobject13["alpha"] = "1";
            oc_Newobject13["mouseOverAlpha"] = "1";
            oc_Newobject13["alphaFade"] = "1";
            oc_Newobject13["contextFontColor"] = "0";
            oc_Newobject13["contextBackColor"] = "0";
            oc_Newobject13["contextFillColor"] = "0";
            oc_Newobject13["contextFontSize"] = "0";
            oc_Newobject13["contextModal"] = "0";
            oc_Newobject13["editable"] = "0";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl (CBDetailedInfo)        oc_Newobject12
            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiScrollCtrl", "CBDetailedInfo");
            oc_Newobject12["willFirstRespond"] = "1";
            oc_Newobject12["hScrollBar"] = "dynamic";
            oc_Newobject12["vScrollBar"] = "dynamic";
            oc_Newobject12["lockHorizScroll"] = "0";
            oc_Newobject12["lockVertScroll"] = "0";
            oc_Newobject12["constantThumbHeight"] = "0";
            oc_Newobject12["childMargin"] = "0 0";
            oc_Newobject12["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject12["margin"] = "0 0 0 0";
            oc_Newobject12["padding"] = "0 0 0 0";
            oc_Newobject12["anchorTop"] = "1";
            oc_Newobject12["anchorBottom"] = "0";
            oc_Newobject12["anchorLeft"] = "1";
            oc_Newobject12["anchorRight"] = "0";
            oc_Newobject12["position"] = "0 0";
            oc_Newobject12["extent"] = "218 241";
            oc_Newobject12["minExtent"] = "8 2";
            oc_Newobject12["maxExtent"] = "1920 1080";
            oc_Newobject12["horizSizing"] = "relative";
            oc_Newobject12["vertSizing"] = "relative";
            oc_Newobject12["profile"] = "GuiScrollProfile";
            oc_Newobject12["controlFontColor"] = "0 0 0 0";
            oc_Newobject12["controlFillColor"] = "0 0 0 0";
            oc_Newobject12["backgroundColor"] = "255 255 255 255";
            oc_Newobject12["controlFontSize"] = "14";
            oc_Newobject12["controlModal"] = "1";
            oc_Newobject12["visible"] = "0";
            oc_Newobject12["active"] = "1";
            oc_Newobject12["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["alphaValue"] = "1";
            oc_Newobject12["mouseOverAlphaValue"] = "1";
            oc_Newobject12["alphaFadeTime"] = "1000";
            oc_Newobject12["windowSettings"] = "1";
            oc_Newobject12["alpha"] = "1";
            oc_Newobject12["mouseOverAlpha"] = "1";
            oc_Newobject12["alphaFade"] = "1";
            oc_Newobject12["contextFontColor"] = "0";
            oc_Newobject12["contextBackColor"] = "0";
            oc_Newobject12["contextFillColor"] = "0";
            oc_Newobject12["contextFontSize"] = "0";
            oc_Newobject12["contextModal"] = "0";
            oc_Newobject12["hidden"] = "1";
            oc_Newobject12["editable"] = "0";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #region GuiControl ()        oc_Newobject11
            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiControl", "");
            oc_Newobject11["position"] = "1 1";
            oc_Newobject11["extent"] = "274 130";
            oc_Newobject11["minExtent"] = "8 2";
            oc_Newobject11["maxExtent"] = "1920 1080";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["profile"] = "GuiDefaultProfile";
            oc_Newobject11["controlFontColor"] = "0 0 0 0";
            oc_Newobject11["controlFillColor"] = "0 0 0 0";
            oc_Newobject11["backgroundColor"] = "255 255 255 255";
            oc_Newobject11["controlFontSize"] = "14";
            oc_Newobject11["controlModal"] = "1";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["active"] = "1";
            oc_Newobject11["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["alphaValue"] = "1";
            oc_Newobject11["mouseOverAlphaValue"] = "1";
            oc_Newobject11["alphaFadeTime"] = "1000";
            oc_Newobject11["moveControl"] = "0";
            oc_Newobject11["lockControl"] = "0";
            oc_Newobject11["windowSettings"] = "1";
            oc_Newobject11["alpha"] = "1";
            oc_Newobject11["mouseOverAlpha"] = "1";
            oc_Newobject11["alphaFade"] = "1";
            oc_Newobject11["contextFontColor"] = "0";
            oc_Newobject11["contextBackColor"] = "0";
            oc_Newobject11["contextFillColor"] = "0";
            oc_Newobject11["contextFontSize"] = "0";
            oc_Newobject11["contextModal"] = "0";
            oc_Newobject11["editable"] = "0";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject2
            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["text"] = "Detailed Info";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["margin"] = "0 0 0 0";
            oc_Newobject2["padding"] = "0 0 0 0";
            oc_Newobject2["anchorTop"] = "1";
            oc_Newobject2["anchorBottom"] = "0";
            oc_Newobject2["anchorLeft"] = "1";
            oc_Newobject2["anchorRight"] = "0";
            oc_Newobject2["position"] = "15 5";
            oc_Newobject2["extent"] = "93 18";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["maxExtent"] = "1920 1080";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiTextProfile";
            oc_Newobject2["controlFontColor"] = "0 0 0 0";
            oc_Newobject2["controlFillColor"] = "0 0 0 0";
            oc_Newobject2["backgroundColor"] = "255 255 255 255";
            oc_Newobject2["controlFontSize"] = "14";
            oc_Newobject2["controlModal"] = "1";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["alphaValue"] = "1";
            oc_Newobject2["mouseOverAlphaValue"] = "1";
            oc_Newobject2["alphaFadeTime"] = "1000";
            oc_Newobject2["moveControl"] = "0";
            oc_Newobject2["lockControl"] = "0";
            oc_Newobject2["windowSettings"] = "1";
            oc_Newobject2["alpha"] = "1";
            oc_Newobject2["mouseOverAlpha"] = "1";
            oc_Newobject2["alphaFade"] = "1";
            oc_Newobject2["contextFontColor"] = "0";
            oc_Newobject2["contextBackColor"] = "0";
            oc_Newobject2["contextFillColor"] = "0";
            oc_Newobject2["contextFontSize"] = "0";
            oc_Newobject2["contextModal"] = "0";
            oc_Newobject2["editable"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject11["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3
            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "Creation Date";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["margin"] = "0 0 0 0";
            oc_Newobject3["padding"] = "0 0 0 0";
            oc_Newobject3["anchorTop"] = "1";
            oc_Newobject3["anchorBottom"] = "0";
            oc_Newobject3["anchorLeft"] = "1";
            oc_Newobject3["anchorRight"] = "0";
            oc_Newobject3["position"] = "15 40";
            oc_Newobject3["extent"] = "70 20";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["maxExtent"] = "1920 1080";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["profile"] = "GuiTextProfile";
            oc_Newobject3["controlFontColor"] = "0 0 0 0";
            oc_Newobject3["controlFillColor"] = "0 0 0 0";
            oc_Newobject3["backgroundColor"] = "255 255 255 255";
            oc_Newobject3["controlFontSize"] = "14";
            oc_Newobject3["controlModal"] = "1";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["alphaValue"] = "1";
            oc_Newobject3["mouseOverAlphaValue"] = "1";
            oc_Newobject3["alphaFadeTime"] = "1000";
            oc_Newobject3["moveControl"] = "0";
            oc_Newobject3["lockControl"] = "0";
            oc_Newobject3["windowSettings"] = "1";
            oc_Newobject3["alpha"] = "1";
            oc_Newobject3["mouseOverAlpha"] = "1";
            oc_Newobject3["alphaFade"] = "1";
            oc_Newobject3["contextFontColor"] = "0";
            oc_Newobject3["contextBackColor"] = "0";
            oc_Newobject3["contextFillColor"] = "0";
            oc_Newobject3["contextFontSize"] = "0";
            oc_Newobject3["contextModal"] = "0";
            oc_Newobject3["editable"] = "0";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject11["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4
            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Size";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["margin"] = "0 0 0 0";
            oc_Newobject4["padding"] = "0 0 0 0";
            oc_Newobject4["anchorTop"] = "1";
            oc_Newobject4["anchorBottom"] = "0";
            oc_Newobject4["anchorLeft"] = "1";
            oc_Newobject4["anchorRight"] = "0";
            oc_Newobject4["position"] = "15 60";
            oc_Newobject4["extent"] = "70 24";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["maxExtent"] = "1920 1080";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiTextProfile";
            oc_Newobject4["controlFontColor"] = "0 0 0 0";
            oc_Newobject4["controlFillColor"] = "0 0 0 0";
            oc_Newobject4["backgroundColor"] = "255 255 255 255";
            oc_Newobject4["controlFontSize"] = "14";
            oc_Newobject4["controlModal"] = "1";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["alphaValue"] = "1";
            oc_Newobject4["mouseOverAlphaValue"] = "1";
            oc_Newobject4["alphaFadeTime"] = "1000";
            oc_Newobject4["moveControl"] = "0";
            oc_Newobject4["lockControl"] = "0";
            oc_Newobject4["windowSettings"] = "1";
            oc_Newobject4["alpha"] = "1";
            oc_Newobject4["mouseOverAlpha"] = "1";
            oc_Newobject4["alphaFade"] = "1";
            oc_Newobject4["contextFontColor"] = "0";
            oc_Newobject4["contextBackColor"] = "0";
            oc_Newobject4["contextFillColor"] = "0";
            oc_Newobject4["contextFontSize"] = "0";
            oc_Newobject4["contextModal"] = "0";
            oc_Newobject4["editable"] = "0";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject11["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5
            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "Last Modified";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["margin"] = "0 0 0 0";
            oc_Newobject5["padding"] = "0 0 0 0";
            oc_Newobject5["anchorTop"] = "1";
            oc_Newobject5["anchorBottom"] = "0";
            oc_Newobject5["anchorLeft"] = "1";
            oc_Newobject5["anchorRight"] = "0";
            oc_Newobject5["position"] = "15 80";
            oc_Newobject5["extent"] = "70 24";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["maxExtent"] = "1920 1080";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["profile"] = "GuiTextProfile";
            oc_Newobject5["controlFontColor"] = "0 0 0 0";
            oc_Newobject5["controlFillColor"] = "0 0 0 0";
            oc_Newobject5["backgroundColor"] = "255 255 255 255";
            oc_Newobject5["controlFontSize"] = "14";
            oc_Newobject5["controlModal"] = "1";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["alphaValue"] = "1";
            oc_Newobject5["mouseOverAlphaValue"] = "1";
            oc_Newobject5["alphaFadeTime"] = "1000";
            oc_Newobject5["moveControl"] = "0";
            oc_Newobject5["lockControl"] = "0";
            oc_Newobject5["windowSettings"] = "1";
            oc_Newobject5["alpha"] = "1";
            oc_Newobject5["mouseOverAlpha"] = "1";
            oc_Newobject5["alphaFade"] = "1";
            oc_Newobject5["contextFontColor"] = "0";
            oc_Newobject5["contextBackColor"] = "0";
            oc_Newobject5["contextFillColor"] = "0";
            oc_Newobject5["contextFontSize"] = "0";
            oc_Newobject5["contextModal"] = "0";
            oc_Newobject5["editable"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject11["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl (CBDetailedInfoCreationDate)        oc_Newobject6
            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "CBDetailedInfoCreationDate");
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["margin"] = "0 0 0 0";
            oc_Newobject6["padding"] = "0 0 0 0";
            oc_Newobject6["anchorTop"] = "1";
            oc_Newobject6["anchorBottom"] = "0";
            oc_Newobject6["anchorLeft"] = "1";
            oc_Newobject6["anchorRight"] = "0";
            oc_Newobject6["position"] = "100 40";
            oc_Newobject6["extent"] = "140 20";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["maxExtent"] = "1920 1080";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "GuiTextProfile";
            oc_Newobject6["controlFontColor"] = "0 0 0 0";
            oc_Newobject6["controlFillColor"] = "0 0 0 0";
            oc_Newobject6["backgroundColor"] = "255 255 255 255";
            oc_Newobject6["controlFontSize"] = "14";
            oc_Newobject6["controlModal"] = "1";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["alphaValue"] = "1";
            oc_Newobject6["mouseOverAlphaValue"] = "1";
            oc_Newobject6["alphaFadeTime"] = "1000";
            oc_Newobject6["moveControl"] = "0";
            oc_Newobject6["lockControl"] = "0";
            oc_Newobject6["windowSettings"] = "1";
            oc_Newobject6["alpha"] = "1";
            oc_Newobject6["mouseOverAlpha"] = "1";
            oc_Newobject6["alphaFade"] = "1";
            oc_Newobject6["contextFontColor"] = "0";
            oc_Newobject6["contextBackColor"] = "0";
            oc_Newobject6["contextFillColor"] = "0";
            oc_Newobject6["contextFontSize"] = "0";
            oc_Newobject6["contextModal"] = "0";
            oc_Newobject6["editable"] = "0";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject11["#Newobject6"] = oc_Newobject6;

            #region GuiTextCtrl (CBDetailedInfoSize)        oc_Newobject7
            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "CBDetailedInfoSize");
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["margin"] = "0 0 0 0";
            oc_Newobject7["padding"] = "0 0 0 0";
            oc_Newobject7["anchorTop"] = "1";
            oc_Newobject7["anchorBottom"] = "0";
            oc_Newobject7["anchorLeft"] = "1";
            oc_Newobject7["anchorRight"] = "0";
            oc_Newobject7["position"] = "100 60";
            oc_Newobject7["extent"] = "140 20";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["maxExtent"] = "1920 1080";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["profile"] = "GuiTextProfile";
            oc_Newobject7["controlFontColor"] = "0 0 0 0";
            oc_Newobject7["controlFillColor"] = "0 0 0 0";
            oc_Newobject7["backgroundColor"] = "255 255 255 255";
            oc_Newobject7["controlFontSize"] = "14";
            oc_Newobject7["controlModal"] = "1";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["alphaValue"] = "1";
            oc_Newobject7["mouseOverAlphaValue"] = "1";
            oc_Newobject7["alphaFadeTime"] = "1000";
            oc_Newobject7["moveControl"] = "0";
            oc_Newobject7["lockControl"] = "0";
            oc_Newobject7["windowSettings"] = "1";
            oc_Newobject7["alpha"] = "1";
            oc_Newobject7["mouseOverAlpha"] = "1";
            oc_Newobject7["alphaFade"] = "1";
            oc_Newobject7["contextFontColor"] = "0";
            oc_Newobject7["contextBackColor"] = "0";
            oc_Newobject7["contextFillColor"] = "0";
            oc_Newobject7["contextFontSize"] = "0";
            oc_Newobject7["contextModal"] = "0";
            oc_Newobject7["editable"] = "0";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject11["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl (CBDetailedInfoLastModified)        oc_Newobject8
            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "CBDetailedInfoLastModified");
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["margin"] = "0 0 0 0";
            oc_Newobject8["padding"] = "0 0 0 0";
            oc_Newobject8["anchorTop"] = "1";
            oc_Newobject8["anchorBottom"] = "0";
            oc_Newobject8["anchorLeft"] = "1";
            oc_Newobject8["anchorRight"] = "0";
            oc_Newobject8["position"] = "100 80";
            oc_Newobject8["extent"] = "140 20";
            oc_Newobject8["minExtent"] = "8 2";
            oc_Newobject8["maxExtent"] = "1920 1080";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["profile"] = "GuiTextProfile";
            oc_Newobject8["controlFontColor"] = "0 0 0 0";
            oc_Newobject8["controlFillColor"] = "0 0 0 0";
            oc_Newobject8["backgroundColor"] = "255 255 255 255";
            oc_Newobject8["controlFontSize"] = "14";
            oc_Newobject8["controlModal"] = "1";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["active"] = "1";
            oc_Newobject8["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["alphaValue"] = "1";
            oc_Newobject8["mouseOverAlphaValue"] = "1";
            oc_Newobject8["alphaFadeTime"] = "1000";
            oc_Newobject8["moveControl"] = "0";
            oc_Newobject8["lockControl"] = "0";
            oc_Newobject8["windowSettings"] = "1";
            oc_Newobject8["alpha"] = "1";
            oc_Newobject8["mouseOverAlpha"] = "1";
            oc_Newobject8["alphaFade"] = "1";
            oc_Newobject8["contextFontColor"] = "0";
            oc_Newobject8["contextBackColor"] = "0";
            oc_Newobject8["contextFillColor"] = "0";
            oc_Newobject8["contextFontSize"] = "0";
            oc_Newobject8["contextModal"] = "0";
            oc_Newobject8["editable"] = "0";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject11["#Newobject8"] = oc_Newobject8;

            #region GuiSeparatorCtrl ()        oc_Newobject9
            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiSeparatorCtrl", "");
            oc_Newobject9["type"] = "Horizontal";
            oc_Newobject9["borderMargin"] = "2";
            oc_Newobject9["invisible"] = "0";
            oc_Newobject9["leftMargin"] = "0";
            oc_Newobject9["position"] = "10 15";
            oc_Newobject9["extent"] = "240 22";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["maxExtent"] = "1920 1080";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["profile"] = "GuiDefaultProfile";
            oc_Newobject9["controlFontColor"] = "0 0 0 0";
            oc_Newobject9["controlFillColor"] = "0 0 0 0";
            oc_Newobject9["backgroundColor"] = "255 255 255 255";
            oc_Newobject9["controlFontSize"] = "14";
            oc_Newobject9["controlModal"] = "1";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["active"] = "1";
            oc_Newobject9["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["alphaValue"] = "1";
            oc_Newobject9["mouseOverAlphaValue"] = "1";
            oc_Newobject9["alphaFadeTime"] = "1000";
            oc_Newobject9["moveControl"] = "0";
            oc_Newobject9["lockControl"] = "0";
            oc_Newobject9["windowSettings"] = "1";
            oc_Newobject9["alpha"] = "1";
            oc_Newobject9["mouseOverAlpha"] = "1";
            oc_Newobject9["alphaFade"] = "1";
            oc_Newobject9["contextFontColor"] = "0";
            oc_Newobject9["contextBackColor"] = "0";
            oc_Newobject9["contextFillColor"] = "0";
            oc_Newobject9["contextFontSize"] = "0";
            oc_Newobject9["contextModal"] = "0";
            oc_Newobject9["editable"] = "0";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject11["#Newobject9"] = oc_Newobject9;

            #region GuiSeparatorCtrl ()        oc_Newobject10
            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiSeparatorCtrl", "");
            oc_Newobject10["type"] = "Vertical";
            oc_Newobject10["borderMargin"] = "2";
            oc_Newobject10["invisible"] = "0";
            oc_Newobject10["leftMargin"] = "0";
            oc_Newobject10["position"] = "80 39";
            oc_Newobject10["extent"] = "12 76";
            oc_Newobject10["minExtent"] = "8 2";
            oc_Newobject10["maxExtent"] = "1920 1080";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["profile"] = "GuiDefaultProfile";
            oc_Newobject10["controlFontColor"] = "0 0 0 0";
            oc_Newobject10["controlFillColor"] = "0 0 0 0";
            oc_Newobject10["backgroundColor"] = "255 255 255 255";
            oc_Newobject10["controlFontSize"] = "14";
            oc_Newobject10["controlModal"] = "1";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["active"] = "1";
            oc_Newobject10["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["alphaValue"] = "1";
            oc_Newobject10["mouseOverAlphaValue"] = "1";
            oc_Newobject10["alphaFadeTime"] = "1000";
            oc_Newobject10["moveControl"] = "0";
            oc_Newobject10["lockControl"] = "0";
            oc_Newobject10["windowSettings"] = "1";
            oc_Newobject10["alpha"] = "1";
            oc_Newobject10["mouseOverAlpha"] = "1";
            oc_Newobject10["alphaFade"] = "1";
            oc_Newobject10["contextFontColor"] = "0";
            oc_Newobject10["contextBackColor"] = "0";
            oc_Newobject10["contextFillColor"] = "0";
            oc_Newobject10["contextFontSize"] = "0";
            oc_Newobject10["contextModal"] = "0";
            oc_Newobject10["editable"] = "0";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject18["#Newobject13"] = oc_Newobject13;

            #region GuiControl ()        oc_Newobject17
            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "");
            oc_Newobject17["position"] = "0 490";
            oc_Newobject17["extent"] = "218 241";
            oc_Newobject17["minExtent"] = "8 2";
            oc_Newobject17["maxExtent"] = "1920 1080";
            oc_Newobject17["horizSizing"] = "right";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["profile"] = "GuiDefaultProfile";
            oc_Newobject17["controlFontColor"] = "0 0 0 0";
            oc_Newobject17["controlFillColor"] = "0 0 0 0";
            oc_Newobject17["backgroundColor"] = "255 255 255 255";
            oc_Newobject17["controlFontSize"] = "14";
            oc_Newobject17["controlModal"] = "1";
            oc_Newobject17["visible"] = "1";
            oc_Newobject17["active"] = "1";
            oc_Newobject17["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["alphaValue"] = "1";
            oc_Newobject17["mouseOverAlphaValue"] = "1";
            oc_Newobject17["alphaFadeTime"] = "1000";
            oc_Newobject17["moveControl"] = "0";
            oc_Newobject17["lockControl"] = "0";
            oc_Newobject17["windowSettings"] = "1";
            oc_Newobject17["alpha"] = "1";
            oc_Newobject17["mouseOverAlpha"] = "1";
            oc_Newobject17["alphaFade"] = "1";
            oc_Newobject17["contextFontColor"] = "0";
            oc_Newobject17["contextBackColor"] = "0";
            oc_Newobject17["contextFillColor"] = "0";
            oc_Newobject17["contextFontSize"] = "0";
            oc_Newobject17["contextModal"] = "0";
            oc_Newobject17["editable"] = "0";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject14
            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["text"] = "File tree";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["margin"] = "0 0 0 0";
            oc_Newobject14["padding"] = "0 0 0 0";
            oc_Newobject14["anchorTop"] = "1";
            oc_Newobject14["anchorBottom"] = "0";
            oc_Newobject14["anchorLeft"] = "1";
            oc_Newobject14["anchorRight"] = "0";
            oc_Newobject14["position"] = "11 1";
            oc_Newobject14["extent"] = "124 14";
            oc_Newobject14["minExtent"] = "8 2";
            oc_Newobject14["maxExtent"] = "1920 1080";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["profile"] = "GuiTextProfile";
            oc_Newobject14["controlFontColor"] = "0 0 0 0";
            oc_Newobject14["controlFillColor"] = "0 0 0 0";
            oc_Newobject14["backgroundColor"] = "255 255 255 255";
            oc_Newobject14["controlFontSize"] = "14";
            oc_Newobject14["controlModal"] = "1";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["active"] = "1";
            oc_Newobject14["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["alphaValue"] = "1";
            oc_Newobject14["mouseOverAlphaValue"] = "1";
            oc_Newobject14["alphaFadeTime"] = "1000";
            oc_Newobject14["moveControl"] = "0";
            oc_Newobject14["lockControl"] = "0";
            oc_Newobject14["windowSettings"] = "1";
            oc_Newobject14["alpha"] = "1";
            oc_Newobject14["mouseOverAlpha"] = "1";
            oc_Newobject14["alphaFade"] = "1";
            oc_Newobject14["contextFontColor"] = "0";
            oc_Newobject14["contextBackColor"] = "0";
            oc_Newobject14["contextFillColor"] = "0";
            oc_Newobject14["contextFontSize"] = "0";
            oc_Newobject14["contextModal"] = "0";
            oc_Newobject14["editable"] = "0";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject17["#Newobject14"] = oc_Newobject14;

            #region GuiScrollCtrl (CBLibraryScroll)        oc_Newobject16
            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiScrollCtrl", "CBLibraryScroll");
            oc_Newobject16["willFirstRespond"] = "1";
            oc_Newobject16["hScrollBar"] = "dynamic";
            oc_Newobject16["vScrollBar"] = "dynamic";
            oc_Newobject16["lockHorizScroll"] = "0";
            oc_Newobject16["lockVertScroll"] = "0";
            oc_Newobject16["constantThumbHeight"] = "0";
            oc_Newobject16["childMargin"] = "0 0";
            oc_Newobject16["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject16["margin"] = "0 0 0 0";
            oc_Newobject16["padding"] = "0 0 0 0";
            oc_Newobject16["anchorTop"] = "1";
            oc_Newobject16["anchorBottom"] = "0";
            oc_Newobject16["anchorLeft"] = "1";
            oc_Newobject16["anchorRight"] = "0";
            oc_Newobject16["position"] = "0 24";
            oc_Newobject16["extent"] = "218 217";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["maxExtent"] = "1920 1080";
            oc_Newobject16["horizSizing"] = "relative";
            oc_Newobject16["vertSizing"] = "relative";
            oc_Newobject16["profile"] = "GuiScrollProfile";
            oc_Newobject16["controlFontColor"] = "0 0 0 0";
            oc_Newobject16["controlFillColor"] = "0 0 0 0";
            oc_Newobject16["backgroundColor"] = "255 255 255 255";
            oc_Newobject16["controlFontSize"] = "14";
            oc_Newobject16["controlModal"] = "1";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["active"] = "1";
            oc_Newobject16["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["alphaValue"] = "1";
            oc_Newobject16["mouseOverAlphaValue"] = "1";
            oc_Newobject16["alphaFadeTime"] = "1000";
            oc_Newobject16["windowSettings"] = "1";
            oc_Newobject16["alpha"] = "1";
            oc_Newobject16["mouseOverAlpha"] = "1";
            oc_Newobject16["alphaFade"] = "1";
            oc_Newobject16["contextFontColor"] = "0";
            oc_Newobject16["contextBackColor"] = "0";
            oc_Newobject16["contextFillColor"] = "0";
            oc_Newobject16["contextFontSize"] = "0";
            oc_Newobject16["contextModal"] = "0";
            oc_Newobject16["editable"] = "0";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "0";

            #region GuiFileTreeCtrl (CBLibraryTreeView)        oc_Newobject15
            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiFileTreeCtrl", "CBLibraryTreeView", typeof(CBLibraryTreeView));
            oc_Newobject15["rootPath"] = "art";
            oc_Newobject15["fileFilter"] = "*.dae *.dts *.kmz *.dif";
            oc_Newobject15["tabSize"] = "16";
            oc_Newobject15["textOffset"] = "2";
            oc_Newobject15["fullRowSelect"] = "0";
            oc_Newobject15["itemHeight"] = "21";
            oc_Newobject15["destroyTreeOnSleep"] = "1";
            oc_Newobject15["mouseDragging"] = "0";
            oc_Newobject15["multipleSelections"] = "0";
            oc_Newobject15["deleteObjectAllowed"] = "1";
            oc_Newobject15["dragToItemAllowed"] = "1";
            oc_Newobject15["clearAllOnSingleSelection"] = "1";
            oc_Newobject15["showRoot"] = "1";
            oc_Newobject15["useInspectorTooltips"] = "0";
            oc_Newobject15["tooltipOnWidthOnly"] = "0";
            oc_Newobject15["showObjectIds"] = "1";
            oc_Newobject15["showClassNames"] = "1";
            oc_Newobject15["showObjectNames"] = "1";
            oc_Newobject15["showInternalNames"] = "1";
            oc_Newobject15["showClassNameForUnnamedObjects"] = "0";
            oc_Newobject15["compareToObjectID"] = "1";
            oc_Newobject15["canRenameObjects"] = "1";
            oc_Newobject15["renameInternal"] = "0";
            oc_Newobject15["position"] = "1 1";
            oc_Newobject15["extent"] = "96 273";
            oc_Newobject15["minExtent"] = "8 2";
            oc_Newobject15["maxExtent"] = "1920 1080";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject15["controlFontColor"] = "0 0 0 0";
            oc_Newobject15["controlFillColor"] = "0 0 0 0";
            oc_Newobject15["backgroundColor"] = "255 255 255 255";
            oc_Newobject15["controlFontSize"] = "14";
            oc_Newobject15["controlModal"] = "1";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["active"] = "1";
            oc_Newobject15["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["alphaValue"] = "1";
            oc_Newobject15["mouseOverAlphaValue"] = "1";
            oc_Newobject15["alphaFadeTime"] = "1000";
            oc_Newobject15["windowSettings"] = "1";
            oc_Newobject15["alpha"] = "1";
            oc_Newobject15["mouseOverAlpha"] = "1";
            oc_Newobject15["alphaFade"] = "1";
            oc_Newobject15["contextFontColor"] = "0";
            oc_Newobject15["contextBackColor"] = "0";
            oc_Newobject15["contextFillColor"] = "0";
            oc_Newobject15["contextFontSize"] = "0";
            oc_Newobject15["contextModal"] = "0";
            oc_Newobject15["editable"] = "0";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject41["#Newobject19"] = oc_Newobject19;

            #region GuiPanel ()        oc_Newobject40
            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiPanel", "");
            oc_Newobject40["docking"] = "Client";
            oc_Newobject40["margin"] = "0 0 0 0";
            oc_Newobject40["padding"] = "0 0 0 0";
            oc_Newobject40["anchorTop"] = "1";
            oc_Newobject40["anchorBottom"] = "0";
            oc_Newobject40["anchorLeft"] = "1";
            oc_Newobject40["anchorRight"] = "0";
            oc_Newobject40["position"] = "227 0";
            oc_Newobject40["extent"] = "793 739";
            oc_Newobject40["minExtent"] = "16 16";
            oc_Newobject40["maxExtent"] = "1920 1080";
            oc_Newobject40["horizSizing"] = "right";
            oc_Newobject40["vertSizing"] = "bottom";
            oc_Newobject40["profile"] = "GuiDefaultProfile";
            oc_Newobject40["controlFontColor"] = "0 0 0 0";
            oc_Newobject40["controlFillColor"] = "0 0 0 0";
            oc_Newobject40["backgroundColor"] = "255 255 255 255";
            oc_Newobject40["controlFontSize"] = "14";
            oc_Newobject40["controlModal"] = "1";
            oc_Newobject40["visible"] = "1";
            oc_Newobject40["active"] = "1";
            oc_Newobject40["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["isContainer"] = "1";
            oc_Newobject40["alphaValue"] = "1";
            oc_Newobject40["mouseOverAlphaValue"] = "1";
            oc_Newobject40["alphaFadeTime"] = "1000";
            oc_Newobject40["moveControl"] = "0";
            oc_Newobject40["lockControl"] = "0";
            oc_Newobject40["windowSettings"] = "1";
            oc_Newobject40["alpha"] = "1";
            oc_Newobject40["mouseOverAlpha"] = "1";
            oc_Newobject40["alphaFade"] = "1";
            oc_Newobject40["contextFontColor"] = "0";
            oc_Newobject40["contextBackColor"] = "0";
            oc_Newobject40["contextFillColor"] = "0";
            oc_Newobject40["contextFontSize"] = "0";
            oc_Newobject40["contextModal"] = "0";
            oc_Newobject40["internalName"] = "panel2";
            oc_Newobject40["editable"] = "0";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["canSaveDynamicFields"] = "0";

            #region GuiFrameSetCtrl (CBRightFrameSet)        oc_Newobject39
            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiFrameSetCtrl", "CBRightFrameSet");
            oc_Newobject39["columns"] = "0";
            oc_Newobject39["rows"] = "0 225 388";
            oc_Newobject39["borderWidth"] = "5";
            oc_Newobject39["borderColor"] = "29 81 109 205";
            oc_Newobject39["borderEnable"] = "alwaysOn";
            oc_Newobject39["borderMovable"] = "alwaysOn";
            oc_Newobject39["autoBalance"] = "1";
            oc_Newobject39["fudgeFactor"] = "5";
            oc_Newobject39["margin"] = "0 0 0 0";
            oc_Newobject39["padding"] = "0 0 0 0";
            oc_Newobject39["anchorTop"] = "1";
            oc_Newobject39["anchorBottom"] = "0";
            oc_Newobject39["anchorLeft"] = "1";
            oc_Newobject39["anchorRight"] = "0";
            oc_Newobject39["position"] = "2 0";
            oc_Newobject39["extent"] = "788 735";
            oc_Newobject39["minExtent"] = "8 2";
            oc_Newobject39["maxExtent"] = "1920 1080";
            oc_Newobject39["horizSizing"] = "relative";
            oc_Newobject39["vertSizing"] = "relative";
            oc_Newobject39["profile"] = "GuiFrameSetProfile";
            oc_Newobject39["controlFontColor"] = "0 0 0 0";
            oc_Newobject39["controlFillColor"] = "0 0 0 0";
            oc_Newobject39["backgroundColor"] = "255 255 255 255";
            oc_Newobject39["controlFontSize"] = "14";
            oc_Newobject39["controlModal"] = "1";
            oc_Newobject39["visible"] = "1";
            oc_Newobject39["active"] = "1";
            oc_Newobject39["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["isContainer"] = "1";
            oc_Newobject39["alphaValue"] = "1";
            oc_Newobject39["mouseOverAlphaValue"] = "1";
            oc_Newobject39["alphaFadeTime"] = "1000";
            oc_Newobject39["windowSettings"] = "1";
            oc_Newobject39["alpha"] = "1";
            oc_Newobject39["mouseOverAlpha"] = "1";
            oc_Newobject39["alphaFade"] = "1";
            oc_Newobject39["contextFontColor"] = "0";
            oc_Newobject39["contextBackColor"] = "0";
            oc_Newobject39["contextFillColor"] = "0";
            oc_Newobject39["contextFontSize"] = "0";
            oc_Newobject39["contextModal"] = "0";
            oc_Newobject39["editable"] = "0";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject35
            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject35["willFirstRespond"] = "1";
            oc_Newobject35["hScrollBar"] = "dynamic";
            oc_Newobject35["vScrollBar"] = "dynamic";
            oc_Newobject35["lockHorizScroll"] = "0";
            oc_Newobject35["lockVertScroll"] = "0";
            oc_Newobject35["constantThumbHeight"] = "0";
            oc_Newobject35["childMargin"] = "0 0";
            oc_Newobject35["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject35["margin"] = "0 0 0 0";
            oc_Newobject35["padding"] = "0 0 0 0";
            oc_Newobject35["anchorTop"] = "1";
            oc_Newobject35["anchorBottom"] = "0";
            oc_Newobject35["anchorLeft"] = "1";
            oc_Newobject35["anchorRight"] = "0";
            oc_Newobject35["position"] = "0 0";
            oc_Newobject35["extent"] = "788 220";
            oc_Newobject35["minExtent"] = "8 2";
            oc_Newobject35["maxExtent"] = "1920 1080";
            oc_Newobject35["horizSizing"] = "right";
            oc_Newobject35["vertSizing"] = "bottom";
            oc_Newobject35["profile"] = "GuiScrollProfile";
            oc_Newobject35["controlFontColor"] = "0 0 0 0";
            oc_Newobject35["controlFillColor"] = "0 0 0 0";
            oc_Newobject35["backgroundColor"] = "255 255 255 255";
            oc_Newobject35["controlFontSize"] = "14";
            oc_Newobject35["controlModal"] = "1";
            oc_Newobject35["visible"] = "1";
            oc_Newobject35["active"] = "1";
            oc_Newobject35["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["isContainer"] = "1";
            oc_Newobject35["alphaValue"] = "1";
            oc_Newobject35["mouseOverAlphaValue"] = "1";
            oc_Newobject35["alphaFadeTime"] = "1000";
            oc_Newobject35["windowSettings"] = "1";
            oc_Newobject35["alpha"] = "1";
            oc_Newobject35["mouseOverAlpha"] = "1";
            oc_Newobject35["alphaFade"] = "1";
            oc_Newobject35["contextFontColor"] = "0";
            oc_Newobject35["contextBackColor"] = "0";
            oc_Newobject35["contextFillColor"] = "0";
            oc_Newobject35["contextFontSize"] = "0";
            oc_Newobject35["contextModal"] = "0";
            oc_Newobject35["editable"] = "0";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["canSaveDynamicFields"] = "0";

            #region GuiControl ()        oc_Newobject34
            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiControl", "");
            oc_Newobject34["position"] = "1 1";
            oc_Newobject34["extent"] = "780 214";
            oc_Newobject34["minExtent"] = "8 2";
            oc_Newobject34["maxExtent"] = "1920 1080";
            oc_Newobject34["horizSizing"] = "right";
            oc_Newobject34["vertSizing"] = "bottom";
            oc_Newobject34["profile"] = "GuiDefaultProfile";
            oc_Newobject34["controlFontColor"] = "0 0 0 0";
            oc_Newobject34["controlFillColor"] = "0 0 0 0";
            oc_Newobject34["backgroundColor"] = "255 255 255 255";
            oc_Newobject34["controlFontSize"] = "14";
            oc_Newobject34["controlModal"] = "1";
            oc_Newobject34["visible"] = "1";
            oc_Newobject34["active"] = "1";
            oc_Newobject34["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["isContainer"] = "1";
            oc_Newobject34["alphaValue"] = "1";
            oc_Newobject34["mouseOverAlphaValue"] = "1";
            oc_Newobject34["alphaFadeTime"] = "1000";
            oc_Newobject34["moveControl"] = "0";
            oc_Newobject34["lockControl"] = "0";
            oc_Newobject34["windowSettings"] = "1";
            oc_Newobject34["alpha"] = "1";
            oc_Newobject34["mouseOverAlpha"] = "1";
            oc_Newobject34["alphaFade"] = "1";
            oc_Newobject34["contextFontColor"] = "0";
            oc_Newobject34["contextBackColor"] = "0";
            oc_Newobject34["contextFillColor"] = "0";
            oc_Newobject34["contextFontSize"] = "0";
            oc_Newobject34["contextModal"] = "0";
            oc_Newobject34["editable"] = "0";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["canSaveDynamicFields"] = "0";

            #region GuiFrameSetCtrl (CBSearchFilter)        oc_Newobject31
            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiFrameSetCtrl", "CBSearchFilter");
            oc_Newobject31["columns"] = "0 329";
            oc_Newobject31["rows"] = "0";
            oc_Newobject31["borderWidth"] = "4";
            oc_Newobject31["borderColor"] = "205 205 205 205";
            oc_Newobject31["borderEnable"] = "dynamic";
            oc_Newobject31["borderMovable"] = "dynamic";
            oc_Newobject31["autoBalance"] = "0";
            oc_Newobject31["fudgeFactor"] = "0";
            oc_Newobject31["margin"] = "0 0 0 0";
            oc_Newobject31["padding"] = "0 0 0 0";
            oc_Newobject31["anchorTop"] = "1";
            oc_Newobject31["anchorBottom"] = "0";
            oc_Newobject31["anchorLeft"] = "1";
            oc_Newobject31["anchorRight"] = "0";
            oc_Newobject31["position"] = "21 39";
            oc_Newobject31["extent"] = "655 170";
            oc_Newobject31["minExtent"] = "8 2";
            oc_Newobject31["maxExtent"] = "1920 1080";
            oc_Newobject31["horizSizing"] = "right";
            oc_Newobject31["vertSizing"] = "bottom";
            oc_Newobject31["profile"] = "GuiFrameSetProfile";
            oc_Newobject31["controlFontColor"] = "0 0 0 0";
            oc_Newobject31["controlFillColor"] = "0 0 0 0";
            oc_Newobject31["backgroundColor"] = "255 255 255 255";
            oc_Newobject31["controlFontSize"] = "14";
            oc_Newobject31["controlModal"] = "1";
            oc_Newobject31["visible"] = "1";
            oc_Newobject31["active"] = "1";
            oc_Newobject31["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["isContainer"] = "1";
            oc_Newobject31["alphaValue"] = "1";
            oc_Newobject31["mouseOverAlphaValue"] = "1";
            oc_Newobject31["alphaFadeTime"] = "1000";
            oc_Newobject31["windowSettings"] = "1";
            oc_Newobject31["alpha"] = "1";
            oc_Newobject31["mouseOverAlpha"] = "1";
            oc_Newobject31["alphaFade"] = "1";
            oc_Newobject31["contextFontColor"] = "0";
            oc_Newobject31["contextBackColor"] = "0";
            oc_Newobject31["contextFillColor"] = "0";
            oc_Newobject31["contextFontSize"] = "0";
            oc_Newobject31["contextModal"] = "0";
            oc_Newobject31["editable"] = "0";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject30
            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject30["willFirstRespond"] = "1";
            oc_Newobject30["hScrollBar"] = "dynamic";
            oc_Newobject30["vScrollBar"] = "dynamic";
            oc_Newobject30["lockHorizScroll"] = "0";
            oc_Newobject30["lockVertScroll"] = "0";
            oc_Newobject30["constantThumbHeight"] = "0";
            oc_Newobject30["childMargin"] = "0 0";
            oc_Newobject30["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject30["margin"] = "0 0 0 0";
            oc_Newobject30["padding"] = "0 0 0 0";
            oc_Newobject30["anchorTop"] = "1";
            oc_Newobject30["anchorBottom"] = "0";
            oc_Newobject30["anchorLeft"] = "1";
            oc_Newobject30["anchorRight"] = "0";
            oc_Newobject30["position"] = "0 0";
            oc_Newobject30["extent"] = "325 170";
            oc_Newobject30["minExtent"] = "8 2";
            oc_Newobject30["maxExtent"] = "1920 1080";
            oc_Newobject30["horizSizing"] = "relative";
            oc_Newobject30["vertSizing"] = "relative";
            oc_Newobject30["profile"] = "GuiScrollProfile";
            oc_Newobject30["controlFontColor"] = "0 0 0 0";
            oc_Newobject30["controlFillColor"] = "0 0 0 0";
            oc_Newobject30["backgroundColor"] = "255 255 255 255";
            oc_Newobject30["controlFontSize"] = "14";
            oc_Newobject30["controlModal"] = "1";
            oc_Newobject30["visible"] = "1";
            oc_Newobject30["active"] = "1";
            oc_Newobject30["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["isContainer"] = "1";
            oc_Newobject30["alphaValue"] = "1";
            oc_Newobject30["mouseOverAlphaValue"] = "1";
            oc_Newobject30["alphaFadeTime"] = "1000";
            oc_Newobject30["windowSettings"] = "1";
            oc_Newobject30["alpha"] = "1";
            oc_Newobject30["mouseOverAlpha"] = "1";
            oc_Newobject30["alphaFade"] = "1";
            oc_Newobject30["contextFontColor"] = "0";
            oc_Newobject30["contextBackColor"] = "0";
            oc_Newobject30["contextFillColor"] = "0";
            oc_Newobject30["contextFontSize"] = "0";
            oc_Newobject30["contextModal"] = "0";
            oc_Newobject30["editable"] = "0";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["canSaveDynamicFields"] = "0";

            #region GuiControl (CBSearchStaticFilter)        oc_Newobject29
            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiControl", "CBSearchStaticFilter");
            oc_Newobject29["position"] = "1 1";
            oc_Newobject29["extent"] = "196 163";
            oc_Newobject29["minExtent"] = "8 2";
            oc_Newobject29["maxExtent"] = "1920 1080";
            oc_Newobject29["horizSizing"] = "right";
            oc_Newobject29["vertSizing"] = "bottom";
            oc_Newobject29["profile"] = "GuiDefaultProfile";
            oc_Newobject29["controlFontColor"] = "0 0 0 0";
            oc_Newobject29["controlFillColor"] = "0 0 0 0";
            oc_Newobject29["backgroundColor"] = "255 255 255 255";
            oc_Newobject29["controlFontSize"] = "14";
            oc_Newobject29["controlModal"] = "1";
            oc_Newobject29["visible"] = "1";
            oc_Newobject29["active"] = "1";
            oc_Newobject29["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["isContainer"] = "1";
            oc_Newobject29["alphaValue"] = "1";
            oc_Newobject29["mouseOverAlphaValue"] = "1";
            oc_Newobject29["alphaFadeTime"] = "1000";
            oc_Newobject29["moveControl"] = "0";
            oc_Newobject29["lockControl"] = "0";
            oc_Newobject29["windowSettings"] = "1";
            oc_Newobject29["alpha"] = "1";
            oc_Newobject29["mouseOverAlpha"] = "1";
            oc_Newobject29["alphaFade"] = "1";
            oc_Newobject29["contextFontColor"] = "0";
            oc_Newobject29["contextBackColor"] = "0";
            oc_Newobject29["contextFillColor"] = "0";
            oc_Newobject29["contextFontSize"] = "0";
            oc_Newobject29["contextModal"] = "0";
            oc_Newobject29["editable"] = "0";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["canSaveDynamicFields"] = "0";

            #region GuiContainer ()        oc_Newobject21
            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiContainer", "");
            oc_Newobject21["margin"] = "0 0 0 0";
            oc_Newobject21["padding"] = "0 0 0 0";
            oc_Newobject21["anchorTop"] = "1";
            oc_Newobject21["anchorBottom"] = "0";
            oc_Newobject21["anchorLeft"] = "1";
            oc_Newobject21["anchorRight"] = "0";
            oc_Newobject21["position"] = "10 5";
            oc_Newobject21["extent"] = "166 17";
            oc_Newobject21["minExtent"] = "8 2";
            oc_Newobject21["maxExtent"] = "1920 1080";
            oc_Newobject21["horizSizing"] = "right";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["profile"] = "GuiDefaultProfile";
            oc_Newobject21["controlFontColor"] = "0 0 0 0";
            oc_Newobject21["controlFillColor"] = "0 0 0 0";
            oc_Newobject21["backgroundColor"] = "255 255 255 255";
            oc_Newobject21["controlFontSize"] = "14";
            oc_Newobject21["controlModal"] = "1";
            oc_Newobject21["visible"] = "1";
            oc_Newobject21["active"] = "1";
            oc_Newobject21["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["alphaValue"] = "1";
            oc_Newobject21["mouseOverAlphaValue"] = "1";
            oc_Newobject21["alphaFadeTime"] = "1000";
            oc_Newobject21["moveControl"] = "0";
            oc_Newobject21["lockControl"] = "0";
            oc_Newobject21["windowSettings"] = "1";
            oc_Newobject21["alpha"] = "1";
            oc_Newobject21["mouseOverAlpha"] = "1";
            oc_Newobject21["alphaFade"] = "1";
            oc_Newobject21["contextFontColor"] = "0";
            oc_Newobject21["contextBackColor"] = "0";
            oc_Newobject21["contextFillColor"] = "0";
            oc_Newobject21["contextFontSize"] = "0";
            oc_Newobject21["contextModal"] = "0";
            oc_Newobject21["editable"] = "0";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject20
            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject20["text"] = "Types";
            oc_Newobject20["maxLength"] = "1024";
            oc_Newobject20["margin"] = "0 0 0 0";
            oc_Newobject20["padding"] = "0 0 0 0";
            oc_Newobject20["anchorTop"] = "1";
            oc_Newobject20["anchorBottom"] = "0";
            oc_Newobject20["anchorLeft"] = "1";
            oc_Newobject20["anchorRight"] = "0";
            oc_Newobject20["position"] = "0 0";
            oc_Newobject20["extent"] = "64 15";
            oc_Newobject20["minExtent"] = "8 2";
            oc_Newobject20["maxExtent"] = "1920 1080";
            oc_Newobject20["horizSizing"] = "right";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["profile"] = "GuiTextProfile";
            oc_Newobject20["controlFontColor"] = "0 0 0 0";
            oc_Newobject20["controlFillColor"] = "0 0 0 0";
            oc_Newobject20["backgroundColor"] = "255 255 255 255";
            oc_Newobject20["controlFontSize"] = "14";
            oc_Newobject20["controlModal"] = "1";
            oc_Newobject20["visible"] = "1";
            oc_Newobject20["active"] = "1";
            oc_Newobject20["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["alphaValue"] = "1";
            oc_Newobject20["mouseOverAlphaValue"] = "1";
            oc_Newobject20["alphaFadeTime"] = "1000";
            oc_Newobject20["moveControl"] = "0";
            oc_Newobject20["lockControl"] = "0";
            oc_Newobject20["windowSettings"] = "1";
            oc_Newobject20["alpha"] = "1";
            oc_Newobject20["mouseOverAlpha"] = "1";
            oc_Newobject20["alphaFade"] = "1";
            oc_Newobject20["contextFontColor"] = "0";
            oc_Newobject20["contextBackColor"] = "0";
            oc_Newobject20["contextFillColor"] = "0";
            oc_Newobject20["contextFontSize"] = "0";
            oc_Newobject20["contextModal"] = "0";
            oc_Newobject20["editable"] = "0";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject29["#Newobject21"] = oc_Newobject21;

            #region GuiCheckBoxCtrl (CBSearchAllCheckBox)        oc_Newobject22
            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiCheckBoxCtrl", "CBSearchAllCheckBox");
            oc_Newobject22["text"] = "All";
            oc_Newobject22["groupNum"] = "-1";
            oc_Newobject22["buttonType"] = "ToggleButton";
            oc_Newobject22["useMouseEvents"] = "0";
            oc_Newobject22["position"] = "10 20";
            oc_Newobject22["extent"] = "140 30";
            oc_Newobject22["minExtent"] = "8 2";
            oc_Newobject22["maxExtent"] = "1920 1080";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["profile"] = "GuiCheckBoxProfile";
            oc_Newobject22["controlFontColor"] = "0 0 0 0";
            oc_Newobject22["backgroundColor"] = "255 255 255 255";
            oc_Newobject22["controlFontSize"] = "14";
            oc_Newobject22["controlModal"] = "1";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["active"] = "1";
            oc_Newobject22["command"] = "ContentBrowserGui.setStaticFilter($ThisControl.getText(), $ThisControl.isStateOn());";
            oc_Newobject22["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["alphaValue"] = "1";
            oc_Newobject22["mouseOverAlphaValue"] = "1";
            oc_Newobject22["alphaFadeTime"] = "1000";
            oc_Newobject22["windowSettings"] = "1";
            oc_Newobject22["alpha"] = "1";
            oc_Newobject22["mouseOverAlpha"] = "1";
            oc_Newobject22["alphaFade"] = "1";
            oc_Newobject22["contextFontColor"] = "0";
            oc_Newobject22["contextBackColor"] = "0";
            oc_Newobject22["contextFontSize"] = "0";
            oc_Newobject22["contextModal"] = "0";
            oc_Newobject22["editable"] = "0";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject29["#Newobject22"] = oc_Newobject22;

            #region GuiCheckBoxCtrl (CBSearchMaterialsCheckBox)        oc_Newobject23
            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiCheckBoxCtrl", "CBSearchMaterialsCheckBox");
            oc_Newobject23["text"] = "Materials";
            oc_Newobject23["groupNum"] = "-1";
            oc_Newobject23["buttonType"] = "ToggleButton";
            oc_Newobject23["useMouseEvents"] = "0";
            oc_Newobject23["position"] = "10 40";
            oc_Newobject23["extent"] = "140 30";
            oc_Newobject23["minExtent"] = "8 2";
            oc_Newobject23["maxExtent"] = "1920 1080";
            oc_Newobject23["horizSizing"] = "right";
            oc_Newobject23["vertSizing"] = "bottom";
            oc_Newobject23["profile"] = "GuiCheckBoxProfile";
            oc_Newobject23["controlFontColor"] = "0 0 0 0";
            oc_Newobject23["backgroundColor"] = "255 255 255 255";
            oc_Newobject23["controlFontSize"] = "14";
            oc_Newobject23["controlModal"] = "1";
            oc_Newobject23["visible"] = "1";
            oc_Newobject23["active"] = "1";
            oc_Newobject23["command"] = "ContentBrowserGui.setStaticFilter($ThisControl.getText(), $ThisControl.isStateOn());";
            oc_Newobject23["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["alphaValue"] = "1";
            oc_Newobject23["mouseOverAlphaValue"] = "1";
            oc_Newobject23["alphaFadeTime"] = "1000";
            oc_Newobject23["windowSettings"] = "1";
            oc_Newobject23["alpha"] = "1";
            oc_Newobject23["mouseOverAlpha"] = "1";
            oc_Newobject23["alphaFade"] = "1";
            oc_Newobject23["contextFontColor"] = "0";
            oc_Newobject23["contextBackColor"] = "0";
            oc_Newobject23["contextFontSize"] = "0";
            oc_Newobject23["contextModal"] = "0";
            oc_Newobject23["editable"] = "0";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject29["#Newobject23"] = oc_Newobject23;

            #region GuiCheckBoxCtrl (CBSearchParticleEmittersCheckBox)        oc_Newobject24
            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiCheckBoxCtrl", "CBSearchParticleEmittersCheckBox");
            oc_Newobject24["text"] = "Particle Emitters";
            oc_Newobject24["groupNum"] = "-1";
            oc_Newobject24["buttonType"] = "ToggleButton";
            oc_Newobject24["useMouseEvents"] = "0";
            oc_Newobject24["position"] = "10 60";
            oc_Newobject24["extent"] = "140 30";
            oc_Newobject24["minExtent"] = "8 2";
            oc_Newobject24["maxExtent"] = "1920 1080";
            oc_Newobject24["horizSizing"] = "right";
            oc_Newobject24["vertSizing"] = "bottom";
            oc_Newobject24["profile"] = "GuiCheckBoxProfile";
            oc_Newobject24["controlFontColor"] = "0 0 0 0";
            oc_Newobject24["backgroundColor"] = "255 255 255 255";
            oc_Newobject24["controlFontSize"] = "14";
            oc_Newobject24["controlModal"] = "1";
            oc_Newobject24["visible"] = "1";
            oc_Newobject24["active"] = "1";
            oc_Newobject24["command"] = "ContentBrowserGui.setStaticFilter($ThisControl.getText(), $ThisControl.isStateOn());";
            oc_Newobject24["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["alphaValue"] = "1";
            oc_Newobject24["mouseOverAlphaValue"] = "1";
            oc_Newobject24["alphaFadeTime"] = "1000";
            oc_Newobject24["windowSettings"] = "1";
            oc_Newobject24["alpha"] = "1";
            oc_Newobject24["mouseOverAlpha"] = "1";
            oc_Newobject24["alphaFade"] = "1";
            oc_Newobject24["contextFontColor"] = "0";
            oc_Newobject24["contextBackColor"] = "0";
            oc_Newobject24["contextFontSize"] = "0";
            oc_Newobject24["contextModal"] = "0";
            oc_Newobject24["editable"] = "0";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject29["#Newobject24"] = oc_Newobject24;

            #region GuiCheckBoxCtrl (CBSearchScriptedMeshesCheckBox)        oc_Newobject25
            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiCheckBoxCtrl", "CBSearchScriptedMeshesCheckBox");
            oc_Newobject25["text"] = "Scripted Meshes";
            oc_Newobject25["groupNum"] = "-1";
            oc_Newobject25["buttonType"] = "ToggleButton";
            oc_Newobject25["useMouseEvents"] = "0";
            oc_Newobject25["position"] = "10 80";
            oc_Newobject25["extent"] = "140 30";
            oc_Newobject25["minExtent"] = "8 2";
            oc_Newobject25["maxExtent"] = "1920 1080";
            oc_Newobject25["horizSizing"] = "right";
            oc_Newobject25["vertSizing"] = "bottom";
            oc_Newobject25["profile"] = "GuiCheckBoxProfile";
            oc_Newobject25["controlFontColor"] = "0 0 0 0";
            oc_Newobject25["backgroundColor"] = "255 255 255 255";
            oc_Newobject25["controlFontSize"] = "14";
            oc_Newobject25["controlModal"] = "1";
            oc_Newobject25["visible"] = "1";
            oc_Newobject25["active"] = "1";
            oc_Newobject25["command"] = "ContentBrowserGui.setStaticFilter($ThisControl.getText(), $ThisControl.isStateOn());";
            oc_Newobject25["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["alphaValue"] = "1";
            oc_Newobject25["mouseOverAlphaValue"] = "1";
            oc_Newobject25["alphaFadeTime"] = "1000";
            oc_Newobject25["windowSettings"] = "1";
            oc_Newobject25["alpha"] = "1";
            oc_Newobject25["mouseOverAlpha"] = "1";
            oc_Newobject25["alphaFade"] = "1";
            oc_Newobject25["contextFontColor"] = "0";
            oc_Newobject25["contextBackColor"] = "0";
            oc_Newobject25["contextFontSize"] = "0";
            oc_Newobject25["contextModal"] = "0";
            oc_Newobject25["editable"] = "0";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject29["#Newobject25"] = oc_Newobject25;

            #region GuiCheckBoxCtrl (CBSearchSoundEmittersCheckBox)        oc_Newobject26
            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiCheckBoxCtrl", "CBSearchSoundEmittersCheckBox");
            oc_Newobject26["text"] = "Sound Emitters";
            oc_Newobject26["groupNum"] = "-1";
            oc_Newobject26["buttonType"] = "ToggleButton";
            oc_Newobject26["useMouseEvents"] = "0";
            oc_Newobject26["position"] = "10 100";
            oc_Newobject26["extent"] = "140 30";
            oc_Newobject26["minExtent"] = "8 2";
            oc_Newobject26["maxExtent"] = "1920 1080";
            oc_Newobject26["horizSizing"] = "right";
            oc_Newobject26["vertSizing"] = "bottom";
            oc_Newobject26["profile"] = "GuiCheckBoxProfile";
            oc_Newobject26["controlFontColor"] = "0 0 0 0";
            oc_Newobject26["backgroundColor"] = "255 255 255 255";
            oc_Newobject26["controlFontSize"] = "14";
            oc_Newobject26["controlModal"] = "1";
            oc_Newobject26["visible"] = "1";
            oc_Newobject26["active"] = "1";
            oc_Newobject26["command"] = "ContentBrowserGui.setStaticFilter($ThisControl.getText(), $ThisControl.isStateOn());";
            oc_Newobject26["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["alphaValue"] = "1";
            oc_Newobject26["mouseOverAlphaValue"] = "1";
            oc_Newobject26["alphaFadeTime"] = "1000";
            oc_Newobject26["windowSettings"] = "1";
            oc_Newobject26["alpha"] = "1";
            oc_Newobject26["mouseOverAlpha"] = "1";
            oc_Newobject26["alphaFade"] = "1";
            oc_Newobject26["contextFontColor"] = "0";
            oc_Newobject26["contextBackColor"] = "0";
            oc_Newobject26["contextFontSize"] = "0";
            oc_Newobject26["contextModal"] = "0";
            oc_Newobject26["editable"] = "0";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject29["#Newobject26"] = oc_Newobject26;

            #region GuiCheckBoxCtrl (CBSearchStaticMeshesCheckBox)        oc_Newobject27
            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiCheckBoxCtrl", "CBSearchStaticMeshesCheckBox");
            oc_Newobject27["text"] = "Static Meshes";
            oc_Newobject27["groupNum"] = "-1";
            oc_Newobject27["buttonType"] = "ToggleButton";
            oc_Newobject27["useMouseEvents"] = "0";
            oc_Newobject27["position"] = "10 120";
            oc_Newobject27["extent"] = "140 30";
            oc_Newobject27["minExtent"] = "8 2";
            oc_Newobject27["maxExtent"] = "1920 1080";
            oc_Newobject27["horizSizing"] = "right";
            oc_Newobject27["vertSizing"] = "bottom";
            oc_Newobject27["profile"] = "GuiCheckBoxProfile";
            oc_Newobject27["controlFontColor"] = "0 0 0 0";
            oc_Newobject27["backgroundColor"] = "255 255 255 255";
            oc_Newobject27["controlFontSize"] = "14";
            oc_Newobject27["controlModal"] = "1";
            oc_Newobject27["visible"] = "1";
            oc_Newobject27["active"] = "1";
            oc_Newobject27["command"] = "ContentBrowserGui.setStaticFilter($ThisControl.getText(), $ThisControl.isStateOn());";
            oc_Newobject27["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["alphaValue"] = "1";
            oc_Newobject27["mouseOverAlphaValue"] = "1";
            oc_Newobject27["alphaFadeTime"] = "1000";
            oc_Newobject27["windowSettings"] = "1";
            oc_Newobject27["alpha"] = "1";
            oc_Newobject27["mouseOverAlpha"] = "1";
            oc_Newobject27["alphaFade"] = "1";
            oc_Newobject27["contextFontColor"] = "0";
            oc_Newobject27["contextBackColor"] = "0";
            oc_Newobject27["contextFontSize"] = "0";
            oc_Newobject27["contextModal"] = "0";
            oc_Newobject27["editable"] = "0";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject29["#Newobject27"] = oc_Newobject27;

            #region GuiCheckBoxCtrl (CBSearchTexturesCheckBox)        oc_Newobject28
            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiCheckBoxCtrl", "CBSearchTexturesCheckBox");
            oc_Newobject28["text"] = "Textures";
            oc_Newobject28["groupNum"] = "-1";
            oc_Newobject28["buttonType"] = "ToggleButton";
            oc_Newobject28["useMouseEvents"] = "0";
            oc_Newobject28["position"] = "10 140";
            oc_Newobject28["extent"] = "140 30";
            oc_Newobject28["minExtent"] = "8 2";
            oc_Newobject28["maxExtent"] = "1920 1080";
            oc_Newobject28["horizSizing"] = "right";
            oc_Newobject28["vertSizing"] = "bottom";
            oc_Newobject28["profile"] = "GuiCheckBoxProfile";
            oc_Newobject28["controlFontColor"] = "0 0 0 0";
            oc_Newobject28["backgroundColor"] = "255 255 255 255";
            oc_Newobject28["controlFontSize"] = "14";
            oc_Newobject28["controlModal"] = "1";
            oc_Newobject28["visible"] = "1";
            oc_Newobject28["active"] = "1";
            oc_Newobject28["command"] = "ContentBrowserGui.setStaticFilter($ThisControl.getText(), $ThisControl.isStateOn());";
            oc_Newobject28["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["isContainer"] = "0";
            oc_Newobject28["alphaValue"] = "1";
            oc_Newobject28["mouseOverAlphaValue"] = "1";
            oc_Newobject28["alphaFadeTime"] = "1000";
            oc_Newobject28["windowSettings"] = "1";
            oc_Newobject28["alpha"] = "1";
            oc_Newobject28["mouseOverAlpha"] = "1";
            oc_Newobject28["alphaFade"] = "1";
            oc_Newobject28["contextFontColor"] = "0";
            oc_Newobject28["contextBackColor"] = "0";
            oc_Newobject28["contextFontSize"] = "0";
            oc_Newobject28["contextModal"] = "0";
            oc_Newobject28["editable"] = "0";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject29["#Newobject28"] = oc_Newobject28;

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject31["#Newobject30"] = oc_Newobject30;

            #endregion

            oc_Newobject34["#Newobject31"] = oc_Newobject31;

            #region GuiButtonCtrl (CBSearchButton)        oc_Newobject32
            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiButtonCtrl", "CBSearchButton");
            oc_Newobject32["text"] = "Search";
            oc_Newobject32["groupNum"] = "-1";
            oc_Newobject32["buttonType"] = "PushButton";
            oc_Newobject32["useMouseEvents"] = "0";
            oc_Newobject32["position"] = "508 4";
            oc_Newobject32["extent"] = "167 30";
            oc_Newobject32["minExtent"] = "8 2";
            oc_Newobject32["maxExtent"] = "1920 1080";
            oc_Newobject32["horizSizing"] = "right";
            oc_Newobject32["vertSizing"] = "bottom";
            oc_Newobject32["profile"] = "GuiButtonProfile";
            oc_Newobject32["controlFontColor"] = "0 0 0 0";
            oc_Newobject32["backgroundColor"] = "255 255 255 255";
            oc_Newobject32["controlFontSize"] = "14";
            oc_Newobject32["controlModal"] = "1";
            oc_Newobject32["command"] = "CBDetailedTable.selectRow( CBSearchAutoCompleteCtrl.text );";
            oc_Newobject32["visible"] = "1";
            oc_Newobject32["active"] = "1";
            oc_Newobject32["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["alphaValue"] = "1";
            oc_Newobject32["mouseOverAlphaValue"] = "1";
            oc_Newobject32["alphaFadeTime"] = "1000";
            oc_Newobject32["windowSettings"] = "1";
            oc_Newobject32["alpha"] = "1";
            oc_Newobject32["mouseOverAlpha"] = "1";
            oc_Newobject32["alphaFade"] = "1";
            oc_Newobject32["contextFontColor"] = "0";
            oc_Newobject32["contextBackColor"] = "0";
            oc_Newobject32["contextFontSize"] = "0";
            oc_Newobject32["contextModal"] = "0";
            oc_Newobject32["editable"] = "0";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject34["#Newobject32"] = oc_Newobject32;

            #region GuiAutoCompleteCtrl (CBSearchAutoCompleteCtrl)        oc_Newobject33
            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiAutoCompleteCtrl", "CBSearchAutoCompleteCtrl", typeof(CBSearchAutoCompleteCtrl));
            oc_Newobject33["maxPopupHeight"] = "200";
            oc_Newobject33["sbUsesNAColor"] = "0";
            oc_Newobject33["reverseTextList"] = "0";
            oc_Newobject33["bitmapBounds"] = "16 16";
            oc_Newobject33["historySize"] = "0";
            oc_Newobject33["tabComplete"] = "0";
            oc_Newobject33["sinkAllKeyEvents"] = "0";
            oc_Newobject33["password"] = "0";
            oc_Newobject33["passwordMask"] = "*";
            oc_Newobject33["maxLength"] = "1024";
            oc_Newobject33["margin"] = "0 0 0 0";
            oc_Newobject33["padding"] = "0 0 0 0";
            oc_Newobject33["anchorTop"] = "1";
            oc_Newobject33["anchorBottom"] = "0";
            oc_Newobject33["anchorLeft"] = "1";
            oc_Newobject33["anchorRight"] = "0";
            oc_Newobject33["position"] = "30 9";
            oc_Newobject33["extent"] = "445 17";
            oc_Newobject33["minExtent"] = "8 2";
            oc_Newobject33["maxExtent"] = "1920 1080";
            oc_Newobject33["horizSizing"] = "right";
            oc_Newobject33["vertSizing"] = "bottom";
            oc_Newobject33["profile"] = "GuiTextEditProfile";
            oc_Newobject33["controlFontColor"] = "0 0 0 0";
            oc_Newobject33["controlFillColor"] = "0 0 0 0";
            oc_Newobject33["backgroundColor"] = "255 255 255 255";
            oc_Newobject33["controlFontSize"] = "14";
            oc_Newobject33["controlModal"] = "1";
            oc_Newobject33["visible"] = "1";
            oc_Newobject33["active"] = "1";
            oc_Newobject33["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["isContainer"] = "1";
            oc_Newobject33["alphaValue"] = "1";
            oc_Newobject33["mouseOverAlphaValue"] = "1";
            oc_Newobject33["alphaFadeTime"] = "1000";
            oc_Newobject33["windowSettings"] = "1";
            oc_Newobject33["alpha"] = "1";
            oc_Newobject33["mouseOverAlpha"] = "1";
            oc_Newobject33["alphaFade"] = "1";
            oc_Newobject33["contextFontColor"] = "0";
            oc_Newobject33["contextBackColor"] = "0";
            oc_Newobject33["contextFillColor"] = "0";
            oc_Newobject33["contextFontSize"] = "0";
            oc_Newobject33["contextModal"] = "0";
            oc_Newobject33["editable"] = "0";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject34["#Newobject33"] = oc_Newobject33;

            #endregion

            oc_Newobject35["#Newobject34"] = oc_Newobject34;

            #endregion

            oc_Newobject39["#Newobject35"] = oc_Newobject35;

            #region GuiTableControl (CBDetailedTable)        oc_Newobject36
            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiTableControl", "CBDetailedTable", typeof(CBDetailedTable));
            oc_Newobject36["columns"] = "0 300 600 900";
            oc_Newobject36["fitParentWidth"] = "0";
            oc_Newobject36["headingSize"] = "20";
            oc_Newobject36["willFirstRespond"] = "1";
            oc_Newobject36["hScrollBar"] = "alwaysOn";
            oc_Newobject36["vScrollBar"] = "alwaysOn";
            oc_Newobject36["lockHorizScroll"] = "0";
            oc_Newobject36["lockVertScroll"] = "0";
            oc_Newobject36["constantThumbHeight"] = "0";
            oc_Newobject36["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject36["margin"] = "0 0 0 0";
            oc_Newobject36["padding"] = "0 0 0 0";
            oc_Newobject36["anchorTop"] = "1";
            oc_Newobject36["anchorBottom"] = "0";
            oc_Newobject36["anchorLeft"] = "1";
            oc_Newobject36["anchorRight"] = "0";
            oc_Newobject36["position"] = "0 225";
            oc_Newobject36["extent"] = "788 158";
            oc_Newobject36["minExtent"] = "8 2";
            oc_Newobject36["maxExtent"] = "1920 1080";
            oc_Newobject36["horizSizing"] = "right";
            oc_Newobject36["vertSizing"] = "bottom";
            oc_Newobject36["profile"] = "GuiScrollProfile";
            oc_Newobject36["controlFontColor"] = "0 0 0 0";
            oc_Newobject36["controlFillColor"] = "0 0 0 0";
            oc_Newobject36["backgroundColor"] = "255 255 255 255";
            oc_Newobject36["controlFontSize"] = "14";
            oc_Newobject36["controlModal"] = "1";
            oc_Newobject36["visible"] = "1";
            oc_Newobject36["active"] = "1";
            oc_Newobject36["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject36["hovertime"] = "1000";
            oc_Newobject36["isContainer"] = "1";
            oc_Newobject36["alphaValue"] = "1";
            oc_Newobject36["mouseOverAlphaValue"] = "1";
            oc_Newobject36["alphaFadeTime"] = "1000";
            oc_Newobject36["windowSettings"] = "1";
            oc_Newobject36["alpha"] = "1";
            oc_Newobject36["mouseOverAlpha"] = "1";
            oc_Newobject36["alphaFade"] = "1";
            oc_Newobject36["contextFontColor"] = "0";
            oc_Newobject36["contextBackColor"] = "0";
            oc_Newobject36["contextFillColor"] = "0";
            oc_Newobject36["contextFontSize"] = "0";
            oc_Newobject36["contextModal"] = "0";
            oc_Newobject36["editable"] = "0";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject39["#Newobject36"] = oc_Newobject36;

            #region GuiScrollCtrl (CBThumbnailScroll)        oc_Newobject38
            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiScrollCtrl", "CBThumbnailScroll");
            oc_Newobject38["willFirstRespond"] = "1";
            oc_Newobject38["hScrollBar"] = "alwaysOff";
            oc_Newobject38["vScrollBar"] = "dynamic";
            oc_Newobject38["lockHorizScroll"] = "0";
            oc_Newobject38["lockVertScroll"] = "0";
            oc_Newobject38["constantThumbHeight"] = "0";
            oc_Newobject38["childMargin"] = "10 0";
            oc_Newobject38["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject38["margin"] = "0 0 0 0";
            oc_Newobject38["padding"] = "0 0 0 0";
            oc_Newobject38["anchorTop"] = "1";
            oc_Newobject38["anchorBottom"] = "0";
            oc_Newobject38["anchorLeft"] = "1";
            oc_Newobject38["anchorRight"] = "0";
            oc_Newobject38["position"] = "0 388";
            oc_Newobject38["extent"] = "788 347";
            oc_Newobject38["minExtent"] = "8 2";
            oc_Newobject38["maxExtent"] = "1920 1080";
            oc_Newobject38["horizSizing"] = "relative";
            oc_Newobject38["vertSizing"] = "relative";
            oc_Newobject38["profile"] = "GuiScrollProfile";
            oc_Newobject38["controlFontColor"] = "0 0 0 0";
            oc_Newobject38["controlFillColor"] = "0 0 0 0";
            oc_Newobject38["backgroundColor"] = "255 255 255 255";
            oc_Newobject38["controlFontSize"] = "14";
            oc_Newobject38["controlModal"] = "1";
            oc_Newobject38["visible"] = "1";
            oc_Newobject38["active"] = "1";
            oc_Newobject38["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["isContainer"] = "1";
            oc_Newobject38["alphaValue"] = "1";
            oc_Newobject38["mouseOverAlphaValue"] = "1";
            oc_Newobject38["alphaFadeTime"] = "1000";
            oc_Newobject38["windowSettings"] = "1";
            oc_Newobject38["alpha"] = "1";
            oc_Newobject38["mouseOverAlpha"] = "1";
            oc_Newobject38["alphaFade"] = "1";
            oc_Newobject38["contextFontColor"] = "0";
            oc_Newobject38["contextBackColor"] = "0";
            oc_Newobject38["contextFillColor"] = "0";
            oc_Newobject38["contextFontSize"] = "0";
            oc_Newobject38["contextModal"] = "0";
            oc_Newobject38["editable"] = "0";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["canSaveDynamicFields"] = "0";

            #region GuiDynamicCtrlArrayControl (CBThumbnailDynamicControl)        oc_Newobject37
            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiDynamicCtrlArrayControl", "CBThumbnailDynamicControl");
            oc_Newobject37["colCount"] = "4";
            oc_Newobject37["colSize"] = "170";
            oc_Newobject37["rowCount"] = "1";
            oc_Newobject37["rowSize"] = "170";
            oc_Newobject37["rowSpacing"] = "0";
            oc_Newobject37["colSpacing"] = "0";
            oc_Newobject37["frozen"] = "0";
            oc_Newobject37["autoCellSize"] = "0";
            oc_Newobject37["fillRowFirst"] = "1";
            oc_Newobject37["dynamicSize"] = "1";
            oc_Newobject37["padding"] = "0 0 0 0";
            oc_Newobject37["position"] = "11 1";
            oc_Newobject37["extent"] = "770 169";
            oc_Newobject37["minExtent"] = "8 2";
            oc_Newobject37["maxExtent"] = "1920 1080";
            oc_Newobject37["horizSizing"] = "relative";
            oc_Newobject37["vertSizing"] = "relative";
            oc_Newobject37["profile"] = "GuiMenuButtonProfile";
            oc_Newobject37["controlFontColor"] = "0 0 0 0";
            oc_Newobject37["controlFillColor"] = "0 0 0 0";
            oc_Newobject37["backgroundColor"] = "255 255 255 255";
            oc_Newobject37["controlFontSize"] = "18";
            oc_Newobject37["controlModal"] = "1";
            oc_Newobject37["visible"] = "1";
            oc_Newobject37["active"] = "1";
            oc_Newobject37["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["isContainer"] = "1";
            oc_Newobject37["alphaValue"] = "1";
            oc_Newobject37["mouseOverAlphaValue"] = "1";
            oc_Newobject37["alphaFadeTime"] = "1000";
            oc_Newobject37["moveControl"] = "0";
            oc_Newobject37["lockControl"] = "0";
            oc_Newobject37["windowSettings"] = "1";
            oc_Newobject37["alpha"] = "1";
            oc_Newobject37["mouseOverAlpha"] = "1";
            oc_Newobject37["alphaFade"] = "1";
            oc_Newobject37["contextFontColor"] = "0";
            oc_Newobject37["contextBackColor"] = "0";
            oc_Newobject37["contextFillColor"] = "0";
            oc_Newobject37["contextFontSize"] = "0";
            oc_Newobject37["contextModal"] = "0";
            oc_Newobject37["editable"] = "0";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject38["#Newobject37"] = oc_Newobject37;

            #endregion

            oc_Newobject39["#Newobject38"] = oc_Newobject38;

            #endregion

            oc_Newobject40["#Newobject39"] = oc_Newobject39;

            #endregion

            oc_Newobject41["#Newobject40"] = oc_Newobject40;

            #endregion

            oc_Newobject42["#Newobject41"] = oc_Newobject41;

            #endregion
            oc_Newobject42.Create();
        }

        [ConsoleInteraction(true)]
        public void setStaticFilter( string filter, bool state )
        {
            filter = Util.stripChars( filter, " " );

            ArrayObject AllArray = "AllArray";
  
            if( currentStaticFilter.getIndexFromKey( AllArray ) != -1 )
            currentStaticFilter.empty();
            int key = -1;
   
            switch(filter)
            {
                case "All":
                    if( state )
                    {
                        this.clearActiveStaticFilters();
                    }
                    break;

                case "Materials":
                    ArrayObject MaterialAllArray = "MaterialAllArray";
                    if( state )
                        this.currentStaticFilter.add( MaterialAllArray, "" );
                    else
                    {
                        key = currentStaticFilter.getIndexFromKey( MaterialAllArray );
                        currentStaticFilter.erase( key );
                    }
                    break;
         
                case "ParticleEmitters":
                    ArrayObject ParticleEmittersArray = "ParticleEmittersArray";
                    if( state )
                        currentStaticFilter.add( ParticleEmittersArray, "" );
                    else
                    {
                        key = currentStaticFilter.getIndexFromKey( ParticleEmittersArray );
                        currentStaticFilter.erase( key );
                    }
                    break;
         
                case "ScriptedMeshes":
                    ArrayObject ScriptedMeshArray = "ScriptedMeshArray";
                    if( state )
                        currentStaticFilter.add( ScriptedMeshArray, "" );
                    else
                    {
                        key = currentStaticFilter.getIndexFromKey( ScriptedMeshArray );
                        currentStaticFilter.erase( key );
                    }
                    break;
         
                case "SoundEmitters":
                    ArrayObject SoundEmittersArray = "SoundEmittersArray";
                    if( state )
                        currentStaticFilter.add( SoundEmittersArray, "" );
                    else
                    {
                        key = currentStaticFilter.getIndexFromKey( SoundEmittersArray );
                        currentStaticFilter.erase( key );
                    }
                    break;
         
                case "StaticMeshes":
                    ArrayObject StaticMeshArray = "StaticMeshArray";
                    if( state )
                        currentStaticFilter.add( StaticMeshArray, "" );
                    else
                    {
                        key = currentStaticFilter.getIndexFromKey( StaticMeshArray );
                        currentStaticFilter.erase( key );
                    }
                    break;
         
                case "Textures":
                    ArrayObject TexturesArray = "TexturesArray";
                    if( state )
                        currentStaticFilter.add( TexturesArray, "" );
                    else
                    {
                        key = currentStaticFilter.getIndexFromKey( TexturesArray );
                        currentStaticFilter.erase( key );
                    }
                    break;

            }

            GuiCheckBoxCtrl CBSearchAllCheckBox = "CBSearchAllCheckBox";
   
            if( this.isStaticFiltersActive() )
                CBSearchAllCheckBox.setStateOn(false);
            else
            {
                CBSearchAllCheckBox.setStateOn(true);
                currentStaticFilter.empty();
                currentStaticFilter.add( AllArray, "" );
            }
      
            this.loadFilter( "", "", false );
        }

        [ConsoleInteraction]
        public bool isStaticFiltersActive()
        {
            GuiCheckBoxCtrl CBSearchMaterialsCheckBox = "CBSearchMaterialsCheckBox";
            GuiCheckBoxCtrl CBSearchParticleEmittersCheckBox = "CBSearchParticleEmittersCheckBox";
            GuiCheckBoxCtrl CBSearchScriptedMeshesCheckBox = "CBSearchScriptedMeshesCheckBox";
            GuiCheckBoxCtrl CBSearchSoundEmittersCheckBox = "CBSearchSoundEmittersCheckBox";
            GuiCheckBoxCtrl CBSearchStaticMeshesCheckBox = "CBSearchStaticMeshesCheckBox";
            GuiCheckBoxCtrl CBSearchTexturesCheckBox = "CBSearchTexturesCheckBox";

            return (CBSearchMaterialsCheckBox.isStateOn() || CBSearchParticleEmittersCheckBox.isStateOn()
            || CBSearchScriptedMeshesCheckBox.isStateOn() || CBSearchSoundEmittersCheckBox.isStateOn() ||
            CBSearchStaticMeshesCheckBox.isStateOn() || CBSearchTexturesCheckBox.isStateOn());
        }

        [ConsoleInteraction]
        public void clearActiveStaticFilters( )
        {
            GuiCheckBoxCtrl CBSearchMaterialsCheckBox = "CBSearchMaterialsCheckBox";
            GuiCheckBoxCtrl CBSearchParticleEmittersCheckBox = "CBSearchParticleEmittersCheckBox";
            GuiCheckBoxCtrl CBSearchScriptedMeshesCheckBox = "CBSearchScriptedMeshesCheckBox";
            GuiCheckBoxCtrl CBSearchSoundEmittersCheckBox = "CBSearchSoundEmittersCheckBox";
            GuiCheckBoxCtrl CBSearchStaticMeshesCheckBox = "CBSearchStaticMeshesCheckBox";
            GuiCheckBoxCtrl CBSearchTexturesCheckBox = "CBSearchTexturesCheckBox";

            CBSearchMaterialsCheckBox.setStateOn(false);
            CBSearchParticleEmittersCheckBox.setStateOn(false);
            CBSearchScriptedMeshesCheckBox.setStateOn(false);
            CBSearchSoundEmittersCheckBox.setStateOn(false);
            CBSearchStaticMeshesCheckBox.setStateOn(false);
            CBSearchTexturesCheckBox.setStateOn(false);
        }

        [ConsoleInteraction]
        public void loadFilter( string sortFunction, string sortCallback, bool ascending )
        {
            ArrayObject CBScheduleArray = "CBScheduleArray";
            CBDetailedTable CBDetailedTable = "CBDetailedTable";
            GuiDynamicCtrlArrayControl CBThumbnailDynamicControl = "CBThumbnailDynamicControl";
            CBSearchAutoCompleteCtrl CBSearchAutoCompleteCtrl = "CBSearchAutoCompleteCtrl";

            if(!CBScheduleArray.isObject())
                CBScheduleArray = new ObjectCreator("ArrayObject", "CBScheduleArray").Create();
   
            // if we select another list... delete all schedules that were created by 
            // previous load
            for( int i = 0; i < CBScheduleArray.count(); i++ )
                Util.cancel(CBScheduleArray.getKey(i).AsInt());
   
            // we have to empty out the list; so when we create new schedules, these dont linger
            CBScheduleArray.empty();
   
            //Clear out the children
            CBDetailedTable.clearChildren();
      
            CBThumbnailDynamicControl.deleteAllObjects();
            CBSearchAutoCompleteCtrl.clear();
            
            if( this.currentStaticFilter.count() == 0 )
                currentStaticFilter.add( (ArrayObject)"AllArray", "" );
   
            ArrayObject filteredObjectsArray = new ObjectCreator("ArrayObject").Create();
      
            int tagCount = Util.getWordCount( this["currentFilter"] );

            if( tagCount != 0 )
            {
                for( int j = 0; j < tagCount; j++ )
                {
                    for( int i = 0; i < currentStaticFilter.count(); i++ )
                    {
                        ArrayObject selectedArray = currentStaticFilter.getKey(i);
            
                        for( int k = 0; k < selectedArray.count(); k++ )
                        {
                            string currentTag = Util.getWord( this["currentFilter"], j );
                            if( selectedArray.getKey(k) == currentTag)
                                filteredObjectsArray.add( selectedArray.getKey(k), selectedArray.getValue(k) );
                        }
                    }
                }
            }
            else
            {
                // Rebuild the static filter list without tagged materials
                for( int i = 0; i < currentStaticFilter.count(); i++ )
                {
                    ArrayObject selectedArray = currentStaticFilter.getKey(i);
                    selectedArray.sorta();
         
                    for( int j = 0; j < selectedArray.count(); j++ )
                    {
                        if( selectedArray.getKey(j) != "")
                        continue;
            
                        string item = selectedArray.getValue(j);
            
                        // CustomMaterials are not available for selection
                        //if ( !isObject( %material ) || %material.isMemberOfClass( "CustomMaterial" ) )
                        //continue;
         
                        filteredObjectsArray.add( "", item );
                    }
                }
            }
   
            filteredObjectsArray.uniqueValue();
            if( sortFunction == "" )
                filteredObjectsArray.sorta();
            else
            {
                if( sortCallback != "" )
                    filteredObjectsArray.call( sortFunction, sortCallback );
                else
                    filteredObjectsArray.call( sortFunction );
         
                CBDetailedTable.setColumnSort( this.columnId, ascending );
            }
   
            int count = filteredObjectsArray.count();
   
            for( int k = 0; k < count; k++ )
            {
                string itemDetails = filteredObjectsArray.getValue(k);
                string item = Util.getField( itemDetails, 0 );
      
                string itemType = Util.getField( itemDetails, 1 );
                string functionName = Util.strreplace( itemType, " ", "" );
      
                string function = "load" + functionName + "Details";
                int schedule = this.schedule((k * 64).AsString(), function, itemDetails);
                CBScheduleArray.add( schedule.AsString(), item );
            }

            filteredObjectsArray.delete();
        }

        [ConsoleInteraction]
        public void loadStaticMeshDetails( string staticMeshDetails )
        {
            CBDetailedTable CBDetailedTable = "CBDetailedTable";
            CBSearchAutoCompleteCtrl CBSearchAutoCompleteCtrl = "CBSearchAutoCompleteCtrl";

            string previewImage = "core/art/warnmat";
   
            string staticMesh = Util.getField( staticMeshDetails, 0 );
            string staticMeshPath = Util.getField( staticMeshDetails, 2);
   
            // Remove the extension, capitalize the first letter.
            string ext = Util.fileExt( staticMesh );
            string name = Util.strreplace( staticMesh, ext, "" );
   
            name = ShapeEditor.strcapitalise(name);
            //%first = strupr( first );
            //%rem = getSubStr( %name, 1, strlen( %name ));
   
            //%name = %first @ %rem;
   
            string createCmd = "EWCreatorWindow.createStatic( \\\"" + staticMeshPath + "\\\" );";
   
            CBDetailedTable.addChildRow( name + '\t' + "Static Mesh" + '\t' + Util.getField( staticMeshDetails, 2 ), 0);
            CBSearchAutoCompleteCtrl.add( name, "0" );

            this.createContainer<CreatorStaticIconBtn>(name, "Static Mesh", previewImage, createCmd, staticMeshPath);
        }

        [ConsoleInteraction]
        public void loadScriptedMeshDetails( string scriptedMeshDetails )
        {
            CBDetailedTable CBDetailedTable = "CBDetailedTable";
            CBSearchAutoCompleteCtrl CBSearchAutoCompleteCtrl = "CBSearchAutoCompleteCtrl";

            string previewImage = "core/art/warnmat";
   
            SimObject scriptedMesh = Util.getField( scriptedMeshDetails, 0 );
   
            string name = scriptedMesh.getName();
   
            string className = scriptedMesh.getClassName();
            string cmd = className + "::create(" + name + ");";
   
            string shapePath = ( scriptedMesh["shapeFile"] != "" ) ? scriptedMesh["shapeFile"] : scriptedMesh["shapeName"];
   
            string createCmd = "EWCreatorWindow.createObject( \\\"" + cmd + "\\\" );";
   
            CBDetailedTable.addChildRow( name + '\t' + "Scripted Mesh" + '\t' + shapePath, 0);
            CBSearchAutoCompleteCtrl.add( name, "0" );

            this.createContainer<CreatorShapeIconBtn>(name, "Scripted Mesh", previewImage, createCmd, shapePath);
        }

        [ConsoleInteraction]
        public void loadParticleEmitterDetails( string particleOrEmitterDetails )
        {
            CBDetailedTable CBDetailedTable = "CBDetailedTable";
            CBSearchAutoCompleteCtrl CBSearchAutoCompleteCtrl = "CBSearchAutoCompleteCtrl";

            string previewImage = "core/art/warnmat";
   
            SimObject particleOrEmitter = Util.getField( particleOrEmitterDetails, 0 );
   
            string name = particleOrEmitter.getName();
   
            CBDetailedTable.addChildRow( name + '\t' + "Particle Emitter" + '\t' + particleOrEmitter.getFilename(), 0);
            CBSearchAutoCompleteCtrl.add( name, "0" );

            this.createContainer<ParticleEmitterButton>(name, "Particle Emitter", previewImage, "", particleOrEmitter.getFilename());
        }

        [ConsoleInteraction]
        public void loadMaterialDetails( string materialDetails )
        {
            CBDetailedTable CBDetailedTable = "CBDetailedTable";
            CBSearchAutoCompleteCtrl CBSearchAutoCompleteCtrl = "CBSearchAutoCompleteCtrl";

            string matName = "";
            string previewImage = "";
   
            SimObject material = Util.getField( materialDetails, 0 );

            // CustomMaterials are not available for selection
            if ( !material.isObject() || material.isMemberOfClass( "CustomMaterial" ) )
                return;
      
            string materialPath = material.getFilename();

            if( material.isMemberOfClass("TerrainMaterial") )
            {
                matName = material.getInternalName();

                previewImage = material["diffuseMap"] == "" ? "core/art/warnmat" : material["diffuseMap"];
            }
            else if( material["toneMap[0]"] == "" && material["diffuseMap[0]"] == "" && !material["cubemap"].isObject() )
            {
                matName = material.name;
                previewImage = "core/art/warnmat";
            }
            else
            {
                matName = material.name;
      
                if( material["toneMap[0]"] != "" )
                    previewImage = material["toneMap[0]"];
                else if( material["diffuseMap[0]"] != "" )
                    previewImage = material["diffuseMap[0]"];
                else if( ((SimObject)material["cubemap"])["cubeFace[0]"] != "" )
                    previewImage = ((SimObject)material["cubemap"])["cubeFace[0]"];
      
                // were going to use a couple of string commands in order to properly
                // find out what the img src path is 
                // **NEW** this needs to be updated with the above, but has some timing issues
                string materialDiffuse =  previewImage;
      
                if( Util.strchr( materialDiffuse, "/") == "" )
                {
                    int k = 0;
                    while( Util.strpos( materialPath, "/", k ) != -1 )
                    {
                        int foo = Util.strpos( materialPath, "/", k );
                        k = foo + 1;
                    }
      
                    string foobar = Util.getSubStr( materialPath , k , 99 );
                    previewImage = Util.strreplace( materialPath, foobar, previewImage );
                }
                else
                    previewImage = Util.strreplace( materialPath, materialPath, previewImage );
            }
   
            CBDetailedTable.addChildRow( matName + '\t' + "Material" + '\t' + materialPath, 0);
            CBSearchAutoCompleteCtrl.add( matName, "0" );

            this.createContainer<MaterialButton>(matName, "Material", previewImage, "", materialPath);
        }

        [ConsoleInteraction]
        public void displayContextMenu( string button )
        {
            ObjectCreator oc = new ObjectCreator("PopupMenu", "", typeof (ContentDropTypeMenu));
            oc["button"] = button;
         
            oc["item[0]"] = "at Origin" + '\t' + "" + '\t' + "atOrigin";
            oc["item[1]"] = "at Camera" + '\t' + "" + '\t' + "atCamera";
            //item[2] = "at Camera w/Rotation" TAB "" TAB "atCameraRot";
            //item[3] = "Below Camera" TAB "" TAB "belowCamera";
            oc["item[2]"] = "Screen Center" + '\t' + "" + '\t' + "screenCenter";
            //item[5] = "at Centroid" TAB "" TAB "atCentroid";
            //item[6] = "to Terrain" TAB "" TAB "toTerrain";
            //item[7] = "Below Selection" TAB "" TAB "belowSelection";

            ContentDropTypeMenu placeAtMenu = oc.Create();
      
            ObjectCreator oc1 = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));
            oc1["isPopup"] = "1";
            //         barTitle = "Object";
         
            oc1["item[0]"] = "Properties" + '\t' + "" + '\t' + "ContentBrowserGui.viewProperties(" + button + ");";
            oc1["item[1]"] = "Place At" + '\t' + placeAtMenu;
            oc1["item[2]"] = "-";
            oc1["item[3]"] = "Explore to" + '\t' + "" + '\t' + "ContentBrowserGui.explorePath(" + button + ");";
            oc1["item[4]"] = "Duplicate" + '\t' + "" + '\t' + "ContentBrowserGui.createDuplicate(" + button +");";
            oc1["item[5]"] = "ReImport" + '\t' + "" + '\t' + "ContentBrowserGui.reImport(" + button + ");";
            oc1["item[6]"] = "Rename" + '\t' + "" + '\t' + "ContentBrowserGui.rename(" + button + ");";

            MenuBuilder itemPopup = oc1.Create();
      
            itemPopup.showPopup( (canvas)"Canvas" );
        }

        [ConsoleInteraction]
        public void explorePath( SimObject button )
        {
            if( button["path"]  != "" )
                Util.selectFile( button["path"] );
        }

        [ConsoleInteraction]
        public void createDuplicate( SimObject button )
        {
            if( button["path"] != "" )
            {
                string path = button["path"];
                string folderSlash = Util.strrchr( path, "/" );
                string fileName = Util.strreplace( folderSlash, "/", "");
      
                string ext = Util.fileExt( fileName );
                fileName = Util.strreplace( fileName, ext, "" );
      
                string folder = Util.filePath(path);
      
                string name = folder + "/" + fileName + "_copy" + ext;
      
                Util.pathCopy( button["path"], name , true );

                this.reloadCurrentFilters( );      
      
                this.schedule("300", "loadFilter", "");
            }
        }

        [ConsoleInteraction]
        public void rename( SimObject button )
        {
            CBObjectRenameCtrl CBObjectRenameCtrl = "CBObjectRenameCtrl";

            CBObjectRenameCtrl.createRenameCtrl( button, button["tooltip"], "ContentBrowserGui.onRenameOk", "" );
        }

        [ConsoleInteraction]
        public void onRenameOk( SimObject button, string newValue )
        {
            string path = button["path"];
   
            string folderSlash = Util.strrchr( path, "/" );
   
            string folder = Util.filePath( path );
   
            string fileName = Util.strreplace( folderSlash, "/", "");
      
            if( button["contentType"] == "Static Mesh" )
            {  
                string ext = Util.fileExt( fileName );
                fileName = Util.strreplace( fileName, ext, "" );
      
                if( Util.strlwr(fileName) == Util.strlwr(newValue) )
                    return;   
      
                string name = folder + "/" + newValue + ext;
      
                Util.renameFile( button["path"], name );
            }
            else
            {
                SimObject objectFound = button["tooltip"].getID();
      
                bool nameChangeAllowed = objectFound.isNameChangeAllowed();
                objectFound.setNameChangeAllowed(true);
      
                if( Util.strlwr(objectFound.getName()) == Util.strlwr(newValue) )
                    return;
         
                int length = Util.strlen( newValue ) - Util.strlen( objectFound.getName() );
         
                FileStreamObject file = new ObjectCreator("FileStreamObject").Create();
                FileStreamObject temp = new ObjectCreator("FileStreamObject").Create();
      
                file.open(path, "read");
                temp.open(folder + "/temp.dat", "write");
      
                int lineNo = 0;
      
                int decLine = objectFound.getDeclarationLine();
      
                while( !file.isEOF() )
                {
                    string line = file.readLine();
                    lineNo += 1;
         
                    if( lineNo == decLine )
                        line = Util.strreplace( line, objectFound.getName(), newValue );
            
                    temp.writeLine(line);
         
                }
      
                file.close();
      
                temp.close();
      
                Util.deleteFile( path );
      
                Util.renameFile( folder + "/temp.dat", path );
      
                objectFound.setName( newValue );
      
                objectFound.setNameChangeAllowed( nameChangeAllowed );
            }
   
            this.reloadCurrentFilters();
   
            this.schedule("300", "loadFilter", "");
        }

        [ConsoleInteraction]
        public void viewProperties( SimObject button )
        {
            EditorGui EditorGui = "EditorGui";
            ParticleEmitterEditor.PEE_EmitterSelector_Control PEE_EmitterSelector_Control = "PEE_EmitterSelector_Control";
            GuiPopUpMenuCtrl PopUpMenu = PEE_EmitterSelector_Control.FOT("PopUpMenu");

            switch(button["contentType"])
            {
                    
                case "Material":
                    
                    MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                    if( EditorGui.currentEditor != "MaterialEditorPlugin" )
                        EditorGui.setEditor("MaterialEditorPlugin", false );
                    MaterialEditorGui.switchMaterial(button["tooltip"].getID());
                    break;
                case "Scripted Mesh":
                case "Static Mesh" :
                    ShapeEditorPlugin ShapeEditorPlugin = "ShapeEditorPlugin";
                    ShapeEditorPlugin.open(button["path"]);
                    break;
                case "Particle Emitter":
                    if( EditorGui.currentEditor != "ParticleEditorPlugin" )
                    EditorGui.setEditor("ParticleEditorPlugin", false );
            
                    PopUpMenu.setSelected( button["tooltip"].getID() );
                    break;
            }
        }

        [ConsoleInteraction]
        public void reImport( SimObject button )
        {
            Settings EditorSettings = "EditorSettings";
            string forceLoadDAE = EditorSettings.value("forceLoadDAE");
            if( button["path"] != "" )
            {
                EditorSettings.setValue( "forceLoadDAE", true.AsString() );
            }
      
            Util.eval(button["AltCommand"]);
            EditorSettings.setValue( "forceLoadDAE", forceLoadDAE );
   
        }

        [ConsoleInteraction]
        public void reloadCurrentFilters()
        {
            ArrayObject AllArray = "AllArray";
            AllArray.empty();
   
            for( int i = 0; i < currentStaticFilter.count(); i++ )
            {
                ArrayObject selectedArray = currentStaticFilter.getKey(i);
                switch(selectedArray.getName() )
                {
                    case "MaterialAllArray":
                        this.buildMaterialFilters();
                        break;
                    case "ParticleEmittersArray":
                        this.buildParticleEmitterFilters();
                        break;
                    case "ScriptedMeshArray":
                        this.buildScriptedMeshFilters();
                        break;
                    case "SoundEmittersArray":
                        Util._echo("Sound");
                        break;
                    case "StaticMeshArray":
                        this.buildStaticMeshFilters();
                        break;
                    case "TexturesArray":
                        Util._echo("Texture");
                        break;
                }
            }
   
        }

        //[ConsoleInteraction]
        public void createContainer<T>( string name, string contentType, string previewImage, string command, string path )
        {
            // it may seem goofy why the checkbox can't be instanciated inside the container
            // reason being its because we need to store the checkbox ctrl in order to make changes
            // on it later in the function. 

            #region GuiControl ()        oc_Newobject6
            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "");
            oc_Newobject6["profile"] = "ToolsGuiDefaultProfile" ;
            oc_Newobject6["Position"] = "0 0" ;
            oc_Newobject6["Extent"] = "150 150" ;
            oc_Newobject6["HorizSizing"] = "right" ;
            oc_Newobject6["VertSizing"] = "bottom" ;
            oc_Newobject6["isContainer"] = "1" ;

            #region GuiTextCtrl ()        oc_Newobject5
            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["position"] = "20 130" ;
            oc_Newobject5["profile"] = "ToolsGuiTextCenterProfile" ;
            oc_Newobject5["extent"] = "100 16" ;
            oc_Newobject5["text"] = name;
            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion
            GuiControl container = oc_Newobject6.Create();

            #region GuiBitmapButtonCtrl ()        oc_Newobject8
            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["internalName"] = name ;
            oc_Newobject8["HorizSizing"] = "right" ;
            oc_Newobject8["VertSizing"] = "bottom" ;
            oc_Newobject8["profile"] = "ToolsGuiButtonProfile" ;
            oc_Newobject8["position"] = "7 4" ;
            oc_Newobject8["extent"] = "125 125" ;
            oc_Newobject8["buttonType"] = "PushButton" ;
            oc_Newobject8["bitmap"] = "" ;
            oc_Newobject8["Command"] = "" ;
            oc_Newobject8["bitmap"] = previewImage ;
            oc_Newobject8["useStates"] = new ObjectCreator.StringNoQuote ("false") ;

            #region GuiBitmapButtonCtrl ()        oc_Newobject7
            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject7["HorizSizing"] = "right" ;
            oc_Newobject7["VertSizing"] = "bottom" ;
            oc_Newobject7["profile"] = "ToolsGuiButtonProfile" ;
            oc_Newobject7["position"] = "0 0" ;
            oc_Newobject7["extent"] = "125 125" ;
            oc_Newobject7["Variable"] = "" ;
            oc_Newobject7["buttonType"] = "toggleButton" ;
            oc_Newobject7["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder" ;
            oc_Newobject7["groupNum"] = "0" ;
            oc_Newobject7["text"] = "" ;
            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion
            GuiBitmapButtonCtrl previewButton = oc_Newobject8.Create();

            #region GuiButtonCtrl ()        oc_Newobject9
            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiButtonCtrl", "", typeof(T));
            oc_Newobject9["internalName"] = name+ "Border";
            oc_Newobject9["HorizSizing"] = "right" ;
            oc_Newobject9["VertSizing"] = "bottom" ;
            oc_Newobject9["profile"] = "ToolsGuiThumbHighlightButtonProfile";
            oc_Newobject9["position"] = "3 0" ;
            oc_Newobject9["extent"] = "133 150" ;
            oc_Newobject9["Variable"] = "" ;
            oc_Newobject9["buttonType"] = "toggleButton" ;
            oc_Newobject9["tooltip"] = name;
            oc_Newobject9["Command"] = "ContentBrowserGui.updateSelection( $ThisControl.getParent().getObject(1).internalName );" ;
            oc_Newobject9["path"] = path;
            oc_Newobject9["AltCommand"] = command;
            oc_Newobject9["contentType"] = contentType;
            oc_Newobject9["groupNum"] = "0" ;
            oc_Newobject9["useMouseEvents"] = "1" ;
            //oc_Newobject9["class"] = className;
            oc_Newobject9["text"] = "" ;
            #endregion
            GuiButtonCtrl previewBorder = oc_Newobject9.Create();
   
            container.add(previewButton);  
            container.add(previewBorder); 
   
            // add to the gui control array
            GuiDynamicCtrlArrayControl CBThumbnailDynamicControl = "CBThumbnailDynamicControl";
            CBThumbnailDynamicControl.add(container);
        }

        [ConsoleInteraction]
        public void updateSelection( string item )
        {
            GuiDynamicCtrlArrayControl CBThumbnailDynamicControl = "CBThumbnailDynamicControl";
            GuiScrollCtrl CBThumbnailScroll = "CBThumbnailScroll";
            CBDetailedTable CBDetailedTable = "CBDetailedTable";

            GuiButtonCtrl control = CBThumbnailDynamicControl.findObjectByInternalName( item + "Border", true );
            control.setStateOn();
            CBThumbnailScroll.scrollToObject(control.getParent());
            if( sGlobal["$lastItemSelected"] != "" )
                ((GuiButtonCtrl)CBThumbnailDynamicControl.findObjectByInternalName( sGlobal["$lastItemSelected"] + "Border", true )).setStateOn(false);
   
            CBDetailedTable.selectRow( item );
   
            sGlobal["$lastItemSelected"] = item;
        }

        [ConsoleInteraction]
        public void buildStaticMeshFilters( )
        {
            ArrayObject StaticMeshArray = "StaticMeshArray";
            ArrayObject AllArray = "AllArray";

            if( !StaticMeshArray.isObject() )
                StaticMeshArray = new ObjectCreator("ArrayObject","StaticMeshArray").Create();
            else
                StaticMeshArray.empty();
   
            string fullPath = Util.findFirstFileMultiExpr( "*.dts" + '\t' + "*.dae" + '\t' + "*.kmz" + '\t' + "*.dif" );
      
            while ( fullPath != "" )
            {
                if (Util.strstr(fullPath, "cached.dts") != -1)
                {
                    fullPath = Util.findNextFileMultiExpr( "*.dts" + '\t' + "*.dae" + '\t' + "*.kmz"  + '\t' + "*.dif" );
                    continue;
                }

                fullPath = Util.makeRelativePath( fullPath, Util.getMainDotCsDir() );                                  
                string splitPath = Util.strreplace( fullPath, "/", " " );     
                if( Util.getWord(splitPath, 0) == "tools" )
                {
                    fullPath = Util.findNextFileMultiExpr( "*.dts" + '\t' + "*.dae" + '\t' + "*.kmz"  + '\t' + "*.dif" );
                    continue;
                }
      
                string name = Util.getWord( splitPath, ( Util.getWordCount( splitPath ) - 1 ));
                name = Util.strlwr( name );
      
                StaticMeshArray.add( "", name + '\t' + "Static Mesh" + '\t' + fullPath );
                AllArray.add( "", name + '\t' + "Static Mesh" + '\t' + fullPath);     
      
                fullPath = Util.findNextFileMultiExpr( "*.dts" + '\t' + "*.dae" + '\t' + "*.kmz" + '\t' + "*.dif" );
            }
        }

        [ConsoleInteraction]
        public void buildParticleEmitterFilters( )
        {
            ArrayObject ParticleEmittersArray = "ParticleEmittersArray";
            ArrayObject ParticleArray = "ParticleArray";
            ArrayObject AllArray = "AllArray";

            if( !ParticleEmittersArray.isObject() )
                ParticleEmittersArray = new ObjectCreator("ArrayObject","ParticleEmittersArray").Create();
            else
                ParticleEmittersArray.empty();

            if( !ParticleArray.isObject() )
                ParticleArray = new ObjectCreator("ArrayObject", "ParticleArray").Create();
            else
                ParticleArray.empty();
            
            SimGroup DatablockGroup = "DatablockGroup";

            for(uint i = 0; i< DatablockGroup.getCount(); i++)
            {
                SimObject obj = DatablockGroup.getObject(i);
                if( obj.isMemberOfClass( "ParticleEmitterData" ) )
                {
                    // Filter out emitters on the PE_UnlistedEmitters list.
         
                    bool unlistedFound = false;
                    SimSet PE_UnlistedEmitters = "PE_UnlistedEmitters";
                    for (uint j = 0; j < PE_UnlistedEmitters.getCount(); j++)
                    {
                        SimObject unlisted = PE_UnlistedEmitters.getObject(i);
                        if( unlisted.getId() == obj.getId() )
                        {
                            unlistedFound = true;
                            break;
                        }
                    }
                    
      
                    if( unlistedFound )
                        continue;
            
                    // To prevent our default emitters from getting changed,
                    // prevent them from populating the list. Default emitters
                    // should only be used as a template for creating new ones.
                    if ( obj.getName() == "DefaultEmitter")
                        continue;
         
                    ParticleEmittersArray.add( "", obj.getName() + '\t' + "Particle Emitter" + '\t' + obj.getFilename() );
                    AllArray.add("", obj.getName() + '\t' + "Particle Emitter" + '\t' + obj.getFilename() );
                }
                else if( obj.isMemberOfClass( "ParticleData" ) )
                {
                    bool unlistedFound = false;

                    SimSet PE_UnlistedParticles = "PE_UnlistedParticles";
                    for (uint j = 0; j < PE_UnlistedParticles.getCount(); j++)
                    {
                        SimObject unlisted = PE_UnlistedParticles.getObject(i);
                        if (unlisted.getId() == obj.getId() )
                        {
                            unlistedFound = true;
                            break;
                        }
                    }

                    if( unlistedFound )
                        continue;
            
                    string name = obj.getName();
                    int id = obj.getId();
         
                    if ( name == "DefaultParticle")
                        continue;

                    ParticleArray.add( "", name + '\t' + "Particle Emitter" + '\t' + obj.getFilename() );
                    AllArray.add("", name + '\t' + "Particle Emitter" + '\t' + obj.getFilename() );
                }
            }
        }

        [ConsoleInteraction]
        public void buildScriptedMeshFilters( )
        {
            ArrayObject ScriptedMeshArray = "ScriptedMeshArray";
            ArrayObject AllArray = "AllArray";

            if( !ScriptedMeshArray.isObject())
                ScriptedMeshArray = new ObjectCreator("ArrayObject", "ScriptedMeshArray").Create();
            else
                ScriptedMeshArray.empty();
   
            SimGroup dataGroup = "DataBlockGroup";
      
            for ( uint i = 0; i < dataGroup.getCount(); i++ )
            {
                SimObject obj = dataGroup.getObject(i);
                // echo ("Obj: " @ %obj.getName() @ " - " @ %obj.category );
      
                if ( obj["category"] == "" && obj["category"] == "0" )
                    continue;
      
                string shapePath = ( obj["shapeFile"] != "" ) ? obj["shapeFile"] : obj["shapeName"];
      
                ScriptedMeshArray.add( "", obj.name + '\t' + "Scripted Mesh" + '\t' + shapePath );
                AllArray.add( "", obj.name + '\t' + "Scripted Mesh" + '\t' + shapePath );
            }
        }

        [ConsoleInteraction]
        public void buildMaterialFilters( )
        {
            ArrayObject MaterialAllArray = "MaterialAllArray";
            ArrayObject MaterialMappedArray = "MaterialMappedArray";
            ArrayObject MaterialUnmappedArray = "MaterialUnmappedArray";
            ArrayObject AllArray = "AllArray";

            if( !MaterialAllArray.isObject() )
                MaterialAllArray = new ObjectCreator("ArrayObject","MaterialAllArray").Create();
            else
                MaterialAllArray.empty();

            if( !MaterialMappedArray.isObject() )
                MaterialMappedArray = new ObjectCreator("ArrayObject", "MaterialMappedArray").Create();
            else
                MaterialMappedArray.empty();

            if( !MaterialUnmappedArray.isObject() )
                MaterialUnmappedArray = new ObjectCreator("ArrayObject", "MaterialUnmappedArray").Create();
            else
                MaterialUnmappedArray.empty();
      
            string mats = "";
            int count = 0;

            MaterialSelector MaterialSelector = "MaterialSelector";
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            SimSet MaterialSet = "MaterialSet";
            if( MaterialSelector.terrainMaterials )
            {
                mats = ETerrainEditor.getTerrainBlocksMaterialList();
                count = Util.getRecordCount( mats );
            }
            else
            {
                count = MaterialSet.getCount();
            }

            SimSet TerrainMaterialSet = "TerrainMaterialSet";
            SimObject material = "";
            string materialPath = "";

            for(int i = 0; i < count; i++)
            {
                // Process terrain materials
                if( MaterialSelector.terrainMaterials )
                {
                    string matInternalName = Util.getRecord( mats, i );
                    material = TerrainMaterialSet.findObjectByInternalName( matInternalName );
         
                    // Is there no material info for this slot?
                    if ( !material.isObject() )
                        continue;
            
                    materialPath = material.getFilename();
         
                    // Add to the appropriate filters
                    MaterialMappedArray.add( "", material + '\t' + "Material" + '\t' + materialPath );
                    MaterialAllArray.add( "", material + '\t' + "Material" + '\t' + materialPath );
                    AllArray.add("", material + '\t' + "Material" + '\t' + materialPath);
         
                    continue;
                }

                // Process regular materials here
                material = MaterialSet.getObject((uint)i);
                ArrayObject UnlistedMaterials = "UnlistedMaterials";
                bool unlistedFound = false;
                for( int k = 0; k < UnlistedMaterials.count(); k++ )
                {
                    unlistedFound = false;
                    if( UnlistedMaterials.getValue(k) == material.name )
                    {
                        unlistedFound = true;
                        break;
                    }
                }
      
                if( unlistedFound )
                    continue;
         
                materialPath = material.getFilename();
      
                if( material["mapTo"] == "" || material["mapTo"] == "unmapped_mat" )
                {
                    MaterialUnmappedArray.add( "", material.name + '\t' + "Material" + '\t' + materialPath );
                    //running through the existing tag names
                    for( int j = 0; material.getFieldValue("materialTag" + j) != ""; j++ )
                        MaterialUnmappedArray.add( material.getFieldValue("materialTag" + j), material.name + '\t' + "Material" + '\t' + materialPath );
                }
                else
                {
                    MaterialMappedArray.add( "", material.name + '\t' + "Material" + '\t' + materialPath );
                    for( int j = 0; material.getFieldValue("materialTag" + j) != ""; j++ )
                        MaterialMappedArray.add( material.getFieldValue("materialTag" + j), material.name + '\t' + "Material" + '\t' + materialPath );
                }
      
                MaterialAllArray.add( "", material.name + '\t' + "Material" + '\t' + materialPath );
                AllArray.add("", material.name + '\t' + "Material" + '\t' + materialPath );
                for( int j = 0; material.getFieldValue("materialTag" + j) != ""; j++ )
                {
                    MaterialAllArray.add( material.getFieldValue("materialTag" + j), material.name + '\t' + "Material" + '\t' + materialPath );
                    AllArray.add( material.getFieldValue("materialTag" + j), material.name + '\t' + "Material" + '\t' + materialPath );
                }
            }
        }

        [ConsoleInteraction(true)]
        public override void onWake()
        {
            GuiFrameSetCtrl CBRightFrameSet = "CBRightFrameSet";
            GuiFrameSetCtrl CBLeftFrameSet = "CBLeftFrameSet";
            CBDetailedTable CBDetailedTable = "CBDetailedTable";

            CBRightFrameSet.frameMinExtent( 0, 702, 230);
            CBRightFrameSet.frameMinExtent( 1, 702, 100);
            CBRightFrameSet.frameMinExtent( 2, 702, 150);
   
            CBLeftFrameSet.frameMinExtent( 0, 150, 230);
            CBLeftFrameSet.frameMinExtent( 2, 150, 230);
   
            CBDetailedTable.addHeading( "Name" + '\t' + "Type" + '\t' + "Location", 0 );
   
            currentStaticFilter = new ObjectCreator("ArrayObject").Create();
            new ObjectCreator("ArrayObject","AllArray").Create();
   
            buildMaterialFilters();
            buildParticleEmitterFilters();
            buildScriptedMeshFilters();
            buildStaticMeshFilters();

            GuiCheckBoxCtrl CBSearchAllCheckBox = "CBSearchAllCheckBox";
            CBSearchAllCheckBox.setStateOn(true);
            setStaticFilter(CBSearchAllCheckBox.getText(), CBSearchAllCheckBox.isStateOn());
        }

        [ConsoleInteraction]
        public override void onSleep()
        {
            ArrayObject MaterialAllArray = "MaterialAllArray";
            ArrayObject MaterialMappedArray = "MaterialMappedArray";
            ArrayObject MaterialUnmappedArray = "MaterialUnmappedArray";
            ArrayObject ParticleArray = "ParticleArray";
            ArrayObject ParticleEmittersArray = "ParticleEmittersArray";
            ArrayObject ScriptedMeshArray = "ScriptedMeshArray";
            ArrayObject StaticMeshArray = "StaticMeshArray";
            ArrayObject AllArray = "AllArray";
            GuiScrollCtrl CBDetailedInfo = "CBDetailedInfo";
            GuiObjectView CBObjectView = "CBObjectView";
            GuiCheckBoxCtrl CBSearchAllCheckBox = "CBSearchAllCheckBox";
            ArrayObject CBScheduleArray = "CBScheduleArray";
            CBDetailedTable CBDetailedTable = "CBDetailedTable";
            GuiDynamicCtrlArrayControl CBThumbnailDynamicControl = "CBThumbnailDynamicControl";
            CBSearchAutoCompleteCtrl CBSearchAutoCompleteCtrl = "CBSearchAutoCompleteCtrl";

            clearActiveStaticFilters();
   
            //CBHeadingTextList.removeRowById( 0 );
   
            //Materials Array Deletion
            if( MaterialAllArray.isObject() )
                MaterialAllArray.delete();
            if( MaterialMappedArray.isObject() )
                MaterialMappedArray.delete();
            if( MaterialUnmappedArray.isObject() )
                MaterialUnmappedArray.delete();
   
            //ParticleEmitters Array Deletion
            if( ParticleArray.isObject() )
                ParticleArray.delete();
            if( ParticleEmittersArray.isObject() )   
                ParticleEmittersArray.delete();
   
            //ScriptedMeshes Array Deletion
            if( ScriptedMeshArray.isObject() )
                ScriptedMeshArray.delete();
   
            //StaticMeshes Array Deletion
            if( StaticMeshArray.isObject() )
                StaticMeshArray.delete();
   
            //All array deletion
            if( AllArray.isObject() )
                AllArray.delete();
      
            CBDetailedInfo.visible = false;
            CBObjectView.shapeFile = "";
   
            //Current Static filter Deletion
            if( currentStaticFilter.isObject() )
                currentStaticFilter.delete();
      
            clearActiveStaticFilters();
            CBSearchAllCheckBox.setStateOn(false);
      
            if( CBScheduleArray.isObject() )
            {
                for( int i = 0; i < CBScheduleArray.count(); i++ )
                Util.cancel(CBScheduleArray.getKey(i).AsInt());
      
                // we have to empty out the list; so when we create new schedules, these dont linger
                CBScheduleArray.empty();
            }
            //Clear out the children
            CBDetailedTable.clearChildren();
      
            CBThumbnailDynamicControl.deleteAllObjects();
            CBSearchAutoCompleteCtrl.clear();
        }

        [ConsoleInteraction]
        public static int sortArrayAscending( string itemA, string itemB )
        {
            ContentBrowserGui ContentBrowserGui = "ContentBrowserGui";
            return omni.Util.strcmp( omni.Util.getField( itemB, ContentBrowserGui.columnId ), omni.Util.getField( itemA, ContentBrowserGui.columnId ) );
        }

        [ConsoleInteraction]
        public static int sortArrayDescending( string itemA, string itemB )
        {
            ContentBrowserGui ContentBrowserGui = "ContentBrowserGui";

            return omni.Util.strcmp( omni.Util.getField( itemB, ContentBrowserGui.columnId ), omni.Util.getField( itemA, ContentBrowserGui.columnId ) );
        }

        [TypeConverter(typeof (TypeConverterGeneric<CBDetailedTable>))]
        public class CBDetailedTable : GuiTableControl
        {
            [ConsoleInteraction]
            public override void onSortedColumn(int columnId, string columnName, bool increasing)
            {
                ContentBrowserGui ContentBrowserGui = "ContentBrowserGui";

                if( increasing )
                {
                    ContentBrowserGui.columnId = columnId;
                    ContentBrowserGui.loadFilter( "sortf", "sortArrayAscending", true );
                }
                else
                {
                ContentBrowserGui.columnId = columnId;
                ContentBrowserGui.loadFilter( "sortfd", "sortArrayDescending", false );
                }
            }

            [ConsoleInteraction]
            public override void onSelect(string cellId, string cellValue)
            {
                GuiDynamicCtrlArrayControl CBThumbnailDynamicControl = "CBThumbnailDynamicControl";
                GuiButtonCtrl button = CBThumbnailDynamicControl.findObjectByInternalName( Util.getField( cellValue, 0 ) + "Border", true );
                button.performClick();
                //echo(%cellId SPC %cellValue);
            }

            [ConsoleInteraction]
            public void selectRow( string item )
            {
                if( item != "" )
                {
                    int row = findColumnTextIndex(0, item);
                    if( getSelectedRow() != row )
                        setSelectedRow( row );
                }
            }

            #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(CBDetailedTable ts, string simobjectid)
                    {
                    return object.ReferenceEquals(ts, null)
                        ? object.ReferenceEquals(simobjectid, null)
                        : ts.Equals(simobjectid);
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
                public static bool operator !=(CBDetailedTable ts, string simobjectid)
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
                public static implicit operator string(CBDetailedTable ts)
                    {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator CBDetailedTable(string ts)
                    {
                    uint simobjectid = resolveobject(ts);
                    return (CBDetailedTable) Omni.self.getSimObject(simobjectid, typeof (CBDetailedTable));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(CBDetailedTable ts)
                    {
                    return (int) ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator CBDetailedTable(int simobjectid)
                    {
                    return
                        (CBDetailedTable) Omni.self.getSimObject((uint) simobjectid, typeof (CBDetailedTable));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(CBDetailedTable ts)
                    {
                    return ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator CBDetailedTable(uint simobjectid)
                    {
                    return (CBDetailedTable) Omni.self.getSimObject(simobjectid, typeof (CBDetailedTable));
                    }

                #endregion
        }

        [TypeConverter(typeof(TypeConverterGeneric<CBSearchAutoCompleteCtrl>))]
        public class CBSearchAutoCompleteCtrl : GuiAutoCompleteCtrl
        {
            [ConsoleInteraction]
            public override void onReturn()
            {
                CBDetailedTable CBDetailedTable = "CBDetailedTable";

                CBDetailedTable.selectRow( this.text );
            }

            #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(CBSearchAutoCompleteCtrl ts, string simobjectid)
                    {
                    return object.ReferenceEquals(ts, null)
                        ? object.ReferenceEquals(simobjectid, null)
                        : ts.Equals(simobjectid);
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
                public static bool operator !=(CBSearchAutoCompleteCtrl ts, string simobjectid)
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
                public static implicit operator string(CBSearchAutoCompleteCtrl ts)
                    {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator CBSearchAutoCompleteCtrl(string ts)
                    {
                    uint simobjectid = resolveobject(ts);
                    return (CBSearchAutoCompleteCtrl) Omni.self.getSimObject(simobjectid, typeof (CBSearchAutoCompleteCtrl));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(CBSearchAutoCompleteCtrl ts)
                    {
                    return (int) ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator CBSearchAutoCompleteCtrl(int simobjectid)
                    {
                    return
                        (CBSearchAutoCompleteCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (CBSearchAutoCompleteCtrl));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(CBSearchAutoCompleteCtrl ts)
                    {
                    return ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator CBSearchAutoCompleteCtrl(uint simobjectid)
                    {
                    return (CBSearchAutoCompleteCtrl) Omni.self.getSimObject(simobjectid, typeof (CBSearchAutoCompleteCtrl));
                    }

                #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<CBLibraryTreeView>))]
        public class CBLibraryTreeView : GuiFileTreeCtrl
        {
            [ConsoleInteraction]
            public override void onSelectPath(string fullPath)
            {
                GuiObjectView CBObjectView = "CBObjectView";
                GuiScrollCtrl CBDetailedInfo = "CBDetailedInfo";
                GuiTextCtrl CBDetailedInfoSize = "CBDetailedInfoSize";
                GuiTextCtrl CBDetailedInfoCreationDate = "CBDetailedInfoCreationDate";
                GuiTextCtrl CBDetailedInfoLastModified = "CBDetailedInfoLastModified";

                if( Util.isFile(fullPath) )
                {
                    string ext = Util.fileExt( fullPath );
                    ext = Util.strlwr( ext );
      
                    if( ext == ".dts" || ext == ".dae" )
                        CBObjectView.shapeFile = fullPath;
         
                    CBDetailedInfo.visible = true;
                    CBDetailedInfoSize.text = Util.fileSize( fullPath ) / 1000.0 + " KB";
                    CBDetailedInfoCreationDate.text =  Util.fileCreatedTime( fullPath );
                    CBDetailedInfoLastModified.text =  Util.fileModifiedTime( fullPath );
                }
                else
                {
                    CBDetailedInfo.visible = false;
                }
            }

            [ConsoleInteraction]
            public override void onDblClick(string fullPath)
            {
                if( bGlobal["$missionRunning"] && !bGlobal["$InGuiEditor"])
                {
                   
                    if( WinterLeaf.Demo.Full.Models .User.Extendable.GuiCanvas.EditorIsActive() )
                    {
                        string createCmd = "EWCreatorWindow.createStatic( \\\"" + fullPath + "\\\" );";
                        string command = "ColladaImportDlg.showDialog( \"" + fullPath + "\", \"" + createCmd + "\" );";
                        Util.eval(command);
                    }
                }
            }

            #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(CBLibraryTreeView ts, string simobjectid)
                    {
                    return object.ReferenceEquals(ts, null)
                        ? object.ReferenceEquals(simobjectid, null)
                        : ts.Equals(simobjectid);
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
                public static bool operator !=(CBLibraryTreeView ts, string simobjectid)
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
                public static implicit operator string(CBLibraryTreeView ts)
                    {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator CBLibraryTreeView(string ts)
                    {
                    uint simobjectid = resolveobject(ts);
                    return (CBLibraryTreeView) Omni.self.getSimObject(simobjectid, typeof (CBLibraryTreeView));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(CBLibraryTreeView ts)
                    {
                    return (int) ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator CBLibraryTreeView(int simobjectid)
                    {
                    return
                        (CBLibraryTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (CBLibraryTreeView));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(CBLibraryTreeView ts)
                    {
                    return ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator CBLibraryTreeView(uint simobjectid)
                    {
                    return (CBLibraryTreeView) Omni.self.getSimObject(simobjectid, typeof (CBLibraryTreeView));
                    }

                #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ContentDropTypeMenu>))]
        public class ContentDropTypeMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override bool onSelectItem(string id, string text)
            {
                EWorldEditor EWorldEditor = "EWorldEditor";

                // This sets up which drop script function to use when
                // a drop type is selected in the menu.
   
                TypeWorldEditorDropType dropType = EWorldEditor.dropType;
   
                EWorldEditor.dropType = Util.getField(this["item[" + id + "]"], 2);
   
                Util.eval(((GuiButtonCtrl)this["button"]).altCommand);
   
                EWorldEditor.dropType = dropType;
   
                return true;
            }

            #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(ContentDropTypeMenu ts, string simobjectid)
                    {
                    return object.ReferenceEquals(ts, null)
                        ? object.ReferenceEquals(simobjectid, null)
                        : ts.Equals(simobjectid);
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
                public static bool operator !=(ContentDropTypeMenu ts, string simobjectid)
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
                public static implicit operator string(ContentDropTypeMenu ts)
                    {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator ContentDropTypeMenu(string ts)
                    {
                    uint simobjectid = resolveobject(ts);
                    return (ContentDropTypeMenu) Omni.self.getSimObject(simobjectid, typeof (ContentDropTypeMenu));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(ContentDropTypeMenu ts)
                    {
                    return (int) ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator ContentDropTypeMenu(int simobjectid)
                    {
                    return
                        (ContentDropTypeMenu) Omni.self.getSimObject((uint) simobjectid, typeof (ContentDropTypeMenu));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(ContentDropTypeMenu ts)
                    {
                    return ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator ContentDropTypeMenu(uint simobjectid)
                    {
                    return (ContentDropTypeMenu) Omni.self.getSimObject(simobjectid, typeof (ContentDropTypeMenu));
                    }

                #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ParticleEmitterButton>))]
        public class ParticleEmitterButton : GuiButtonCtrl
        {
            [ConsoleInteraction]
            public override void onRightClick()
            {
                ContentBrowserGui ContentBrowserGui = "ContentBrowserGui";

                ContentBrowserGui.displayContextMenu(this);
            }

            #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(ParticleEmitterButton ts, string simobjectid)
                    {
                    return object.ReferenceEquals(ts, null)
                        ? object.ReferenceEquals(simobjectid, null)
                        : ts.Equals(simobjectid);
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
                public static bool operator !=(ParticleEmitterButton ts, string simobjectid)
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
                public static implicit operator string(ParticleEmitterButton ts)
                    {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator ParticleEmitterButton(string ts)
                    {
                    uint simobjectid = resolveobject(ts);
                    return (ParticleEmitterButton) Omni.self.getSimObject(simobjectid, typeof (ParticleEmitterButton));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(ParticleEmitterButton ts)
                    {
                    return (int) ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator ParticleEmitterButton(int simobjectid)
                    {
                    return
                        (ParticleEmitterButton) Omni.self.getSimObject((uint) simobjectid, typeof (ParticleEmitterButton));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(ParticleEmitterButton ts)
                    {
                    return ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator ParticleEmitterButton(uint simobjectid)
                    {
                    return (ParticleEmitterButton) Omni.self.getSimObject(simobjectid, typeof (ParticleEmitterButton));
                    }

                #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<MaterialButton>))]
        public class MaterialButton : GuiButtonCtrl
        {
            [ConsoleInteraction]
            public override void onMouseDragged()
            {
                this.setCur();
                string matName = this["toolTip"];
                string bitmap = ((SimObject)((SimSet)this.getParent()).findObjectByInternalName(matName))["bitmap"];
            }

            [ConsoleInteraction]
            public override void onRightClick()
            {
                ContentBrowserGui ContentBrowserGui = "ContentBrowserGui";
                ContentBrowserGui.displayContextMenu(this);
            }

            [ConsoleInteraction]
            public override void onMouseUp()
            {
                Point2I screenPos = ((GuiCanvas)this.getRoot()).getCursorPos();
                ((GuiCanvas)this.getRoot()).clearFirstResponder();
                
                canvas Canvas = "Canvas";
                string clientPos = Canvas.screenToClient(screenPos).AsString();
   
                bool ret = isMainCanvas( this.getRoot(), screenPos.AsString() );
                if( !ret )
                    return;
   
                GuiControl ctrl = Canvas.findHitControl(Util.getWord(clientPos,0).AsInt(), Util.getWord(clientPos,1).AsInt());
                if( ctrl.isInNamespaceHierarchy( "EditTSCtrl" ) )
                {
                    GameConnection ServerConnection = "ServerConnection";

                    string control = ServerConnection.getControlObject();
                    string fvec = ((EditTSCtrl)ctrl).getClickVector( clientPos.AsPoint2I() );
      
                    string start = ((EditTSCtrl)ctrl).getWorldPosition(clientPos.AsPoint2I());
      
                    string end = Util.VectorAdd( start.AsPoint3F(), Util.VectorScale( fvec.AsPoint3F(), 30 ) ).AsString();
      
                    string result = Util.containerRayCast(start.AsPoint3F(), end.AsPoint3F(),
                        (uint)(iGlobal["$TypeMasks::GameBaseObjectType"] | iGlobal["$TypeMasks::ShapeBaseObjectType"] | iGlobal["$TypeMasks::StaticObjectType"]),
                    control, true);
            
                    if (Util.getWordCount(result) > 0 && Util.getWord(result, 0) != "0")
                    {
                        SimObject objectFound = Util.getWord(result, 0 );

                        Inspector Inspector = "Inspector";
                        //Inspector.inspect(%object);
                        //eval( "" @ %object @".Material = " @ %this.toolTip @ ";" ); 
                        Inspector.setObjectField("material", this["toolTip"]);
                        Inspector.apply();
                        Inspector.refresh();
                    }
                }
                this.resetCur();
            }

            #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(MaterialButton ts, string simobjectid)
                    {
                    return object.ReferenceEquals(ts, null)
                        ? object.ReferenceEquals(simobjectid, null)
                        : ts.Equals(simobjectid);
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
                public static bool operator !=(MaterialButton ts, string simobjectid)
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
                public static implicit operator string(MaterialButton ts)
                    {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator MaterialButton(string ts)
                    {
                    uint simobjectid = resolveobject(ts);
                    return (MaterialButton) Omni.self.getSimObject(simobjectid, typeof (MaterialButton));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(MaterialButton ts)
                    {
                    return (int) ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator MaterialButton(int simobjectid)
                    {
                    return
                        (MaterialButton) Omni.self.getSimObject((uint) simobjectid, typeof (MaterialButton));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(MaterialButton ts)
                    {
                    return ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator MaterialButton(uint simobjectid)
                    {
                    return (MaterialButton) Omni.self.getSimObject(simobjectid, typeof (MaterialButton));
                    }

                #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<CreatorShapeIconBtn>))]
        public class CreatorShapeIconBtn : GuiButtonCtrl
        {
            [ConsoleInteraction]
            public override void onMouseDragged()
            {        
                this.setCur();
            }

            [ConsoleInteraction]
            public override void onMouseUp()
            {
                canvas Canvas = "Canvas";

                Point2I screenPos = ((GuiCanvas)this.getRoot()).getCursorPos();
   
                string clientPos = Canvas.screenToClient(screenPos).AsString();
   
                bool ret = isMainCanvas( this.getRoot(), screenPos.AsString() );
                if( !ret )
                    return;
   
                ((GuiCanvas)this.getRoot()).clearFirstResponder();
   
   
                //%ctrl = Canvas.getFirstResponder();
                GuiControl ctrl = Canvas.findHitControl(Util.getWord(clientPos,0).AsInt(), Util.getWord(clientPos,1).AsInt());
                if( ctrl.isInNamespaceHierarchy( "EditTSCtrl" ) )
                {
                    GameConnection ServerConnection = "ServerConnection";

                    SimObject control = ServerConnection.getControlObject();
      
                    //%fvec = "0 1 0";
                    //%fvec = %control.getEyeVector();
                    string fvec = ((EditTSCtrl)ctrl).getClickVector( clientPos.AsPoint2I() );
      
                    //%start = %ctrl.unproject(%clientPos SPC "0" );
                    string start = ((EditTSCtrl)ctrl).getWorldPosition(clientPos.AsPoint2I());
      
                    Point3F end = Util.VectorAdd( start.AsPoint3F(), Util.VectorScale( fvec.AsPoint3F(), 30 ) );
      
                    string result = Util.containerRayCast(start.AsPoint3F(), end,
                    (uint)(iGlobal["$TypeMasks::GameBaseObjectType"] | iGlobal["$TypeMasks::ShapeBaseObjectType"] | iGlobal["$TypeMasks::StaticObjectType"]),
                    control, true);
            
                    if (Util.getWordCount(result) > 0 && Util.getWord(result, 0) != "0")
                    {
                        string posX = Util.getWord(result, 1);
                        string posY = Util.getWord(result, 2);
                        string posZ = Util.getWord(result, 3);

                        SimObject id = ((ColladaImportDlg)"ColladaImportDlg").showDialog(this["path"], altCommand);

                        //SimObject id = Util.eval(cmd);         
         
                        //%id.setPosition(%posX SPC %posY SPC %posZ);
         
                        id.call("setTransform", posX + " " + posY + " " + posZ + " " + "1 0 0 0" );
                    }
                }
                this.resetCur();
            }

            [ConsoleInteraction]
            public override void onRightClick()
            {
                ContentBrowserGui ContentBrowserGui = "ContentBrowserGui";

                ContentBrowserGui.displayContextMenu(this);
            }

            #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(CreatorShapeIconBtn ts, string simobjectid)
                    {
                    return object.ReferenceEquals(ts, null)
                        ? object.ReferenceEquals(simobjectid, null)
                        : ts.Equals(simobjectid);
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
                public static bool operator !=(CreatorShapeIconBtn ts, string simobjectid)
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
                public static implicit operator string(CreatorShapeIconBtn ts)
                    {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator CreatorShapeIconBtn(string ts)
                    {
                    uint simobjectid = resolveobject(ts);
                    return (CreatorShapeIconBtn) Omni.self.getSimObject(simobjectid, typeof (CreatorShapeIconBtn));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(CreatorShapeIconBtn ts)
                    {
                    return (int) ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator CreatorShapeIconBtn(int simobjectid)
                    {
                    return
                        (CreatorShapeIconBtn) Omni.self.getSimObject((uint) simobjectid, typeof (CreatorShapeIconBtn));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(CreatorShapeIconBtn ts)
                    {
                    return ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator CreatorShapeIconBtn(uint simobjectid)
                    {
                    return (CreatorShapeIconBtn) Omni.self.getSimObject(simobjectid, typeof (CreatorShapeIconBtn));
                    }

                #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<CreatorStaticIconBtn>))]
        public class CreatorStaticIconBtn : GuiButtonCtrl
        {
            [ConsoleInteraction]
            public override void onRightClick()
            {
                ContentBrowserGui ContentBrowserGui = "ContentBrowserGui";

                ContentBrowserGui.displayContextMenu(this);
            }

            [ConsoleInteraction]
            public override void onMouseDragged()
            {
                this.setCur();
            }

            [ConsoleInteraction]
            public override void onMouseUp()
            {
                canvas Canvas = "Canvas";

                Point2I screenPos = ((GuiCanvas)this.getRoot()).getCursorPos();
   
                string clientPos = Canvas.screenToClient(screenPos).AsString();
   
                bool ret = isMainCanvas( getRoot(), screenPos.AsString() );
                if( !ret )
                    return;
   
                GuiControl ctrl = Canvas.findHitControl(Util.getWord(clientPos,0).AsInt(), Util.getWord(clientPos,1).AsInt());
                if( ctrl.isInNamespaceHierarchy( "EditTSCtrl" ) )
                {
                    GameConnection ServerConnection = "ServerConnection";

                    string control = ServerConnection.getControlObject();
                    string fvec = ((EditTSCtrl)ctrl).getClickVector( clientPos.AsPoint2I() );
      
                    string start = ((EditTSCtrl)ctrl).getWorldPosition(clientPos.AsPoint2I());
      
                    Point3F end = Util.VectorAdd( start.AsPoint3F(), Util.VectorScale( fvec.AsPoint3F(), 30 ) );
      
                    string result = Util.containerRayCast(start.AsPoint3F(), end,
                    (uint)(iGlobal["$TypeMasks::GameBaseObjectType"] | iGlobal["$TypeMasks::ShapeBaseObjectType"] | iGlobal["$TypeMasks::StaticObjectType"]),
                    control, true);
            
                    if (Util.getWordCount(result) > 0 && Util.getWord(result, 0) != "0")
                    {
                        string posX = Util.getWord(result, 1);
                        string posY = Util.getWord(result, 2);
                        string posZ = Util.getWord(result, 3);

                        SimObject id = ((ColladaImportDlg)"ColladaImportDlg").showDialog(this["path"], altCommand);

                        //SimObject id = Util.eval(cmd);
         
                        id.call("setTransform", posX + " " + posY + " " + posZ + " " + "1 0 0 0" );
                    }
                }
                this.resetCur();
            }

            #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(CreatorStaticIconBtn ts, string simobjectid)
                    {
                    return object.ReferenceEquals(ts, null)
                        ? object.ReferenceEquals(simobjectid, null)
                        : ts.Equals(simobjectid);
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
                public static bool operator !=(CreatorStaticIconBtn ts, string simobjectid)
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
                public static implicit operator string(CreatorStaticIconBtn ts)
                    {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator CreatorStaticIconBtn(string ts)
                    {
                    uint simobjectid = resolveobject(ts);
                    return (CreatorStaticIconBtn) Omni.self.getSimObject(simobjectid, typeof (CreatorStaticIconBtn));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(CreatorStaticIconBtn ts)
                    {
                    return (int) ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator CreatorStaticIconBtn(int simobjectid)
                    {
                    return
                        (CreatorStaticIconBtn) Omni.self.getSimObject((uint) simobjectid, typeof (CreatorStaticIconBtn));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(CreatorStaticIconBtn ts)
                    {
                    return ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator CreatorStaticIconBtn(uint simobjectid)
                    {
                    return (CreatorStaticIconBtn) Omni.self.getSimObject(simobjectid, typeof (CreatorStaticIconBtn));
                    }

                #endregion
        }
        
        [ConsoleInteraction]
        public static bool isMainCanvas( GuiCanvas rootCanvas, string screenPos )
        {
            canvas Canvas = "Canvas";
            if( rootCanvas != Canvas.getId() )
            {
                string extent1 = rootCanvas.getWindowPosition().AsString() + rootCanvas.getExtent().AsString();
      
                string finalPos1 = ( omni.Util.getWord(extent1, 0 ).AsInt() + omni.Util.getWord(extent1, 2).AsInt() ) + " " + ( omni.Util.getWord(extent1, 1).AsInt() + omni.Util.getWord(extent1, 3).AsInt() );
      
                if( omni.Util.getWord(screenPos, 0).AsInt() < omni.Util.getWord(extent1, 0).AsInt() || omni.Util.getWord(screenPos, 1).AsInt() < omni.Util.getWord(extent1, 1).AsInt() || omni.Util.getWord(screenPos,0).AsInt() > omni.Util.getWord(finalPos1,0).AsInt() || omni.Util.getWord(screenPos,1).AsInt() > omni.Util.getWord(finalPos1,1).AsInt() )
                {
                    //echo("Outside Root");
                }
                else
                {
                    //echo("Inside Root");
                    return false;
                }

                string extent = Canvas.getWindowPosition().AsString() + Canvas.getExtent().AsString();
      
                string finalPos = ( omni.Util.getWord(extent,0).AsInt() + omni.Util.getWord(extent,2).AsInt() ) + " " + ( omni.Util.getWord(extent,1).AsInt() + omni.Util.getWord(extent,3).AsInt() );
      
                if( omni.Util.getWord(screenPos,0).AsInt() < omni.Util.getWord(extent,0).AsInt() || omni.Util.getWord(screenPos,1).AsInt() < omni.Util.getWord(extent,1).AsInt() || omni.Util.getWord(screenPos,0).AsInt() > omni.Util.getWord(finalPos,0).AsInt() || omni.Util.getWord(screenPos,1).AsInt() > omni.Util.getWord(finalPos,1).AsInt() )
                {
                    //echo("Outside Canvas");
                    return false;
                }
                //else
                //echo("Inside Canvas");
            }
   
            return true;
        }

        #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(ContentBrowserGui ts, string simobjectid)
                    {
                    return object.ReferenceEquals(ts, null)
                        ? object.ReferenceEquals(simobjectid, null)
                        : ts.Equals(simobjectid);
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
                public static bool operator !=(ContentBrowserGui ts, string simobjectid)
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
                public static implicit operator string(ContentBrowserGui ts)
                    {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator ContentBrowserGui(string ts)
                    {
                    uint simobjectid = resolveobject(ts);
                    return (ContentBrowserGui) Omni.self.getSimObject(simobjectid, typeof (ContentBrowserGui));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(ContentBrowserGui ts)
                    {
                    return (int) ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator ContentBrowserGui(int simobjectid)
                    {
                    return
                        (ContentBrowserGui) Omni.self.getSimObject((uint) simobjectid, typeof (ContentBrowserGui));
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(ContentBrowserGui ts)
                    {
                    return ts._iID;
                    }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator ContentBrowserGui(uint simobjectid)
                    {
                    return (ContentBrowserGui) Omni.self.getSimObject(simobjectid, typeof (ContentBrowserGui));
                    }

                #endregion
    }
}
