using System.Text;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class metrics
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            //con.error("------------------------>LOADING FRAMEOVERLAYGUI!!!!!!!!!!!!!!!!!!!!!");
            FrameOverlayGui.initialize();
            metricsGui.initialize();
            }


        [ConsoleInteraction(true)]
        public static string fpsMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append(" | FPS | ");
            outtext.Append(omni.sGlobal["$fps::real"] + "  max: ");
            outtext.Append(omni.sGlobal["$fps::realMax"] + "  min: ");
            outtext.Append(omni.sGlobal["$fps::realMin"] + "  mspf: ");
            outtext.Append((1000.0/omni.dGlobal["$fps::real"]));
            return outtext.ToString();
            //return "  | FPS |  " +
            //    t3d.sGlobal["$fps::real"] + "  max: " +
            //    t3d.sGlobal["$fps::realMax"] + "  min: " +
            //    t3d.sGlobal["$fps::realMin"] + "  mspf: " +
            //    (1000.0 / t3d.dGlobal["$fps::real"]);
            }

        [ConsoleInteraction(true)]
        public static string gfxMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append("  | GFX |");
            outtext.Append("  PolyCount: ");
            outtext.Append(omni.sGlobal["$GFXDeviceStatistics::polyCount"]);
            outtext.Append("  DrawCalls: ");
            outtext.Append(omni.sGlobal["$GFXDeviceStatistics::drawCalls"]);
            outtext.Append("  RTChanges: ");
            outtext.Append(omni.sGlobal["$GFXDeviceStatistics::renderTargetChanges"]);
            return outtext.ToString();


            //return "  | GFX |" + 
            //    "  PolyCount: " + 
            //    t3d.sGlobal["$GFXDeviceStatistics::polyCount"] + 
            //    "  DrawCalls: " + 
            //    t3d.sGlobal["$GFXDeviceStatistics::drawCalls"] + 
            //    "  RTChanges: " + 
            //    t3d.sGlobal["$GFXDeviceStatistics::renderTargetChanges"];
            }

        [ConsoleInteraction(true)]
        public static string terrainMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append("  | Terrain |");
            outtext.Append("  Cells: ");
            outtext.Append(omni.sGlobal["$TerrainBlock::cellsRendered"]);
            outtext.Append("  Override Cells: ");
            outtext.Append(omni.sGlobal["$TerrainBlock::overrideCells"]);
            outtext.Append("  DrawCalls: ");
            outtext.Append(omni.sGlobal["$TerrainBlock::drawCalls"]);
            return outtext.ToString();
            //return 
            //    "  | Terrain |" + 
            //    "  Cells: " + 
            //    t3d.sGlobal["$TerrainBlock::cellsRendered"] + 
            //    "  Override Cells: " + 
            //    t3d.sGlobal["$TerrainBlock::overrideCells"] + 
            //    "  DrawCalls: " + 
            //    t3d.sGlobal["$TerrainBlock::drawCalls"];
            }

        [ConsoleInteraction(true)]
        public static string netMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append("  | Net |");
            outtext.Append("  BitsSent: ");
            outtext.Append(omni.sGlobal["$Stats::netBitsSent"]);
            outtext.Append("  BitsRcvd: ");
            outtext.Append(omni.sGlobal["$Stats::netBitsReceived"]);
            outtext.Append("  GhostUpd: ");
            outtext.Append(omni.sGlobal["$Stats::netGhostUpdates"]);
            return outtext.ToString();

            //return 
            //    "  | Net |" + 
            //    "  BitsSent: " + 
            //    t3d.sGlobal["$Stats::netBitsSent"] + 
            //    "  BitsRcvd: " + 
            //    t3d.sGlobal["$Stats::netBitsReceived"] + 
            //    "  GhostUpd: " + 
            //    t3d.sGlobal["$Stats::netGhostUpdates"];
            }

        [ConsoleInteraction(true)]
        public static string groundCoverMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append("  | GroundCover |");
            outtext.Append("  Cells: ");
            outtext.Append(omni.sGlobal["$GroundCover::renderedCells"]);
            outtext.Append("  Billboards: ");
            outtext.Append(omni.sGlobal["$GroundCover::renderedBillboards"]);
            outtext.Append("  Batches: ");
            outtext.Append(omni.sGlobal["$GroundCover::renderedBatches"]);
            outtext.Append("  Shapes: ");
            outtext.Append(omni.sGlobal["$GroundCover::renderedShapes"]);
            return outtext.ToString();

            //return 
            //    "  | GroundCover |" + 
            //    "  Cells: " + 
            //    t3d.sGlobal["$GroundCover::renderedCells"] + 
            //    "  Billboards: " + 
            //    t3d.sGlobal["$GroundCover::renderedBillboards"] + 
            //    "  Batches: " + 
            //    t3d.sGlobal["$GroundCover::renderedBatches"] + 
            //    "  Shapes: " + 
            //    t3d.sGlobal["$GroundCover::renderedShapes"];
            }

        [ConsoleInteraction(true)]
        public static string sfxMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append("  | SFX |");
            outtext.Append("  Sounds: ");
            outtext.Append(omni.sGlobal["$SFX::numSounds"]);
            outtext.Append("  Lists: ");
            outtext.Append((omni.iGlobal["$SFX::numSources"] - omni.iGlobal["$SFX::numSounds"] -
                            omni.iGlobal["$SFX::Device::fmodNumEventSource"]));
            outtext.Append("  Events: ");
            outtext.Append(omni.sGlobal["$SFX::fmodNumEventSources"]);
            outtext.Append("  Playing: ");
            outtext.Append(omni.sGlobal["$SFX::numPlaying"]);
            outtext.Append("  Culled: ");
            outtext.Append(omni.sGlobal["$SFX::numCulled"]);
            outtext.Append("  Voices: ");
            outtext.Append(omni.sGlobal["$SFX::numVoices"]);
            outtext.Append("  Buffers: ");
            outtext.Append(omni.sGlobal["$SFX::Device::numBuffers"]);
            outtext.Append("  Memory: ");
            outtext.Append((omni.dGlobal["$SFX::Device::numBufferBytes"]/1024.0/1024.0));
            outtext.Append(" MB");
            outtext.Append("  Time/S: ");
            outtext.Append(omni.sGlobal["$SFX::sourceUpdateTime"]);
            outtext.Append("  Time/P: ");
            outtext.Append(omni.sGlobal["$SFX::parameterUpdateTime"]);
            outtext.Append("  Time/A: ");
            outtext.Append(omni.sGlobal["$SFX::ambientUpdateTime"]);
            return outtext.ToString();

            //return 
            //    "  | SFX |" + 
            //    "  Sounds: " + 
            //    t3d.sGlobal["$SFX::numSounds"] + 
            //    "  Lists: " + 
            //    (t3d.iGlobal["$SFX::numSources"] - t3d.iGlobal["$SFX::numSounds"] - t3d.iGlobal["$SFX::Device::fmodNumEventSource"]) +
            //    "  Events: " + 
            //    t3d.sGlobal["$SFX::fmodNumEventSources"] + 
            //    "  Playing: " + 
            //    t3d.sGlobal["$SFX::numPlaying"] + 
            //    "  Culled: " + 
            //    t3d.sGlobal["$SFX::numCulled"] + 
            //    "  Voices: " + 
            //    t3d.sGlobal["$SFX::numVoices"] + 
            //    "  Buffers: " + 
            //    t3d.sGlobal["$SFX::Device::numBuffers"] + 
            //    "  Memory: " + 
            //    (t3d.dGlobal["$SFX::Device::numBufferBytes"] / 1024.0 / 1024.0) + 
            //    " MB" + 
            //    "  Time/S: " + 
            //    t3d.sGlobal["$SFX::sourceUpdateTime"] + 
            //    "  Time/P: " + 
            //    t3d.sGlobal["$SFX::parameterUpdateTime"] + 
            //    "  Time/A: " + 
            //    t3d.sGlobal["$SFX::ambientUpdateTime"];
            }

        [ConsoleInteraction(true)]
        public static string sfxSourcesMetricsCallback()
            {
            return omni.Util.sfxDumpSourcesToString(false);
            }

        [ConsoleInteraction(true)]
        public static string sfxStatesMetricsCallback()
            {
            return "  | SFXStates |" + omni.sGlobal["sfxGetActiveStates"];
            }

        [ConsoleInteraction(true)]
        public static string timeMetricsCallback()
            {
            return "  | Time |" + "  Sim Time: " + omni.Util.getSimTime() + "  Mod: " + (omni.Util.getSimTime()%32);
            }

        [ConsoleInteraction(true)]
        public static string reflectMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append("  | REFLECT |");
            outtext.Append("  Objects: ");
            outtext.Append(omni.sGlobal["$Reflect::numObjects"]);
            outtext.Append("  Visible: ");
            outtext.Append(omni.sGlobal["$Reflect::numVisible"]);
            outtext.Append("  Occluded: ");
            outtext.Append(omni.sGlobal["$Reflect::numOccluded"]);
            outtext.Append("  Updated: ");
            outtext.Append(omni.sGlobal["$Reflect::numUpdated"]);
            outtext.Append("  Elapsed: ");
            outtext.Append(omni.sGlobal["$Reflect::elapsed"]);
            outtext.Append("\n");
            outtext.Append("  Allocated: ");
            outtext.Append(omni.sGlobal["$Reflect::renderTargetsAllocated"]);
            outtext.Append("  Pooled: ");
            outtext.Append(omni.sGlobal["$Reflect::poolSize"]);
            outtext.Append("\n");
            outtext.Append("  ");

            string[] textstat = omni.sGlobal["$Reflect::textureStats"].Split(' ');

            if (textstat.GetUpperBound(0) > 0)
                {
                outtext.Append(textstat[1]);
                outtext.Append("\t");
                outtext.Append("  ");
                outtext.Append(textstat[2]);
                outtext.Append("MB");
                outtext.Append("\t");
                outtext.Append("  ");
                outtext.Append(textstat[0]);
                }
            else
                {
                outtext.Append("");
                outtext.Append("\t");
                outtext.Append("  ");
                outtext.Append("");
                outtext.Append("MB");
                outtext.Append("\t");
                outtext.Append("  ");
                outtext.Append("");
                }
            return outtext.ToString();

            //return 
            //    "  | REFLECT |" + 
            //    "  Objects: " + 
            //    t3d.sGlobal["$Reflect::numObjects"] + 
            //    "  Visible: " + 
            //    t3d.sGlobal["$Reflect::numVisible"] + 
            //    "  Occluded: " + 
            //    t3d.sGlobal["$Reflect::numOccluded"] + 
            //    "  Updated: " + 
            //    t3d.sGlobal["$Reflect::numUpdated"] + 
            //    "  Elapsed: " + 
            //    t3d.sGlobal["$Reflect::elapsed"] + 
            //    "\n" + 
            //    "  Allocated: " + 
            //    t3d.sGlobal["$Reflect::renderTargetsAllocated"] + 
            //    "  Pooled: " + 
            //    t3d.sGlobal["$Reflect::poolSize"] + 
            //    "\n" + 
            //    "  " + 
            //    t3d.sGlobal["$Reflect::textureStats"].Split(' ')[1] + 
            //    "\t" + 
            //    "  " + 
            //    t3d.sGlobal["$Reflect::textureStats"].Split(' ')[2] + 
            //    "MB" + 
            //    "\t" + 
            //    "  " + 
            //    t3d.sGlobal["$Reflect::textureStats"].Split(' ')[0];
            }

        [ConsoleInteraction(true)]
        public static string decalMetricsCallback()
            {
            return "  | DECAL |" + " Batches: " + omni.sGlobal["$Decal::Batches"] + " Buffers: " +
                   omni.sGlobal["$Decal::Buffers"] + " DecalsRendered: " + omni.sGlobal["$Decal::DecalsRendered"];
            }

        [ConsoleInteraction(true)]
        public static string renderMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append("  | Render |");
            outtext.Append("  Int: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_Interior"]);
            outtext.Append("  IntDL: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_InteriorDynamicLighting"]);
            outtext.Append("  Mesh: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_Mesh"]);
            outtext.Append("  MeshDL: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_MeshDynamicLighting"]);
            outtext.Append("  Shadow: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_Shadow"]);
            outtext.Append("  Sky: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_Sky"]);
            outtext.Append("  Obj: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_Object"]);
            outtext.Append("  ObjT: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_ObjectTranslucent"]);
            outtext.Append("  Decal: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_Decal"]);
            outtext.Append("  Water: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_Water"]);
            outtext.Append("  Foliage: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_Foliage"]);
            outtext.Append("  Trans: ");
            outtext.Append(omni.sGlobal["$RenderMetris::RIT_Translucent"]);
            outtext.Append("  Custom: ");
            outtext.Append(omni.sGlobal["$RenderMetrics::RIT_Custom"]);
            return outtext.ToString();
            //return 
            //    "  | Render |" + 
            //    "  Int: " + 
            //    t3d.sGlobal["$RenderMetrics::RIT_Interior"] + 
            //    "  IntDL: " + 
            //    t3d.sGlobal["$RenderMetrics::RIT_InteriorDynamicLighting"] + 
            //    "  Mesh: " + 
            //    t3d.sGlobal["$RenderMetrics::RIT_Mesh"] + 
            //    "  MeshDL: " + 
            //    t3d.sGlobal["$RenderMetrics::RIT_MeshDynamicLighting"] + 
            //    "  Shadow: " + 
            //    t3d.sGlobal["$RenderMetrics::RIT_Shadow"] + 
            //    "  Sky: " +
            //    t3d.sGlobal["$RenderMetrics::RIT_Sky"] + 
            //    "  Obj: " + 
            //    t3d.sGlobal["$RenderMetrics::RIT_Object"] + 
            //    "  ObjT: " +
            //    t3d.sGlobal["$RenderMetrics::RIT_ObjectTranslucent"] + 
            //    "  Decal: " + 
            //    t3d.sGlobal["$RenderMetrics::RIT_Decal"] + 
            //    "  Water: " + 
            //    t3d.sGlobal["$RenderMetrics::RIT_Water"] +
            //    "  Foliage: " +
            //    t3d.sGlobal["$RenderMetrics::RIT_Foliage"] + 
            //    "  Trans: " +
            //    t3d.sGlobal["$RenderMetris::RIT_Translucent"] +
            //    "  Custom: " + 
            //    t3d.sGlobal["$RenderMetrics::RIT_Custom"];
            }

        [ConsoleInteraction(true)]
        public static string shadowMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append("  | Shadow |");
            outtext.Append("  Active: ");
            outtext.Append(omni.sGlobal["$ShadowStats::activeMaps"]);
            outtext.Append("  Updated: ");
            outtext.Append(omni.sGlobal["$ShadowStats::updatedMaps"]);
            outtext.Append("  PolyCount: ");
            outtext.Append(omni.sGlobal["$ShadowStats::polyCount"]);
            outtext.Append("  DrawCalls: ");
            outtext.Append(omni.sGlobal["$ShadowStats::drawCalls"]);
            outtext.Append("  RTChanges: ");
            outtext.Append(omni.sGlobal["$ShadowStats::rtChanges"]);
            outtext.Append("  PoolTexCount: ");
            outtext.Append(omni.sGlobal["$ShadowStats::poolTexCount"]);
            outtext.Append("  PoolTexMB: ");
            outtext.Append(omni.sGlobal["$ShadowStats::poolTexMemory"]);
            outtext.Append("MB");
            return outtext.ToString();

            //return 
            //    "  | Shadow |" + 
            //    "  Active: " +
            //    t3d.sGlobal["$ShadowStats::activeMaps"] +
            //    "  Updated: " +
            //    t3d.sGlobal["$ShadowStats::updatedMaps"] + 
            //    "  PolyCount: " + 
            //    t3d.sGlobal["$ShadowStats::polyCount"] + 
            //    "  DrawCalls: " + 
            //    t3d.sGlobal["$ShadowStats::drawCalls"] + 
            //    "  RTChanges: " + 
            //    t3d.sGlobal["$ShadowStats::rtChanges"] + 
            //    "  PoolTexCount: " + 
            //    t3d.sGlobal["$ShadowStats::poolTexCount"] +
            //    "  PoolTexMB: " +
            //    t3d.sGlobal["$ShadowStats::poolTexMemory"] + 
            //    "MB";
            }

        [ConsoleInteraction(true)]
        public static string basicShadowMetricsCallback()
            {
            StringBuilder outtext = new StringBuilder(1000);
            outtext.Append("  | Shadow |");
            outtext.Append("  Active: ");
            outtext.Append(omni.sGlobal["$BasicLightManagerStats::activePlugins"]);
            outtext.Append("  Updated: ");
            outtext.Append(omni.sGlobal["$BasicLightManagerStats::shadowsUpdated"]);
            outtext.Append("  Elapsed Ms: ");
            outtext.Append(omni.sGlobal["$BasicLightManagerStats::elapsedUpdateMs"]);
            return outtext.ToString();
            //return 
            //    "  | Shadow |" + 
            //    "  Active: " + 
            //    t3d.sGlobal["$BasicLightManagerStats::activePlugins"] + 
            //    "  Updated: " + 
            //    t3d.sGlobal["$BasicLightManagerStats::shadowsUpdated"] + 
            //    "  Elapsed Ms: " + 
            //    t3d.sGlobal["$BasicLightManagerStats::elapsedUpdateMs"];
            }

        [ConsoleInteraction(true)]
        public static string lightMetricsCallback()
            {
            return "  | Deferred Lights |" + "  Active: " + omni.sGlobal["$lightMetrics::activeLights"] + "  Culled: " +
                   omni.sGlobal["$lightMetrics::culledLights"];
            }

        [ConsoleInteraction(true)]
        public static string particleMetricsCallback()
            {
            return "  | Particles |" + "  # Simulated " + omni.sGlobal["$particle::numSimulated"];
            }

        [ConsoleInteraction(true)]
        public static string partMetricsCallback()
            {
            return particleMetricsCallback();
            }

        [ConsoleInteraction(true)]
        public static string audioMetricsCallback()
            {
            return sfxMetricsCallback();
            }

        [ConsoleInteraction(true)]
        public static string videoMetricsCallback()
            {
            return gfxMetricsCallback();
            }

        [ConsoleInteraction(true)]
        public static string imposterMetricsCallback()
            {
            StringBuilder sb = new StringBuilder(1000);
            sb.Append("  | IMPOSTER |");
            sb.Append("   Rendered: ");
            sb.Append(omni.sGlobal["$ImposterStats::rendered"]);
            sb.Append("   Batches: ");
            sb.Append(omni.sGlobal["$ImposterStats::batches"]);
            sb.Append("   DrawCalls: ");
            sb.Append(omni.sGlobal["$ImposterStats::drawCalls"]);
            sb.Append("   Polys: ");
            sb.Append(omni.sGlobal["$ImposterStats::polyCount"]);
            sb.Append("   RtChanges: ");
            sb.Append(omni.sGlobal["$ImposterStats::rtChanges"]);
            return sb.ToString();
            }

        // Add a metrics HUD.  %expr can be a vector of names where each element
        // must have a corresponding '<name>MetricsCallback()' function defined
        // that will be called on each update of the GUI control.  The results
        // of each function are stringed together.
        //
        // Example: metrics( "fps gfx" );
        [ConsoleInteraction(true)]
        public static void Metrics(string expr)
            {
            string metricsExpr = "";
            if (expr != "")
                {
                foreach (string name in expr.Split(' '))
                    {
                    string cb = name.Trim() + "MetricsCallback";
                    //Can't check any more since the function isn't defined in DLL, will need to fix this.
                    //if (!t3d.console.isFunction(cb))
                    //    {
                    //    t3d.console.error("metrics - undefined callback: " + cb);
                    //    }
                    //else
                        {
                        cb = cb + "()";
                        if (metricsExpr.Length > 0)
                            metricsExpr += " NL ";
                        metricsExpr += cb;


                        //fpsMetricsCallback() NL gfxMetricsCallback() @ " "
                        }
                    }
                metricsExpr += " @ \" \"";
                }
            if (metricsExpr != "")
                {
                ((GuiCanvas) "Canvas").pushDialog("FrameOverlayGui", 1000);
                ((GuiConsoleTextCtrl) "TextOverlayControl").setValue(metricsExpr);
                }
            else
                {
                ((GuiCanvas) "Canvas").popDialog("FrameOverlayGui");
                }
            }
        }
    }