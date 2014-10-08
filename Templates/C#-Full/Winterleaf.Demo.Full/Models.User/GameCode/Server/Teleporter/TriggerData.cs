namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class TriggerData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onEnterTrigger(Trigger trigger, GameBase obj)
            {
            // This method is called whenever an object enters the %trigger
            // area, the object is passed as %obj.
            base.onEnterTrigger(trigger, obj);
            }

        public override void onLeaveTrigger(Trigger trigger, GameBase obj)
            {
            // This method is called whenever an object leaves the %trigger
            // area, the object is passed as %obj.
            base.onLeaveTrigger(trigger, obj);
            }

        public override void onTickTrigger(Trigger trigger)
            {
            // This method is called every tickPerioMS, as long as any
            // objects intersect the trigger.

            // You can iterate through the objects in the list by using these
            // methods:
            //    %trigger.getNumObjects();
            //    %trigger.getObject(n);
            base.onTickTrigger(trigger);
            }
        }
    }