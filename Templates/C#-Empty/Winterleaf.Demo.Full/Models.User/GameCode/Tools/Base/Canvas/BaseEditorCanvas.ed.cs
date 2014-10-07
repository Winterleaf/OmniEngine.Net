using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.MenuBar;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Canvas
    {
    [TypeConverter(typeof (TypeConverterGeneric<BaseEditorCanvas>))]
    public class BaseEditorCanvas : GuiCanvas
        {
        internal WinterLeaf.Demo.Full.Models.User.Extendable.MenuBar menuBar
            {
            get { return this["menuBar"]; }
            set { this["menuBar"] = value; }
            }

        [ConsoleInteraction]
        public override void onAdd()
            {
            this.createMenuBar();

            ObjectCreator oc = new ObjectCreator("GuiPanel");
            oc["internalName"] = "DocumentContainer";

            GuiPanel panel = oc.Create();

            this.setContent(panel);

            int xOffset = 20;
            int yOffset = 20;

            for (int i = 0; i < 10; i++)
                {
                ObjectCreator oc1 = new ObjectCreator("GuiWindowCtrl");
                oc["extent"] = "200 100";
                oc["position"] = xOffset + ' ' + yOffset;

                GuiWindowCtrl window = oc1.Create();
                panel.add(window);

                xOffset += 30;
                yOffset += 30;
                }
            }

        [ConsoleInteraction]
        public override void onRemove()
            {
            this.destroyMenuBar();
            }

        [ConsoleInteraction]
        public static void testBaseEditor()
            {
            new ObjectCreator("GuiCanvas", "", typeof (BaseEditorCanvas));
            }

        [ConsoleInteraction]
        // onAdd creates the base menu's and document controller
        public void createMenuBar()
            {
            if (this.menuBar.isObject())
                return;

            // Menu bar

            #region MenuBar ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("MenuBar", "");
            oc_Newobject2["dynamicItemInsertPos"] = new ObjectCreator.StringNoQuote("3");

            #region PopupMenu ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("PopupMenu", "basefileEditor", typeof (BaseEditorFileMenu));
            oc_Newobject1["internalName"] = "FileMenu";
            oc_Newobject1["barTitle"] = "File";
            oc_Newobject1["item[0]"] = "New..." + '\t' + "Ctrl N" + '\t' + "basefileEditor.onNew();";
            oc_Newobject1["item[1]"] = "Open..." + '\t' + "Ctrl O" + '\t' + "basefileEditor.onOpen();";
            oc_Newobject1["item[2]"] = "-";
            oc_Newobject1["item[3]"] = "Save" + '\t' + "Ctrl S" + '\t' + "basefileEditor.onSave();";
            oc_Newobject1["item[4]"] = "Save As" + '\t' + "Ctrl-Alt S" + '\t' + "basefileEditor.onSaveAs();";
            oc_Newobject1["item[5]"] = "Save All" + '\t' + "Ctrl-Shift S" + '\t' + "basefileEditor.onSaveAll();";
            oc_Newobject1["item[6]"] = "-";
            oc_Newobject1["item[7]"] = "Import..." + '\t' + "Ctrl-Shift I" + '\t' + "basefileEditor.onImport();";
            oc_Newobject1["item[8]"] = "Export..." + '\t' + "Ctrl-Shift E" + '\t' + "basefileEditor.onExport();";
            oc_Newobject1["item[9]"] = "-";
            oc_Newobject1["item[10]"] = "Revert" + '\t' + "Ctrl R" + '\t' + "basefileEditor.onRevert();";
            oc_Newobject1["item[11]"] = "-";
            oc_Newobject1["item[12]"] = "Close" + '\t' + "Ctrl W" + '\t' + "basefileEditor.onClose();";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            this.menuBar = oc_Newobject2.Create();
            }

        [ConsoleInteraction]
        public void destroyMenuBar()
            {
            if (this.menuBar.isObject())
                this.menuBar.delete();
            }

        [ConsoleInteraction]
        public override void onCreateMenu()
            {
            if (!this.menuBar.isObject())
                this.createMenuBar();

            this.menuBar.attachToCanvas(this, 0);
            }

        [ConsoleInteraction]
        public override void onDestroyMenu()
            {
            if (this.menuBar.isObject())
                {
                this.destroyMenuBar();
                this.menuBar.removeFromCanvas();
                }
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(BaseEditorCanvas ts, string simobjectid)
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
        public static bool operator !=(BaseEditorCanvas ts, string simobjectid)
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
        public static implicit operator string(BaseEditorCanvas ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator BaseEditorCanvas(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (BaseEditorCanvas) Omni.self.getSimObject(simobjectid, typeof (BaseEditorCanvas));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(BaseEditorCanvas ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator BaseEditorCanvas(int simobjectid)
            {
            return (BaseEditorCanvas) Omni.self.getSimObject((uint) simobjectid, typeof (BaseEditorCanvas));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(BaseEditorCanvas ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator BaseEditorCanvas(uint simobjectid)
            {
            return (BaseEditorCanvas) Omni.self.getSimObject(simobjectid, typeof (BaseEditorCanvas));
            }

        #endregion
        }
    }