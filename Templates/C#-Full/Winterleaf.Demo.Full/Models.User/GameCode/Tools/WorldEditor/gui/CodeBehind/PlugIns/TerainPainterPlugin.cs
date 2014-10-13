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
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns
{
    [TypeConverter(typeof (TypeConverterGeneric<TerrainPainterPlugin>))]
    public class TerrainPainterPlugin : EditorPlugin
    {
        internal ActionMap map
        {
            get { return this["map"]; }
            set { this["map"] = value; }
        }

        internal bool isActive
        {
            get { return this["isActive"].AsBool(); }
            set { this["isActive"] = value.AsString(); }
        }

        [ConsoleInteraction]
        public override bool? setEditorFunction(string overrideGroup = "")
        {
            bool terrainExists = AggregateControl.parseMissionGroup("TerrainBlock");
            ///  console.Call("parseMissionGroup", new string[] { "TerrainBlock" });
            if (terrainExists == false)
                messageBox.MessageBoxYesNoCancel("No Terrain", "Would you like to create a New Terrain?", "Canvas.pushDialog(CreateNewTerrainGui);");

            return terrainExists;
        }

        public override void onWorldEditorStartup()
        {
            EditorGui EditorGui = "EditorGui";
            base.onWorldEditorStartup();
            // Add ourselves to the window menu.

            string accel = EditorGui.addToEditorsMenu("Terrain Painter", "", this);
            // Add ourselves to the ToolsToolbar
            string tooltip = "Terrain Painter (" + accel + ")";

            EditorGui.addToToolsToolbar("TerrainPainterPlugin", "TerrainPainterPalette", Util._expandFilename("tools/worldEditor/images/toolbar/paint-terrain"), tooltip);
            ActionMap map = new ObjectCreator("ActionMap").Create();

            string keyboard = "keyboard";

            map.bindCmd(keyboard, "v", "EWTerrainPainterToolbarBrushType->ellipse.performClick();", ""); // Circle Brush
            map.bindCmd(keyboard, "b", "EWTerrainPainterToolbarBrushType->box.performClick();", ""); // Box Brush
            map.bindCmd(keyboard, "=", "TerrainPainterPlugin.keyboardModifyBrushSize(1);", ""); // +1 Brush Size
            map.bindCmd(keyboard, "+", "TerrainPainterPlugin.keyboardModifyBrushSize(1);", ""); // +1 Brush Size
            map.bindCmd(keyboard, "-", "TerrainPainterPlugin.keyboardModifyBrushSize(-1);", ""); // -1 Brush Size
            map.bindCmd(keyboard, "[", "TerrainPainterPlugin.keyboardModifyBrushSize(-5);", ""); // -5 Brush Size
            map.bindCmd(keyboard, "]", "TerrainPainterPlugin.keyboardModifyBrushSize(5);", ""); // +5 Brush Size

            for (int i = 0; i < 10; i++)
                map.bindCmd(keyboard, i.AsString(), "TerrainPainterPlugin.keyboardSetMaterial(" + (i - 1) + ");", "");

            map.bindCmd(keyboard, "0", "TerrainPainterPlugin.keyboardSetMaterial(10);", "");

            this.map = map;

            //console.Call_Classname("GuiWindowCtrl", "attach", new[] { "TerrainPainter", "TerrainPainterPreview" });
            TerrainPainter TerrainPainter = "TerrainPainter";
            TerrainPainter.attachTo("TerrainPainterPreview");
        }

        public override void onActivated()
        {
            EditorGui EditorGui = "EditorGui";
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            GuiWindowCollapseCtrl TerrainPainterPreview = "TerrainPainterPreview";
            GuiControl EWTerrainPainterToolbar = "EWTerrainPainterToolbar";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            TerrainPainter TerrainPainter = "TerrainPainter";

            base.onActivated();
            isActive = true;

            EditorGui.readTerrainEditorSettings();
            GuiControl EWTerrainPainterToolbarBrushType = "EWTerrainPainterToolbarBrushType";
            ((GuiBitmapButtonCtrl) EWTerrainPainterToolbarBrushType.findObjectByInternalName("ellipse", true)).performClick();
            map.push();

            EditorGui.bringToFront(ETerrainEditor);
            ETerrainEditor.setVisible(true);
            ETerrainEditor.attachTerrain();
            ETerrainEditor.makeFirstResponder(true);

            //Copyright Winterleaf Entertainment L.L.C. 2013
            TerrainPainter.setVisible(true);
            TerrainPainterPreview.setVisible(true);
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            EWTerrainPainterToolbar.setVisible(true);
            ETerrainEditor.onBrushChanged();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            TerrainPainter.setup(0);
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            syncBrushInfo();

            EditorGuiStatusBar.setSelection("");
        }

        public override void onDeactivated()
        {
            if (!isActive)
                return;

            EditorGui EditorGui = "EditorGui";
            TerrainPainter TerrainPainter = "TerrainPainter";
            GuiWindowCollapseCtrl TerrainPainterPreview = "TerrainPainterPreview";
            GuiControl EWTerrainPainterToolbar = "EWTerrainPainterToolbar";
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            isActive = false;
            base.onDeactivated();

            EditorGui.writeTerrainEditorSettings();
            map.pop();

            //Copyright Winterleaf Entertainment L.L.C. 2013   
            TerrainPainter.setVisible(false);
            TerrainPainterPreview.setVisible(false);
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            EWTerrainPainterToolbar.setVisible(false);
            ETerrainEditor.setVisible(false);
        }

        [ConsoleInteraction]
        public void syncBrushInfo()
        {
            // Update gui brush info
            GuiControl PaintBrushSizeTextEditContainer = "PaintBrushSizeTextEditContainer";
            GuiControl PaintBrushSlopeControl = "PaintBrushSlopeControl";
            GuiControl PaintBrushPressureTextEditContainer = "PaintBrushPressureTextEditContainer";
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            ((GuiTextEditCtrl) PaintBrushSizeTextEditContainer.findObjectByInternalName("textEdit", true)).text = Util.getWord(ETerrainEditor.getBrushSize(), 0);
            ((GuiTextEditCtrl) PaintBrushSlopeControl.findObjectByInternalName("SlopeMinAngle", true)).text = ETerrainEditor.getSlopeLimitMinAngle().AsString();
            ((GuiTextEditCtrl) PaintBrushSlopeControl.findObjectByInternalName("SlopeMaxAngle", true)).text = ETerrainEditor.getSlopeLimitMaxAngle().AsString();
            ((GuiTextEditCtrl) PaintBrushPressureTextEditContainer.findObjectByInternalName("textEdit", true)).text = (ETerrainEditor.getBrushPressure()*100).AsString();

            string brushType = ETerrainEditor.getBrushType();
            Util.eval("EWTerrainPainterToolbar-->" + brushType + ".setStateOn(1);");
        }

        [ConsoleInteraction]
        public void validateBrushSize()
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            int minBrushSize = 1;
            int maxBrushSize = Util.getWord(ETerrainEditor["maxBrushSize"], 0).AsInt();

            int val = ((SimObject) sGlobal["$ThisControl"]).call("getText").AsInt();

            if (val < minBrushSize)
                sGlobal["$ThisControl"].call("setValue", new string[] {minBrushSize.AsString()});
            else if (val > maxBrushSize)
                sGlobal["$ThisControl"].call("setValue", new string[] {maxBrushSize.AsString()});
        }

        [ConsoleInteraction]
        public void validateSlopeMaxAngle()
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            float maxVal = ETerrainEditor.getSlopeLimitMaxAngle();
            ((GuiTextEditCtrl) ((GuiControl) "PaintBrushSlopeControl").findObjectByInternalName("SlopeMaxAngle", true)).setText(maxVal.AsString());
        }

        [ConsoleInteraction]
        public void validateSlopeMinAngle()
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            float maxVal = ETerrainEditor.getSlopeLimitMinAngle();
            ((GuiTextEditCtrl) ((GuiControl) "PaintBrushSlopeControl").findObjectByInternalName("SlopeMinAngle", true)).setText(maxVal.AsString());
        }

        [ConsoleInteraction]
        public void keyboardModifyBrushSize(int amt)
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            int val = ((GuiTextEditCtrl) ((GuiControl) "PaintBrushSizeTextEditContainer").findObjectByInternalName("textEdit", true)).getText().AsInt();

            val += amt;

            ((GuiTextEditCtrl) ((GuiControl) "PaintBrushSizeTextEditContainer").findObjectByInternalName("textEdit", true)).setText(val.AsString());

            ((GuiTextEditCtrl) ((GuiControl) "PaintBrushSizeTextEditContainer").findObjectByInternalName("textEdit", true)).forceValidateText();

            ETerrainEditor.setBrushSize(val);
        }

        [ConsoleInteraction]
        public void keyboardSetMaterial(string mat)
        {
            string name = "EPainterMaterialButton" + mat;
            GuiBitmapButtonCtrl ctrl = ((GuiWindowCollapseCtrl) "TerrainPainter").findObjectByInternalName(name, true);
            if (ctrl.isObject())
                ctrl.performClick();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainPainterPlugin ts, string simobjectid)
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
        public static bool operator !=(TerrainPainterPlugin ts, string simobjectid)
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
        public static implicit operator string(TerrainPainterPlugin ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TerrainPainterPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TerrainPainterPlugin) Omni.self.getSimObject(simobjectid, typeof (TerrainPainterPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TerrainPainterPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainPainterPlugin(int simobjectid)
        {
            return (TerrainPainterPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainPainterPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TerrainPainterPlugin ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainPainterPlugin(uint simobjectid)
        {
            return (TerrainPainterPlugin) Omni.self.getSimObject(simobjectid, typeof (TerrainPainterPlugin));
        }

        #endregion
    }
}