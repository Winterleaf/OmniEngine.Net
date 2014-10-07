#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    public partial class SimGroup
        {
        // This is on MissionGroup so it doesn't happen when the mission has ended
        [ConsoleInteraction(true)]
        public virtual SceneObject respawnTurret(SimDataBlock datablock, string classname, TransformF transform,
            string isstatic, string respawn)
            {
            ObjectCreator tch = new ObjectCreator(classname);
            tch["datablock"] = datablock;
            tch["static"] = isstatic;
            tch["respawn"] = respawn;

            SceneObject turret = tch.Create();

            turret.setTransform(transform);
            ((SimGroup) "MissionGroup").add(turret);
            return turret;
            }
        }
    }