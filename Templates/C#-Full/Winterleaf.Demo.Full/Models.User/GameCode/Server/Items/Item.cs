#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class Item
        {
        internal int ItemPopTime = 10*1000;
        internal int ItemRespawnTime = 60*1000;

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public void SchedulePop()
            {
            // This method deletes the object after a default duration. Dynamic
            // items such as thrown or drop weapons are usually popped to avoid
            // world clutter.

            schedule((ItemPopTime - 1000).AsString(), "startFade", "1000", "0", "true");
            schedule(ItemPopTime.AsString(), "delete");
            }

        [ConsoleInteraction(true)]
        public void Respawn()
            {
            // This method is used to respawn static ammo and weapon items
            // and is usually called when the item is picked up.
            // Instant fade...
            startFade(0, 0, true);
            setHidden(true);

            schedule(ItemRespawnTime.AsString(), "setHidden", "false");
            schedule((ItemRespawnTime + 100).AsString(), "startFade", "1000", "0", "false");
            }
        }
    }