using System;
using System.Collections.Generic;
using Winterleaf.Demo.Full.Dedicated.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using WinterLeaf.Engine.Classes.Interopt;

namespace Winterleaf.Demo.Full.Dedicated.Models.User.CustomObjects.Utilities
    {
    class radiusDamage
        {
        private static pInvokes tst = new pInvokes();

        public static void RadiusDamage(GameBase sourceobject, Point3F position, float radius, float damage, string damageType, float impulse)
            {
            // Use the container system to iterate through all the objects
            // within our explosion radius.  We'll apply damage to all ShapeBase
            // objects.
            Dictionary<uint, float> r = tst.console.initContainerRadiusSearch(position, radius, (uint)SceneObjectTypesAsUint.ShapeBaseObjectType);
            float halfRadius = radius / (float)2.0;
            foreach (ShapeBase targetObject in r.Keys)
                {
                // Calculate how much exposure the current object has to
                // the explosive force.  The object types listed are objects
                // that will block an explosion.  If the object is totally blocked,
                // then no damage is applied.

                UInt32 mask = (uint)SceneObjectTypesAsUint.TerrainObjectType | (uint)SceneObjectTypesAsUint.StaticShapeObjectType | (uint)SceneObjectTypesAsUint.VehicleObjectType ;

                float coverage = tst.Util.calcExplosionCoverage(new Point3F(position), targetObject, mask);
                if (!coverage.AsBool())
                    continue;
                float dist = r[targetObject];
                // Calculate a distance scale for the damage and the impulse.
                // Full damage is applied to anything less than half the radius away,
                // linear scale from there.
                float distScale = (float)((dist < halfRadius) ? 1.0 : 1 - ((dist - halfRadius) / halfRadius));
                // Apply the damage

                targetObject.damage(sourceobject, position, (((damage) * coverage * distScale)), damageType);

                // Apply the impulse
                if (!impulse.AsBool())
                    continue;
                TransformF impulseVec = new TransformF(targetObject.getWorldBoxCenter()) - new TransformF(position);
                impulseVec = impulseVec.normalizeSafe();
                impulseVec = impulseVec.vectorScale(impulse * distScale);
                targetObject.applyImpulse(new Point3F(position), impulseVec.GetPosition());
                }
            }
        }
    }
