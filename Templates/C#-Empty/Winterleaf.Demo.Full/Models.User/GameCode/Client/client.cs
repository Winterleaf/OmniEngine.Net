#region

using System;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.GraphicsQuality;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class client
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void LoadDefaults()
            {
            omni.sGlobal["$pref::Player::Name"] = "Visitor";
            omni.iGlobal["$pref::Player::defaultFov"] = 65;
            omni.iGlobal["$pref::Player::zoomSpeed"] = 0;

            omni.iGlobal["$pref::Net::LagThreshold"] = 400;
            omni.iGlobal["$pref::Net::Port"] = 28000;

            //omni.iGlobal["$pref::Net::PacketRateToClient"] = 32;
            //omni.iGlobal["$pref::Net::PacketRateToServer"] = 32;
            //omni.iGlobal["$pref::Net::PacketSize"] = 200;

            omni.iGlobal["$pref::HudMessageLogSize"] = 40;
            omni.iGlobal["$pref::ChatHudLength"] = 1;

            omni.iGlobal["$pref::Input::LinkMouseSensitivity"] = 1;
            // DInput keyboard, mouse, and joystick prefs
            omni.iGlobal["$pref::Input::KeyboardEnabled"] = 1;
            omni.iGlobal["$pref::Input::MouseEnabled"] = 1;
            omni.iGlobal["$pref::Input::JoystickEnabled"] = 0;
            omni.dGlobal["$pref::Input::KeyboardTurnSpeed"] = 0.1;

            omni.iGlobal["$sceneLighting::cacheSize"] = 20000;
            omni.sGlobal["$sceneLighting::purgeMethod"] = "lastCreated";
            omni.iGlobal["$sceneLighting::cacheLighting"] = 1;

            omni.sGlobal["$pref::Video::displayDevice"] = "D3D9";
            omni.iGlobal["$pref::Video::disableVerticalSync"] = 1;
            omni.sGlobal["$pref::Video::Canvas::mode"] = "1024 768 false 32 60 4";
            //omni.sGlobal["$pref::Video::Canvas_SceneTree::mode"] = "300 480 false 32 60 4";
            //omni.sGlobal["$pref::Video::Canvas_Inspector::mode"] = "500 480 false 32 60 4";

            omni.iGlobal["$pref::Video::defaultFenceCount"] = 0;
            omni.iGlobal["$pref::Video::screenShotSession"] = 0;
            omni.sGlobal["$pref::Video::screenShotFormat"] = "PNG";

            // This disables the hardware FSAA/MSAA so that
            // we depend completely on the FXAA post effect
            // which works on all cards and in deferred mode.
            //
            // Note the new Intel Hybrid graphics on laptops
            // will fail to initialize when hardware AA is
            // enabled... so you've been warned.
            //
            omni.bGlobal["$pref::Video::disableHardwareAA"] = true;

            omni.bGlobal["$pref::Video::disableNormalmapping"] = false;

            omni.bGlobal["$pref::Video::disablePixSpecular"] = false;

            omni.bGlobal["$pref::Video::disableCubemapping"] = false;


            omni.bGlobal["$pref::Video::disableParallaxMapping"] = false;

            omni.dGlobal["$pref::Video::Gamma"] = 1.0;

            if (omni.sGlobal["$platform"] == "xenon")
                {
                // Save some fillrate on the X360, and take advantage of the HW scaling
                omni.sGlobal["$pref::Video::Resolution"] = "1152 640";
                omni.sGlobal["$pref::Video::Canvas::mode"] = omni.sGlobal["$pref::Video::Resolution"] + " " +
                                                             "true 32 60 0";
                omni.iGlobal["$pref::Video::fullScreen"] = 1;
                }


            // This is the path used by ShaderGen to cache procedural
            // shaders.  If left blank ShaderGen will only cache shaders
            // to memory and not to disk.
            omni.sGlobal["$shaderGen::cachePath"] = "shaders/procedural";

            // The perfered light manager to use at startup.  If blank
            // or if the selected one doesn't work on this platfom it
            // will try the defaults below.
            omni.sGlobal["$pref::lightManager"] = "";

            // This is the default list of light managers ordered from
            // most to least desirable for initialization.
            omni.sGlobal["$lightManager::defaults"] = "Advanced Lighting\nBasic Lighting";

            // A scale to apply to the camera view distance
            // typically used for tuning performance.
            omni.dGlobal["$pref::camera::distanceScale"] = 1.0;

            // Causes the system to do a one time autodetect
            // of an SFX provider and device at startup if the
            // provider is unset.
            omni.bGlobal["$pref::SFX::autoDetect"] = true;

            // The sound provider to select at startup.  Typically
            // this is DirectSound, OpenAL, or XACT.  There is also 
            // a special Null provider which acts normally, but 
            // plays no sound.
            omni.sGlobal["$pref::SFX::provider"] = "";

            // The sound device to select from the provider.  Each
            // provider may have several different devices.
            omni.sGlobal["$pref::SFX::device"] = "OpenAL";

            // If true the device will try to use hardware buffers
            // and sound mixing.  If not it will use software.
            omni.bGlobal["$pref::SFX::useHardware"] = false;

            // If you have a software device you have a 
            // choice of how many software buffers to
            // allow at any one time.  More buffers cost
            // more CPU time to process and mix.
            omni.iGlobal["$pref::SFX::maxSoftwareBuffers"] = 16;

            // This is the playback frequency for the primary 
            // sound buffer used for mixing.  Although most
            // providers will reformat on the fly, for best 
            // quality and performance match your sound files
            // to this setting.
            omni.iGlobal["$pref::SFX::frequency"] = 44100;

            // This is the playback bitrate for the primary 
            // sound buffer used for mixing.  Although most
            // providers will reformat on the fly, for best 
            // quality and performance match your sound files
            // to this setting.
            omni.iGlobal["$pref::SFX::bitrate"] = 32;

            // The overall system volume at startup.  Note that 
            // you can only scale volume down, volume does not
            // get louder than 1.
            omni.dGlobal["$pref::SFX::masterVolume"] = 0.8;

            // The startup sound channel volumes.  These are 
            // used to control the overall volume of different 
            // classes of sounds.
            omni.iGlobal["$pref::SFX::channelVolume1"] = 1;
            omni.iGlobal["$pref::SFX::channelVolume2"] = 1;
            omni.iGlobal["$pref::SFX::channelVolume3"] = 1;
            omni.iGlobal["$pref::SFX::channelVolume4"] = 1;
            omni.iGlobal["$pref::SFX::channelVolume5"] = 1;
            omni.iGlobal["$pref::SFX::channelVolume6"] = 1;
            omni.iGlobal["$pref::SFX::channelVolume7"] = 1;
            omni.iGlobal["$pref::SFX::channelVolume8"] = 1;

            omni.sGlobal["$pref::PostEffect::PreferedHDRFormat"] = "GFXFormatR8G8B8A8";

            // This is an scalar which can be used to reduce the 
            // reflection textures on all objects to save fillrate.
            omni.dGlobal["$pref::Reflect::refractTexScale"] = 1.0;

            // This is the total frame in milliseconds to budget for
            // reflection rendering.  If your CPU bound and have alot
            // of smaller reflection surfaces try reducing this time.
            omni.iGlobal["$pref::Reflect::frameLimitMS"] = 10;

            // Set true to force all water objects to use static cubemap reflections.
            omni.bGlobal["$pref::Water::disableTrueReflections"] = false;

            // A global LOD scalar which can reduce the overall density of placed GroundCover.
            omni.dGlobal["$pref::GroundCover::densityScale"] = 1.0;

            // An overall scaler on the lod switching between DTS models.
            // Smaller numbers makes the lod switch sooner.
            omni.dGlobal["$pref::TS::detailAdjust"] = 1.0;
            omni.bGlobal["$pref::decalMgr::enabled"] = true;

            //
            omni.bGlobal["$pref::Decals::enabled"] = true;

            //
            omni.sGlobal["$pref::Decals::lifeTimeScale"] = "1";

            // The number of mipmap levels to drop on loaded textures
            // to reduce video memory usage.  
            //
            // It will skip any textures that have been defined as not 
            // allowing down scaling.
            //
            omni.iGlobal["$pref::Video::textureReductionLevel"] = 0;

            //
            omni.dGlobal["$pref::Shadows::textureScalar"] = 1.0;

            //
            omni.bGlobal["$pref::Shadows::disable"] = false;

            // Sets the shadow filtering mode.
            //
            // None - Disables filtering.
            //
            // SoftShadow - Does a simple soft shadow
            //
            // SoftShadowHighQuality 
            //
            omni.sGlobal["$pref::Shadows::filterMode"] = "SoftShadow";

            //
            omni.iGlobal["$pref::Video::defaultAnisotropy"] = 0;

            // Radius in meters around the camera that ForestItems are affected by wind.
            // Note that a very large number with a large number of items is not cheap.
            omni.iGlobal["$pref::windEffectRadius"] = 25;

            // AutoDetect graphics quality levels the next startup.
            omni.iGlobal["$pref::Video::autoDetect"] = 1;

            //-----------------------------------------------------------------------------
            // Graphics Quality Groups
            //-----------------------------------------------------------------------------

            // The graphics quality groups are used by the options dialog to
            // control the state of the $prefs.  You should overload these in
            // your game specific defaults.cs file if they need to be changed.

            if ("MeshQualityGroup".isObject())
                "MeshQualityGroup".delete();
            if ("TextureQualityGroup".isObject())
                "TextureQualityGroup".delete();
            if ("LightingQualityGroup".isObject())
                "LightingQualityGroup".delete();
            if ("ShaderQualityGroup".isObject())
                "ShaderQualityGroup".delete();

            ObjectCreator oc = new ObjectCreator("SimGroup", "MeshQualityGroup", typeof (QualityGroup));

            ObjectCreator ao1 = new ObjectCreator("ArrayObject", "[Lowest]", typeof (GraphicsQualityLevel));
            ao1["class"] = "GraphicsQualityLevel";
            ao1["caseSensitive"] = true;
            ao1["key[\"$pref::TS::detailAdjust\"]"] = 0.5;
            ao1["key[\"$pref::TS::skipRenderDLs\"]"] = 1;
            ao1["key[\"$pref::Terrain::lodScale\"]"] = 2.0;
            ao1["key[\"$pref::decalMgr::enabled\"]"] = false;
            ao1["key[\"$pref::GroundCover::densityScale\"]"] = 0.5;
            oc["#1"] = ao1;

            ObjectCreator ao2 = new ObjectCreator("ArrayObject", "[Low]", typeof (GraphicsQualityLevel));
            ao2["class"] = "GraphicsQualityLevel";
            ao2["caseSensitive"] = true;
            ao2["key[\"$pref::TS::detailAdjust\"]"] = 0.75;
            ao2["key[\"$pref::TS::skipRenderDLs\"]"] = 0;
            ao2["key[\"$pref::Terrain::lodScale\"]"] = 1.5;
            ao2["key[\"$pref::decalMgr::enabled\"]"] = true;
            ao2["key[\"$pref::GroundCover::densityScale\"]"] = 0.75;
            oc["#2"] = ao2;

            ObjectCreator ao3 = new ObjectCreator("ArrayObject", "[Normal]", typeof (GraphicsQualityLevel));
            ao3["class"] = "GraphicsQualityLevel";
            ao3["caseSensitive"] = true;
            ao3["key[\"$pref::TS::detailAdjust\"]"] = 1.0;
            ao3["key[\"$pref::TS::skipRenderDLs\"]"] = 0;
            ao3["key[\"$pref::Terrain::lodScale\"]"] = 1.0;
            ao3["key[\"$pref::decalMgr::enabled\"]"] = true;
            ao3["key[\"$pref::GroundCover::densityScale\"]"] = 1.0;
            oc["#3"] = ao3;

            ObjectCreator ao4 = new ObjectCreator("ArrayObject", "[High]", typeof (GraphicsQualityLevel));
            ao4["class"] = "GraphicsQualityLevel";
            ao4["caseSensitive"] = true;
            ao4["key[\"$pref::TS::detailAdjust\"]"] = 1.5;
            ao4["key[\"$pref::TS::skipRenderDLs\"]"] = 0;
            ao4["key[\"$pref::Terrain::lodScale\"]"] = 0.75;
            ao4["key[\"$pref::decalMgr::enabled\"]"] = true;
            ao4["key[\"$pref::GroundCover::densityScale\"]"] = 1.0;
            oc["#4"] = ao4;

            oc.Create();

            oc = new ObjectCreator("SimGroup", "TextureQualityGroup", typeof (TextureQualityGroup));
            ObjectCreator bo1 = new ObjectCreator("ArrayObject", "[Lowest]", typeof (GraphicsQualityLevel));
            bo1["class"] = "GraphicsQualityLevel";
            bo1["caseSensitive"] = true;
            bo1["key[\"$pref::Video::textureReductionLevel\"]"] = 2;
            bo1["key[\"$pref::Reflect::refractTexScale\"]"] = 0.5;
            bo1["key[\"$pref::Terrain::detailScale\"]"] = 0.5;
            oc["#1"] = bo1;

            ObjectCreator bo2 = new ObjectCreator("ArrayObject", "[Low]", typeof (GraphicsQualityLevel));
            bo2["class"] = "GraphicsQualityLevel";
            bo2["caseSensitive"] = true;
            bo2["key[\"$pref::Video::textureReductionLevel\"]"] = 1;
            bo2["key[\"$pref::Reflect::refractTexScale\"]"] = 0.75;
            bo2["key[\"$pref::Terrain::detailScale\"]"] = 0.75;
            oc["#2"] = bo2;

            ObjectCreator bo3 = new ObjectCreator("ArrayObject", "[Normal]", typeof (GraphicsQualityLevel));
            bo3["class"] = "GraphicsQualityLevel";
            bo3["caseSensitive"] = true;
            bo3["key[\"$pref::Video::textureReductionLevel\"]"] = 0;
            bo3["key[\"$pref::Reflect::refractTexScale\"]"] = 1;
            bo3["key[\"$pref::Terrain::detailScale\"]"] = 1;
            oc["#3"] = bo3;

            ObjectCreator bo4 = new ObjectCreator("ArrayObject", "[High]", typeof (GraphicsQualityLevel));
            bo4["class"] = "GraphicsQualityLevel";
            bo4["caseSensitive"] = true;
            bo4["key[\"$pref::Video::textureReductionLevel\"]"] = 0;
            bo4["key[\"$pref::Reflect::refractTexScale\"]"] = 1.25;
            bo4["key[\"$pref::Terrain::detailScale\"]"] = 1.5;
            oc["#4"] = bo4;
            oc.Create();

            oc = new ObjectCreator("SimGroup", "LightingQualityGroup", typeof (LightingQualityGroup));
            ObjectCreator co1 = new ObjectCreator("ArrayObject", "[Lowest]", typeof (GraphicsQualityLevel));
            co1["class"] = "GraphicsQualityLevel";
            co1["caseSensitive"] = true;
            co1["key[\"$pref::lightManager\"]"] = "Basic Lighting";
            co1["key[\"$pref::Shadows::disable\"]"] = false;
            co1["key[\"$pref::Shadows::textureScalar\"]"] = 0.5;
            co1["key[\"$pref::Shadows::filterMode\"]"] = "None";
            oc["#1"] = co1;

            ObjectCreator co2 = new ObjectCreator("ArrayObject", "[Low]", typeof (GraphicsQualityLevel));
            co2["class"] = "GraphicsQualityLevel";
            co2["caseSensitive"] = true;
            co2["key[\"$pref::lightManager\"]"] = "Advanced Lighting";
            co2["key[\"$pref::Shadows::disable\"]"] = false;
            co2["key[\"$pref::Shadows::textureScalar\"]"] = 0.5;
            co2["key[\"$pref::Shadows::filterMode\"]"] = "SoftShadow";
            oc["#2"] = co2;

            ObjectCreator co3 = new ObjectCreator("ArrayObject", "[Normal]", typeof (GraphicsQualityLevel));
            co3["class"] = "GraphicsQualityLevel";
            co3["caseSensitive"] = true;
            co3["key[\"$pref::lightManager\"]"] = "Advanced Lighting";
            co3["key[\"$pref::Shadows::disable\"]"] = false;
            co3["key[\"$pref::Shadows::textureScalar\"]"] = 1.0;
            co3["key[\"$pref::Shadows::filterMode\"]"] = "SoftShadow";
            oc["#3"] = co3;

            ObjectCreator co4 = new ObjectCreator("ArrayObject", "[High]", typeof (GraphicsQualityLevel));
            co4["class"] = "GraphicsQualityLevel";
            co4["caseSensitive"] = true;
            co4["key[\"$pref::lightManager\"]"] = "Advanced Lighting";
            co4["key[\"$pref::Shadows::disable\"]"] = false;
            co4["key[\"$pref::Shadows::textureScalar\"]"] = 2.0;
            co4["key[\"$pref::Shadows::filterMode\"]"] = "SoftShadowHighQuality";
            oc["#4"] = co4;

            oc.Create();

            oc = new ObjectCreator("SimGroup", "ShaderQualityGroup", typeof (QualityGroup));
            ObjectCreator so1 = new ObjectCreator("ArrayObject", "[Lowest]", typeof (GraphicsQualityLevel));
            so1["class"] = "GraphicsQualityLevel";
            so1["caseSensitive"] = true;

            so1["key[\"$pref::Video::disablePixSpecular\"]"] = true;
            so1["key[\"$pref::Video::disableNormalmapping\"]"] = true;
            so1["key[\"$pref::Video::disableParallaxMapping\"]"] = true;
            so1["key[\"$pref::Water::disableTrueReflections\"]"] = true;
            oc["#1"] = so1;

            ObjectCreator so2 = new ObjectCreator("ArrayObject", "[Low]", typeof (GraphicsQualityLevel));
            so2["class"] = "GraphicsQualityLevel";
            so2["caseSensitive"] = true;

            so2["key[\"$pref::Video::disablePixSpecular\"]"] = false;
            so2["key[\"$pref::Video::disableNormalmapping\"]"] = false;
            so2["key[\"$pref::Video::disableParallaxMapping\"]"] = true;
            so2["key[\"$pref::Water::disableTrueReflections\"]"] = true;
            oc["#2"] = so2;

            ObjectCreator so3 = new ObjectCreator("ArrayObject", "[Normal]", typeof (GraphicsQualityLevel));
            so3["class"] = "GraphicsQualityLevel";
            so3["caseSensitive"] = true;
            so3["key[\"$pref::Video::disablePixSpecular\"]"] = false;
            so3["key[\"$pref::Video::disableNormalmapping\"]"] = false;
            so3["key[\"$pref::Video::disableParallaxMapping\"]"] = false;
            so3["key[\"$pref::Water::disableTrueReflections\"]"] = false;
            oc["#3"] = so3;

            ObjectCreator so4 = new ObjectCreator("ArrayObject", "[High]", typeof (GraphicsQualityLevel));
            so4["class"] = "GraphicsQualityLevel";
            so4["caseSensitive"] = true;
            so4["key[\"$pref::Video::disablePixSpecular\"]"] = false;
            so4["key[\"$pref::Video::disableNormalmapping\"]"] = false;
            so4["key[\"$pref::Video::disableParallaxMapping\"]"] = false;
            so4["key[\"$pref::Water::disableTrueReflections\"]"] = false;
            oc["#4"] = so4;
            oc.Create();


            omni.bGlobal["$PhysXLogWarnings"] = false;
            if (omni.sGlobal["$platform"] != "xenon")
                {
                //Todo Settings - Switch this back when fixed.

                //Settings.LoadSection("scripts/client/prefs.cs");
                omni.Util.exec("prefs.client.cs", false, false);
                }
            else
                {
                omni.console.print("Not loading client prefs.cs on Xbox360");
                }
            }

        [ConsoleInteraction(true)]
        public static string GraphicsQualityAutodetect()
            {
            omni.bGlobal["$pref::Video::autoDetect = false;"] = false;

            float shaderVer = omni.Util.getPixelShaderVersion();
            bool intel = omni.Util.getDisplayDeviceInformation().ToUpper() == "INTEL";
            string videoMem = omni.console.Call_Classname("GFXCardProfilerAPI", "getVideoMemoryMB");

            return GraphicsQualityAutodetect_Apply(shaderVer, intel, videoMem);
            }

        public static string GraphicsQualityAutodetect_Apply(float shaderVer, bool intel, string videoMem)
            {
            if (shaderVer < 2.0)
                {
                return "Your video card does not meet the minimum requirment of shader model 2.0.";
                }
            if (shaderVer < 3 || intel)
                {
                if (shaderVer > 2.0)
                    {
                    ((GraphicsQualityLevel) ((SimSet) "MeshQualityGroup").findObjectByInternalName("Lowest", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "TextureQualityGroup").findObjectByInternalName("Lowest", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "LightingQualityGroup").findObjectByInternalName("Lowest", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "ShaderQualityGroup").findObjectByInternalName("Lowest", true))
                        .apply();
                    }
                else
                    {
                    ((GraphicsQualityLevel) ((SimSet) "MeshQualityGroup").findObjectByInternalName("Lowest", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "TextureQualityGroup").findObjectByInternalName("Lowest", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "LightingQualityGroup").findObjectByInternalName("Lowest", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "ShaderQualityGroup").findObjectByInternalName("Lowest", true))
                        .apply();
                    }
                }
            else
                {
                if (videoMem.AsInt() > 1000)
                    {
                    ((GraphicsQualityLevel) ((SimSet) "MeshQualityGroup").findObjectByInternalName("High", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "TextureQualityGroup").findObjectByInternalName("High", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "LightingQualityGroup").findObjectByInternalName("High", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "ShaderQualityGroup").findObjectByInternalName("High", true))
                        .apply();
                    }
                else if (videoMem.AsInt() > 400 || videoMem.AsInt() == 0)
                    {
                    ((GraphicsQualityLevel) ((SimSet) "MeshQualityGroup").findObjectByInternalName("Normal", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "TextureQualityGroup").findObjectByInternalName("Normal", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "LightingQualityGroup").findObjectByInternalName("Normal", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "ShaderQualityGroup").findObjectByInternalName("Normal", true))
                        .apply();
                    if (videoMem.AsInt() == 0)
                        return "Torque was unable to detect available video memory. Applying 'Normal' quality.";
                    }
                else
                    {
                    ((GraphicsQualityLevel) ((SimSet) "MeshQualityGroup").findObjectByInternalName("Low", true)).apply
                        ();
                    ((GraphicsQualityLevel) ((SimSet) "TextureQualityGroup").findObjectByInternalName("Low", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "LightingQualityGroup").findObjectByInternalName("Low", true))
                        .apply();
                    ((GraphicsQualityLevel) ((SimSet) "ShaderQualityGroup").findObjectByInternalName("Low", true))
                        .apply();
                    }
                }
            return "Graphics quality settings have been auto detected.";
            }

        [ConsoleInteraction(true)]
        public static void initBaseClient()
            {
            //message.Initialize();
            mission.initialize();
            renderManager.initialize();
            renderManager.initRenderManager();
            lighting.initLightingSystems();
            }

        [ConsoleInteraction(true)]
        public static int serverToClientObject(int serverObject)
            {
            if (!"LocalClientConnection".isObject())
                throw new Exception("serverToClientObject() - No local client connection found!");
            if (!"ServerConnection".isObject())
                throw new Exception("serverToClientObject() - No server connection found!");

            int ghostid = ((GameConnection) "LocalClientConnection").getGhostID(serverObject);
            if (ghostid == -1)
                return 0;

            return ((GameConnection) "ServerConnection").resolveGhostID(ghostid);
            }

        [ConsoleInteraction(true)]
        public static void netSimulateLag(int msDelay, int packetLossPercent)
            {
            omni.console.commandToServer("NetSimulateLag", new[] {msDelay.AsString(), packetLossPercent.AsString()});
            }
        }
    }