using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
    {
    public class Cursor
        {
        [ConsoleInteraction(true, "cursors_ed_cs_Initialize")]
        public static void initialize()
            {
            #region GuiCursor (EditorHandCursor)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiCursor", "EditorHandCursor");
            oc_Newobject1["hotSpot"] = "7 0";
            oc_Newobject1["bitmapName"] = "tools/worldEditor/images/CUR_hand.png";

            #endregion

            oc_Newobject1.Create();

            #region GuiCursor (EditorRotateCursor)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiCursor", "EditorRotateCursor");
            oc_Newobject2["hotSpot"] = "11 18";
            oc_Newobject2["bitmapName"] = "tools/worldEditor/images/CUR_rotate.png";

            #endregion

            oc_Newobject2.Create();

            #region GuiCursor (EditorMoveCursor)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiCursor", "EditorMoveCursor");
            oc_Newobject3["hotSpot"] = "9 13";
            oc_Newobject3["bitmapName"] = "tools/worldEditor/images/CUR_grab.png";

            #endregion

            oc_Newobject3.Create();

            #region GuiCursor (EditorArrowCursor)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiCursor", "EditorArrowCursor");
            oc_Newobject4["hotSpot"] = "0 0";
            oc_Newobject4["bitmapName"] = "tools/worldEditor/images/CUR_3darrow.png";

            #endregion

            oc_Newobject4.Create();

            #region GuiCursor (EditorUpDownCursor)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiCursor", "EditorUpDownCursor");
            oc_Newobject5["hotSpot"] = "5 10";
            oc_Newobject5["bitmapName"] = "tools/worldEditor/images/CUR_3dupdown";

            #endregion

            oc_Newobject5.Create();

            #region GuiCursor (EditorLeftRightCursor)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiCursor", "EditorLeftRightCursor");
            oc_Newobject6["hotSpot"] = "9 5";
            oc_Newobject6["bitmapName"] = "tools/worldEditor/images/CUR_3dleftright";

            #endregion

            oc_Newobject6.Create();

            #region GuiCursor (EditorDiagRightCursor)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiCursor", "EditorDiagRightCursor");
            oc_Newobject7["hotSpot"] = "8 8";
            oc_Newobject7["bitmapName"] = "tools/worldEditor/images/CUR_3ddiagright";

            #endregion

            oc_Newobject7.Create();

            #region GuiCursor (EditorDiagLeftCursor)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiCursor", "EditorDiagLeftCursor");
            oc_Newobject8["hotSpot"] = "8 8";
            oc_Newobject8["bitmapName"] = "tools/worldEditor/images/CUR_3ddiagleft";

            #endregion

            oc_Newobject8.Create();

            #region GuiControl (EmptyControl)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "EmptyControl");
            oc_Newobject9["profile"] = "ToolsGuiButtonProfile";

            #endregion

            oc_Newobject9.Create();
            }
        }
    }