#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    public partial class ActionMap
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public void copyBind(ActionMap otherMap, string command)
            {
            if (otherMap.isObject())
                {
                Util._error("ActionMap::copyBind - \"" + otherMap + "\" is not an object!");
                return;
                }
            string bind = otherMap.getBinding(command);
            if (bind == "")
                return;
            string device = Util.getField(bind, 0);
            string action = Util.getField(bind, 1);
            string flags = otherMap.isInverted(device, action) ? "SDI" : "SD";
            string deadzone = otherMap.getDeadZone(device, action);
            float scale = otherMap.getScale(device, action);
            this.bind(device, action, flags, deadzone, scale.AsString(), command);
            }

        [ConsoleInteraction(true)]
        public void blockBind(ActionMap othermap, string command)
            {
            if (othermap.isObject())
                {
                Util._error("ActionMap::blockBind - \"" + othermap + "\" is not an object!");
                return;
                }
            string bind = othermap.getBinding(command);

            if (bind != "")
                this.bind(Util.getField(bind, 0), Util.getField(bind, 1), "");
            }
        }
    }