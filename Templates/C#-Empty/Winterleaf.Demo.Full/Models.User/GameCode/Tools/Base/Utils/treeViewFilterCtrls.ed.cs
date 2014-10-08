using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils
    {
    public class treeViewFilterCtrls
        {
        //---------------------------------------------------------------------------------------------


        //---------------------------------------------------------------------------------------------
        public class GuiTreeViewFilterClearButton : GuiBitmapButtonCtrl
            {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
                {
                this["textCtrl"].call("reset");
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiTreeViewFilterClearButton ts, string simobjectid)
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
            public static bool operator !=(GuiTreeViewFilterClearButton ts, string simobjectid)
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
            public static implicit operator string(GuiTreeViewFilterClearButton ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiTreeViewFilterClearButton(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (GuiTreeViewFilterClearButton)
                        Omni.self.getSimObject(simobjectid, typeof (GuiTreeViewFilterClearButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiTreeViewFilterClearButton ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiTreeViewFilterClearButton(int simobjectid)
                {
                return
                    (GuiTreeViewFilterClearButton)
                        Omni.self.getSimObject((uint) simobjectid, typeof (GuiTreeViewFilterClearButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiTreeViewFilterClearButton ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiTreeViewFilterClearButton(uint simobjectid)
                {
                return
                    (GuiTreeViewFilterClearButton)
                        Omni.self.getSimObject(simobjectid, typeof (GuiTreeViewFilterClearButton));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<GuiTreeViewFilterText>))]
        public class GuiTreeViewFilterText : GuiTextEditCtrl
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                string filter = ((GuiTreeViewCtrl) this["treeView"]).getFilterText();
                if (filter == "")
                    this.setText("Filter...");
                else
                    this.setText(filter);
                }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onGainFirstResponder(string ID)
                {
                this.selectAllText();
                }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            // When Enter is pressed in the filter text control, pass along the text of the control
            // as the treeview's filter.
            public override void onReturn()
                {
                text = this.getText();
                if (text == "")
                    this.reset();
                else
                    ((GuiTreeViewCtrl) this["treeView"]).setFilterText(text);
                }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void reset()
                {
                //TODO /c2
                this.setText("Filter...");
                ((GuiTreeViewCtrl) this["treeView"]).clearFilterText();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiTreeViewFilterText ts, string simobjectid)
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
            public static bool operator !=(GuiTreeViewFilterText ts, string simobjectid)
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
            public static implicit operator string(GuiTreeViewFilterText ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiTreeViewFilterText(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (GuiTreeViewFilterText) Omni.self.getSimObject(simobjectid, typeof (GuiTreeViewFilterText));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiTreeViewFilterText ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiTreeViewFilterText(int simobjectid)
                {
                return
                    (GuiTreeViewFilterText) Omni.self.getSimObject((uint) simobjectid, typeof (GuiTreeViewFilterText));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiTreeViewFilterText ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiTreeViewFilterText(uint simobjectid)
                {
                return (GuiTreeViewFilterText) Omni.self.getSimObject(simobjectid, typeof (GuiTreeViewFilterText));
                }

            #endregion
            }
        }
    }