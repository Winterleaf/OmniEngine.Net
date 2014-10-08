#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class CameraData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public virtual void onTrigger(Camera obj, string trigger, bool state)
            {
            }

        [ConsoleInteraction(true)]
        public virtual void setMode(Camera camera, string mode, SceneObject arg1, string arg2, string arg3)
            {
            }
        }
    }