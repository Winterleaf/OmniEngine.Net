#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class AIPlayer
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public virtual int GetNearestPlayerTarget()
            {
            if (!isObject())
                return -1;

            if ((this["CurrentTarget"] != "") && (this["CurrentTarget"] != "-1"))
                {
                if (this["CurrentTarget"].isObject())
                    if (((Player) this["CurrentTarget"]).getState() != "Dead")
                        if (TargetIsInLos(this["CurrentTarget"]))
                            return this["CurrentTarget"].AsInt();

                this["CurrentTarget"] = "";
                }


            SimSet mobSearchGroup = this["aiteam"] == "1" ? "MobSearchGroup_2" : "MobSearchGroup_1";

            SimSet mobSearchGroupResult = "MobSearchGroupResult";
            if (!mobSearchGroupResult.isObject())
                mobSearchGroupResult = new ObjectCreator("SimSet", "MobSearchGroupResult").Create();

            AISearchSimSet(180, 50, mobSearchGroup, mobSearchGroupResult);


            int closesttarget = -1;
            float closestdist = 51;

            for (uint i = 0; i < mobSearchGroupResult.getCount(); i++)
                {
                Player target = mobSearchGroupResult.getObject(i);
                if (!target.isObject())
                    continue;
                if (target.getState() == "Dead")
                    continue;
                float dist = GetTargetDistance(target);
                if (dist >= closestdist)
                    continue;
                closestdist = dist;
                closesttarget = target;
                }
            mobSearchGroupResult.clear();

            this["CurrentTarget"] = closesttarget.AsString();

            return closesttarget;
            }

        public virtual float GetTargetDistance(Player target)
            {
            return Util.VectorDist(target.getPosition(), getWorldBoxCenter());
            }

        public virtual bool TargetIsInLos(Player target)
            {
            const uint mask =
                (uint) (SceneObjectTypesAsUint.StaticObjectType | SceneObjectTypesAsUint.TerrainObjectType);

            string collision = Util.containerRayCast(getEyePoint(), target.getEyePoint(), mask, this, true);
            if (collision == "0")
                return true;

            string hit = collision.Split(' ')[0];
            return hit == target.ID;
            }

        public virtual void AiPlayerAnimate(string seq)
            {
            setActionThread(seq, false, true);
            }
        }
    }