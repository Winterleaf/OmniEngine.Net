#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class ProjectileData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onCollision(Projectile proj, SceneObject col, float fade, Point3F pos, Point3F normal)
            {
            // Apply damage to the object all shape base objects
            if (this["directDamage"].AsFloat() > 0)
                if ((console.getTypeMask(col) & (uint) SceneObjectTypesAsUint.ShapeBaseObjectType) ==
                    (uint) SceneObjectTypesAsUint.ShapeBaseObjectType)
                    {
                    ShapeBase shapebase = col._ID;
                    shapebase.damage(proj, pos, this["directDamage"].AsFloat(), this["damageType"]);
                    }
            }

        public override void onExplode(Projectile proj, Point3F pos, float fade)
            {
            // Damage objects within the projectiles damage radius
            float radius = this["damageRadius"].AsFloat();
            if (radius <= 0)
                return;
            string damageType = this["damageType"];
            float areaImpulse = this["areaImpulse"].AsFloat();
            float radiusDamage = this["radiusDamage"].AsFloat();
            CustomObjects.Utilities.radiusDamage.RadiusDamage(proj, pos, radius, radiusDamage, damageType, areaImpulse);
            }
        }
    }