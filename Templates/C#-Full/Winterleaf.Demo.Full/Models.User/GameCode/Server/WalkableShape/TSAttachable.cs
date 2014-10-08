#region

using WinterLeaf.Demo.Full.Models.Base;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
{
    public partial class TSAttachable : TSAttachable_Base
    {
        public virtual bool hasHumanRider()
        {
            for (int i = 0; i < this.getNumAttachments(); i++)
                {
                SimObject remainingObj = this.getAttachment(i);
                if (remainingObj.isObject() && remainingObj["client"].isObject() && remainingObj["client.player"] == remainingObj)
                    return true;
                }
            return false;
        }
    }
}