using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    [TypeConverter(typeof(TypeConverterGeneric<hudlessGui>))]
    public class hudlessGui : GameTSCtrl
        {
        public static void initialize()
            {
            #region GameTSCtrl (HudlessPlayGui)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GameTSCtrl", "HudlessPlayGui", typeof(hudlessGui));
            oc_Newobject1["canSaveDynamicFields"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "GuiContentProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "0 0";
            oc_Newobject1["Extent"] = "1024 768";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["cameraZRot"] = "0";
            oc_Newobject1["forceFOV"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["noCursor"] = "1";

            #endregion

            oc_Newobject1.Create();
            }

        [ConsoleInteraction]
        public override void onWake()
        {
            ActionMap moveMap = "moveMap";
            // just update the action map here
            moveMap.push();
        }

        [ConsoleInteraction]
        public override void onSleep()
        {
            ActionMap moveMap = "moveMap";
            // pop the keymaps
            moveMap.pop();
        }

        [ConsoleInteraction]
        public void toggle()
        {
            canvas Canvas = "Canvas";
            if (isAwake())
                Canvas.setContent("PlayGui");
            else
                Canvas.setContent("HudlessPlayGui");
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==( hudlessGui ts, string simobjectid)
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
        public static bool operator !=( hudlessGui ts, string simobjectid)
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
        public static implicit operator string( hudlessGui ts)
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
        public static implicit operator  hudlessGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return ( hudlessGui) Omni.self.getSimObject(simobjectid, typeof ( hudlessGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( hudlessGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator  hudlessGui(int simobjectid)
            {
            return ( hudlessGui) Omni.self.getSimObject((uint) simobjectid, typeof ( hudlessGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( hudlessGui ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator  hudlessGui(uint simobjectid)
            {
            return ( hudlessGui) Omni.self.getSimObject(simobjectid, typeof ( hudlessGui));
            }

        #endregion
        }
    }