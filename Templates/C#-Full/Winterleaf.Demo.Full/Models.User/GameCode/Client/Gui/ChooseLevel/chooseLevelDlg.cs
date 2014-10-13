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

using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.ChooseLevel
{
    [TypeConverter(typeof (TypeConverterGeneric<chooseLevelDlg>))]
    public class chooseLevelDlg : GuiControl
    {

        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        [ConsoleInteraction(true)]
        public static void StartLevel(string mission, string hostingType)
        {
            GuiTextListCtrl CL_levelList = "CL_levelList";
            if (mission == "")
                mission = omni.Util.getField(CL_levelList.getRowTextById(CL_levelList.getSelectedId()), 1);

            string serverType = hostingType;

            if (serverType == "")
                {
                if (omni.bGlobal["$pref::HostMultiPlayer"])
                    serverType = "MultiPlayer";
                else
                    serverType = "SinglePlayer";
                }

            // Show the loading screen immediately.
            if ("LoadingGui".isObject())
                {
                ((GuiCanvas) "Canvas").setContent("LoadingGui");
                ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("1");
                ((GuiTextCtrl) "LoadingProgressTxt").setValue("LOADING MISSION FILE");
                ((GuiCanvas) "Canvas").repaint(-1);
                }

            server.createAndConnectToLocalServer(serverType, mission);
        }

        public override void onWake()
        {
            GuiTextListCtrl CL_levelList = "CL_levelList";
            CL_levelList.clear();
            ChooseLevelWindow ChooseLevelWindow = "ChooseLevelWindow";
            GuiDynamicCtrlArrayControl SmallPreviews = ((GuiDynamicCtrlArrayControl) ((GuiWindowCtrl) "ChooseLevelWindow").findObjectByInternalName("SmallPreviews", false));

            ((GuiDynamicCtrlArrayControl) ChooseLevelWindow.findObjectByInternalName("SmallPreviews", false)).clear();
            string file = "";
            for (file = Util.findFirstFile(sGlobal["$Server::MissionFileSpec"], true); file != ""; file = Util.findNextFile(sGlobal["$Server::MissionFileSpec"]))
                {
                // Skip our new level/mission if we arent choosing a level
                // to launch in the editor.
                if (!this["launchInEditor"].AsBool())
                    {
                    if (Util.strstr(file, "newMission.mis") > -1)
                        continue;
                    if (Util.strstr(file, "newLevel.mis") > -1)
                        continue;
                    }
                addMissionFile(file);
                }
            // Also add the new level mission as defined in the world editor settings
            // if we are choosing a level to launch in the editor.
            if (this["launchInEditor"].AsBool())
                {
                file = ((Settings) "EditorSettings").value("WorldEditor/newLevelFile");
                if (file != "")
                    addMissionFile(file);
                }
            // Sort our list
            CL_levelList.sort("0");

            // Set the first row as the selected row
            CL_levelList.setSelectedRow(0);

            GuiBitmapButtonCtrl preview;
            for (int i = 0; i < CL_levelList.rowCount(); i++)
                {
                ObjectCreator oc = new ObjectCreator("GuiBitmapButtonCtrl");
                oc["internalName"] = "SmallPreview" + i;
                oc["Extent"] = "108 81";
                oc["bitmap"] = "art/gui/no-preview";
                oc["command"] = "ChooseLevelWindow.previewSelected(ChooseLevelWindow->SmallPreviews->SmallPreview" + i + ");";
                preview = oc.Create();
                SmallPreviews.add(preview);
                // Set this small preview visible
                if (i > 5)
                    preview.setVisible(false);
                // Set the level index
                preview["levelIndex"] = i.AsString();
                // Get the name
                string name = Util.getField(CL_levelList.getRowText(i), 0);
                preview["levelName"] = name;
                file = Util.getField(CL_levelList.getRowText(i), 1);
                // Find the preview image
                string levelPreview = Util.filePath(file) + "/" + Util.fileBase(file) + "_preview";
                // Test against all of the different image formats
                // This should probably be moved into an engine function
                if (Util.isFile(levelPreview + ".png") || Util.isFile(levelPreview + ".jpg") || Util.isFile(levelPreview + ".bmp") || Util.isFile(levelPreview + ".gif") || Util.isFile(levelPreview + ".jng") || Util.isFile(levelPreview + ".mng") || Util.isFile(levelPreview + ".tga"))
                    preview.setBitmap(levelPreview);
                // Get the description
                String desc = Util.getField(CL_levelList.getRowText(i), 2);
                preview["levelDesc"] = desc;
                }

            SmallPreviews["firstVisible"] = "-1";
            SmallPreviews["lastVisible"] = "-1";

            if (SmallPreviews.getCount() > 0)
                {
                SmallPreviews["firstVisible"] = "0";
                if (SmallPreviews.getCount() < 6)
                    SmallPreviews["lastVisible"] = (SmallPreviews.getCount() - 1).AsString();
                else
                    SmallPreviews["lastVisible"] = "4";
                }

            if (SmallPreviews.getCount() > 0)
                ChooseLevelWindow.previewSelected(SmallPreviews.getObject(0));
            // If we have 5 or less previews then hide our next/previous buttons
            // and resize to fill their positions

            if (SmallPreviews.getCount() < 6)
                {
                ((GuiBitmapButtonCtrl) ChooseLevelWindow.findObjectByInternalName("PreviousSmallPreviews", false)).setVisible(false);
                ((GuiBitmapButtonCtrl) ChooseLevelWindow.findObjectByInternalName("NextSmallPreviews", false)).setVisible(false);

                Point2I previewPos = SmallPreviews.getPosition();
                Point2I previousPos = ((GuiBitmapButtonCtrl) ChooseLevelWindow.findObjectByInternalName("PreviousSmallPreviews", false)).getPosition();

                SmallPreviews.setPosition(previousPos.x, previewPos.y);

                SmallPreviews.colSpacing = 10;
                SmallPreviews.refresh();
                }

            if (SmallPreviews.getCount() <= 1)
                {
                // Hide the small previews
                SmallPreviews.setVisible(false);
                // Shrink the ChooseLevelWindow so that we don't have a large blank space

                ChooseLevelWindow.setExtent(new Point2F(ChooseLevelWindow.getExtent().x + " " + SmallPreviews.getPosition().y));

                ChooseLevelWindow.setExtent(new Point2F(ChooseLevelWindow.getExtent().x, SmallPreviews.getPosition().y));
                }
            else
                {
                // Make sure the small previews are visible
                SmallPreviews.setVisible(true);

                int extentX = ChooseLevelWindow.getExtent().x;
                int extentY = SmallPreviews.getPosition().y;
                extentY = extentY + SmallPreviews.getExtent().y;
                extentY += 9;
                ChooseLevelWindow.setExtent(new Point2F(extentX, extentY));
                }
        }

        public void addMissionFile(string file)
        {
            string levelName = Util.fileBase(file);
            string levelDesc = "A Torque Level";

            string _LevelInfoObject = getLevelInfo(file);

            if (_LevelInfoObject != "0")
                {
                ScriptObject LevelInfoObject = _LevelInfoObject;

                if (LevelInfoObject["levelName"] != "")
                    levelName = LevelInfoObject["levelName"];
                else if (LevelInfoObject["name"] != "")
                    levelName = LevelInfoObject["name"];

                if (LevelInfoObject["desc0"] != "")
                    levelDesc = LevelInfoObject["desc0"];

                LevelInfoObject.delete();
                }

            GuiTextListCtrl CL_levelList = "CL_levelList";
            CL_levelList.addRow(CL_levelList.rowCount(), levelName + "\t" + file + "\t" + levelDesc, -1);
        }

        public override void onSleep()
        {
            // This is set from the outside, only stays true for a single wake/sleep
            // cycle.
            this["launchInEditor"] = "false";
        }

        public string getLevelInfo(string missionFile)
        {
            FileObject file = new ObjectCreator("FileObject").Create();
            string LevelInfoObject = "";

            bool inInfoBlock;
            if (file.openForRead(missionFile))
                {
                inInfoBlock = false;
                while (!file.isEOF())
                    {
                    string line = file.readLine().Trim();

                    if (line == "new ScriptObject(LevelInfo) {")
                        inInfoBlock = true;
                    else if (line == "new LevelInfo(theLevelInfo) {")
                        inInfoBlock = true;
                    else if (inInfoBlock && line == "};")
                        {
                        inInfoBlock = false;
                        LevelInfoObject += line;
                        break;
                        }
                    if (inInfoBlock)
                        LevelInfoObject += line + " ";
                    }
                file.close();
                }
            file.delete();

            //Ok, temporary bug, because LevelInfo isn't derived from SimObject it isn't accessable easily, so I switch it to a script object.

            if (LevelInfoObject.Contains(" LevelInfo("))
                LevelInfoObject = LevelInfoObject.Replace(" LevelInfo(", " ScriptObject(");

            if (LevelInfoObject != "")
                {
                string r = console.Eval(LevelInfoObject, true);
                return r;
                }

            return "0";
        }

        public string getLevelInfo1(string missionFile)
        {
            string levelInfoObject = "";

            string path = Assembly.GetExecutingAssembly().Location;
            path = path.Substring(0, path.LastIndexOf('\\')) + "\\" + missionFile;

            using (StreamReader sr = new StreamReader(path))
                {
                bool inInfoBlock = false;
                while (!sr.EndOfStream)
                    {
                    string line = sr.ReadLine().Trim();
                    if (line == "new LevelInfo(theLevelInfo) {")
                        inInfoBlock = true;
                    else if (inInfoBlock && line == "};")
                        {
                        inInfoBlock = false;
                        levelInfoObject += line;
                        break;
                        }
                    if (inInfoBlock)
                        levelInfoObject += line + " ";
                    }
                }

            if ("TheLevelInfo".isObject())
                "TheLevelInfo".delete();

            if (levelInfoObject != "")
                {
                Util.eval(levelInfoObject);
                return "TheLevelInfo";
                }

            return "0";
        }

        public static void Initialize()
        {
            #region GuiControl (ChooseLevelDlg)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "ChooseLevelDlg", typeof (chooseLevelDlg));

            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "GuiOverlayProfile";
            oc_Newobject12["HorizSizing"] = "width";
            oc_Newobject12["VertSizing"] = "height";
            oc_Newobject12["position"] = "0 0";
            oc_Newobject12["Extent"] = "1024 768";
            oc_Newobject12["MinExtent"] = "8 8";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";

            #region GuiWindowCtrl (ChooseLevelWindow)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiWindowCtrl", "ChooseLevelWindow", typeof (ChooseLevelWindow));
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "GuiWindowProfile";
            oc_Newobject11["HorizSizing"] = "center";
            oc_Newobject11["VertSizing"] = "center";
            oc_Newobject11["Position"] = "252 224";
            oc_Newobject11["Extent"] = "600 433";
            oc_Newobject11["MinExtent"] = "8 8";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["isDecoy"] = "0";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["resizeWidth"] = "0";
            oc_Newobject11["resizeHeight"] = "0";
            oc_Newobject11["canMove"] = "1";
            oc_Newobject11["canClose"] = "1";
            oc_Newobject11["canMinimize"] = "0";
            oc_Newobject11["canMaximize"] = "0";
            oc_Newobject11["minSize"] = "50 50";
            oc_Newobject11["EdgeSnap"] = "1";
            oc_Newobject11["text"] = "Choose Level";
            oc_Newobject11["closeCommand"] = "Canvas.popDialog(ChooseLevelDlg);";

            #region GuiBitmapCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject1["canSaveDynamicFields"] = "1";
            oc_Newobject1["internalName"] = "CurrentPreview";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "GuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "10 31";
            oc_Newobject1["Extent"] = "400 300";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["bitmap"] = "art/gui/no-preview";
            oc_Newobject1["wrap"] = "0";

            #endregion

            oc_Newobject11["#Newobject1"] = oc_Newobject1;

            #region GuiTextCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["internalName"] = "LevelName";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "GuiMediumTextProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "420 31";
            oc_Newobject2["Extent"] = "165 18";
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
            oc_Newobject2["text"] = "Level";
            oc_Newobject2["maxLength"] = "255";

            #endregion

            oc_Newobject11["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "GuiTextProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "420 50";
            oc_Newobject3["Extent"] = "72 18";
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
            oc_Newobject3["text"] = "Description:";
            oc_Newobject3["maxLength"] = "255";

            #endregion

            oc_Newobject11["#Newobject3"] = oc_Newobject3;

            #region GuiMLTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiMLTextCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["internalName"] = "LevelDescription";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "GuiMLTextProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "420 76";
            oc_Newobject4["Extent"] = "165 189";
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
            oc_Newobject4["text"] = "";
            oc_Newobject4["maxLength"] = "255";

            #endregion

            oc_Newobject11["#Newobject4"] = oc_Newobject4;

            #region GuiCheckBoxCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "GuiCheckBoxProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "420 303";
            oc_Newobject5["Extent"] = "45 23";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Variable"] = "pref::HostMultiPlayer";
            oc_Newobject5["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["text"] = " Host";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "ToggleButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["useInactiveState"] = "0";

            #endregion

            oc_Newobject11["#Newobject5"] = oc_Newobject5;

            #region GuiButtonCtrl (ChooseLevelDlgGoBtn)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiButtonCtrl", "ChooseLevelDlgGoBtn", typeof (chooseLevelDlgGoBtn));
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "GuiMenuButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "458 287";
            oc_Newobject6["Extent"] = "143 56";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["text"] = "Go!";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "PushButton";
            oc_Newobject6["useMouseEvents"] = "1";

            #endregion

            oc_Newobject11["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "1";
            oc_Newobject7["internalName"] = "PreviousSmallPreviews";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "GuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "10 343";
            oc_Newobject7["Extent"] = "11 81";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["bitmap"] = "art/gui/previous-button";
            oc_Newobject7["wrap"] = "0";
            oc_Newobject7["command"] = "ChooseLevelWindow.previousPreviews();";

            #endregion

            oc_Newobject11["#Newobject7"] = oc_Newobject7;

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject8["internalName"] = "SmallPreviews";
            oc_Newobject8["position"] = "24 343";
            oc_Newobject8["extent"] = "600 81";
            oc_Newobject8["autoCellSize"] = new Creator.StringNoQuote("true");
            oc_Newobject8["colSpacing"] = new Creator.StringNoQuote("3");
            oc_Newobject8["colCount"] = new Creator.StringNoQuote("5");
            oc_Newobject8["rowCount"] = new Creator.StringNoQuote("1");

            #endregion

            oc_Newobject11["#Newobject8"] = oc_Newobject8;

            #region GuiBitmapButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "1";
            oc_Newobject9["internalName"] = "NextSmallPreviews";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "GuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "579 343";
            oc_Newobject9["Extent"] = "11 81";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["bitmap"] = "art/gui/next-button";
            oc_Newobject9["wrap"] = "0";
            oc_Newobject9["command"] = "ChooseLevelWindow.nextPreviews();";

            #endregion

            oc_Newobject11["#Newobject9"] = oc_Newobject9;

            #region GuiTextListCtrl (CL_levelList)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextListCtrl", "CL_levelList");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "GuiTextArrayProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "1 1";
            oc_Newobject10["Extent"] = "421 144";
            oc_Newobject10["MinExtent"] = "8 8";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "0";
            oc_Newobject10["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["enumerate"] = "0";
            oc_Newobject10["resizeCell"] = "1";
            oc_Newobject10["columns"] = "0";
            oc_Newobject10["fitParentWidth"] = "1";
            oc_Newobject10["clipColumnText"] = "0";

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject12.Create();
        }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(chooseLevelDlg ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
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
        public static bool operator !=(chooseLevelDlg ts, string simobjectid)
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
        public static implicit operator string(chooseLevelDlg ts)
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
        public static implicit operator chooseLevelDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (chooseLevelDlg) Omni.self.getSimObject(simobjectid, typeof (chooseLevelDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(chooseLevelDlg ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator chooseLevelDlg(int simobjectid)
        {
            return (chooseLevelDlg) Omni.self.getSimObject((uint) simobjectid, typeof (chooseLevelDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(chooseLevelDlg ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator chooseLevelDlg(uint simobjectid)
        {
            return (chooseLevelDlg) Omni.self.getSimObject(simobjectid, typeof (chooseLevelDlg));
        }

        #endregion
    }
}