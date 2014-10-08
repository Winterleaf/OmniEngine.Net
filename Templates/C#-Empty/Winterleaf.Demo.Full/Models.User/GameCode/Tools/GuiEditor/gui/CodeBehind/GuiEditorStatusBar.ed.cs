using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditorStatusBar>))]
    public class GuiEditorStatusBar : GuiTextCtrl
        {
        internal int sequenceNum
            {
            get { return this["sequenceNum"].AsInt(); }
            set { this["sequenceNum"] = value.AsString(); }
            }

        [ConsoleInteraction]
        public string getMouseModeHelp()
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            bool isMac = (sGlobal["$platform"] == "macos");

            string cmdCtrl;
            if (isMac)
                cmdCtrl = "CMD";
            else
                cmdCtrl = "CTRL";

            string mouseMode = GuiEditor.getMouseMode();
            switch (mouseMode)
                {
                    case "Selecting":
                        return "";

                    case "DragSelecting":
                        return cmdCtrl + " to add to selection; ALT to exclude parents; CTRL+ALT to exclude children";

                    case "MovingSelection":
                        return "";

                    case "SizingSelection":
                        return "CTRL to activate snapping; ALT to move instead of resize";

                    case "DragGuide":
                        return "Drag into ruler to delete; drop to place";
                }

            return "";
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void print(string message)
            {
            this.setText(message);

            int sequenceNum = this.sequenceNum + 1;
            this.sequenceNum = sequenceNum;

            this.schedule((4*1000).AsString(), "clearMessage", sequenceNum.AsString());
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void clearMessage(int sequenceNum)
            {
            // If we had no newer message in the meantime, clear
            // out the current text.

            if (this.sequenceNum == sequenceNum)
                this.setText(this.getMouseModeHelp());
            }

        //=============================================================================================
        //    Event Handlers.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onWake()
            {
            this.setText(this.getMouseModeHelp());
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEditorStatusBar ts, string simobjectid)
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
        public static bool operator !=(GuiEditorStatusBar ts, string simobjectid)
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
        public static implicit operator string(GuiEditorStatusBar ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorStatusBar(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (GuiEditorStatusBar) Omni.self.getSimObject(simobjectid, typeof (GuiEditorStatusBar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditorStatusBar ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorStatusBar(int simobjectid)
            {
            return (GuiEditorStatusBar) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorStatusBar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditorStatusBar ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditorStatusBar(uint simobjectid)
            {
            return (GuiEditorStatusBar) Omni.self.getSimObject(simobjectid, typeof (GuiEditorStatusBar));
            }

        #endregion
        }
    }