#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class ShapeBaseData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public virtual void damage(ShapeBase obj, Point3F position, GameBase source, float damage,
            string damagetype)
            {
            // Ignore damage by default. This empty method is here to
            // avoid console warnings.
            }

        [ConsoleInteraction(true)]
        public virtual bool onUse(ShapeBase user)
            {
            //// Invoked when the object uses this datablock, should return
            //// true if the item was used.

            return false;
            }

        [ConsoleInteraction(true)]
        public virtual int onThrow(ShapeBase user, int amount)
            {
            // Invoked when the object is thrown.  This method should
            // construct and return the actual mission object to be
            // physically thrown.  This method is also responsible for
            // decrementing the user's inventory.
            return 0;
            }

        [ConsoleInteraction(true)]
        public virtual bool onPickup(Item obj, ShapeBase user, int amount)
            {
            // Invoked when the user attempts to pickup this datablock object.
            // The %amount argument is the space in the user's inventory for
            // this type of datablock.  This method is responsible for
            // incrementing the user's inventory is something is addded.
            // Should return true if something was added to the inventory.
            return false;
            }

        [ConsoleInteraction(true)]
        public virtual void onInventory(ShapeBase user, int value)
            {
            }
        }
    }