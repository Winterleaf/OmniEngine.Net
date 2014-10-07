using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui
{
    [TypeConverter(typeof(TypeConverterGeneric<NavEditorAboutDlg>))]
    public class NavEditorAboutDlg : GuiControl
    {
        public static void initialize()
        {
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
            {

                #region GuiControl (NavEditorAboutDlg)        oc_Newobject00003
                oc_Newobject00003 = new ObjectCreator("GuiControl", "NavEditorAboutDlg", typeof(NavEditorAboutDlg));
                oc_Newobject00003["position"] = "0 0";
                oc_Newobject00003["extent"] = "1024 768";
                oc_Newobject00003["minExtent"] = "8 2";
                oc_Newobject00003["horizSizing"] = "right";
                oc_Newobject00003["vertSizing"] = "bottom";
                oc_Newobject00003["profile"] = "GuiOverlayProfile";
                oc_Newobject00003["visible"] = "1";
                oc_Newobject00003["active"] = "1";
                oc_Newobject00003["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject00003["hovertime"] = "1000";
                oc_Newobject00003["isContainer"] = "1";
                oc_Newobject00003["canSave"] = "1";
                oc_Newobject00003["canSaveDynamicFields"] = "1";
                oc_Newobject00003["fileName"] = "./about.hfl";
                if (true)
                {

                    #region GuiWindowCtrl ()        oc_Newobject00002
                    oc_Newobject00002 = new ObjectCreator("GuiWindowCtrl", "");
                    oc_Newobject00002["text"] = "About";
                    oc_Newobject00002["resizeWidth"] = "0";
                    oc_Newobject00002["resizeHeight"] = "0";
                    oc_Newobject00002["canMove"] = "1";
                    oc_Newobject00002["canClose"] = "1";
                    oc_Newobject00002["canMinimize"] = "0";
                    oc_Newobject00002["canMaximize"] = "0";
                    oc_Newobject00002["canCollapse"] = "0";
                    oc_Newobject00002["closeCommand"] = "Canvas.popDialog(NavEditorAboutDlg);";
                    oc_Newobject00002["edgeSnap"] = "1";
                    oc_Newobject00002["margin"] = "0 0 0 0";
                    oc_Newobject00002["padding"] = "0 0 0 0";
                    oc_Newobject00002["anchorTop"] = "1";
                    oc_Newobject00002["anchorBottom"] = "0";
                    oc_Newobject00002["anchorLeft"] = "1";
                    oc_Newobject00002["anchorRight"] = "0";
                    oc_Newobject00002["position"] = "270 150";
                    oc_Newobject00002["extent"] = "320 240";
                    oc_Newobject00002["minExtent"] = "8 2";
                    oc_Newobject00002["horizSizing"] = "right";
                    oc_Newobject00002["vertSizing"] = "bottom";
                    oc_Newobject00002["profile"] = "GuiWindowProfile";
                    oc_Newobject00002["visible"] = "1";
                    oc_Newobject00002["active"] = "1";
                    oc_Newobject00002["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00002["hovertime"] = "1000";
                    oc_Newobject00002["isContainer"] = "1";
                    oc_Newobject00002["canSave"] = "1";
                    oc_Newobject00002["canSaveDynamicFields"] = "0";
                    if (true)
                    {

                        #region GuiMLTextCtrl ()        oc_Newobject00001
                        oc_Newobject00001 = new ObjectCreator("GuiMLTextCtrl", "");
                        oc_Newobject00001["lineSpacing"] = "2";
                        oc_Newobject00001["allowColorChars"] = "0";
                        oc_Newobject00001["maxChars"] = "-1";
                        oc_Newobject00001["useURLMouseCursor"] = "0";
                        oc_Newobject00001["position"] = "10 25";
                        oc_Newobject00001["extent"] = "300 178";
                        oc_Newobject00001["minExtent"] = "8 2";
                        oc_Newobject00001["horizSizing"] = "right";
                        oc_Newobject00001["vertSizing"] = "bottom";
                        oc_Newobject00001["profile"] = "GuiMLTextProfile";
                        oc_Newobject00001["visible"] = "1";
                        oc_Newobject00001["active"] = "1";
                        oc_Newobject00001["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00001["hovertime"] = "1000";
                        oc_Newobject00001["isContainer"] = "0";
                        oc_Newobject00001["internalName"] = "TextBox";
                        oc_Newobject00001["canSave"] = "1";
                        oc_Newobject00001["canSaveDynamicFields"] = "0";
                        #endregion

                        oc_Newobject00002["#Newobject00001"] = oc_Newobject00001;

                    }
                    #endregion

                    oc_Newobject00003["#Newobject00002"] = oc_Newobject00002;

                }
                #endregion
                oc_Newobject00003.Create();

            }
        }

        [ConsoleInteraction]
        public override void onWake()
        {
            string text = "";
            FileObject f = new ObjectCreator("FileObject").Create();
            f.openForRead(this["fileName"]);
            while(!f.isEOF())
                text = text + f.readLine() + "\n";
            f.delete();

            ((GuiMLTextCtrl)FOT("TextBox")).setText(text);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==( NavEditorAboutDlg ts, string simobjectid)
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
        public static bool operator !=( NavEditorAboutDlg ts, string simobjectid)
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
        public static implicit operator string( NavEditorAboutDlg ts)
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
        public static implicit operator  NavEditorAboutDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return ( NavEditorAboutDlg) Omni.self.getSimObject(simobjectid, typeof ( NavEditorAboutDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( NavEditorAboutDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator  NavEditorAboutDlg(int simobjectid)
            {
            return ( NavEditorAboutDlg) Omni.self.getSimObject((uint) simobjectid, typeof ( NavEditorAboutDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( NavEditorAboutDlg ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator  NavEditorAboutDlg(uint simobjectid)
            {
            return ( NavEditorAboutDlg) Omni.self.getSimObject(simobjectid, typeof ( NavEditorAboutDlg));
            }

        #endregion          
    }
}
