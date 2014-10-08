using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups
    {
    [TypeConverter(typeof (TypeConverterGeneric<EWToolsPaletteWindow>))]
    public class EWToolsPaletteWindow : GuiWindowCtrl
        {
        public void LoadControls(GuiControl obj, int paletteGroup)
            {
            GuiDynamicCtrlArrayControl ToolsPaletteArray = "ToolsPaletteArray";
            for (int i = obj.getCount(); i != 0; i--)
                {
                ((GuiControl) obj.getObject(0)).visible = false;
                ((GuiControl) obj.getObject(0))["groupNum"] = paletteGroup.AsString();
                ((GuiControl) obj.getObject(0))["paletteName"] = obj.getName();
                ToolsPaletteArray.addGuiControl(obj.getObject(0));
                }
            }

        [ConsoleInteraction]
        public void loadToolsPalettes()
            {
            int paletteGroup = 0;
            LoadControls(ConvexEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(DecalEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(ForestEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(MeshRoadEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(RiverEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(RoadEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(ShapeEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(TerrainEditPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(TerrainPainterPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(WorldEditorPalette.initialize(), paletteGroup);
            paletteGroup++;
            LoadControls(NavEditorPalette.initialize(), paletteGroup);
            }

        [ConsoleInteraction]
        public void init()
            {
            loadToolsPalettes();
            }

        [ConsoleInteraction]
        public void togglePalette(string paletteName)
            {
            GuiDynamicCtrlArrayControl ToolsPaletteArray = "ToolsPaletteArray";
            EWToolsPaletteWindow EWToolsPaletteWindow = "EWToolsPaletteWindow";
            // since the palette window ctrl auto adjusts to child ctrls being visible,
            // loop through the array and pick out the children that belong to a certain tool
            // and label them visible or not visible

            for (uint i = 0; i < ToolsPaletteArray.getCount(); i++)
                ((GuiControl) ToolsPaletteArray.getObject(i)).visible = false;

            int windowMultiplier = 0;

            int paletteNameWordCount = Util.getWordCount(paletteName);

            for (int palatteNum = 0; palatteNum < paletteNameWordCount; palatteNum++)
                {
                string currentPalette = Util.getWord(paletteName, palatteNum);

                for (uint i = 0; i < ToolsPaletteArray.getCount(); i++)
                    {
                    if (((GuiControl) ToolsPaletteArray.getObject(i))["paletteName"] == currentPalette)
                        {
                        ((GuiControl) ToolsPaletteArray.getObject(i)).visible = true;
                        windowMultiplier++;
                        }
                    }
                }
            // auto adjust the palette window extent according to how many 
            // children controls we found; if none found, the palette window becomes invisible
            if (windowMultiplier == 0 || paletteName == "")
                EWToolsPaletteWindow.visible = false;
            else
                {
                EWToolsPaletteWindow.visible = true;
                EWToolsPaletteWindow.extent = new Point2I(EWToolsPaletteWindow.extent.x, (16 + 26*windowMultiplier));
                }
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EWToolsPaletteWindow ts, string simobjectid)
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
        public static bool operator !=(EWToolsPaletteWindow ts, string simobjectid)
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
        public static implicit operator string(EWToolsPaletteWindow ts)
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
        public static implicit operator EWToolsPaletteWindow(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EWToolsPaletteWindow) Omni.self.getSimObject(simobjectid, typeof (EWToolsPaletteWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EWToolsPaletteWindow ts)
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
        public static implicit operator EWToolsPaletteWindow(int simobjectid)
            {
            return (EWToolsPaletteWindow) Omni.self.getSimObject((uint) simobjectid, typeof (EWToolsPaletteWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EWToolsPaletteWindow ts)
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
        public static implicit operator EWToolsPaletteWindow(uint simobjectid)
            {
            return (EWToolsPaletteWindow) Omni.self.getSimObject(simobjectid, typeof (EWToolsPaletteWindow));
            }

        #endregion
        }
    }