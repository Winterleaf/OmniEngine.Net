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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ConvexEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ConvexEditorToolbar>))]
    public class ConvexEditorToolbar : GuiControl
    {
        [ConsoleInteraction(true, "ConvexEditorToolbar_initialize")]
        public static void initialize()
        {
            #region GuiControl (convexEditorToolbar, EditorGuiGroup)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "convexEditorToolbar, EditorGuiGroup", typeof (ConvexEditorToolbar));
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "305 0";
            oc_Newobject7["Extent"] = new Creator.StringNoQuote("\"550\" SPC getWord(EditorGuiToolbar.extent, 1)");
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canMove"] = "0";
            oc_Newobject7["canClose"] = "0";
            oc_Newobject7["canMinimize"] = "0";
            oc_Newobject7["canMaximize"] = "0";
            oc_Newobject7["resizeWidth"] = "0";
            oc_Newobject7["resizeHeight"] = "0";
            oc_Newobject7["EdgeSnap"] = "0";
            oc_Newobject7["text"] = "";

            #region GuiContainer ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiContainer", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "menubarProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "800 32";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "15 7";
            oc_Newobject1["extent"] = "86 16";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["text"] = "Sketch Tool";
            oc_Newobject1["maxLength"] = "255";
            oc_Newobject1["helpTag"] = "0";

            #endregion

            oc_Newobject6["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["position"] = "94 3";
            oc_Newobject2["Extent"] = "2 26";
            oc_Newobject2["MinExtent"] = "1 1";
            oc_Newobject2["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (ConvexEditorCreateBoxBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "ConvexEditorCreateBoxBtn");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "100 3";
            oc_Newobject3["Extent"] = "29 27";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "ConvexEditorGui.createConvexBox();";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = new Creator.StringNoQuote("\"Create ConvexShape Box\" NL \"Use Alt + Click-Drag instead of this for more control of starting placement.\"");
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["bitmap"] = "tools/convexEditor/images/convex-editor-btn";
            oc_Newobject3["text"] = "";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl (ConvexEditorSplitFaceBtn)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "ConvexEditorSplitFaceBtn");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "134 3";
            oc_Newobject4["Extent"] = "29 27";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "ConvexEditorGui.splitSelectedFace();";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["ToolTip"] = new Creator.StringNoQuote("\"Split selected face\" NL \"Use Ctrl + Rotate instead for more control.\"");
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["bitmap"] = "tools/convexEditor/images/split-face-btn";
            oc_Newobject4["text"] = "";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl (ConvexEditorDeleteFaceBtn)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "ConvexEditorDeleteFaceBtn");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "166 3";
            oc_Newobject5["Extent"] = "29 27";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "ConvexEditorGui.handleDelete();";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = new Creator.StringNoQuote("\"Delete selected face\" NL \"(Delete)\"");
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "tools/gui/images/menubar/delete-btn";
            oc_Newobject5["text"] = "";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "PushButton";
            oc_Newobject5["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject7.Create();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ConvexEditorToolbar ts, string simobjectid)
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
        public static bool operator !=(ConvexEditorToolbar ts, string simobjectid)
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
        public static implicit operator string(ConvexEditorToolbar ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorToolbar(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ConvexEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorToolbar));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ConvexEditorToolbar ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorToolbar(int simobjectid)
        {
            return (ConvexEditorToolbar) Omni.self.getSimObject((uint) simobjectid, typeof (ConvexEditorToolbar));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ConvexEditorToolbar ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ConvexEditorToolbar(uint simobjectid)
        {
            return (ConvexEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorToolbar));
        }

        #endregion
    }
}