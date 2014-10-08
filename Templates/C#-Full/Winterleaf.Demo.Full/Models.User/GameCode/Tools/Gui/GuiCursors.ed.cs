using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui
    {
    public class GuiCursors
        {
        [ConsoleInteraction(true, "GuiCursors_initialize")]
        public static void initialize()
            {
            #region GuiCursor (LeftRightCursor)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiCursor", "LeftRightCursor");
            oc_Newobject1["hotSpot"] = "0.5 0";
            oc_Newobject1["renderOffset"] = "0.5 0";
            oc_Newobject1["bitmapName"] = "tools/gui/images/leftRight";

            #endregion

            oc_Newobject1.Create();

            #region GuiCursor (UpDownCursor)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiCursor", "UpDownCursor");
            oc_Newobject2["hotSpot"] = "1 1";
            oc_Newobject2["renderOffset"] = "0 1";
            oc_Newobject2["bitmapName"] = "tools/gui/images/upDown";

            #endregion

            oc_Newobject2.Create();

            #region GuiCursor (NWSECursor)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiCursor", "NWSECursor");
            oc_Newobject3["hotSpot"] = "1 1";
            oc_Newobject3["renderOffset"] = "0.5 0.5";
            oc_Newobject3["bitmapName"] = "tools/gui/images/NWSE";

            #endregion

            oc_Newobject3.Create();

            #region GuiCursor (NESWCursor)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiCursor", "NESWCursor");
            oc_Newobject4["hotSpot"] = "1 1";
            oc_Newobject4["renderOffset"] = "0.5 0.5";
            oc_Newobject4["bitmapName"] = "tools/gui/images/NESW";

            #endregion

            oc_Newobject4.Create();

            #region GuiCursor (MoveCursor)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiCursor", "MoveCursor");
            oc_Newobject5["hotSpot"] = "1 1";
            oc_Newobject5["renderOffset"] = "0.5 0.5";
            oc_Newobject5["bitmapName"] = "tools/gui/images/move";

            #endregion

            oc_Newobject5.Create();

            #region GuiCursor (TextEditCursor)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiCursor", "TextEditCursor");
            oc_Newobject6["hotSpot"] = "1 1";
            oc_Newobject6["renderOffset"] = "0.5 0.5";
            oc_Newobject6["bitmapName"] = "tools/gui/images/textEdit";

            #endregion

            oc_Newobject6.Create();
            }
        }
    }