using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    [TypeConverter(typeof (TypeConverterGeneric<MainChatHud>))]
    public class MainChatHud : GuiControl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onWake()
            {
            // set the chat hud to the users pref
            setChatHudLength(iGlobal["$Pref::ChatHudLength"]);
            }

        public void setChatHudLength(int length)
            {
            int textheight = iGlobal["ChatHud.Profile.fontSize"] + iGlobal["ChatHud.lineSpacing"];
            if (textheight <= 0)
                textheight = 12;

            int lengthInPixels = iGlobal["$outerChatLenY[" + length + "]"]*textheight;

            GuiBitmapBorderCtrl OuterChatHud = "OuterChatHud";
            GuiScrollCtrl ChatScrollHud = "ChatScrollHud";
            int chatMargin = OuterChatHud.extent.y - ChatScrollHud.extent.y + 2*ChatScrollHud.profile.borderThickness;
            OuterChatHud.setExtent(new Point2F( OuterChatHud.extent.x, (lengthInPixels + chatMargin)));
            ChatScrollHud.scrollToBottom();
            ((GuiControl) "ChatPageDown").setVisible(false);
            }

        public void nextChatHudLen()
            {
            int len = iGlobal["$pref::ChatHudLength"];
            len++;
            if (len == 4)
                len = 1;
            setChatHudLength(len);
            iGlobal["$pref::ChatHudLength"] = len;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MainChatHud ts, string simobjectid)
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
        public static bool operator !=(MainChatHud ts, string simobjectid)
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
        public static implicit operator string(MainChatHud ts)
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
        public static implicit operator MainChatHud(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (MainChatHud) Omni.self.getSimObject(simobjectid, typeof (MainChatHud));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MainChatHud ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MainChatHud(int simobjectid)
            {
            return (MainChatHud) Omni.self.getSimObject((uint) simobjectid, typeof (MainChatHud));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MainChatHud ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MainChatHud(uint simobjectid)
            {
            return (MainChatHud) Omni.self.getSimObject(simobjectid, typeof (MainChatHud));
            }

        #endregion
        }
    }