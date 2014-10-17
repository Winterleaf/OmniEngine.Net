// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

using System.ComponentModel;
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui.CodeBehind
{
    public class MaterialEditor
    {
        [TypeConverter(typeof (TypeConverterGeneric<MaterialEditorGui>))]
        public class MaterialEditorGui : GuiControl
        {
            internal Material currentMaterial
            {
                get { return this["currentMaterial"]; }
                set { this["currentMaterial"] = value; }
            }

            internal SimObject currentObject
            {
                get { return this["currentObject"]; }
                set { this["currentObject"] = value; }
            }

            internal string currentMode
            {
                get { return this["currentMode"]; }
                set { this["currentMode"] = value; }
            }

            internal string currentMeshMode
            {
                get { return this["currentMeshMode"]; }
                set { this["currentMeshMode"] = value; }
            }

            [ConsoleInteraction]
            public void establishMaterials()
            {
                //Cubemap used to preview other cubemaps in the editor.

                CubemapData matEdCubeMapPreviewMat = "matEdCubeMapPreviewMat";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";
                CustomMaterial materialEd_justAlphaMaterial = "materialEd_justAlphaMaterial";
                ShaderData materialEd_justAlphaShader = "materialEd_justAlphaShader";

                if (!matEdCubeMapPreviewMat.isObject())
                    {
                    #region CubemapData (matEdCubeMapPreviewMat)      oc_Newobject4

                    SingletonCreator oc_Newobject4 = new SingletonCreator("CubemapData", "matEdCubeMapPreviewMat");
                    oc_Newobject4["cubeFace[0]"] = "tools/materialeditor/gui/cube_xNeg";
                    oc_Newobject4["cubeFace[1]"] = "tools/materialeditor/gui/cube_xPos";
                    oc_Newobject4["cubeFace[2]"] = "tools/materialeditor/gui/cube_ZNeg";
                    oc_Newobject4["cubeFace[3]"] = "tools/materialeditor/gui/cube_ZPos";
                    oc_Newobject4["cubeFace[4]"] = "tools/materialeditor/gui/cube_YNeg";
                    oc_Newobject4["cubeFace[5]"] = "tools/materialeditor/gui/cube_YPos";
                    oc_Newobject4["parentGroup"] = "RootGroup";

                    #endregion

                    matEdCubeMapPreviewMat = oc_Newobject4.Create();
                    }

                //Material used to preview other materials in the editor.

                if (!materialEd_previewMaterial.isObject())
                    {
                    #region Material (materialEd_previewMaterial)        oc_Newobject1

                    SingletonCreator oc_Newobject1 = new SingletonCreator("Material", "materialEd_previewMaterial");
                    oc_Newobject1["mapTo"] = "matEd_mappedMat";
                    oc_Newobject1["diffuseMap[0]"] = "tools/materialeditor/gui/matEd_mappedMat";

                    #endregion

                    materialEd_previewMaterial = oc_Newobject1.Create();
                    }

                if (!materialEd_justAlphaMaterial.isObject())
                    {
                    #region CustomMaterial ( materialEd_justAlphaMaterial )        oc_Newobject2

                    SingletonCreator oc_Newobject2 = new SingletonCreator("CustomMaterial", " materialEd_justAlphaMaterial ");
                    oc_Newobject2["mapTo"] = "matEd_mappedMatB";
                    oc_Newobject2["texture[0]"] = materialEd_previewMaterial.diffuseMap[0];

                    #endregion

                    materialEd_justAlphaMaterial = oc_Newobject2.Create();
                    }

                //Custom shader to allow the display of just the alpha channel.

                if (!materialEd_justAlphaShader.isObject())
                    {
                    #region ShaderData ( materialEd_justAlphaShader )        oc_Newobject3

                    SingletonCreator oc_Newobject3 = new SingletonCreator("ShaderData", "materialEd_justAlphaShader");
                    oc_Newobject3["DXVertexShaderFile"] = "shaders/alphaOnlyV.hlsl";
                    oc_Newobject3["DXPixelShaderFile"] = "shaders/alphaOnlyP.hlsl";
                    oc_Newobject3["pixVersion"] = 1.0;

                    #endregion

                    materialEd_justAlphaShader = oc_Newobject3.Create();
                    }
            }

            public void open()
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiButtonCtrl matEd_cubemapEditBtn = MaterialEditorPropertiesWindow.FOT("matEd_cubemapEditBtn");
                GuiPopUpMenuCtrl blendingTypePopUp = MaterialEditorPropertiesWindow.FOT("blendingTypePopUp");
                GuiPopUpMenuCtrl reflectionTypePopUp = MaterialEditorPropertiesWindow.FOT("reflectionTypePopUp");
                GuiPopUpMenuCtrl footstepSoundPopup = MaterialEditorPropertiesWindow.FOT("footstepSoundPopup");
                GuiPopUpMenuCtrl impactSoundPopup = MaterialEditorPropertiesWindow.FOT("impactSoundPopup");
                GuiPopUpMenuCtrl MaterialLayerCtrl = MaterialEditorPropertiesWindow.FOT("MaterialLayerCtrl");
                GuiWindowCtrl materialSelector = "materialSelector";
                GuiWindowCtrl matEdSaveDialog = "matEdSaveDialog";
                GuiPopUpMenuCtrl matEd_quickPreview_Popup = "matEd_quickPreview_Popup";

                this.establishMaterials();

                // We hide these specific windows here due too there non-modal nature.
                // These guis are also pushed onto Canvas, which means they shouldn't be parented
                // by editorgui
                materialSelector.setVisible(false);
                matEdSaveDialog.setVisible(false);

                matEd_cubemapEditBtn.setVisible(false);

                //Setup our dropdown menu contents.
                //Blending Modes
                blendingTypePopUp.clear();
                blendingTypePopUp.add(TypeMaterialBlendOp.None.ToString(), 0);
                blendingTypePopUp.add(TypeMaterialBlendOp.Mul.ToString(), 1);
                blendingTypePopUp.add(TypeMaterialBlendOp.Add.ToString(), 2);
                blendingTypePopUp.add(TypeMaterialBlendOp.AddAlpha.ToString(), 3);
                blendingTypePopUp.add(TypeMaterialBlendOp.Sub.ToString(), 4);
                blendingTypePopUp.add(TypeMaterialBlendOp.LerpAlpha.ToString(), 5);
                blendingTypePopUp.setSelected(0, false);

                //Reflection Types
                reflectionTypePopUp.clear();
                reflectionTypePopUp.add("None", 0);
                reflectionTypePopUp.add("cubemap", 1);
                reflectionTypePopUp.setSelected(0, false);

                //Sounds
                footstepSoundPopup.clear();
                impactSoundPopup.clear();

                string sounds = "<None>" + '\t' + "<Soft>" + '\t' + "<Hard>" + '\t' + "<Metal>" + '\t' + "<Snow>";
                // Default sounds

                // Get custom sound datablocks
                SimSet DataBlockSet = "DataBlockSet";
                int datablockCount = DataBlockSet.getCount();
                for (uint i = 0; i < datablockCount; i++)
                    {
                    SimObject db = DataBlockSet.getObject(i);
                    if (db.isMemberOfClass("SFXTrack"))
                        sounds = sounds + '\t' + db.getName();
                    }

                int count = Util.getFieldCount(sounds);
                for (int j = 0; j < count; j++)
                    {
                    string name = Util.getField(sounds, j);
                    footstepSoundPopup.add(name);
                    impactSoundPopup.add(name);
                    }

                //Preview Models
                matEd_quickPreview_Popup.clear();
                matEd_quickPreview_Popup.add("Cube", 0);
                matEd_quickPreview_Popup.add("Sphere", 1);
                matEd_quickPreview_Popup.add("Pyramid", 2);
                matEd_quickPreview_Popup.add("Cylinder", 3);
                matEd_quickPreview_Popup.add("Torus", 4);
                matEd_quickPreview_Popup.add("Knot", 5);
                matEd_quickPreview_Popup.setSelected(0, false);
                matEd_quickPreview_Popup["selected"] = matEd_quickPreview_Popup.getText();

                MaterialLayerCtrl.clear();
                MaterialLayerCtrl.add("Layer 0", 0);
                MaterialLayerCtrl.add("Layer 1", 1);
                MaterialLayerCtrl.add("Layer 2", 2);
                MaterialLayerCtrl.add("Layer 3", 3);
                MaterialLayerCtrl.setSelected(0, false);

                //Sift through the RootGroup and find all loaded material items.
                this.updateAllFields();
                this.updatePreviewObject();

                // If no selected object; go to material mode. And edit the last selected material
                this.setMode();

                this["preventUndo"] = true.AsString();

                if (this.currentMode == "Mesh")
                    this.prepareActiveObject(true);
                else
                    this.prepareActiveMaterial("", true);

                this["preventUndo"] = false.AsString();
            }

            [ConsoleInteraction]
            public void quit()
            {
                Material materialEd_previewMaterial = "materialEd_previewMaterial";
                GuiMaterialPreview matEd_previewObjectView = "matEd_previewObjectView";
                CubemapData matEdCubeMapPreviewMat = "matEdCubeMapPreviewMat";
                Material notDirtyMaterial = "notDirtyMaterial";

                // if we quit, restore with notDirty
                if (this["materialDirty"].AsBool())
                    {
                    //keep on doing this
                    this.copyMaterials(notDirtyMaterial, materialEd_previewMaterial);
                    this.copyMaterials(notDirtyMaterial, this.currentMaterial);
                    this.guiSync(materialEd_previewMaterial);

                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();
                    this.currentMaterial.flush();
                    this.currentMaterial.reload();
                    }

                if (this.currentMaterial.isObject())
                    this["lastMaterial"] = this.currentMaterial.getName();

                this.setMaterialNotDirty();

                // First delete the model so that it releases
                // material instances that use the preview materials.
                matEd_previewObjectView.deleteModel();

                // Now we can delete the preview materials and shaders
                // knowing that there are no matinstances using them.
                //Copyright Winterleaf Entertainment L.L.C. 2013   
                if (matEdCubeMapPreviewMat.isObject())
                    matEdCubeMapPreviewMat.delete();
                if (materialEd_previewMaterial.isObject())
                    materialEd_previewMaterial.delete();
                if (materialEd_previewMaterial.isObject())
                    materialEd_previewMaterial.delete();
                if (materialEd_previewMaterial.isObject())
                    materialEd_previewMaterial.delete();
                //Copyright Winterleaf Entertainment L.L.C. 2013	  
            }

            [ConsoleInteraction]
            public string openFile(string fileType)
            {
                string filters = "", defaultFileName = "", defaultPath = "", filename = "";
                switch (fileType)
                    {
                        case "texture":
                            filters = this["textureFormats"];

                            if (this["lastTextureFile"] == "")
                                defaultFileName = "*.*";
                            else
                                defaultFileName = this["lastTextureFile"];

                            defaultPath = this["lastTexturePath"];
                            break;

                        case "model":
                            filters = this["modelFormats"];
                            defaultFileName = "*.dts";
                            defaultPath = this["lastModelPath"];
                            break;
                    }

                OpenFileDialog ofd = new OpenFileDialog {FileName = defaultFileName, InitialDirectory = defaultPath, Filter = filters, CheckFileExists = true, Multiselect = false};

                DialogResult dr = Dialogs.OpenFileDialog(ref ofd);
                switch (dr)
                    {
                        case DialogResult.OK:
                            string fileName = Dialogs.GetForwardSlashFile(ofd.FileName);
                            switch (fileType)
                                {
                                    case "texture":
                                        this["lastTexturePath"] = Util.filePath(fileName);
                                        this["lastTextureFile"] = filename = fileName;
                                        break;

                                    case "model":
                                        this["lastModelPath"] = Util.filePath(fileName);
                                        this["lastModelFile"] = filename = fileName;
                                        break;
                                }
                            break;
                        case DialogResult.Abort:
                        case DialogResult.Ignore:
                        case DialogResult.No:
                        case DialogResult.Cancel:
                        case DialogResult.None:
                            return "";
                    }
                return Util.makeRelativePath(filename, Util.getMainDotCsDir());
            }

            //==============================================================================
            // Select object logic (deciding material/target mode)

            [ConsoleInteraction]
            public void setMode()
            {
                GuiContainer MatEdMaterialMode = "MatEdMaterialMode";
                GuiContainer MatEdTargetMode = "MatEdTargetMode";
                MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                EWorldEditor EWorldEditor = "EWorldEditor";

                MatEdMaterialMode.setVisible(false);
                MatEdTargetMode.setVisible(false);

                if (MaterialEditorGui.currentObject.isObject())
                    {
                    MaterialEditorGui.currentMode = "Mesh";
                    MatEdTargetMode.setVisible(true);
                    }
                else
                    {
                    MaterialEditorGui.currentMode = "Material";
                    MatEdMaterialMode.setVisible(true);
                    EWorldEditor.clearSelection();
                    }
            }

            [ConsoleInteraction]
            public void prepareActiveObject(bool bOverride)
            {
                SimObject obj = sGlobal["$Tools::materialEditorList"];
                SubMaterialSelector SubMaterialSelector = "SubMaterialSelector";

                if (this.currentObject == obj && !bOverride)
                    return;

                // TSStatics and ShapeBase objects should have getModelFile methods
                if (obj.isMethod("getModelFile"))
                    {
                    this.currentObject = obj;

                    SubMaterialSelector.clear();
                    this.currentMeshMode = "Model";

                    this.setMode();

                    int targetCount = this.currentObject.call("getTargetCount").AsInt();

                    for (int j = 0; j < targetCount; j++)
                        {
                        string target = this.currentObject.call("getTargetName", new string[] {j.AsString()});
                        int count = SubMaterialSelector.getCount();
                        SubMaterialSelector.add(target);
                        }
                    }
                else // Other classes that support materials if possible
                    {
                    bool canSupportMaterial = false;
                    for (int i = 0; i < obj.getFieldCount(); i++)
                        {
                        string fieldName = obj.getField(i);

                        if (obj.getFieldType(fieldName) != "TypeMaterialName")
                            continue;

                        if (!canSupportMaterial)
                            {
                            this.currentObject = obj;
                            SubMaterialSelector.clear();
                            SubMaterialSelector.add(fieldName, 0);
                            }
                        else
                            {
                            int count = SubMaterialSelector.getCount();
                            SubMaterialSelector.add(fieldName, count);
                            }
                        canSupportMaterial = true;
                        }

                    if (!canSupportMaterial) // Non-relevant classes get returned
                        return;

                    this.currentMeshMode = "EditorShape";
                    this.setMode();
                    }

                int id = SubMaterialSelector.findText(this.currentMaterial.mapTo);
                if (id != -1)
                    SubMaterialSelector.setSelected(id);
                else
                    SubMaterialSelector.setSelected(0);
            }

            //==============================================================================
            // Helper functions to help create categories and manage category lists

            [ConsoleInteraction]
            public void updateAllFields()
            {
                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";
                matEd_cubemapEd_availableCubemapList.clear();
            }

            [ConsoleInteraction]
            public void updatePreviewObject()
            {
                GuiPopUpMenuCtrl matEd_quickPreview_Popup = "matEd_quickPreview_Popup";
                GuiMaterialPreview matEd_previewObjectView = "matEd_previewObjectView";

                string newModel = matEd_quickPreview_Popup.getValue();

                switch (newModel)
                    {
                        case "Sphere":
                            matEd_quickPreview_Popup["selected"] = newModel;
                            matEd_previewObjectView.setModel("tools/materialeditor/gui/spherePreview.dts");
                            matEd_previewObjectView.setOrbitDistance(4);
                            break;

                        case "Cube":
                            matEd_quickPreview_Popup["selected"] = newModel;
                            matEd_previewObjectView.setModel("tools/materialeditor/gui/cubePreview.dts");
                            matEd_previewObjectView.setOrbitDistance(5);
                            break;

                        case "Pyramid":
                            matEd_quickPreview_Popup["selected"] = newModel;
                            matEd_previewObjectView.setModel("tools/materialeditor/gui/pyramidPreview.dts");
                            matEd_previewObjectView.setOrbitDistance(5);
                            break;

                        case "Cylinder":
                            matEd_quickPreview_Popup["selected"] = newModel;
                            matEd_previewObjectView.setModel("tools/materialeditor/gui/cylinderPreview.dts");
                            matEd_previewObjectView.setOrbitDistance((float) 4.2);
                            break;

                        case "Torus":
                            matEd_quickPreview_Popup["selected"] = newModel;
                            matEd_previewObjectView.setModel("tools/materialeditor/gui/torusPreview.dts");
                            matEd_previewObjectView.setOrbitDistance((float) 4.2);
                            break;

                        case "Knot":
                            matEd_quickPreview_Popup["selected"] = newModel;
                            matEd_previewObjectView.setModel("tools/materialeditor/gui/torusknotPreview.dts");
                            break;
                    }
            }

            //==============================================================================
            // Helper functions to help load and update the preview and active material

            // Finds the selected line in the material list, then makes it active in the editor.

            [ConsoleInteraction]
            public void prepareActiveMaterial(Material material, bool bOverride)
            {
                SimSet MaterialSet = "MaterialSet";
                // If were not valid, grab the first valid material out of the materialSet
                if (!material.isObject())
                    material = MaterialSet.getObject(0);

                // Check made in order to avoid loading the same material. Overriding
                // made in special cases
                if (material == this["lastMaterial"] && !bOverride)
                    return;
                else
                    {
                    if (this["materialDirty"].AsBool())
                        {
                        this.showSaveDialog(material);
                        return;
                        }

                    this.setActiveMaterial(material);
                    }
            }

            // Updates the preview material to use the same properties as the selected material,
            // and makes that material active in the editor.

            [ConsoleInteraction]
            public void setActiveMaterial(Material material)
            {
                // Warn if selecting a CustomMaterial (they can't be properly previewed or edited)
                if (material.isObject() && material.isMemberOfClass("CustomMaterial"))
                    {
                    messageBox.MessageBoxOK("Warning", "The selected Material (" + material.getName() + ") is a CustomMaterial, and cannot be edited using the Material Editor.");
                    return;
                    }
                //oh Aswin my friend...

                MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                MaterialEditorGui.currentMaterial = material;
                MaterialEditorGui["lastMaterial"] = material;

                // we create or recreate a material to hold in a pristine state

                #region Material (notDirtyMaterial)        oc_Newobject6

                SingletonCreator oc_Newobject6 = new SingletonCreator("Material", "notDirtyMaterial");
                oc_Newobject6["mapTo"] = "matEd_mappedMat";
                oc_Newobject6["diffuseMap[0]"] = "tools/materialEditor/gui/matEd_mappedMat";

                #endregion

                oc_Newobject6.Create();

                // Converts the texture files into absolute paths.
                MaterialEditorGui.convertTextureFields();

                // If we're allowing for name changes, make sure to save the name seperately
                this["originalName"] = MaterialEditorGui.currentMaterial.name;

                //VINCE DOWN HERE, materialEd_previewMaterial HERE

                // Copy materials over to other references
                MaterialEditorGui.copyMaterials(this.currentMaterial, "materialEd_previewMaterial");
                MaterialEditorGui.copyMaterials(this.currentMaterial, "notDirtyMaterial");

                //AND HERE
                MaterialEditorGui.guiSync("materialEd_previewMaterial");

                //OR HERE, TAKE YOUR PICK
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                // Necessary functionality in order to render correctly
                materialEd_previewMaterial.flush();
                materialEd_previewMaterial.reload();
                MaterialEditorGui.currentMaterial.flush();
                MaterialEditorGui.currentMaterial.reload();

                MaterialEditorGui.setMaterialNotDirty();
            }

            [ConsoleInteraction]
            public bool isMatEditorMaterial(SimObject material)
            {
                return (material.getFilename() == "" || material.getFilename() == "tools/gui/materialSelector.ed.gui" || material.getFilename() == "tools/materialEditor/scripts/materialEditor.ed.cs");
            }

            [ConsoleInteraction]
            public void setMaterialNotDirty()
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                PersistenceManager matEd_PersistMan = "matEd_PersistMan";

                const string propertyText = "Material Properties";
                const string previewText = "Material Preview";
                MaterialEditorPropertiesWindow.text = propertyText;
                MaterialEditorPreviewWindow.text = previewText;

                this["materialDirty"] = false.AsString();
                matEd_PersistMan.removeDirty(this.currentMaterial);
            }

            [ConsoleInteraction]
            public void setMaterialDirty()
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                PersistenceManager matEd_PersistMan = "matEd_PersistMan";

                const string propertyText = "Material Properties *";
                const string previewText = "Material Preview *";
                MaterialEditorPropertiesWindow.text = propertyText;
                MaterialEditorPreviewWindow.text = previewText;

                this["materialDirty"] = true.AsString();

                // materials created in the material selector are given that as its filename, so we run another check
                if (this.isMatEditorMaterial(this.currentMaterial))
                    {
                    if (this.currentMaterial.isAutoGenerated())
                        {
                        string shapePath = "";

                        if (this.currentObject["shapeName"] != "")
                            shapePath = this.currentObject["shapeName"];
                        else if (this.currentObject.isMethod("getDatablock"))
                            {
                            if (((SimObject) this.currentObject.call("getDatablock"))["shapeFile"] != "")
                                shapePath = ((SimObject) this.currentObject.call("getDatablock"))["shapeFile"];
                            }

                        //creating toPath
                        int k = 0;
                        while (Util.strpos(shapePath, "/", k) != -1)
                            {
                            int pos = Util.strpos(shapePath, "/", k);
                            k = pos + 1;
                            }
                        string savePath = Util.getSubStr(shapePath, 0, k);
                        savePath = savePath + "materials.cs";

                        matEd_PersistMan.setDirty(this.currentMaterial, savePath);
                        }
                    else
                        matEd_PersistMan.setDirty(this.currentMaterial, "art/materials.cs");
                    }
                else
                    matEd_PersistMan.setDirty(this.currentMaterial);
            }

            [ConsoleInteraction]
            public void convertTextureFields()
            {
                // Find the absolute paths for the texture filenames so that
                // we can properly wire up the preview materials and controls.

                for (int diffuseI = 0; diffuseI < 4; diffuseI++)
                    {
                    string diffuseMap = this.currentMaterial.diffuseMap[diffuseI];
                    diffuseMap = this.searchForTexture(this.currentMaterial, diffuseMap);
                    this.currentMaterial.diffuseMap[diffuseI] = diffuseMap.AsTypeImageFilename();
                    }

                for (int normalI = 0; normalI < 4; normalI++)
                    {
                    string normalMap = this.currentMaterial.normalMap[normalI];
                    normalMap = this.searchForTexture(this.currentMaterial, normalMap);
                    this.currentMaterial.normalMap[normalI] = normalMap.AsTypeImageFilename();
                    }

                for (int overlayI = 0; overlayI < 4; overlayI++)
                    {
                    string overlayMap = this.currentMaterial.overlayMap[overlayI];
                    overlayMap = this.searchForTexture(this.currentMaterial, overlayMap);
                    this.currentMaterial.overlayMap[overlayI] = overlayMap.AsTypeImageFilename();
                    }

                for (int detailI = 0; detailI < 4; detailI++)
                    {
                    string detailMap = this.currentMaterial.detailMap[detailI];
                    detailMap = this.searchForTexture(this.currentMaterial, detailMap);
                    this.currentMaterial.detailMap[detailI] = detailMap.AsTypeImageFilename();
                    }

                for (int detailNormalI = 0; detailNormalI < 4; detailNormalI++)
                    {
                    string detailNormalMap = this.currentMaterial.detailNormalMap[detailNormalI];
                    detailNormalMap = this.searchForTexture(this.currentMaterial, detailNormalMap);
                    this.currentMaterial.detailNormalMap[detailNormalI] = detailNormalMap.AsTypeImageFilename();
                    }

                for (int lightI = 0; lightI < 4; lightI++)
                    {
                    string lightMap = this.currentMaterial.lightMap[lightI];
                    lightMap = this.searchForTexture(this.currentMaterial, lightMap);
                    this.currentMaterial.lightMap[lightI] = lightMap.AsTypeImageFilename();
                    }

                for (int toneI = 0; toneI < 4; toneI++)
                    {
                    string toneMap = this.currentMaterial.toneMap[toneI];
                    toneMap = this.searchForTexture(this.currentMaterial, toneMap);
                    this.currentMaterial.toneMap[toneI] = toneMap.AsTypeImageFilename();
                    }

                for (int specI = 0; specI < 4; specI++)
                    {
                    string specMap = this.currentMaterial.specularMap[specI];
                    specMap = this.searchForTexture(this.currentMaterial, specMap);
                    this.currentMaterial.specularMap[specI] = specMap.AsTypeImageFilename();
                    }

                for (int accuI = 0; accuI < 4; accuI++)
                    {
                    string accuMap = this.currentMaterial["accuMap[" + accuI + "]"];
                    accuMap = this.searchForTexture(this.currentMaterial, accuMap);
                    this.currentMaterial["accuMap[" + accuI + "]"] = accuMap.AsTypeImageFilename();
                    }
            }

            // still needs to be optimized further
            [ConsoleInteraction]
            public string searchForTexture(SimObject material, string texture)
            {
                if (texture != "")
                    {
                    // set the find signal as false to start out with 
                    bool isFile = false;
                    // sete the formats we're going to be looping through if need be
                    string formats = ".png .jpg .dds .bmp .gif .jng .tga";

                    // if the texture contains the correct filepath and name right off the bat, lets use it
                    if (Util.isFile(texture))
                        isFile = true;
                    else
                        {
                        for (int i = 0; i < Util.getWordCount(formats); i++)
                            {
                            string testFileName = texture + Util.getWord(formats, i);
                            if (Util.isFile(testFileName))
                                {
                                isFile = true;
                                break;
                                }
                            }
                        }

                    // if we didn't grab a proper name, lets use a string logarithm
                    if (!isFile)
                        {
                        string materialDiffuse = texture;
                        string materialDiffuse2 = texture;

                        string materialPath = material.getFilename();

                        if (Util.strchr(materialDiffuse, "/") == "")
                            {
                            int k = 0;
                            while (Util.strpos(materialPath, "/", k) != -1)
                                {
                                int count = Util.strpos(materialPath, "/", k);
                                k = count + 1;
                                }

                            string materialsCs = Util.getSubStr(materialPath, k, 99);
                            texture = Util.strreplace(materialPath, materialsCs, texture);
                            }
                        else
                            texture = Util.strreplace(materialPath, materialPath, texture);

                        // lets test the pathing we came up with
                        if (Util.isFile(texture))
                            isFile = true;
                        else
                            {
                            for (int i = 0; i < Util.getWordCount(formats); i++)
                                {
                                string testFileName = texture + Util.getWord(formats, i);
                                if (Util.isFile(testFileName))
                                    {
                                    isFile = true;
                                    break;
                                    }
                                }
                            }

                        // as a last resort to find the proper name
                        // we have to resolve using find first file functions very very slow
                        if (!isFile)
                            {
                            int k = 0;
                            while (Util.strpos(materialDiffuse2, "/", k) != -1)
                                {
                                int count = Util.strpos(materialDiffuse2, "/", k);
                                k = count + 1;
                                }

                            texture = Util.getSubStr(materialDiffuse2, k, 99);
                            for (int i = 0; i < Util.getWordCount(formats); i++)
                                {
                                string searchString = "*" + texture + Util.getWord(formats, i);
                                string testFileName = Util.findFirstFile(searchString, true);
                                if (Util.isFile(testFileName))
                                    {
                                    texture = testFileName;
                                    isFile = true;
                                    break;
                                    }
                                }
                            }
                        return texture;
                        }
                    else
                        return texture; //Texture exists and can be found - just return the input argument.
                    }
                return ""; //No texture associated with this property.
            }

            [ConsoleInteraction]
            public void updateLivePreview(bool preview)
            {
                Material materialEd_previewMaterial = "materialEd_previewMaterial";
                Material notDirtyMaterial = "notDirtyMaterial";

                // When checkbox is selected, preview the material in real time, if not; then don't
                if (preview)
                    this.copyMaterials(materialEd_previewMaterial, this.currentMaterial);
                else
                    this.copyMaterials(notDirtyMaterial, this.currentMaterial);

                this.currentMaterial.flush();
                this.currentMaterial.reload();
            }

            [ConsoleInteraction]
            public void copyMaterials(Material copyFrom, Material copyTo)
            {
                // Make sure we copy and restore the map to.
                string mapTo = copyTo["mapTo"];
                copyTo.assignFieldsFrom(copyFrom);
                copyTo["mapTo"] = mapTo;
            }

            [ConsoleInteraction]
            public void guiSync(Material material)
            {
                GuiContainer MatEdMaterialMode = "MatEdMaterialMode";
                GuiTextEditCtrl MatEdMaterialModeSelMaterialName = MatEdMaterialMode.FOT("selMaterialName");
                GuiTextCtrl MatEdMaterialModeSelMaterialMapTo = MatEdMaterialMode.FOT("selMaterialMapTo");

                GuiContainer MatEdTargetMode = "MatEdTargetMode";
                GuiTextEditCtrl MatEdTargetModeSelMaterialName = MatEdTargetMode.FOT("selMaterialName");
                GuiTextCtrl MatEdTargetModeSelMaterialMapTo = MatEdTargetMode.FOT("selMaterialMapTo");

                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextEditCtrl alphaRefTextEdit = MaterialEditorPropertiesWindow.FOT("alphaRefTextEdit");
                GuiSliderCtrl alphaRefSlider = MaterialEditorPropertiesWindow.FOT("alphaRefSlider");
                GuiCheckBoxCtrl doubleSidedCheckBox = MaterialEditorPropertiesWindow.FOT("doubleSidedCheckBox");
                GuiCheckBoxCtrl transZWriteCheckBox = MaterialEditorPropertiesWindow.FOT("transZWriteCheckBox");
                GuiCheckBoxCtrl alphaTestCheckBox = MaterialEditorPropertiesWindow.FOT("alphaTestCheckBox");
                GuiCheckBoxCtrl castShadows = MaterialEditorPropertiesWindow.FOT("castShadows");
                GuiCheckBoxCtrl translucentCheckbox = MaterialEditorPropertiesWindow.FOT("translucentCheckbox");
                GuiPopUpMenuCtrl blendingTypePopUp = MaterialEditorPropertiesWindow.FOT("blendingTypePopUp");
                GuiButtonCtrl matEd_cubemapEditBtn = MaterialEditorPropertiesWindow.FOT("matEd_cubemapEditBtn");
                GuiPopUpMenuCtrl reflectionTypePopUp = MaterialEditorPropertiesWindow.FOT("reflectionTypePopUp");
                GuiSwatchButtonCtrl effectColor0Swatch = MaterialEditorPropertiesWindow.FOT("effectColor0Swatch");
                GuiSwatchButtonCtrl effectColor1Swatch = MaterialEditorPropertiesWindow.FOT("effectColor1Swatch");
                GuiCheckBoxCtrl showFootprintsCheckbox = MaterialEditorPropertiesWindow.FOT("showFootprintsCheckbox");
                GuiCheckBoxCtrl showDustCheckbox = MaterialEditorPropertiesWindow.FOT("showDustCheckbox");

                GuiTextCtrl diffuseMapNameText = MaterialEditorPropertiesWindow.FOT("diffuseMapNameText");
                GuiBitmapCtrl diffuseMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("diffuseMapDisplayBitmap");

                GuiTextCtrl normalMapNameText = MaterialEditorPropertiesWindow.FOT("normalMapNameText");
                GuiBitmapCtrl normalMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("normalMapDisplayBitmap");

                GuiTextCtrl overlayMapNameText = MaterialEditorPropertiesWindow.FOT("overlayMapNameText");
                GuiBitmapCtrl overlayMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("overlayMapDisplayBitmap");

                GuiTextCtrl detailMapNameText = MaterialEditorPropertiesWindow.FOT("detailMapNameText");
                GuiBitmapCtrl detailMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("detailMapDisplayBitmap");

                GuiTextCtrl detailNormalMapNameText = MaterialEditorPropertiesWindow.FOT("detailNormalMapNameText");
                GuiBitmapCtrl detailNormalMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("detailNormalMapDisplayBitmap");

                GuiTextCtrl lightMapNameText = MaterialEditorPropertiesWindow.FOT("lightMapNameText");
                GuiBitmapCtrl lightMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("lightMapDisplayBitmap");

                GuiTextCtrl toneMapNameText = MaterialEditorPropertiesWindow.FOT("toneMapNameText");
                GuiBitmapCtrl toneMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("toneMapDisplayBitmap");

                GuiTextCtrl specMapNameText = MaterialEditorPropertiesWindow.FOT("specMapNameText");
                GuiBitmapCtrl specMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("specMapDisplayBitmap");

                GuiTextCtrl accuMapNameText = MaterialEditorPropertiesWindow.FOT("accuMapNameText");
                GuiBitmapCtrl accuMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("accuMapDisplayBitmap");

                //GuiTextCtrl skinMapNameText = MaterialEditorPropertiesWindow.FOT("skinMapNameText");
                //GuiBitmapCtrl skinMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("skinMapDisplayBitmap");

                //GuiTextCtrl furMapNameText = MaterialEditorPropertiesWindow.FOT("furMapNameText");
                //GuiBitmapCtrl furMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("furMapDisplayBitmap");

                //GuiTextCtrl skinPoreMapNameText = MaterialEditorPropertiesWindow.FOT("skinPoreMapNameText");
                //GuiBitmapCtrl skinPoreMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("skinPoreMapDisplayBitmap");

                //GuiTextCtrl skinForeheadMapNameText = MaterialEditorPropertiesWindow.FOT("skinForeheadMapNameText");
                //GuiBitmapCtrl skinForeheadMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("skinForeheadMapDisplayBitmap");

                //GuiTextCtrl skinNoseMapNameText = MaterialEditorPropertiesWindow.FOT("skinNoseMapNameText");
                //GuiBitmapCtrl skinNoseMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("skinNoseMapDisplayBitmap");

                //GuiTextCtrl skinCheekMapNameText = MaterialEditorPropertiesWindow.FOT("skinCheekMapNameText");
                //GuiBitmapCtrl skinCheekMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("skinCheekMapDisplayBitmap");

                GuiTextEditCtrl detailScaleTextEdit = MaterialEditorPropertiesWindow.FOT("detailScaleTextEdit");
                GuiTextEditCtrl detailNormalStrengthTextEdit = MaterialEditorPropertiesWindow.FOT("detailNormalStrengthTextEdit");
                GuiSwatchButtonCtrl colorTintSwatch = MaterialEditorPropertiesWindow.FOT("colorTintSwatch");
                GuiSwatchButtonCtrl specularColorSwatch = MaterialEditorPropertiesWindow.FOT("specularColorSwatch");
                GuiTextEditCtrl specularPowerTextEdit = MaterialEditorPropertiesWindow.FOT("specularPowerTextEdit");
                GuiSliderCtrl specularPowerSlider = MaterialEditorPropertiesWindow.FOT("specularPowerSlider");
                GuiTextEditCtrl specularStrengthTextEdit = MaterialEditorPropertiesWindow.FOT("specularStrengthTextEdit");
                GuiSliderCtrl specularStrengthSlider = MaterialEditorPropertiesWindow.FOT("specularStrengthSlider");
                GuiCheckBoxCtrl pixelSpecularCheckbox = MaterialEditorPropertiesWindow.FOT("pixelSpecularCheckbox");
                GuiCheckBoxCtrl glowCheckbox = MaterialEditorPropertiesWindow.FOT("glowCheckbox");
                GuiCheckBoxCtrl emissiveCheckbox = MaterialEditorPropertiesWindow.FOT("emissiveCheckbox");
                GuiTextEditCtrl parallaxTextEdit = MaterialEditorPropertiesWindow.FOT("parallaxTextEdit");
                GuiSliderCtrl parallaxSlider = MaterialEditorPropertiesWindow.FOT("parallaxSlider");
                GuiCheckBoxCtrl useAnisoCheckbox = MaterialEditorPropertiesWindow.FOT("useAnisoCheckbox");
                GuiCheckBoxCtrl vertLitCheckbox = MaterialEditorPropertiesWindow.FOT("vertLitCheckbox");
                //TODO
                GuiSwatchButtonCtrl vertColorSwatch = MaterialEditorPropertiesWindow.FOT("vertColorSwatch");
                GuiCheckBoxCtrl subSurfaceCheckbox = MaterialEditorPropertiesWindow.FOT("subSurfaceCheckbox");
                GuiSwatchButtonCtrl subSurfaceColorSwatch = MaterialEditorPropertiesWindow.FOT("subSurfaceColorSwatch");
                GuiTextEditCtrl subSurfaceRolloffTextEdit = MaterialEditorPropertiesWindow.FOT("subSurfaceRolloffTextEdit");
                GuiTextEditCtrl minnaertTextEdit = MaterialEditorPropertiesWindow.FOT("minnaertTextEdit");

                GuiCheckBoxCtrl RotationAnimation = MaterialEditorPropertiesWindow.FOT("RotationAnimation");
                GuiCheckBoxCtrl ScrollAnimation = MaterialEditorPropertiesWindow.FOT("ScrollAnimation");
                GuiCheckBoxCtrl WaveAnimation = MaterialEditorPropertiesWindow.FOT("WaveAnimation");
                GuiCheckBoxCtrl ScaleAnimation = MaterialEditorPropertiesWindow.FOT("ScaleAnimation");
                GuiCheckBoxCtrl SequenceAnimation = MaterialEditorPropertiesWindow.FOT("SequenceAnimation");

                GuiTextEditCtrl RotationTextEditU = MaterialEditorPropertiesWindow.FOT("RotationTextEditU");
                GuiTextEditCtrl RotationTextEditV = MaterialEditorPropertiesWindow.FOT("RotationTextEditV");
                GuiTextEditCtrl RotationSpeedTextEdit = MaterialEditorPropertiesWindow.FOT("RotationSpeedTextEdit");
                GuiSliderCtrl RotationSliderU = MaterialEditorPropertiesWindow.FOT("RotationSliderU");
                GuiSliderCtrl RotationSliderV = MaterialEditorPropertiesWindow.FOT("RotationSliderV");
                GuiSliderCtrl RotationSpeedSlider = MaterialEditorPropertiesWindow.FOT("RotationSpeedSlider");
                GuiBitmapCtrl RotationCrosshair = MaterialEditorPropertiesWindow.FOT("RotationCrosshair");

                GuiTextEditCtrl ScrollTextEditU = MaterialEditorPropertiesWindow.FOT("ScrollTextEditU");
                GuiTextEditCtrl ScrollTextEditV = MaterialEditorPropertiesWindow.FOT("ScrollTextEditV");
                GuiTextEditCtrl ScrollSpeedTextEdit = MaterialEditorPropertiesWindow.FOT("ScrollSpeedTextEdit");
                GuiSliderCtrl ScrollSliderU = MaterialEditorPropertiesWindow.FOT("ScrollSliderU");
                GuiSliderCtrl ScrollSliderV = MaterialEditorPropertiesWindow.FOT("ScrollSliderV");
                GuiSliderCtrl ScrollSpeedSlider = MaterialEditorPropertiesWindow.FOT("ScrollSpeedSlider");
                GuiBitmapCtrl ScrollCrosshair = MaterialEditorPropertiesWindow.FOT("ScrollCrosshair");

                GuiContainer WaveButtonContainer = MaterialEditorPropertiesWindow.FOT("WaveButtonContainer");
                GuiTextEditCtrl WaveTextEditAmp = MaterialEditorPropertiesWindow.FOT("WaveTextEditAmp");
                GuiTextEditCtrl WaveTextEditFreq = MaterialEditorPropertiesWindow.FOT("WaveTextEditFreq");
                GuiSliderCtrl WaveSliderAmp = MaterialEditorPropertiesWindow.FOT("WaveSliderAmp");
                GuiSliderCtrl WaveSliderFreq = MaterialEditorPropertiesWindow.FOT("WaveSliderFreq");

                GuiTextEditCtrl SequenceTextEditFPS = MaterialEditorPropertiesWindow.FOT("SequenceTextEditFPS");
                GuiTextEditCtrl SequenceTextEditSSS = MaterialEditorPropertiesWindow.FOT("SequenceTextEditSSS");
                GuiSliderCtrl SequenceSliderFPS = MaterialEditorPropertiesWindow.FOT("SequenceSliderFPS");
                GuiSliderCtrl SequenceSliderSSS = MaterialEditorPropertiesWindow.FOT("SequenceSliderSSS");

                GuiTextEditCtrl accuScaleTextEdit = MaterialEditorPropertiesWindow.FOT("accuScaleTextEdit");
                GuiTextEditCtrl accuDirectionTextEdit = MaterialEditorPropertiesWindow.FOT("accuDirectionTextEdit");
                GuiTextEditCtrl accuStrengthTextEdit = MaterialEditorPropertiesWindow.FOT("accuStrengthTextEdit");
                GuiTextEditCtrl accuCoverageTextEdit = MaterialEditorPropertiesWindow.FOT("accuCoverageTextEdit");
                GuiTextEditCtrl accuSpecularTextEdit = MaterialEditorPropertiesWindow.FOT("accuSpecularTextEdit");

                this["preventUndo"] = true.AsString();
                //Setup our headers
                if (this.currentMode == "material")
                    {
                    MatEdMaterialModeSelMaterialName.setText(this.currentMaterial.name);
                    MatEdMaterialModeSelMaterialMapTo.setText(this.currentMaterial.mapTo);
                    }
                else
                    {
                    if (this.currentObject.isMethod("getModelFile"))
                        {
                        string sourcePath = this.currentObject.call("getModelFile");
                        if (sourcePath != "")
                            {
                            MatEdTargetModeSelMaterialMapTo["ToolTip"] = sourcePath;
                            string sourceName = Util.fileName(sourcePath);
                            MatEdTargetModeSelMaterialMapTo.setText(sourceName);
                            MatEdTargetModeSelMaterialName.setText(this.currentMaterial.name);
                            }
                        }
                    else
                        {
                        string info = this.currentObject.getClassName();
                        MatEdTargetModeSelMaterialMapTo["ToolTip"] = info;
                        MatEdTargetModeSelMaterialMapTo.setText(info);
                        MatEdTargetModeSelMaterialName.setText(this.currentMaterial.name);
                        }
                    }

                alphaRefTextEdit.setText(material.alphaRef.AsString());
                alphaRefSlider.setValue(material.alphaRef.AsString());
                doubleSidedCheckBox.setValue(material.doubleSided.AsString());
                transZWriteCheckBox.setValue(material.translucentZWrite.AsString());
                alphaTestCheckBox.setValue(material.alphaTest.AsString());
                castShadows.setValue(material.castShadows.AsString());
                translucentCheckbox.setValue(material.translucent.AsString());

                int selectedNum = 0;
                if (material.translucentBlendOp == TypeMaterialBlendOp.None)
                    selectedNum = 0;
                else if (material.translucentBlendOp == TypeMaterialBlendOp.Mul)
                    selectedNum = 1;
                else if (material.translucentBlendOp == TypeMaterialBlendOp.Add)
                    selectedNum = 2;
                else if (material.translucentBlendOp == TypeMaterialBlendOp.AddAlpha)
                    selectedNum = 3;
                else if (material.translucentBlendOp == TypeMaterialBlendOp.Sub)
                    selectedNum = 4;
                else if (material.translucentBlendOp == TypeMaterialBlendOp.LerpAlpha)
                    selectedNum = 5;
                blendingTypePopUp.setSelected(selectedNum);

                if (material.cubemap != "")
                    {
                    matEd_cubemapEditBtn.setVisible(true);
                    reflectionTypePopUp.setSelected(1);
                    }
                else if (material.dynamicCubemap)
                    {
                    matEd_cubemapEditBtn.setVisible(false);
                    reflectionTypePopUp.setSelected(2);
                    }
                else if (material.planarReflection)
                    {
                    matEd_cubemapEditBtn.setVisible(false);
                    reflectionTypePopUp.setSelected(3);
                    }
                else
                    {
                    matEd_cubemapEditBtn.setVisible(false);
                    reflectionTypePopUp.setSelected(0);
                    }

                effectColor0Swatch.color = material.effectColor[0];
                effectColor1Swatch.color = material.effectColor[1];
                showFootprintsCheckbox.setValue(material.showFootprints.AsString());
                showDustCheckbox.setValue(material.showDust.AsString());
                this.updateSoundPopup("Footstep", material.footstepSoundId.AsString(), material.customFootstepSound);
                this.updateSoundPopup("Impact", material.impactSoundId.AsString(), material.customImpactSound);

                //layer specific controls are located here
                int layer = this["currentLayer"].AsInt();

                if (material.diffuseMap[layer] == "")
                    {
                    diffuseMapNameText.setText("None");
                    diffuseMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    }
                else
                    {
                    diffuseMapNameText.setText(material.diffuseMap[layer]);
                    diffuseMapDisplayBitmap.setBitmapX(material.diffuseMap[layer]);
                    }

                if (material.normalMap[layer] == "")
                    {
                    normalMapNameText.setText("None");
                    normalMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    }
                else
                    {
                    normalMapNameText.setText(material.normalMap[layer]);
                    normalMapDisplayBitmap.setBitmapX(material.normalMap[layer]);
                    }

                if (material.overlayMap[layer] == "")
                    {
                    overlayMapNameText.setText("None");
                    overlayMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    }
                else
                    {
                    overlayMapNameText.setText(material.overlayMap[layer]);
                    overlayMapDisplayBitmap.setBitmapX(material.overlayMap[layer]);
                    }

                if ((material).detailMap[layer] == "")
                    {
                    detailMapNameText.setText("None");
                    detailMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    }
                else
                    {
                    detailMapNameText.setText((material).detailMap[layer]);
                    detailMapDisplayBitmap.setBitmapX((material).detailMap[layer]);
                    }

                if ((material).detailNormalMap[layer] == "")
                    {
                    detailNormalMapNameText.setText("None");
                    detailNormalMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    }
                else
                    {
                    detailNormalMapNameText.setText((material).detailNormalMap[layer]);
                    detailNormalMapDisplayBitmap.setBitmapX((material).detailNormalMap[layer]);
                    }

                if (material.lightMap[layer] == "")
                    {
                    lightMapNameText.setText("None");
                    lightMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    }
                else
                    {
                    lightMapNameText.setText(material.lightMap[layer]);
                    lightMapDisplayBitmap.setBitmapX(material.lightMap[layer]);
                    }

                if (material.toneMap[layer] == "")
                    {
                    toneMapNameText.setText("None");
                    toneMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    }
                else
                    {
                    toneMapNameText.setText(material.toneMap[layer]);
                    toneMapDisplayBitmap.setBitmapX(material.toneMap[layer]);
                    }

                if (material.specularMap[layer] == "")
                    {
                    specMapNameText.setText("None");
                    specMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    }
                else
                    {
                    specMapNameText.setText(material.specularMap[layer]);
                    specMapDisplayBitmap.setBitmapX(material.specularMap[layer]);
                    }
                if (material["accuMap[" + layer + "]"] == "")
                    {
                    accuMapNameText.setText("None");
                    accuMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    }
                else
                    {
                    accuMapNameText.setText(material["accuMap[" + layer + "]"]);
                    accuMapDisplayBitmap.setBitmapX(material["accuMap[" + layer + "]"]);
                    }

                accuScaleTextEdit.setText(material["accuScale[" + layer + "]"]);
                //accuScaleTextEdit.setText(material.accuScale[layer]);
                accuDirectionTextEdit.setText(material["accuDirection[" + layer + "]"]);
                //accuDirectionTextEdit.setText(material.accuDirection[layer]);
                accuStrengthTextEdit.setText(material["accuStrength[" + layer + "]"]);
                //accuStrengthTextEdit.setText(material.accuStrength[layer]);
                accuCoverageTextEdit.setText(material["accuCoverage[" + layer + "]"]);
                //accuCoverageTextEdit.setText(material.accuCoverage[layer]);
                accuSpecularTextEdit.setText(material["accuSpecular[" + layer + "]"]);
                //accuSpecularTextEdit.setText(material.accuSpecular[layer]);
                //if (material.furMap[layer] == "")
                //    {
                //    furMapNameText.setText("None");
                //    furMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                //    }
                //else
                //    {
                //    furMapNameText.setText(material.furMap[layer]);
                //    furMapDisplayBitmap.setBitmapX(material.furMap[layer]);
                //    }
                //if (material.skinPoreMap[layer] == "")
                //    {
                //    skinPoreMapNameText.setText("None");
                //    skinPoreMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                //    }
                //else
                //    {
                //        skinPoreMapNameText.setText(material.skinPoreMap[layer]);
                //        skinPoreMapDisplayBitmap.setBitmapX(material.skinPoreMap[layer]);
                //    }
                //if (material.skinForeheadMap[layer] == "")
                //    {
                //        skinForeheadMapNameText.setText("None");
                //        skinForeheadMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                //    }
                //else
                //    {
                //        skinForeheadMapNameText.setText(material.skinForeheadMap[layer]);
                //        skinForeheadMapDisplayBitmap.setBitmapX(material.skinForeheadMap[layer]);
                //    }
                //if (material.skinNoseMap[layer] == "")
                //    {
                //        skinNoseMapNameText.setText("None");
                //        skinNoseMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                //    }
                //else
                //    {
                //        skinNoseMapNameText.setText(material.skinNoseMap[layer]);
                //        skinNoseMapDisplayBitmap.setBitmapX(material.skinNoseMap[layer]);
                //    }
                //if (material.skinCheekMap[layer] == "")
                //    {
                //        skinCheekMapNameText.setText("None");
                //        skinCheekMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                //    }
                //else
                //    {
                //        skinCheekMapNameText.setText(material.skinCheekMap[layer]);
                //        skinCheekMapDisplayBitmap.setBitmapX(material.skinCheekMap[layer]);
                //    }
                //if (material["skinMap[" + layer + "]"] == "") //TODO
                //    {
                //    skinMapNameText.setText("None");
                //    skinMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                //    }
                //else
                //    {
                //    skinMapNameText.setText(material["skinMap[" +layer + "]"]);
                //    skinMapDisplayBitmap.setBitmapX(material["skinMap[" + layer + "]"]);
                //    }

                detailScaleTextEdit.setText(Util.getWord(material.detailScale[layer].AsString(), 0));
                detailNormalStrengthTextEdit.setText(Util.getWord(material.detailNormalMapStrength[layer].AsString(), 0));

                colorTintSwatch.color = material.diffuseColor[layer];
                specularColorSwatch.color = material.specular[layer];

                specularPowerTextEdit.setText(material.specularPower[layer].AsString());
                specularPowerSlider.setValue(material.specularPower[layer].AsString());
                specularStrengthTextEdit.setText(material.specularStrength[layer].AsString());
                specularStrengthSlider.setValue(material.specularStrength[layer].AsString());
                pixelSpecularCheckbox.setValue(material.pixelSpecular[layer].AsString());
                glowCheckbox.setValue(material.glow[layer].AsString());
                emissiveCheckbox.setValue(material.emissive[layer].AsString());
                parallaxTextEdit.setText(material.parallaxScale[layer].AsString());
                parallaxSlider.setValue(material.parallaxScale[layer].AsString());

                useAnisoCheckbox.setValue(material.useAnisotropic[layer].AsString());
                vertLitCheckbox.setValue(material.vertLit[layer].AsString());

                //Todo Not sure what the intention of this line of code was for.  Material.vertColor is a bool being asssigned to a color?  WTF

                //vertColorSwatch.color = material.vertColor[layer];

                subSurfaceCheckbox.setValue(material.subSurface[layer].AsString());
                subSurfaceColorSwatch.color = material.subSurfaceColor[layer];
                subSurfaceRolloffTextEdit.setText(material.subSurfaceRolloff[layer].AsString());
                minnaertTextEdit.setText(material.minnaertConstant[layer].AsString());

                // Animation properties
                RotationAnimation.setValue("0");
                ScrollAnimation.setValue("0");
                WaveAnimation.setValue("0");
                ScaleAnimation.setValue("0");
                SequenceAnimation.setValue("0");

                string flags = material.getAnimFlags((uint) layer);
                int wordCount = Util.getWordCount(flags);
                for (int i = 0; i != wordCount; i++)
                    {
                    switch (Util.getWord(flags, i))
                        {
                            case "$Rotate":
                                RotationAnimation.setValue("1");
                                break;
                            case "$Scroll":
                                ScrollAnimation.setValue("1");
                                break;
                            case "$Wave":
                                WaveAnimation.setValue("1");
                                break;
                            case "$Scale":
                                ScaleAnimation.setValue("1");
                                break;
                            case "$Sequence":
                                SequenceAnimation.setValue("1");
                                break;
                        }
                    }

                RotationTextEditU.setText(Util.getWord(material.rotPivotOffset[layer].AsString(), 0));
                RotationTextEditV.setText(Util.getWord(material.rotPivotOffset[layer].AsString(), 1));
                RotationSpeedTextEdit.setText(material.rotSpeed[layer].AsString());
                RotationSliderU.setValue(Util.getWord(material.rotPivotOffset[layer].AsString(), 0));
                RotationSliderV.setValue(Util.getWord(material.rotPivotOffset[layer].AsString(), 1));
                RotationSpeedSlider.setValue(material.rotSpeed[layer].AsString());
                RotationCrosshair.setPosition((int) (45*Util.mAbs(Util.getWord(material.rotPivotOffset[layer].AsString(), 0).AsFloat()) - 2), (int) (45*Util.mAbs(Util.getWord(material.rotPivotOffset[layer].AsString(), 1).AsFloat()) - 2));

                ScrollTextEditU.setText(Util.getWord(material.scrollDir[layer].AsString(), 0));
                ScrollTextEditV.setText(Util.getWord(material.scrollDir[layer].AsString(), 1));
                ScrollSpeedTextEdit.setText(material.scrollSpeed[layer].AsString());
                ScrollSliderU.setValue(Util.getWord(material.scrollDir[layer].AsString(), 0));
                ScrollSliderV.setValue(Util.getWord(material.scrollDir[layer].AsString(), 1));
                ScrollSpeedSlider.setValue(material.scrollSpeed[layer].AsString());
                ScrollCrosshair.setPosition((int) -(23*Util.getWord(material.scrollDir[layer].AsString(), 0).AsFloat()) + 20, (int) -(23*Util.getWord(material.scrollDir[layer].AsString(), 1).AsFloat()) + 20);

                string waveType = material["waveType[layer]"];
                for (uint radioButton = 0; radioButton < WaveButtonContainer.getCount(); radioButton++)
                    {
                    if (waveType == ((GuiBitmapButtonCtrl) WaveButtonContainer.getObject(radioButton))["waveType"])
                        ((GuiBitmapButtonCtrl) WaveButtonContainer.getObject(radioButton)).setStateOn(true);
                    }

                WaveTextEditAmp.setText(material.waveAmp[layer].AsString());
                WaveTextEditFreq.setText(material.waveFreq[layer].AsString());
                WaveSliderAmp.setValue(material.waveAmp[layer].AsString());
                WaveSliderFreq.setValue(material.waveAmp[layer].AsString());

                int numFrames = (int) Util.mRound(1/material.sequenceSegmentSize[layer].AsString().AsFloat());

                SequenceTextEditFPS.setText(material.sequenceFramePerSec[layer].AsString());
                SequenceTextEditSSS.setText(numFrames.AsString());
                SequenceSliderFPS.setValue(material.sequenceFramePerSec[layer].AsString());
                SequenceSliderSSS.setValue(numFrames.AsString());

                this["preventUndo"] = false.AsString();
            }

            //=======================================
            // Material Update Functionality

            [ConsoleInteraction]
            public void changeLayer(string layer)
            {
                if (this["currentLayer"] == Util.getWord(layer, 1))
                    return;

                this["currentLayer"] = Util.getWord(layer, 1);
                this.guiSync("materialEd_previewMaterial");
            }

            [ConsoleInteraction]
            public void updateActiveMaterial(string propertyField, string value, bool isSlider = false, bool onMouseUp = false)
            {
                editor Editor = "Editor";
                UndoManager undoManager = Editor.getUndoManager();
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                this.setMaterialDirty();

                //if (value == "")
                //value = "\"\"";

                // Here is where we handle undo actions with slider controls. We want to be able to
                // undo every onMouseUp; so we overrite the same undo action when necessary in order
                // to achieve this desired effect.
                SimObject last = undoManager.getUndoAction((undoManager.getUndoCount() - 1));
                if ((last != -1) && (last["isSlider"].AsBool()) && (!last["onMouseUp"].AsBool()))
                    {
                    last["field"] = propertyField;
                    last["isSlider"] = isSlider.AsString();
                    last["onMouseUp"] = onMouseUp.AsString();
                    last["newValue"] = value;
                    }
                else
                    {
                    MaterialEditorUndo.ActionUpdateActiveMaterial action = this.createUndo<MaterialEditorUndo.ActionUpdateActiveMaterial>("Update Active Material");
                    action["material"] = this.currentMaterial;
                    action["object"] = this.currentObject;
                    action["field"] = propertyField;
                    action["isSlider"] = isSlider.AsString();
                    action["onMouseUp"] = onMouseUp.AsString();
                    action["newValue"] = value;
                    action["oldValue"] = this.currentMaterial[propertyField];
                    action["oldValue"] = "\"" + action["oldValue"] + "\"";
                    this.submitUndo(action);
                    }

                materialEd_previewMaterial[propertyField] = Util.strreplace(value, "\"", "");
                materialEd_previewMaterial.flush();
                materialEd_previewMaterial.reload();

                if (this["livePreview"].AsBool())
                    {
                    this.currentMaterial[propertyField] = Util.strreplace(value, "\"", "");
                    ;
                    this.currentMaterial.flush();
                    this.currentMaterial.reload();
                    }
            }

            [ConsoleInteraction]
            public void updateActiveMaterialName(string name)
            {
                MaterialEditorUndo.ActionUpdateActiveMaterialName action = this.createUndo<MaterialEditorUndo.ActionUpdateActiveMaterialName>("Update Active Material Name");
                action["material"] = this.currentMaterial;
                action["object"] = this.currentObject;
                action["oldName"] = this.currentMaterial.getName();
                action["newName"] = name;
                this.submitUndo(action);

                this.currentMaterial.setName(name);

                // Some objects (ConvexShape, DecalRoad etc) reference Materials by name => need
                // to find and update all these references so they don't break when we rename the
                // Material.
                this.updateMaterialReferences("MissionGroup", action["oldName"], action["newName"]);
            }

            [ConsoleInteraction]
            public void updateMaterialReferences(SimObject obj, string oldName, string newName)
            {
                if (obj.isMemberOfClass("SimSet"))
                    {
                    // invoke on children
                    int count = obj.call("getCount").AsInt();
                    for (int i = 0; i < count; i++)
                        this.updateMaterialReferences(obj.call("getObject", i.AsString()), oldName, newName);
                    }
                else
                    {
                    bool objChanged = false;

                    // Change all material fields that use the old material name
                    int count = obj.getFieldCount();
                    for (int i = 0; i < count; i++)
                        {
                        string fieldName = obj.getField(i);
                        if ((obj.getFieldType(fieldName) == "TypeMaterialName") && (obj.getFieldValue(fieldName, -1) == oldName))
                            {
                            obj[fieldName] = newName;
                            objChanged = true;
                            }
                        }

                    ((EWorldEditor) "EWorldEditor").isDirty = objChanged;
                    if (objChanged && obj.isMethod("postApply"))
                        obj.call("postApply");
                    }
            }

            // Global Material Options

            [ConsoleInteraction]
            public void updateReflectionType(string type)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiButtonCtrl matEd_cubemapEditBtn = MaterialEditorPropertiesWindow.FOT("matEd_cubemapEditBtn");
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                if (type == "None")
                    {
                    matEd_cubemapEditBtn.setVisible(false);
                    //Reset material reflection settings on the preview materials
                    this.updateActiveMaterial("cubemap", "");
                    this.updateActiveMaterial("dynamicCubemap", false.AsString());
                    this.updateActiveMaterial("planarReflection", false.AsString());
                    }
                else
                    {
                    if (type == "cubemap")
                        {
                        matEd_cubemapEditBtn.setVisible(true);
                        this.updateActiveMaterial(type, materialEd_previewMaterial.cubemap);
                        }
                    else
                        this.updateActiveMaterial(type, true.AsString());
                    }
            }

            // Per-Layer Material Options

            // For update maps
            // action : 1 = change map
            // action : 0 = remove map

            [ConsoleInteraction]
            public void updateTextureMap(string type, bool action)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";

                string layer = this["currentLayer"];

                GuiBitmapCtrl bitmapCtrl = MaterialEditorPropertiesWindow.findObjectByInternalName(type + "MapDisplayBitmap", true);
                GuiTextCtrl textCtrl = MaterialEditorPropertiesWindow.findObjectByInternalName(type + "MapNameText", true);

                if (action)
                    {
                    string texture = this.openFile("texture");
                    if (texture != "")
                        {
                        bitmapCtrl.setBitmapX(texture);

                        string bitmap = bitmapCtrl["bitmap"];
                        bitmap = Util.strreplace(bitmap, "tools/materialEditor/scripts/", "");
                        bitmapCtrl.setBitmapX(bitmap);
                        textCtrl.setText(bitmap);
                        this.updateActiveMaterial(type + "Map[" + layer + "]", "\"" + bitmap + "\"");
                        }
                    }
                else
                    {
                    textCtrl.setText("None");
                    bitmapCtrl.setBitmapX("tools/materialeditor/gui/unknownImage");
                    this.updateActiveMaterial(type + "Map[" + layer + "]", "");
                    }
            }

            [ConsoleInteraction]
            public void updateDetailScale(string newScale)
            {
                string layer = this["currentLayer"];

                string detailScale = "\"" + newScale + ' ' + newScale + "\"";
                this.updateActiveMaterial("detailScale[" + layer + "]", detailScale);
            }

            [ConsoleInteraction]
            public void updateDetailNormalStrength(string newStrength)
            {
                string layer = this["currentLayer"];

                string detailStrength = "\"" + newStrength + "\"";
                this.updateActiveMaterial("detailNormalMapStrength[" + layer + "]", detailStrength);
            }

            [ConsoleInteraction]
            public void updateSpecMap(bool action)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextCtrl specMapNameText = MaterialEditorPropertiesWindow.FOT("specMapNameText");
                GuiBitmapCtrl specMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("specMapDisplayBitmap");

                string layer = this["currentLayer"];

                if (action)
                    {
                    string texture = this.openFile("texture");
                    if (texture != "")
                        {
                        this.updateActiveMaterial("pixelSpecular[" + this["currentLayer"] + "]", "0");

                        specMapDisplayBitmap.setBitmapX(texture);

                        string bitmap = specMapDisplayBitmap["bitmap"];
                        bitmap = Util.strreplace(bitmap, "tools/materialEditor/scripts/", "");
                        specMapDisplayBitmap.setBitmapX(bitmap);
                        specMapNameText.setText(bitmap);
                        this.updateActiveMaterial("specularMap[" + layer + "]", "\"" + bitmap + "\"");
                        }
                    }
                else
                    {
                    specMapNameText.setText("None");
                    specMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    this.updateActiveMaterial("specularMap[" + layer + "]", "");
                    }

                this.guiSync("materialEd_previewMaterial");
            }

            [ConsoleInteraction]
            public void updateAccuMap(bool action)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextCtrl accuMapNameText = MaterialEditorPropertiesWindow.FOT("accuMapNameText");
                GuiBitmapCtrl accuMapDisplayBitmap = MaterialEditorPropertiesWindow.FOT("accuMapDisplayBitmap");

                string layer = this["currentLayer"];

                if (action)
                    {
                    string texture = this.openFile("texture");
                    if (texture != "")
                        {
                        accuMapDisplayBitmap.setBitmapX(texture);

                        string bitmap = accuMapDisplayBitmap["bitmap"];
                        bitmap = Util.strreplace(bitmap, "tools/materialEditor/scripts/", "");
                        accuMapDisplayBitmap.setBitmapX(bitmap);
                        accuMapNameText.setText(bitmap);
                        this.updateActiveMaterial("accuMap[" + layer + "]", "\"" + bitmap + "\"");
                        }
                    }
                else
                    {
                    accuMapNameText.setText("None");
                    accuMapDisplayBitmap.setBitmapX("tools/materialeditor/gui/unknownImage");
                    this.updateActiveMaterial("accuMap[" + layer + "]", "");
                    }

                this.guiSync("materialEd_previewMaterial");
            }

            [ConsoleInteraction]
            public void updateRotationOffset(bool isSlider, bool onMouseUp)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextEditCtrl RotationTextEditU = MaterialEditorPropertiesWindow.FOT("RotationTextEditU");
                GuiTextEditCtrl RotationTextEditV = MaterialEditorPropertiesWindow.FOT("RotationTextEditV");
                GuiBitmapCtrl RotationCrosshair = MaterialEditorPropertiesWindow.FOT("RotationCrosshair");

                string layer = this["currentLayer"];
                string X = RotationTextEditU.getText();
                string Y = RotationTextEditV.getText();
                RotationCrosshair.setPosition((int) (45*Util.mAbs(X.AsFloat()) - 2), (int) (45*Util.mAbs(Y.AsFloat()) - 2));

                this.updateActiveMaterial("rotPivotOffset[" + layer + "]", "\"" + X + ' ' + Y + "\"", isSlider, onMouseUp);
            }

            [ConsoleInteraction]
            public void updateRotationSpeed(bool isSlider, bool onMouseUp)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextEditCtrl RotationSpeedTextEdit = MaterialEditorPropertiesWindow.FOT("RotationSpeedTextEdit");

                string layer = this["currentLayer"];
                string speed = RotationSpeedTextEdit.getText();
                this.updateActiveMaterial("rotSpeed[" + layer + "]", speed, isSlider, onMouseUp);
            }

            [ConsoleInteraction]
            public void updateScrollOffset(bool isSlider, bool onMouseUp)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextEditCtrl ScrollTextEditU = MaterialEditorPropertiesWindow.FOT("ScrollTextEditU");
                GuiTextEditCtrl ScrollTextEditV = MaterialEditorPropertiesWindow.FOT("ScrollTextEditV");
                GuiBitmapCtrl ScrollCrosshair = MaterialEditorPropertiesWindow.FOT("ScrollCrosshair");

                string layer = this["currentLayer"];
                string X = ScrollTextEditU.getText();
                string Y = ScrollTextEditV.getText();
                ScrollCrosshair.setPosition((int) -(23*X.AsFloat()) + 20, (int) -(23*Y.AsFloat()) + 20);

                this.updateActiveMaterial("scrollDir[" + layer + "]", "\"" + X + ' ' + Y + "\"", isSlider, onMouseUp);
            }

            [ConsoleInteraction]
            public void updateScrollSpeed(bool isSlider, bool onMouseUp)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextEditCtrl ScrollSpeedTextEdit = MaterialEditorPropertiesWindow.FOT("ScrollSpeedTextEdit");

                string layer = this["currentLayer"];
                string speed = ScrollSpeedTextEdit.getText();
                this.updateActiveMaterial("scrollSpeed[" + layer + "]", speed, isSlider, onMouseUp);
            }

            [ConsoleInteraction]
            public void updateWaveType()
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiContainer WaveButtonContainer = "WaveButtonContainer";
                string type = "";

                for (uint radioButton = 0; radioButton < WaveButtonContainer.getCount(); radioButton++)
                    {
                    if (((GuiBitmapButtonCtrl) WaveButtonContainer.getObject(radioButton)).getValue().AsInt() == 1)
                        type = ((GuiBitmapButtonCtrl) WaveButtonContainer.getObject(radioButton))["waveType"];
                    }

                string layer = this["currentLayer"];
                this.updateActiveMaterial("waveType[" + layer + "]", type);
            }

            [ConsoleInteraction]
            public void updateWaveAmp(bool isSlider, bool onMouseUp)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextEditCtrl WaveTextEditAmp = MaterialEditorPropertiesWindow.FOT("WaveTextEditAmp");

                string layer = this["currentLayer"];
                string amp = WaveTextEditAmp.getText();
                this.updateActiveMaterial("waveAmp[" + layer + "]", amp, isSlider, onMouseUp);
            }

            [ConsoleInteraction]
            public void updateWaveFreq(bool isSlider, bool onMouseUp)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextEditCtrl WaveTextEditFreq = MaterialEditorPropertiesWindow.FOT("WaveTextEditFreq");

                string layer = this["currentLayer"];
                string freq = WaveTextEditFreq.getText();
                this.updateActiveMaterial("waveFreq[" + layer + "]", freq, isSlider, onMouseUp);
            }

            [ConsoleInteraction]
            public void updateSequenceFPS(bool isSlider, bool onMouseUp)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextEditCtrl SequenceTextEditFPS = MaterialEditorPropertiesWindow.FOT("SequenceTextEditFPS");

                string layer = this["currentLayer"];
                string fps = SequenceTextEditFPS.getText();
                this.updateActiveMaterial("sequenceFramePerSec[" + layer + "]", fps, isSlider, onMouseUp);
            }

            [ConsoleInteraction]
            public void updateSequenceSSS(bool isSlider, bool onMouseUp)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiTextEditCtrl SequenceTextEditSSS = MaterialEditorPropertiesWindow.FOT("SequenceTextEditSSS");

                string layer = this["currentLayer"];
                string sss = (1/SequenceTextEditSSS.getText().AsFloat()).AsString();
                this.updateActiveMaterial("sequenceSegmentSize[" + layer + "]", sss, isSlider, onMouseUp);
            }

            [ConsoleInteraction]
            public void updateAnimationFlags()
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiCheckBoxCtrl RotationAnimation = MaterialEditorPropertiesWindow.FOT("RotationAnimation");
                GuiCheckBoxCtrl ScrollAnimation = MaterialEditorPropertiesWindow.FOT("ScrollAnimation");
                GuiCheckBoxCtrl WaveAnimation = MaterialEditorPropertiesWindow.FOT("WaveAnimation");
                GuiCheckBoxCtrl ScaleAnimation = MaterialEditorPropertiesWindow.FOT("ScaleAnimation");
                GuiCheckBoxCtrl SequenceAnimation = MaterialEditorPropertiesWindow.FOT("SequenceAnimation");
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                this.setMaterialDirty();
                bool single = true;
                string flags = "";

                if (RotationAnimation.getValue().AsBool())
                    {
                    if (single)
                        flags = flags + "$Rotate";
                    else
                        flags = flags + " | $Rotate";

                    single = false;
                    }
                if (ScrollAnimation.getValue().AsBool())
                    {
                    if (single)
                        flags = flags + "$Scroll";
                    else
                        flags = flags + " | $Scroll";

                    single = false;
                    }
                if (WaveAnimation.getValue().AsBool())
                    {
                    if (single)
                        flags = flags + "$Wave";
                    else
                        flags = flags + " | $Wave";

                    single = false;
                    }
                if (ScaleAnimation.getValue().AsBool())
                    {
                    if (single)
                        flags = flags + "$Scale";
                    else
                        flags = flags + " | $Scale";

                    single = false;
                    }
                if (SequenceAnimation.getValue().AsBool())
                    {
                    if (single)
                        flags = flags + "$Sequence";
                    else
                        flags = flags + " | $Sequence";

                    single = false;
                    }

                if (flags == "")
                    flags = "\"\"";

                MaterialEditorUndo.ActionUpdateActiveMaterialAnimationFlags action = this.createUndo<MaterialEditorUndo.ActionUpdateActiveMaterialAnimationFlags>("Update Active Material");
                action["material"] = this.currentMaterial;
                action["object"] = this.currentObject;
                action["layer"] = this["currentLayer"];

                action["newValue"] = flags;

                string oldFlags = this.currentMaterial.getAnimFlags(this["currentLayer"].AsUint());
                if (oldFlags == "")
                    oldFlags = "\"\"";

                action["oldValue"] = oldFlags;
                this.submitUndo(action);

                Util.eval("materialEd_previewMaterial.animFlags[" + this["currentLayer"] + "] = " + flags + ";");
                materialEd_previewMaterial.flush();
                materialEd_previewMaterial.reload();

                if (this["livePreview"].AsBool())
                    {
                    Util.eval("MaterialEditorGui.currentMaterial.animFlags[" + this["currentLayer"] + "] =" + flags + ";");
                    this.currentMaterial.flush();
                    this.currentMaterial.reload();
                    }
            }

            //==============================================================================
            // Color Picker Helpers - They are all using colorPicker.ed.gui in order to function
            // These functions are mainly passed callbacks from getColorI/getColorF callbacks

            [ConsoleInteraction]
            public void syncGuiColor(GuiSwatchButtonCtrl guiCtrl, string propName, string color)
            {
                string layer = this["currentLayer"];

                string r = Util.getWord(color, 0);
                string g = Util.getWord(color, 1);
                string b = Util.getWord(color, 2);
                string a = Util.getWord(color, 3);

                string colorSwatch = (r + ' ' + g + ' ' + b + ' ' + a);
                color = "\"" + r + ' ' + g + ' ' + b + ' ' + a + "\"";

                guiCtrl["color"] = colorSwatch;
                this.updateActiveMaterial(propName, color);
            }

            //These two functions are focused on object/layer specific functionality

            [ConsoleInteraction]
            public void updateColorMultiply(string color)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiSwatchButtonCtrl colorTintSwatch = MaterialEditorPropertiesWindow.FOT("colorTintSwatch");

                string propName = "diffuseColor[" + this["currentLayer"] + "]";
                this.syncGuiColor(colorTintSwatch, propName, color);
            }

            [ConsoleInteraction]
            public void updateSpecularCheckbox(string value)
            {
                this.updateActiveMaterial("pixelSpecular[" + this["currentLayer"] + "]", value);
                this.guiSync("materialEd_previewMaterial");
            }

            [ConsoleInteraction]
            public void updateSpecular(string color)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiSwatchButtonCtrl specularColorSwatch = MaterialEditorPropertiesWindow.FOT("specularColorSwatch");

                string propName = "specular[" + this["currentLayer"] + "]";
                this.syncGuiColor(specularColorSwatch, propName, color);
            }

            [ConsoleInteraction]
            public void updateSubSurfaceColor(string color)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiSwatchButtonCtrl subSurfaceColorSwatch = MaterialEditorPropertiesWindow.FOT("subSurfaceColorSwatch");

                string propName = "subSurfaceColor[" + this["currentLayer"] + "]";
                this.syncGuiColor(subSurfaceColorSwatch, propName, color);
            }

            [ConsoleInteraction]
            public void updateEffectColor0(string color)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiSwatchButtonCtrl effectColor0Swatch = MaterialEditorPropertiesWindow.FOT("effectColor0Swatch");

                this.syncGuiColor(effectColor0Swatch, "effectColor[0]", color);
            }

            [ConsoleInteraction]
            public void updateEffectColor1(string color)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                GuiSwatchButtonCtrl effectColor1Swatch = MaterialEditorPropertiesWindow.FOT("effectColor1Swatch");

                this.syncGuiColor(effectColor1Swatch, "effectColor[1]", color);
            }

            [ConsoleInteraction]
            public void updateBehaviorSound(string type, string sound)
            {
                int defaultId = -1;
                string customName = "";

                switch (sound)
                    {
                        case "<Soft>":
                            defaultId = 0;
                            break;
                        case "<Hard>":
                            defaultId = 1;
                            break;
                        case "<Metal>":
                            defaultId = 2;
                            break;
                        case "<Snow>":
                            defaultId = 3;
                            break;
                        default:
                            customName = sound;
                            break;
                    }

                this.updateActiveMaterial(type + "SoundId", defaultId.AsString());
                this.updateActiveMaterial("custom" + type + "Sound", customName);
            }

            [ConsoleInteraction]
            public void updateSoundPopup(string type, string defaultId, string customName)
            {
                GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                string name = "";

                GuiPopUpMenuCtrl ctrl = MaterialEditorPropertiesWindow.findObjectByInternalName(type + "SoundPopup", true);

                switch (defaultId)
                    {
                        case "0":
                            name = "<Soft>";
                            break;
                        case "1":
                            name = "<Hard>";
                            break;
                        case "2":
                            name = "<Metal>";
                            break;
                        case "3":
                            name = "<Snow>";
                            break;
                        default:
                            name = customName == "" ? "<None>" : customName;
                            break;
                    }

                int r = ctrl.findText(name);
                if (r != -1)
                    ctrl.setSelected(r, false);
                else
                    ctrl.setText(name);
            }

            //These two functions are focused on environment specific functionality

            [ConsoleInteraction]
            public void updateLightColor(string color)
            {
                GuiMaterialPreview matEd_previewObjectView = "matEd_previewObjectView";
                GuiSwatchButtonCtrl matEd_lightColorPicker = "matEd_lightColorPicker";

                matEd_previewObjectView.setLightColor(color.AsColorF());
                matEd_lightColorPicker["color"] = color;
            }

            [ConsoleInteraction]
            public void updatePreviewBackground(string color)
            {
                GuiSwatchButtonCtrl matEd_previewBackground = "matEd_previewBackground";
                GuiSwatchButtonCtrl MaterialPreviewBackgroundPicker = "MaterialPreviewBackgroundPicker";

                matEd_previewBackground["color"] = color;
                MaterialPreviewBackgroundPicker["color"] = color;
            }

            [ConsoleInteraction]
            public void updateAmbientColor(string color)
            {
                GuiMaterialPreview matEd_previewObjectView = "matEd_previewObjectView";
                GuiSwatchButtonCtrl matEd_ambientLightColorPicker = "matEd_ambientLightColorPicker";

                matEd_previewObjectView.setAmbientLightColor(color.AsColorF());
                matEd_ambientLightColorPicker["color"] = color;
            }

            //==============================================================================
            // Commands for the Cubemap Editor

            [ConsoleInteraction]
            public void selectCubemap()
            {
                CubemapData cubemap = this["currentCubemap"];
                if (!cubemap.isObject())
                    return;

                this.updateActiveMaterial("cubemap", cubemap["name"]);
                this.hideCubemapEditor(false);
            }

            [ConsoleInteraction]
            public void cancelCubemap()
            {
                CubemapData cubemap = this["currentCubemap"];
                CubemapData notDirtyCubemap = "notDirtyCubemap";
                CubemapData matEdCubeMapPreviewMat = "matEdCubeMapPreviewMat";
                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";

                int idx = matEd_cubemapEd_availableCubemapList.findItemText(cubemap.getName(), false);
                matEd_cubemapEd_availableCubemapList.setItemText(idx, notDirtyCubemap["originalName"]);
                cubemap.setName(notDirtyCubemap["originalName"]);

                this.copyCubemaps(notDirtyCubemap, cubemap);
                this.copyCubemaps(notDirtyCubemap, matEdCubeMapPreviewMat);

                cubemap.updateFaces();
                matEdCubeMapPreviewMat.updateFaces();
            }

            [ConsoleInteraction]
            public void showCubemapEditor()
            {
                GuiWindowCtrl matEd_cubemapEditor = "matEd_cubemapEditor";
                SimSet RootGroup = "RootGroup";
                ArrayObject UnlistedCubemaps = "UnlistedCubemaps";
                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";
                CubemapData cubemap;

                if (matEd_cubemapEditor.isVisible())
                    return;

                this["currentCubemap"] = "";

                matEd_cubemapEditor.setVisible(true);
                new ObjectCreator("PersistenceManager", "matEd_cubemapEdPerMan").Create();
                this.setCubemapNotDirty();

                for (uint i = 0; i < RootGroup.getCount(); i++)
                    {
                    if (((SimObject) RootGroup.getObject(i)).getClassName() != "CubemapData")
                        continue;

                    bool unlistedFound = false;
                    for (int k = 0; k < UnlistedCubemaps.count(); k++)
                        {
                        unlistedFound = false;
                        if (UnlistedCubemaps.getValue(k) == ((SimObject) RootGroup.getObject(i))["name"])
                            {
                            unlistedFound = true;
                            break;
                            }
                        }

                    if (unlistedFound)
                        continue;

                    matEd_cubemapEd_availableCubemapList.addItem(((SimObject) RootGroup.getObject(i))["name"], "0.0 0.0 1.0");
                    }

                CubemapData notDirtyCubemap = new SingletonCreator("CubemapData", "notDirtyCubemap").Create();

                // if there was no cubemap, pick the first, select, and bail, these are going to take
                // care of themselves in the selected function
                if (!this.currentMaterial.cubemap.isObject())
                    {
                    if (matEd_cubemapEd_availableCubemapList.getItemCount() > 0)
                        {
                        matEd_cubemapEd_availableCubemapList.setSelected(0, true);
                        return;
                        }
                    else
                        {
                        // if there are no cubemaps, then create one, select, and bail
                        cubemap = this.createNewCubemap("");
                        matEd_cubemapEd_availableCubemapList.addItem(cubemap["name"], "0.0 0.0 1.0");
                        matEd_cubemapEd_availableCubemapList.setSelected(0, true);
                        return;
                        }
                    }

                // do not directly change activeMat!
                this["currentCubemap"] = this.currentMaterial.cubemap.getID().AsString();
                cubemap = this["currentCubemap"];

                notDirtyCubemap["originalName"] = cubemap.getName();
                this.copyCubemaps(cubemap, notDirtyCubemap);
                this.copyCubemaps(cubemap, "matEdCubeMapPreviewMat");
                this.syncCubemap(cubemap);
            }

            [ConsoleInteraction]
            public void hideCubemapEditor(bool cancel)
            {
                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";
                PersistenceManager matEd_cubemapEdPerMan = "matEd_cubemapEdPerMan";
                GuiWindowCtrl matEd_cubemapEditor = "matEd_cubemapEditor";
                if (cancel)
                    this.cancelCubemap();

                matEd_cubemapEd_availableCubemapList.clearItems();
                matEd_cubemapEdPerMan.delete();
                matEd_cubemapEditor.setVisible(false);
            }

            // create category and update current material if there is one

            [ConsoleInteraction]
            public void addCubemap(string cubemapName)
            {
                SimSet RootGroup = "RootGroup";
                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";
                GuiWindowCtrl matEd_addCubemapWindow = "matEd_addCubemapWindow";
                GuiTextEditCtrl matEd_addCubemapWindowCubemapName = matEd_addCubemapWindow.FOT("cubemapName");

                if (cubemapName == "")
                    {
                    messageBox.MessageBoxOK("Error", "Can not create a cubemap without a valid name.");
                    return;
                    }

                for (uint i = 0; i < RootGroup.getCount(); i++)
                    {
                    if (cubemapName == RootGroup.getObject(i).getName())
                        {
                        messageBox.MessageBoxOK("Error", "There is already an object with the same name.");
                        return;
                        }
                    }

                // Create and select a new cubemap
                CubemapData cubemap = this.createNewCubemap(cubemapName);
                int idx = matEd_cubemapEd_availableCubemapList.addItem(cubemap["name"], "0.0 0.0 1.0");
                matEd_cubemapEd_availableCubemapList.setSelected(idx, true);

                // material category text field to blank
                matEd_addCubemapWindowCubemapName.setText("");
            }

            [ConsoleInteraction]
            public string createNewCubemap(string cubemap)
            {
                PersistenceManager matEd_cubemapEdPerMan = "matEd_cubemapEdPerMan";

                if (cubemap == "")
                    {
                    for (int i = 0;; i++)
                        {
                        cubemap = "newCubemap_" + i;
                        if (!cubemap.isObject())
                            break;
                        }
                    }

                #region CubemapData (cubemap)        oc_Newobject9

                ObjectCreator oc_Newobject9 = new ObjectCreator("CubemapData", cubemap);
                oc_Newobject9["cubeFace[0]"] = "tools/materialeditor/gui/cube_xNeg";
                oc_Newobject9["cubeFace[1]"] = "tools/materialeditor/gui/cube_xPos";
                oc_Newobject9["cubeFace[2]"] = "tools/materialeditor/gui/cube_ZNeg";
                oc_Newobject9["cubeFace[3]"] = "tools/materialeditor/gui/cube_ZPos";
                oc_Newobject9["cubeFace[4]"] = "tools/materialeditor/gui/cube_YNeg";
                oc_Newobject9["cubeFace[5]"] = "tools/materialeditor/gui/cube_YPos";
                oc_Newobject9["parentGroup"] = new Creator.StringNoQuote("RootGroup");

                #endregion

                cubemap = oc_Newobject9.Create().AsString();

                matEd_cubemapEdPerMan.setDirty(cubemap, "art/materials.cs");
                matEd_cubemapEdPerMan.saveDirty();

                return cubemap;
            }

            [ConsoleInteraction]
            public void setCubemapDirty()
            {
                GuiWindowCtrl matEd_cubemapEditor = "matEd_cubemapEditor";
                GuiBitmapButtonCtrl saveCubemap = matEd_cubemapEditor.FOT("saveCubemap");
                PersistenceManager matEd_cubemapEdPerMan = "matEd_cubemapEdPerMan";

                const string propertyText = "Create Cubemap *";
                matEd_cubemapEditor["text"] = propertyText;
                matEd_cubemapEditor["dirty"] = true.AsString();
                saveCubemap.setActive(true);

                CubemapData cubemap = this["currentCubemap"];

                // materials created in the materail selector are given that as its filename, so we run another check
                if (this.isMatEditorMaterial(cubemap))
                    matEd_cubemapEdPerMan.setDirty(cubemap, "art/materials.cs");
                else
                    matEd_cubemapEdPerMan.setDirty(cubemap);
            }

            [ConsoleInteraction]
            public void setCubemapNotDirty()
            {
                GuiWindowCtrl matEd_cubemapEditor = "matEd_cubemapEditor";
                GuiBitmapButtonCtrl saveCubemap = matEd_cubemapEditor.FOT("saveCubemap");
                PersistenceManager matEd_cubemapEdPerMan = "matEd_cubemapEdPerMan";

                string propertyText = Util.strreplace("Create Cubemap", "*", "");

                matEd_cubemapEditor.text = propertyText;
                matEd_cubemapEditor["dirty"] = false.AsString();
                saveCubemap.setActive(false);

                CubemapData cubemap = this["currentCubemap"];
                matEd_cubemapEdPerMan.removeDirty(cubemap);
            }

            [ConsoleInteraction]
            public void showDeleteCubemapDialog()
            {
                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";

                int idx = matEd_cubemapEd_availableCubemapList.getSelectedItem();
                CubemapData cubemap = matEd_cubemapEd_availableCubemapList.getItemText(idx);
                cubemap = cubemap.getId();

                if (cubemap == -1 || !cubemap.isObject())
                    return;

                if (cubemap.isObject())
                    messageBox.MessageBoxYesNoCancel("Delete Cubemap?", "Are you sure you want to delete<br><br>" + cubemap.getName() + "<br><br> Cubemap deletion won't take affect until the engine is quit.", "MaterialEditorGui.deleteCubemap( " + cubemap + ", " + idx + " );", "", "");
            }

            [ConsoleInteraction]
            public void deleteCubemap(CubemapData cubemap, int idx)
            {
                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";
                ArrayObject UnlistedCubemaps = "UnlistedCubemaps";
                PersistenceManager matEd_cubemapEdPerMan = "matEd_cubemapEdPerMan";

                matEd_cubemapEd_availableCubemapList.deleteItem(idx);

                UnlistedCubemaps.add("unlistedCubemaps", cubemap.getName());

                if (!this.isMatEditorMaterial(cubemap))
                    {
                    matEd_cubemapEdPerMan.removeDirty(cubemap);
                    matEd_cubemapEdPerMan.removeObjectFromFile(cubemap);
                    }

                if (matEd_cubemapEd_availableCubemapList.getItemCount() > 0)
                    matEd_cubemapEd_availableCubemapList.setSelected(0, true);
                else
                    {
                    // if there are no cubemaps, then create one, select, and bail
                    cubemap = this.createNewCubemap("");
                    matEd_cubemapEd_availableCubemapList.addItem(cubemap.getName(), "0.0 0.0 1.0");
                    matEd_cubemapEd_availableCubemapList.setSelected(0, true);
                    }
            }

            [ConsoleInteraction]
            public void showSaveCubemapDialog()
            {
                CubemapData cubemap = this["currentCubemap"];
                if (!cubemap.isObject())
                    return;

                messageBox.MessageBoxYesNoCancel("Save Cubemap?", "Do you want to save changes to <br><br>" + cubemap.getName(), "MaterialEditorGui.saveCubemap( " + cubemap + " );", "", "");
            }

            [ConsoleInteraction]
            public void saveCubemap(string cubemap)
            {
                CubemapData notDirtyCubemap = "notDirtyCubemap";
                PersistenceManager matEd_cubemapEdPerMan = "matEd_cubemapEdPerMan";

                notDirtyCubemap["originalName"] = cubemap.getName();
                this.copyCubemaps(cubemap, notDirtyCubemap);
                this.copyCubemaps(cubemap, "matEdCubeMapPreviewMat");

                matEd_cubemapEdPerMan.saveDirty();

                this.setCubemapNotDirty();
            }

            [ConsoleInteraction]
            public void saveCubemapDialogDontSave(CubemapData newCubemap)
            {
                //deal with old cubemap first
                CubemapData oldCubemap = this["currentCubemap"];
                CubemapData notDirtyCubemap = "notDirtyCubemap";

                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";

                int idx = matEd_cubemapEd_availableCubemapList.findItemText(oldCubemap.getName(), false);
                matEd_cubemapEd_availableCubemapList.setItemText(idx, notDirtyCubemap["originalName"]);
                oldCubemap.setName(notDirtyCubemap["originalName"]);

                this.copyCubemaps(notDirtyCubemap, oldCubemap);
                this.copyCubemaps(notDirtyCubemap, "matEdCubeMapPreviewMat");
                this.syncCubemap(oldCubemap);

                this.changeCubemap(newCubemap);
            }

            [ConsoleInteraction]
            public void saveCubemapDialogCancel()
            {
                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";

                CubemapData cubemap = this["currentCubemap"];
                int idx = matEd_cubemapEd_availableCubemapList.findItemText(cubemap.getName(), false);
                matEd_cubemapEd_availableCubemapList.clearSelection();
                matEd_cubemapEd_availableCubemapList.setSelected(idx, true);
            }

            [ConsoleInteraction]
            public void changeCubemap(CubemapData cubemap)
            {
                CubemapData notDirtyCubemap = "notDirtyCubemap";

                this.setCubemapNotDirty();
                this["currentCubemap"] = cubemap;

                notDirtyCubemap["originalName"] = cubemap.getName();
                this.copyCubemaps(cubemap, notDirtyCubemap);
                this.copyCubemaps(cubemap, "matEdCubeMapPreviewMat");
                this.syncCubemap(cubemap);
            }

            [ConsoleInteraction]
            public void editCubemapImage(string face)
            {
                this.setCubemapDirty();

                CubemapData cubemap = this["currentCubemap"];
                string bitmap = this.openFile("texture");
                if (bitmap != "" && bitmap != "tools/materialEditor/gui/cubemapBtnBorder")
                    {
                    cubemap["cubeFace[" + face + "]"] = bitmap;
                    this.copyCubemaps(cubemap, "matEdCubeMapPreviewMat");
                    this.syncCubemap(cubemap);
                    }
            }

            [ConsoleInteraction]
            public void editCubemapName(string newName)
            {
                GuiListBoxCtrl matEd_cubemapEd_availableCubemapList = "matEd_cubemapEd_availableCubemapList";

                this.setCubemapDirty();

                CubemapData cubemap = this["currentCubemap"];

                int idx = matEd_cubemapEd_availableCubemapList.findItemText(cubemap.getName(), false);
                matEd_cubemapEd_availableCubemapList.setItemText(idx, newName);
                cubemap.setName(newName);

                this.syncCubemap(cubemap);
            }

            [ConsoleInteraction]
            public void syncCubemap(CubemapData cubemap)
            {
                GuiBitmapCtrl matEd_cubemapEd_XPos = "matEd_cubemapEd_XPos";
                GuiBitmapCtrl matEd_cubemapEd_XNeg = "matEd_cubemapEd_XNeg";
                GuiBitmapCtrl matEd_cubemapEd_YNeG = "matEd_cubemapEd_YNeG";
                GuiBitmapCtrl matEd_cubemapEd_YPos = "matEd_cubemapEd_YPos";
                GuiBitmapCtrl matEd_cubemapEd_ZPos = "matEd_cubemapEd_ZPos";
                GuiBitmapCtrl matEd_cubemapEd_ZNeg = "matEd_cubemapEd_ZNeg";
                GuiTextEditCtrl matEd_cubemapEd_activeCubemapNameTxt = "matEd_cubemapEd_activeCubemapNameTxt";
                CubemapData matEdCubeMapPreviewMat = "matEdCubeMapPreviewMat";

                string xpos = this.searchForTexture(cubemap.getName(), cubemap["cubeFace[0]"]);
                if (xpos != "")
                    matEd_cubemapEd_XPos.setBitmapX(xpos);

                string xneg = this.searchForTexture(cubemap.getName(), cubemap["cubeFace[1]"]);
                if (xneg != "")
                    matEd_cubemapEd_XNeg.setBitmapX(xneg);

                string yneg = this.searchForTexture(cubemap.getName(), cubemap["cubeFace[2]"]);
                if (yneg != "")
                    matEd_cubemapEd_YNeG.setBitmapX(yneg);

                string ypos = this.searchForTexture(cubemap.getName(), cubemap["cubeFace[3]"]);
                if (ypos != "")
                    matEd_cubemapEd_YPos.setBitmapX(ypos);

                string zpos = this.searchForTexture(cubemap.getName(), cubemap["cubeFace[4]"]);
                if (zpos != "")
                    matEd_cubemapEd_ZPos.setBitmapX(zpos);

                string zneg = this.searchForTexture(cubemap.getName(), cubemap["cubeFace[5]"]);
                if (zneg != "")
                    matEd_cubemapEd_ZNeg.setBitmapX(zneg);

                matEd_cubemapEd_activeCubemapNameTxt.setText(cubemap.getName());

                cubemap.updateFaces();
                matEdCubeMapPreviewMat.updateFaces();
            }

            [ConsoleInteraction]
            public void copyCubemaps(CubemapData copyFrom, CubemapData copyTo)
            {
                copyTo["cubeFace[0]"] = copyFrom["cubeFace[0]"];
                copyTo["cubeFace[1]"] = copyFrom["cubeFace[1]"];
                copyTo["cubeFace[2]"] = copyFrom["cubeFace[2]"];
                copyTo["cubeFace[3]"] = copyFrom["cubeFace[3]"];
                copyTo["cubeFace[4]"] = copyFrom["cubeFace[4]"];
                copyTo["cubeFace[5]"] = copyFrom["cubeFace[5]"];
            }

            //==============================================================================
            // showSaveDialog logic

            [ConsoleInteraction]
            public void showSaveDialog(Material toMaterial)
            {
                messageBox.MessageBoxYesNoCancel("Save Material?", "The material " + this.currentMaterial.getName() + " has unsaved changes. <br>Do you want to save?", "MaterialEditorGui.saveDialogSave(" + toMaterial + ");", "MaterialEditorGui.saveDialogDontSave(" + toMaterial + ");", "MaterialEditorGui.saveDialogCancel();");
            }

            [ConsoleInteraction]
            public void showMaterialChangeSaveDialog(Material toMaterial)
            {
                Material fromMaterial = this.currentMaterial;

                messageBox.MessageBoxYesNoCancel("Save Material?", "The material " + fromMaterial.getName() + " has unsaved changes. <br>Do you want to save before changing the material?", "MaterialEditorGui.saveDialogSave(" + toMaterial + "); MaterialEditorGui.changeMaterial(" + fromMaterial + ", " + toMaterial + ");", "MaterialEditorGui.saveDialogDontSave(" + toMaterial + "); MaterialEditorGui.changeMaterial(" + fromMaterial + ", " + toMaterial + ");", "MaterialEditorGui.saveDialogCancel();");
            }

            /*
            internal void showCreateNewMaterialSaveDialog( toMaterial )
            {
               MessageBoxYesNoCancel("Save Material?", 
                  "The material " + this.currentMaterial.getName() + " has unsaved changes. <br>Do you want to save before changing the material?", 
                  "this.save(); this.createNewMaterial(" + toMaterial + ");", 
                  "this.saveDialogDontSave(" + toMaterial + "); this.changeMaterial(" + toMaterial + ");", 
                  "this.saveDialogCancel();" );
            }
            */

            [ConsoleInteraction]
            public void saveDialogCancel()
            {
                this.guiSync("materialEd_previewMaterial");
            }

            [ConsoleInteraction]
            public void saveDialogDontSave(Material material)
            {
                Material notDirtyMaterial = "notDirtyMaterial";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                this.currentMaterial.setName(this["originalName"]);

                //restore to defaults
                this.copyMaterials(notDirtyMaterial, this.currentMaterial);
                this.copyMaterials(notDirtyMaterial, materialEd_previewMaterial);
                this.guiSync(materialEd_previewMaterial);

                materialEd_previewMaterial.flush();
                materialEd_previewMaterial.reload();
                this.currentMaterial.flush();
                this.currentMaterial.reload();

                this.setMaterialNotDirty();

                this.setActiveMaterial(material);
            }

            [ConsoleInteraction]
            public void saveDialogSave(Material material)
            {
                this.save();
                this.setActiveMaterial(material);
            }

            [ConsoleInteraction]
            public void save()
            {
                PersistenceManager matEd_PersistMan = "matEd_PersistMan";

                if (this.currentMaterial.getName() == "")
                    {
                    messageBox.MessageBoxOK("Cannot perform operation", "Saved materials cannot be named \"\". A name must be given before operation is performed");
                    return;
                    }

                // Update the live object regardless in this case
                this.updateLivePreview(true);

                currentMaterial = this.currentMaterial;
                if (currentMaterial == -1)
                    {
                    messageBox.MessageBoxOK("Cannot perform operation", "Could not locate material");
                    return;
                    }

                // Specifically for materials autogenerated from shapes.
                if (currentMaterial.isAutoGenerated())
                    currentMaterial.setAutoGenerated(false);

                // Save the material using the persistence manager
                matEd_PersistMan.saveDirty();

                // Clean up the Material Editor
                this.copyMaterials("materialEd_previewMaterial", "notDirtyMaterial");
                this.setMaterialNotDirty();
            }

            //==============================================================================
            // Create New and Delete Material

            [ConsoleInteraction]
            public void createNewMaterial()
            {
                MaterialEditorUndo.ActionCreateNewMaterial action = this.createUndo<MaterialEditorUndo.ActionCreateNewMaterial>("Create New Material");
                action["object"] = "";

                string material = Util.getUniqueName("newMaterial");

                #region Material (material)        oc_Newobject10

                ObjectCreator oc_Newobject10 = new ObjectCreator("Material", material);
                oc_Newobject10["diffuseMap[0]"] = "core/art/warnmat";
                oc_Newobject10["mapTo"] = "unmapped_mat";
                oc_Newobject10["parentGroup"] = new Creator.StringNoQuote("RootGroup");

                #endregion

                material = oc_Newobject10.Create().AsString();

                action["newMaterial"] = material;
                action["oldMaterial"] = this.currentMaterial;

                this.submitUndo(action);

                this.currentObject = "";
                this.setMode();
                this.prepareActiveMaterial(material, true);
            }

            [ConsoleInteraction]
            public void deleteMaterial()
            {
                PersistenceManager matEd_PersistMan = "matEd_PersistMan";
                ArrayObject UnlistedMaterials = "UnlistedMaterials";

                MaterialEditorUndo.ActionDeleteMaterial action = this.createUndo<MaterialEditorUndo.ActionDeleteMaterial>("Delete Material");
                action["object"] = this.currentObject;
                action["currentMode"] = this.currentMode;

                /*
                if( this.currentMode $= "Mesh" )
                {
                    materialTarget = SubMaterialSelector.text;
                    action.materialTarget = materialTarget;   
      
                    //create the stub material
                    toMaterial = getUniqueName( "newMaterial" );
                    new Material(toMaterial) 
                    {
                        diffuseMap[0] = "core/art/warnmat";
                        mapTo = "unmapped_mat";
                        parentGroup = RootGroup;
                    };
         
                    action.toMaterial = toMaterial.getId();   
                    action.fromMaterial = this.currentMaterial;
                    action.fromMaterialOldFname = this.currentMaterial.getFilename();
                }
                else
                {
                    // Grab first material we see; if theres not one, create one
                    toMaterial = MaterialSet.getObject(0);
                    if( !isObject( toMaterial ) )
                    {
                        toMaterial = getUniqueName( "newMaterial" );
                        new Material(toMaterial) 
                        {
                            diffuseMap[0] = "core/art/warnmat";
                            mapTo = "unmapped_mat";
                            parentGroup = RootGroup;
                        };    
                    }
   
                    action.toMaterial = toMaterial.getId();
                    action.fromMaterial = this.currentMaterial;
                }
                */

                // Grab first material we see; if theres not one, create one
                string newMaterial = Util.getUniqueName("newMaterial");

                #region Material (%newMaterial)        oc_Newobject11

                ObjectCreator oc_Newobject11 = new ObjectCreator("Material", newMaterial);
                oc_Newobject11["diffuseMap[0]"] = "core/art/warnmat";
                oc_Newobject11["mapTo"] = "unmapped_mat";
                oc_Newobject11["parentGroup"] = new Creator.StringNoQuote("RootGroup");

                #endregion

                newMaterial = oc_Newobject11.Create().AsString();

                // Setup vars
                action["newMaterial"] = newMaterial;
                action["oldMaterial"] = this.currentMaterial;
                action["oldMaterialFname"] = this.currentMaterial.getFilename();

                // Submit undo
                this.submitUndo(action);

                // Delete the material from file
                if (!this.isMatEditorMaterial(this.currentMaterial))
                    {
                    matEd_PersistMan.removeObjectFromFile(this.currentMaterial);
                    matEd_PersistMan.removeDirty(this.currentMaterial);
                    }

                // Delete the material as seen through the material selector.
                UnlistedMaterials.add("unlistedMaterials", this.currentMaterial.getName());

                // Loadup another material
                this.currentObject = "";
                this.setMode();
                this.prepareActiveMaterial(newMaterial, true);
            }

            //==============================================================================
            // Clear and Refresh Material

            [ConsoleInteraction]
            public void clearMaterial()
            {
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                UndoScriptAction action = this.createUndo<MaterialEditorUndo.ActionClearMaterial>("Clear Material");
                action["material"] = this.currentMaterial;
                action["object"] = this.currentObject;

                Util.pushInstantGroup();
                action["oldMaterial"] = new ObjectCreator("Material", "").Create().AsString();
                action["newMaterial"] = new ObjectCreator("Material", "").Create().AsString();
                Util.popInstantGroup();

                this.submitUndo(action);

                this.copyMaterials(this.currentMaterial, action["oldMaterial"]);

                #region Material ()        oc_Newobject12

                ObjectCreator oc_Newobject12 = new ObjectCreator("Material", "");
                oc_Newobject12["name"] = "tempMaterial";
                oc_Newobject12["mapTo"] = "unmapped_mat";
                oc_Newobject12["parentGroup"] = new Creator.StringNoQuote("RootGroup");

                #endregion

                Material tempMat = oc_Newobject12.Create();

                this.copyMaterials(tempMat, materialEd_previewMaterial);
                this.guiSync(materialEd_previewMaterial);

                materialEd_previewMaterial.flush();
                materialEd_previewMaterial.reload();

                if (this["livePreview"].AsBool())
                    {
                    this.copyMaterials(tempMat, this.currentMaterial);
                    this.currentMaterial.flush();
                    this.currentMaterial.reload();
                    }

                this.setMaterialDirty();

                tempMat.delete();
            }

            [ConsoleInteraction]
            public void refreshMaterial()
            {
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                MaterialEditorUndo.ActionRefreshMaterial action = this.createUndo<MaterialEditorUndo.ActionRefreshMaterial>("Refresh Material");
                action["material"] = this.currentMaterial;
                action["object"] = this.currentObject;

                Util.pushInstantGroup();
                action["oldMaterial"] = new ObjectCreator("Material", "").Create().AsString();
                action["newMaterial"] = new ObjectCreator("Material", "").Create().AsString();
                Util.popInstantGroup();

                this.copyMaterials(this.currentMaterial, action["oldMaterial"]);
                this.copyMaterials("notDirtyMaterial", action["newMaterial"]);

                action["oldName"] = this.currentMaterial.getName();
                action["newName"] = this["originalName"];

                this.submitUndo(action);

                this.currentMaterial.setName(this["originalName"]);
                this.copyMaterials("notDirtyMaterial", materialEd_previewMaterial);
                this.guiSync(materialEd_previewMaterial);

                materialEd_previewMaterial.flush();
                materialEd_previewMaterial.reload();

                if (this["livePreview"].AsBool())
                    {
                    this.copyMaterials("notDirtyMaterial", this.currentMaterial);
                    this.currentMaterial.flush();
                    this.currentMaterial.reload();
                    }

                this.setMaterialNotDirty();
            }

            //==============================================================================
            // Switching and Changing Materials

            [ConsoleInteraction]
            public void switchMaterial(Material material)
            {
                //this.currentMaterial = material.getId();
                this.currentObject = "";
                this.setMode();
                this.prepareActiveMaterial(material.getId(), true);
            }

            /*------------------------------------------------------------------------------
            This changes the map to's of possibly two materials (fromMaterial, toMaterial)
            and updates the engines libraries accordingly in order to make this change per 
            object/per objects instances/per target. Before this functionality is enacted, 
            there is a popup beforehand that will ask if you are sure if you want to make
            this change. Making this change will physically alter possibly two materials.cs 
            files in order to move the (fromMaterial, toMaterial), replacing the 
            (fromMaterials)'s mapTo to "unmapped_mat".
            -------------------------------------------------------------------------------*/

            [ConsoleInteraction]
            public void changeMaterial(Material fromMaterial, Material toMaterial)
            {
                GuiPopUpMenuCtrlEx SubMaterialSelector = "SubMaterialSelector";
                PersistenceManager matEd_PersistMan = "matEd_PersistMan";
                string sourcePath = "";

                MaterialEditorUndo.ActionChangeMaterial action = this.createUndo<MaterialEditorUndo.ActionChangeMaterial>("Change Material");

                string materialTarget = SubMaterialSelector["text"];
                action["materialTarget"] = materialTarget;

                action["fromMaterial"] = fromMaterial;
                action["toMaterial"] = toMaterial;
                action["toMaterialOldFname"] = toMaterial.getFilename();
                action["object"] = this.currentObject;

                if (this.currentMeshMode == "Model") // Models
                    {
                    action["mode"] = "model";

                    this.currentObject.call("changeMaterial", materialTarget, fromMaterial.getName(), toMaterial.getName());

                    if (this.currentObject["shapeName"] != "")
                        sourcePath = this.currentObject["shapeName"];
                    else if (this.currentObject.isMethod("getDatablock"))
                        {
                        if (((SimObject) this.currentObject.call("getDatablock"))["shapeFile"] != "")
                            sourcePath = ((SimObject) this.currentObject.call("getDatablock"))["shapeFile"];
                        }

                    // Creating "to" path
                    int k = 0;
                    while (Util.strpos(sourcePath, "/", k) != -1)
                        {
                        int count = Util.strpos(sourcePath, "/", k);
                        k = count + 1;
                        }
                    string fileName = Util.getSubStr(sourcePath, 0, k);
                    fileName = fileName + "materials.cs";

                    action["toMaterialNewFname"] = fileName;

                    this.prepareActiveMaterial(toMaterial, true);
                    if (!this.isMatEditorMaterial(toMaterial))
                        matEd_PersistMan.removeObjectFromFile(toMaterial);

                    matEd_PersistMan.setDirty(fromMaterial);
                    matEd_PersistMan.setDirty(toMaterial, fileName);
                    matEd_PersistMan.saveDirty();

                    matEd_PersistMan.removeDirty(fromMaterial);
                    matEd_PersistMan.removeDirty(toMaterial);
                    }
                else // EditorShapes
                    {
                    action["mode"] = "editorShapes";

                    this.currentObject[SubMaterialSelector.getText()] = toMaterial.getName();
                    if (this.currentObject.isMethod("postApply"))
                        this.currentObject.call("postApply");

                    this.prepareActiveMaterial(toMaterial, true);
                    }

                this.submitUndo(action);
            }

            // [ConsoleInteraction]
            public T createUndo<T>(string desc)
            {
                Util.pushInstantGroup();
                ObjectCreator actionCreator = new ObjectCreator("UndoScriptAction", "", typeof (T));
                //action["class"] = className;
                //action["superClass"] = "BaseMaterialEdAction";
                actionCreator["actionName"] = desc;

                T action = myReflections.ChangeType<T>(actionCreator.Create());

                Util.popInstantGroup();
                return action;
            }

            [ConsoleInteraction]
            public void submitUndo(UndoScriptAction action)
            {
                editor Editor = "Editor";
                if (!this["preventUndo"].AsBool())
                    action.addToManager(Editor.getUndoManager());
            }

            //==============================================================================
            // Image thumbnail right-clicks.

            // not yet functional
            [TypeConverter(typeof (TypeConverterGeneric<MaterialEditorMapThumbnail>))]
            public class MaterialEditorMapThumbnail : GuiBitmapCtrl
            {
                [ConsoleInteraction]
                public void onRightClick()
                {
                    MenuBuilder MaterialEditorMapThumbnailPopup = "MaterialEditorMapThumbnailPopup";
                    MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                    GuiCanvas Canvas = "Canvas";

                    if (!MaterialEditorMapThumbnailPopup.isObject())
                        {
                        #region PopupMenu ( MaterialEditorMapThumbnailPopup )        

                        ObjectCreator materialCreator = new ObjectCreator("PopupMenu", "MaterialEditorMapThumbnailPopup", typeof (MenuBuilder));
                        materialCreator["isPopup"] = true.AsString();
                        materialCreator["item[0]"] = "Open File" + '\t' + "" + '\t' + "openFile( MaterialEditorMapThumbnailPopup.filePath );";
                        materialCreator["item[1]"] = "Open Folder" + '\t' + "" + '\t' + "openFolder( filePath( MaterialEditorMapThumbnailPopup.filePath ) );";
                        materialCreator["filePath"] = "";

                        #endregion

                        MaterialEditorMapThumbnailPopup = materialCreator.Create();
                        }
                    // Find the text control containing the filename.

                    GuiTextEditCtrl textCtrl = ((SimSet) this.parentGroup).findObjectByInternalName(this["fileNameTextCtrl"], true);
                    if (!textCtrl.isObject())
                        return;

                    string fileName = textCtrl.getText();
                    string fullPath = Util.makeFullPath(fileName, Util.getMainDotCsDir());

                    // Construct a full path.

                    bool isValid = Util.isFile(fullPath);
                    if (!isValid)
                        {
                        if (Util.isFile(fileName))
                            {
                            fullPath = fileName;
                            isValid = true;
                            }
                        else
                            {
                            // Try material-relative path.

                            Material material = MaterialEditorGui.currentMaterial;
                            if (material.isObject())
                                {
                                string materialPath = Util.filePath(Util.makeFullPath(material.getFilename(), Util.getMainDotCsDir()));
                                fullPath = Util.makeFullPath(fileName, materialPath);
                                isValid = Util.isFile(fullPath);
                                }
                            }
                        }

                    PopupMenu popup = MaterialEditorMapThumbnailPopup;
                    popup.enableItem(0, isValid);
                    popup.enableItem(1, isValid);
                    popup["filePath"] = fullPath;

                    popup.showPopup(Canvas);
                }
            }

            //==============================================================================
            // SubMaterial(Material Target) -- Supports different ways to grab the 
            // material from the dropdown list. We're here either because-
            // 1. We have switched over from another editor with an object locked in the 
            //    $Tools::materialEditorList variable
            // 2. We have selected an object using the Object Editor via the Material Editor 

            [TypeConverter(typeof (TypeConverterGeneric<SubMaterialSelector>))]
            public class SubMaterialSelector : GuiPopUpMenuCtrlEx
            {
                [ConsoleInteraction]
                public override void onSelect(string id, string text)
                {
                    MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                    string material = "";

                    if (MaterialEditorGui.currentMeshMode == "Model")
                        material = Util.getMapEntry(this.getText());
                    else
                        material = MaterialEditorGui.currentObject.getFieldValue(this.getText(), -1);

                    Material origMat = material;
                    if (material == "")
                        origMat = material = this.getText();
                    // if there is no material attached to that objects material field or the 
                    // object does not have a valid method to grab a material
                    if (!material.isObject())
                        {
                        // look for a newMaterial name to grab
                        // addiitonally, convert "." to "_" in case we have something like: "base.texname" as a material name   
                        // at the end we will have generated material name: "base_texname_mat"   
                        material = Util.getUniqueName(Util.strreplace(material, ".", "_") + "_mat");

                        #region Material (material)        oc_Newobject5

                        ObjectCreator oc_Newobject5 = new ObjectCreator("Material", material);
                        oc_Newobject5["diffuseMap[0]"] = origMat;
                        oc_Newobject5["mapTo"] = origMat;
                        oc_Newobject5["parentGroup"] = new Creator.StringNoQuote("RootGroup");

                        #endregion

                        material = oc_Newobject5.Create().AsString();

                        MaterialEditorGui.currentObject[Util.strreplace(this.getText(), ".", "_")] = material;

                        if (MaterialEditorGui.currentObject.isMethod("postApply"))
                            MaterialEditorGui.currentObject.call("postApply");
                        }

                    MaterialEditorGui.prepareActiveMaterial(material, false);
                }

                #region ProxyObjects Operator Overrides

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static bool operator ==(SubMaterialSelector ts, string simobjectid)
                {
                    return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
                public static bool operator !=(SubMaterialSelector ts, string simobjectid)
                {
                    if (ReferenceEquals(ts, null))
                        return !ReferenceEquals(simobjectid, null);
                    return !ts.Equals(simobjectid);
                }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator string(SubMaterialSelector ts)
                {
                    return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator SubMaterialSelector(string ts)
                {
                    uint simobjectid = resolveobject(ts);
                    return (SubMaterialSelector) Omni.self.getSimObject(simobjectid, typeof (SubMaterialSelector));
                }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator int(SubMaterialSelector ts)
                {
                    return (int) ts._iID;
                }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="simobjectid"></param>
                /// <returns></returns>
                public static implicit operator SubMaterialSelector(int simobjectid)
                {
                    return (SubMaterialSelector) Omni.self.getSimObject((uint) simobjectid, typeof (SubMaterialSelector));
                }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="ts"></param>
                /// <returns></returns>
                public static implicit operator uint(SubMaterialSelector ts)
                {
                    return ts._iID;
                }

                /// <summary>
                /// 
                /// </summary>
                /// <returns></returns>
                public static implicit operator SubMaterialSelector(uint simobjectid)
                {
                    return (SubMaterialSelector) Omni.self.getSimObject(simobjectid, typeof (SubMaterialSelector));
                }

                #endregion
            }

            [TypeConverter(typeof (TypeConverterGeneric<matEd_cubemapEd_availableCubemapList>))]
            public class matEd_cubemapEd_availableCubemapList : GuiListBoxCtrl
            {
                [ConsoleInteraction]
                public override void onSelect(string id, string cubemap)
                {
                    MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                    GuiWindowCtrl matEd_cubemapEditor = "matEd_cubemapEditor";
                    CubemapData cubemapData = cubemap;
                    if (MaterialEditorGui["currentCubemap"] == cubemapData)
                        return;

                    if (matEd_cubemapEditor["dirty"].AsBool())
                        {
                        CubemapData savedCubemap = MaterialEditorGui["currentCubemap"];
                        messageBox.MessageBoxYesNoCancel("Save Existing Cubemap?", "Do you want to save changes to <br><br>" + savedCubemap.getName(), "MaterialEditorGui.saveCubemap(" + true + ");", "MaterialEditorGui.saveCubemapDialogDontSave(" + cubemapData + ");", "MaterialEditorGui.saveCubemapDialogCancel();");
                        }
                    else
                        MaterialEditorGui.changeCubemap(cubemapData);
                }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(MaterialEditorGui ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            public static bool operator !=(MaterialEditorGui ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(MaterialEditorGui ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator MaterialEditorGui(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (MaterialEditorGui) Omni.self.getSimObject(simobjectid, typeof (MaterialEditorGui));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(MaterialEditorGui ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator MaterialEditorGui(int simobjectid)
            {
                return (MaterialEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (MaterialEditorGui));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(MaterialEditorGui ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator MaterialEditorGui(uint simobjectid)
            {
                return (MaterialEditorGui) Omni.self.getSimObject(simobjectid, typeof (MaterialEditorGui));
            }

            #endregion
        }
    }
}