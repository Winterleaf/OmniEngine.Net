using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui
    {
    public class MaterialProfiles
        {
        [ConsoleInteraction(true, "MaterialProfiles_initialize")]
        public static void initialize()
            {
            #region GuiControlProfile  (GuiMatEdSliderProfile)        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile ", "GuiMatEdSliderProfile");
            oc_Newobject1["bitmap"] = "./matEdSlider";
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();

            #region GuiControlProfile  (GuiMatEdRightJustifyProfile)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiControlProfile ", "GuiMatEdRightJustifyProfile");
            oc_Newobject2["fontType"] = "Arial";
            oc_Newobject2["fontSize"] = new ObjectCreator.StringNoQuote("14");
            oc_Newobject2["fontCharset"] = new ObjectCreator.StringNoQuote("ANSI");
            oc_Newobject2["fontColor"] = "0 0 0";
            oc_Newobject2["justify"] = "right";
            oc_Newobject2["category"] = "Editor";

            #endregion

            oc_Newobject2.Create();

            #region GuiControlProfile (GuiMatEdPopUpMenuProfile)        oc_Newobject3

            SingletonCreator oc_Newobject3 = new SingletonCreator("GuiControlProfile", "GuiMatEdPopUpMenuProfile");
            oc_Newobject3["opaque"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject3["mouseOverSelected"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject3["textOffset"] = "3 3";
            oc_Newobject3["border"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject3["fixedExtent"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject3["bitmap"] = "tools/editorClasses/gui/images/scroll";
            oc_Newobject3["hasBitmapArray"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject3["profileForChildren"] = new ObjectCreator.StringNoQuote("GuiControlListPopupProfile");
            oc_Newobject3["fillColor"] = "255 0 0 255";
            oc_Newobject3["fontColor"] = "255 255 255 255";
            oc_Newobject3["fillColorHL"] = "50 50 50";
            oc_Newobject3["fontColorHL"] = "220 220 220";
            oc_Newobject3["borderColor"] = "100 100 108";
            oc_Newobject3["category"] = "Editor";

            #endregion

            oc_Newobject3.Create();

            #region GuiControlProfile  (MatEdCenteredTextProfile)        oc_Newobject4

            SingletonCreator oc_Newobject4 = new SingletonCreator("GuiControlProfile ", "MatEdCenteredTextProfile");
            oc_Newobject4["fontColor"] = "0 0 0";
            oc_Newobject4["justify"] = "center";
            oc_Newobject4["category"] = "Editor";

            #endregion

            oc_Newobject4.Create();
            }
        }
    }