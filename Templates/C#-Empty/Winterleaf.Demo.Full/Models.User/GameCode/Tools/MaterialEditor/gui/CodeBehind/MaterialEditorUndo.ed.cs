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
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui.CodeBehind
{
    public class MaterialEditorUndo
    {
        [TypeConverter(typeof (TypeConverterGeneric<ActionChangeMaterial>))]
        public class ActionChangeMaterial : BaseMaterialEdAction
        {
            [ConsoleInteraction]
            public override void redo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material toMaterial = this["toMaterial"];
                Material fromMaterial = this["fromMaterial"];
                SimObject thisObject = this["object"];
                PersistenceManager matEd_PersistMan = "matEd_PersistMan";

                if (this["mode"] == "model")
                    {
                    thisObject.call("changeMaterial", this["materialTarget"], fromMaterial.getName(), toMaterial.getName());

                    MaterialEditorGui.currentObject = thisObject;

                    if (toMaterial.getFilename() != "tools/gui/materialSelector.ed.gui" || toMaterial.getFilename() != "tools/materialEditor/scripts/materialEditor.ed.cs")
                        matEd_PersistMan.removeObjectFromFile(toMaterial);

                    matEd_PersistMan.setDirty(fromMaterial);
                    matEd_PersistMan.setDirty(toMaterial, this["toMaterialNewFname"]);
                    matEd_PersistMan.saveDirty();

                    matEd_PersistMan.removeDirty(fromMaterial);
                    matEd_PersistMan.removeDirty(toMaterial);
                    }
                else
                    {
                    ((SimObject) this["object"])[this["materialTarget"]] = toMaterial.getName();
                    MaterialEditorGui.currentObject.call("postApply");
                    }

                if (MaterialEditorPreviewWindow.isVisible())
                    MaterialEditorGui.setActiveMaterial(toMaterial);
            }

            [ConsoleInteraction]
            public override void undo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material toMaterial = this["toMaterial"];
                Material fromMaterial = this["fromMaterial"];
                SimObject thisObject = this["object"];
                PersistenceManager matEd_PersistMan = "matEd_PersistMan";

                if (this["mode"] == "model")
                    {
                    thisObject.call("changeMaterial", this["materialTarget"], toMaterial.getName(), fromMaterial.getName());

                    MaterialEditorGui.currentObject = thisObject;

                    if (toMaterial.getFilename() != "tools/gui/materialSelector.ed.gui" || toMaterial.getFilename() != "tools/materialEditor/scripts/materialEditor.ed.cs")
                        matEd_PersistMan.removeObjectFromFile(toMaterial);

                    matEd_PersistMan.setDirty(fromMaterial);
                    matEd_PersistMan.setDirty(toMaterial, this["toMaterialOldFname"]);
                    matEd_PersistMan.saveDirty();

                    matEd_PersistMan.removeDirty(fromMaterial);
                    matEd_PersistMan.removeDirty(toMaterial);
                    }
                else
                    {
                    ((SimObject) this["object"])[this["materialTarget"]] = fromMaterial.getName();
                    MaterialEditorGui.currentObject.call("postApply");
                    }

                if (MaterialEditorPreviewWindow.isVisible())
                    MaterialEditorGui.setActiveMaterial(fromMaterial);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionChangeMaterial ts, string simobjectid)
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
            public static bool operator !=(ActionChangeMaterial ts, string simobjectid)
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
            public static implicit operator string(ActionChangeMaterial ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionChangeMaterial(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionChangeMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionChangeMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionChangeMaterial ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionChangeMaterial(int simobjectid)
            {
                return (ActionChangeMaterial) Omni.self.getSimObject((uint) simobjectid, typeof (ActionChangeMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionChangeMaterial ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionChangeMaterial(uint simobjectid)
            {
                return (ActionChangeMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionChangeMaterial));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionClearMaterial>))]
        public class ActionClearMaterial : BaseMaterialEdAction
        {
            [ConsoleInteraction]
            public override void redo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    MaterialEditorGui.copyMaterials(this["newMaterial"], materialEd_previewMaterial);
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    if (MaterialEditorGui["livePreview"].AsBool())
                        {
                        MaterialEditorGui.copyMaterials(this["newMaterial"], this.material);
                        this.material.flush();
                        this.material.reload();
                        }

                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialNotDirty();
                    }
                else
                    {
                    MaterialEditorGui.copyMaterials(this["newMaterial"], this.material);
                    this.material.flush();
                    this.material.reload();
                    }
            }

            [ConsoleInteraction]
            public override void undo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    MaterialEditorGui.copyMaterials(this["oldMaterial"], materialEd_previewMaterial);
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    if (MaterialEditorGui["livePreview"].AsBool())
                        {
                        MaterialEditorGui.copyMaterials(this["newMaterial"], this.material);
                        this.material.flush();
                        this.material.reload();
                        }

                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialNotDirty();
                    }
                else
                    {
                    MaterialEditorGui.copyMaterials(this["oldMaterial"], this.material);
                    this.material.flush();
                    this.material.reload();
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionClearMaterial ts, string simobjectid)
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
            public static bool operator !=(ActionClearMaterial ts, string simobjectid)
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
            public static implicit operator string(ActionClearMaterial ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionClearMaterial(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionClearMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionClearMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionClearMaterial ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionClearMaterial(int simobjectid)
            {
                return (ActionClearMaterial) Omni.self.getSimObject((uint) simobjectid, typeof (ActionClearMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionClearMaterial ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionClearMaterial(uint simobjectid)
            {
                return (ActionClearMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionClearMaterial));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionCreateNewMaterial>))]
        public class ActionCreateNewMaterial : BaseMaterialEdAction
        {
            [ConsoleInteraction]
            public override void redo()
            {
                ArrayObject UnlistedMaterials = "UnlistedMaterials";
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                if (MaterialEditorPreviewWindow.isVisible())
                    {
                    if (MaterialEditorGui.currentMaterial != this["newMaterial"])
                        {
                        MaterialEditorGui.currentObject = "";
                        MaterialEditorGui.setMode();
                        MaterialEditorGui.setActiveMaterial(this["newMaterial"]);
                        }

                    MaterialEditorGui.copyMaterials(this["newMaterial"], materialEd_previewMaterial);
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    }

                int idx = UnlistedMaterials.getIndexFromValue(this["newMaterial"].getName());
                UnlistedMaterials.erase(idx);
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ArrayObject UnlistedMaterials = "UnlistedMaterials";
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                if (MaterialEditorPreviewWindow.isVisible())
                    {
                    if (MaterialEditorGui.currentMaterial != this["oldMaterial"])
                        {
                        MaterialEditorGui.currentObject = "";
                        MaterialEditorGui.setMode();
                        MaterialEditorGui.setActiveMaterial(this["oldMaterial"]);
                        }

                    MaterialEditorGui.copyMaterials(this["oldMaterial"], materialEd_previewMaterial);
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    }

                UnlistedMaterials.add("unlistedMaterials", this["newMaterial"].getName());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionCreateNewMaterial ts, string simobjectid)
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
            public static bool operator !=(ActionCreateNewMaterial ts, string simobjectid)
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
            public static implicit operator string(ActionCreateNewMaterial ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionCreateNewMaterial(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionCreateNewMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionCreateNewMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionCreateNewMaterial ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionCreateNewMaterial(int simobjectid)
            {
                return (ActionCreateNewMaterial) Omni.self.getSimObject((uint) simobjectid, typeof (ActionCreateNewMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionCreateNewMaterial ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionCreateNewMaterial(uint simobjectid)
            {
                return (ActionCreateNewMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionCreateNewMaterial));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionDeleteMaterial>))]
        public class ActionDeleteMaterial : BaseMaterialEdAction
        {
            [ConsoleInteraction]
            public override void redo()
            {
                ArrayObject UnlistedMaterials = "UnlistedMaterials";
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material thisOldMaterial = this["oldMaterial"];
                Material materialEd_previewMaterial = "materialEd_previewMaterial";
                PersistenceManager matEd_PersistMan = "matEd_PersistMan";

                if (MaterialEditorPreviewWindow.isVisible())
                    {
                    if (MaterialEditorGui.currentMaterial != this["newMaterial"])
                        {
                        MaterialEditorGui.currentObject = "";
                        MaterialEditorGui.setMode();
                        MaterialEditorGui.setActiveMaterial(this["newMaterial"]);
                        }

                    MaterialEditorGui.copyMaterials(this["newMaterial"], materialEd_previewMaterial);
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    }

                if (thisOldMaterial.getFilename() != "tools/gui/materialSelector.ed.gui" || thisOldMaterial.getFilename() != "tools/materialEditor/scripts/materialEditor.ed.cs")
                    matEd_PersistMan.removeObjectFromFile(thisOldMaterial);

                UnlistedMaterials.add("unlistedMaterials", thisOldMaterial.getName());
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ArrayObject UnlistedMaterials = "UnlistedMaterials";
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material thisOldMaterial = this["oldMaterial"];
                Material materialEd_previewMaterial = "materialEd_previewMaterial";
                PersistenceManager matEd_PersistMan = "matEd_PersistMan";

                if (MaterialEditorPreviewWindow.isVisible())
                    {
                    if (MaterialEditorGui.currentMaterial != thisOldMaterial)
                        {
                        MaterialEditorGui.currentObject = "";
                        MaterialEditorGui.setMode();
                        MaterialEditorGui.setActiveMaterial(thisOldMaterial);
                        }

                    MaterialEditorGui.copyMaterials(thisOldMaterial, materialEd_previewMaterial);
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    }

                matEd_PersistMan.setDirty(thisOldMaterial, this["oldMaterialFname"]);
                matEd_PersistMan.saveDirty();
                matEd_PersistMan.removeDirty(thisOldMaterial);

                int idx = UnlistedMaterials.getIndexFromValue(thisOldMaterial.getName());
                UnlistedMaterials.erase(idx);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionDeleteMaterial ts, string simobjectid)
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
            public static bool operator !=(ActionDeleteMaterial ts, string simobjectid)
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
            public static implicit operator string(ActionDeleteMaterial ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionDeleteMaterial(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionDeleteMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionDeleteMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionDeleteMaterial ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionDeleteMaterial(int simobjectid)
            {
                return (ActionDeleteMaterial) Omni.self.getSimObject((uint) simobjectid, typeof (ActionDeleteMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionDeleteMaterial ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionDeleteMaterial(uint simobjectid)
            {
                return (ActionDeleteMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionDeleteMaterial));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRefreshMaterial>))]
        public class ActionRefreshMaterial : BaseMaterialEdAction
        {
            [ConsoleInteraction]
            public override void redo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    this.material.setName(this["newName"]);

                    MaterialEditorGui.copyMaterials(this["newMaterial"], materialEd_previewMaterial);
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    if (MaterialEditorGui["livePreview"].AsBool())
                        {
                        MaterialEditorGui.copyMaterials(this["newMaterial"], this.material);
                        this.material.flush();
                        this.material.reload();
                        }

                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialNotDirty();
                    }
                else
                    {
                    MaterialEditorGui.copyMaterials(this["newMaterial"], this.material);
                    this.material.flush();
                    this.material.reload();
                    }
            }

            [ConsoleInteraction]
            public override void undo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    this.material.setName(this["oldName"]);

                    MaterialEditorGui.copyMaterials(this["oldMaterial"], materialEd_previewMaterial);
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    if (MaterialEditorGui["livePreview"].AsBool())
                        {
                        MaterialEditorGui.copyMaterials(this["oldMaterial"], this.material);
                        this.material.flush();
                        this.material.reload();
                        }

                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialDirty();
                    }
                else
                    {
                    MaterialEditorGui.copyMaterials(this["oldMaterial"], this.material);
                    this.material.flush();
                    this.material.reload();
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRefreshMaterial ts, string simobjectid)
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
            public static bool operator !=(ActionRefreshMaterial ts, string simobjectid)
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
            public static implicit operator string(ActionRefreshMaterial ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRefreshMaterial(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRefreshMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionRefreshMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRefreshMaterial ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRefreshMaterial(int simobjectid)
            {
                return (ActionRefreshMaterial) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRefreshMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRefreshMaterial ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRefreshMaterial(uint simobjectid)
            {
                return (ActionRefreshMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionRefreshMaterial));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveMaterial>))]
        public class ActionUpdateActiveMaterial : BaseMaterialEdAction
        {
            [ConsoleInteraction]
            public override void redo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    /*
                    if( MaterialEditorGui.currentMaterial != %this.material )
                    {
                    MaterialEditorGui.currentObject = %this.object;
                    MaterialEditorGui.setMode();
                    MaterialEditorGui.setActiveMaterial(%this.material);
                    }
                    */
                    materialEd_previewMaterial[this["field"]] = Util.strreplace(this["newValue"], "\"", "");
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    if (MaterialEditorGui["livePreview"].AsBool())
                        {
                        this.material[this["field"]] = Util.strreplace(this["newValue"], "\"", "");
                        ;
                        MaterialEditorGui.currentMaterial.flush();
                        MaterialEditorGui.currentMaterial.reload();
                        }

                    MaterialEditorGui["preventUndo"] = true.AsString();
                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialDirty();
                    MaterialEditorGui["preventUndo"] = false.AsString();
                    }
                else
                    {
                    this.material[this["field"]] = Util.strreplace(this["newValue"], "\"", "");
                    this.material.flush();
                    this.material.reload();
                    }
            }

            [ConsoleInteraction]
            public override void undo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                MaterialEditorGui["preventUndo"] = true.AsString();
                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    /*
                    if( MaterialEditorGui.currentMaterial != %this.material )
                    {
                    MaterialEditorGui.currentObject = %this.object;
                    MaterialEditorGui.setMode();
                    MaterialEditorGui.setActiveMaterial(%this.material);
                    }
                    */

                    materialEd_previewMaterial[this["field"]] = Util.strreplace(this["oldValue"], "\"", "");
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    if (MaterialEditorGui["livePreview"].AsBool())
                        {
                        this.material[this["field"]] = Util.strreplace(this["oldValue"], "\"", "");
                        MaterialEditorGui.currentMaterial.flush();
                        MaterialEditorGui.currentMaterial.reload();
                        }
                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialDirty();
                    }
                else
                    {
                    this.material[this["field"]] = Util.strreplace(this["oldValue"], "\"", "");
                    this.material.flush();
                    this.material.reload();
                    }

                MaterialEditorGui["preventUndo"] = false.AsString();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveMaterial ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveMaterial ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveMaterial ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveMaterial(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionUpdateActiveMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveMaterial ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveMaterial(int simobjectid)
            {
                return (ActionUpdateActiveMaterial) Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveMaterial));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveMaterial ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveMaterial(uint simobjectid)
            {
                return (ActionUpdateActiveMaterial) Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveMaterial));
            }

            #endregion
        }

        // Special case updateActiveMaterial redo/undo

        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveMaterialAnimationFlags>))]
        public class ActionUpdateActiveMaterialAnimationFlags : BaseMaterialEdAction
        {
            [ConsoleInteraction]
            public override void redo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";
                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    /*
                    if( MaterialEditorGui.currentMaterial != %this.material )
                    {
                    MaterialEditorGui.currentObject = %this.object;
                    MaterialEditorGui.setMode();
                    MaterialEditorGui.setActiveMaterial(%this.material);
                    }
                    */

                    materialEd_previewMaterial.animFlags[this["layer"].AsInt()] = this["newValue"];
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    if (MaterialEditorGui["livePreview"].AsBool())
                        {
                        this.material.animFlags[this["layer"].AsInt()] = this["newValue"];
                        MaterialEditorGui.currentMaterial.flush();
                        MaterialEditorGui.currentMaterial.reload();
                        }
                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialDirty();
                    }
                else
                    {
                    this.material.animFlags[this["layer"].AsInt()] = this["newValue"];
                    this.material.flush();
                    this.material.reload();
                    }
            }

            [ConsoleInteraction]
            public override void undo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";

                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    materialEd_previewMaterial.animFlags[this["layer"].AsInt()] = this["oldValue"];
                    materialEd_previewMaterial.flush();
                    materialEd_previewMaterial.reload();

                    if (MaterialEditorGui["livePreview"].AsBool())
                        {
                        this.material.animFlags[this["layer"].AsInt()] = this["oldValue"];
                        MaterialEditorGui.currentMaterial.flush();
                        MaterialEditorGui.currentMaterial.reload();
                        }
                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialDirty();
                    }
                else
                    {
                    this.material.animFlags[this["layer"].AsInt()] = this["oldValue"];
                    this.material.flush();
                    this.material.reload();
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveMaterialAnimationFlags ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveMaterialAnimationFlags ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveMaterialAnimationFlags ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveMaterialAnimationFlags(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionUpdateActiveMaterialAnimationFlags) Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveMaterialAnimationFlags));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveMaterialAnimationFlags ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveMaterialAnimationFlags(int simobjectid)
            {
                return (ActionUpdateActiveMaterialAnimationFlags) Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveMaterialAnimationFlags));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveMaterialAnimationFlags ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveMaterialAnimationFlags(uint simobjectid)
            {
                return (ActionUpdateActiveMaterialAnimationFlags) Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveMaterialAnimationFlags));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveMaterialName>))]
        public class ActionUpdateActiveMaterialName : BaseMaterialEdAction
        {
            [ConsoleInteraction]
            public override void redo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";
                SimGroup MissionGroup = "MissionGroup";

                this.material.setName(this["newName"]);
                MaterialEditorGui.updateMaterialReferences(MissionGroup, this["oldName"], this["newName"]);

                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialDirty();
                    }
            }

            public override void undo()
            {
                GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                Material materialEd_previewMaterial = "materialEd_previewMaterial";
                SimGroup MissionGroup = "MissionGroup";

                this.material.setName(this["oldName"]);
                MaterialEditorGui.updateMaterialReferences(MissionGroup, this["newName"], this["oldName"]);

                if (MaterialEditorPreviewWindow.isVisible() && MaterialEditorGui.currentMaterial == this.material)
                    {
                    MaterialEditorGui.guiSync(materialEd_previewMaterial);
                    MaterialEditorGui.setMaterialDirty();
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveMaterialName ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveMaterialName ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveMaterialName ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveMaterialName(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionUpdateActiveMaterialName) Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveMaterialName));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveMaterialName ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveMaterialName(int simobjectid)
            {
                return (ActionUpdateActiveMaterialName) Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveMaterialName));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveMaterialName ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveMaterialName(uint simobjectid)
            {
                return (ActionUpdateActiveMaterialName) Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveMaterialName));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<BaseMaterialEdAction>))]
        public class BaseMaterialEdAction : UndoScriptAction
        {
            public Material material
            {
                get { return this["material"]; }
                set { this["material"] = value; }
            }

            public Material newMaterial
            {
                get { return this["newMaterial"]; }
                set { this["newMaterial"] = value; }
            }

            public Material OldMaterial
            {
                get { return this["OldMaterial"]; }
                set { this["OldMaterial"] = value; }
            }

            [ConsoleInteraction]
            public override void redo()
            {
                //TODO
                //this.redo();
            }

            [ConsoleInteraction]
            public override void undo()
            {
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(BaseMaterialEdAction ts, string simobjectid)
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
            public static bool operator !=(BaseMaterialEdAction ts, string simobjectid)
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
            public static implicit operator string(BaseMaterialEdAction ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator BaseMaterialEdAction(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (BaseMaterialEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseMaterialEdAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(BaseMaterialEdAction ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator BaseMaterialEdAction(int simobjectid)
            {
                return (BaseMaterialEdAction) Omni.self.getSimObject((uint) simobjectid, typeof (BaseMaterialEdAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(BaseMaterialEdAction ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator BaseMaterialEdAction(uint simobjectid)
            {
                return (BaseMaterialEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseMaterialEdAction));
            }

            #endregion
        }
    }
}