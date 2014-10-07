using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
    {
    [TypeConverter(typeof (EWTreeWindow))]
    public class EWTreeWindow : GuiWindowCollapseCtrl
        {
        public override void onPopWindow()
            {
            WorldEditorInspectorPlugin WorldEditorInspectorPlugin = "WorldEditorInspectorPlugin";

            EditorGui.DeactivateAll();
            WorldEditorInspectorPlugin.onActivated();
            }

        public override void onPopWindowClosed()
            {
            WorldEditorInspectorPlugin WorldEditorInspectorPlugin = "WorldEditorInspectorPlugin";
            EWInspectorWindow EWInspectorWindow = "EWInspectorWindow";

            EditorGui.DeactivateAll();
            WorldEditorInspectorPlugin.onActivated();
            this.attachTo(EWInspectorWindow);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EWTreeWindow ts, string simobjectid)
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
        public static bool operator !=(EWTreeWindow ts, string simobjectid)
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
        public static implicit operator string(EWTreeWindow ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EWTreeWindow(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EWTreeWindow) Omni.self.getSimObject(simobjectid, typeof (EWTreeWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EWTreeWindow ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EWTreeWindow(int simobjectid)
            {
            return (EWTreeWindow) Omni.self.getSimObject((uint) simobjectid, typeof (EWTreeWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EWTreeWindow ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EWTreeWindow(uint simobjectid)
            {
            return (EWTreeWindow) Omni.self.getSimObject(simobjectid, typeof (EWTreeWindow));
            }

        #endregion
        }
    }