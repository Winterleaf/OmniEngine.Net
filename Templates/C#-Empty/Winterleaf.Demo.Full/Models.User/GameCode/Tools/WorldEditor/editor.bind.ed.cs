using System;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
    {
    public class editor_bind_ed
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true, "editor_bind_ed_cs_initialize")]
        public static void initialize()
            {
            new ObjectCreator("ActionMap", "EditorMap").Create();

            ActionMap EditorMap = "EditorMap";

            EditorMap.bind("mouse", "xaxis", "editorYaw");
            EditorMap.bind("mouse", "yaxis", "editorPitch");
            EditorMap.bind("mouse", "zaxis", "mouseWheelScroll");

            EditorMap.bind("mouse", "alt zaxis", "editorWheelFadeScroll");
            }

        [ConsoleInteraction]
        public static void mouseWheelScroll(float val)
            {
            //$Camera::speedCurveTime += $Camera::scrollStepSize * ( (%val>0.0) ? 1 : -1 );
            //$Camera::speedCurveTime = mClamp( $Camera::speedCurveTime, 0.0, 1.0 );
            //calculateCameraSpeed();   
            //EditorGui-->CameraSpeedSpinner.setText( $Camera::movementSpeed );

            float rollAdj = defaultBind.getMouseAdjustAmount(val);
            rollAdj = omni.Util.mClamp(rollAdj, (float) (-Math.PI + 0.01), (float) (Math.PI - 0.01));
            omni.fGlobal["$mvRoll"] += rollAdj;
            }

        [ConsoleInteraction]
        public static void editorYaw(float val)
            {
            float yawAdj = defaultBind.getMouseAdjustAmount(val);
            if (((GameConnection) "ServerConnection").isControlObjectRotDampedCamera() ||
                ((EWorldEditor) "EWorldEditor").isMiddleMouseDown())
                {
                // Clamp and scale
                yawAdj = omni.Util.mClamp(yawAdj, ((float) (-2.0f*Math.PI) + 0.01f), ((float) (2.0f*Math.PI) - 0.01f));
                yawAdj *= 0.5f;
                }

            if (((SimObject) "EditorSettings")["Camera/invertXAxis"].AsBool())
                yawAdj *= -1;

            omni.fGlobal["$mvYaw"] += yawAdj;
            }

        [ConsoleInteraction]
        public static void editorPitch(float val)
            {
            float pitchAdj = defaultBind.getMouseAdjustAmount(val);
            if (((GameConnection) "ServerConnection").isControlObjectRotDampedCamera() ||
                ((EWorldEditor) "EWorldEditor").isMiddleMouseDown())
                {
                pitchAdj = omni.Util.mClamp(pitchAdj, ((float) (-2.0f*Math.PI) + 0.01f), ((float) (2.0f*Math.PI) - 0.01f));
                pitchAdj *= 0.5f;
                }
            if (((SimObject) "EditorSettings")["Camera/invertYAxis"].AsBool())
                pitchAdj *= -1;

            omni.fGlobal["$mvPitch"] += pitchAdj;
            }

        [ConsoleInteraction]
        public static void editorWheelFadeScroll(float val)
            {
            EWorldEditor EWorldEditor = "EWorldEditor";
            EWorldEditor.fadeIconsDist += val * 0.1f;
            if (EWorldEditor.fadeIconsDist < 0)
                EWorldEditor.fadeIconsDist = 0;
            }
        }
    }