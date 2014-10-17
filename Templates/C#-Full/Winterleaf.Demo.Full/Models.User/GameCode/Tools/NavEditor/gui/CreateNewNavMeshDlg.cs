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
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<CreateNewNavMeshDlg>))]
    public class CreateNewNavMeshDlg : GuiControl
    {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
        {
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
                #region GuiControl (CreateNewNavMeshDlg)        oc_Newobject00011

                oc_Newobject00011 = new ObjectCreator("GuiControl", "CreateNewNavMeshDlg", typeof (CreateNewNavMeshDlg));
                oc_Newobject00011["position"] = "0 0";
                oc_Newobject00011["extent"] = "1024 768";
                oc_Newobject00011["minExtent"] = "8 2";
                oc_Newobject00011["horizSizing"] = "right";
                oc_Newobject00011["vertSizing"] = "bottom";
                oc_Newobject00011["profile"] = "GuiDefaultProfile";
                oc_Newobject00011["visible"] = "1";
                oc_Newobject00011["active"] = "1";
                oc_Newobject00011["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject00011["hovertime"] = "1000";
                oc_Newobject00011["isContainer"] = "1";
                oc_Newobject00011["canSave"] = "1";
                oc_Newobject00011["canSaveDynamicFields"] = "1";
                if (true)
                    {
                    #region GuiWindowCtrl ()        oc_Newobject00010

                    oc_Newobject00010 = new ObjectCreator("GuiWindowCtrl", "");
                    oc_Newobject00010["text"] = "New NavMesh";
                    oc_Newobject00010["resizeWidth"] = "0";
                    oc_Newobject00010["resizeHeight"] = "0";
                    oc_Newobject00010["canMove"] = "1";
                    oc_Newobject00010["canClose"] = "1";
                    oc_Newobject00010["canMinimize"] = "0";
                    oc_Newobject00010["canMaximize"] = "0";
                    oc_Newobject00010["canCollapse"] = "0";
                    oc_Newobject00010["closeCommand"] = "Canvas.popDialog(CreateNewNavMeshDlg);";
                    oc_Newobject00010["edgeSnap"] = "1";
                    oc_Newobject00010["margin"] = "0 0 0 0";
                    oc_Newobject00010["padding"] = "0 0 0 0";
                    oc_Newobject00010["anchorTop"] = "1";
                    oc_Newobject00010["anchorBottom"] = "0";
                    oc_Newobject00010["anchorLeft"] = "1";
                    oc_Newobject00010["anchorRight"] = "0";
                    oc_Newobject00010["position"] = "283 240";
                    oc_Newobject00010["extent"] = "200 151";
                    oc_Newobject00010["minExtent"] = "8 2";
                    oc_Newobject00010["horizSizing"] = "right";
                    oc_Newobject00010["vertSizing"] = "bottom";
                    oc_Newobject00010["profile"] = "GuiWindowProfile";
                    oc_Newobject00010["visible"] = "1";
                    oc_Newobject00010["active"] = "1";
                    oc_Newobject00010["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00010["hovertime"] = "1000";
                    oc_Newobject00010["isContainer"] = "1";
                    oc_Newobject00010["canSave"] = "1";
                    oc_Newobject00010["canSaveDynamicFields"] = "0";
                    if (true)
                        {
                        #region GuiTextCtrl ()        oc_Newobject00001

                        oc_Newobject00001 = new ObjectCreator("GuiTextCtrl", "");
                        oc_Newobject00001["text"] = "Name:";
                        oc_Newobject00001["maxLength"] = "1024";
                        oc_Newobject00001["margin"] = "0 0 0 0";
                        oc_Newobject00001["padding"] = "0 0 0 0";
                        oc_Newobject00001["anchorTop"] = "1";
                        oc_Newobject00001["anchorBottom"] = "0";
                        oc_Newobject00001["anchorLeft"] = "1";
                        oc_Newobject00001["anchorRight"] = "0";
                        oc_Newobject00001["position"] = "12 29";
                        oc_Newobject00001["extent"] = "39 21";
                        oc_Newobject00001["minExtent"] = "8 2";
                        oc_Newobject00001["horizSizing"] = "right";
                        oc_Newobject00001["vertSizing"] = "bottom";
                        oc_Newobject00001["profile"] = "GuiTextRightProfile";
                        oc_Newobject00001["visible"] = "1";
                        oc_Newobject00001["active"] = "1";
                        oc_Newobject00001["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00001["hovertime"] = "1000";
                        oc_Newobject00001["isContainer"] = "1";
                        oc_Newobject00001["canSave"] = "1";
                        oc_Newobject00001["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00010["#Newobject00001"] = oc_Newobject00001;

                        #region GuiTextEditCtrl ()        oc_Newobject00002

                        oc_Newobject00002 = new ObjectCreator("GuiTextEditCtrl", "");
                        oc_Newobject00002["historySize"] = "0";
                        oc_Newobject00002["tabComplete"] = "0";
                        oc_Newobject00002["sinkAllKeyEvents"] = "0";
                        oc_Newobject00002["password"] = "0";
                        oc_Newobject00002["passwordMask"] = "*";
                        oc_Newobject00002["text"] = "Nav";
                        oc_Newobject00002["maxLength"] = "1024";
                        oc_Newobject00002["margin"] = "0 0 0 0";
                        oc_Newobject00002["padding"] = "0 0 0 0";
                        oc_Newobject00002["anchorTop"] = "1";
                        oc_Newobject00002["anchorBottom"] = "0";
                        oc_Newobject00002["anchorLeft"] = "1";
                        oc_Newobject00002["anchorRight"] = "0";
                        oc_Newobject00002["position"] = "59 30";
                        oc_Newobject00002["extent"] = "129 18";
                        oc_Newobject00002["minExtent"] = "8 2";
                        oc_Newobject00002["horizSizing"] = "right";
                        oc_Newobject00002["vertSizing"] = "bottom";
                        oc_Newobject00002["profile"] = "GuiTextEditProfile";
                        oc_Newobject00002["visible"] = "1";
                        oc_Newobject00002["active"] = "1";
                        oc_Newobject00002["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00002["hovertime"] = "1000";
                        oc_Newobject00002["isContainer"] = "1";
                        oc_Newobject00002["internalName"] = "MeshName";
                        oc_Newobject00002["canSave"] = "1";
                        oc_Newobject00002["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00010["#Newobject00002"] = oc_Newobject00002;

                        #region GuiTextCtrl ()        oc_Newobject00003

                        oc_Newobject00003 = new ObjectCreator("GuiTextCtrl", "");
                        oc_Newobject00003["text"] = "Position:";
                        oc_Newobject00003["maxLength"] = "1024";
                        oc_Newobject00003["margin"] = "0 0 0 0";
                        oc_Newobject00003["padding"] = "0 0 0 0";
                        oc_Newobject00003["anchorTop"] = "1";
                        oc_Newobject00003["anchorBottom"] = "0";
                        oc_Newobject00003["anchorLeft"] = "1";
                        oc_Newobject00003["anchorRight"] = "0";
                        oc_Newobject00003["position"] = "12 51";
                        oc_Newobject00003["extent"] = "39 21";
                        oc_Newobject00003["minExtent"] = "8 2";
                        oc_Newobject00003["horizSizing"] = "right";
                        oc_Newobject00003["vertSizing"] = "bottom";
                        oc_Newobject00003["profile"] = "GuiTextRightProfile";
                        oc_Newobject00003["visible"] = "1";
                        oc_Newobject00003["active"] = "1";
                        oc_Newobject00003["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00003["hovertime"] = "1000";
                        oc_Newobject00003["isContainer"] = "1";
                        oc_Newobject00003["canSave"] = "1";
                        oc_Newobject00003["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00010["#Newobject00003"] = oc_Newobject00003;

                        #region GuiTextEditCtrl ()        oc_Newobject00004

                        oc_Newobject00004 = new ObjectCreator("GuiTextEditCtrl", "");
                        oc_Newobject00004["historySize"] = "0";
                        oc_Newobject00004["tabComplete"] = "0";
                        oc_Newobject00004["sinkAllKeyEvents"] = "0";
                        oc_Newobject00004["password"] = "0";
                        oc_Newobject00004["passwordMask"] = "*";
                        oc_Newobject00004["text"] = "0 0 0";
                        oc_Newobject00004["maxLength"] = "1024";
                        oc_Newobject00004["margin"] = "0 0 0 0";
                        oc_Newobject00004["padding"] = "0 0 0 0";
                        oc_Newobject00004["anchorTop"] = "1";
                        oc_Newobject00004["anchorBottom"] = "0";
                        oc_Newobject00004["anchorLeft"] = "1";
                        oc_Newobject00004["anchorRight"] = "0";
                        oc_Newobject00004["position"] = "59 52";
                        oc_Newobject00004["extent"] = "129 18";
                        oc_Newobject00004["minExtent"] = "8 2";
                        oc_Newobject00004["horizSizing"] = "right";
                        oc_Newobject00004["vertSizing"] = "bottom";
                        oc_Newobject00004["profile"] = "GuiTextEditProfile";
                        oc_Newobject00004["visible"] = "1";
                        oc_Newobject00004["active"] = "1";
                        oc_Newobject00004["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00004["hovertime"] = "1000";
                        oc_Newobject00004["isContainer"] = "1";
                        oc_Newobject00004["internalName"] = "MeshPosition";
                        oc_Newobject00004["canSave"] = "1";
                        oc_Newobject00004["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00010["#Newobject00004"] = oc_Newobject00004;

                        #region GuiTextCtrl ()        oc_Newobject00005

                        oc_Newobject00005 = new ObjectCreator("GuiTextCtrl", "");
                        oc_Newobject00005["text"] = "Scale:";
                        oc_Newobject00005["maxLength"] = "1024";
                        oc_Newobject00005["margin"] = "0 0 0 0";
                        oc_Newobject00005["padding"] = "0 0 0 0";
                        oc_Newobject00005["anchorTop"] = "1";
                        oc_Newobject00005["anchorBottom"] = "0";
                        oc_Newobject00005["anchorLeft"] = "1";
                        oc_Newobject00005["anchorRight"] = "0";
                        oc_Newobject00005["position"] = "12 73";
                        oc_Newobject00005["extent"] = "39 21";
                        oc_Newobject00005["minExtent"] = "8 2";
                        oc_Newobject00005["horizSizing"] = "right";
                        oc_Newobject00005["vertSizing"] = "bottom";
                        oc_Newobject00005["profile"] = "GuiTextRightProfile";
                        oc_Newobject00005["visible"] = "1";
                        oc_Newobject00005["active"] = "1";
                        oc_Newobject00005["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00005["hovertime"] = "1000";
                        oc_Newobject00005["isContainer"] = "1";
                        oc_Newobject00005["canSave"] = "1";
                        oc_Newobject00005["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00010["#Newobject00005"] = oc_Newobject00005;

                        #region GuiTextEditCtrl ()        oc_Newobject00006

                        oc_Newobject00006 = new ObjectCreator("GuiTextEditCtrl", "");
                        oc_Newobject00006["historySize"] = "0";
                        oc_Newobject00006["tabComplete"] = "0";
                        oc_Newobject00006["sinkAllKeyEvents"] = "0";
                        oc_Newobject00006["password"] = "0";
                        oc_Newobject00006["passwordMask"] = "*";
                        oc_Newobject00006["text"] = "50 50 20";
                        oc_Newobject00006["maxLength"] = "1024";
                        oc_Newobject00006["margin"] = "0 0 0 0";
                        oc_Newobject00006["padding"] = "0 0 0 0";
                        oc_Newobject00006["anchorTop"] = "1";
                        oc_Newobject00006["anchorBottom"] = "0";
                        oc_Newobject00006["anchorLeft"] = "1";
                        oc_Newobject00006["anchorRight"] = "0";
                        oc_Newobject00006["position"] = "59 74";
                        oc_Newobject00006["extent"] = "129 18";
                        oc_Newobject00006["minExtent"] = "8 2";
                        oc_Newobject00006["horizSizing"] = "right";
                        oc_Newobject00006["vertSizing"] = "bottom";
                        oc_Newobject00006["profile"] = "GuiTextEditProfile";
                        oc_Newobject00006["visible"] = "1";
                        oc_Newobject00006["active"] = "1";
                        oc_Newobject00006["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00006["hovertime"] = "1000";
                        oc_Newobject00006["isContainer"] = "1";
                        oc_Newobject00006["internalName"] = "MeshScale";
                        oc_Newobject00006["canSave"] = "1";
                        oc_Newobject00006["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00010["#Newobject00006"] = oc_Newobject00006;

                        #region GuiCheckBoxCtrl ()        oc_Newobject00007

                        oc_Newobject00007 = new ObjectCreator("GuiCheckBoxCtrl", "");
                        oc_Newobject00007["text"] = " Fit NavMesh to mission area?";
                        oc_Newobject00007["groupNum"] = "-1";
                        oc_Newobject00007["buttonType"] = "ToggleButton";
                        oc_Newobject00007["useMouseEvents"] = "0";
                        oc_Newobject00007["position"] = "22 99";
                        oc_Newobject00007["extent"] = "159 15";
                        oc_Newobject00007["minExtent"] = "8 2";
                        oc_Newobject00007["horizSizing"] = "right";
                        oc_Newobject00007["vertSizing"] = "bottom";
                        oc_Newobject00007["profile"] = "GuiCheckBoxProfile";
                        oc_Newobject00007["visible"] = "1";
                        oc_Newobject00007["active"] = "1";
                        oc_Newobject00007["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00007["tooltip"] = "Positions and scales the NavMesh so it includes all your mission objects.";
                        oc_Newobject00007["hovertime"] = "1000";
                        oc_Newobject00007["isContainer"] = "0";
                        oc_Newobject00007["internalName"] = "MeshMissionBounds";
                        oc_Newobject00007["canSave"] = "1";
                        oc_Newobject00007["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00010["#Newobject00007"] = oc_Newobject00007;

                        #region GuiButtonCtrl ()        oc_Newobject00008

                        oc_Newobject00008 = new ObjectCreator("GuiButtonCtrl", "");
                        oc_Newobject00008["text"] = "Create!";
                        oc_Newobject00008["groupNum"] = "-1";
                        oc_Newobject00008["buttonType"] = "PushButton";
                        oc_Newobject00008["useMouseEvents"] = "0";
                        oc_Newobject00008["position"] = "12 121";
                        oc_Newobject00008["extent"] = "87 19";
                        oc_Newobject00008["minExtent"] = "8 2";
                        oc_Newobject00008["horizSizing"] = "right";
                        oc_Newobject00008["vertSizing"] = "bottom";
                        oc_Newobject00008["profile"] = "GuiButtonProfile";
                        oc_Newobject00008["visible"] = "1";
                        oc_Newobject00008["active"] = "1";
                        oc_Newobject00008["command"] = "CreateNewNavMeshDlg.create();";
                        oc_Newobject00008["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00008["hovertime"] = "1000";
                        oc_Newobject00008["isContainer"] = "0";
                        oc_Newobject00008["canSave"] = "1";
                        oc_Newobject00008["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00010["#Newobject00008"] = oc_Newobject00008;

                        #region GuiButtonCtrl ()        oc_Newobject00009

                        oc_Newobject00009 = new ObjectCreator("GuiButtonCtrl", "");
                        oc_Newobject00009["text"] = "Cancel";
                        oc_Newobject00009["groupNum"] = "-1";
                        oc_Newobject00009["buttonType"] = "PushButton";
                        oc_Newobject00009["useMouseEvents"] = "0";
                        oc_Newobject00009["position"] = "104 121";
                        oc_Newobject00009["extent"] = "84 19";
                        oc_Newobject00009["minExtent"] = "8 2";
                        oc_Newobject00009["horizSizing"] = "right";
                        oc_Newobject00009["vertSizing"] = "bottom";
                        oc_Newobject00009["profile"] = "GuiButtonProfile";
                        oc_Newobject00009["visible"] = "1";
                        oc_Newobject00009["active"] = "1";
                        oc_Newobject00009["command"] = "Canvas.popDialog(CreateNewNavMeshDlg);";
                        oc_Newobject00009["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00009["hovertime"] = "1000";
                        oc_Newobject00009["isContainer"] = "0";
                        oc_Newobject00009["canSave"] = "1";
                        oc_Newobject00009["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00010["#Newobject00009"] = oc_Newobject00009;
                        }

                    #endregion

                    oc_Newobject00011["#Newobject00010"] = oc_Newobject00010;
                    }

                #endregion

                oc_Newobject00011.Create();
                }
        }

        [ConsoleInteraction]
        public override void onWake()
        {
            GuiTextEditCtrl MeshName = FOT("MeshName");
            GuiTextEditCtrl MeshPosition = FOT("MeshPosition");
            GuiTextEditCtrl MeshScale = FOT("MeshScale");
            MeshName.setText("Nav");
            MeshPosition.setText("0 0 0");
            MeshScale.setText("50 50 20");
        }

        [ConsoleInteraction]
        public static string MissionBoundsExtents(SimSet group)
        {
            string box = "0 0 0 0 0 0";
            int count = group.getCount();
            for (uint i = 0; i < count; i++)
                {
                // Skip LevelInfos. Need a way to detect other non-SceneObjects.
                // Also skip GroundPlanes. They're too big.
                SimObject obj = group.getObject(i);
                //var cls = obj.getClassName();
                string cls = obj.GetType().Name;
                if (cls == "LevelInfo" || cls == "GroundPlane" || cls == "GroundCover")
                    continue;

                // Get world box - might have to recurse into nested SimGroups.
                string wbox = "0 0 0 0 0 0";
                if (cls == "SimGroup" || cls == "SimSet" || cls == "Path")
                    wbox = MissionBoundsExtents((SimSet) obj);
                else if (obj.GetType() == typeof (SceneObject) && ((SceneObject) obj).getType() == omni.iGlobal["$TypeMasks::StaticObjectType"] && !(((SceneObject) obj).getType() == omni.iGlobal["$TypeMasks::EnvironmentObjectType"]))
                    wbox = ((SceneObject) obj).getWorldBox().AsString();
                else
                    continue;

                // Update min point.
                for (int j = 0; j < 3; j++)
                    {
                    if (omni.Util.getWord(box, j).AsInt() > omni.Util.getWord(wbox, j).AsInt())
                        box = omni.Util.setWord(box, j, omni.Util.getWord(wbox, j));
                    }
                // Update max point.
                for (int j = 3; j < 6; j++)
                    {
                    if (omni.Util.getWord(box, j).AsInt() < omni.Util.getWord(wbox, j).AsInt())
                        box = omni.Util.setWord(box, j, omni.Util.getWord(wbox, j));
                    }
                }
            return box;
        }

        [ConsoleInteraction]
        public void create()
        {
            GuiTextEditCtrl MeshName = FOT("MeshName");
            GuiCheckBoxCtrl MeshMissionBounds = FOT("MeshMissionBounds");
            string name = MeshName.getText();
            if (name == "" || Util.nameToID(name) > 0)
                {
                messageBox.MessageBoxOK("Error", "A NavMesh must have a unique name!");
                return;
                }

            NavMesh mesh = "0";

            SimSet MissionGroup = "MissionGroup";
            if (MeshMissionBounds.isStateOn())
                {
                if (!Util.isObject(MissionGroup))
                    {
                    messageBox.MessageBoxOK("Error", "You must have a MissionGroup to use the mission bounds function.");
                    return;
                    }
                // Get maximum extents of all objects.
                string box = MissionBoundsExtents(MissionGroup);
                Point3F pos = Util.getBoxCenter(box.AsBox3F());
                string scale = (Util.getWord(box, 3).AsInt() - Util.getWord(box, 0).AsInt())/2 + 5 + " " + (Util.getWord(box, 4).AsInt() - Util.getWord(box, 1).AsInt())/2 + 5 + " " + (Util.getWord(box, 5).AsInt() - Util.getWord(box, 2).AsInt())/2 + 5;

                ObjectCreator oc = new ObjectCreator("NavMesh", name);
                oc["position"] = pos;
                oc["scale"] = scale;
                mesh = oc.Create();
                }
            else
                {
                GuiTextEditCtrl MeshPosition = FOT("MeshPosition");
                GuiTextEditCtrl MeshScale = FOT("MeshScale");

                ObjectCreator oc = new ObjectCreator("NavMesh", name);
                oc["position"] = MeshPosition.getText();
                oc["scale"] = MeshScale.getText();
                mesh = oc.Create();
                }
            MissionGroup.add(mesh);
            NavEditorGui NavEditorGui = "NavEditorGui";
            canvas Canvas = "Canvas";
            NavEditorGui.selectObject(mesh);

            Canvas.popDialog(this);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CreateNewNavMeshDlg ts, string simobjectid)
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
        public static bool operator !=(CreateNewNavMeshDlg ts, string simobjectid)
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
        public static implicit operator string(CreateNewNavMeshDlg ts)
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
        public static implicit operator CreateNewNavMeshDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (CreateNewNavMeshDlg) Omni.self.getSimObject(simobjectid, typeof (CreateNewNavMeshDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(CreateNewNavMeshDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CreateNewNavMeshDlg(int simobjectid)
        {
            return (CreateNewNavMeshDlg) Omni.self.getSimObject((uint) simobjectid, typeof (CreateNewNavMeshDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(CreateNewNavMeshDlg ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CreateNewNavMeshDlg(uint simobjectid)
        {
            return (CreateNewNavMeshDlg) Omni.self.getSimObject(simobjectid, typeof (CreateNewNavMeshDlg));
        }

        #endregion
    }
}