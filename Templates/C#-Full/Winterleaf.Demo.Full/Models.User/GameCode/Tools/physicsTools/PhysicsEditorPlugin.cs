using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.physicsTools
    {
    [TypeConverter(typeof (TypeConverterGeneric<PhysicsEditorPlugin>))]
    public class PhysicsEditorPlugin : EditorPlugin
        {
        public override void onWorldEditorStartup()
            {
            ObjectCreator viewCreator = new ObjectCreator("PopupMenu", "PhysicsToolsMenu", typeof (PhysicsToolsMenu));
            viewCreator["superClass"] = "MenuBuilder";
            //class = "PhysXToolsMenu";

            viewCreator["barTitle"] = "Physics";

            viewCreator["item[0]"] =
                "Start Simulation\tCtrl-Alt P\tphysicsStartSimulation( \"client\" );physicsStartSimulation( \"server\" );";

            viewCreator["item[1]"] = "-";
            viewCreator["item[2]"] = "Speed 25%\t\tphysicsSetTimeScale( 0.25 );";
            viewCreator["item[3]"] = "Speed 50%\t\tphysicsSetTimeScale( 0.5 );";
            viewCreator["item[4]"] = "Speed 100%\t\tphysicsSetTimeScale( 1.0 );";
            viewCreator["item[5]"] = "-";
            viewCreator["item[6]"] = "Reload NXBs\t\t";

            EditorGui EditorGui = "EditorGui";
            MenuBar menuBar = EditorGui["menuBar"];

            menuBar.insert("PhysicsToolsMenu", menuBar["dynamicItemInsertPos"].AsInt());
            }

        public override void onEditorWake()
            {
            // Disable physics when entering
            // the editor.  Will be re-enabled
            // when the editor is closed.
            Util.physicsStopSimulation("client");
            Util.physicsStopSimulation("server");
            Util.physicsRestoreState();
            }

        public override void onEditorSleep()
            {
            Util.physicsStoreState();

            float currentTimeScale = Util.physicsGetTimeScale();
            if (currentTimeScale == 0.0)
                Util.physicsSetTimeScale(1.0f);

            Util.physicsStartSimulation("client");
            Util.physicsStartSimulation("server");
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PhysicsEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(PhysicsEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(PhysicsEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator PhysicsEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (PhysicsEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (PhysicsEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(PhysicsEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PhysicsEditorPlugin(int simobjectid)
            {
            return (PhysicsEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (PhysicsEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(PhysicsEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PhysicsEditorPlugin(uint simobjectid)
            {
            return (PhysicsEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (PhysicsEditorPlugin));
            }

        #endregion
        }
    }