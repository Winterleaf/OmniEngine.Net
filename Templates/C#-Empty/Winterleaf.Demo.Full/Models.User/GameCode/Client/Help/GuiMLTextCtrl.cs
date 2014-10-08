#region

using WinterLeaf.Demo.Full.Models.Base;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class GuiMLTextCtrl : GuiMLTextCtrl_Base
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onURL(string url)
            {
            Util.gotoWebPage(url);
            }
        }
    }