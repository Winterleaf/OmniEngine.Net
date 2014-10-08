using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.physicsTools
    {
    [TypeConverter(typeof (TypeConverterGeneric<PhysicsToolsMenu>))]
    public class PhysicsToolsMenu : MenuBuilder
        {
        

        public override void onMenuSelect()
            {
            bool isEnabled = omni.Util.physicsSimulationEnabled();

            string itemText = !isEnabled ? "Start Simulation" : "Pause Simulation";
            string itemCommand = !isEnabled
                ? "physicsStartSimulation( \"client\" );physicsStartSimulation( \"server\" );"
                : "physicsStopSimulation( \"client\" );physicsStopSimulation( \"server\" );";

            this.setItemName(0, itemText);
            this.setItemCommand("0", itemCommand);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PhysicsToolsMenu ts, string simobjectid)
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
        public static bool operator !=(PhysicsToolsMenu ts, string simobjectid)
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
        public static implicit operator string(PhysicsToolsMenu ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator PhysicsToolsMenu(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (PhysicsToolsMenu) Omni.self.getSimObject(simobjectid, typeof (PhysicsToolsMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(PhysicsToolsMenu ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PhysicsToolsMenu(int simobjectid)
            {
            return (PhysicsToolsMenu) Omni.self.getSimObject((uint) simobjectid, typeof (PhysicsToolsMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(PhysicsToolsMenu ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PhysicsToolsMenu(uint simobjectid)
            {
            return (PhysicsToolsMenu) Omni.self.getSimObject(simobjectid, typeof (PhysicsToolsMenu));
            }

        #endregion
        }
    }