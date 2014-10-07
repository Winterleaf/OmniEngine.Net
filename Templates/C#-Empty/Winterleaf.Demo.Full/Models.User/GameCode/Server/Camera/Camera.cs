#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class Camera
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        //This is puzzling... the C++ camera class does not have an onAdd event, only the datablock does.
        //So I'll define it as a new virtual just to be safe.
        [ConsoleInteraction(true)]
        public virtual void onAdd(GameBase obj)
            {
            this.setMode(this["mode"]);
            }

        [ConsoleInteraction(true)]
        public virtual void setMode(string mode, string arg1 = "", string arg2 = "", string arg3 = "")
            {
            CameraData datablock = this.getDataBlock();
            datablock.setMode(this, mode, arg1, arg2, arg3);
            }
        }
    }