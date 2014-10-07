#region

using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class TurretShape
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void damage(GameBase sourceobject, Point3F position, float damage, string damagetype)
            {
            ((TurretShapeData) (getDataBlock())).damage(this, position, sourceobject, damage, damagetype);
            }

        [ConsoleInteraction(true)]
        public static void sendMsgClientKilled_TurretDamage(string msgtype, GameConnection client,
            GameConnection sourceclient, string damloc)
            {
            if (sourceclient == 0)
                message.MessageAll(msgtype, "%1 was shot down by a turret!", client["playerName"] + ");");
            else if (sourceclient == client)
                message.MessageAll(msgtype, "%1 kill by his own turret!", client["playerName"] + ");");
            else
                message.MessageAll(msgtype, "%1 was killed by a turret of %2!", client["playerName"] + ");",
                    sourceclient["playerName"]);
            }
        }
    }