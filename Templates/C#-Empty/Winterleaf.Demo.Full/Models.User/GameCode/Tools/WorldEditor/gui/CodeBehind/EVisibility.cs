using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<EVisibility>))]
    public class EVisibility : GuiWindowCtrl
        {
        private ArrayObject array
            {
            get { return this["array"]; }
            }


        private ArrayObject classArray
            {
            get { return this["classArray"]; }
            }

        public override void onWake()
            {
            if (!this["array"].isObject())
                {
                this["array"] = new ObjectCreator("ArrayObject").Create().AsString();
                }

            // Create the array if it
            // doesn't already exist.

            if (!this["classArray"].isObject())
                {
                this["classArray"] = new ObjectCreator("ArrayObject").Create().AsString();
                this.addClassOptions();
                }
            this.updateOptions();
            }


        [ConsoleInteraction]
        public void updateOptions()
            {
            GuiStackControl theVisOptionsList = this.findObjectByInternalName("theVisOptionsList", true);
            theVisOptionsList.clear();

            // Go through all the
            // parameters in our array and
            // create a check box for each.
            for (int i = 0; i < array.count(); i++)
                {
                string text = "  " + array.getValue(i);
                string val = array.getKey(i);
                string var = Util.getWord(val, 0);
                string toggleFunction = Util.getWord(val, 1);

                int textLength = text.Length;

                string cmd = "";

                if (toggleFunction != "")
                    cmd = toggleFunction + "( $thisControl.getValue() );";

                ObjectCreator oc = new ObjectCreator("GuiCheckBoxCtrl");
                oc["canSaveDynamicFields"] = "0";
                oc["isContainer"] = "0";
                oc["Profile"] = "ToolsGuiCheckBoxListProfile";
                oc["HorizSizing"] = "right";
                oc["VertSizing"] = "bottom";
                oc["Position"] = "0 0";
                oc["Extent"] = (textLength*4) + " 18";
                oc["MinExtent"] = "8 2";
                oc["canSave"] = "1";
                oc["Visible"] = "1";
                oc["Variable"] = var;
                oc["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc["hovertime"] = "1000";
                oc["text"] = text;
                oc["groupNum"] = "-1";
                oc["buttonType"] = "ToggleButton";
                oc["useMouseEvents"] = "0";
                oc["useInactiveState"] = "0";
                oc["Command"] = cmd;

                GuiCheckBoxCtrl ctrl = oc.Create();

                theVisOptionsList.addGuiControl(ctrl);
                }
            }

        [ConsoleInteraction]
        public void addOption(string text, string varName, string toggleFunction)
            {
            // Create the array if it
            // doesn't already exist.
            if (!this["array"].isObject())
                {
                this["array"] = new ObjectCreator("ArrayObject").Create().AsString();
                }
            this.array.push_back(varName + " " + toggleFunction, text);
            this.array.uniqueKey();
            this.array.sortd();
            this.updateOptions();
            }

        [ConsoleInteraction]
        public void addClassOptions()
            {
            GuiStackControl visList = this.findObjectByInternalName("theClassVisList", true);
            GuiStackControl selList = this.findObjectByInternalName("theClassSelList", true);

            // First clear the stack control.
            visList.clear();
            selList.clear();

            string classList = Util._call("enumerateConsoleClasses", "SceneObject");
            int classCount = Util.getFieldCount(classList);

            for (int i = 0; i < classCount; i++)
                {
                string className = Util.getField(classList, i);
                classArray.push_back(className, "");
                }

            // Remove duplicates and sort by key.
            this.classArray.uniqueKey();
            this.classArray.sortkd();

            // Go through all the
            // parameters in our array and
            // create a check box for each.

            for (int i = 0; i < classArray.count(); i++)
                {
                string Class = classArray.getKey(i);

                string visVar = "$" + Class + "::isRenderable";
                string selVar = "$" + Class + "::isSelectable";

                int textLength = Class.Length;

                string text = "  " + Class;

                // Add visibility toggle.

                ObjectCreator oc = new ObjectCreator("GuiCheckBoxCtrl");
                oc["canSaveDynamicFields"] = "0";
                oc["isContainer"] = "0";
                oc["Profile"] = "ToolsGuiCheckBoxListFlipedProfile";
                oc["HorizSizing"] = "right";
                oc["VertSizing"] = "bottom";
                oc["Position"] = "0 0";
                oc["Extent"] = (textLength*4) + " 18";
                oc["MinExtent"] = "8 2";
                oc["canSave"] = "1";
                oc["Visible"] = "1";
                oc["Variable"] = visVar;
                oc["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc["hovertime"] = "1000";
                oc["tooltip"] = "Show/hide all " + Class + " objects.";
                oc["text"] = text;
                oc["groupNum"] = "-1";
                oc["buttonType"] = "ToggleButton";
                oc["useMouseEvents"] = "0";
                oc["useInactiveState"] = "0";

                GuiCheckBoxCtrl ctrl = oc.Create();
                visList.addGuiControl(ctrl);
                // Add selectability toggle.
                oc = new ObjectCreator("GuiCheckBoxCtrl");
                oc["canSaveDynamicFields"] = "0";
                oc["isContainer"] = "0";
                oc["Profile"] = "ToolsGuiCheckBoxListFlipedProfile";
                oc["HorizSizing"] = "right";
                oc["VertSizing"] = "bottom";
                oc["Position"] = "0 0";
                oc["Extent"] = (textLength*4) + " 18";
                oc["MinExtent"] = "8 2";
                oc["canSave"] = "1";
                oc["Visible"] = "1";
                oc["Variable"] = selVar;
                oc["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc["hovertime"] = "1000";
                oc["tooltip"] = "Enable/disable selection of all " + Class + " objects.";
                oc["text"] = text;
                oc["groupNum"] = "-1";
                oc["buttonType"] = "ToggleButton";
                oc["useMouseEvents"] = "0";
                oc["useInactiveState"] = "0";
                ctrl = oc.Create();

                selList.addGuiControl(ctrl);
                }
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EVisibility ts, string simobjectid)
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
        public static bool operator !=(EVisibility ts, string simobjectid)
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
        public static implicit operator string(EVisibility ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EVisibility(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EVisibility) Omni.self.getSimObject(simobjectid, typeof (EVisibility));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EVisibility ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EVisibility(int simobjectid)
            {
            return (EVisibility) Omni.self.getSimObject((uint) simobjectid, typeof (EVisibility));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EVisibility ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EVisibility(uint simobjectid)
            {
            return (EVisibility) Omni.self.getSimObject(simobjectid, typeof (EVisibility));
            }

        #endregion
        }
    }