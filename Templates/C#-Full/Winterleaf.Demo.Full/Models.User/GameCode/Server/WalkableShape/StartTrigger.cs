using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.WalkableShape
{

    [TypeConverter(typeof (TypeConverterGeneric<StartTrigger>))]
    internal class StartTrigger : TriggerData
    {
        public override void onEnterTrigger(Trigger trigger, GameBase obj)
        {
            if (obj["client"].isObject() && obj["client.welcomed"].AsBool())
                {
                message.MessageClient(obj["client"], "MsgItemPickup", "\\c1There\'s a platform in-front of you...Jump on.");
                obj["client.welcomed"] = "true";
                }
        }
    }
}