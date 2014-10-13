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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.InGameEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<InGameContext>))]
    public class InGameContext : GuiControl
    {
        [ConsoleInteraction]
        public override void onAdd()
        {
            string filename = sGlobal["$appName"];
            sGlobal["$XMLOutput"] = Util.strreplace(filename, " ", "") + "_XML";
        }

        [ConsoleInteraction]
        public override void onRightMouseUp(GuiControl ctrl)
        {
            int fontColorPos, backgroundColorPos, fillColorPos, fontSizePos, lockPos, winSettingsPos, setTitlePos, bitmapPos;
            GuiCanvas Canvas = "Canvas";

            ObjectCreator popupCreator = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));

            popupCreator["isPopup"] = true.AsString();

            popupCreator["object"] = "-1";

            MenuBuilder popup = popupCreator.Create();

            popup.removeAllItems();
            popup["object"] = ctrl;

            if (ctrl.getName() != "")
                popup.appendItem(ctrl.getName() + '\t' + "" + '\t' + "");
            else
                popup.appendItem(ctrl.getClassName() + '\t' + "" + '\t' + "");

            popup.enableItem(0, false);

            if (ctrl.lockControl)
                {
                lockPos = popup.appendItem("Locked" + '\t' + "" + '\t' + ctrl + ".setControlLock(!" + ctrl + ".getControlLock());");
                popup.checkItem(lockPos, ctrl.getControlLock());
                }

            if (ctrl.contextFontColor)
                fontColorPos = popup.appendItem("Font Color..." + '\t' + "" + '\t' + "getColorI(\"" + ctrl.controlFontColor.AsString() + "\", \"" + ctrl + ".setControlFontColor\", " + ctrl.getRoot() + ", \"" + ctrl + ".setControlFontColor\", \"" + ctrl + ".setControlFontColor\" );");

            if (ctrl.contextBackColor)
                backgroundColorPos = popup.appendItem("Background Color..." + '\t' + "" + '\t' + "IngameContext.transparentCheck(" + ctrl + ", \"backColor\");");

            if (ctrl.contextFillColor)
                fillColorPos = popup.appendItem("Fill Color..." + '\t' + "" + '\t' + "IngameContext.transparentCheck(" + ctrl + ", \"fillColor\");");

            if (ctrl.contextFontSize)
                fontSizePos = popup.appendItem("Font Size..." + '\t' + "" + '\t' + "ChangeFontSize.loadDialog(" + ctrl + ");");

            if (ctrl.windowSettings)
                winSettingsPos = popup.appendItem("Window Settings" + '\t' + "" + '\t' + "WindowSettings.loadDialog(" + ctrl + ");");

            if (ctrl.isMemberOfClass("GuiBitmapCtrl"))
                {
                if (((GuiControl) popup["object"])["setBitmap"].AsBool())
                    bitmapPos = popup.appendItem("Set Bitmap..." + '\t' + "" + '\t' + "getLoadFilename( \"All Image Files|*.png;*.jpeg;*.jpg;*.tga;*.jng;*.mng;*.gif;*.bmp;*.dds|png|*.png|jpeg|*.jpeg|jpg|*.jpg|tga|*.tga|jng|*.jng|mng|*.mng|gif|*.gif|bmp|*.bmp|dds|*.dds\"," + ctrl + "\".setBitmap\", \"\" );");
                }

            if (ctrl.isMemberOfClass("GuiWindowCtrl"))
                {
                if (((GuiControl) popup["object"])["setTitle"].AsBool())
                    setTitlePos = popup.appendItem("Set Title..." + '\t' + "" + '\t' + "SetTitle.loadDialog(" + ctrl + ");");
                }

            popup.showPopup(Canvas);
        }

        [ConsoleInteraction]
        public void loadXML()
        {
            ReadXML xmlOutput = sGlobal["$XMLOutput"];

            if (!xmlOutput.isObject())
                {
                ObjectCreator xmlCreator = new ObjectCreator("ReadXML", xmlOutput);
                xmlCreator["fileName"] = sGlobal["$XMLOutput"] + ".xml";

                xmlOutput = xmlCreator.Create();
                }

            bool output = xmlOutput.readFile();
            Util._echo(output ? "Read successful." : "Read error.");
        }

        [ConsoleInteraction]
        public void xmlOutput(GuiControl ctrl)
        {
            GuiControl currentObject = ctrl.getRootControl();
            bool saved = currentObject.saveToXML(sGlobal["$XMLOutput"], sGlobal["$XMLOutput"] + ".xml");
            if (saved)
                Util._echo(" Saved " + sGlobal["$XMLOutput"] + ".xml");
            else
                Util._echo("Saved failed");
        }

        [ConsoleInteraction]
        public void transparentCheck(GuiControl ctrl, string colorName)
        {
            bool transparent = ctrl.transparentControlCheck();
            if (transparent)
                return;

            if (colorName == "fillColor")
                ColorPickerDlg.GetColorI(ctrl.controlFillColor.AsString(), ctrl + ".setControlFillColor", ctrl.getRoot(), ctrl + ".setControlFillColor", ctrl + ".setControlFillColor");
            else if (colorName == "backColor")
                ColorPickerDlg.GetColorI(ctrl.backgroundColor.AsString(), ctrl + ".setControlBackgroundColor", ctrl.getRoot(), ctrl + ".setControlBackgroundColor", ctrl + ".setControlBackgroundColor");
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(InGameContext ts, string simobjectid)
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
        public static bool operator !=(InGameContext ts, string simobjectid)
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
        public static implicit operator string(InGameContext ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator InGameContext(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (InGameContext) Omni.self.getSimObject(simobjectid, typeof (InGameContext));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(InGameContext ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator InGameContext(int simobjectid)
        {
            return (InGameContext) Omni.self.getSimObject((uint) simobjectid, typeof (InGameContext));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(InGameContext ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator InGameContext(uint simobjectid)
        {
            return (InGameContext) Omni.self.getSimObject(simobjectid, typeof (InGameContext));
        }

        #endregion
    }
}