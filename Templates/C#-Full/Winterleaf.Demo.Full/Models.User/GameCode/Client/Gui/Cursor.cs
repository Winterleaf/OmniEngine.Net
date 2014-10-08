using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    public class cursor
        {
        public static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            if (omni.sGlobal["$platform"] == "macos")
                {
                ObjectCreator oc = new ObjectCreator("GuiCursor", "DefaultCursor");

                oc["hotSpot"] = "4 4";
                oc["renderOffset"] = "0 0";
                oc["bitmapName"] = "~/art/gui/images/macCursor";
                oc.Create();
                }
            else
                {
                ObjectCreator oc = new ObjectCreator("GuiCursor", "DefaultCursor");
                oc["hotSpot"] = "1 1";
                oc["renderOffset"] = "0 0";
                oc["bitmapName"] = "~/art/gui/images/defaultCursor";
                oc.Create();
                }
            }
        }
    }