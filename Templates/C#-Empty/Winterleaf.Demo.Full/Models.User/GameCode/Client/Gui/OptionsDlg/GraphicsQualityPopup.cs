using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg
    {
    public class GraphicsQualityPopup : GuiPopUpMenuCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public void init(SimGroup qualityGroup)
            {
            // Clear the existing content first.  
            this.clear();
            // Fill it.
            int select = -1;
            for (uint i = 0; i < qualityGroup.getCount(); i++)
                {
                GraphicsQualityLevel level = qualityGroup.getObject(i);
                if (level.isCurrent())
                    select = (int) i;

                this.add(level.getInternalName(), (int)i);
                }
            // Setup a default selection.
            if (select == -1)
                this.setText("Custom");
            else
                this.setSelected(select);

            //this.setText(select.AsString());
            }

        [ConsoleInteraction(true)]
        public bool apply(SimGroup qualityGroup, bool testNeedApply)
            {
            string quality = getText();
            int index = findText(quality);

            if (index == -1)
                return false;

            GraphicsQualityLevel level = qualityGroup.getObject((uint) index);
            if (level.isObject() && !level.isCurrent())
                {
                if (testNeedApply)
                    return true;
                level.apply();
                }
            return false;
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GraphicsQualityPopup ts, string simobjectid)
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
        public static bool operator !=(GraphicsQualityPopup ts, string simobjectid)
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
        public static implicit operator string(GraphicsQualityPopup ts)
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
        public static implicit operator GraphicsQualityPopup(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (GraphicsQualityPopup) Omni.self.getSimObject(simobjectid, typeof (GraphicsQualityPopup));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GraphicsQualityPopup ts)
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
        public static implicit operator GraphicsQualityPopup(int simobjectid)
            {
            return (GraphicsQualityPopup) Omni.self.getSimObject((uint) simobjectid, typeof (GraphicsQualityPopup));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GraphicsQualityPopup ts)
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
        public static implicit operator GraphicsQualityPopup(uint simobjectid)
            {
            return (GraphicsQualityPopup) Omni.self.getSimObject(simobjectid, typeof (GraphicsQualityPopup));
            }

        #endregion
        }
    }