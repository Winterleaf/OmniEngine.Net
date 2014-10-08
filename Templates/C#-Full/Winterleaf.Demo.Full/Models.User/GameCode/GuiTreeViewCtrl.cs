#region

using WinterLeaf.Demo.Full.Models.Base;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class GuiTreeViewCtrl : GuiTreeViewCtrl_Base
        {
        //These are needed to make the tools work right.
        public override void onClick(string SelectedidString)
            {
            this.callScript("onClick", new string[] {SelectedidString});
            }

        public override void onAddSelection(int itemOrObjectId, bool isLastSelection)
            {
            this.callScript("onAddSelection", new string[] {itemOrObjectId.AsString(), isLastSelection.AsString()});
            }

        public override void onRemoveSelection(int itemOrObjectId)
            {
            this.callScript("onRemoveSelection", new string[] {itemOrObjectId.AsString()});
            }
        }
    }