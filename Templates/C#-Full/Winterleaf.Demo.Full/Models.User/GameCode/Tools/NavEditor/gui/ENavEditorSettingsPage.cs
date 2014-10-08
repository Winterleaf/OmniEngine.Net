using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui
{
    [TypeConverter(typeof(TypeConverterGeneric<ENavEditorSettingsPage>))]
    public class ENavEditorSettingsPage : GuiTabPageCtrl
    {
        public static void initialize()
        {
            ObjectCreator oc_Newobject00021;
            ObjectCreator oc_Newobject00020;
            ObjectCreator oc_Newobject00019;
            ObjectCreator oc_Newobject00018;
            ObjectCreator oc_Newobject00017;
            ObjectCreator oc_Newobject00016;
            ObjectCreator oc_Newobject00015;
            ObjectCreator oc_Newobject00014;
            ObjectCreator oc_Newobject00013;
            ObjectCreator oc_Newobject00012;
            ObjectCreator oc_Newobject00011;
            ObjectCreator oc_Newobject00010;
            ObjectCreator oc_Newobject00009;
            ObjectCreator oc_Newobject00008;
            ObjectCreator oc_Newobject00007;
            ObjectCreator oc_Newobject00006;
            ObjectCreator oc_Newobject00005;
            ObjectCreator oc_Newobject00004;
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
            {

                #region GuiTabPageCtrl (ENavEditorSettingsPage)        oc_Newobject00021
                oc_Newobject00021 = new ObjectCreator("GuiTabPageCtrl", "ENavEditorSettingsPage", typeof(ENavEditorSettingsPage));
                oc_Newobject00021["fitBook"] = "1";
                oc_Newobject00021["text"] = "Navigation Editor";
                oc_Newobject00021["maxLength"] = "1024";
                oc_Newobject00021["margin"] = "0 0 0 0";
                oc_Newobject00021["padding"] = "0 0 0 0";
                oc_Newobject00021["anchorTop"] = "1";
                oc_Newobject00021["anchorBottom"] = "0";
                oc_Newobject00021["anchorLeft"] = "1";
                oc_Newobject00021["anchorRight"] = "0";
                oc_Newobject00021["position"] = "0 0";
                oc_Newobject00021["extent"] = "208 292";
                oc_Newobject00021["minExtent"] = "8 2";
                oc_Newobject00021["horizSizing"] = "width";
                oc_Newobject00021["vertSizing"] = "height";
                oc_Newobject00021["profile"] = "GuiSolidDefaultProfile";
                oc_Newobject00021["visible"] = "1";
                oc_Newobject00021["active"] = "1";
                oc_Newobject00021["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject00021["hovertime"] = "1000";
                oc_Newobject00021["isContainer"] = "1";
                oc_Newobject00021["canSave"] = "1";
                oc_Newobject00021["canSaveDynamicFields"] = "1";
                if (true)
                {

                    #region GuiScrollCtrl ()        oc_Newobject00020
                    oc_Newobject00020 = new ObjectCreator("GuiScrollCtrl", "");
                    oc_Newobject00020["willFirstRespond"] = "1";
                    oc_Newobject00020["hScrollBar"] = "alwaysOff";
                    oc_Newobject00020["vScrollBar"] = "dynamic";
                    oc_Newobject00020["lockHorizScroll"] = "1";
                    oc_Newobject00020["lockVertScroll"] = "0";
                    oc_Newobject00020["constantThumbHeight"] = "0";
                    oc_Newobject00020["childMargin"] = "0 0";
                    oc_Newobject00020["mouseWheelScrollSpeed"] = "-1";
                    oc_Newobject00020["margin"] = "0 0 0 0";
                    oc_Newobject00020["padding"] = "0 0 0 0";
                    oc_Newobject00020["anchorTop"] = "1";
                    oc_Newobject00020["anchorBottom"] = "0";
                    oc_Newobject00020["anchorLeft"] = "1";
                    oc_Newobject00020["anchorRight"] = "0";
                    oc_Newobject00020["position"] = "0 0";
                    oc_Newobject00020["extent"] = "208 292";
                    oc_Newobject00020["minExtent"] = "8 2";
                    oc_Newobject00020["horizSizing"] = "width";
                    oc_Newobject00020["vertSizing"] = "height";
                    oc_Newobject00020["profile"] = "GuiScrollProfile";
                    oc_Newobject00020["visible"] = "1";
                    oc_Newobject00020["active"] = "1";
                    oc_Newobject00020["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00020["hovertime"] = "1000";
                    oc_Newobject00020["isContainer"] = "1";
                    oc_Newobject00020["canSave"] = "1";
                    oc_Newobject00020["canSaveDynamicFields"] = "0";
                    if (true)
                    {

                        #region GuiStackControl ()        oc_Newobject00019
                        oc_Newobject00019 = new ObjectCreator("GuiStackControl", "");
                        oc_Newobject00019["stackingType"] = "Vertical";
                        oc_Newobject00019["horizStacking"] = "Left to Right";
                        oc_Newobject00019["vertStacking"] = "Top to Bottom";
                        oc_Newobject00019["padding"] = "0";
                        oc_Newobject00019["dynamicSize"] = "1";
                        oc_Newobject00019["dynamicNonStackExtent"] = "0";
                        oc_Newobject00019["dynamicPos"] = "0";
                        oc_Newobject00019["changeChildSizeToFit"] = "1";
                        oc_Newobject00019["changeChildPosition"] = "1";
                        oc_Newobject00019["position"] = "1 1";
                        oc_Newobject00019["extent"] = "206 124";
                        oc_Newobject00019["minExtent"] = "8 2";
                        oc_Newobject00019["horizSizing"] = "width";
                        oc_Newobject00019["vertSizing"] = "bottom";
                        oc_Newobject00019["profile"] = "GuiDefaultProfile";
                        oc_Newobject00019["visible"] = "1";
                        oc_Newobject00019["active"] = "1";
                        oc_Newobject00019["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00019["hovertime"] = "1000";
                        oc_Newobject00019["isContainer"] = "1";
                        oc_Newobject00019["canSave"] = "1";
                        oc_Newobject00019["canSaveDynamicFields"] = "0";
                        if (true)
                        {

                            #region GuiRolloutCtrl ()        oc_Newobject00008
                            oc_Newobject00008 = new ObjectCreator("GuiRolloutCtrl", "");
                            oc_Newobject00008["caption"] = "Test spawn";
                            oc_Newobject00008["margin"] = "0 3 0 0";
                            oc_Newobject00008["defaultHeight"] = "40";
                            oc_Newobject00008["expanded"] = "1";
                            oc_Newobject00008["clickCollapse"] = "1";
                            oc_Newobject00008["hideHeader"] = "0";
                            oc_Newobject00008["autoCollapseSiblings"] = "0";
                            oc_Newobject00008["position"] = "0 0";
                            oc_Newobject00008["extent"] = "206 62";
                            oc_Newobject00008["minExtent"] = "8 2";
                            oc_Newobject00008["horizSizing"] = "right";
                            oc_Newobject00008["vertSizing"] = "bottom";
                            oc_Newobject00008["profile"] = "GuiRolloutProfile";
                            oc_Newobject00008["visible"] = "1";
                            oc_Newobject00008["active"] = "1";
                            oc_Newobject00008["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00008["hovertime"] = "1000";
                            oc_Newobject00008["isContainer"] = "1";
                            oc_Newobject00008["canSave"] = "1";
                            oc_Newobject00008["canSaveDynamicFields"] = "0";
                            if (true)
                            {

                                #region GuiStackControl ()        oc_Newobject00007
                                oc_Newobject00007 = new ObjectCreator("GuiStackControl", "");
                                oc_Newobject00007["stackingType"] = "Vertical";
                                oc_Newobject00007["horizStacking"] = "Left to Right";
                                oc_Newobject00007["vertStacking"] = "Top to Bottom";
                                oc_Newobject00007["padding"] = "3";
                                oc_Newobject00007["dynamicSize"] = "1";
                                oc_Newobject00007["dynamicNonStackExtent"] = "0";
                                oc_Newobject00007["dynamicPos"] = "0";
                                oc_Newobject00007["changeChildSizeToFit"] = "1";
                                oc_Newobject00007["changeChildPosition"] = "1";
                                oc_Newobject00007["position"] = "0 20";
                                oc_Newobject00007["extent"] = "206 39";
                                oc_Newobject00007["minExtent"] = "8 2";
                                oc_Newobject00007["horizSizing"] = "width";
                                oc_Newobject00007["vertSizing"] = "bottom";
                                oc_Newobject00007["profile"] = "GuiDefaultProfile";
                                oc_Newobject00007["visible"] = "1";
                                oc_Newobject00007["active"] = "1";
                                oc_Newobject00007["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00007["hovertime"] = "1000";
                                oc_Newobject00007["isContainer"] = "1";
                                oc_Newobject00007["canSave"] = "1";
                                oc_Newobject00007["canSaveDynamicFields"] = "0";
                                if (true)
                                {

                                    #region GuiControl ()        oc_Newobject00003
                                    oc_Newobject00003 = new ObjectCreator("GuiControl", "");
                                    oc_Newobject00003["position"] = "0 0";
                                    oc_Newobject00003["extent"] = "206 18";
                                    oc_Newobject00003["minExtent"] = "8 2";
                                    oc_Newobject00003["horizSizing"] = "right";
                                    oc_Newobject00003["vertSizing"] = "bottom";
                                    oc_Newobject00003["profile"] = "GuiDefaultProfile";
                                    oc_Newobject00003["visible"] = "1";
                                    oc_Newobject00003["active"] = "1";
                                    oc_Newobject00003["tooltipProfile"] = "GuiToolTipProfile";
                                    oc_Newobject00003["hovertime"] = "1000";
                                    oc_Newobject00003["isContainer"] = "1";
                                    oc_Newobject00003["canSave"] = "1";
                                    oc_Newobject00003["canSaveDynamicFields"] = "0";
                                    if (true)
                                    {

                                        #region GuiTextCtrl ()        oc_Newobject00001
                                        oc_Newobject00001 = new ObjectCreator("GuiTextCtrl", "");
                                        oc_Newobject00001["text"] = "Spawn class:";
                                        oc_Newobject00001["maxLength"] = "1024";
                                        oc_Newobject00001["margin"] = "0 0 0 0";
                                        oc_Newobject00001["padding"] = "0 0 0 0";
                                        oc_Newobject00001["anchorTop"] = "1";
                                        oc_Newobject00001["anchorBottom"] = "0";
                                        oc_Newobject00001["anchorLeft"] = "1";
                                        oc_Newobject00001["anchorRight"] = "0";
                                        oc_Newobject00001["position"] = "5 1";
                                        oc_Newobject00001["extent"] = "70 16";
                                        oc_Newobject00001["minExtent"] = "8 2";
                                        oc_Newobject00001["horizSizing"] = "right";
                                        oc_Newobject00001["vertSizing"] = "bottom";
                                        oc_Newobject00001["profile"] = "GuiTextRightProfile";
                                        oc_Newobject00001["visible"] = "1";
                                        oc_Newobject00001["active"] = "1";
                                        oc_Newobject00001["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00001["hovertime"] = "1000";
                                        oc_Newobject00001["isContainer"] = "0";
                                        oc_Newobject00001["canSave"] = "1";
                                        oc_Newobject00001["canSaveDynamicFields"] = "0";
                                        #endregion

                                        oc_Newobject00003["#Newobject00001"] = oc_Newobject00001;

                                        #region GuiPopUpMenuCtrlEx ()        oc_Newobject00002
                                        oc_Newobject00002 = new ObjectCreator("GuiPopUpMenuCtrlEx", "", typeof(ESettingsWindowPopup));
                                        oc_Newobject00002["maxPopupHeight"] = "200";
                                        oc_Newobject00002["sbUsesNAColor"] = "0";
                                        oc_Newobject00002["reverseTextList"] = "0";
                                        oc_Newobject00002["bitmapBounds"] = "16 16";
                                        oc_Newobject00002["hotTrackCallback"] = "0";
                                        oc_Newobject00002["maxLength"] = "1024";
                                        oc_Newobject00002["margin"] = "0 0 0 0";
                                        oc_Newobject00002["padding"] = "0 0 0 0";
                                        oc_Newobject00002["anchorTop"] = "1";
                                        oc_Newobject00002["anchorBottom"] = "0";
                                        oc_Newobject00002["anchorLeft"] = "1";
                                        oc_Newobject00002["anchorRight"] = "0";
                                        oc_Newobject00002["position"] = "81 0";
                                        oc_Newobject00002["extent"] = "121 18";
                                        oc_Newobject00002["minExtent"] = "8 2";
                                        oc_Newobject00002["horizSizing"] = "right";
                                        oc_Newobject00002["vertSizing"] = "bottom";
                                        oc_Newobject00002["profile"] = "GuiPopUpMenuProfile";
                                        oc_Newobject00002["visible"] = "1";
                                        oc_Newobject00002["active"] = "1";
                                        oc_Newobject00002["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00002["hovertime"] = "1000";
                                        oc_Newobject00002["isContainer"] = "1";
                                        oc_Newobject00002["internalName"] = "SpawnClassOptions";
                                        //oc_Newobject00002["class"] = "ESettingsWindowPopup";
                                        oc_Newobject00002["canSave"] = "1";
                                        oc_Newobject00002["canSaveDynamicFields"] = "1";
                                        oc_Newobject00002["editorSettingsRead"] = "NavEditorPlugin.readSettings();";
                                        oc_Newobject00002["editorSettingsValue"] = "NavEditor/SpawnClass";
                                        oc_Newobject00002["editorSettingsWrite"] = "NavEditorPlugin.writeSettings();";
                                        #endregion

                                        oc_Newobject00003["#Newobject00002"] = oc_Newobject00002;

                                    }
                                    #endregion

                                    oc_Newobject00007["#Newobject00003"] = oc_Newobject00003;

                                    #region GuiControl ()        oc_Newobject00006
                                    oc_Newobject00006 = new ObjectCreator("GuiControl", "");
                                    oc_Newobject00006["position"] = "0 21";
                                    oc_Newobject00006["extent"] = "206 18";
                                    oc_Newobject00006["minExtent"] = "8 2";
                                    oc_Newobject00006["horizSizing"] = "right";
                                    oc_Newobject00006["vertSizing"] = "bottom";
                                    oc_Newobject00006["profile"] = "GuiDefaultProfile";
                                    oc_Newobject00006["visible"] = "1";
                                    oc_Newobject00006["active"] = "1";
                                    oc_Newobject00006["tooltipProfile"] = "GuiToolTipProfile";
                                    oc_Newobject00006["hovertime"] = "1000";
                                    oc_Newobject00006["isContainer"] = "1";
                                    oc_Newobject00006["canSave"] = "1";
                                    oc_Newobject00006["canSaveDynamicFields"] = "0";
                                    if (true)
                                    {

                                        #region GuiTextCtrl ()        oc_Newobject00004
                                        oc_Newobject00004 = new ObjectCreator("GuiTextCtrl", "");
                                        oc_Newobject00004["text"] = "Datablock:";
                                        oc_Newobject00004["maxLength"] = "1024";
                                        oc_Newobject00004["margin"] = "0 0 0 0";
                                        oc_Newobject00004["padding"] = "0 0 0 0";
                                        oc_Newobject00004["anchorTop"] = "1";
                                        oc_Newobject00004["anchorBottom"] = "0";
                                        oc_Newobject00004["anchorLeft"] = "1";
                                        oc_Newobject00004["anchorRight"] = "0";
                                        oc_Newobject00004["position"] = "5 1";
                                        oc_Newobject00004["extent"] = "70 18";
                                        oc_Newobject00004["minExtent"] = "8 2";
                                        oc_Newobject00004["horizSizing"] = "right";
                                        oc_Newobject00004["vertSizing"] = "bottom";
                                        oc_Newobject00004["profile"] = "GuiTextRightProfile";
                                        oc_Newobject00004["visible"] = "1";
                                        oc_Newobject00004["active"] = "1";
                                        oc_Newobject00004["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00004["hovertime"] = "1000";
                                        oc_Newobject00004["isContainer"] = "0";
                                        oc_Newobject00004["canSave"] = "1";
                                        oc_Newobject00004["canSaveDynamicFields"] = "0";
                                        #endregion

                                        oc_Newobject00006["#Newobject00004"] = oc_Newobject00004;

                                        #region GuiTextEditCtrl ()        oc_Newobject00005
                                        oc_Newobject00005 = new ObjectCreator("GuiTextEditCtrl", "", typeof(ESettingsWindow.ESettingsWindowTextEdit));
                                        oc_Newobject00005["historySize"] = "0";
                                        oc_Newobject00005["tabComplete"] = "0";
                                        oc_Newobject00005["sinkAllKeyEvents"] = "0";
                                        oc_Newobject00005["password"] = "0";
                                        oc_Newobject00005["passwordMask"] = "*";
                                        oc_Newobject00005["text"] = "DefaultPlayerData";
                                        oc_Newobject00005["maxLength"] = "1024";
                                        oc_Newobject00005["margin"] = "0 0 0 0";
                                        oc_Newobject00005["padding"] = "0 0 0 0";
                                        oc_Newobject00005["anchorTop"] = "1";
                                        oc_Newobject00005["anchorBottom"] = "0";
                                        oc_Newobject00005["anchorLeft"] = "1";
                                        oc_Newobject00005["anchorRight"] = "0";
                                        oc_Newobject00005["position"] = "81 0";
                                        oc_Newobject00005["extent"] = "121 18";
                                        oc_Newobject00005["minExtent"] = "8 2";
                                        oc_Newobject00005["horizSizing"] = "width";
                                        oc_Newobject00005["vertSizing"] = "bottom";
                                        oc_Newobject00005["profile"] = "GuiTextEditProfile";
                                        oc_Newobject00005["visible"] = "1";
                                        oc_Newobject00005["active"] = "1";
                                        oc_Newobject00005["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00005["hovertime"] = "1000";
                                        oc_Newobject00005["isContainer"] = "0";
                                        //oc_Newobject00005["class"] = "ESettingsWindowTextEdit";
                                        oc_Newobject00005["canSave"] = "1";
                                        oc_Newobject00005["canSaveDynamicFields"] = "1";
                                        oc_Newobject00005["editorSettingsRead"] = "NavEditorPlugin.readSettings();";
                                        oc_Newobject00005["editorSettingsValue"] = "NavEditor/SpawnDatablock";
                                        oc_Newobject00005["editorSettingsWrite"] = "NavEditorPlugin.writeSettings();";
                                        #endregion

                                        oc_Newobject00006["#Newobject00005"] = oc_Newobject00005;

                                    }
                                    #endregion

                                    oc_Newobject00007["#Newobject00006"] = oc_Newobject00006;

                                }
                                #endregion

                                oc_Newobject00008["#Newobject00007"] = oc_Newobject00007;

                            }
                            #endregion

                            oc_Newobject00019["#Newobject00008"] = oc_Newobject00008;

                            #region GuiRolloutCtrl ()        oc_Newobject00018
                            oc_Newobject00018 = new ObjectCreator("GuiRolloutCtrl", "");
                            oc_Newobject00018["caption"] = "Colors";
                            oc_Newobject00018["margin"] = "0 3 0 0";
                            oc_Newobject00018["defaultHeight"] = "40";
                            oc_Newobject00018["expanded"] = "1";
                            oc_Newobject00018["clickCollapse"] = "1";
                            oc_Newobject00018["hideHeader"] = "0";
                            oc_Newobject00018["autoCollapseSiblings"] = "0";
                            oc_Newobject00018["position"] = "0 62";
                            oc_Newobject00018["extent"] = "206 62";
                            oc_Newobject00018["minExtent"] = "8 2";
                            oc_Newobject00018["horizSizing"] = "right";
                            oc_Newobject00018["vertSizing"] = "bottom";
                            oc_Newobject00018["profile"] = "GuiRolloutProfile";
                            oc_Newobject00018["visible"] = "1";
                            oc_Newobject00018["active"] = "1";
                            oc_Newobject00018["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00018["hovertime"] = "1000";
                            oc_Newobject00018["isContainer"] = "1";
                            oc_Newobject00018["canSave"] = "1";
                            oc_Newobject00018["canSaveDynamicFields"] = "0";
                            if (true)
                            {

                                #region GuiStackControl ()        oc_Newobject00017
                                oc_Newobject00017 = new ObjectCreator("GuiStackControl", "");
                                oc_Newobject00017["stackingType"] = "Vertical";
                                oc_Newobject00017["horizStacking"] = "Left to Right";
                                oc_Newobject00017["vertStacking"] = "Top to Bottom";
                                oc_Newobject00017["padding"] = "3";
                                oc_Newobject00017["dynamicSize"] = "1";
                                oc_Newobject00017["dynamicNonStackExtent"] = "0";
                                oc_Newobject00017["dynamicPos"] = "0";
                                oc_Newobject00017["changeChildSizeToFit"] = "1";
                                oc_Newobject00017["changeChildPosition"] = "1";
                                oc_Newobject00017["position"] = "0 20";
                                oc_Newobject00017["extent"] = "206 39";
                                oc_Newobject00017["minExtent"] = "8 2";
                                oc_Newobject00017["horizSizing"] = "width";
                                oc_Newobject00017["vertSizing"] = "bottom";
                                oc_Newobject00017["profile"] = "GuiDefaultProfile";
                                oc_Newobject00017["visible"] = "1";
                                oc_Newobject00017["active"] = "1";
                                oc_Newobject00017["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00017["hovertime"] = "1000";
                                oc_Newobject00017["isContainer"] = "1";
                                oc_Newobject00017["canSave"] = "1";
                                oc_Newobject00017["canSaveDynamicFields"] = "0";
                                if (true)
                                {

                                    #region GuiControl ()        oc_Newobject00012
                                    oc_Newobject00012 = new ObjectCreator("GuiControl", "", typeof(ESettingsWindow.ESettingsWindowColor));
                                    oc_Newobject00012["position"] = "0 0";
                                    oc_Newobject00012["extent"] = "206 18";
                                    oc_Newobject00012["minExtent"] = "8 2";
                                    oc_Newobject00012["horizSizing"] = "right";
                                    oc_Newobject00012["vertSizing"] = "bottom";
                                    oc_Newobject00012["profile"] = "GuiDefaultProfile";
                                    oc_Newobject00012["visible"] = "1";
                                    oc_Newobject00012["active"] = "1";
                                    oc_Newobject00012["tooltipProfile"] = "GuiToolTipProfile";
                                    oc_Newobject00012["hovertime"] = "1000";
                                    oc_Newobject00012["isContainer"] = "1";
                                    //oc_Newobject00012["class"] = "ESettingsWindowColor";
                                    oc_Newobject00012["canSave"] = "1";
                                    oc_Newobject00012["canSaveDynamicFields"] = "1";
                                    oc_Newobject00012["editorSettingsRead"] = "NavEditorPlugin.readSettings();";
                                    oc_Newobject00012["editorSettingsValue"] = "NavEditor/HoverSplineColor";
                                    oc_Newobject00012["editorSettingsWrite"] = "NavEditorPlugin.writeSettings();";
                                    if (true)
                                    {

                                        #region GuiTextCtrl ()        oc_Newobject00009
                                        oc_Newobject00009 = new ObjectCreator("GuiTextCtrl", "");
                                        oc_Newobject00009["text"] = "Hover Spline:";
                                        oc_Newobject00009["maxLength"] = "1024";
                                        oc_Newobject00009["margin"] = "0 0 0 0";
                                        oc_Newobject00009["padding"] = "0 0 0 0";
                                        oc_Newobject00009["anchorTop"] = "1";
                                        oc_Newobject00009["anchorBottom"] = "0";
                                        oc_Newobject00009["anchorLeft"] = "1";
                                        oc_Newobject00009["anchorRight"] = "0";
                                        oc_Newobject00009["position"] = "0 1";
                                        oc_Newobject00009["extent"] = "70 16";
                                        oc_Newobject00009["minExtent"] = "8 2";
                                        oc_Newobject00009["horizSizing"] = "right";
                                        oc_Newobject00009["vertSizing"] = "bottom";
                                        oc_Newobject00009["profile"] = "GuiTextRightProfile";
                                        oc_Newobject00009["visible"] = "1";
                                        oc_Newobject00009["active"] = "1";
                                        oc_Newobject00009["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00009["hovertime"] = "1000";
                                        oc_Newobject00009["isContainer"] = "0";
                                        oc_Newobject00009["canSave"] = "1";
                                        oc_Newobject00009["canSaveDynamicFields"] = "1";
                                        #endregion

                                        oc_Newobject00012["#Newobject00009"] = oc_Newobject00009;

                                        #region GuiTextEditCtrl ()        oc_Newobject00010
                                        oc_Newobject00010 = new ObjectCreator("GuiTextEditCtrl", "", typeof(ESettingsWindow.ESettingsWindowColorEdit));
                                        oc_Newobject00010["historySize"] = "0";
                                        oc_Newobject00010["tabComplete"] = "0";
                                        oc_Newobject00010["sinkAllKeyEvents"] = "0";
                                        oc_Newobject00010["password"] = "0";
                                        oc_Newobject00010["passwordMask"] = "*";
                                        oc_Newobject00010["maxLength"] = "1024";
                                        oc_Newobject00010["margin"] = "0 0 0 0";
                                        oc_Newobject00010["padding"] = "0 0 0 0";
                                        oc_Newobject00010["anchorTop"] = "1";
                                        oc_Newobject00010["anchorBottom"] = "0";
                                        oc_Newobject00010["anchorLeft"] = "1";
                                        oc_Newobject00010["anchorRight"] = "0";
                                        oc_Newobject00010["position"] = "80 0";
                                        oc_Newobject00010["extent"] = "104 18";
                                        oc_Newobject00010["minExtent"] = "8 2";
                                        oc_Newobject00010["horizSizing"] = "width";
                                        oc_Newobject00010["vertSizing"] = "bottom";
                                        oc_Newobject00010["profile"] = "GuiTextEditProfile";
                                        oc_Newobject00010["visible"] = "1";
                                        oc_Newobject00010["active"] = "1";
                                        oc_Newobject00010["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00010["hovertime"] = "1000";
                                        oc_Newobject00010["isContainer"] = "0";
                                        oc_Newobject00010["internalName"] = "ColorEdit";
                                        //oc_Newobject00010["class"] = "ESettingsWindowColorEdit";
                                        oc_Newobject00010["canSave"] = "1";
                                        oc_Newobject00010["canSaveDynamicFields"] = "1";
                                        #endregion

                                        oc_Newobject00012["#Newobject00010"] = oc_Newobject00010;

                                        #region GuiSwatchButtonCtrl ()        oc_Newobject00011
                                        oc_Newobject00011 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof(ESettingsWindow.ESettingsWindowColorButton));
                                        oc_Newobject00011["color"] = "0 0 0 0";
                                        oc_Newobject00011["groupNum"] = "-1";
                                        oc_Newobject00011["buttonType"] = "PushButton";
                                        oc_Newobject00011["useMouseEvents"] = "0";
                                        oc_Newobject00011["position"] = "188 2";
                                        oc_Newobject00011["extent"] = "14 14";
                                        oc_Newobject00011["minExtent"] = "8 2";
                                        oc_Newobject00011["horizSizing"] = "left";
                                        oc_Newobject00011["vertSizing"] = "bottom";
                                        oc_Newobject00011["profile"] = "GuiDefaultProfile";
                                        oc_Newobject00011["visible"] = "1";
                                        oc_Newobject00011["active"] = "1";
                                        oc_Newobject00011["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00011["hovertime"] = "1000";
                                        oc_Newobject00011["isContainer"] = "0";
                                        oc_Newobject00011["internalName"] = "ColorButton";
                                        //oc_Newobject00011["class"] = "ESettingsWindowColorButton";
                                        oc_Newobject00011["canSave"] = "1";
                                        oc_Newobject00011["canSaveDynamicFields"] = "1";
                                        #endregion

                                        oc_Newobject00012["#Newobject00011"] = oc_Newobject00011;

                                    }
                                    #endregion

                                    oc_Newobject00017["#Newobject00012"] = oc_Newobject00012;

                                    #region GuiControl ()        oc_Newobject00016
                                    oc_Newobject00016 = new ObjectCreator("GuiControl", "", typeof(ESettingsWindow.ESettingsWindowColor));
                                    oc_Newobject00016["position"] = "0 21";
                                    oc_Newobject00016["extent"] = "206 18";
                                    oc_Newobject00016["minExtent"] = "8 2";
                                    oc_Newobject00016["horizSizing"] = "right";
                                    oc_Newobject00016["vertSizing"] = "bottom";
                                    oc_Newobject00016["profile"] = "GuiDefaultProfile";
                                    oc_Newobject00016["visible"] = "1";
                                    oc_Newobject00016["active"] = "1";
                                    oc_Newobject00016["tooltipProfile"] = "GuiToolTipProfile";
                                    oc_Newobject00016["hovertime"] = "1000";
                                    oc_Newobject00016["isContainer"] = "1";
                                    //oc_Newobject00016["class"] = "ESettingsWindowColor";
                                    oc_Newobject00016["canSave"] = "1";
                                    oc_Newobject00016["canSaveDynamicFields"] = "1";
                                    oc_Newobject00016["editorSettingsRead"] = "NavEditorPlugin.readSettings();";
                                    oc_Newobject00016["editorSettingsValue"] = "NavEditor/SelectedSplineColor";
                                    oc_Newobject00016["editorSettingsWrite"] = "NavEditorPlugin.writeSettings();";
                                    if (true)
                                    {

                                        #region GuiTextCtrl ()        oc_Newobject00013
                                        oc_Newobject00013 = new ObjectCreator("GuiTextCtrl", "");
                                        oc_Newobject00013["text"] = "Sel. Spline:";
                                        oc_Newobject00013["maxLength"] = "1024";
                                        oc_Newobject00013["margin"] = "0 0 0 0";
                                        oc_Newobject00013["padding"] = "0 0 0 0";
                                        oc_Newobject00013["anchorTop"] = "1";
                                        oc_Newobject00013["anchorBottom"] = "0";
                                        oc_Newobject00013["anchorLeft"] = "1";
                                        oc_Newobject00013["anchorRight"] = "0";
                                        oc_Newobject00013["position"] = "0 1";
                                        oc_Newobject00013["extent"] = "70 16";
                                        oc_Newobject00013["minExtent"] = "8 2";
                                        oc_Newobject00013["horizSizing"] = "right";
                                        oc_Newobject00013["vertSizing"] = "bottom";
                                        oc_Newobject00013["profile"] = "GuiTextRightProfile";
                                        oc_Newobject00013["visible"] = "1";
                                        oc_Newobject00013["active"] = "1";
                                        oc_Newobject00013["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00013["hovertime"] = "1000";
                                        oc_Newobject00013["isContainer"] = "0";
                                        oc_Newobject00013["canSave"] = "1";
                                        oc_Newobject00013["canSaveDynamicFields"] = "1";
                                        #endregion

                                        oc_Newobject00016["#Newobject00013"] = oc_Newobject00013;

                                        #region GuiTextEditCtrl ()        oc_Newobject00014
                                        oc_Newobject00014 = new ObjectCreator("GuiTextEditCtrl", "", typeof(ESettingsWindow.ESettingsWindowColorEdit));
                                        oc_Newobject00014["historySize"] = "0";
                                        oc_Newobject00014["tabComplete"] = "0";
                                        oc_Newobject00014["sinkAllKeyEvents"] = "0";
                                        oc_Newobject00014["password"] = "0";
                                        oc_Newobject00014["passwordMask"] = "*";
                                        oc_Newobject00014["maxLength"] = "1024";
                                        oc_Newobject00014["margin"] = "0 0 0 0";
                                        oc_Newobject00014["padding"] = "0 0 0 0";
                                        oc_Newobject00014["anchorTop"] = "1";
                                        oc_Newobject00014["anchorBottom"] = "0";
                                        oc_Newobject00014["anchorLeft"] = "1";
                                        oc_Newobject00014["anchorRight"] = "0";
                                        oc_Newobject00014["position"] = "80 0";
                                        oc_Newobject00014["extent"] = "104 18";
                                        oc_Newobject00014["minExtent"] = "8 2";
                                        oc_Newobject00014["horizSizing"] = "width";
                                        oc_Newobject00014["vertSizing"] = "bottom";
                                        oc_Newobject00014["profile"] = "GuiTextEditProfile";
                                        oc_Newobject00014["visible"] = "1";
                                        oc_Newobject00014["active"] = "1";
                                        oc_Newobject00014["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00014["hovertime"] = "1000";
                                        oc_Newobject00014["isContainer"] = "0";
                                        oc_Newobject00014["internalName"] = "ColorEdit";
                                        //oc_Newobject00014["class"] = "ESettingsWindowColorEdit";
                                        oc_Newobject00014["canSave"] = "1";
                                        oc_Newobject00014["canSaveDynamicFields"] = "1";
                                        #endregion

                                        oc_Newobject00016["#Newobject00014"] = oc_Newobject00014;

                                        #region GuiSwatchButtonCtrl ()        oc_Newobject00015
                                        oc_Newobject00015 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof(ESettingsWindow.ESettingsWindowColorButton));
                                        oc_Newobject00015["color"] = "0 0 0 0";
                                        oc_Newobject00015["groupNum"] = "-1";
                                        oc_Newobject00015["buttonType"] = "PushButton";
                                        oc_Newobject00015["useMouseEvents"] = "0";
                                        oc_Newobject00015["position"] = "188 2";
                                        oc_Newobject00015["extent"] = "14 14";
                                        oc_Newobject00015["minExtent"] = "8 2";
                                        oc_Newobject00015["horizSizing"] = "left";
                                        oc_Newobject00015["vertSizing"] = "bottom";
                                        oc_Newobject00015["profile"] = "GuiDefaultProfile";
                                        oc_Newobject00015["visible"] = "1";
                                        oc_Newobject00015["active"] = "1";
                                        oc_Newobject00015["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00015["hovertime"] = "1000";
                                        oc_Newobject00015["isContainer"] = "0";
                                        oc_Newobject00015["internalName"] = "ColorButton";
                                        //oc_Newobject00015["class"] = "ESettingsWindowColorButton";
                                        oc_Newobject00015["canSave"] = "1";
                                        oc_Newobject00015["canSaveDynamicFields"] = "1";
                                        #endregion

                                        oc_Newobject00016["#Newobject00015"] = oc_Newobject00015;

                                    }
                                    #endregion

                                    oc_Newobject00017["#Newobject00016"] = oc_Newobject00016;

                                }
                                #endregion

                                oc_Newobject00018["#Newobject00017"] = oc_Newobject00017;

                            }
                            #endregion

                            oc_Newobject00019["#Newobject00018"] = oc_Newobject00018;

                        }
                        #endregion

                        oc_Newobject00020["#Newobject00019"] = oc_Newobject00019;

                    }
                    #endregion

                    oc_Newobject00021["#Newobject00020"] = oc_Newobject00020;

                }
                #endregion
                oc_Newobject00021.Create();

            }
        }

        [ConsoleInteraction]
        public void init()
        {
            // Initialises the settings controls in the settings dialog box.
            GuiPopUpMenuCtrlEx SpawnClassOptions = FOT("SpawnClassOptions");
            SpawnClassOptions.clear();
            SpawnClassOptions.add("AIPlayer");
            SpawnClassOptions.setFirstSelected();
        }
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==( ENavEditorSettingsPage ts, string simobjectid)
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
        public static bool operator !=( ENavEditorSettingsPage ts, string simobjectid)
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
        public static implicit operator string( ENavEditorSettingsPage ts)
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
        public static implicit operator  ENavEditorSettingsPage(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return ( ENavEditorSettingsPage) Omni.self.getSimObject(simobjectid, typeof ( ENavEditorSettingsPage));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ENavEditorSettingsPage ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator  ENavEditorSettingsPage(int simobjectid)
            {
            return ( ENavEditorSettingsPage) Omni.self.getSimObject((uint) simobjectid, typeof ( ENavEditorSettingsPage));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ENavEditorSettingsPage ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator  ENavEditorSettingsPage(uint simobjectid)
            {
            return ( ENavEditorSettingsPage) Omni.self.getSimObject(simobjectid, typeof ( ENavEditorSettingsPage));
            }

        #endregion
    }
}
