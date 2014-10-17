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
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<NavEditorAboutDlg>))]
    public class NavEditorAboutDlg : GuiControl
    {
        public static void initialize()
        {
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
                {
                #region GuiControl (NavEditorAboutDlg)        oc_Newobject00003

                oc_Newobject00003 = new ObjectCreator("GuiControl", "NavEditorAboutDlg", typeof (NavEditorAboutDlg));
                oc_Newobject00003["position"] = "0 0";
                oc_Newobject00003["extent"] = "1024 768";
                oc_Newobject00003["minExtent"] = "8 2";
                oc_Newobject00003["horizSizing"] = "right";
                oc_Newobject00003["vertSizing"] = "bottom";
                oc_Newobject00003["profile"] = "GuiOverlayProfile";
                oc_Newobject00003["visible"] = "1";
                oc_Newobject00003["active"] = "1";
                oc_Newobject00003["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject00003["hovertime"] = "1000";
                oc_Newobject00003["isContainer"] = "1";
                oc_Newobject00003["canSave"] = "1";
                oc_Newobject00003["canSaveDynamicFields"] = "1";
                oc_Newobject00003["fileName"] = "./about.hfl";
                if (true)
                    {
                    #region GuiWindowCtrl ()        oc_Newobject00002

                    oc_Newobject00002 = new ObjectCreator("GuiWindowCtrl", "");
                    oc_Newobject00002["text"] = "About";
                    oc_Newobject00002["resizeWidth"] = "0";
                    oc_Newobject00002["resizeHeight"] = "0";
                    oc_Newobject00002["canMove"] = "1";
                    oc_Newobject00002["canClose"] = "1";
                    oc_Newobject00002["canMinimize"] = "0";
                    oc_Newobject00002["canMaximize"] = "0";
                    oc_Newobject00002["canCollapse"] = "0";
                    oc_Newobject00002["closeCommand"] = "Canvas.popDialog(NavEditorAboutDlg);";
                    oc_Newobject00002["edgeSnap"] = "1";
                    oc_Newobject00002["margin"] = "0 0 0 0";
                    oc_Newobject00002["padding"] = "0 0 0 0";
                    oc_Newobject00002["anchorTop"] = "1";
                    oc_Newobject00002["anchorBottom"] = "0";
                    oc_Newobject00002["anchorLeft"] = "1";
                    oc_Newobject00002["anchorRight"] = "0";
                    oc_Newobject00002["position"] = "270 150";
                    oc_Newobject00002["extent"] = "320 240";
                    oc_Newobject00002["minExtent"] = "8 2";
                    oc_Newobject00002["horizSizing"] = "right";
                    oc_Newobject00002["vertSizing"] = "bottom";
                    oc_Newobject00002["profile"] = "GuiWindowProfile";
                    oc_Newobject00002["visible"] = "1";
                    oc_Newobject00002["active"] = "1";
                    oc_Newobject00002["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00002["hovertime"] = "1000";
                    oc_Newobject00002["isContainer"] = "1";
                    oc_Newobject00002["canSave"] = "1";
                    oc_Newobject00002["canSaveDynamicFields"] = "0";
                    if (true)
                        {
                        #region GuiMLTextCtrl ()        oc_Newobject00001

                        oc_Newobject00001 = new ObjectCreator("GuiMLTextCtrl", "");
                        oc_Newobject00001["lineSpacing"] = "2";
                        oc_Newobject00001["allowColorChars"] = "0";
                        oc_Newobject00001["maxChars"] = "-1";
                        oc_Newobject00001["useURLMouseCursor"] = "0";
                        oc_Newobject00001["position"] = "10 25";
                        oc_Newobject00001["extent"] = "300 178";
                        oc_Newobject00001["minExtent"] = "8 2";
                        oc_Newobject00001["horizSizing"] = "right";
                        oc_Newobject00001["vertSizing"] = "bottom";
                        oc_Newobject00001["profile"] = "GuiMLTextProfile";
                        oc_Newobject00001["visible"] = "1";
                        oc_Newobject00001["active"] = "1";
                        oc_Newobject00001["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00001["hovertime"] = "1000";
                        oc_Newobject00001["isContainer"] = "0";
                        oc_Newobject00001["internalName"] = "TextBox";
                        oc_Newobject00001["canSave"] = "1";
                        oc_Newobject00001["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00002["#Newobject00001"] = oc_Newobject00001;
                        }

                    #endregion

                    oc_Newobject00003["#Newobject00002"] = oc_Newobject00002;
                    }

                #endregion

                oc_Newobject00003.Create();
                }
        }

        [ConsoleInteraction]
        public override void onWake()
        {
            string text = "";
            FileObject f = new ObjectCreator("FileObject").Create();
            f.openForRead(this["fileName"]);
            while (!f.isEOF())
                text = text + f.readLine() + "\n";
            f.delete();

            ((GuiMLTextCtrl) FOT("TextBox")).setText(text);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NavEditorAboutDlg ts, string simobjectid)
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
        public static bool operator !=(NavEditorAboutDlg ts, string simobjectid)
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
        public static implicit operator string(NavEditorAboutDlg ts)
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
        public static implicit operator NavEditorAboutDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (NavEditorAboutDlg) Omni.self.getSimObject(simobjectid, typeof (NavEditorAboutDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(NavEditorAboutDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NavEditorAboutDlg(int simobjectid)
        {
            return (NavEditorAboutDlg) Omni.self.getSimObject((uint) simobjectid, typeof (NavEditorAboutDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(NavEditorAboutDlg ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NavEditorAboutDlg(uint simobjectid)
        {
            return (NavEditorAboutDlg) Omni.self.getSimObject(simobjectid, typeof (NavEditorAboutDlg));
        }

        #endregion
    }
}