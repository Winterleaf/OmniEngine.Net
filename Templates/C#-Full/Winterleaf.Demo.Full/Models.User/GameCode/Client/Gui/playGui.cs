using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.CenterPrint;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<playGui>))]
    public class playGui : GameTSCtrl
        {
        public static void initialize()
            {
            #region GameTSCtrl (PlayGui)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GameTSCtrl", "PlayGui", typeof (playGui));
            oc_Newobject20["cameraZRot"] = "0";
            oc_Newobject20["forceFOV"] = "0";
            oc_Newobject20["reflectPriority"] = "1";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "GuiContentProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "0 0";
            oc_Newobject20["Extent"] = "1024 768";
            oc_Newobject20["MinExtent"] = "8 8";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["canSaveDynamicFields"] = "1";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["helpTag"] = "0";
            oc_Newobject20["noCursor"] = "1";

            #region GuiBitmapCtrl (CenterPrintDlg)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapCtrl", "CenterPrintDlg");
            oc_Newobject2["bitmap"] = "art/gui/hudfill.png";
            oc_Newobject2["wrap"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "CenterPrintProfile";
            oc_Newobject2["HorizSizing"] = "center";
            oc_Newobject2["VertSizing"] = "center";
            oc_Newobject2["position"] = "237 375";
            oc_Newobject2["Extent"] = "550 20";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "0";
            oc_Newobject2["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #region GuiMLTextCtrl (CenterPrintText)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiMLTextCtrl", "CenterPrintText",
                typeof (printText));
            oc_Newobject1["lineSpacing"] = "2";
            oc_Newobject1["allowColorChars"] = "0";
            oc_Newobject1["maxChars"] = "-1";
            oc_Newobject1["useURLMouseCursor"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "CenterPrintTextProfile";
            oc_Newobject1["HorizSizing"] = "center";
            oc_Newobject1["VertSizing"] = "center";
            oc_Newobject1["position"] = "0 0";
            oc_Newobject1["Extent"] = "546 12";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject20["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapCtrl (BottomPrintDlg)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapCtrl", "BottomPrintDlg");
            oc_Newobject4["bitmap"] = "art/gui/hudfill.png";
            oc_Newobject4["wrap"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "CenterPrintProfile";
            oc_Newobject4["HorizSizing"] = "center";
            oc_Newobject4["VertSizing"] = "top";
            oc_Newobject4["position"] = "237 719";
            oc_Newobject4["Extent"] = "550 20";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "0";
            oc_Newobject4["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #region GuiMLTextCtrl (BottomPrintText)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiMLTextCtrl", "BottomPrintText",
                typeof (printText));
            oc_Newobject3["lineSpacing"] = "2";
            oc_Newobject3["allowColorChars"] = "0";
            oc_Newobject3["maxChars"] = "-1";
            oc_Newobject3["useURLMouseCursor"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "CenterPrintTextProfile";
            oc_Newobject3["HorizSizing"] = "center";
            oc_Newobject3["VertSizing"] = "center";
            oc_Newobject3["position"] = "0 0";
            oc_Newobject3["Extent"] = "546 12";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject20["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapCtrl (LagIcon)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapCtrl", "LagIcon");
            oc_Newobject5["bitmap"] = "art/gui/lagIcon.png";
            oc_Newobject5["wrap"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "GuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "572 3";
            oc_Newobject5["Extent"] = "32 32";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "0";
            oc_Newobject5["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject5"] = oc_Newobject5;

            #region GuiShapeNameHud ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiShapeNameHud", "");
            oc_Newobject6["fillColor"] = "0 0 0 0.25";
            oc_Newobject6["frameColor"] = "0 1 0 1";
            oc_Newobject6["textColor"] = "0 1 0 1";
            oc_Newobject6["showFill"] = "0";
            oc_Newobject6["showFrame"] = "0";
            oc_Newobject6["verticalOffset"] = "0.2";
            oc_Newobject6["distanceFade"] = "0.1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "GuiModelessDialogProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "height";
            oc_Newobject6["position"] = "0 0";
            oc_Newobject6["Extent"] = "1024 768";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject6"] = oc_Newobject6;

            #region GuiCrossHairHud (Reticle)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiCrossHairHud", "Reticle");
            oc_Newobject7["damageFillColor"] = "0 1 0 1";
            oc_Newobject7["damageFrameColor"] = "1 0.6 0 1";
            oc_Newobject7["damageRect"] = "50 4";
            oc_Newobject7["damageOffset"] = "0 10";
            oc_Newobject7["bitmap"] = "art/gui/weaponHud/blank.png";
            oc_Newobject7["wrap"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "GuiModelessDialogProfile";
            oc_Newobject7["HorizSizing"] = "center";
            oc_Newobject7["VertSizing"] = "center";
            oc_Newobject7["position"] = "496 368";
            oc_Newobject7["Extent"] = "32 32";
            oc_Newobject7["MinExtent"] = "8 8";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject7"] = oc_Newobject7;

            #region GuiCrossHairHud (ZoomReticle)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiCrossHairHud", "ZoomReticle");
            oc_Newobject8["damageFillColor"] = "0 1 0 1";
            oc_Newobject8["damageFrameColor"] = "1 0.6 0 1";
            oc_Newobject8["damageRect"] = "50 4";
            oc_Newobject8["damageOffset"] = "0 10";
            oc_Newobject8["bitmap"] = "art/gui/weaponHud/bino.png";
            oc_Newobject8["wrap"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "GuiModelessDialogProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "height";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["Extent"] = "1024 768";
            oc_Newobject8["MinExtent"] = "8 8";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "0";
            oc_Newobject8["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject8"] = oc_Newobject8;

            #region GuiBitmapBorderCtrl (WeaponHUD)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapBorderCtrl", "WeaponHUD");
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ChatHudBorderProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "top";
            oc_Newobject12["position"] = "78 693";
            oc_Newobject12["Extent"] = "124 72";
            oc_Newobject12["MinExtent"] = "8 8";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject9["bitmap"] = "core/art/gui/images/hudfill.png";
            oc_Newobject9["wrap"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "GuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "height";
            oc_Newobject9["position"] = "8 8";
            oc_Newobject9["Extent"] = "108 56";
            oc_Newobject9["MinExtent"] = "8 8";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapCtrl (PreviewImage)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapCtrl", "PreviewImage");
            oc_Newobject10["bitmap"] = "art/gui/weaponHud/blank.png";
            oc_Newobject10["wrap"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "GuiDefaultProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "height";
            oc_Newobject10["position"] = "8 8";
            oc_Newobject10["Extent"] = "108 56";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiTextCtrl (AmmoAmount)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "AmmoAmount");
            oc_Newobject11["maxLength"] = "255";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "0";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "0";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "HudTextItalicProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "top";
            oc_Newobject11["position"] = "40 8";
            oc_Newobject11["Extent"] = "120 16";
            oc_Newobject11["MinExtent"] = "8 8";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject20["#Newobject12"] = oc_Newobject12;

            #region GuiHealthTextHud ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiHealthTextHud", "");
            oc_Newobject13["fillColor"] = "0 0 0 0.65";
            oc_Newobject13["frameColor"] = "0 0 0 1";
            oc_Newobject13["textColor"] = "1 1 1 1";
            oc_Newobject13["warningColor"] = "1 0 0 1";
            oc_Newobject13["showFill"] = "1";
            oc_Newobject13["showFrame"] = "1";
            oc_Newobject13["showTrueValue"] = "0";
            oc_Newobject13["showEnergy"] = "0";
            oc_Newobject13["warnThreshold"] = "25";
            oc_Newobject13["pulseThreshold"] = "15";
            oc_Newobject13["pulseRate"] = "750";
            oc_Newobject13["position"] = "5 693";
            oc_Newobject13["extent"] = "72 72";
            oc_Newobject13["minExtent"] = "8 2";
            oc_Newobject13["horizSizing"] = "right";
            oc_Newobject13["vertSizing"] = "top";
            oc_Newobject13["profile"] = "GuiBigTextProfile";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["active"] = "1";
            oc_Newobject13["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject13"] = oc_Newobject13;

            #region GuiControl (DamageHUD)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiControl", "DamageHUD");
            oc_Newobject19["position"] = "384 256";
            oc_Newobject19["extent"] = "256 256";
            oc_Newobject19["minExtent"] = "8 2";
            oc_Newobject19["horizSizing"] = "center";
            oc_Newobject19["vertSizing"] = "center";
            oc_Newobject19["profile"] = "GuiDefaultProfile";
            oc_Newobject19["visible"] = "1";
            oc_Newobject19["active"] = "1";
            oc_Newobject19["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["canSaveDynamicFields"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject14["bitmap"] = "art/gui/damageFront.png";
            oc_Newobject14["wrap"] = "0";
            oc_Newobject14["position"] = "0 0";
            oc_Newobject14["extent"] = "256 32";
            oc_Newobject14["minExtent"] = "8 2";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["profile"] = "GuiDefaultProfile";
            oc_Newobject14["visible"] = "0";
            oc_Newobject14["active"] = "1";
            oc_Newobject14["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["internalName"] = "Damage_Front";
            oc_Newobject14["hidden"] = "1";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject19["#Newobject14"] = oc_Newobject14;

            #region GuiBitmapCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject15["bitmap"] = "art/gui/damageTop.png";
            oc_Newobject15["wrap"] = "0";
            oc_Newobject15["position"] = "0 0";
            oc_Newobject15["extent"] = "256 32";
            oc_Newobject15["minExtent"] = "8 2";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["profile"] = "GuiDefaultProfile";
            oc_Newobject15["visible"] = "0";
            oc_Newobject15["active"] = "1";
            oc_Newobject15["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["internalName"] = "Damage_Top";
            oc_Newobject15["hidden"] = "1";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject19["#Newobject15"] = oc_Newobject15;

            #region GuiBitmapCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject16["bitmap"] = "art/gui/damageBottom.png";
            oc_Newobject16["wrap"] = "0";
            oc_Newobject16["position"] = "0 224";
            oc_Newobject16["extent"] = "256 32";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["horizSizing"] = "right";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["profile"] = "GuiDefaultProfile";
            oc_Newobject16["visible"] = "0";
            oc_Newobject16["active"] = "1";
            oc_Newobject16["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["internalName"] = "Damage_Bottom";
            oc_Newobject16["hidden"] = "1";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject19["#Newobject16"] = oc_Newobject16;

            #region GuiBitmapCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject17["bitmap"] = "art/gui/damageLeft.png";
            oc_Newobject17["wrap"] = "0";
            oc_Newobject17["position"] = "0 0";
            oc_Newobject17["extent"] = "32 256";
            oc_Newobject17["minExtent"] = "8 2";
            oc_Newobject17["horizSizing"] = "right";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["profile"] = "GuiDefaultProfile";
            oc_Newobject17["visible"] = "0";
            oc_Newobject17["active"] = "1";
            oc_Newobject17["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["internalName"] = "Damage_Left";
            oc_Newobject17["hidden"] = "1";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject19["#Newobject17"] = oc_Newobject17;

            #region GuiBitmapCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject18["bitmap"] = "art/gui/damageRight.png";
            oc_Newobject18["wrap"] = "0";
            oc_Newobject18["position"] = "224 0";
            oc_Newobject18["extent"] = "32 256";
            oc_Newobject18["minExtent"] = "8 2";
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["profile"] = "GuiDefaultProfile";
            oc_Newobject18["visible"] = "0";
            oc_Newobject18["active"] = "1";
            oc_Newobject18["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["internalName"] = "Damage_Right";
            oc_Newobject18["hidden"] = "1";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject20.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onWake()
            {
            // Turn off any shell sounds...
            // sfxStop( ... );

            bGlobal["$enableDirectInput"] = true;
            Util.activateDirectInput();

            // Message hud dialog
            if ("MainChatHud".isObject())
                {
                ((GuiCanvas) "Canvas").pushDialog("MainChatHud");
                ((GuiMessageVectorCtrl) "chatHud").attach("HudMessageVector");
                }

            // just update the action map here
            ((ActionMap) "moveMap").push();

            refreshCenterTextCtrl();
            refreshBottomTextCtrl();
            }

        public override void onSleep()
            {
            if ("MainChatHud".isObject())
                ((GuiCanvas) "Canvas").popDialog("MainChatHud");

            // pop the keymaps
            ((ActionMap) "moveMap").pop();
            }


        public virtual void clearHud()
            {
            ((GuiCanvas) "Canvas").popDialog("MainChatHud");

            while (getCount() > 0)
                getObject(0).delete();
            }

        public void refreshBottomTextCtrl()
            {
            ((GuiMLTextCtrl) "BottomPrintText").position = new Point2I(0, 0);
            }

        public void refreshCenterTextCtrl()
            {
            ((GuiMLTextCtrl) "CenterPrintText").position = new Point2I(0, 0);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(playGui ts, string simobjectid)
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
        public static bool operator !=(playGui ts, string simobjectid)
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
        public static implicit operator string(playGui ts)
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
        public static implicit operator playGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (playGui) Omni.self.getSimObject(simobjectid, typeof (playGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(playGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator playGui(int simobjectid)
            {
            return (playGui) Omni.self.getSimObject((uint) simobjectid, typeof (playGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(playGui ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator playGui(uint simobjectid)
            {
            return (playGui) Omni.self.getSimObject(simobjectid, typeof (playGui));
            }

        #endregion
        }
    }