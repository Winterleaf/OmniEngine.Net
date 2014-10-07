using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils
    {
    [TypeConverter(typeof (UndoActionReparentObjects))]
    public class UndoActionReparentObjects : UndoScriptAction
        {
        

        public int numObjects
            {
            get { return this["numObjects"].AsInt(); }
            set { this["numObjects"] = value.AsString(); }
            }

        [ConsoleInteraction]
        public string create(string treeView)
            {
            omni.Util.pushInstantGroup();
            ObjectCreator undoObject = new ObjectCreator("UndoScriptAction", "", typeof (UndoActionReparentObjects));
            //undoObject["class"] = "UndoActionReparentObjects";
            undoObject["numObjects"] = "0";
            undoObject["treeView"] = treeView;
            UndoActionReparentObjects action = undoObject.Create();
            omni.Util.popInstantGroup();

            return action;
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void add(SimObject objectx, string oldParent, string newParent)
            {
            int index = this.numObjects;

            this["objects[" + index + "]"] = objectx;
            this["oldParents[" + index + "]"] = oldParent;
            this["newParents[" + index + "]"] = newParent;

            this.numObjects = this.numObjects + 1;
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void undo()
            {
            int numObjects = this.numObjects;
            for (int i = 0; i < numObjects; i ++)
                {
                SimObject obj = this["objects[" + i + "]"];
                SimObject group = this["oldParents[" + i + "]"];

                if (obj.isObject() && group.isObject())
                    obj.parentGroup = group;
                }

            if (this["treeView"].isObject())
                this["treeView"].call("update");
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void redo()
            {
            int numObjects = this.numObjects;
            for (int i = 0; i < numObjects; i ++)
                {
                SimObject obj = this["objects[" + i + "]"];
                SimObject group = this["newParents[" + i + "]"];

                if (obj.isObject() && group.isObject())
                    obj.parentGroup = group;
                }

            if (this["treeView"].isObject())
                this["treeView"].call("update");
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(UndoActionReparentObjects ts, string simobjectid)
            {
            return ReferenceEquals(ts, null)
                ? ReferenceEquals(simobjectid, null)
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
        public static bool operator !=(UndoActionReparentObjects ts, string simobjectid)
            {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(UndoActionReparentObjects ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator UndoActionReparentObjects(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (UndoActionReparentObjects) Omni.self.getSimObject(simobjectid, typeof (UndoActionReparentObjects));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(UndoActionReparentObjects ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator UndoActionReparentObjects(int simobjectid)
            {
            return
                (UndoActionReparentObjects)
                    Omni.self.getSimObject((uint) simobjectid, typeof (UndoActionReparentObjects));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(UndoActionReparentObjects ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator UndoActionReparentObjects(uint simobjectid)
            {
            return (UndoActionReparentObjects) Omni.self.getSimObject(simobjectid, typeof (UndoActionReparentObjects));
            }

        #endregion
        }
    }