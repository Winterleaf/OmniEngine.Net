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
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
{
    [TypeConverter(typeof (EManageSFXParameters))]
    public class EManageSFXParameters : GuiWindowCollapseCtrl
    {
        internal PersistenceManager persistenceMgr
        {
            get { return this["persistenceMgr"]; }
            set { this["persistenceMgr"] = value; }
        }

        //=============================================================================
        //    EManageSFXParameters.
        //=============================================================================

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void createNewParameter(string name)
        {
            ObjectCreator sfxCreator = new ObjectCreator("SFXParameter");
            sfxCreator["internalName"] = name;

            SFXParameter parameter = sfxCreator.Create();

            if (!parameter.isObject())
                return;

            parameter.setFilename(sGlobal["$SFX_PARAMETER_FILE"]);
            this.persistenceMgr.setDirty(parameter);
            this.persistenceMgr.saveDirty();

            this.addParameter(parameter);
        }

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void showDeleteParameterDlg(SFXParameter parameter)
        {
            messageBox.MessageBoxOKCancel("Confirmation", "Really delete '" + parameter.getInternalName() + "'?" + '\n' + "" + '\n' + "The parameter will be removed from the file '" + parameter.getFilename() + "'.", this + ".deleteParameter( " + parameter + " );");
        }

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void deleteParameter(SFXParameter parameter)
        {
            this.removeParameter(parameter);
            if (parameter.getFilename() != "")
                this.persistenceMgr.removeObjectFromFile(parameter);

            parameter.delete();
        }

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void saveParameter(SFXParameter parameter)
        {
            if (parameter.getFilename() != "")
                {
                if (!this.persistenceMgr.isDirty(parameter))
                    this.persistenceMgr.setDirty(parameter);

                this.persistenceMgr.saveDirty();
                }
        }

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onWake()
        {
            GuiStackControl SFXParametersStack = this.FOT("SFXParametersStack");

            // If the parameter list is empty, add all SFXParameters in the
            // SFXParameterGroup to the list.

            if (SFXParametersStack.getCount() == 0)
                this.initList("");

            if (!this.persistenceMgr.isObject())
                this.persistenceMgr = new ObjectCreator("PersistenceManager").Create();
        }

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onVisible(bool state)
        {
            if (state)
                {
                // Schedule an update.
                //TODO
                this.schedule(sGlobal["$SFX_PARAMETERS_UPDATE_INTERVAL"], "update");
                }
        }

        //-----------------------------------------------------------------------------

        /// Populate the parameter list with the currently defined SFXParameters.
        [ConsoleInteraction]
        public void initList(string filter)
        {
            GuiStackControl SFXParametersStack = this.FOT("SFXParametersStack");
            SimSet SFXParameterGroup = "SFXParameterGroup";

            // Clear the current lists.

            SFXParametersStack.clear();

            // Add each SFXParameter in SFXParameterGroup.

            for (uint i = 0; i < SFXParameterGroup.getCount(); i++)
                {
                SimObject obj = SFXParameterGroup.getObject(i);
                if (!Util.isMemberOfClass(obj.getClassName(), "SFXParameter"))
                    continue;

                // If we have a filter, search for it in the parameter's
                // categories.

                bool matchesFilter = true;
                if (filter != "")
                    {
                    matchesFilter = false;

                    for (int idx = 0; obj["categories[" + idx + "]"] != ""; idx ++)
                        {
                        if (obj["categories[" + idx + "]"] == filter)
                            {
                            matchesFilter = true;
                            break;
                            }
                        }
                    }

                if (matchesFilter)
                    this.addParameter((SFXParameter) obj);
                }

            // Init the filters.

            this.initFilterList(filter);
        }

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void initFilterList(string selectFilter)
        {
            GuiPopUpMenuCtrl SFXParameterFilter = this.FOT("SFXParameterFilter");
            SimSet SFXParameterGroup = "SFXParameterGroup";

            GuiPopUpMenuCtrl filterList = SFXParameterFilter;
            filterList.clear();
            filterList.add("", 0);

            for (uint i = 0; i < SFXParameterGroup.getCount(); i++)
                {
                SimObject obj = SFXParameterGroup.getObject(i);
                if (!Util.isMemberOfClass(obj.getClassName(), "SFXParameter"))
                    continue;

                for (int idx = 0; obj["categories[" + idx + "]"] != ""; idx ++)
                    {
                    string category = obj["categories[" + idx + "]"];
                    if (filterList.findText(category) == -1)
                        filterList.add(category, filterList.size());
                    }
                }

            // Sort the filters.

            filterList.sort();
            filterList.setSelected(filterList.findText(selectFilter), false);
        }

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        /// Parse the categories for the parameter from the given comma-separated list.
        public void updateParameterCategories(SFXParameter parameter, string list)
        {
            GuiPopUpMenuCtrl SFXParameterFilter = this.FOT("SFXParameterFilter");

            this.persistenceMgr.setDirty(parameter);

            // Parse the list.

            int len = Util.strlen(list);
            int pos = 0;

            int idx = 0;
            while (pos < len)
                {
                int startPos = pos;
                pos = Util.strchrpos(list, ",", pos);
                if (pos == -1)
                    pos = len;

                if (pos > startPos)
                    {
                    string category = Util.getSubStr(list, startPos, pos - startPos);
                    category = Util.trim(category);
                    parameter["categories[" + idx + "]"] = category;
                    idx ++;
                    }

                pos ++;
                }

            // Clear out excess categories existing from before.

            while (parameter["categories[" + idx + "]"] != "")
                {
                parameter["categories[" + idx + "]"] = "";
                this.persistenceMgr.removeField(parameter, "categories" + idx);
                idx ++;
                }

            // Save the parameter.

            this.saveParameter(parameter);

            // Re-initialize the filter list.

            this.initFilterList(SFXParameterFilter.getText());
        }

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        // Add a new SFXParameter to the list.
        public void addParameter(SFXParameter parameter)
        {
            GuiStackControl SFXParametersStack = this.FOT("SFXParametersStack");

            #region GuiRolloutCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject23["Margin"] = "0 0 0 0";
            oc_Newobject23["DefaultHeight"] = "40";
            oc_Newobject23["Expanded"] = "1";
            oc_Newobject23["ClickCollapse"] = "1";
            oc_Newobject23["HideHeader"] = "0";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["Profile"] = "GuiRolloutProfile";
            oc_Newobject23["HorizSizing"] = "right";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["position"] = "0 0";
            oc_Newobject23["Extent"] = "421 114";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["caption"] = parameter.getInternalName();

            #region GuiControl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiControl", "");
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = "0 17";
            oc_Newobject22["Extent"] = "421 94";
            oc_Newobject22["MinExtent"] = "421 94";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "Value";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "7 4";
            oc_Newobject3["Extent"] = "27 17";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Channel";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "7 27";
            oc_Newobject4["Extent"] = "45 17";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "Comment";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "7 50";
            oc_Newobject5["Extent"] = "47 17";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["text"] = "Tags";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "7 73";
            oc_Newobject6["Extent"] = "25 17";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject6"] = oc_Newobject6;

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["text"] = "Min";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject7["HorizSizing"] = "left";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "205 27";
            oc_Newobject7["Extent"] = "17 17";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["text"] = "Max";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject8["HorizSizing"] = "left";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "271 27";
            oc_Newobject8["Extent"] = "21 17";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject8"] = oc_Newobject8;

            #region GuiTextCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject9["text"] = "Initial";
            oc_Newobject9["maxLength"] = "1024";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject9["HorizSizing"] = "left";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "340 27";
            oc_Newobject9["Extent"] = "24 17";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject9"] = oc_Newobject9;

            #region GuiSliderCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject10["range"] = "0 1";
            oc_Newobject10["ticks"] = "0";
            oc_Newobject10["snap"] = "0";
            oc_Newobject10["value"] = "0.5";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "65 5";
            oc_Newobject10["Extent"] = "263 15";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["internalName"] = "valueSlider";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["command"] = parameter + ".value = $thisControl.getValue();";

            #endregion

            oc_Newobject22["#Newobject10"] = oc_Newobject10;

            #region GuiTextEditCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject11["historySize"] = "0";
            oc_Newobject11["password"] = "0";
            oc_Newobject11["tabComplete"] = "0";
            oc_Newobject11["sinkAllKeyEvents"] = "0";
            oc_Newobject11["passwordMask"] = "•";
            oc_Newobject11["maxLength"] = "1024";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject11["HorizSizing"] = "left";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "336 4";
            oc_Newobject11["Extent"] = "39 17";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["internalName"] = "valueField";
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["altCommand"] = parameter + ".value = $thisControl.getValue();";

            #endregion

            oc_Newobject22["#Newobject11"] = oc_Newobject11;

            #region GuiBitmapButtonCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject12["bitmap"] = "tools/gui/images/reset-icon";
            oc_Newobject12["autoFit"] = "0";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["buttonType"] = "PushButton";
            oc_Newobject12["useMouseEvents"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "left";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "381 4";
            oc_Newobject12["Extent"] = "17 17";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["internalName"] = "resetButton";
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["command"] = parameter + ".reset();";

            #endregion

            oc_Newobject22["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapButtonCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject13["bitmap"] = "tools/gui/images/delete";
            oc_Newobject13["autoFit"] = "0";
            oc_Newobject13["groupNum"] = "-1";
            oc_Newobject13["buttonType"] = "PushButton";
            oc_Newobject13["useMouseEvents"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["HorizSizing"] = "left";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "398 4";
            oc_Newobject13["Extent"] = "17 17";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["internalName"] = "deleteButton";
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["command"] = "EManageSFXParameters.showDeleteParameterDlg( " + parameter + ");";

            #endregion

            oc_Newobject22["#Newobject13"] = oc_Newobject13;

            #region GuiPopUpMenuCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject14["maxPopupHeight"] = "200";
            oc_Newobject14["sbUsesNAColor"] = "0";
            oc_Newobject14["reverseTextList"] = "0";
            oc_Newobject14["bitmapBounds"] = "16 16";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "65 26";
            oc_Newobject14["Extent"] = "135 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["internalName"] = "channelDropdown";
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["command"] = parameter + ".channel = $ThisControl.getText(); EManageSFXParameters.saveParameter( " + parameter + ");";

            #endregion

            oc_Newobject22["#Newobject14"] = oc_Newobject14;

            #region GuiTextEditCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject15["historySize"] = "0";
            oc_Newobject15["password"] = "0";
            oc_Newobject15["tabComplete"] = "0";
            oc_Newobject15["sinkAllKeyEvents"] = "0";
            oc_Newobject15["passwordMask"] = "•";
            oc_Newobject15["maxLength"] = "1024";
            oc_Newobject15["Margin"] = "0 0 0 0";
            oc_Newobject15["Padding"] = "0 0 0 0";
            oc_Newobject15["AnchorTop"] = "1";
            oc_Newobject15["AnchorBottom"] = "0";
            oc_Newobject15["AnchorLeft"] = "1";
            oc_Newobject15["AnchorRight"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject15["HorizSizing"] = "width";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "65 50";
            oc_Newobject15["Extent"] = "350 17";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["internalName"] = "descriptionField";
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["altCommand"] = parameter + ".description = $ThisControl.getText(); EManageSFXParameters.saveParameter( " + parameter + ");";

            #endregion

            oc_Newobject22["#Newobject15"] = oc_Newobject15;

            #region GuiTextEditCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject16["historySize"] = "0";
            oc_Newobject16["password"] = "0";
            oc_Newobject16["tabComplete"] = "0";
            oc_Newobject16["sinkAllKeyEvents"] = "0";
            oc_Newobject16["passwordMask"] = "•";
            oc_Newobject16["maxLength"] = "1024";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "65 73";
            oc_Newobject16["Extent"] = "230 17";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["internalName"] = "tagsField";
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["altCommand"] = "EManageSFXParameters.updateParameterCategories( " + parameter + ", $ThisControl.getText() );";

            #endregion

            oc_Newobject22["#Newobject16"] = oc_Newobject16;

            #region GuiTextEditCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject17["historySize"] = "0";
            oc_Newobject17["password"] = "0";
            oc_Newobject17["tabComplete"] = "0";
            oc_Newobject17["sinkAllKeyEvents"] = "0";
            oc_Newobject17["passwordMask"] = "•";
            oc_Newobject17["maxLength"] = "1024";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject17["HorizSizing"] = "left";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "372 27";
            oc_Newobject17["Extent"] = "43 17";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["internalName"] = "defaultField";
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["command"] = parameter + ".defaultValue = $ThisControl.getValue(); EManageSFXParameters.saveParameter( " + parameter + ");";

            #endregion

            oc_Newobject22["#Newobject17"] = oc_Newobject17;

            #region GuiTextEditCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject18["historySize"] = "0";
            oc_Newobject18["password"] = "0";
            oc_Newobject18["tabComplete"] = "0";
            oc_Newobject18["sinkAllKeyEvents"] = "0";
            oc_Newobject18["passwordMask"] = "•";
            oc_Newobject18["maxLength"] = "1024";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject18["HorizSizing"] = "left";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = "297 27";
            oc_Newobject18["Extent"] = "39 17";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["internalName"] = "rangeMaxField";
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["altCommand"] = parameter + ".range = " + parameter + ".range.x SPC $ThisControl.getValue(); $ThisControl.parentGroup-->valueSlider.range = " + parameter + ".range; EManageSFXParameters.saveParameter( " + parameter + ");";

            #endregion

            oc_Newobject22["#Newobject18"] = oc_Newobject18;

            #region GuiTextEditCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject19["historySize"] = "0";
            oc_Newobject19["password"] = "0";
            oc_Newobject19["tabComplete"] = "0";
            oc_Newobject19["sinkAllKeyEvents"] = "0";
            oc_Newobject19["passwordMask"] = "•";
            oc_Newobject19["maxLength"] = "1024";
            oc_Newobject19["Margin"] = "0 0 0 0";
            oc_Newobject19["Padding"] = "0 0 0 0";
            oc_Newobject19["AnchorTop"] = "1";
            oc_Newobject19["AnchorBottom"] = "0";
            oc_Newobject19["AnchorLeft"] = "1";
            oc_Newobject19["AnchorRight"] = "0";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject19["HorizSizing"] = "left";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "229 27";
            oc_Newobject19["Extent"] = "39 17";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["internalName"] = "rangeMinField";
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["altCommand"] = parameter + ".range = $ThisControl.getValue() SPC " + parameter + ".range.y; $ThisControl.parentGroup-->valueSlider.range = " + parameter + ".range; EManageSFXParameters.saveParameter( " + parameter + ");";

            #endregion

            oc_Newobject22["#Newobject19"] = oc_Newobject19;

            #region GuiCheckBoxCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject20["useInactiveState"] = "0";
            oc_Newobject20["text"] = "Local";
            oc_Newobject20["groupNum"] = "-1";
            oc_Newobject20["buttonType"] = "ToggleButton";
            oc_Newobject20["useMouseEvents"] = "0";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject20["HorizSizing"] = "left";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "302 73";
            oc_Newobject20["Extent"] = "45 17";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["internalName"] = "localCheckbox";
            oc_Newobject20["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject20"] = oc_Newobject20;

            #region GuiPopUpMenuCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject21["maxPopupHeight"] = "200";
            oc_Newobject21["sbUsesNAColor"] = "0";
            oc_Newobject21["reverseTextList"] = "0";
            oc_Newobject21["bitmapBounds"] = "16 16";
            oc_Newobject21["maxLength"] = "1024";
            oc_Newobject21["Margin"] = "0 0 0 0";
            oc_Newobject21["Padding"] = "0 0 0 0";
            oc_Newobject21["AnchorTop"] = "1";
            oc_Newobject21["AnchorBottom"] = "0";
            oc_Newobject21["AnchorLeft"] = "1";
            oc_Newobject21["AnchorRight"] = "0";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject21["HorizSizing"] = "left";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["position"] = "349 73";
            oc_Newobject21["Extent"] = "64 17";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["internalName"] = "sourceDropdown";
            oc_Newobject21["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            GuiRolloutCtrl ctrl = oc_Newobject23.Create();

            ctrl["sfxParameter"] = parameter;

            // Deactivate the per-source controls for now as these are not
            // yet implemented in SFX.

            GuiCheckBoxCtrl localCheckbox = ctrl.FOT("localCheckbox");
            GuiPopUpMenuCtrl sourceDropdown = ctrl.FOT("sourceDropdown");
            GuiTextEditCtrl valueField = ctrl.FOT("valueField");
            GuiTextEditCtrl rangeMinField = ctrl.FOT("rangeMinField");
            GuiTextEditCtrl rangeMaxField = ctrl.FOT("rangeMaxField");
            GuiTextEditCtrl defaultField = ctrl.FOT("defaultField");
            GuiTextEditCtrl descriptionField = ctrl.FOT("descriptionField");
            GuiSliderCtrl valueSlider = ctrl.FOT("valueSlider");
            GuiPopUpMenuCtrl channelDropdown = ctrl.FOT("channelDropdown");
            GuiTextEditCtrl tagsField = ctrl.FOT("tagsField");

            localCheckbox.setActive(false);
            sourceDropdown.setActive(false);

            // Set the fields to reflect the parameter's current settings.

            valueField.setValue(parameter.value.AsString());
            rangeMinField.setText(parameter.range.x.AsString());
            rangeMaxField.setText(parameter.range.y.AsString());
            defaultField.setValue(parameter.defaultValue.AsString());
            descriptionField.setText(parameter.description);

            valueSlider.range = parameter.range;
            valueSlider.setValue(parameter.value.AsString());

            // Set up the channels dropdown.

            GuiPopUpMenuCtrl list = channelDropdown;
            for (int i = 0; i < iGlobal["$SFX_PARAMETER_CHANNELS_COUNT"]; i ++)
                list.add(sGlobal["$SFX_PARAMETER_CHANNELS[" + i + "]"], i);
            list.sort();
            list.setSelected(list.findText(parameter["channel"]));

            SFXParametersStack.addGuiControl(ctrl);

            // Fill tagging field.

            string tags = "";
            bool isFirst = true;
            for (int i = 0; parameter["categories[" + i + "]"] != ""; i ++)
                {
                if (!isFirst)
                    tags = tags + ", ";

                tags = tags + parameter["categories[" + i + "]"];

                isFirst = false;
                }

            tagsField.setText(tags);
        }

        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void removeParameter(SFXParameter parameter)
        {
            GuiStackControl SFXParametersStack = this.FOT("SFXParametersStack");

            for (uint i = 0; i < SFXParametersStack.getCount(); i++)
                {
                SimObject ctrl = SFXParametersStack.getObject(i);

                if (ctrl["sfxParameter"] == parameter)
                    {
                    ctrl.delete();
                    break;
                    }
                }
        }

        //-----------------------------------------------------------------------------
        [ConsoleInteraction]
        public void update()
        {
            GuiStackControl SFXParametersStack = this.FOT("SFXParametersStack");

            for (uint i = 0; i < SFXParametersStack.getCount(); i++)
                {
                // If either the value field or the slider are currently being
                // edited, don't update the value in order to not interfere with
                // user editing.

                GuiControl ctrl = SFXParametersStack.getObject(i);

                GuiTextEditCtrl valueField = ctrl.FOT("valueField");
                GuiSliderCtrl valueSlider = ctrl.FOT("valueSlider");

                if (valueField.isFirstResponder() || valueSlider.isThumbBeingDragged())
                    continue;

                SFXParameter parameter = ctrl["sfxParameter"];

                valueField.setValue(parameter.value.AsString());
                valueSlider.setValue(parameter.value.AsString());
                }

            // If the control is still awake, schedule another
            // update.

            if (this.isVisible())
                this.schedule(iGlobal["$SFX_PARAMETERS_UPDATE_INTERVAL"].AsString(), "update");
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EManageSFXParameters ts, string simobjectid)
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
        public static bool operator !=(EManageSFXParameters ts, string simobjectid)
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
        public static implicit operator string(EManageSFXParameters ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EManageSFXParameters(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (EManageSFXParameters) Omni.self.getSimObject(simobjectid, typeof (EManageSFXParameters));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EManageSFXParameters ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EManageSFXParameters(int simobjectid)
        {
            return (EManageSFXParameters) Omni.self.getSimObject((uint) simobjectid, typeof (EManageSFXParameters));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EManageSFXParameters ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EManageSFXParameters(uint simobjectid)
        {
            return (EManageSFXParameters) Omni.self.getSimObject(simobjectid, typeof (EManageSFXParameters));
        }

        #endregion
    }
}