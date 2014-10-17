#region

using Winterleaf.Demo.Full.Dedicated.Models.Base;

#endregion

namespace Winterleaf.Demo.Full.Dedicated.Models.User.Extendable
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