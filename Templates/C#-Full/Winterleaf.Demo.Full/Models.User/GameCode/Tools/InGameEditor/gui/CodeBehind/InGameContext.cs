using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.InGameEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<InGameContext>))]
    public class InGameContext : GuiControl
        {
        [ConsoleInteraction]
        public override void onAdd()
            {
            string filename = sGlobal["$appName"];
            sGlobal["$XMLOutput"] = Util.strreplace(filename, " ", "") + "_XML";
            }

        [ConsoleInteraction]
        public override void onRightMouseUp(GuiControl ctrl)
            {
            int fontColorPos,
                backgroundColorPos,
                fillColorPos,
                fontSizePos,
                lockPos,
                winSettingsPos,
                setTitlePos,
                bitmapPos;
            GuiCanvas Canvas = "Canvas";

            ObjectCreator popupCreator = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));

            popupCreator["isPopup"] = true.AsString();

            popupCreator["object"] = "-1";

            MenuBuilder popup = popupCreator.Create();

            popup.removeAllItems();
            popup["object"] = ctrl;

            if (ctrl.getName() != "")
                popup.appendItem(ctrl.getName() + '\t' + "" + '\t' + "");
            else
                popup.appendItem(ctrl.getClassName() + '\t' + "" + '\t' + "");

            popup.enableItem(0, false);

            if (ctrl.lockControl)
                {
                lockPos =
                    popup.appendItem("Locked" + '\t' + "" + '\t' + ctrl + ".setControlLock(!" + ctrl +
                                     ".getControlLock());");
                popup.checkItem(lockPos, ctrl.getControlLock());
                }

            if (ctrl.contextFontColor)
                fontColorPos =
                    popup.appendItem("Font Color..." + '\t' + "" + '\t' + "getColorI(\"" +
                                     ctrl.controlFontColor.AsString() + "\", \"" + ctrl + ".setControlFontColor\", " +
                                     ctrl.getRoot() + ", \"" + ctrl + ".setControlFontColor\", \"" + ctrl +
                                     ".setControlFontColor\" );");

            if (ctrl.contextBackColor)
                backgroundColorPos =
                    popup.appendItem("Background Color..." + '\t' + "" + '\t' + "IngameContext.transparentCheck(" + ctrl +
                                     ", \"backColor\");");

            if (ctrl.contextFillColor)
                fillColorPos =
                    popup.appendItem("Fill Color..." + '\t' + "" + '\t' + "IngameContext.transparentCheck(" + ctrl +
                                     ", \"fillColor\");");

            if (ctrl.contextFontSize)
                fontSizePos =
                    popup.appendItem("Font Size..." + '\t' + "" + '\t' + "ChangeFontSize.loadDialog(" + ctrl + ");");

            if (ctrl.windowSettings)
                winSettingsPos =
                    popup.appendItem("Window Settings" + '\t' + "" + '\t' + "WindowSettings.loadDialog(" + ctrl + ");");

            if (ctrl.isMemberOfClass("GuiBitmapCtrl"))
                {
                if (((GuiControl) popup["object"])["setBitmap"].AsBool())
                    bitmapPos =
                        popup.appendItem("Set Bitmap..." + '\t' + "" + '\t' +
                                         "getLoadFilename( \"All Image Files|*.png;*.jpeg;*.jpg;*.tga;*.jng;*.mng;*.gif;*.bmp;*.dds|png|*.png|jpeg|*.jpeg|jpg|*.jpg|tga|*.tga|jng|*.jng|mng|*.mng|gif|*.gif|bmp|*.bmp|dds|*.dds\"," +
                                         ctrl + "\".setBitmap\", \"\" );");
                }

            if (ctrl.isMemberOfClass("GuiWindowCtrl"))
                {
                if (((GuiControl) popup["object"])["setTitle"].AsBool())
                    setTitlePos =
                        popup.appendItem("Set Title..." + '\t' + "" + '\t' + "SetTitle.loadDialog(" + ctrl + ");");
                }

            popup.showPopup(Canvas);
            }

        [ConsoleInteraction]
        public void loadXML()
            {
            ReadXML xmlOutput = sGlobal["$XMLOutput"];

            if (!xmlOutput.isObject())
                {
                ObjectCreator xmlCreator = new ObjectCreator("ReadXML", xmlOutput);
                xmlCreator["fileName"] = sGlobal["$XMLOutput"] + ".xml";

                xmlOutput = xmlCreator.Create();
                }

            bool output = xmlOutput.readFile();
            Util._echo(output ? "Read successful." : "Read error.");
            }

        [ConsoleInteraction]
        public void xmlOutput(GuiControl ctrl)
            {
            GuiControl currentObject = ctrl.getRootControl();
            bool saved = currentObject.saveToXML(sGlobal["$XMLOutput"], sGlobal["$XMLOutput"] + ".xml");
            if (saved)
                Util._echo(" Saved " + sGlobal["$XMLOutput"] + ".xml");
            else
                Util._echo("Saved failed");
            }

        [ConsoleInteraction]
        public void transparentCheck(GuiControl ctrl, string colorName)
            {
            bool transparent = ctrl.transparentControlCheck();
            if (transparent)
                return;

            if (colorName == "fillColor")
                ColorPickerDlg.GetColorI(ctrl.controlFillColor.AsString(), ctrl + ".setControlFillColor", ctrl.getRoot(),
                    ctrl + ".setControlFillColor", ctrl + ".setControlFillColor");
            else if (colorName == "backColor")
                ColorPickerDlg.GetColorI(ctrl.backgroundColor.AsString(), ctrl + ".setControlBackgroundColor",
                    ctrl.getRoot(), ctrl + ".setControlBackgroundColor", ctrl + ".setControlBackgroundColor");
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(InGameContext ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null)
                ? object.ReferenceEquals(simobjectid, null)
                : ts.Equals(simobjectid);
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
        public static bool operator !=(InGameContext ts, string simobjectid)
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
        public static implicit operator string(InGameContext ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator InGameContext(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (InGameContext) Omni.self.getSimObject(simobjectid, typeof (InGameContext));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(InGameContext ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator InGameContext(int simobjectid)
            {
            return (InGameContext) Omni.self.getSimObject((uint) simobjectid, typeof (InGameContext));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(InGameContext ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator InGameContext(uint simobjectid)
            {
            return (InGameContext) Omni.self.getSimObject(simobjectid, typeof (InGameContext));
            }

        #endregion
        }
    }