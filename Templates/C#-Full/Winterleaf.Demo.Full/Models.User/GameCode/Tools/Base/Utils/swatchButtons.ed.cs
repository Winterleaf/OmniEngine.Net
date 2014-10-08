using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class GuiSwatchButtonCtrl
        {
        // Common functionality for GuiSwatchButtonCtrls.
        //
        // Note that for the mouse-event related functionality, "useMouseEvents" must be set
        // to true.


        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public override void onMouseDragged()
            {
            GuiCanvas Canvas = "Canvas";

            GuiSwatchButtonCtrl payload = new ObjectCreator("GuiSwatchButtonCtrl").Create();
            payload.assignFieldsFrom(this);
            payload.position = "0 0 ".AsPoint2I();
            payload["dragSourceControl"] = this;

            int xOffset = payload.extent.x/2;
            int yOffset = payload.extent.y/2;
            Point2I cursorpos = Canvas.getCursorPos();
            int xPos = cursorpos.x - xOffset;
            int yPos = cursorpos.y - yOffset;

            // Create the drag control.

            ObjectCreator oc = new ObjectCreator("GuiDragAndDropControl");
            oc["canSaveDynamicFields"] = "0";
            oc["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc["HorizSizing"] = "right";
            oc["VertSizing"] = "bottom";
            oc["Position"] = xPos + ' ' + yPos;
            oc["extent"] = payload.extent;
            oc["MinExtent"] = "4 4";
            oc["canSave"] = "1";
            oc["Visible"] = "1";
            oc["hovertime"] = "1000";
            oc["deleteOnMouseUp"] = true;
            oc["class"] = "GuiDragAndDropControlType_ColorSwatch";

            GuiDragAndDropControl ctrl = oc.Create();

            ctrl.add(payload);

            // Start drag.

            ((SimSet) Canvas.getContent()).add(ctrl);
            ctrl.startDragging(xOffset, yOffset);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onControlDropped(GuiControl payload, string position)
            {
            if (!payload.parentGroup.isInNamespaceHierarchy("GuiDragAndDropControlType_ColorSwatch"))
                return;

            // If dropped on same button whence we came from,
            // do nothing.

            if (payload["dragSourceControl"] == this)
                return;

            // If a swatch button control is dropped onto this control,
            // copy it's color.

            if (payload.isMemberOfClass("GuiSwatchButtonCtrl"))
                {
                // If the swatch button is part of a color-type inspector field,
                // remember the inspector field so we can later set the color
                // through it.

                if (this.parentGroup.isMemberOfClass("GuiInspectorTypeColorI"))
                    ((GuiInspectorTypeColorI) this.parentGroup).apply(ColorPickerDlg.ColorFloatToInt(payload["color"]));
                else if (this.parentGroup.isMemberOfClass("GuiInspectorTypeColorF"))
                    ((GuiInspectorTypeColorF) this.parentGroup).apply(payload["color"]);
                else
                    this.setColor(payload["color"]);
                }
            }
        }
    }