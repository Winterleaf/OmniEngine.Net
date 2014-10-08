#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class ShapeBaseImageData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public virtual void onFire(ShapeBase obj, int slot)
            {
            }

        [ConsoleInteraction(true)]
        public virtual void onAltFire(ShapeBase obj, int slot)
            {
            }

        [ConsoleInteraction(true)]
        public virtual void onWetFire(ShapeBase obj, int slot)
            {
            }
        }
    }