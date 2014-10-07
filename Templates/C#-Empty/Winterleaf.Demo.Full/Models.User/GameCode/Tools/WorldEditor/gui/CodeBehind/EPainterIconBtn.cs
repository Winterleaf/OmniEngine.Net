using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<EPainterIconBtn>))]
    public class EPainterIconBtn : GuiIconButtonCtrl
        {
        public override void onMouseDragged()
            {
            GuiCanvas canvas = "canvas";

            ObjectCreator oc = new ObjectCreator("GuiControl");
            oc["profile"] = "GuiCreatorIconButtonProfile";
            oc["position"] = "0 0";
            oc["extent"] = this.extent.x + " 5";
            oc["dragSourceControl"] = this;

            GuiControl payload = oc.Create();

            int xOffset = payload.extent.x/2;
            int yOffset = payload.extent.y/2;

            Point2I cursorPos = canvas.getCursorPos();

            int xPos = cursorPos.x - xOffset;
            int yPos = cursorPos.y - yOffset;

            // Create the drag control.

            oc = new ObjectCreator("GuiDragAndDropControl");
            oc["canSaveDynamicFields"] = "0";
            oc["Profile"] = "EPainterDragDropProfile";
            oc["HorizSizing"] = "right";
            oc["VertSizing"] = "bottom";
            oc["Position"] = xPos + " " + yPos;
            oc["extent"] = payload.extent;
            oc["MinExtent"] = "4 4";
            oc["canSave"] = "1";
            oc["Visible"] = "1";
            oc["hovertime"] = "1000";
            oc["deleteOnMouseUp"] = true;

            GuiDragAndDropControl ctrl = oc.Create();

            ctrl.add(payload);

            ((GuiControl) canvas.getContent()).add(ctrl);
            ctrl.startDragging(xOffset, yOffset);
            }

        public override void onControlDragged(GuiControl control, string dropPoint)
            {
            ((GuiControl) control.getParent()).position = this.getGlobalPosition();
            }

        public override void onControlDropped(GuiControl control, string dropPoint)
            {
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            string srcBtn = control["dragSourceControl"];
            GuiControl dstBtn = this;
            GuiControl stack = this.getParent();
            // Not dropped on a valid Button.
            // Really this shouldnt happen since we are in a callback on our specialized
            // EPainterIconBtn namespace.

            if (stack != dstBtn.getParent() || stack != "EPainterStack".getID())
                {
                console.print("Not dropped on valid control");
                return;
                }
            // Dropped on the original control, no order change.
            // Simulate a click on the control, instead of a drag/drop.
            if (srcBtn == dstBtn)
                {
                dstBtn.call("performClick");
                return;
                }

            int dstIndex =  stack.getObjectIndex(dstBtn);

            ETerrainEditor.reorderMaterial(stack.getObjectIndex(srcBtn), dstIndex);

            // select the button/material we just reordered.

            stack.getObject((uint)dstIndex).call("performClick");
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EPainterIconBtn ts, string simobjectid)
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
        public static bool operator !=(EPainterIconBtn ts, string simobjectid)
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
        public static implicit operator string(EPainterIconBtn ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EPainterIconBtn(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EPainterIconBtn) Omni.self.getSimObject(simobjectid, typeof (EPainterIconBtn));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EPainterIconBtn ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EPainterIconBtn(int simobjectid)
            {
            return (EPainterIconBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EPainterIconBtn));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EPainterIconBtn ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EPainterIconBtn(uint simobjectid)
            {
            return (EPainterIconBtn) Omni.self.getSimObject(simobjectid, typeof (EPainterIconBtn));
            }

        #endregion
        }
    }