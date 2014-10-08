using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.ChooseLevel
    {
    [TypeConverter(typeof (TypeConverterGeneric<ChooseLevelWindow>))]
    public class ChooseLevelWindow : GuiWindowCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public void previewSelected(SimObject preview)
            {
            GuiTextListCtrl CL_levelList = "CL_levelList";
            if (preview.isObject() && preview["levelIndex"] != "")
                CL_levelList.setSelectedRow(preview["levelIndex"].AsInt());
            else
                CL_levelList.setSelectedRow(-1);

            // Set the large preview image
            if (preview.isObject() && preview["bitmap"] != "")
                ((GuiBitmapCtrl) this.findObjectByInternalName("CurrentPreview", false)).setBitmapX(preview["bitmap"]);
            else
                ((GuiBitmapCtrl) this.findObjectByInternalName("CurrentPreview", false)).setBitmapX(
                    "art/gui/no-preview");

            // Set the current level name
            if (preview.isObject() && preview["levelName"] != "")
                ((GuiTextCtrl) this.findObjectByInternalName("LevelName", false)).setText(preview["levelName"]);
            else
                ((GuiTextCtrl) this.findObjectByInternalName("LevelName", false)).setText("Level");

            // Set the current level description
            if (preview.isObject() && preview["levelDesc"] != "")
                ((GuiMLTextCtrl) this.findObjectByInternalName("LevelDescription", false)).setText(
                    preview["levelDesc"]);
            else
                ((GuiMLTextCtrl) this.findObjectByInternalName("LevelDescription", false)).setText("A Torque Level");
            }

        [ConsoleInteraction(true)]
        public void previousPreviews()
            {
            GuiDynamicCtrlArrayControl SmallPreviews =
                ((GuiDynamicCtrlArrayControl)
                    ((GuiWindowCtrl) "ChooseLevelWindow").findObjectByInternalName("SmallPreviews", false));

            int prevHiddenIdx = SmallPreviews["firstVisible"].AsInt() - 1;
            if (prevHiddenIdx < 0)
                return;

            int lastVisibleIdx = SmallPreviews["lastVisible"].AsInt();

            if (lastVisibleIdx >= SmallPreviews.getCount())
                return;

            GuiControl prevHiddenObj = SmallPreviews.getObject((uint) prevHiddenIdx);
            GuiControl lastVisibleObj = SmallPreviews.getObject((uint) lastVisibleIdx);

            if (prevHiddenObj.isObject() && lastVisibleObj.isObject())
                {
                SmallPreviews["firstVisible"] = (SmallPreviews["firstVisible"].AsInt() - 1).AsString();
                SmallPreviews["lastVisible"] = (SmallPreviews["lastVisible"].AsInt() - 1).AsString();

                prevHiddenObj.setVisible(true);
                lastVisibleObj.setVisible(false);
                }
            }

        [ConsoleInteraction(true)]
        public void nextPreviews()
            {
            GuiDynamicCtrlArrayControl SmallPreviews =
                ((GuiDynamicCtrlArrayControl)
                    ((GuiWindowCtrl) "ChooseLevelWindow").findObjectByInternalName("SmallPreviews", false));

            int firstVisibleIdx = SmallPreviews["firstVisible"].AsInt();

            if (firstVisibleIdx < 0)
                return;

            int firstHiddenIdx = (SmallPreviews["lastVisible"].AsInt() + 1);

            if (firstHiddenIdx >= SmallPreviews.getCount())
                return;

            GuiControl firstVisibleObj = SmallPreviews.getObject((uint) firstVisibleIdx);
            GuiControl firstHiddenObj = SmallPreviews.getObject((uint) firstHiddenIdx);

            if (firstVisibleObj.isObject() && firstHiddenObj.isObject())
                {
                SmallPreviews["firstVisible"] = (SmallPreviews["firstVisible"].AsInt() + 1).AsString();
                SmallPreviews["lastVisible"] = (SmallPreviews["lastVisible"].AsInt() + 1).AsString();

                firstVisibleObj.setVisible(false);
                firstHiddenObj.setVisible(true);
                }
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ChooseLevelWindow ts, string simobjectid)
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
        public static bool operator !=(ChooseLevelWindow ts, string simobjectid)
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
        public static implicit operator string(ChooseLevelWindow ts)
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
        public static implicit operator ChooseLevelWindow(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ChooseLevelWindow) Omni.self.getSimObject(simobjectid, typeof (ChooseLevelWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ChooseLevelWindow ts)
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
        public static implicit operator ChooseLevelWindow(int simobjectid)
            {
            return (ChooseLevelWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ChooseLevelWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ChooseLevelWindow ts)
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
        public static implicit operator ChooseLevelWindow(uint simobjectid)
            {
            return (ChooseLevelWindow) Omni.self.getSimObject(simobjectid, typeof (ChooseLevelWindow));
            }

        #endregion
        }
    }