using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui
    {
    public class ShapeEdPreviewWindow
        {
        [ConsoleInteraction(true, "ShapeEdPreviewWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "1024 768";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";

            #region GuiContainer (ShapeEdPreviewGui)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiContainer", "ShapeEdPreviewGui",
                typeof (CodeBehind.ShapeEditor.ShapeEdPreviewGui));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "height";
            oc_Newobject3["Position"] =
                new ObjectCreator.StringNoQuote("\"0\" SPC (getWord(EditorGuiToolbar.extent, 1)-1)");
            oc_Newobject3["Docking"] = "Client";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";

            #region GuiSwatchButtonCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject1["internalName"] = "previewBackground";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "height";
            oc_Newobject1["Position"] = "-210 -40";
            oc_Newobject1["Extent"] =
                new ObjectCreator.StringNoQuote(
                    "getWord(ShapeEdPreviewGui.extent,0)+212            SPC  getWord(ShapeEdPreviewGui.extent,0)+42");
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["color"] = "0 0 0 .39";

            #endregion

            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            #region GuiShapeEdPreview (ShapeEdShapeView)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiShapeEdPreview", "ShapeEdShapeView",
                typeof (CodeBehind.ShapeEditor.ShapeEdShapeView));
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["Position"] = "-209 -90";
            oc_Newobject2["Extent"] =
                new ObjectCreator.StringNoQuote(
                    "getWord(ShapeEdPreviewGui.extent,0)+209            SPC getWord(ShapeEdPreviewGui.extent, 1)+90");
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["renderMissionArea"] = "0";
            oc_Newobject2["GizmoProfile"] = "GlobalGizmoProfile";
            oc_Newobject2["cameraZRot"] = "0";
            oc_Newobject2["forceFOV"] = "0";
            oc_Newobject2["gridColor"] = "0 0 0 140";
            oc_Newobject2["renderNodes"] = "0";
            oc_Newobject2["renderObjBox"] = "0";
            oc_Newobject2["renderMounts"] = "0";
            oc_Newobject2["renderColMeshes"] = "0";
            oc_Newobject2["selectedNode"] = "-1";
            oc_Newobject2["sunDiffuse"] = "255 255 255 255";
            oc_Newobject2["sunAmbient"] = "180 180 180 255";
            oc_Newobject2["timeScale"] = "1.0";
            oc_Newobject2["fixedDetail"] = "0";
            oc_Newobject2["orbitNode"] = "0";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject4.Create();
            }
        }
    }