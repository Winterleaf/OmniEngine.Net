using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils
    {
    [TypeConverter(typeof (TypeConverterGeneric<EditorInspectorBase>))]
    public class EditorInspectorBase : GuiInspector
        {
        [ConsoleInteraction]
        public override void onAdd()
            {
            MenuBuilder EditorInspectorBaseDatablockFieldPopup = "EditorInspectorBaseDatablockFieldPopup";
            MenuBuilder EditorInspectorBaseFieldPopup = "EditorInspectorBaseFieldPopup";
            MenuBuilder EditorInspectorBaseFileFieldPopup = "EditorInspectorBaseFileFieldPopup";
            MenuBuilder EditorInspectorBaseShapeFieldPopup = "EditorInspectorBaseShapeFieldPopup";
            MenuBuilder EditorInspectorBaseProfileFieldPopup = "EditorInspectorBaseProfileFieldPopup";

            if (!EditorInspectorBaseDatablockFieldPopup.isObject())
                {
                #region PopupMenu ( EditorInspectorBaseDatablockFieldPopup )        oc_Newobject1

                ObjectCreator oc_Newobject1 = new ObjectCreator("PopupMenu", "EditorInspectorBaseDatablockFieldPopup",
                    typeof (MenuBuilder));
                oc_Newobject1["isPopup"] = new ObjectCreator.StringNoQuote("true");
                oc_Newobject1["item[0]"] = "Edit Datablock" + '\t' + "" + '\t' +
                                           "DatablockEditorPlugin.openDatablock( EditorInspectorBaseDatablockFieldPopup.inspectorField.getData() );";
                oc_Newobject1["Item[1]"] = "Jump to Definition in Torsion" + '\t' + "" + '\t' +
                                           "EditorOpenDeclarationInTorsion( EditorInspectorBaseDatablockFieldPopup.inspectorField.getData() );";
                oc_Newobject1["item[2]"] = "-";
                oc_Newobject1["item[3]"] = "Copy Value" + '\t' + "" + '\t' +
                                           "setClipboard( EditorInspectorBaseDatablockFieldPopup.inspectorField.getData() );";
                oc_Newobject1["item[4]"] = "Paste Value" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseDatablockFieldPopup.inspectorField.apply( getClipboard() );";
                oc_Newobject1["item[5]"] = "Reset to Default" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseDatablockFieldPopup.inspectorField.reset();";
                oc_Newobject1["inspectorField"] = new ObjectCreator.StringNoQuote("-1");

                #endregion

                oc_Newobject1.Create();
                }

            if (!EditorInspectorBaseFieldPopup.isObject())
                {
                #region PopupMenu ( EditorInspectorBaseFieldPopup )        oc_Newobject1

                ObjectCreator oc_Newobject1 = new ObjectCreator("PopupMenu", "EditorInspectorBaseFieldPopup",
                    typeof (MenuBuilder));
                oc_Newobject1["isPopup"] = new ObjectCreator.StringNoQuote("true");
                oc_Newobject1["item[0]"] = "Inspect Object" + '\t' + "" + '\t' +
                                           "inspectObject( EditorInspectorBaseFieldPopup.inspectorField.getData() );";
                oc_Newobject1["Item[1]"] = "Jump to Definition in Torsion" + '\t' + "" + '\t' +
                                           "EditorOpenDeclarationInTorsion( EditorInspectorBaseFieldPopup.inspectorField.getData() );";
                oc_Newobject1["item[2]"] = "-";
                oc_Newobject1["item[3]"] = "Copy Value" + '\t' + "" + '\t' +
                                           "setClipboard( EditorInspectorBaseFieldPopup.inspectorField.getData() );";
                oc_Newobject1["item[4]"] = "Paste Value" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseFieldPopup.inspectorField.apply( getClipboard() );";
                oc_Newobject1["item[5]"] = "Reset to Default" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseFieldPopup.inspectorField.reset();";
                oc_Newobject1["inspectorField"] = new ObjectCreator.StringNoQuote("-1");

                #endregion

                oc_Newobject1.Create();
                }

            if (!EditorInspectorBaseFileFieldPopup.isObject())
                {
                #region PopupMenu ( EditorInspectorBaseFileFieldPopup )        oc_Newobject2

                ObjectCreator oc_Newobject2 = new ObjectCreator("PopupMenu", "EditorInspectorBaseFileFieldPopup",
                    typeof (MenuBuilder));
                oc_Newobject2["isPopup"] = new ObjectCreator.StringNoQuote("true");
                oc_Newobject2["item[0]"] = "Open File" + '\t' + "" + '\t' +
                                           "openFile( EditorInspectorBaseFileFieldPopup.filePath );";
                oc_Newobject2["item[1]"] = "Open Folder" + '\t' + "" + '\t' +
                                           "openFolder(EditorInspectorBaseFileFieldPopup.folderPath );";
                oc_Newobject2["item[2]"] = "-";
                oc_Newobject2["item[3]"] = "Copy Value" + '\t' + "" + '\t' +
                                           "setClipboard( EditorInspectorBaseFileFieldPopup.inspectorField.getData() );";
                oc_Newobject2["item[4]"] = "Paste Value" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseFileFieldPopup.inspectorField.apply( getClipboard() );";
                oc_Newobject2["item[5]"] = "Reset to Default" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseFileFieldPopup.inspectorField.reset();";
                oc_Newobject2["inspectorField"] = new ObjectCreator.StringNoQuote("-1");
                oc_Newobject2["folderPath"] = "";
                oc_Newobject2["filePath"] = "";

                #endregion

                oc_Newobject2.Create();
                }

            if (!EditorInspectorBaseShapeFieldPopup.isObject())
                {
                #region PopupMenu ( EditorInspectorBaseShapeFieldPopup )        oc_Newobject3

                ObjectCreator oc_Newobject3 = new ObjectCreator("PopupMenu", "EditorInspectorBaseShapeFieldPopup",
                    typeof (MenuBuilder));
                oc_Newobject3["isPopup"] = new ObjectCreator.StringNoQuote("true");
                oc_Newobject3["item[0]"] = "Edit Shape" + '\t' + "" + '\t' +
                                           "ShapeEditorPlugin.openShape( EditorInspectorBaseShapeFieldPopup.inspectorField.getData() );";
                oc_Newobject3["item[1]"] = "-";
                oc_Newobject3["item[2]"] = "Open File" + '\t' + "" + '\t' +
                                           "openFile( EditorInspectorBaseShapeFieldPopup.filePath );";
                oc_Newobject3["item[3]"] = "Open Folder" + '\t' + "" + '\t' +
                                           "openFolder( EditorInspectorBaseShapeFieldPopup.folderPath );";
                oc_Newobject3["item[4]"] = "-";
                oc_Newobject3["item[5]"] = "Copy Value" + '\t' + "" + '\t' +
                                           "setClipboard( EditorInspectorBaseShapeFieldPopup.inspectorField.getData() );";
                oc_Newobject3["item[6]"] = "Paste Value" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseShapeFieldPopup.inspectorField.apply( getClipboard() );";
                oc_Newobject3["item[7]"] = "Reset to Default" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseShapeFieldPopup.inspectorField.reset();";
                oc_Newobject3["inspectorField"] = new ObjectCreator.StringNoQuote("-1");
                oc_Newobject3["folderPath"] = "";
                oc_Newobject3["filePath"] = "";

                #endregion

                oc_Newobject3.Create();
                }

            if (!EditorInspectorBaseProfileFieldPopup.isObject())
                {
                #region PopupMenu ( EditorInspectorBaseProfileFieldPopup )        oc_Newobject4

                ObjectCreator oc_Newobject4 = new ObjectCreator("PopupMenu", "EditorInspectorBaseProfileFieldPopup",
                    typeof (MenuBuilder));
                oc_Newobject4["isPopup"] = new ObjectCreator.StringNoQuote("true");
                oc_Newobject4["item[0]"] = "Edit Profile" + '\t' + "" + '\t' +
                                           "if( !$InGuiEditor ) toggleGuiEditor( true ); GuiEditor.editProfile( EditorInspectorBaseProfileFieldPopup.inspectorField.getData() );";
                oc_Newobject4["item[1]"] = "Jump to Definition in Torsion" + '\t' + "" + '\t' +
                                           "EditorOpenDeclarationInTorsion( EditorInspectorBaseProfileFieldPopup.inspectorField.getData() );";
                oc_Newobject4["item[2]"] = "Inspect Object" + '\t' + "" + '\t' +
                                           "inspectObject( EditorInspectorBaseProfileFieldPopup.inspectorField.getData() );";
                oc_Newobject4["item[3]"] = "-";
                oc_Newobject4["item[4]"] = "Copy Value" + '\t' + "" + '\t' +
                                           "setClipboard( EditorInspectorBaseProfileFieldPopup.inspectorField.getData() );";
                oc_Newobject4["item[5]"] = "Paste Value" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseProfileFieldPopup.inspectorField.apply( getClipboard() );";
                oc_Newobject4["item[6]"] = "Reset to Default" + '\t' + "" + '\t' +
                                           "EditorInspectorBaseProfileFieldPopup.inspectorField.reset();";
                oc_Newobject4["inspectorField"] = new ObjectCreator.StringNoQuote("-1");
                oc_Newobject4["folderPath"] = "";
                oc_Newobject4["filePath"] = "";

                #endregion

                oc_Newobject4.Create();
                }
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onFieldRightClick(string field)
            {
            SimObject obj = this.getInspectObject();
            string fieldValue = ((GuiInspectorField) field).getData();

            int inspectIndex = -1;
            int openFileIndex = -1;
            int openFolderIndex = -1;
            int jumpToIndex = -1;

            // Find out if this is a TypeFilename field referring to a shape file.

            bool isShapeFilenameField = false;
            if (((GuiInspectorField) field).getInspectedFieldName() == "shapeName")
                {
                isShapeFilenameField =
                    obj.isMemberOfClass("PhysicsShape") ||
                    obj.isMemberOfClass("TSStatic");
                }
            else if (((GuiInspectorField) field).getInspectedFieldName() == "shapeFile")
                {
                isShapeFilenameField =
                    obj.isMemberOfClass("ShapeBaseData") ||
                    obj.isMemberOfClass("ShapeBaseImageData") ||
                    obj.isMemberOfClass("ForestItemData") ||
                    obj.isMemberOfClass("WheeledVehicleTire") ||
                    obj.isMemberOfClass("fxShapeReplicator") ||
                    obj.isMemberOfClass("RenderShapeExample") ||
                    obj.isMemberOfClass("DebrisData");
                }

            // Select the popup.

            MenuBuilder popup = "";

            if (isShapeFilenameField)
                {
                popup = "EditorInspectorBaseShapeFieldPopup";

                openFileIndex = 2;
                openFolderIndex = 3;
                }
            else if (this.isFileTypeField(field))
                {
                popup = "EditorInspectorBaseFileFieldPopup";
                openFileIndex = 0;
                openFolderIndex = 1;
                }
            else
                {
                switch (((GuiInspectorField) field).getClassName())
                    {
                        case "GuiInspectorCustomField":
                            if (((GuiInspectorField) field).getInspectedFieldName() != "parentGroup")
                                return;
                            break;

                        case "GuiInspectorTypeGuiProfile":

                            popup = "EditorInspectorBaseProfileFieldPopup";

                            popup.enableItem(0, fieldValue.isObject());
                            inspectIndex = 2;
                            jumpToIndex = 1;
                            break;

                        case "GuiInspectorDatablockField":
                        case "GuiInspectorTypeSFXDescriptionName":
                        case "GuiInspectorTypeSFXEnvironmentName":
                        case "GuiInspectorTypeSFXTrackName":
                        case "GuiInspectorTypeSFXAmbienceName":
                        case "GuiInspectorTypeSFXSourceName":

                            popup = "EditorInspectorBaseDatablockFieldPopup";
                            popup.enableItem(0, fieldValue.isObject());
                            inspectIndex = 2;
                            jumpToIndex = 1;
                            break;

                        default:

                            popup = "EditorInspectorBaseFieldPopup";
                            inspectIndex = 0;
                            jumpToIndex = 1;
                            break;
                    }
                }

            if (inspectIndex != -1)
                {
                bool isObject = false;
                if (this.isObjectTypeField(field))
                    isObject = fieldValue.isObject();

                popup.enableItem(inspectIndex, isObject);
                popup.enableItem(jumpToIndex, isObject);
                }

            if (openFileIndex != -1 || openFolderIndex != -1)
                {
                string fullPath = this.getFullFilePath(field);
                popup["filePath"] = fullPath;
                popup["folderPath"] = Util.filePath(fullPath);

                if (openFileIndex != -1)
                    popup.enableItem(0, Util.isFile(fullPath));

                if (openFolderIndex != -1)
                    popup.enableItem(1, Util.IsDirectory(popup["folderPath"]));
                }

            popup["inspectorField"] = field;

            GuiCanvas Canvas = "Canvas";

            popup.showPopup(Canvas);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public bool isObjectTypeField(GuiInspectorField field)
            {
            // Inspector field types that refer to objects.

            switch (field.getClassName())
                {
                    case "GuiInspectorDatablockField":
                    case "GuiInspectorTypeSFXDescriptionName":
                    case "GuiInspectorTypeSFXEnvironmentName":
                    case "GuiInspectorTypeSFXTrackName":
                    case "GuiInspectorTypeSFXAmbienceName":
                    case "GuiInspectorTypeSFXSourceName":
                    case "GuiInspectorTypeGuiProfile":
                        return true;
                }

            // Other console types that refer to objects.

            switch (field.getInspectedFieldType())
                {
                    case "TypeSimObject":
                    case "TypeSimObjectName":
                    case "TypeMaterialName":
                    case "TypeCubemapName":
                    case "TypeGuiProfile":
                        return true;
                }

            return false;
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public bool isFileTypeField(GuiInspectorField field)
            {
            return field.isMemberOfClass("GuiInspectorTypeFileName");
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public string getFullFilePath(GuiInspectorField field)
            {
            string fileName = field.getData();
            GuiInspector inspector = field.getInspector();
            SimObject objectx = inspector.getInspectObject();

            if (objectx.isMemberOfClass("Material"))
                {
                // Image filenames in materials are relative to the material's file.

                string objectPath = Util.filePath(Util.makeFullPath(objectx.getFilename(), Util.getMainDotCsDir()));
                return Util.makeFullPath(fileName, objectPath);
                }
            else
                return Util.makeFullPath(fileName, Util.getMainDotCsDir());
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorInspectorBase ts, string simobjectid)
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
        public static bool operator !=(EditorInspectorBase ts, string simobjectid)
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
        public static implicit operator string(EditorInspectorBase ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorInspectorBase(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorInspectorBase) Omni.self.getSimObject(simobjectid, typeof (EditorInspectorBase));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorInspectorBase ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorInspectorBase(int simobjectid)
            {
            return (EditorInspectorBase) Omni.self.getSimObject((uint) simobjectid, typeof (EditorInspectorBase));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorInspectorBase ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorInspectorBase(uint simobjectid)
            {
            return (EditorInspectorBase) Omni.self.getSimObject(simobjectid, typeof (EditorInspectorBase));
            }

        #endregion
        }
    }