using Winterleaf.Demo.Full.Dedicated.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;


namespace Winterleaf.Demo.Full.Dedicated.Models.User.CustomObjects.Utilities
    {
    public class Audio
        {
        static public void AudioServerPlay2D(string profile)
            {
            foreach (GameConnection clientid in pInvokes.ClientGroup)
                clientid.play2D(profile);
            }



        static public void AudioServerPlay3D(string profile, TransformF transform)
            {
            foreach (GameConnection clientid in pInvokes.ClientGroup)
                clientid.play3D(profile, transform);
            }
        }
    }
