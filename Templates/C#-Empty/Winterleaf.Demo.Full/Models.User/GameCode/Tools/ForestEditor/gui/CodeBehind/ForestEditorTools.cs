using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class ForestBrushTool
        {
        [ConsoleInteraction]
        public override void onActivated()
            {
            ForestEditToolbar ForestEditToolbar = "ForestEditToolbar";

            ForestEditToolbar.setVisible(true);
            this.syncBrushToolbar();
            }

        [ConsoleInteraction]
        public override void onDeactivated()
            {
            ForestEditToolbar ForestEditToolbar = "ForestEditToolbar";

            ForestEditToolbar.setVisible(false);
            }

        [ConsoleInteraction]
        public override void syncBrushToolbar()
            {
            ForestEditorGui.ForestBrushSizeSliderCtrlContainer ForestBrushSizeSliderCtrlContainer =
                "ForestBrushSizeSliderCtrlContainer";
            GuiControl ForestBrushSizeTextEditContainer = "ForestBrushSizeTextEditContainer";
            GuiControl ForestBrushPressureTextEditContainer = "ForestBrushPressureTextEditContainer";
            GuiControl ForestBrushHardnessTextEditContainer = "ForestBrushHardnessTextEditContainer";
            GuiMouseEventCtrl ForestBrushPressureSliderCtrlContainer = "ForestBrushPressureSliderCtrlContainer";
            GuiMouseEventCtrl ForestBrushHardnessSliderCtrlContainer = "ForestBrushHardnessSliderCtrlContainer";

            GuiSliderCtrl ForestBrushSizeSliderCtrlContainerslider = ForestBrushSizeSliderCtrlContainer.FOT("slider");
            GuiSliderCtrl ForestBrushPressureSliderCtrlContainerslider =
                ForestBrushPressureSliderCtrlContainer.FOT("slider");
            GuiSliderCtrl ForestBrushHardnessSliderCtrlContainerslider =
                ForestBrushHardnessSliderCtrlContainer.FOT("slider");
            GuiTextEditCtrl ForestBrushSizeTextEditContainertextEdit = ForestBrushSizeTextEditContainer.FOT("textEdit");
            GuiTextEditCtrl ForestBrushPressureTextEditContainertextEdit =
                ForestBrushPressureTextEditContainer.FOT("textEdit");
            GuiTextEditCtrl ForestBrushHardnessTextEditContainertextEdit =
                ForestBrushHardnessTextEditContainer.FOT("textEdit");

            string size = this["size"];
            ForestBrushSizeSliderCtrlContainerslider.setValue(size);
            ForestBrushSizeTextEditContainertextEdit.setValue(size);

            string pres = this["pressure"];
            ForestBrushPressureSliderCtrlContainerslider.setValue(pres);
            ForestBrushPressureTextEditContainertextEdit.setValue(Util.mCeil(100*pres.AsFloat()) + "%");

            string hard = this["hardness"];
            ForestBrushHardnessSliderCtrlContainerslider.setValue(hard);
            ForestBrushHardnessTextEditContainertextEdit.setValue(Util.mCeil(100*hard.AsFloat()) + "%");
            }

        [ConsoleInteraction]
        public override void onMouseDown()
            {
            ForestEditorGui.ForestEditTabBook ForestEditTabBook = "ForestEditTabBook";
            ForestEditTabBook.selectPage(0);
            }
        }


    public partial class ForestSelectionTool
        {
        [ConsoleInteraction]
        public void onActivated()
            {
            }

        [ConsoleInteraction]
        public void onDeactivated()
            {
            this.clearSelection();
            }
        }
    }