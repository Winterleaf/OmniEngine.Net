using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.EditorChooseLevelGui.ed.cs
    {
    [TypeConverter(typeof (TypeConverterGeneric<EditorChooseLevelGui>))]
    public class EditorChooseLevelGui : GuiContainer
        {
        public override void onWake()
            {
            // Build the text lists
            GuiMLTextCtrl WE_LevelList = "WE_LevelList";
            GuiMLTextCtrl WE_TemplateList = "WE_TemplateList";
            WE_LevelList.clear();
            WE_TemplateList.clear();
            string leveltext = "<linkcolor:0000FF><linkcolorhl:FF0000>";
            string templatetext = "<linkcolor:0000FF><linkcolorhl:FF0000>";

            string file = Util.findFirstFile(sGlobal["$Server::MissionFileSpec"], true);
            while (file != "")
                {
                string name = console.Call("getLevelDisplayName", new string[] {file});

                string n = name.ToLower();

                if (!n.Contains("template"))
                    {
                    leveltext = leveltext + "<a:gamelink:" + file + ">" + name + "</a><br>";
                    }
                else
                    {
                    templatetext = templatetext + "<a:gamelink:" + file + ">" + name + "</a><br>";
                    }


                file = Util.findNextFile(sGlobal["$Server::MissionFileSpec"]);
                }


            WE_LevelList.setText(leveltext);
            WE_LevelList.forceReflow();
            WE_LevelList.scrollToTop(0, 0);

            WE_TemplateList.setText(templatetext);
            WE_TemplateList.forceReflow();
            WE_TemplateList.scrollToTop(0, 0);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorChooseLevelGui ts, string simobjectid)
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
        public static bool operator !=(EditorChooseLevelGui ts, string simobjectid)
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
        public static implicit operator string(EditorChooseLevelGui ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorChooseLevelGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorChooseLevelGui) Omni.self.getSimObject(simobjectid, typeof (EditorChooseLevelGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorChooseLevelGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorChooseLevelGui(int simobjectid)
            {
            return (EditorChooseLevelGui) Omni.self.getSimObject((uint) simobjectid, typeof (EditorChooseLevelGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorChooseLevelGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorChooseLevelGui(uint simobjectid)
            {
            return (EditorChooseLevelGui) Omni.self.getSimObject(simobjectid, typeof (EditorChooseLevelGui));
            }

        #endregion
        }
    }