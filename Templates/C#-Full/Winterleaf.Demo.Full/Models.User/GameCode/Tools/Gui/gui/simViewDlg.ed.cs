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
    [TypeConverter(typeof (TypeConverterGeneric<simViewDlg>))]
    public class simViewDlg : GuiControl
        {
        

        [ConsoleInteraction(true, "simViewDlg_initialize")]
        public static void initialize()
            {
            #region GuiControl (simViewDlg, EditorGuiGroup)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiControl", "simViewDlg, EditorGuiGroup",
                typeof (simViewDlg));
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "0 0";
            oc_Newobject15["Extent"] = "800 600";
            oc_Newobject15["MinExtent"] = "8 8";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["hovertime"] = "1000";

            #region GuiWindowCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject14["HorizSizing"] = "center";
            oc_Newobject14["VertSizing"] = "center";
            oc_Newobject14["position"] = "70 43";
            oc_Newobject14["Extent"] = "685 489";
            oc_Newobject14["MinExtent"] = "602 440";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["text"] = "Torque SimView";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["resizeWidth"] = "1";
            oc_Newobject14["resizeHeight"] = "1";
            oc_Newobject14["canMove"] = "1";
            oc_Newobject14["canClose"] = "1";
            oc_Newobject14["canMinimize"] = "1";
            oc_Newobject14["canMaximize"] = "1";
            oc_Newobject14["minSize"] = "50 50";
            oc_Newobject14["closeCommand"] = "Canvas.popDialog(simViewDlg);";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["position"] = "10 28";
            oc_Newobject2["Extent"] = "255 448";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "dynamic";
            oc_Newobject2["vScrollBar"] = "alwaysOn";
            oc_Newobject2["lockHorizScroll"] = "false";
            oc_Newobject2["lockVertScroll"] = "false";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";

            #region GuiTreeViewCtrl (InspectTreeView)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTreeViewCtrl", "InspectTreeView",
                typeof (InspectTreeView));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "2 2";
            oc_Newobject1["Extent"] = "212 21";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["tabSize"] = "16";
            oc_Newobject1["textOffset"] = "2";
            oc_Newobject1["fullRowSelect"] = "0";
            oc_Newobject1["itemHeight"] = "21";
            oc_Newobject1["destroyTreeOnSleep"] = "1";
            oc_Newobject1["MouseDragging"] = "1";
            oc_Newobject1["MultipleSelections"] = "1";
            oc_Newobject1["DeleteObjectAllowed"] = "1";
            oc_Newobject1["DragToItemAllowed"] = "1";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject14["#Newobject2"] = oc_Newobject2;

            #region GuiScrollCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject4["HorizSizing"] = "left";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["position"] = "272 96";
            oc_Newobject4["Extent"] = "404 380";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["willFirstRespond"] = "1";
            oc_Newobject4["hScrollBar"] = "alwaysOff";
            oc_Newobject4["vScrollBar"] = "alwaysOn";
            oc_Newobject4["lockHorizScroll"] = "true";
            oc_Newobject4["lockVertScroll"] = "false";
            oc_Newobject4["constantThumbHeight"] = "0";
            oc_Newobject4["childMargin"] = "0 0";

            #region GuiInspector (InspectFields)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiInspector", "InspectFields");
            oc_Newobject3["StackingType"] = "Vertical";
            oc_Newobject3["HorizStacking"] = "Left to Right";
            oc_Newobject3["VertStacking"] = "Top to Bottom";
            oc_Newobject3["Padding"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "2 2";
            oc_Newobject3["Extent"] = "382 8";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject14["#Newobject4"] = oc_Newobject4;

            #region GuiControl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiControl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject13["HorizSizing"] = "left";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "272 28";
            oc_Newobject13["Extent"] = "403 61";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["hovertime"] = "1000";

            #region GuiTextEditCtrl (InspectObjectName)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextEditCtrl", "InspectObjectName");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "121 8";
            oc_Newobject5["Extent"] = "195 18";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["historySize"] = "0";
            oc_Newobject5["password"] = "0";
            oc_Newobject5["tabComplete"] = "0";
            oc_Newobject5["sinkAllKeyEvents"] = "0";
            oc_Newobject5["password"] = "0";
            oc_Newobject5["passwordMask"] = "*";

            #endregion

            oc_Newobject13["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Profile"] = "EditorTextHLRight";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "217 35";
            oc_Newobject6["Extent"] = "44 18";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["text"] = "Sim ID:";
            oc_Newobject6["maxLength"] = "1024";

            #endregion

            oc_Newobject13["#Newobject6"] = oc_Newobject6;

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Profile"] = "EditorTextHLRight";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "10 35";
            oc_Newobject7["Extent"] = "106 18";
            oc_Newobject7["MinExtent"] = "8 8";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "Internal Name:";
            oc_Newobject7["maxLength"] = "1024";

            #endregion

            oc_Newobject13["#Newobject7"] = oc_Newobject7;

            #region GuiTextEditCtrl (InspectObjectInternalName)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextEditCtrl", "InspectObjectInternalName");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "121 35";
            oc_Newobject8["Extent"] = "93 18";
            oc_Newobject8["MinExtent"] = "8 8";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["historySize"] = "0";
            oc_Newobject8["password"] = "0";
            oc_Newobject8["tabComplete"] = "0";
            oc_Newobject8["sinkAllKeyEvents"] = "0";
            oc_Newobject8["password"] = "0";
            oc_Newobject8["passwordMask"] = "*";

            #endregion

            oc_Newobject13["#Newobject8"] = oc_Newobject8;

            #region GuiTextCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Profile"] = "EditorTextHLBoldRight";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "10 8";
            oc_Newobject9["Extent"] = "106 18";
            oc_Newobject9["MinExtent"] = "8 8";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["text"] = "Selected Object:";
            oc_Newobject9["maxLength"] = "1024";

            #endregion

            oc_Newobject13["#Newobject9"] = oc_Newobject9;

            #region GuiIconButtonCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "321 33";
            oc_Newobject10["Extent"] = "76 22";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["Command"] = "InspectApply();";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["text"] = "Refresh";
            oc_Newobject10["groupNum"] = "-1";
            oc_Newobject10["buttonType"] = "PushButton";
            oc_Newobject10["iconBitmap"] = "tools/gui/images/iconRefresh.png";
            oc_Newobject10["sizeIconToButton"] = "0";
            oc_Newobject10["textLocation"] = "Right";
            oc_Newobject10["textMargin"] = "4";
            oc_Newobject10["buttonMargin"] = "4 4";

            #endregion

            oc_Newobject13["#Newobject10"] = oc_Newobject10;

            #region GuiTextCtrl (InspectObjectSimID)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "InspectObjectSimID");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Profile"] = "EditorTextHLBoldCenter";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "265 35";
            oc_Newobject11["Extent"] = "51 18";
            oc_Newobject11["MinExtent"] = "8 8";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["text"] = "0";
            oc_Newobject11["maxLength"] = "1024";

            #endregion

            oc_Newobject13["#Newobject11"] = oc_Newobject11;

            #region GuiIconButtonCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "321 6";
            oc_Newobject12["Extent"] = "76 22";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "InspectDelete();";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["text"] = "Delete";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["buttonType"] = "PushButton";
            oc_Newobject12["iconBitmap"] = "tools/gui/images/iconDelete.png";
            oc_Newobject12["sizeIconToButton"] = "0";
            oc_Newobject12["textLocation"] = "Right";
            oc_Newobject12["textMargin"] = "4";
            oc_Newobject12["buttonMargin"] = "4 4";

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject15.Create();
            }

        [ConsoleInteraction]
        public static void Inspect(SimObject obj)
            {
            GuiInspector InspectFields = "InspectFields";
            GuiTextEditCtrl InspectObjectName = "InspectObjectName";
            GuiTextEditCtrl InspectObjectInternalName = "InspectObjectInternalName";
            GuiTextCtrl InspectObjectSimID = "InspectObjectSimID";

            // Don't inspect the root group.
            if (obj == -1)
                return;

            InspectFields.inspect(obj);

            // Update selected object properties
            InspectObjectName.setValue(obj.getName());
            InspectObjectInternalName.setValue(obj.getInternalName());
            InspectObjectSimID.setValue(obj.getId().AsString());

            // Store Object Reference
            InspectObjectName["refObj"] = obj;
            }

        [ConsoleInteraction]
        public static void InspectApply()
            {
            GuiInspector InspectFields = "InspectFields";
            GuiTextEditCtrl InspectObjectName = "InspectObjectName";
            GuiTextEditCtrl InspectObjectInternalName = "InspectObjectInternalName";

            SimObject obj = InspectObjectName["refObj"];
            if (!obj.isObject())
                return;

            // Update name and internal name
            obj.setName(InspectObjectName.getValue());
            obj.setInternalName(InspectObjectInternalName.getValue());

            // Update inspected object information.
            InspectFields.inspect(obj);
            }

        [ConsoleInteraction]
        public static void InspectDelete()
            {
            GuiInspector InspectFields = "InspectFields";
            GuiTextEditCtrl InspectObjectName = "InspectObjectName";
            GuiTextEditCtrl InspectObjectInternalName = "InspectObjectInternalName";
            GuiTextCtrl InspectObjectSimID = "InspectObjectSimID";

            SimObject obj = InspectObjectName["refObj"];
            if (!obj.isObject())
                return;

            obj.delete();

            // Update inspected object information.
            InspectFields.inspect("0");

            // Update selected object properties
            InspectObjectName.setValue("");
            InspectObjectInternalName.setValue("");
            InspectObjectSimID.setValue("0");
            }

        [ConsoleInteraction]
        public static void Tree(SimObject obj)
            {
            InspectTreeView InspectTreeView = "InspectTreeView";
            GuiCanvas Canvas = "Canvas";

            Canvas.popDialog("simViewDlg");
            Canvas.pushDialog("simViewDlg", 20);
            InspectTreeView.open(obj);
            }

        [TypeConverter(typeof (InspectTreeView))]
        public class InspectTreeView : GuiTreeViewCtrl
            {
            [ConsoleInteraction]
            public override void onSelect(string x, string y)
                {
                Inspect(x);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(InspectTreeView ts, string simobjectid)
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
            public static bool operator !=(InspectTreeView ts, string simobjectid)
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
            public static implicit operator string(InspectTreeView ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator InspectTreeView(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (InspectTreeView) Omni.self.getSimObject(simobjectid, typeof (InspectTreeView));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(InspectTreeView ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator InspectTreeView(int simobjectid)
                {
                return (InspectTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (InspectTreeView));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(InspectTreeView ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator InspectTreeView(uint simobjectid)
                {
                return (InspectTreeView) Omni.self.getSimObject(simobjectid, typeof (InspectTreeView));
                }

            #endregion
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(simViewDlg ts, string simobjectid)
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
        public static bool operator !=(simViewDlg ts, string simobjectid)
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
        public static implicit operator string(simViewDlg ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator simViewDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (simViewDlg) Omni.self.getSimObject(simobjectid, typeof (simViewDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(simViewDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator simViewDlg(int simobjectid)
            {
            return (simViewDlg) Omni.self.getSimObject((uint) simobjectid, typeof (simViewDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(simViewDlg ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator simViewDlg(uint simobjectid)
            {
            return (simViewDlg) Omni.self.getSimObject(simobjectid, typeof (simViewDlg));
            }

        #endregion
        }
    }

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class GuiInspector
        {
        //TODO
        // MM: Added Dynamic group toggle support.
        [ConsoleInteraction]
        public void toggleDynamicGroupScript(SimObject obj)
            {
            this.call("toggleDynamicGroupExpand");
            this.inspect(obj);
            }

        [ConsoleInteraction]
        // MM: Added group toggle support.
        public void toggleGroupScript(SimObject obj, string fieldName)
            {
            this.call("toggleGroupExpand", obj, fieldName);
            this.inspect(obj);
            }

        [ConsoleInteraction]
        // MM: Set All Group State support.
        public void setAllGroupStateScript(SimObject obj, string groupState)
            {
            this.call("setAllGroupState", groupState);
            this.inspect(obj);
            }
        }
    }