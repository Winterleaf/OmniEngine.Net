using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<ESnapOptions>))]
    public class ESnapOptions : GuiWindowCollapseCtrl
        {
        public override void onWake()
            {
            GuiTabPageCtrl ESnapOptionsTabTerrain = "ESnapOptionsTabTerrain";
            GuiTabPageCtrl ESnapOptionsTabSoft = "ESnapOptionsTabSoft";
            ((GuiRadioCtrl) ESnapOptionsTabTerrain.findObjectByInternalName("NoAlignment", true)).setStateOn(true);

            ((GuiRadioCtrl) ESnapOptionsTabSoft.findObjectByInternalName("NoAlignment", true)).setStateOn(true);

            ((GuiCheckBoxCtrl) ESnapOptionsTabSoft.findObjectByInternalName("RenderSnapBounds", true)).setStateOn(true);

            ((GuiTextEditCtrl) ESnapOptionsTabSoft.findObjectByInternalName("SnapBackfaceTolerance", true)).
                setText(((EWorldEditor) "EWorldEditor").getSoftSnapBackfaceTolerance().AsString());
            }

        [ConsoleInteraction]
        public void hideDialog()
            {
            setVisible(false);
            ((GuiBitmapButtonCtrl) ((GuiControl) "SnapToBar").findObjectByInternalName("snappingSettingsBtn", true))
                .setStateOn(false);
            }

        [ConsoleInteraction]
        public void ToggleVisibility()
            {
            if (this.visible)
                {
                setVisible(false);
                ((GuiBitmapButtonCtrl)
                    ((GuiControl) "SnapToBar").findObjectByInternalName("snappingSettingsBtn", true)).setStateOn(false);
                }
            else
                {
                setVisible(true);
                selectWindow();
                setCollapseGroup(false);
                ((GuiBitmapButtonCtrl)
                    ((GuiControl) "SnapToBar").findObjectByInternalName("snappingSettingsBtn", true)).setStateOn(true);
                }
            }

        [ConsoleInteraction]
        public void setTerrainSnapAlignment(TypeWorldEditorAlignmentType val)
            {
            ((EWorldEditor) "EWorldEditor").setTerrainSnapAlignment(val);
            }

        [ConsoleInteraction]
        public void setSoftSnapAlignment(TypeWorldEditorAlignmentType val)
            {
            ((EWorldEditor) "EWorldEditor").setSoftSnapAlignment(val);
            }

        [ConsoleInteraction]
        public void setSoftSnapSize()
            {
            string val = ((GuiTextEditCtrl) this.findObjectByInternalName("SnapSize", true)).getText();
            ((EWorldEditor) "EWorldEditor").setSoftSnapSize(val.AsFloat());
            ((EWorldEditor) "EWorldEditor").syncGui();
            }

        [ConsoleInteraction]
        public void setGridSnapSize()
            {
            string val = ((GuiTextEditCtrl) this.findObjectByInternalName("GridSize", true)).getText();
            ((EWorldEditor) "EWorldEditor").setGridSize(val);
            }

        [ConsoleInteraction]
        public void toggleRenderSnapBounds()
            {
            GuiTabPageCtrl ESnapOptionsTabSoft = "ESnapOptionsTabSoft";
            ((EWorldEditor) "EWorldEditor").softSnapRender(
                ((GuiCheckBoxCtrl) ESnapOptionsTabSoft.findObjectByInternalName("RenderSnapBounds", true)).getValue().AsBool());
            }

        [ConsoleInteraction]
        public void toggleRenderSnappedTriangle()
            {
            GuiTabPageCtrl ESnapOptionsTabSoft = "ESnapOptionsTabSoft";
            ((WinterLeaf.Demo.Full.Models.User.Extendable.WorldEditor) "EWorldEditor").softSnapRender(
                ((GuiCheckBoxCtrl) ESnapOptionsTabSoft.findObjectByInternalName("RenderSnappedTriangle", true))
                    .getValue().AsBool());
            }

        [ConsoleInteraction]
        public void getSoftSnapBackfaceTolerance()
            {
            string val = ((GuiTextEditCtrl) this.findObjectByInternalName("SnapBackfaceTolerance", true)).getText();
            ((EWorldEditor) "EWorldEditor").setSoftSnapBackfaceTolerance(val.AsFloat());
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ESnapOptions ts, string simobjectid)
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
        public static bool operator !=(ESnapOptions ts, string simobjectid)
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
        public static implicit operator string(ESnapOptions ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ESnapOptions(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ESnapOptions) Omni.self.getSimObject(simobjectid, typeof (ESnapOptions));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ESnapOptions ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ESnapOptions(int simobjectid)
            {
            return (ESnapOptions) Omni.self.getSimObject((uint) simobjectid, typeof (ESnapOptions));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ESnapOptions ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ESnapOptions(uint simobjectid)
            {
            return (ESnapOptions) Omni.self.getSimObject(simobjectid, typeof (ESnapOptions));
            }

        #endregion
        }
    }