using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditorContentList>))]
    public class GuiEditorContentList : GuiPopUpMenuCtrl
        {
        

        [ConsoleInteraction(true, "GuiEditorContentList_initialize")]
        public static void initialize()
            {
            if (!omni.Util.isDefined("$GuiEditor::GuiFilterList"))
                {
                /// List of named controls that are filtered out from the
                /// control list dropdown.
                omni.sGlobal["$GuiEditor::GuiFilterList"] =
                    "GuiEditorGui" + '\t' +
                    "AL_ShadowVizOverlayCtrl" + '\t' +
                    "MessageBoxOKDlg" + '\t' +
                    "MessageBoxOKCancelDlg" + '\t' +
                    "MessageBoxOKCancelDetailsDlg" + '\t' +
                    "MessageBoxYesNoDlg" + '\t' +
                    "MessageBoxYesNoCancelDlg" + '\t' +
                    "MessagePopupDlg";
                }
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void init()
            {
            SimSet GuiGroup = "GuiGroup";

            this.clear();
            this.scanGroup(GuiGroup);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void scanGroup(SimSet group)
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            for (uint i = 0; i < group.getCount(); i++)
                {
                SimObject obj = group.getObject(i);
                if (obj.isMemberOfClass("GuiControl"))
                    {
                    if (obj.getClassName() == "GuiCanvas")
                        {
                        this.scanGroup((GuiCanvas) obj);
                        }
                    else
                        {
                        string name;
                        if (obj.getName() == "")
                            name = "(unnamed) - " + obj;
                        else
                            name = obj.getName() + " - " + obj;

                        bool skip = false;

                        foreach (string guiEntry in sGlobal["$GuiEditor::GuiFilterList"].Split('\t'))
                            if (obj.getName() == guiEntry)
                                {
                                skip = true;
                                break;
                                }

                        if (!skip)
                            this.add(name, obj);
                        }
                    }
                else if (obj.isMemberOfClass("SimGroup")
                         &&
                         ( //(%obj.internalName !$= "EditorGuiGroup" /* Copyright (C) 2013 WinterLeaf Entertainment LLC. */&& %obj.internalName !$= "IngameGuiGroup" )   // Don't put our editor's GUIs in the list
                             /*||*/ GuiEditor["showEditorGuis"].AsBool())) // except if explicitly requested.
                    {
                    // Scan nested SimGroups for GuiControls.

                    this.scanGroup((SimGroup) obj);
                    }
                }
            }

        //=============================================================================================
        //    Event Handlers.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onSelect(string ctrl, string text)
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            GuiEditor.openForEditing(ctrl);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEditorContentList ts, string simobjectid)
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
        public static bool operator !=(GuiEditorContentList ts, string simobjectid)
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
        public static implicit operator string(GuiEditorContentList ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorContentList(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (GuiEditorContentList) Omni.self.getSimObject(simobjectid, typeof (GuiEditorContentList));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditorContentList ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorContentList(int simobjectid)
            {
            return (GuiEditorContentList) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorContentList));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditorContentList ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditorContentList(uint simobjectid)
            {
            return (GuiEditorContentList) Omni.self.getSimObject(simobjectid, typeof (GuiEditorContentList));
            }

        #endregion
        }
    }