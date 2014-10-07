using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns
    {
    [TypeConverter(typeof (TypeConverterGeneric<WorldEditorPlugin>))]
    public class WorldEditorPlugin : EditorPlugin
        {
        public override void onActivated()
            {
            EditorGui EditorGui = "EditorGui";
            EWorldEditor EWorldEditor = "EWorldEditor";
            EditorTree EditorTree = "EditorTree";
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            ETransformSelection ETransformSelection = "ETransformSelection";
            SimGroup MissionGroup = "MissionGroup";

            EditorGui.bringToFront("EWorldEditor");
            EWorldEditor.setVisible(true);

            EditorGui.menuBar.insert(EditorGui.worldMenu, EditorGui.menuBar["dynamicItemInsertPos"].AsInt());

            EWorldEditor.makeFirstResponder(true);
            EditorTree.open(MissionGroup, true);
            EWCreatorWindow.setNewObjectGroup(MissionGroup);

            EWorldEditor.syncGui();

            EditorGuiStatusBar.setSelectionObjectsByCount(EWorldEditor.getSelectionSize().AsString());

            // Should the Transform Selection window open?
            if (EWorldEditor["ETransformSelectionDisplayed"].AsBool())
                ETransformSelection.setVisible(true);

            base.onActivated();
            }

        public override void onDeactivated()
            {
            ETransformSelection ETransformSelection = "ETransformSelection";
            EWorldEditor EWorldEditor = "EWorldEditor";
            EditorGui EditorGui = "EditorGui";

            ETransformSelection.setVisible(false);
            EWorldEditor.setVisible(false);
            EditorGui.menuBar.remove(EditorGui.worldMenu);
            base.onDeactivated();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WorldEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(WorldEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(WorldEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator WorldEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (WorldEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (WorldEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(WorldEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WorldEditorPlugin(int simobjectid)
            {
            return (WorldEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (WorldEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(WorldEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WorldEditorPlugin(uint simobjectid)
            {
            return (WorldEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (WorldEditorPlugin));
            }

        #endregion
        }
    }