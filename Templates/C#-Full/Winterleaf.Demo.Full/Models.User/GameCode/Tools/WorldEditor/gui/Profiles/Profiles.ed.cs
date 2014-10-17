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

using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.Profiles
{
    public class Profiles
    {
        [ConsoleInteraction(true, "WorldEditor_Profiles_initialize")]
        public static void initialize()
        {
            #region GuiControlProfile  (EditorDefaultProfile)        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile ", "EditorDefaultProfile");
            oc_Newobject1["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();

            #region GuiControlProfile  (EditorToolButtonProfile)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiControlProfile ", "EditorToolButtonProfile");
            oc_Newobject2["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject2["border"] = new Creator.StringNoQuote("2");
            oc_Newobject2["category"] = "Editor";

            #endregion

            oc_Newobject2.Create();

            #region GuiControlProfile  (EditorTextProfile)        oc_Newobject3

            SingletonCreator oc_Newobject3 = new SingletonCreator("GuiControlProfile ", "EditorTextProfile");
            oc_Newobject3["fontType"] = "Arial Bold";
            oc_Newobject3["fontColor"] = "196 196 196 255";
            oc_Newobject3["autoSizeWidth"] = new Creator.StringNoQuote("true");
            oc_Newobject3["autoSizeHeight"] = new Creator.StringNoQuote("true");
            oc_Newobject3["category"] = "Editor";

            #endregion

            oc_Newobject3.Create();

            #region GuiControlProfile  (EditorTextProfileWhite)        oc_Newobject4

            SingletonCreator oc_Newobject4 = new SingletonCreator("GuiControlProfile ", "EditorTextProfileWhite");
            oc_Newobject4["fontType"] = "Arial Bold";
            oc_Newobject4["fontColor"] = "255 255 255";
            oc_Newobject4["autoSizeWidth"] = new Creator.StringNoQuote("true");
            oc_Newobject4["autoSizeHeight"] = new Creator.StringNoQuote("true");
            oc_Newobject4["category"] = "Editor";

            #endregion

            oc_Newobject4.Create();

            #region GuiControlProfile  (WorldEditorProfile)        oc_Newobject5

            SingletonCreator oc_Newobject5 = new SingletonCreator("GuiControlProfile ", "WorldEditorProfile");
            oc_Newobject5["canKeyFocus"] = new Creator.StringNoQuote("true");
            oc_Newobject5["category"] = "Editor";

            #endregion

            oc_Newobject5.Create();

            #region GuiControlProfile  (EditorScrollProfile)        oc_Newobject6

            SingletonCreator oc_Newobject6 = new SingletonCreator("GuiControlProfile ", "EditorScrollProfile");
            oc_Newobject6["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject6["fillColor"] = "192 192 192 192";
            oc_Newobject6["border"] = new Creator.StringNoQuote("3");
            oc_Newobject6["borderThickness"] = new Creator.StringNoQuote("2");
            oc_Newobject6["borderColor"] = "0 0 0";
            oc_Newobject6["bitmap"] = "tools/gui/images/scrollBar";
            oc_Newobject6["hasBitmapArray"] = new Creator.StringNoQuote("true");
            oc_Newobject6["category"] = "Editor";

            #endregion

            oc_Newobject6.Create();

            #region GuiControlProfile  (GuiEditorClassProfile)        oc_Newobject7

            SingletonCreator oc_Newobject7 = new SingletonCreator("GuiControlProfile ", "GuiEditorClassProfile");
            oc_Newobject7["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject7["fillColor"] = "232 232 232";
            oc_Newobject7["border"] = new Creator.StringNoQuote("true");
            oc_Newobject7["borderColor"] = "0 0 0";
            oc_Newobject7["borderColorHL"] = "127 127 127";
            oc_Newobject7["fontColor"] = "0 0 0";
            oc_Newobject7["fontColorHL"] = "50 50 50";
            oc_Newobject7["fixedExtent"] = new Creator.StringNoQuote("true");
            oc_Newobject7["justify"] = "center";
            oc_Newobject7["bitmap"] = "tools/gui/images/scrollBar";
            oc_Newobject7["hasBitmapArray"] = new Creator.StringNoQuote("true");
            oc_Newobject7["category"] = "Editor";

            #endregion

            oc_Newobject7.Create();

            #region GuiControlProfile ( EPainterBitmapProfile )        oc_Newobject8

            SingletonCreator oc_Newobject8 = new SingletonCreator("GuiControlProfile", "EPainterBitmapProfile");
            oc_Newobject8["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject8["border"] = new Creator.StringNoQuote("false");
            oc_Newobject8["borderColor"] = "243 242 241";
            oc_Newobject8["Color"] = "230 230 230";
            oc_Newobject8["category"] = "Editor";

            #endregion

            oc_Newobject8.Create();

            #region GuiControlProfile ( EPainterBorderButtonProfile : ToolsGuiDefaultProfile )        oc_Newobject9

            SingletonCreator oc_Newobject9 = new SingletonCreator("GuiControlProfile", " EPainterBorderButtonProfile : ToolsGuiDefaultProfile ");
            oc_Newobject9["border"] = new Creator.StringNoQuote("true");
            oc_Newobject9["borderColor"] = "0 0 0";
            oc_Newobject9["borderThickness"] = new Creator.StringNoQuote("2");
            oc_Newobject9["fontColorHL"] = "255 0 0";
            oc_Newobject9["fontColorSEL"] = "0 0 255";
            oc_Newobject9["category"] = "Editor";

            #endregion

            oc_Newobject9.Create();

            #region GuiControlProfile ( EPainterDragDropProfile )        oc_Newobject10

            SingletonCreator oc_Newobject10 = new SingletonCreator("GuiControlProfile", "EPainterDragDropProfile");
            oc_Newobject10["justify"] = "center";
            oc_Newobject10["fontColor"] = "0 0 0";
            oc_Newobject10["border"] = new Creator.StringNoQuote("0");
            oc_Newobject10["textOffset"] = "0 0";
            oc_Newobject10["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject10["fillColor"] = "221 221 221 150";
            oc_Newobject10["category"] = "Editor";

            #endregion

            oc_Newobject10.Create();

            #region GizmoProfile ( GlobalGizmoProfile )        oc_Newobject11

            SingletonCreator oc_Newobject11 = new SingletonCreator("GizmoProfile", "GlobalGizmoProfile");
            oc_Newobject11["screenLength"] = new Creator.StringNoQuote("100");
            oc_Newobject11["category"] = "Editor";

            #endregion

            oc_Newobject11.Create();
        }
    }
}