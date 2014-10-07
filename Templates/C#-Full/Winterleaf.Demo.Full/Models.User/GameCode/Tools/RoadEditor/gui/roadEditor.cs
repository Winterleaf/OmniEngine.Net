using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui
    {
    public class roadEditor
        {
        [ConsoleInteraction(true, "RoadEditor_initialize")]
        public static void initialize()
            {
            #region GuiControlProfile ( RoadEditorProfile )        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile", "RoadEditorProfile");
            oc_Newobject1["canKeyFocus"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["opaque"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["fillColor"] = "192 192 192 192";
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();

            #region GuiControlProfile  (GuiSimpleBorderProfile)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiControlProfile ", "GuiSimpleBorderProfile");
            oc_Newobject2["opaque"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject2["border"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["category"] = "Editor";

            #endregion

            oc_Newobject2.Create();

            #region GuiCursor (RoadEditorMoveCursor)        oc_Newobject3

            SingletonCreator oc_Newobject3 = new SingletonCreator("GuiCursor", "RoadEditorMoveCursor");
            oc_Newobject3["hotSpot"] = "4 4";
            oc_Newobject3["renderOffset"] = "0 0";
            oc_Newobject3["bitmapName"] = "~/gui/images/macCursor";
            oc_Newobject3["category"] = "Editor";

            #endregion

            oc_Newobject3.Create();

            #region GuiCursor ( RoadEditorMoveNodeCursor )        oc_Newobject4

            SingletonCreator oc_Newobject4 = new SingletonCreator("GuiCursor", "RoadEditorMoveNodeCursor");
            oc_Newobject4["hotSpot"] = "1 1";
            oc_Newobject4["renderOffset"] = "0 0";
            oc_Newobject4["bitmapName"] = "./Cursors/outline/drag_node_outline";
            oc_Newobject4["category"] = "Editor";

            #endregion

            oc_Newobject4.Create();

            #region GuiCursor ( RoadEditorAddNodeCursor )        oc_Newobject5

            SingletonCreator oc_Newobject5 = new SingletonCreator("GuiCursor", "RoadEditorAddNodeCursor");
            oc_Newobject5["hotSpot"] = "1 1";
            oc_Newobject5["renderOffset"] = "0 0";
            oc_Newobject5["bitmapName"] = "./Cursors/outline/add_to_end_outline";
            oc_Newobject5["category"] = "Editor";

            #endregion

            oc_Newobject5.Create();

            #region GuiCursor ( RoadEditorInsertNodeCursor )        oc_Newobject6

            SingletonCreator oc_Newobject6 = new SingletonCreator("GuiCursor", "RoadEditorInsertNodeCursor");
            oc_Newobject6["hotSpot"] = "1 1";
            oc_Newobject6["renderOffset"] = "0 0";
            oc_Newobject6["bitmapName"] = "./Cursors/outline/insert_in_middle_outline";
            oc_Newobject6["category"] = "Editor";

            #endregion

            oc_Newobject6.Create();

            #region GuiCursor ( RoadEditorResizeNodeCursor )        oc_Newobject7

            SingletonCreator oc_Newobject7 = new SingletonCreator("GuiCursor", "RoadEditorResizeNodeCursor");
            oc_Newobject7["hotSpot"] = "1 1";
            oc_Newobject7["renderOffset"] = "0 0";
            oc_Newobject7["bitmapName"] = "./Cursors/outline/widen_path_outline";
            oc_Newobject7["category"] = "Editor";

            #endregion

            oc_Newobject7.Create();
            }
        }
    }