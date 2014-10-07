#region

using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
{
    public partial class GuiCanvas
    {

        internal static bool blockDialogs = false;
        //internal override bool OnFunctionNotFoundCallTorqueScript()
        //    {
        //    return false;
        //    }



        //internal override void onLoseFocus()
        //    {
        //    this.callScript("onLoseFocus", new[] { "" });
        //    }

        //internal override void onGainFocus()
        //    {
        //    this.callScript("onGainFocus", new[] { "" });
        //    }

        //internal override void onResize(string width, string height)
        //{
        //    this.callScript("onResize", new string[] {width, height});
        //    //base.onResize(width, height);
        //}

        public static void initialize()
        {
            omni.bGlobal["$cursorControlled"] = true;
            ((GuiCanvas)"Canvas").checkCursor();
        }

        [ConsoleInteraction(true)]
        public new static void showCursor()
        {
            if (omni.bGlobal["$cursorControlled"])
                omni.Util.lockMouse(false);
            ((GuiCanvas)"Canvas").cursorOn();
        }

        [ConsoleInteraction(true)]
        public new static void hideCursor()
        {
            if (omni.bGlobal["$cursorControlled"])
                omni.Util.lockMouse(true);
            ((GuiCanvas)"Canvas").cursorOff();
        }

        [ConsoleInteraction(true)]
        public void checkCursor()
        {
            for (uint i = 0; i < getCount(); i++)
            {
                GuiControl control = getObject(i);
                if (control["noCursor"] == "")
                {
                    showCursor();
                    return;
                }
                if (control["noCursor"] != "0" && control["noCursor"].ToLower() != "false")
                    continue;
                showCursor();
                return;
            }
            // If we get here, every control requested a hidden cursor, so we oblige.
            hideCursor();
        }

        [ConsoleInteraction(true)]
        public void setContent(GuiControl ctrl)
        {
            base.setContent(ctrl);
            this.checkCursor();
        }

        /// <summary>
        /// ( GuiCanvas, pushDialog, void, 3, 5, (GuiControl ctrl, int layer=0, bool center=false)
        /// 			  @hide)
        /// 
        /// </summary>
        [ConsoleInteraction(true)]
        public new virtual void pushDialog(string ctrl, int layer = 0, bool center = false)
        {
            if (blockDialogs)
                return;
            //this.call("pushDialog", a2, a3, a4);
            base.pushDialog(ctrl, layer, center);
            this.checkCursor();
        }

        /// <summary>
        /// ( GuiCanvas, popDialog, void, 2, 3, (GuiControl ctrl=NULL)
        /// 			  @hide)
        /// 
        /// </summary>
        //  [ConsoleInteraction(true)]
        public new void popDialog(string a2 = "")
        {
            if (blockDialogs)
                return;
            base.popDialog(a2);
            this.checkCursor();
        }

        [ConsoleInteraction(true)]
        public new void popLayer(int layer)
        {
            base.popLayer(layer);
            checkCursor();
        }

        [ConsoleInteraction(true)]
        public static bool EditorIsActive()
        {
            return ("EditorGui".isObject() && ((GuiCanvas)"Canvas").getContent() == "EditorGui".getID());
        }

        [ConsoleInteraction(true)]
        public static bool GuiEditorIsActive()
        {
            return ("GuiEditorGui".isObject() && ((GuiCanvas)"Canvas").getContent() == "GuiEditorGui".getID());
        }


        //---------------------------------------------------------------------------------------------
        // Full screen handling
        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public virtual void attemptFullscreenToggle()
        {
            // If the Editor is running then we cannot enter full screen mode
            if (EditorIsActive() && !isFullscreen())
            {
                messageBox.MessageBoxOK("Windowed Mode Required",
                    "Please exit the Mission Editor to switch to full screen.", "");
                return;
            }
            if (GuiEditorIsActive() && !isFullscreen())
            {
                messageBox.MessageBoxOK("Windowed Mode Required",
                    "Please exit the Mission Editor to switch to full screen.", "");
                return;
            }

            toggleFullscreen();
        }
    }
}