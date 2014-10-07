#region

using WinterLeaf.Demo.Full.Models.Base;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class GuiArrayCtrl : GuiArrayCtrl_Base
        {
        public override void onSelect(string x, string y)
            {
            this.callScript("onSelect", new string[] {x});
            }
        }
    }