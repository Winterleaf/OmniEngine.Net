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
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups
{
    [TypeConverter(typeof (TypeConverterGeneric<EWToolsPaletteWindow>))]
    public class EWToolsPaletteWindow : GuiWindowCtrl
    {
        public void LoadControls(GuiControl obj, int paletteGroup)
        {
            GuiDynamicCtrlArrayControl ToolsPaletteArray = "ToolsPaletteArray";
            for (int i = obj.getCount(); i != 0; i--)
                {
                ((GuiControl) obj.getObject(0)).visible = false;
                ((GuiControl) obj.getObject(0))["groupNum"] = paletteGroup.AsString();
                ((GuiControl) obj.getObject(0))["paletteName"] = obj.getName();
                ToolsPaletteArray.addGuiControl(obj.getObject(0));
                }
        }

        [ConsoleInteraction]
        public void loadToolsPalettes()
        {
            int paletteGroup = 0;
            LoadControls(ConvexEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(DecalEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(ForestEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(MeshRoadEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(RiverEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(RoadEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(ShapeEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(TerrainEditPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(TerrainPainterPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(WorldEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(NavEditorPalette.initialize(), paletteGroup);
        }

        [ConsoleInteraction]
        public void init()
        {
            loadToolsPalettes();
        }

        [ConsoleInteraction]
        public void togglePalette(string paletteName)
        {
            GuiDynamicCtrlArrayControl ToolsPaletteArray = "ToolsPaletteArray";
            EWToolsPaletteWindow EWToolsPaletteWindow = "EWToolsPaletteWindow";
            // since the palette window ctrl auto adjusts to child ctrls being visible,
            // loop through the array and pick out the children that belong to a certain tool
            // and label them visible or not visible

            for (uint i = 0; i < ToolsPaletteArray.getCount(); i++)
                ((GuiControl) ToolsPaletteArray.getObject(i)).visible = false;

            int windowMultiplier = 0;

            int paletteNameWordCount = Util.getWordCount(paletteName);

            for (int palatteNum = 0; palatteNum < paletteNameWordCount; palatteNum++)
                {
                string currentPalette = Util.getWord(paletteName, palatteNum);

                for (uint i = 0; i < ToolsPaletteArray.getCount(); i++)
                    {
                    if (((GuiControl) ToolsPaletteArray.getObject(i))["paletteName"] == currentPalette)
                        {
                        ((GuiControl) ToolsPaletteArray.getObject(i)).visible = true;
                        windowMultiplier++;
                        }
                    }
                }
            // auto adjust the palette window extent according to how many 
            // children controls we found; if none found, the palette window becomes invisible
            if (windowMultiplier == 0 || paletteName == "")
                EWToolsPaletteWindow.visible = false;
            else
                {
                EWToolsPaletteWindow.visible = true;
                EWToolsPaletteWindow.extent = new Point2I(EWToolsPaletteWindow.extent.x, (16 + 26*windowMultiplier));
                }
        }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EWToolsPaletteWindow ts, string simobjectid)
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
        public static bool operator !=(EWToolsPaletteWindow ts, string simobjectid)
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
        public static implicit operator string(EWToolsPaletteWindow ts)
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
        public static implicit operator EWToolsPaletteWindow(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (EWToolsPaletteWindow) Omni.self.getSimObject(simobjectid, typeof (EWToolsPaletteWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EWToolsPaletteWindow ts)
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
        public static implicit operator EWToolsPaletteWindow(int simobjectid)
        {
            return (EWToolsPaletteWindow) Omni.self.getSimObject((uint) simobjectid, typeof (EWToolsPaletteWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EWToolsPaletteWindow ts)
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
        public static implicit operator EWToolsPaletteWindow(uint simobjectid)
        {
            return (EWToolsPaletteWindow) Omni.self.getSimObject(simobjectid, typeof (EWToolsPaletteWindow));
        }

        #endregion
    }
}