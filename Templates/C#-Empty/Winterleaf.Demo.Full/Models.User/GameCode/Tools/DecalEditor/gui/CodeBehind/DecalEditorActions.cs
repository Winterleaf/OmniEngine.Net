using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DecalEditor.gui.CodeBehind
    {
    public class DecalEditorActions
        {
        [TypeConverter(typeof (TypeConverterGeneric<ActionEditNodeDetails>))]
        public class ActionEditNodeDetails : BaseDecalEdAction
            {
            [ConsoleInteraction]
            public override bool doit()
                {
                DecalEditorGui DecalEditorGui = "DecalEditorGui";

                int count = Util.getWordCount(this["newTransformData"]);
                if (this["instanceId"] != "" && count == 7)
                    {
                    string[] data = this["newTransformData"].Split(' ');
                    Point3F pos = new Point3F(data[0].AsFloat(),data[1].AsFloat(),data[2].AsFloat());
                    Point3F tan = new Point3F(data[3].AsFloat(), data[4].AsFloat(), data[5].AsFloat());
                    float size = data[6].AsFloat();

                    DecalEditorGui.editDecalDetails(this["instanceId"].AsUint(),pos,tan,size);
                    DecalEditorGui.syncNodeDetails();
                    DecalEditorGui.selectDecal(this["instanceId"].AsUInt());
                    return true;
                    }
                return false;
                }

            [ConsoleInteraction]
            public override void undo()
                {
                DecalEditorGui DecalEditorGui = "DecalEditorGui";

                int count = Util.getWordCount(this["oldTransformData"]);
                if (this["instanceId"] != "" && count == 7)
                    {
                    string[] data = this["newTransformData"].Split(' ');
                    Point3F pos = new Point3F(data[0].AsFloat(), data[1].AsFloat(), data[2].AsFloat());
                    Point3F tan = new Point3F(data[3].AsFloat(), data[4].AsFloat(), data[5].AsFloat());
                    float size = data[6].AsFloat();

                    DecalEditorGui.editDecalDetails(this["instanceId"].AsUint(), pos,tan,size);
                    DecalEditorGui.syncNodeDetails();
                    DecalEditorGui.selectDecal(this["instanceId"].AsUint());
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditNodeDetails ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ActionEditNodeDetails ts, string simobjectid)
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
            public static implicit operator string(ActionEditNodeDetails ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditNodeDetails(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ActionEditNodeDetails) Omni.self.getSimObject(simobjectid, typeof (ActionEditNodeDetails));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditNodeDetails ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditNodeDetails(int simobjectid)
                {
                return
                    (ActionEditNodeDetails) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditNodeDetails));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditNodeDetails ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditNodeDetails(uint simobjectid)
                {
                return (ActionEditNodeDetails) Omni.self.getSimObject(simobjectid, typeof (ActionEditNodeDetails));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<BaseDecalEdAction>))]
        public class BaseDecalEdAction : UndoScriptAction
            {
            [ConsoleInteraction]
            public virtual bool doit()
                {
                return false;
                }

            [ConsoleInteraction]
            public override void redo()
                {
                // Default redo action is the same as the doit action
                this.doit();
                }

            [ConsoleInteraction]
            public override void undo()
                {
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(BaseDecalEdAction ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(BaseDecalEdAction ts, string simobjectid)
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
            public static implicit operator string(BaseDecalEdAction ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator BaseDecalEdAction(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (BaseDecalEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseDecalEdAction));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(BaseDecalEdAction ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator BaseDecalEdAction(int simobjectid)
                {
                return (BaseDecalEdAction) Omni.self.getSimObject((uint) simobjectid, typeof (BaseDecalEdAction));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(BaseDecalEdAction ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator BaseDecalEdAction(uint simobjectid)
                {
                return (BaseDecalEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseDecalEdAction));
                }

            #endregion
            }
        }
    }