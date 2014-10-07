using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;


namespace WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities
    {
    public class Audio
        {
        public static pInvokes tst = new pInvokes();

        static public void AudioServerPlay2D(string profile)
            {
            foreach (GameConnection clientid in tst.ClientGroup)
                clientid.play2D(profile);
            }



        static public void AudioServerPlay3D(string profile, TransformF transform)
            {
            foreach (GameConnection clientid in tst.ClientGroup)
                clientid.play3D(profile, transform);
            }
        }
    }
