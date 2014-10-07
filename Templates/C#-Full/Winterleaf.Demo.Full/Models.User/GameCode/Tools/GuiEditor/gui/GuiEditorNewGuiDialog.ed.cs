using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditorNewGuiDialog>))]
    public class GuiEditorNewGuiDialog : GuiControl
        {
        [ConsoleInteraction(true, "GuiEditorNewGuiDialog_initialize")]
        public static void initialize()
            {
            #region GuiControl (GuiEditorNewGuiDialog,EditorGuiGroup)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "GuiEditorNewGuiDialog,EditorGuiGroup",
                typeof (GuiEditorNewGuiDialog));
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["profile"] = "ToolsGuiOverlayProfile";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["position"] = "0 0";
            oc_Newobject9["extent"] = "1024 768";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "1";
            oc_Newobject9["enabled"] = "1";

            #region GuiWindowCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject8["resizeWidth"] = "0";
            oc_Newobject8["resizeHeight"] = "0";
            oc_Newobject8["canMove"] = "1";
            oc_Newobject8["canClose"] = "1";
            oc_Newobject8["canMinimize"] = "0";
            oc_Newobject8["canMaximize"] = "0";
            oc_Newobject8["minSize"] = "50 50";
            oc_Newobject8["edgeSnap"] = "0";
            oc_Newobject8["text"] = "Create new GUI";
            oc_Newobject8["margin"] = "0 0 0 0";
            oc_Newobject8["padding"] = "0 0 0 0";
            oc_Newobject8["anchorTop"] = "1";
            oc_Newobject8["anchorBottom"] = "0";
            oc_Newobject8["anchorLeft"] = "1";
            oc_Newobject8["anchorRight"] = "0";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject8["horizSizing"] = "center";
            oc_Newobject8["vertSizing"] = "center";
            oc_Newobject8["position"] = "357 303";
            oc_Newobject8["extent"] = "310 161";
            oc_Newobject8["minExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #region GuiButtonCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject1["text"] = "Cancel";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["useMouseEvents"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "top";
            oc_Newobject1["position"] = "228 114";
            oc_Newobject1["extent"] = "63 25";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["command"] = "GuiEditorNewGuiDialog.onCancel();";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject1"] = oc_Newobject1;

            #region GuiButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject2["text"] = "Create";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "101 114";
            oc_Newobject2["extent"] = "124 25";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["command"] = "GuiEditorNewGuiDialog.onOK();";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["accelerator"] = "enter";

            #endregion

            oc_Newobject8["#Newobject2"] = oc_Newobject2;

            #region GuiControl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "");
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["position"] = "15 28";
            oc_Newobject7["extent"] = "278 76";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "GUI Name";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["margin"] = "0 0 0 0";
            oc_Newobject3["padding"] = "0 0 0 0";
            oc_Newobject3["anchorTop"] = "1";
            oc_Newobject3["anchorBottom"] = "0";
            oc_Newobject3["anchorLeft"] = "1";
            oc_Newobject3["anchorRight"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["profile"] = "ToolsGuiTextProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "14 13";
            oc_Newobject3["extent"] = "80 18";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiTextEditCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject4["historySize"] = "0";
            oc_Newobject4["password"] = "0";
            oc_Newobject4["tabComplete"] = "0";
            oc_Newobject4["sinkAllKeyEvents"] = "0";
            oc_Newobject4["passwordMask"] = "*";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["margin"] = "0 0 0 0";
            oc_Newobject4["padding"] = "0 0 0 0";
            oc_Newobject4["anchorTop"] = "1";
            oc_Newobject4["anchorBottom"] = "0";
            oc_Newobject4["anchorLeft"] = "1";
            oc_Newobject4["anchorRight"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "103 13";
            oc_Newobject4["extent"] = "160 17";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["internalName"] = "nameField";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "GUI Class";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["margin"] = "0 0 0 0";
            oc_Newobject5["padding"] = "0 0 0 0";
            oc_Newobject5["anchorTop"] = "1";
            oc_Newobject5["anchorBottom"] = "0";
            oc_Newobject5["anchorLeft"] = "1";
            oc_Newobject5["anchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["profile"] = "ToolsGuiTextProfile";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "14 44";
            oc_Newobject5["extent"] = "80 18";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject5"] = oc_Newobject5;

            #region GuiPopUpMenuCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject6["maxPopupHeight"] = "200";
            oc_Newobject6["sbUsesNAColor"] = "0";
            oc_Newobject6["reverseTextList"] = "0";
            oc_Newobject6["bitmapBounds"] = "16 16";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["margin"] = "0 0 0 0";
            oc_Newobject6["padding"] = "0 0 0 0";
            oc_Newobject6["anchorTop"] = "1";
            oc_Newobject6["anchorBottom"] = "0";
            oc_Newobject6["anchorLeft"] = "1";
            oc_Newobject6["anchorRight"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["position"] = "103 44";
            oc_Newobject6["extent"] = "160 18";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["internalName"] = "classDropdown";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject9.Create();
            }

        [ConsoleInteraction]
        public void init(string guiName, string guiClass)
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            GuiTextEditCtrl nameField = this.FOT("nameField");

            nameField.setValue(guiName);

            // Initialize the class dropdown if we haven't already.

            GuiPopUpMenuCtrl classDropdown = this.FOT("classDropdown");
            if (classDropdown.size() == 0)
                {
                string classes = Util.enumerateConsoleClassesByCategory("Gui");
                int count = Util.getFieldCount(classes);

                for (int i = 0; i < count; i ++)
                    {
                    string className = Util.getField(classes, i);
                    if (GuiEditor.isFilteredClass(className)
                        || !Util.isMemberOfClass(className, "GuiControl"))
                        continue;

                    classDropdown.add(className, 0);
                    }

                classDropdown.sort();
                }

            classDropdown.setText("GuiControl");
            }

        //=============================================================================================
        //    Event Handlers.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onWake()
            {
            // Center the dialog.

            GuiControl root = this.getRoot();
            this.setPosition(root.extent.x/2 - this.extent.x/2, root.extent.y/2 - this.extent.y/2);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onOK()
            {
            GuiTextEditCtrl nameField = this.FOT("nameField");
            GuiPopUpMenuCtrl classDropdown = this.FOT("classDropdown");
            editor Editor = "Editor";

            string name = nameField.getValue();
            string className = classDropdown.getText();

            // Make sure we don't clash with an existing object.
            // If there's an existing GUIControl with the name, ask to replace.
            // If there's an existing non-GUIControl with the name, or the name is invalid, refuse to create.

            if (name.isObject() && ((SimObject) name).isMemberOfClass("GuiControl"))
                {
                if (
                    Util.messageBox("Warning", "Replace the existing control '" + name + "'?", "OkCancel", "Question") ==
                    iGlobal["$MROk"])
                    name.delete();
                else
                    return;
                }

            if (Editor.validateObjectName(name, false))
                {
                ((GuiCanvas) this.getRoot()).popDialog(this);
                SimObject obj = Util.eval("return new " + className + "(" + name + ");");

                // Make sure we have no association with a filename.
                obj.setFilename("");

                GuiEditorGui.GuiEditContent(obj);
                }
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onCancel()
            {
            ((GuiCanvas) this.getRoot()).popDialog(this);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEditorNewGuiDialog ts, string simobjectid)
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
        public static bool operator !=(GuiEditorNewGuiDialog ts, string simobjectid)
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
        public static implicit operator string(GuiEditorNewGuiDialog ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorNewGuiDialog(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (GuiEditorNewGuiDialog) Omni.self.getSimObject(simobjectid, typeof (GuiEditorNewGuiDialog));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditorNewGuiDialog ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorNewGuiDialog(int simobjectid)
            {
            return (GuiEditorNewGuiDialog) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorNewGuiDialog));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditorNewGuiDialog ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditorNewGuiDialog(uint simobjectid)
            {
            return (GuiEditorNewGuiDialog) Omni.self.getSimObject(simobjectid, typeof (GuiEditorNewGuiDialog));
            }

        #endregion
        }
    }