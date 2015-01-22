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

using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Lighting.advanced
{
    public partial class shadowViz
    {
        public static void initialize()
        {
            initialize_CS();
            Initialize_Gui();
        }

        public static void initialize_CS()
        {
            ObjectCreator tch = new ObjectCreator("ShaderData", "AL_ShadowVisualizeShader");
            tch["DXVertexShaderFile"] = "shaders/common/guiMaterialV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/dbgShadowVisualizeP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/gl/guiMaterialV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/dbgShadowVisualizeP.glsl";

            tch["pixVersion"] = 2.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_ShadowVisualizeMaterial");
            tch["shader"] = "AL_ShadowVisualizeShader";
            tch["stateBlock"] = "AL_DepthVisualizeState";

            tch["sampler[\"shadowMap\"]"] = "#AL_ShadowVizTexture";
            tch["sampler[\"depthViz\"]"] = "core/scripts/client/lighting/advanced/depthviz";

            tch["pixVersion"] = 2.0;
            tch.Create();

            SingletonCreator ts = new SingletonCreator("GuiControlProfile", "AL_ShadowLabelTextProfile");
            ts["fontColor"] = "0 0 0";
            ts["autoSizeWidth"] = true;
            ts["autoSizeHeight"] = true;
            ts["justify"] = "left";
            ts["fontSize"] = 14;
            ts.Create();
        }

        [ConsoleInteraction(true)]
        public static void toggleShadowViz()
        {
            if (((GuiControl) "AL_ShadowVizOverlayCtrl").isAwake())
                {
                pInvokes.Util.setShadowVizLight("0");
                ((GuiCanvas) "Canvas").popDialog("AL_ShadowVizOverlayCtrl");
                }
            else
                {
                ((GuiCanvas) "Canvas").pushDialog("AL_ShadowVizOverlayCtrl", 100);
                _setShadowVizLight(pInvokes.console.Call("EWorldEditor", "getSelectedObject", new[] {"0"}), false);
                }
        }

        [ConsoleInteraction(true)]
        public static void _setShadowVizLight(string light, bool force)
        {
            GuiControl AL_ShadowVizOverlayCtrl = "AL_ShadowVizOverlayCtrl";

            if (!AL_ShadowVizOverlayCtrl.isAwake())
                return;
            if (AL_ShadowVizOverlayCtrl["isLocked"].AsBool() && !force)
                return;

            string sizeAndAspect = "";
            if (light.isObject())
                {
                //todo Got a bug here I think, don't know enough about lighting to debug it at the moment.  the sizeAndAspect is always blank.
                string clientLight = client.serverToClientObject(light.AsInt()).AsString();
                //console.Call("serverToClientObject", new string[] { light });
                sizeAndAspect = pInvokes.Util.setShadowVizLight(clientLight);
                }

            pInvokes.console.Call(AL_ShadowVizOverlayCtrl.findObjectByInternalName("MatCtrl", true), "setMaterial", new[] {"AL_ShadowVisualizeMaterial"});
            string text = "ShadowViz";

            if (light.isObject() && sizeAndAspect != "")
                text = text + ":" + sizeAndAspect.Split(' ')[0] + " x " + sizeAndAspect.Split(' ')[1];

            pInvokes.console.SetVar(AL_ShadowVizOverlayCtrl.findObjectByInternalName("WindowCtrl", true), text);
        }

        [ConsoleInteraction(true)]
        public static void showShadowVizForLight(string light)
        {
            GuiControl AL_ShadowVizOverlayCtrl = "AL_ShadowVizOverlayCtrl";

            if (!AL_ShadowVizOverlayCtrl.isAwake())
                ((GuiCanvas) "Canvas").pushDialog(AL_ShadowVizOverlayCtrl, 100);

            _setShadowVizLight(light, true);
        }

        [ConsoleInteraction(true)]
        public static void lockShadowViz()
        {
            ((GuiControl) "AL_ShadowVizOverlayCtrl")["islocked"] = true.AsString();
        }

        [ConsoleInteraction(true)]
        public static void unlockShadowViz()
        {
            ((GuiControl) "AL_ShadowVizOverlayCtrl")["islocked"] = false.AsString();
        }
    }
}