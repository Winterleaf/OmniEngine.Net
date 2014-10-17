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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.MenuBar;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Canvas
{
    [TypeConverter(typeof (TypeConverterGeneric<BaseEditorCanvas>))]
    public class BaseEditorCanvas : GuiCanvas
    {
        internal Extendable.MenuBar menuBar
        {
            get { return this["menuBar"]; }
            set { this["menuBar"] = value; }
        }

        [ConsoleInteraction]
        public override void onAdd()
        {
            this.createMenuBar();

            ObjectCreator oc = new ObjectCreator("GuiPanel");
            oc["internalName"] = "DocumentContainer";

            GuiPanel panel = oc.Create();

            this.setContent(panel);

            int xOffset = 20;
            int yOffset = 20;

            for (int i = 0; i < 10; i++)
                {
                ObjectCreator oc1 = new ObjectCreator("GuiWindowCtrl");
                oc["extent"] = "200 100";
                oc["position"] = xOffset + ' ' + yOffset;

                GuiWindowCtrl window = oc1.Create();
                panel.add(window);

                xOffset += 30;
                yOffset += 30;
                }
        }

        [ConsoleInteraction]
        public override void onRemove()
        {
            this.destroyMenuBar();
        }

        [ConsoleInteraction]
        public static void testBaseEditor()
        {
            new ObjectCreator("GuiCanvas", "", typeof (BaseEditorCanvas));
        }

        [ConsoleInteraction]
        // onAdd creates the base menu's and document controller
        public void createMenuBar()
        {
            if (this.menuBar.isObject())
                return;

            // Menu bar

            #region MenuBar ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("MenuBar", "");
            oc_Newobject2["dynamicItemInsertPos"] = new Creator.StringNoQuote("3");

            #region PopupMenu ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("PopupMenu", "basefileEditor", typeof (BaseEditorFileMenu));
            oc_Newobject1["internalName"] = "FileMenu";
            oc_Newobject1["barTitle"] = "File";
            oc_Newobject1["item[0]"] = "New..." + '\t' + "Ctrl N" + '\t' + "basefileEditor.onNew();";
            oc_Newobject1["item[1]"] = "Open..." + '\t' + "Ctrl O" + '\t' + "basefileEditor.onOpen();";
            oc_Newobject1["item[2]"] = "-";
            oc_Newobject1["item[3]"] = "Save" + '\t' + "Ctrl S" + '\t' + "basefileEditor.onSave();";
            oc_Newobject1["item[4]"] = "Save As" + '\t' + "Ctrl-Alt S" + '\t' + "basefileEditor.onSaveAs();";
            oc_Newobject1["item[5]"] = "Save All" + '\t' + "Ctrl-Shift S" + '\t' + "basefileEditor.onSaveAll();";
            oc_Newobject1["item[6]"] = "-";
            oc_Newobject1["item[7]"] = "Import..." + '\t' + "Ctrl-Shift I" + '\t' + "basefileEditor.onImport();";
            oc_Newobject1["item[8]"] = "Export..." + '\t' + "Ctrl-Shift E" + '\t' + "basefileEditor.onExport();";
            oc_Newobject1["item[9]"] = "-";
            oc_Newobject1["item[10]"] = "Revert" + '\t' + "Ctrl R" + '\t' + "basefileEditor.onRevert();";
            oc_Newobject1["item[11]"] = "-";
            oc_Newobject1["item[12]"] = "Close" + '\t' + "Ctrl W" + '\t' + "basefileEditor.onClose();";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            this.menuBar = oc_Newobject2.Create();
        }

        [ConsoleInteraction]
        public void destroyMenuBar()
        {
            if (this.menuBar.isObject())
                this.menuBar.delete();
        }

        [ConsoleInteraction]
        public override void onCreateMenu()
        {
            if (!this.menuBar.isObject())
                this.createMenuBar();

            this.menuBar.attachToCanvas(this, 0);
        }

        [ConsoleInteraction]
        public override void onDestroyMenu()
        {
            if (this.menuBar.isObject())
                {
                this.destroyMenuBar();
                this.menuBar.removeFromCanvas();
                }
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(BaseEditorCanvas ts, string simobjectid)
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
        public static bool operator !=(BaseEditorCanvas ts, string simobjectid)
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
        public static implicit operator string(BaseEditorCanvas ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator BaseEditorCanvas(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (BaseEditorCanvas) Omni.self.getSimObject(simobjectid, typeof (BaseEditorCanvas));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(BaseEditorCanvas ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator BaseEditorCanvas(int simobjectid)
        {
            return (BaseEditorCanvas) Omni.self.getSimObject((uint) simobjectid, typeof (BaseEditorCanvas));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(BaseEditorCanvas ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator BaseEditorCanvas(uint simobjectid)
        {
            return (BaseEditorCanvas) Omni.self.getSimObject(simobjectid, typeof (BaseEditorCanvas));
        }

        #endregion
    }
}