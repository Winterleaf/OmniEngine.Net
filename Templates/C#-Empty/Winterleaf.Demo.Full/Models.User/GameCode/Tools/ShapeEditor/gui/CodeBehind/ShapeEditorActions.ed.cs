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
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind
{
    public class ShapeEditorActions
    {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true, "ShapeEditorActions_initialize")]
        public static void initialize()
        {
            // The ShapeEditor uses its own UndoManager
            if (!"ShapeEdUndoManager".isObject())
                new ObjectCreator("UndoManager", "ShapeEdUndoManager", typeof (ShapeEdUndoManager)).Create();
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionAddMeshFromFile>))]
        public class ActionAddMeshFromFile : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";

                this["meshList"] = ShapeEditor.addLODFromFile(ShapeEditor.shape, this["filename"], this["size"], true);
                if (this["meshList"] != "")
                    {
                    int count = Util.getFieldCount(this["meshList"]);
                    for (int i = 0; i < count; i++)
                        ShapeEdPropWindow.update_onMeshAdded(Util.getField(this["meshList"], i));

                    ShapeEdMaterials.updateMaterialList();

                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";

                // Remove all the meshes we added
                int count = Util.getFieldCount(this["meshList"]);
                for (int i = 0; i < count; i ++)
                    {
                    string name = Util.getField(this["meshList"], i);
                    ShapeEditor.shape.removeMesh(name);
                    ShapeEdPropWindow.update_onMeshRemoved(name);
                    }
                ShapeEdMaterials.updateMaterialList();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionAddMeshFromFile ts, string simobjectid)
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
            public static bool operator !=(ActionAddMeshFromFile ts, string simobjectid)
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
            public static implicit operator string(ActionAddMeshFromFile ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionAddMeshFromFile(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionAddMeshFromFile) Omni.self.getSimObject(simobjectid, typeof (ActionAddMeshFromFile));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionAddMeshFromFile ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionAddMeshFromFile(int simobjectid)
            {
                return (ActionAddMeshFromFile) Omni.self.getSimObject((uint) simobjectid, typeof (ActionAddMeshFromFile));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionAddMeshFromFile ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionAddMeshFromFile(uint simobjectid)
            {
                return (ActionAddMeshFromFile) Omni.self.getSimObject(simobjectid, typeof (ActionAddMeshFromFile));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionAddNode>))]
        public class ActionAddNode : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.addNode(this["nodeName"], this["parentName"], this["transform"].AsTransformF()))
                    {
                    ShapeEdPropWindow.update_onNodeAdded(this["nodeName"], -1);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.removeNode(this["nodeName"]))
                    ShapeEdPropWindow.update_onNodeRemoved(this["nodeName"], 1);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionAddNode ts, string simobjectid)
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
            public static bool operator !=(ActionAddNode ts, string simobjectid)
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
            public static implicit operator string(ActionAddNode ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionAddNode(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionAddNode) Omni.self.getSimObject(simobjectid, typeof (ActionAddNode));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionAddNode ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionAddNode(int simobjectid)
            {
                return (ActionAddNode) Omni.self.getSimObject((uint) simobjectid, typeof (ActionAddNode));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionAddNode ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionAddNode(uint simobjectid)
            {
                return (ActionAddNode) Omni.self.getSimObject(simobjectid, typeof (ActionAddNode));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionAddSequence>))]
        public class ActionAddSequence : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                Settings EditorSettings = "EditorSettings";

                // If adding this sequence from an existing sequence, make a backup copy of
                // the existing sequence first, so we can edit the start/end frames later
                // without having to worry if the original source sequence has changed.
                if (ShapeEditor.shape.getSequenceIndex(this["from"]) >= 0)
                    {
                    this["from"] = ShapeEditor.getUniqueName("sequence", "__backup__" + this["origFrom"] + "_");
                    ShapeEditor.shape.addSequence(this["origFrom"], this["from"]);
                    }

                // Add the sequence
                bGlobal["$collada::forceLoadDAE"] = EditorSettings.value("forceLoadDAE").AsBool();
                bool success = ShapeEditor.shape.addSequence(this["from"], this["seqName"], this["start"].AsInt(), this["end"].AsInt());
                bGlobal["$collada::forceLoadDAE"] = false;

                if (success)
                    {
                    ShapeEdPropWindow.update_onSequenceAdded(this["seqName"], -1);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                // Remove the backup sequence if one was created
                if (this["origFrom"] != this["from"])
                    {
                    ShapeEditor.shape.removeSequence(this["from"]);
                    this["from"] = this["origFrom"];
                    }

                // Remove the actual sequence
                if (ShapeEditor.shape.removeSequence(this["seqName"]))
                    ShapeEdPropWindow.update_onSequenceRemoved(this["seqName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionAddSequence ts, string simobjectid)
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
            public static bool operator !=(ActionAddSequence ts, string simobjectid)
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
            public static implicit operator string(ActionAddSequence ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionAddSequence(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionAddSequence) Omni.self.getSimObject(simobjectid, typeof (ActionAddSequence));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionAddSequence ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionAddSequence(int simobjectid)
            {
                return (ActionAddSequence) Omni.self.getSimObject((uint) simobjectid, typeof (ActionAddSequence));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionAddSequence ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionAddSequence(uint simobjectid)
            {
                return (ActionAddSequence) Omni.self.getSimObject(simobjectid, typeof (ActionAddSequence));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionAddTrigger>))]
        public class ActionAddTrigger : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.addTrigger(this["seqName"], this["frame"].AsInt(), this["state"].AsInt()))
                    {
                    ShapeEdPropWindow.update_onTriggerAdded(this["seqName"], this["frame"].AsInt(), this["state"].AsFloat());
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.removeTrigger(this["seqName"], this["frame"].AsInt(), this["state"].AsInt()))
                    ShapeEdPropWindow.update_onTriggerRemoved(this["seqName"], this["frame"].AsInt(), this["state"].AsFloat());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionAddTrigger ts, string simobjectid)
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
            public static bool operator !=(ActionAddTrigger ts, string simobjectid)
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
            public static implicit operator string(ActionAddTrigger ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionAddTrigger(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionAddTrigger) Omni.self.getSimObject(simobjectid, typeof (ActionAddTrigger));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionAddTrigger ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionAddTrigger(int simobjectid)
            {
                return (ActionAddTrigger) Omni.self.getSimObject((uint) simobjectid, typeof (ActionAddTrigger));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionAddTrigger ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionAddTrigger(uint simobjectid)
            {
                return (ActionAddTrigger) Omni.self.getSimObject(simobjectid, typeof (ActionAddTrigger));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditBlend>))]
        public class ActionEditBlend : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                // If we are changing the blend reference ( rather than just toggling the flag )
                // we need to undo the current blend first.
                if (this["blend"].AsBool() && this["oldBlend"].AsBool())
                    {
                    if (!ShapeEditor.shape.setSequenceBlend(this["seqName"], false, this["oldBlendSeq"], this["oldBlendFrame"].AsInt()))
                        return false;
                    }

                if (ShapeEditor.shape.setSequenceBlend(this["seqName"], this["blend"].AsBool(), this["blendSeq"], this["blendFrame"].AsInt()))
                    {
                    ShapeEdPropWindow.update_onSequenceBlendChanged(this["seqName"], this["blend"].AsBool(), this["oldBlendSeq"], this["oldBlendFrame"].AsInt(), this["blendSeq"], this["blendFrame"].AsInt());
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                // If we are changing the blend reference ( rather than just toggling the flag )
                // we need to undo the current blend first.
                if (this["blend"].AsBool() && this["oldBlend"].AsBool())
                    {
                    if (!ShapeEditor.shape.setSequenceBlend(this["seqName"], false, this["blendSeq"], this["blendFrame"].AsInt()))
                        return;
                    }

                if (ShapeEditor.shape.setSequenceBlend(this["seqName"], this["oldBlend"].AsBool(), this["oldBlendSeq"], this["oldBlendFrame"].AsInt()))
                    ShapeEdPropWindow.update_onSequenceBlendChanged(this["seqName"], !this["blend"].AsBool(), this["blendSeq"], this["blendFrame"].AsInt(), this["oldBlendSeq"], this["oldBlendFrame"].AsInt());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditBlend ts, string simobjectid)
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
            public static bool operator !=(ActionEditBlend ts, string simobjectid)
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
            public static implicit operator string(ActionEditBlend ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditBlend(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditBlend) Omni.self.getSimObject(simobjectid, typeof (ActionEditBlend));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditBlend ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditBlend(int simobjectid)
            {
                return (ActionEditBlend) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditBlend));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditBlend ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditBlend(uint simobjectid)
            {
                return (ActionEditBlend) Omni.self.getSimObject(simobjectid, typeof (ActionEditBlend));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditCollision>))]
        public class ActionEditCollision : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public bool updateCollision(string type, string target, int depth, float merge, float concavity, int maxVerts, float boxMax, float sphereMax, float capsuleMax)
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                ShapeEditor.ShapeEdColWindow ShapeEdColWindow = "ShapeEdColWindow";

                int colDetailSize = -1;
                string colNode = "Col" + colDetailSize;

                // TreeView items are case sensitive, but TSShape names are not, so fixup case
                // if needed
                int index = ShapeEditor.shape.getNodeIndex(colNode);
                if (index != -1)
                    colNode = ShapeEditor.shape.getNodeName(index);

                // First remove the old detail and collision nodes
                string meshList = ShapeEditor.getDetailMeshList(colDetailSize.AsString());
                int meshCount = Util.getFieldCount(meshList);
                if (meshCount > 0)
                    {
                    ShapeEditor.shape.removeDetailLevel(colDetailSize);
                    for (int i = 0; i < meshCount; i++)
                        ShapeEdPropWindow.update_onMeshRemoved(Util.getField(meshList, i));
                    }

                string nodeList = ShapeEditor.getNodeNames(colNode, "", "");
                int nodeCount = Util.getFieldCount(nodeList);
                if (nodeCount > 0)
                    {
                    for (int i = 0; i < nodeCount; i++)
                        ShapeEditor.shape.removeNode(Util.getField(nodeList, i));
                    ShapeEdPropWindow.update_onNodeRemoved(nodeList, nodeCount);
                    }

                // Add the new node and geometry
                if (type == "")
                    return false;

                if (!ShapeEditor.shape.addCollisionDetail(colDetailSize, type, target, depth, merge, concavity, maxVerts, boxMax, sphereMax, capsuleMax))
                    return false;

                // Update UI
                meshList = ShapeEditor.getDetailMeshList(colDetailSize.AsString());
                ShapeEdPropWindow.update_onNodeAdded(colNode, ShapeEditor.shape.getNodeCount());
                // will also add child nodes
                int count = Util.getFieldCount(meshList);
                for (int i = 0; i < count; i++)
                    ShapeEdPropWindow.update_onMeshAdded(Util.getField(meshList, i));

                ShapeEdColWindow["lastColSettings"] = type + '\t' + target + '\t' + depth + '\t' + merge + '\t' + concavity + '\t' + maxVerts + '\t' + boxMax + '\t' + sphereMax + '\t' + capsuleMax;
                ShapeEdColWindow.update_onCollisionChanged();

                return true;
            }

            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEdAdvancedWindow.ShapeEdWaitGui ShapeEdWaitGui = "ShapeEdWaitGui";

                ShapeEdWaitGui.show("Generating collision geometry...");
                bool success = this.updateCollision(this["newType"], this["newTarget"], this["newDepth"].AsInt(), this["newMerge"].AsFloat(), this["newConcavity"].AsFloat(), this["newMaxVerts"].AsInt(), this["newBoxMax"].AsFloat(), this["newSphereMax"].AsFloat(), this["newCapsuleMax"].AsFloat());
                ShapeEdWaitGui.hide();

                return success;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEdAdvancedWindow.ShapeEdWaitGui ShapeEdWaitGui = "ShapeEdWaitGui";

                base.undo();

                ShapeEdWaitGui.show("Generating collision geometry...");
                this.updateCollision(this["oldType"], this["oldTarget"], this["oldDepth"].AsInt(), this["oldMerge"].AsFloat(), this["oldConcavity"].AsFloat(), this["oldMaxVerts"].AsInt(), this["oldBoxMax"].AsFloat(), this["oldSphereMax"].AsFloat(), this["oldCapsuleMax"].AsFloat());
                ShapeEdWaitGui.hide();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditCollision ts, string simobjectid)
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
            public static bool operator !=(ActionEditCollision ts, string simobjectid)
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
            public static implicit operator string(ActionEditCollision ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditCollision(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditCollision) Omni.self.getSimObject(simobjectid, typeof (ActionEditCollision));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditCollision ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditCollision(int simobjectid)
            {
                return (ActionEditCollision) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditCollision));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditCollision ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditCollision(uint simobjectid)
            {
                return (ActionEditCollision) Omni.self.getSimObject(simobjectid, typeof (ActionEditCollision));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditCyclic>))]
        public class ActionEditCyclic : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.setSequenceCyclic(this["seqName"], this["cyclic"].AsBool()))
                    {
                    ShapeEdPropWindow.update_onSequenceCyclicChanged(this["seqName"], this["cyclic"].AsBool());
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.setSequenceCyclic(this["seqName"], (!this["cyclic"].AsBool())))
                    ShapeEdPropWindow.update_onSequenceCyclicChanged(this["seqName"], !this["cyclic"].AsBool());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditCyclic ts, string simobjectid)
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
            public static bool operator !=(ActionEditCyclic ts, string simobjectid)
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
            public static implicit operator string(ActionEditCyclic ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditCyclic(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditCyclic) Omni.self.getSimObject(simobjectid, typeof (ActionEditCyclic));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditCyclic ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditCyclic(int simobjectid)
            {
                return (ActionEditCyclic) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditCyclic));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditCyclic ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditCyclic(uint simobjectid)
            {
                return (ActionEditCyclic) Omni.self.getSimObject(simobjectid, typeof (ActionEditCyclic));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditDetailSize>))]
        public class ActionEditDetailSize : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                int dl = ShapeEditor.shape.setDetailLevelSize(this["oldSize"].AsInt(), this["newSize"].AsInt());
                if (dl != -1)
                    {
                    ShapeEdPropWindow.update_onDetailSizeChanged(this["oldSize"], this["newSize"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                int dl = ShapeEditor.shape.setDetailLevelSize(this["newSize"].AsInt(), this["oldSize"].AsInt());
                if (dl != -1)
                    ShapeEdPropWindow.update_onDetailSizeChanged(this["newSize"], this["oldSize"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditDetailSize ts, string simobjectid)
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
            public static bool operator !=(ActionEditDetailSize ts, string simobjectid)
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
            public static implicit operator string(ActionEditDetailSize ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditDetailSize(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditDetailSize) Omni.self.getSimObject(simobjectid, typeof (ActionEditDetailSize));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditDetailSize ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditDetailSize(int simobjectid)
            {
                return (ActionEditDetailSize) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditDetailSize));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditDetailSize ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditDetailSize(uint simobjectid)
            {
                return (ActionEditDetailSize) Omni.self.getSimObject(simobjectid, typeof (ActionEditDetailSize));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditImposter>))]
        public class ActionEditImposter : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
                ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
                ShapeEdAdvancedWindow.ShapeEdWaitGui ShapeEdWaitGui = "ShapeEdWaitGui";
                ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";
                ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiTextEditCtrl detailSize = ShapeEdAdvancedWindow.FOT("detailSize");
                GuiTextEditCtrl meshSize = ShapeEdDetails.FOT("meshSize");
                GuiCheckBoxCtrl highlightMaterial = ShapeEdMaterials.FOT("highlightMaterial");

                string[] val = new string[7];

                // Unpack new imposter settings
                for (int i = 0; i < 7; i++)
                    val[i] = Util.getField(this["newImposter"], i);

                ShapeEdWaitGui.show("Generating imposter bitmaps...");

                // Need to de-highlight the current material, or the imposter will have the
                // highlight effect baked in!
                ShapeEdMaterials.updateSelectedMaterial(false);

                int dl = ShapeEditor.shape.addImposter(this["newSize"].AsInt(), val[1].AsInt(), val[2].AsInt(), val[3].AsInt(), val[4].AsInt(), val[5].AsBool(), val[6].AsFloat());
                ShapeEdWaitGui.hide();

                // Restore highlight effect
                ShapeEdMaterials.updateSelectedMaterial(highlightMaterial.getValue().AsBool());

                if (dl != -1)
                    {
                    ShapeEdShapeView.refreshShape();
                    ShapeEdShapeView["currentDL"] = dl.AsString();
                    detailSize.setText(this["newSize"]);
                    meshSize.setText(this["newSize"]);
                    ShapeEdDetails.update_onDetailsChanged();

                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
                ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
                ShapeEdAdvancedWindow.ShapeEdWaitGui ShapeEdWaitGui = "ShapeEdWaitGui";
                ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";
                ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiTextEditCtrl detailSize = ShapeEdAdvancedWindow.FOT("detailSize");
                GuiTextEditCtrl meshSize = ShapeEdDetails.FOT("meshSize");
                GuiCheckBoxCtrl highlightMaterial = ShapeEdMaterials.FOT("highlightMaterial");

                base.undo();

                // If this was a new imposter, just remove it. Otherwise restore the old settings
                if (this["oldDL"].AsInt() < 0)
                    {
                    if (ShapeEditor.shape.removeImposter())
                        {
                        ShapeEdShapeView.refreshShape();
                        ShapeEdShapeView.currentDL = 0;
                        ShapeEdDetails.update_onDetailsChanged();
                        }
                    }
                else
                    {
                    string[] val = new string[7];

                    // Unpack old imposter settings
                    for (int i = 0; i < 7; i++)
                        val[i] = Util.getField(this["oldImposter"], i);

                    ShapeEdWaitGui.show("Generating imposter bitmaps...");

                    // Need to de-highlight the current material, or the imposter will have the
                    // highlight effect baked in!
                    ShapeEdMaterials.updateSelectedMaterial(false);

                    int dl = ShapeEditor.shape.addImposter(this["oldSize"].AsInt(), val[1].AsInt(), val[2].AsInt(), val[3].AsInt(), val[4].AsInt(), val[5].AsBool(), val[6].AsFloat());
                    ShapeEdWaitGui.hide();

                    // Restore highlight effect
                    ShapeEdMaterials.updateSelectedMaterial(highlightMaterial.getValue().AsBool());

                    if (dl != -1)
                        {
                        ShapeEdShapeView.refreshShape();
                        ShapeEdShapeView["currentDL"] = dl.AsString();
                        detailSize.setText(this["oldSize"]);
                        meshSize.setText(this["oldSize"]);
                        }
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditImposter ts, string simobjectid)
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
            public static bool operator !=(ActionEditImposter ts, string simobjectid)
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
            public static implicit operator string(ActionEditImposter ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditImposter(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditImposter) Omni.self.getSimObject(simobjectid, typeof (ActionEditImposter));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditImposter ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditImposter(int simobjectid)
            {
                return (ActionEditImposter) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditImposter));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditImposter ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditImposter(uint simobjectid)
            {
                return (ActionEditImposter) Omni.self.getSimObject(simobjectid, typeof (ActionEditImposter));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditMeshBillboard>))]
        public class ActionEditMeshBillboard : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
                GuiPopUpMenuCtrl bbType = ShapeEdDetails.FOT("bbType");

                if (ShapeEditor.shape.setMeshType(this["meshName"], this["newType"]))
                    {
                    switch (ShapeEditor.shape.getMeshType(this["meshName"]))
                        {
                            case "normal":
                                bbType.setSelected(0, false);
                                break;
                            case "billboard":
                                bbType.setSelected(1, false);
                                break;
                            case "billboardzaxis":
                                bbType.setSelected(2, false);
                                break;
                        }
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEditor.ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
                ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
                GuiPopUpMenuCtrl bbType = ShapeEdDetails.FOT("bbType");

                base.undo();

                if (ShapeEditor.shape.setMeshType(this["meshName"], this["oldType"]))
                    {
                    int id = ShapeEdDetailTree.getSelectedItem();
                    if ((id > 1) && (ShapeEdDetailTree.getItemText(id) == this["meshName"]))
                        {
                        switch (ShapeEditor.shape.getMeshType(this["meshName"]))
                            {
                                case "normal":
                                    bbType.setSelected(0, false);
                                    break;
                                case "billboard":
                                    bbType.setSelected(1, false);
                                    break;
                                case "billboardzaxis":
                                    bbType.setSelected(2, false);
                                    break;
                            }
                        }
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditMeshBillboard ts, string simobjectid)
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
            public static bool operator !=(ActionEditMeshBillboard ts, string simobjectid)
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
            public static implicit operator string(ActionEditMeshBillboard ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditMeshBillboard(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditMeshBillboard) Omni.self.getSimObject(simobjectid, typeof (ActionEditMeshBillboard));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditMeshBillboard ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditMeshBillboard(int simobjectid)
            {
                return (ActionEditMeshBillboard) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditMeshBillboard));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditMeshBillboard ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditMeshBillboard(uint simobjectid)
            {
                return (ActionEditMeshBillboard) Omni.self.getSimObject(simobjectid, typeof (ActionEditMeshBillboard));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditMeshSize>))]
        public class ActionEditMeshSize : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.setMeshSize(this["meshName"] + ' ' + this["oldSize"], this["newSize"].AsInt()))
                    {
                    ShapeEdPropWindow.update_onMeshSizeChanged(this["meshName"], this["oldSize"], this["newSize"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.setMeshSize(this["meshName"] + " " + this["newSize"], this["oldSize"].AsInt()))
                    ShapeEdPropWindow.update_onMeshSizeChanged(this["meshName"], this["oldSize"], this["oldSize"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditMeshSize ts, string simobjectid)
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
            public static bool operator !=(ActionEditMeshSize ts, string simobjectid)
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
            public static implicit operator string(ActionEditMeshSize ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditMeshSize(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditMeshSize) Omni.self.getSimObject(simobjectid, typeof (ActionEditMeshSize));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditMeshSize ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditMeshSize(int simobjectid)
            {
                return (ActionEditMeshSize) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditMeshSize));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditMeshSize ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditMeshSize(uint simobjectid)
            {
                return (ActionEditMeshSize) Omni.self.getSimObject(simobjectid, typeof (ActionEditMeshSize));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditNodeTransform>))]
        public class ActionEditNodeTransform : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                ShapeEditor.shape.setNodeTransform(this["nodeName"], this["newTransform"].AsTransformF(), this["isWorld"].AsBool());
                ShapeEdPropWindow.update_onNodeTransformChanged(this["nodeName"]);
                return true;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                ShapeEditor.shape.setNodeTransform(this["nodeName"], this["oldTransform"].AsTransformF(), this["isWorld"].AsBool());
                ShapeEdPropWindow.update_onNodeTransformChanged(this["nodeName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditNodeTransform ts, string simobjectid)
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
            public static bool operator !=(ActionEditNodeTransform ts, string simobjectid)
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
            public static implicit operator string(ActionEditNodeTransform ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditNodeTransform(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditNodeTransform) Omni.self.getSimObject(simobjectid, typeof (ActionEditNodeTransform));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditNodeTransform ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditNodeTransform(int simobjectid)
            {
                return (ActionEditNodeTransform) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditNodeTransform));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditNodeTransform ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditNodeTransform(uint simobjectid)
            {
                return (ActionEditNodeTransform) Omni.self.getSimObject(simobjectid, typeof (ActionEditNodeTransform));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditSeqSource>))]
        public class ActionEditSeqSource : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";

                // If changing the source to an existing sequence, make a backup copy of
                // the existing sequence first, so we can edit the start/end frames later
                // without having to worry if the original source sequence has changed.
                if (!Util.startsWith(this["from"], "__backup__", false) && ShapeEditor.shape.getSequenceIndex(this["from"]) >= 0)
                    {
                    this["from"] = ShapeEditor.getUniqueName("sequence", "__backup__" + this["origFrom"] + "_");
                    ShapeEditor.shape.addSequence(this["origFrom"], this["from"]);
                    }

                // Get settings we want to retain
                float priority = ShapeEditor.shape.getSequencePriority(this["seqName"]);
                bool cyclic = ShapeEditor.shape.getSequenceCyclic(this["seqName"]);
                string blend = ShapeEditor.shape.getSequenceBlend(this["seqName"]);

                // Rename this sequence (instead of removing it) so we can undo this action
                ShapeEditor.shape.renameSequence(this["seqName"], this["seqBackup"]);

                // Add the new sequence
                if (ShapeEditor.shape.addSequence(this["from"], this["seqName"], this["start"].AsInt(), this["end"].AsInt()))
                    {
                    // Restore original settings
                    if (ShapeEditor.shape.getSequencePriority(this["seqName"]) != priority)
                        ShapeEditor.shape.setSequencePriority(this["seqName"], priority);
                    if (ShapeEditor.shape.getSequenceCyclic(this["seqName"]) != cyclic)
                        ShapeEditor.shape.setSequenceCyclic(this["seqName"], cyclic);

                    string newBlend = ShapeEditor.shape.getSequenceBlend(this["seqName"]);
                    if (newBlend != blend)
                        {
                        // Undo current blend, then apply new one
                        ShapeEditor.shape.setSequenceBlend(this["seqName"], false, Util.getField(newBlend, 1), Util.getField(newBlend, 2).AsInt());
                        if (Util.getField(blend, 0) == "1")
                            ShapeEditor.shape.setSequenceBlend(this["seqName"], Util.getField(blend, 0).AsBool(), Util.getField(blend, 1), Util.getField(blend, 2).AsInt());
                        }

                    if (ShapeEdSequenceList.getSelectedName() == this["seqName"])
                        {
                        ShapeEdSequenceList.editColumn(this["seqName"], 3, (this["end"].AsInt() - this["start"].AsInt() + 1).AsString());
                        ShapeEdPropWindow.syncPlaybackDetails();
                        }

                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";

                base.undo();

                // Remove the source sequence backup if one was created
                if ((this["from"] != this["origFrom"]) && (this["from"] != this["seqBackup"]))
                    {
                    ShapeEditor.shape.removeSequence(this["from"]);
                    this["from"] = this["origFrom"];
                    }

                // Remove the added sequence, and rename the backup back
                if (ShapeEditor.shape.removeSequence(this["seqName"]) && ShapeEditor.shape.renameSequence(this["seqBackup"], this["seqName"]))
                    {
                    if (ShapeEdSequenceList.getSelectedName() == this["seqName"])
                        {
                        ShapeEdSequenceList.editColumn(this["seqName"], 3, (this["end"].AsInt() - this["start"].AsInt() + 1).AsString());
                        ShapeEdPropWindow.syncPlaybackDetails();
                        }
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditSeqSource ts, string simobjectid)
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
            public static bool operator !=(ActionEditSeqSource ts, string simobjectid)
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
            public static implicit operator string(ActionEditSeqSource ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditSeqSource(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditSeqSource) Omni.self.getSimObject(simobjectid, typeof (ActionEditSeqSource));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditSeqSource ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditSeqSource(int simobjectid)
            {
                return (ActionEditSeqSource) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditSeqSource));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditSeqSource ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditSeqSource(uint simobjectid)
            {
                return (ActionEditSeqSource) Omni.self.getSimObject(simobjectid, typeof (ActionEditSeqSource));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditSequenceGroundSpeed>))]
        public class ActionEditSequenceGroundSpeed : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.setSequenceGroundSpeed(this["seqName"], this["newSpeed"].AsPoint3F()))
                    {
                    ShapeEdPropWindow.update_onSequenceGroundSpeedChanged(this["seqName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.setSequenceGroundSpeed(this["seqName"], this["oldSpeed"].AsPoint3F()))
                    ShapeEdPropWindow.update_onSequenceGroundSpeedChanged(this["seqName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditSequenceGroundSpeed ts, string simobjectid)
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
            public static bool operator !=(ActionEditSequenceGroundSpeed ts, string simobjectid)
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
            public static implicit operator string(ActionEditSequenceGroundSpeed ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditSequenceGroundSpeed(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditSequenceGroundSpeed) Omni.self.getSimObject(simobjectid, typeof (ActionEditSequenceGroundSpeed));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditSequenceGroundSpeed ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditSequenceGroundSpeed(int simobjectid)
            {
                return (ActionEditSequenceGroundSpeed) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditSequenceGroundSpeed));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditSequenceGroundSpeed ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditSequenceGroundSpeed(uint simobjectid)
            {
                return (ActionEditSequenceGroundSpeed) Omni.self.getSimObject(simobjectid, typeof (ActionEditSequenceGroundSpeed));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditSequencePriority>))]
        public class ActionEditSequencePriority : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.setSequencePriority(this["seqName"], this["newPriority"].AsFloat()))
                    {
                    ShapeEdPropWindow.update_onSequencePriorityChanged(this["seqName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.setSequencePriority(this["seqName"], this["oldPriority"].AsFloat()))
                    ShapeEdPropWindow.update_onSequencePriorityChanged(this["seqName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditSequencePriority ts, string simobjectid)
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
            public static bool operator !=(ActionEditSequencePriority ts, string simobjectid)
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
            public static implicit operator string(ActionEditSequencePriority ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditSequencePriority(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditSequencePriority) Omni.self.getSimObject(simobjectid, typeof (ActionEditSequencePriority));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditSequencePriority ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditSequencePriority(int simobjectid)
            {
                return (ActionEditSequencePriority) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditSequencePriority));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditSequencePriority ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditSequencePriority(uint simobjectid)
            {
                return (ActionEditSequencePriority) Omni.self.getSimObject(simobjectid, typeof (ActionEditSequencePriority));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionEditTrigger>))]
        public class ActionEditTrigger : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEditor.ShapeEdTriggerList ShapeEdTriggerList = "ShapeEdTriggerList";

                if (ShapeEditor.shape.addTrigger(this["seqName"], this["frame"].AsInt(), this["state"].AsInt()) && ShapeEditor.shape.removeTrigger(this["seqName"], this["oldFrame"].AsInt(), this["oldState"].AsInt()))
                    {
                    ShapeEdTriggerList.updateItem(this["oldFrame"].AsInt(), this["oldState"].AsFloat(), this["frame"].AsInt(), this["state"].AsFloat());
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEditor.ShapeEdTriggerList ShapeEdTriggerList = "ShapeEdTriggerList";

                base.undo();

                if (ShapeEditor.shape.addTrigger(this["seqName"], this["oldFrame"].AsInt(), this["oldState"].AsInt()) && ShapeEditor.shape.removeTrigger(this["seqName"], this["frame"].AsInt(), this["state"].AsInt()))
                    ShapeEdTriggerList.updateItem(this["frame"].AsInt(), this["state"].AsFloat(), this["oldFrame"].AsInt(), this["oldState"].AsFloat());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionEditTrigger ts, string simobjectid)
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
            public static bool operator !=(ActionEditTrigger ts, string simobjectid)
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
            public static implicit operator string(ActionEditTrigger ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionEditTrigger(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionEditTrigger) Omni.self.getSimObject(simobjectid, typeof (ActionEditTrigger));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionEditTrigger ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionEditTrigger(int simobjectid)
            {
                return (ActionEditTrigger) Omni.self.getSimObject((uint) simobjectid, typeof (ActionEditTrigger));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionEditTrigger ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionEditTrigger(uint simobjectid)
            {
                return (ActionEditTrigger) Omni.self.getSimObject(simobjectid, typeof (ActionEditTrigger));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRemoveDetail>))]
        public class ActionRemoveDetail : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                string meshList = ShapeEditor.getDetailMeshList(this["size"]);
                if (ShapeEditor.shape.removeDetailLevel(this["size"].AsInt()))
                    {
                    int meshCount = Util.getFieldCount(meshList);
                    for (int i = 0; i < meshCount; i++)
                        ShapeEdPropWindow.update_onMeshRemoved(Util.getField(meshList, i));
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                base.undo();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRemoveDetail ts, string simobjectid)
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
            public static bool operator !=(ActionRemoveDetail ts, string simobjectid)
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
            public static implicit operator string(ActionRemoveDetail ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveDetail(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRemoveDetail) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveDetail));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRemoveDetail ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveDetail(int simobjectid)
            {
                return (ActionRemoveDetail) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRemoveDetail));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRemoveDetail ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRemoveDetail(uint simobjectid)
            {
                return (ActionRemoveDetail) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveDetail));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRemoveImposter>))]
        public class ActionRemoveImposter : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
                ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                if (ShapeEditor.shape.removeImposter())
                    {
                    ShapeEdShapeView.refreshShape();
                    ShapeEdShapeView.currentDL = 0;
                    ShapeEdDetails.update_onDetailsChanged();

                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
                ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
                ShapeEdAdvancedWindow.ShapeEdWaitGui ShapeEdWaitGui = "ShapeEdWaitGui";
                ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";
                ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiTextEditCtrl detailSize = ShapeEdAdvancedWindow.FOT("detailSize");
                GuiTextEditCtrl meshSize = ShapeEdDetails.FOT("meshSize");
                GuiCheckBoxCtrl highlightMaterial = ShapeEdMaterials.FOT("highlightMaterial");

                base.undo();

                string[] val = new string[7];
                // Unpack the old imposter settings
                for (int i = 0; i < 7; i++)
                    val[i] = Util.getField(this["oldImposter"], i);

                ShapeEdWaitGui.show("Generating imposter bitmaps...");
                int dl = ShapeEditor.shape.addImposter(this["oldSize"].AsInt(), val[1].AsInt(), val[2].AsInt(), val[3].AsInt(), val[4].AsInt(), val[5].AsBool(), val[6].AsFloat());
                ShapeEdWaitGui.hide();

                if (dl != -1)
                    {
                    ShapeEdShapeView.refreshShape();
                    ShapeEdShapeView["currentDL"] = dl.AsString();
                    detailSize.setText(this["oldSize"]);
                    meshSize.setText(this["oldSize"]);
                    ShapeEdDetails.update_onDetailsChanged();
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRemoveImposter ts, string simobjectid)
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
            public static bool operator !=(ActionRemoveImposter ts, string simobjectid)
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
            public static implicit operator string(ActionRemoveImposter ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveImposter(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRemoveImposter) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveImposter));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRemoveImposter ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveImposter(int simobjectid)
            {
                return (ActionRemoveImposter) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRemoveImposter));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRemoveImposter ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRemoveImposter(uint simobjectid)
            {
                return (ActionRemoveImposter) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveImposter));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRemoveMesh>))]
        public class ActionRemoveMesh : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.removeMesh(this["meshName"]))
                    {
                    ShapeEdPropWindow.update_onMeshRemoved(this["meshName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                base.undo();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRemoveMesh ts, string simobjectid)
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
            public static bool operator !=(ActionRemoveMesh ts, string simobjectid)
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
            public static implicit operator string(ActionRemoveMesh ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveMesh(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRemoveMesh) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveMesh));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRemoveMesh ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveMesh(int simobjectid)
            {
                return (ActionRemoveMesh) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRemoveMesh));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRemoveMesh ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRemoveMesh(uint simobjectid)
            {
                return (ActionRemoveMesh) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveMesh));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRemoveNode>))]
        public class ActionRemoveNode : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                for (int i = 0; i < this["nameCount"].AsInt(); i++)
                    ShapeEditor.shape.removeNode(this["names[" + i + "]"]);

                // Update GUI
                ShapeEdPropWindow.update_onNodeRemoved(this["nameList"], this["nameCount"].AsInt());

                return true;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                base.undo();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRemoveNode ts, string simobjectid)
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
            public static bool operator !=(ActionRemoveNode ts, string simobjectid)
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
            public static implicit operator string(ActionRemoveNode ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveNode(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRemoveNode) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveNode));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRemoveNode ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveNode(int simobjectid)
            {
                return (ActionRemoveNode) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRemoveNode));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRemoveNode ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRemoveNode(uint simobjectid)
            {
                return (ActionRemoveNode) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveNode));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRemoveSequence>))]
        public class ActionRemoveSequence : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.removeSequence(this["seqName"]))
                    {
                    ShapeEdPropWindow.update_onSequenceRemoved(this["seqName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                base.undo();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRemoveSequence ts, string simobjectid)
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
            public static bool operator !=(ActionRemoveSequence ts, string simobjectid)
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
            public static implicit operator string(ActionRemoveSequence ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveSequence(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRemoveSequence) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveSequence));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRemoveSequence ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveSequence(int simobjectid)
            {
                return (ActionRemoveSequence) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRemoveSequence));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRemoveSequence ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRemoveSequence(uint simobjectid)
            {
                return (ActionRemoveSequence) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveSequence));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRemoveTrigger>))]
        public class ActionRemoveTrigger : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.removeTrigger(this["seqName"], this["frame"].AsInt(), this["state"].AsInt()))
                    {
                    ShapeEdPropWindow.update_onTriggerRemoved(this["seqName"], this["frame"].AsInt(), this["state"].AsFloat());
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.addTrigger(this["seqName"], this["frame"].AsInt(), this["state"].AsInt()))
                    ShapeEdPropWindow.update_onTriggerAdded(this["seqName"], this["frame"].AsInt(), this["state"].AsFloat());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRemoveTrigger ts, string simobjectid)
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
            public static bool operator !=(ActionRemoveTrigger ts, string simobjectid)
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
            public static implicit operator string(ActionRemoveTrigger ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveTrigger(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRemoveTrigger) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveTrigger));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRemoveTrigger ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRemoveTrigger(int simobjectid)
            {
                return (ActionRemoveTrigger) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRemoveTrigger));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRemoveTrigger ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRemoveTrigger(uint simobjectid)
            {
                return (ActionRemoveTrigger) Omni.self.getSimObject(simobjectid, typeof (ActionRemoveTrigger));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRenameDetail>))]
        public class ActionRenameDetail : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.renameDetailLevel(this["oldName"], this["newName"]))
                    {
                    ShapeEdPropWindow.update_onDetailRenamed(this["oldName"], this["newName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.renameDetailLevel(this["newName"], this["oldName"]))
                    ShapeEdPropWindow.update_onDetailRenamed(this["newName"], this["oldName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRenameDetail ts, string simobjectid)
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
            public static bool operator !=(ActionRenameDetail ts, string simobjectid)
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
            public static implicit operator string(ActionRenameDetail ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRenameDetail(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRenameDetail) Omni.self.getSimObject(simobjectid, typeof (ActionRenameDetail));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRenameDetail ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRenameDetail(int simobjectid)
            {
                return (ActionRenameDetail) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRenameDetail));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRenameDetail ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRenameDetail(uint simobjectid)
            {
                return (ActionRenameDetail) Omni.self.getSimObject(simobjectid, typeof (ActionRenameDetail));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRenameNode>))]
        public class ActionRenameNode : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.renameNode(this["oldName"], this["newName"]))
                    {
                    ShapeEdPropWindow.update_onNodeRenamed(this["oldName"], this["newName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.renameNode(this["newName"], this["oldName"]))
                    ShapeEdPropWindow.update_onNodeRenamed(this["newName"], this["oldName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRenameNode ts, string simobjectid)
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
            public static bool operator !=(ActionRenameNode ts, string simobjectid)
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
            public static implicit operator string(ActionRenameNode ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRenameNode(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRenameNode) Omni.self.getSimObject(simobjectid, typeof (ActionRenameNode));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRenameNode ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRenameNode(int simobjectid)
            {
                return (ActionRenameNode) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRenameNode));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRenameNode ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRenameNode(uint simobjectid)
            {
                return (ActionRenameNode) Omni.self.getSimObject(simobjectid, typeof (ActionRenameNode));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRenameObject>))]
        public class ActionRenameObject : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.renameObject(this["oldName"], this["newName"]))
                    {
                    ShapeEdPropWindow.update_onObjectRenamed(this["oldName"], this["newName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.renameObject(this["newName"], this["oldName"]))
                    ShapeEdPropWindow.update_onObjectRenamed(this["newName"], this["oldName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRenameObject ts, string simobjectid)
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
            public static bool operator !=(ActionRenameObject ts, string simobjectid)
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
            public static implicit operator string(ActionRenameObject ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRenameObject(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRenameObject) Omni.self.getSimObject(simobjectid, typeof (ActionRenameObject));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRenameObject ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRenameObject(int simobjectid)
            {
                return (ActionRenameObject) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRenameObject));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRenameObject ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRenameObject(uint simobjectid)
            {
                return (ActionRenameObject) Omni.self.getSimObject(simobjectid, typeof (ActionRenameObject));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionRenameSequence>))]
        public class ActionRenameSequence : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                if (ShapeEditor.shape.renameSequence(this["oldName"], this["newName"]))
                    {
                    ShapeEdPropWindow.update_onSequenceRenamed(this["oldName"], this["newName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.renameSequence(this["newName"], this["oldName"]))
                    ShapeEdPropWindow.update_onSequenceRenamed(this["newName"], this["oldName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionRenameSequence ts, string simobjectid)
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
            public static bool operator !=(ActionRenameSequence ts, string simobjectid)
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
            public static implicit operator string(ActionRenameSequence ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionRenameSequence(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionRenameSequence) Omni.self.getSimObject(simobjectid, typeof (ActionRenameSequence));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionRenameSequence ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionRenameSequence(int simobjectid)
            {
                return (ActionRenameSequence) Omni.self.getSimObject((uint) simobjectid, typeof (ActionRenameSequence));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionRenameSequence ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionRenameSequence(uint simobjectid)
            {
                return (ActionRenameSequence) Omni.self.getSimObject(simobjectid, typeof (ActionRenameSequence));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionSetBounds>))]
        public class ActionSetBounds : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";

                return ShapeEditor.shape.setBounds(this["newBounds"].AsBox3F());
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";

                base.undo();

                ShapeEditor.shape.setBounds(this["oldBounds"].AsBox3F());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionSetBounds ts, string simobjectid)
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
            public static bool operator !=(ActionSetBounds ts, string simobjectid)
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
            public static implicit operator string(ActionSetBounds ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionSetBounds(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionSetBounds) Omni.self.getSimObject(simobjectid, typeof (ActionSetBounds));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionSetBounds ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionSetBounds(int simobjectid)
            {
                return (ActionSetBounds) Omni.self.getSimObject((uint) simobjectid, typeof (ActionSetBounds));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionSetBounds ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionSetBounds(uint simobjectid)
            {
                return (ActionSetBounds) Omni.self.getSimObject(simobjectid, typeof (ActionSetBounds));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionSetNodeParent>))]
        public class ActionSetNodeParent : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.setNodeParent(this["nodeName"], this["parentName"]))
                    {
                    ShapeEdPropWindow.update_onNodeParentChanged(this["nodeName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.setNodeParent(this["nodeName"], this["oldParentName"]))
                    ShapeEdPropWindow.update_onNodeParentChanged(this["nodeName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionSetNodeParent ts, string simobjectid)
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
            public static bool operator !=(ActionSetNodeParent ts, string simobjectid)
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
            public static implicit operator string(ActionSetNodeParent ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionSetNodeParent(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionSetNodeParent) Omni.self.getSimObject(simobjectid, typeof (ActionSetNodeParent));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionSetNodeParent ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionSetNodeParent(int simobjectid)
            {
                return (ActionSetNodeParent) Omni.self.getSimObject((uint) simobjectid, typeof (ActionSetNodeParent));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionSetNodeParent ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionSetNodeParent(uint simobjectid)
            {
                return (ActionSetNodeParent) Omni.self.getSimObject(simobjectid, typeof (ActionSetNodeParent));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ActionSetObjectNode>))]
        public class ActionSetObjectNode : BaseShapeEdAction
        {
            [ConsoleInteraction]
            public override bool doit()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                if (ShapeEditor.shape.setObjectNode(this["objName"], this["newNode"]))
                    {
                    ShapeEdPropWindow.update_onObjectNodeChanged(this["objName"]);
                    return true;
                    }
                return false;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                base.undo();

                if (ShapeEditor.shape.setObjectNode(this["objName"], this["oldNode"]))
                    ShapeEdPropWindow.update_onObjectNodeChanged(this["objName"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionSetObjectNode ts, string simobjectid)
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
            public static bool operator !=(ActionSetObjectNode ts, string simobjectid)
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
            public static implicit operator string(ActionSetObjectNode ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionSetObjectNode(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionSetObjectNode) Omni.self.getSimObject(simobjectid, typeof (ActionSetObjectNode));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionSetObjectNode ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionSetObjectNode(int simobjectid)
            {
                return (ActionSetObjectNode) Omni.self.getSimObject((uint) simobjectid, typeof (ActionSetObjectNode));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionSetObjectNode ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionSetObjectNode(uint simobjectid)
            {
                return (ActionSetObjectNode) Omni.self.getSimObject(simobjectid, typeof (ActionSetObjectNode));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<BaseShapeEdAction>))]
        public class BaseShapeEdAction : UndoScriptAction
        {
            [ConsoleInteraction]
            public virtual bool doit()
            {
                return false;
            }

            [ConsoleInteraction]
            public override void redo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";

                // Default redo action is the same as the doit action
                if (this.doit())
                    ShapeEditor.setDirty(true);
                else
                    messageBox.MessageBoxOK("Error", "Redo" + ' ' + this["actionName"] + ' ' + "failed. Check the console for error messages.", "");
            }

            [ConsoleInteraction]
            public override void undo()
            {
                ShapeEditor ShapeEditor = "ShapeEditor";

                ShapeEditor.setDirty(true);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(BaseShapeEdAction ts, string simobjectid)
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
            public static bool operator !=(BaseShapeEdAction ts, string simobjectid)
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
            public static implicit operator string(BaseShapeEdAction ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator BaseShapeEdAction(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (BaseShapeEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseShapeEdAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(BaseShapeEdAction ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator BaseShapeEdAction(int simobjectid)
            {
                return (BaseShapeEdAction) Omni.self.getSimObject((uint) simobjectid, typeof (BaseShapeEdAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(BaseShapeEdAction ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator BaseShapeEdAction(uint simobjectid)
            {
                return (BaseShapeEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseShapeEdAction));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdUndoManager>))]
        public class ShapeEdUndoManager : UndoManager
        {
            [ConsoleInteraction]
            public void updateUndoMenu(MenuBuilder editMenu)
            {
                string undoName = this.getNextUndoName();
                string redoName = this.getNextRedoName();

                editMenu.setItemName(0, "Undo " + undoName);
                editMenu.setItemName(1, "Redo " + redoName);

                editMenu.enableItem(0, (undoName != ""));
                editMenu.enableItem(1, (redoName != ""));
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdUndoManager ts, string simobjectid)
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
            public static bool operator !=(ShapeEdUndoManager ts, string simobjectid)
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
            public static implicit operator string(ShapeEdUndoManager ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdUndoManager(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdUndoManager) Omni.self.getSimObject(simobjectid, typeof (ShapeEdUndoManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdUndoManager ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdUndoManager(int simobjectid)
            {
                return (ShapeEdUndoManager) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdUndoManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdUndoManager ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdUndoManager(uint simobjectid)
            {
                return (ShapeEdUndoManager) Omni.self.getSimObject(simobjectid, typeof (ShapeEdUndoManager));
            }

            #endregion
        }
    }
}