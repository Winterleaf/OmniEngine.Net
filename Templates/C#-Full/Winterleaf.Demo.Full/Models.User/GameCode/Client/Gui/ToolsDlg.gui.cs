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
using System.Diagnostics;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ToolsDlg>))]
    public class ToolsDlg : GuiControl
    {
        [ConsoleInteraction]
        public static void initialize()
        {
            ObjectCreator oc_Newobject00006;
            ObjectCreator oc_Newobject00005;
            ObjectCreator oc_Newobject00004;
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
                {
                #region GuiControl (ToolsDlg)        oc_Newobject00006

                oc_Newobject00006 = new ObjectCreator("GuiControl", "ToolsDlg", typeof (ToolsDlg));
                oc_Newobject00006["position"] = "0 0";
                oc_Newobject00006["extent"] = "1024 768";
                oc_Newobject00006["minExtent"] = "8 2";
                oc_Newobject00006["maxExtent"] = "1920 1080";
                oc_Newobject00006["horizSizing"] = "right";
                oc_Newobject00006["vertSizing"] = "bottom";
                oc_Newobject00006["profile"] = "GuiOverlayProfile";
                oc_Newobject00006["controlFontColor"] = "0 0 0 0";
                oc_Newobject00006["controlFillColor"] = "0 0 0 0";
                oc_Newobject00006["backgroundColor"] = "255 255 255 255";
                oc_Newobject00006["controlFontSize"] = "14";
                oc_Newobject00006["visible"] = "1";
                oc_Newobject00006["active"] = "1";
                oc_Newobject00006["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject00006["hovertime"] = "1000";
                oc_Newobject00006["isContainer"] = "1";
                oc_Newobject00006["alphaValue"] = "1";
                oc_Newobject00006["mouseOverAlphaValue"] = "1";
                oc_Newobject00006["alphaFadeTime"] = "1000";
                oc_Newobject00006["moveControl"] = "0";
                oc_Newobject00006["lockControl"] = "0";
                oc_Newobject00006["windowSettings"] = "1";
                oc_Newobject00006["alpha"] = "1";
                oc_Newobject00006["mouseOverAlpha"] = "1";
                oc_Newobject00006["alphaFade"] = "1";
                oc_Newobject00006["contextFontColor"] = "0";
                oc_Newobject00006["contextBackColor"] = "0";
                oc_Newobject00006["contextFillColor"] = "0";
                oc_Newobject00006["contextFontSize"] = "0";
                oc_Newobject00006["editable"] = "0";
                oc_Newobject00006["canSave"] = "1";
                oc_Newobject00006["canSaveDynamicFields"] = "1";
                oc_Newobject00006["Enabled"] = "1";
                if (true)
                    {
                    #region GuiWindowCtrl ()        oc_Newobject00005

                    oc_Newobject00005 = new ObjectCreator("GuiWindowCtrl", "");
                    oc_Newobject00005["text"] = "Tools for OMNI";
                    oc_Newobject00005["resizeWidth"] = "1";
                    oc_Newobject00005["resizeHeight"] = "1";
                    oc_Newobject00005["canMove"] = "1";
                    oc_Newobject00005["canClose"] = "1";
                    oc_Newobject00005["canMinimize"] = "1";
                    oc_Newobject00005["canMaximize"] = "1";
                    oc_Newobject00005["canCollapse"] = "0";
                    oc_Newobject00005["edgeSnap"] = "1";
                    oc_Newobject00005["setTitle"] = "0";
                    oc_Newobject00005["ShowTitle"] = "1";
                    oc_Newobject00005["AllowPopWindow"] = "0";
                    oc_Newobject00005["isInPopup"] = "0";
                    oc_Newobject00005["margin"] = "0 0 0 0";
                    oc_Newobject00005["padding"] = "0 0 0 0";
                    oc_Newobject00005["anchorTop"] = "1";
                    oc_Newobject00005["anchorBottom"] = "0";
                    oc_Newobject00005["anchorLeft"] = "1";
                    oc_Newobject00005["anchorRight"] = "0";
                    oc_Newobject00005["position"] = "100 134";
                    oc_Newobject00005["extent"] = "824 499";
                    oc_Newobject00005["minExtent"] = "8 2";
                    oc_Newobject00005["maxExtent"] = "1920 1080";
                    oc_Newobject00005["horizSizing"] = "center";
                    oc_Newobject00005["vertSizing"] = "center";
                    oc_Newobject00005["profile"] = "GuiWindowProfile";
                    oc_Newobject00005["controlFontColor"] = "0 0 0 0";
                    oc_Newobject00005["controlFillColor"] = "0 0 0 0";
                    oc_Newobject00005["backgroundColor"] = "255 255 255 255";
                    oc_Newobject00005["controlFontSize"] = "14";
                    oc_Newobject00005["visible"] = "1";
                    oc_Newobject00005["active"] = "1";
                    oc_Newobject00005["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00005["hovertime"] = "1000";
                    oc_Newobject00005["isContainer"] = "1";
                    oc_Newobject00005["alphaValue"] = "1";
                    oc_Newobject00005["mouseOverAlphaValue"] = "1";
                    oc_Newobject00005["alphaFadeTime"] = "1000";
                    oc_Newobject00005["moveControl"] = "1";
                    oc_Newobject00005["lockControl"] = "0";
                    oc_Newobject00005["windowSettings"] = "1";
                    oc_Newobject00005["alpha"] = "1";
                    oc_Newobject00005["mouseOverAlpha"] = "1";
                    oc_Newobject00005["alphaFade"] = "1";
                    oc_Newobject00005["contextFontColor"] = "0";
                    oc_Newobject00005["contextBackColor"] = "0";
                    oc_Newobject00005["contextFillColor"] = "0";
                    oc_Newobject00005["contextFontSize"] = "0";
                    oc_Newobject00005["editable"] = "0";
                    oc_Newobject00005["canSave"] = "1";
                    oc_Newobject00005["canSaveDynamicFields"] = "0";
                    oc_Newobject00005["Enabled"] = "1";
                    oc_Newobject00005["closeCommand"] = "Canvas.popDialog(ToolsDlg);";
                    if (true)
                        {
                        #region GuiControl ()        oc_Newobject00002

                        oc_Newobject00002 = new ObjectCreator("GuiControl", "");
                        oc_Newobject00002["position"] = "6 26";
                        oc_Newobject00002["extent"] = "806 45";
                        oc_Newobject00002["minExtent"] = "8 2";
                        oc_Newobject00002["maxExtent"] = "1920 1080";
                        oc_Newobject00002["horizSizing"] = "right";
                        oc_Newobject00002["vertSizing"] = "bottom";
                        oc_Newobject00002["profile"] = "GuiDefaultProfile";
                        oc_Newobject00002["controlFontColor"] = "0 0 0 0";
                        oc_Newobject00002["controlFillColor"] = "0 0 0 0";
                        oc_Newobject00002["backgroundColor"] = "255 255 255 255";
                        oc_Newobject00002["controlFontSize"] = "14";
                        oc_Newobject00002["visible"] = "1";
                        oc_Newobject00002["active"] = "1";
                        oc_Newobject00002["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00002["hovertime"] = "1000";
                        oc_Newobject00002["isContainer"] = "1";
                        oc_Newobject00002["alphaValue"] = "1";
                        oc_Newobject00002["mouseOverAlphaValue"] = "1";
                        oc_Newobject00002["alphaFadeTime"] = "1000";
                        oc_Newobject00002["moveControl"] = "0";
                        oc_Newobject00002["lockControl"] = "0";
                        oc_Newobject00002["windowSettings"] = "1";
                        oc_Newobject00002["alpha"] = "1";
                        oc_Newobject00002["mouseOverAlpha"] = "1";
                        oc_Newobject00002["alphaFade"] = "1";
                        oc_Newobject00002["contextFontColor"] = "0";
                        oc_Newobject00002["contextBackColor"] = "0";
                        oc_Newobject00002["contextFillColor"] = "0";
                        oc_Newobject00002["contextFontSize"] = "0";
                        oc_Newobject00002["editable"] = "0";
                        oc_Newobject00002["canSave"] = "1";
                        oc_Newobject00002["canSaveDynamicFields"] = "0";
                        oc_Newobject00002["Enabled"] = "1";
                        if (true)
                            {
                            #region GuiTextCtrl ()        oc_Newobject00001

                            oc_Newobject00001 = new ObjectCreator("GuiTextCtrl", "");
                            oc_Newobject00001["text"] = "TOOLS";
                            oc_Newobject00001["maxLength"] = "1024";
                            oc_Newobject00001["margin"] = "0 0 0 0";
                            oc_Newobject00001["padding"] = "0 0 0 0";
                            oc_Newobject00001["anchorTop"] = "1";
                            oc_Newobject00001["anchorBottom"] = "0";
                            oc_Newobject00001["anchorLeft"] = "1";
                            oc_Newobject00001["anchorRight"] = "0";
                            oc_Newobject00001["position"] = "371 10";
                            oc_Newobject00001["extent"] = "87 24";
                            oc_Newobject00001["minExtent"] = "8 2";
                            oc_Newobject00001["maxExtent"] = "1920 1080";
                            oc_Newobject00001["horizSizing"] = "center";
                            oc_Newobject00001["vertSizing"] = "center";
                            oc_Newobject00001["profile"] = "GuiTextProfile";
                            oc_Newobject00001["controlFontColor"] = "0 0 0 0";
                            oc_Newobject00001["controlFillColor"] = "0 0 0 0";
                            oc_Newobject00001["backgroundColor"] = "255 255 255 255";
                            oc_Newobject00001["controlFontSize"] = "30";
                            oc_Newobject00001["visible"] = "1";
                            oc_Newobject00001["active"] = "1";
                            oc_Newobject00001["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00001["hovertime"] = "1000";
                            oc_Newobject00001["isContainer"] = "1";
                            oc_Newobject00001["alphaValue"] = "1";
                            oc_Newobject00001["mouseOverAlphaValue"] = "1";
                            oc_Newobject00001["alphaFadeTime"] = "1000";
                            oc_Newobject00001["moveControl"] = "0";
                            oc_Newobject00001["lockControl"] = "0";
                            oc_Newobject00001["windowSettings"] = "1";
                            oc_Newobject00001["alpha"] = "1";
                            oc_Newobject00001["mouseOverAlpha"] = "1";
                            oc_Newobject00001["alphaFade"] = "1";
                            oc_Newobject00001["contextFontColor"] = "0";
                            oc_Newobject00001["contextBackColor"] = "0";
                            oc_Newobject00001["contextFillColor"] = "0";
                            oc_Newobject00001["contextFontSize"] = "0";
                            oc_Newobject00001["editable"] = "0";
                            oc_Newobject00001["canSave"] = "1";
                            oc_Newobject00001["canSaveDynamicFields"] = "0";
                            oc_Newobject00001["Enabled"] = "1";

                            #endregion

                            oc_Newobject00002["#Newobject00001"] = oc_Newobject00001;
                            }

                        #endregion

                        oc_Newobject00005["#Newobject00002"] = oc_Newobject00002;

                        #region GuiContainer ()        oc_Newobject00004

                        oc_Newobject00004 = new ObjectCreator("GuiContainer", "");
                        oc_Newobject00004["margin"] = "0 0 0 0";
                        oc_Newobject00004["padding"] = "0 0 0 0";
                        oc_Newobject00004["anchorTop"] = "1";
                        oc_Newobject00004["anchorBottom"] = "0";
                        oc_Newobject00004["anchorLeft"] = "1";
                        oc_Newobject00004["anchorRight"] = "0";
                        oc_Newobject00004["position"] = "14 69";
                        oc_Newobject00004["extent"] = "798 412";
                        oc_Newobject00004["minExtent"] = "8 2";
                        oc_Newobject00004["maxExtent"] = "1920 1080";
                        oc_Newobject00004["horizSizing"] = "right";
                        oc_Newobject00004["vertSizing"] = "bottom";
                        oc_Newobject00004["profile"] = "GuiDefaultProfile";
                        oc_Newobject00004["controlFontColor"] = "0 0 0 0";
                        oc_Newobject00004["controlFillColor"] = "0 0 0 0";
                        oc_Newobject00004["backgroundColor"] = "255 255 255 255";
                        oc_Newobject00004["controlFontSize"] = "14";
                        oc_Newobject00004["visible"] = "1";
                        oc_Newobject00004["active"] = "1";
                        oc_Newobject00004["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00004["hovertime"] = "1000";
                        oc_Newobject00004["isContainer"] = "1";
                        oc_Newobject00004["alphaValue"] = "1";
                        oc_Newobject00004["mouseOverAlphaValue"] = "1";
                        oc_Newobject00004["alphaFadeTime"] = "1000";
                        oc_Newobject00004["moveControl"] = "0";
                        oc_Newobject00004["lockControl"] = "0";
                        oc_Newobject00004["windowSettings"] = "1";
                        oc_Newobject00004["alpha"] = "1";
                        oc_Newobject00004["mouseOverAlpha"] = "1";
                        oc_Newobject00004["alphaFade"] = "1";
                        oc_Newobject00004["contextFontColor"] = "0";
                        oc_Newobject00004["contextBackColor"] = "0";
                        oc_Newobject00004["contextFillColor"] = "0";
                        oc_Newobject00004["contextFontSize"] = "0";
                        oc_Newobject00004["editable"] = "0";
                        oc_Newobject00004["canSave"] = "1";
                        oc_Newobject00004["canSaveDynamicFields"] = "0";
                        oc_Newobject00004["Enabled"] = "1";
                        if (true)
                            {
                            #region GuiDynamicCtrlArrayControl ()        oc_Newobject00003

                            oc_Newobject00003 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
                            oc_Newobject00003["colCount"] = "10";
                            oc_Newobject00003["colSize"] = "185";
                            oc_Newobject00003["rowCount"] = "1";
                            oc_Newobject00003["rowSize"] = "125";
                            oc_Newobject00003["rowSpacing"] = "5";
                            oc_Newobject00003["colSpacing"] = "50";
                            oc_Newobject00003["frozen"] = "0";
                            oc_Newobject00003["fillRowFirst"] = "1";
                            oc_Newobject00003["dynamicSize"] = "0";
                            oc_Newobject00003["padding"] = "0 0 0 0";
                            oc_Newobject00003["position"] = "13 19";
                            oc_Newobject00003["extent"] = "779 379";
                            oc_Newobject00003["minExtent"] = "8 2";
                            oc_Newobject00003["maxExtent"] = "1920 1080";
                            oc_Newobject00003["horizSizing"] = "right";
                            oc_Newobject00003["vertSizing"] = "bottom";
                            oc_Newobject00003["profile"] = "GuiDefaultProfile";
                            oc_Newobject00003["controlFontColor"] = "0 0 0 0";
                            oc_Newobject00003["controlFillColor"] = "0 0 0 0";
                            oc_Newobject00003["backgroundColor"] = "255 255 255 255";
                            oc_Newobject00003["controlFontSize"] = "14";
                            oc_Newobject00003["visible"] = "1";
                            oc_Newobject00003["active"] = "1";
                            oc_Newobject00003["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00003["hovertime"] = "1000";
                            oc_Newobject00003["isContainer"] = "1";
                            oc_Newobject00003["alphaValue"] = "1";
                            oc_Newobject00003["mouseOverAlphaValue"] = "1";
                            oc_Newobject00003["alphaFadeTime"] = "1000";
                            oc_Newobject00003["moveControl"] = "0";
                            oc_Newobject00003["lockControl"] = "0";
                            oc_Newobject00003["windowSettings"] = "1";
                            oc_Newobject00003["alpha"] = "1";
                            oc_Newobject00003["mouseOverAlpha"] = "1";
                            oc_Newobject00003["alphaFade"] = "1";
                            oc_Newobject00003["contextFontColor"] = "0";
                            oc_Newobject00003["contextBackColor"] = "0";
                            oc_Newobject00003["contextFillColor"] = "0";
                            oc_Newobject00003["contextFontSize"] = "0";
                            oc_Newobject00003["internalName"] = "toolsDynamicArray";
                            oc_Newobject00003["editable"] = "0";
                            oc_Newobject00003["canSave"] = "1";
                            oc_Newobject00003["canSaveDynamicFields"] = "0";
                            oc_Newobject00003["Enabled"] = "1";

                            #endregion

                            oc_Newobject00004["#Newobject00003"] = oc_Newobject00003;
                            }

                        #endregion

                        oc_Newobject00005["#Newobject00004"] = oc_Newobject00004;
                        }

                    #endregion

                    oc_Newobject00006["#Newobject00005"] = oc_Newobject00005;
                    }

                #endregion

                oc_Newobject00006.Create();
                }
        }

        [ConsoleInteraction]
        public override void onWake()
        {
            GuiDynamicCtrlArrayControl toolsArray = FOT("toolsDynamicArray");
            toolsArray.clear();

            string cwd = Util.getCurrentDirectory();
            this["cwd"] = Util.filePath(cwd);

            createTool("Clean Shaders", "cleanShaders", toolsArray);
            createTool("Delete Cached DTSs", "DeleteCachedDTSs", toolsArray);
            createTool("Delete DSOs", "DeleteDSOs", toolsArray);
            createTool("Delete Prefs", "DeletePrefs", toolsArray);

            //toolsArray.addGuiControl();
        }

        public void createTool(string tool, string cmd, GuiDynamicCtrlArrayControl toolsArray)
        {
            ObjectCreator oc1 = new ObjectCreator("GuiControl");
            GuiControl container = oc1.Create();

            ObjectCreator oc = new ObjectCreator("GuiBitmapButtonCtrl");
            oc["Extent"] = "108 81";
            oc["position"] = "35 0";
            oc["bitmap"] = "art/gui/no-preview";
            oc["altCommand"] = "ToolsDlg.execute(\\\"" + this["cwd"] + "/" + cmd + ".bat\\\");";
            GuiBitmapButtonCtrl bitmap = oc.Create();

            ObjectCreator oc2 = new ObjectCreator("GuiTextCtrl");
            oc2["text"] = tool;
            oc2["Extent"] = "108 30";
            oc2["position"] = "35 85";
            GuiTextCtrl text = oc2.Create();

            container.addGuiControl(bitmap);
            container.addGuiControl(text);

            toolsArray.addGuiControl(container);
        }

        [ConsoleInteraction]
        public void execute(string filename)
        {
            Process.Start(filename);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ToolsDlg ts, string simobjectid)
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
        public static bool operator !=(ToolsDlg ts, string simobjectid)
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
        public static implicit operator string(ToolsDlg ts)
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
        public static implicit operator ToolsDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ToolsDlg) Omni.self.getSimObject(simobjectid, typeof (ToolsDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ToolsDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ToolsDlg(int simobjectid)
        {
            return (ToolsDlg) Omni.self.getSimObject((uint) simobjectid, typeof (ToolsDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ToolsDlg ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ToolsDlg(uint simobjectid)
        {
            return (ToolsDlg) Omni.self.getSimObject(simobjectid, typeof (ToolsDlg));
        }

        #endregion
    }
}