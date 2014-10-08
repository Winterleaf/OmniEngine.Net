using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg
    {
    [TypeConverter(typeof (TypeConverterGeneric<OptRemapInputCtrl>))]
    public class OptRemapInputCtrl : GuiInputCtrl
        {
        

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onInputEvent(string device, string action, bool state)
            {
            //error( "** onInputEvent called - device = " @ %device @ ", action = " @ %action @ " **" );
            ((GuiCanvas) "Canvas").popDialog("RemapDlg");

            // Test for the reserved keystrokes:
            if (device == "keyboard")
                {
                //Cancel
                if (action == "escape")
                    {
                    //do Nothing
                    return;
                    }
                }

            string cmd = sGlobal["$RemapCmd[" + this["index"] + "]"];
            cmd = sGlobal["$RemapName[" + this["index"] + "]"];

            // Grab the friendly display name for this action
            // which we'll use when prompting the user below.

            string mapName = OptionsDlg.getMapDisplayName(device, action);

            string prevMap = ((ActionMap) "MoveMap").getCommand(device, action);

            // If nothing was mapped to the previous command 

            // mapping then it's easy... just bind it.
            OptionsDlg optionsDlg = "optionsDlg";

            if (prevMap == "")
                {
                unbindExtraActions(cmd, 1);
                ((ActionMap) "moveMap").bind(device, action, cmd);
                ((GuiTextListCtrl) optionsDlg.findObjectByInternalName("OptRemapList", true)).setRowById(
                    this["index"].AsInt(), OptionsDlg.buildFullMapString(this["index"].AsInt()));
                return;
                }


            // If the previous command is the same as the 
            // current then they hit the same input as what
            // was already assigned.

            if (prevMap == cmd)
                {
                unbindExtraActions(cmd, 0);
                ((ActionMap) "moveMap").bind(cmd, action, cmd);
                ((GuiTextListCtrl) optionsDlg.findObjectByInternalName("OptRemapList", true)).setRowById(
                    this["index"].AsInt(), OptionsDlg.buildFullMapString(this["index"].AsInt()));
                return;
                }
            // Look for the index of the previous mapping.
            int prevMapIndex = findRemapCmdIndex(prevMap);

            // If we get a negative index then the previous 
            // mapping was to an item that isn't included in
            // the mapping list... so we cannot unmap it.

            if (prevMapIndex == -1)
                {
                messageBox.MessageBoxOK("Remap Failed",
                    "\"" + mapName + "\" is already bound to a non-remappable command!", "");
                return;
                }

            // Setup the forced remapping callback command.
            string callback = "redoMapping(" + device + ",\"" + action + "\",\"" + cmd + "\", " + prevMapIndex + ", " +
                              this["index"] + ");";
            // Warn that we're about to remove the old mapping and
            // replace it with another.
            string prevCmdName = sGlobal["$RemapName[" + prevMapIndex + "];"];

            messageBox.MessageBoxYesNo("Warning",
                "\"" + mapName + "\" is already bound to \"" + prevCmdName + "\"!\nDo you wish to replace this mapping?",
                callback, "");
            }

        [ConsoleInteraction(true)]
        public static int findRemapCmdIndex(string command)
            {
            for (int i = 0; i < omni.iGlobal["$RemapCount"]; i++)
                {
                if (command == omni.sGlobal["$RemapCmd[" + i + "]"])
                    return i;
                }
            return -1;
            }

        [ConsoleInteraction(true)]
        // This unbinds actions beyond %count associated to the
        // particular moveMap %commmand.
        public static void unbindExtraActions(string command, int count)
            {
            string temp = ((ActionMap) "moveMap").getBinding(command);
            if (temp == "")
                return;

            count = omni.Util.getFieldCount(temp) - (count*2);
            for (int i = 0; i < count; i += 2)
                {
                string device = omni.Util.getField(temp, i + 0);
                string action = omni.Util.getField(temp, i + 1);
                ((ActionMap) "moveMap").unbind(device, action);
                }
            }

        [ConsoleInteraction(true)]
        public static void redoMapping(string device, string action, string cmd, int oldIndex, int newIndex)
            {
            ((ActionMap) "moveMap").bind(device, action, cmd);

            GuiTextListCtrl remapList =
                ((OptRemapInputCtrl) "OptRemapInputCtrl").findObjectByInternalName("OptRemapList", true);
            remapList.setRowById(oldIndex, OptionsDlg.buildFullMapString(oldIndex));
            remapList.setRowById(newIndex, OptionsDlg.buildFullMapString(newIndex));
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(OptRemapInputCtrl ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
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
        public static bool operator !=(OptRemapInputCtrl ts, string simobjectid)
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
        public static implicit operator string(OptRemapInputCtrl ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator OptRemapInputCtrl(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (OptRemapInputCtrl) Omni.self.getSimObject(simobjectid, typeof (OptRemapInputCtrl));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(OptRemapInputCtrl ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator OptRemapInputCtrl(int simobjectid)
            {
            return (OptRemapInputCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (OptRemapInputCtrl));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(OptRemapInputCtrl ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator OptRemapInputCtrl(uint simobjectid)
            {
            return (OptRemapInputCtrl) Omni.self.getSimObject(simobjectid, typeof (OptRemapInputCtrl));
            }

        #endregion
        }
    }