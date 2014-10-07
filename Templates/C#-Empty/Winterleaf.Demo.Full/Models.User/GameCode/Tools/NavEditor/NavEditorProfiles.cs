using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor
{
    public class NavEditorProfiles
    {
        public static void initialize()
        {
            SingletonCreator oc_Newobject00002;
            SingletonCreator oc_Newobject00001;
            if (true)
            {

                #region GuiControlProfile (NavEditorProfile)        oc_Newobject00001

                oc_Newobject00001 = new SingletonCreator("GuiControlProfile", "NavEditorProfile");
                oc_Newobject00001["canKeyFocus"] = new ObjectCreator.StringNoQuote("true");
                oc_Newobject00001["opaque"] = new ObjectCreator.StringNoQuote("true");
                oc_Newobject00001["fillColor"] = "192 192 192 192";
                oc_Newobject00001["category"] = "Editor";

                #endregion

                oc_Newobject00001.Create();

                #region GuiControlProfile (GuiSimpleBorderProfile)        oc_Newobject00002

                oc_Newobject00002 = new SingletonCreator("GuiControlProfile", "GuiSimpleBorderProfile");
                oc_Newobject00002["opaque"] = new ObjectCreator.StringNoQuote("false");
                oc_Newobject00002["border"] = new ObjectCreator.StringNoQuote("1");
                oc_Newobject00002["category"] = "Editor";

                #endregion

                oc_Newobject00002.Create();
            }
        }
    }
}
