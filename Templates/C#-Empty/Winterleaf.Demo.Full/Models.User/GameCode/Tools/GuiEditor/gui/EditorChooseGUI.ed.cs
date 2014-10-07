using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<EditorChooseGUI>))]
    public class EditorChooseGUI : GuiChunkedBitmapCtrl
        {
        

        [ConsoleInteraction(true, "EditorChooseGUI_initialize")]
        public static void initialize()
            {
            #region GuiChunkedBitmapCtrl (EditorChooseGUI, EditorGuiGroup)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiChunkedBitmapCtrl", "EditorChooseGUI, EditorGuiGroup",
                typeof (EditorChooseGUI));
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "GuiContentProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "height";
            oc_Newobject10["Position"] = "0 0";
            oc_Newobject10["Extent"] = "1024 768";
            oc_Newobject10["MinExtent"] = "8 8";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["bitmap"] = "art/gui/background";
            oc_Newobject10["useVariable"] = "0";
            oc_Newobject10["tile"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject9["HorizSizing"] = "center";
            oc_Newobject9["VertSizing"] = "center";
            oc_Newobject9["Position"] = "476 191";
            oc_Newobject9["Extent"] = "211 351";
            oc_Newobject9["MinExtent"] = "8 8";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["resizeWidth"] = "0";
            oc_Newobject9["resizeHeight"] = "0";
            oc_Newobject9["canMove"] = "1";
            oc_Newobject9["canClose"] = "0";
            oc_Newobject9["canMinimize"] = "0";
            oc_Newobject9["canMaximize"] = "0";
            oc_Newobject9["minSize"] = "50 50";
            oc_Newobject9["EdgeSnap"] = "1";
            oc_Newobject9["text"] = "GUI Selector";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "10 23";
            oc_Newobject1["Extent"] = "188 18";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["text"] = "1: Edit an Existing GUI";
            oc_Newobject1["maxLength"] = "255";

            #endregion

            oc_Newobject9["#Newobject1"] = oc_Newobject1;

            #region GuiButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "46 317";
            oc_Newobject2["Extent"] = "120 23";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "GE_ReturnToMainMenu();";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["text"] = "Play Game";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region GuiScrollCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "10 41";
            oc_Newobject4["Extent"] = "192 200";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["willFirstRespond"] = "1";
            oc_Newobject4["hScrollBar"] = "dynamic";
            oc_Newobject4["vScrollBar"] = "alwaysOn";
            oc_Newobject4["lockHorizScroll"] = "false";
            oc_Newobject4["lockVertScroll"] = "false";
            oc_Newobject4["constantThumbHeight"] = "0";
            oc_Newobject4["childMargin"] = "4 0";

            #region GuiMLTextCtrl (GE_GUIList)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiMLTextCtrl", "GE_GUIList", typeof (GE_GUIList));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiMLTextProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "5 1";
            oc_Newobject3["Extent"] = "169 560";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["lineSpacing"] = "2";
            oc_Newobject3["allowColorChars"] = "0";
            oc_Newobject3["maxChars"] = "-1";
            oc_Newobject3["useURLMouseCursor"] = "1";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region GuiButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "112 267";
            oc_Newobject5["Extent"] = "90 23";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "GE_OpenGUIFile();";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["text"] = "Browse";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "PushButton";
            oc_Newobject5["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "9 244";
            oc_Newobject6["Extent"] = "183 18";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["text"] = "2: Create New or Open Existing GUI";
            oc_Newobject6["maxLength"] = "255";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "10 267";
            oc_Newobject7["Extent"] = "93 23";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] =
                "GuiEditorNewGuiDialog.init( \\\"NewGui\\\", \\\"GuiControl\\\" ); Canvas.pushdialog(GuiEditorNewGuiDialog);";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "New GUI";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "9 294";
            oc_Newobject8["Extent"] = "183 18";
            oc_Newobject8["MinExtent"] = "8 8";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["text"] = "3: Play Game from Start";
            oc_Newobject8["maxLength"] = "255";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject10.Create();
            }

        [ConsoleInteraction]
        public static void GE_ReturnToMainMenu()
            {
            init.loadMainMenu();
            }

        [ConsoleInteraction]
        public static void GE_OpenGUIFile()
            {
            GuiCanvas Canvas = "Canvas";

            string openFileName = omni.console.Call_Classname("GuiBuilder", "getOpenName");
            if (openFileName == "")
                return;

            // Make sure the file is valid.
            if ((!omni.Util.isFile(openFileName)) && (!omni.Util.isFile(openFileName + ".dso")))
                return;

            // Allow stomping objects while exec'ing the GUI file as we want to
            // pull the file's objects even if we have another version of the GUI
            // already loaded.

            string oldRedefineBehavior = omni.sGlobal["$Con::redefineBehavior"];
            omni.sGlobal["$Con::redefineBehavior"] = "replaceExisting";

            // Load up the level.
            SimObject guiContent = omni.Util.eval(openFileName);

            omni.sGlobal["$Con::redefineBehavior"] = oldRedefineBehavior;

            // The level file should have contained a scenegraph, which should now be in the instant
            // group. And, it should be the only thing in the group.
            //TODO
            if (!guiContent.isObject())
                {
                omni.Util.messageBox(omni.console.Call("getEngineName"),
                    "You have loaded a Gui file that was created before this version.  It has been loaded but you must open it manually from the content list dropdown",
                    "Ok", "Information");
                GuiEditorGui.GuiEditContent(Canvas.getContent().AsString());
                return;
                }

            GuiEditorGui.GuiEditContent(guiContent);
            }

        [ConsoleInteraction]
        public override void onWake()
            {
            GE_GUIList GE_GUIList = "GE_GUIList";

            // Build the text list
            GE_GUIList.clear();

            string list = "<linkcolor:0000FF><linkcolorhl:FF0000>";
            list = GE_ScanGroupForGuis("GuiGroup", list);
            GE_GUIList.setText(list);
            GE_GUIList.forceReflow();
            GE_GUIList.scrollToTop(0, 0);
            }

        [ConsoleInteraction]
        public static string GE_ScanGroupForGuis(string group, string text)
            {
            int count = ((SimSet) group).getCount();
            for (uint i = 0; i < count; i++)
                {
                SimObject obj = ((SimSet) group).getObject(i);
                if (obj.getClassName() == "GuiCanvas")
                    {
                    text = text + GE_ScanGroupForGuis(obj, text);
                    }
                else
                    {
                    string name = "";
                    if (obj.getName() == "")
                        name = "(unnamed) - " + obj;
                    else
                        name = obj.getName() + " - " + obj;

                    text = text + "<a:gamelink:" + obj + ">" + name + "</a><br>";
                    }
                }

            return text;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorChooseGUI ts, string simobjectid)
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
        public static bool operator !=(EditorChooseGUI ts, string simobjectid)
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
        public static implicit operator string(EditorChooseGUI ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorChooseGUI(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorChooseGUI) Omni.self.getSimObject(simobjectid, typeof (EditorChooseGUI));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorChooseGUI ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorChooseGUI(int simobjectid)
            {
            return (EditorChooseGUI) Omni.self.getSimObject((uint) simobjectid, typeof (EditorChooseGUI));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorChooseGUI ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorChooseGUI(uint simobjectid)
            {
            return (EditorChooseGUI) Omni.self.getSimObject(simobjectid, typeof (EditorChooseGUI));
            }

        #endregion

        [TypeConverter(typeof (TypeConverterGeneric<GE_GUIList>))]
        public class GE_GUIList : GuiMLTextCtrl
            {
            [ConsoleInteraction]
            public override void onURL(string url)
                {
                // Remove 'gamelink:' from front
                string gui = Util.getSubStr(url, 9, 1024);
                GuiEditorGui.GuiEditContent(gui);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GE_GUIList ts, string simobjectid)
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
            public static bool operator !=(GE_GUIList ts, string simobjectid)
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
            public static implicit operator string(GE_GUIList ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GE_GUIList(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (GE_GUIList) Omni.self.getSimObject(simobjectid, typeof (GE_GUIList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GE_GUIList ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GE_GUIList(int simobjectid)
                {
                return (GE_GUIList) Omni.self.getSimObject((uint) simobjectid, typeof (GE_GUIList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GE_GUIList ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GE_GUIList(uint simobjectid)
                {
                return (GE_GUIList) Omni.self.getSimObject(simobjectid, typeof (GE_GUIList));
                }

            #endregion
            }
        }
    }