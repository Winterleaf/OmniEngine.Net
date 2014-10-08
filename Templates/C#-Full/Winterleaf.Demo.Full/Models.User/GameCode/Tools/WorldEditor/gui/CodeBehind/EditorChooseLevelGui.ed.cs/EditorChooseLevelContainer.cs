using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.EditorChooseLevelGui.ed.cs
    {
    [TypeConverter(typeof (TypeConverterGeneric<EditorChooseLevelContainer>))]
    public class EditorChooseLevelContainer : GuiContainer
        {
        public override void onWake()
            {
            // first check if we have a level file to load, then we'll bypass this
            if (sGlobal["$levelToLoad"] != "")
                {
                // First try using the file path raw... it may already be good.
                string file = Util.findFirstFile(sGlobal["$levelToLoad"], true);
                if (file == "")
                    {
                    string levelFile = "levels/";
                    string ext = Util.getSubStr(sGlobal["$levelToLoad"], Util.strlen(sGlobal["$levelToLoad"]) - 3, 3);
                    if (ext != "mis")
                        levelFile = levelFile + sGlobal["$levelToLoad"] + ".mis";
                    else
                        levelFile = levelFile + sGlobal["$levelToLoad"];

                    // let's make sure the file exists
                    file = Util.findFirstFile(levelFile, true);
                    }

                // Clear out the $levelToLoad so we don't attempt to load the level again
                // later on.
                sGlobal["$levelToLoad"] = "";
                if (file != "")
                    {
                    Util._call("WE_EditLevel", file);
                    return;
                    }
                }
            //If no valid name, then push the level chooser
            ((GuiCanvas) "Canvas").pushDialog("EditorChooseLevelContainer");
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorChooseLevelContainer ts, string simobjectid)
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
        public static bool operator !=(EditorChooseLevelContainer ts, string simobjectid)
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
        public static implicit operator string(EditorChooseLevelContainer ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorChooseLevelContainer(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorChooseLevelContainer) Omni.self.getSimObject(simobjectid, typeof (EditorChooseLevelContainer));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorChooseLevelContainer ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorChooseLevelContainer(int simobjectid)
            {
            return
                (EditorChooseLevelContainer)
                    Omni.self.getSimObject((uint) simobjectid, typeof (EditorChooseLevelContainer));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorChooseLevelContainer ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorChooseLevelContainer(uint simobjectid)
            {
            return (EditorChooseLevelContainer) Omni.self.getSimObject(simobjectid, typeof (EditorChooseLevelContainer));
            }

        #endregion
        }
    }