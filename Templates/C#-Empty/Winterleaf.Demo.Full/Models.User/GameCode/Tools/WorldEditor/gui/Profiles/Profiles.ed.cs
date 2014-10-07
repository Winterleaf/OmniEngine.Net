using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.Profiles
    {
    public class Profiles
        {
        [ConsoleInteraction(true, "WorldEditor_Profiles_initialize")]
        public static void initialize()
            {
            #region GuiControlProfile  (EditorDefaultProfile)        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile ", "EditorDefaultProfile");
            oc_Newobject1["opaque"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();

            #region GuiControlProfile  (EditorToolButtonProfile)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiControlProfile ", "EditorToolButtonProfile");
            oc_Newobject2["opaque"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject2["border"] = new ObjectCreator.StringNoQuote("2");
            oc_Newobject2["category"] = "Editor";

            #endregion

            oc_Newobject2.Create();

            #region GuiControlProfile  (EditorTextProfile)        oc_Newobject3

            SingletonCreator oc_Newobject3 = new SingletonCreator("GuiControlProfile ", "EditorTextProfile");
            oc_Newobject3["fontType"] = "Arial Bold";
            oc_Newobject3["fontColor"] = "196 196 196 255";
            oc_Newobject3["autoSizeWidth"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject3["autoSizeHeight"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject3["category"] = "Editor";

            #endregion

            oc_Newobject3.Create();

            #region GuiControlProfile  (EditorTextProfileWhite)        oc_Newobject4

            SingletonCreator oc_Newobject4 = new SingletonCreator("GuiControlProfile ", "EditorTextProfileWhite");
            oc_Newobject4["fontType"] = "Arial Bold";
            oc_Newobject4["fontColor"] = "255 255 255";
            oc_Newobject4["autoSizeWidth"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject4["autoSizeHeight"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject4["category"] = "Editor";

            #endregion

            oc_Newobject4.Create();

            #region GuiControlProfile  (WorldEditorProfile)        oc_Newobject5

            SingletonCreator oc_Newobject5 = new SingletonCreator("GuiControlProfile ", "WorldEditorProfile");
            oc_Newobject5["canKeyFocus"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject5["category"] = "Editor";

            #endregion

            oc_Newobject5.Create();

            #region GuiControlProfile  (EditorScrollProfile)        oc_Newobject6

            SingletonCreator oc_Newobject6 = new SingletonCreator("GuiControlProfile ", "EditorScrollProfile");
            oc_Newobject6["opaque"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject6["fillColor"] = "192 192 192 192";
            oc_Newobject6["border"] = new ObjectCreator.StringNoQuote("3");
            oc_Newobject6["borderThickness"] = new ObjectCreator.StringNoQuote("2");
            oc_Newobject6["borderColor"] = "0 0 0";
            oc_Newobject6["bitmap"] = "tools/gui/images/scrollBar";
            oc_Newobject6["hasBitmapArray"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject6["category"] = "Editor";

            #endregion

            oc_Newobject6.Create();

            #region GuiControlProfile  (GuiEditorClassProfile)        oc_Newobject7

            SingletonCreator oc_Newobject7 = new SingletonCreator("GuiControlProfile ", "GuiEditorClassProfile");
            oc_Newobject7["opaque"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject7["fillColor"] = "232 232 232";
            oc_Newobject7["border"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject7["borderColor"] = "0 0 0";
            oc_Newobject7["borderColorHL"] = "127 127 127";
            oc_Newobject7["fontColor"] = "0 0 0";
            oc_Newobject7["fontColorHL"] = "50 50 50";
            oc_Newobject7["fixedExtent"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject7["justify"] = "center";
            oc_Newobject7["bitmap"] = "tools/gui/images/scrollBar";
            oc_Newobject7["hasBitmapArray"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject7["category"] = "Editor";

            #endregion

            oc_Newobject7.Create();

            #region GuiControlProfile ( EPainterBitmapProfile )        oc_Newobject8

            SingletonCreator oc_Newobject8 = new SingletonCreator("GuiControlProfile", "EPainterBitmapProfile");
            oc_Newobject8["opaque"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject8["border"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject8["borderColor"] = "243 242 241";
            oc_Newobject8["Color"] = "230 230 230";
            oc_Newobject8["category"] = "Editor";

            #endregion

            oc_Newobject8.Create();

            #region GuiControlProfile ( EPainterBorderButtonProfile : ToolsGuiDefaultProfile )        oc_Newobject9

            SingletonCreator oc_Newobject9 = new SingletonCreator("GuiControlProfile",
                " EPainterBorderButtonProfile : ToolsGuiDefaultProfile ");
            oc_Newobject9["border"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject9["borderColor"] = "0 0 0";
            oc_Newobject9["borderThickness"] = new ObjectCreator.StringNoQuote("2");
            oc_Newobject9["fontColorHL"] = "255 0 0";
            oc_Newobject9["fontColorSEL"] = "0 0 255";
            oc_Newobject9["category"] = "Editor";

            #endregion

            oc_Newobject9.Create();

            #region GuiControlProfile ( EPainterDragDropProfile )        oc_Newobject10

            SingletonCreator oc_Newobject10 = new SingletonCreator("GuiControlProfile", "EPainterDragDropProfile");
            oc_Newobject10["justify"] = "center";
            oc_Newobject10["fontColor"] = "0 0 0";
            oc_Newobject10["border"] = new ObjectCreator.StringNoQuote("0");
            oc_Newobject10["textOffset"] = "0 0";
            oc_Newobject10["opaque"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject10["fillColor"] = "221 221 221 150";
            oc_Newobject10["category"] = "Editor";

            #endregion

            oc_Newobject10.Create();

            #region GizmoProfile ( GlobalGizmoProfile )        oc_Newobject11

            SingletonCreator oc_Newobject11 = new SingletonCreator("GizmoProfile", "GlobalGizmoProfile");
            oc_Newobject11["screenLength"] = new ObjectCreator.StringNoQuote("100");
            oc_Newobject11["category"] = "Editor";

            #endregion

            oc_Newobject11.Create();
            }
        }
    }