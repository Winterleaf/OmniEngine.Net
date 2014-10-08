using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<EditorLoadingGui>))]
    public class EditorLoadingGui : GuiControl
        {
        [ConsoleInteraction(true, "EditorLoadingGui_initialize")]
        public static void initialize()
            {
            #region GuiControl (EditorLoadingGui, EditorGuiGroup)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "EditorLoadingGui, EditorGuiGroup",
                typeof (EditorLoadingGui));
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "GuiOverlayProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "0 0";
            oc_Newobject3["Extent"] = "800 600";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "1";

            #region GuiControl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiControl", "");
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "editorMenu_wBorderProfile";
            oc_Newobject2["HorizSizing"] = "center";
            oc_Newobject2["VertSizing"] = "center";
            oc_Newobject2["position"] = "277 271";
            oc_Newobject2["Extent"] = "245 57";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["internalName"] = "Dialog";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Loading the World Editor...";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTextBoldCenterProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "center";
            oc_Newobject1["position"] = "5 19";
            oc_Newobject1["Extent"] = "236 18";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject3.Create();
            }

        [ConsoleInteraction]
        public override void onWake()
            {
            string res = this.getExtent().AsString();
            string resX = Util.getWord(res, 0);
            string resY = Util.getWord(res, 1);

            GuiControl dialog = this.FOT("Dialog");
            string dialogExtent = dialog.getExtent().AsString();
            string dialogWidth = Util.getWord(dialogExtent, 0);
            string dialogHeight = Util.getWord(dialogExtent, 1);
            string dialogPosition = dialog.getPosition().AsString();

            int posX = ((resX.AsInt()/2) - (dialogWidth.AsInt()/2));
            int posY = ((resY.AsInt()/2) - (dialogHeight.AsInt()/2));
            dialog.setPosition(posX, posY);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorLoadingGui ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return base.GetHashCode();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(EditorLoadingGui ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(EditorLoadingGui ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorLoadingGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorLoadingGui) Omni.self.getSimObject(simobjectid, typeof (EditorLoadingGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorLoadingGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorLoadingGui(int simobjectid)
            {
            return (EditorLoadingGui) Omni.self.getSimObject((uint) simobjectid, typeof (EditorLoadingGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorLoadingGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorLoadingGui(uint simobjectid)
            {
            return (EditorLoadingGui) Omni.self.getSimObject(simobjectid, typeof (EditorLoadingGui));
            }

        #endregion
        }
    }