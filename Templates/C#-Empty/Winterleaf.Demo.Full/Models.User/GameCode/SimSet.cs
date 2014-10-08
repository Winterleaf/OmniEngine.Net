#region

using WinterLeaf.Demo.Full.Models.Base;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class SimSet : SimSet_Base
        {
        //internal override void onObjectAdded(SimObject xobject)
        //{

        //}

        //internal override void onObjectRemoved(SimObject xobject)
        //{

        //}
        //internal  string findObjectByInternalName(string internalName, bool searchChildren){
        public string FOT(string internalName)
            {
            return findObjectByInternalName(internalName, true);
            }

        public string FOF(string internalName)
            {
            return findObjectByInternalName(internalName, false);
            }
        }
    }