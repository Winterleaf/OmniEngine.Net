using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<TerrainPainter>))]
    public class TerrainPainter : GuiWindowCollapseCtrl
        {
        public string filter
        {
            get
            {
                return this["filter"];
            }
            set
            {
                this["filter"] = value;
            }
        }
        public override void onPopWindow()
            {
            TerrainPainterPlugin TerrainPainterPlugin = "TerrainPainterPlugin";

            EditorGui.DeactivateAll();
            TerrainPainterPlugin.onActivated();
            }

        public override void onPopWindowClosed()
            {
            TerrainPainterPlugin TerrainPainterPlugin = "TerrainPainterPlugin";
            GuiWindowCollapseCtrl TerrainPainterPreview = "TerrainPainterPreview";
            EditorGui.DeactivateAll();
            TerrainPainterPlugin.onActivated();
            this.attachTo(TerrainPainterPreview);
            }

        [ConsoleInteraction]
        public void updateLayers(string matIndex)
            {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            SimSet TerrainMaterialSet = "TerrainMaterialSet";

            // Default to whatever was selected before.
            if (matIndex == "")
                matIndex = ETerrainEditor.paintIndex.AsString();
            else
                ETerrainEditor.paintIndex = matIndex.AsInt(); //TerrainPainterAddition

            // The material string is a newline seperated string of
            // TerrainMaterial internal names which we can use to find
            // the actual material data in TerrainMaterialSet.

            string mats = ETerrainEditor.getMaterials();

            GuiStackControl matList = this.findObjectByInternalName("theMaterialList", true);
            matList.deleteAllObjects();

            string listWidth = matList.getExtent().x.AsString();

            for (int i = 0; i < Util.getRecordCount(mats); i++)
                {
                string matInternalName = Util.getRecord(mats, i);
                TerrainMaterial mat = TerrainMaterialSet.findObjectByInternalName(matInternalName, true);
                // Is there no material info for this slot?

                if (!mat.isObject())
                    continue;

                //if( this.filter != "" )
                //{
                //    if( Util.strstr( Util.strlwr(matInternalName), Util.strlwr(this.filter) ) == -1 )
                //        continue;
                //}
         
                ////TerrainPainterAddition
                //string terrainFolder = mat["terrainFolder"];
                //if( terrainFolder == "" )
                //    terrainFolder = "Unused";
      
                //string rolloutName = terrainFolder + "Rollout";
                //GuiRolloutCtrl rollout = matList.FOT(rolloutName);
                //GuiStackControl stack = "";
                //if( !rollout.isObject() )
                //{
                //    ObjectCreator ocRollout = new ObjectCreator("GuiRolloutCtrl");
                //    ocRollout["caption"] = terrainFolder;
                //    ocRollout["extent"] = listWidth + " " + "0";
                //    ocRollout["internalName"] = rolloutName;

                //    rollout = ocRollout.Create();

                //    ObjectCreator ocStack = new ObjectCreator("GuiStackControl");
                //    ocStack["StackingType"] = "Vertical";
                //    ocStack["HorizStacking"] = "Left to Right";
                //    ocStack["VertStacking"] = "Top to Bottom";
                //    ocStack["Padding"] = "-2";
                //    ocStack["canSaveDynamicFields"] = "0";
                //    ocStack["Enabled"] = "1";
                //    ocStack["isContainer"] = "1";
                //    ocStack["Profile"] = "ToolsGuiDefaultProfile";
                //    ocStack["HorizSizing"] = "width";
                //    ocStack["VertSizing"] = "bottom";
                //    ocStack["Position"] = "1 3";
                //    ocStack["Extent"] = listWidth + "" + "16";
                //    ocStack["MinExtent"] = "16 16";
                //    ocStack["canSave"] = "1";
                //    ocStack["isDecoy"] = "0";
                //    ocStack["Visible"] = "1";
                //    ocStack["internalName"] = "stackControl";
                //    ocStack["tooltipprofile"] = "ToolsGuiToolTipProfile";
                //    ocStack["hovertime"] = "1000";

                //    stack = ocStack.Create();
         
                //    rollout.add(stack);         
         
                //    matList.add(rollout);
                //}
                //else
                //{
                //    stack = rollout.FOT("stackControl");
                //}

                //int index = matList.getCount();

                string command = "ETerrainEditor.setPaintMaterial( " + i + ", " + mat + " );TerrainPainter.removeOtherSelections($ThisControl);TerrainPainter.lastActiveButton = $ThisControl;";
                string altCommand = "TerrainMaterialDlg.show( " + i + ", " + mat +
                                    ", EPainter_TerrainMaterialUpdateCallback );";

                ObjectCreator oc = new ObjectCreator("GuiIconButtonCtrl", "", typeof (EPainterIconBtn));
                //oc["class"] = "EPainterIconBtn";
                oc["internalName"] = "EPainterMaterialButton" + i;
                oc["profile"] = "GuiCreatorIconButtonProfile";
                oc["iconLocation"] = "Left";
                oc["textLocation"] = "Right";
                oc["extent"] = listWidth + " 46";
                oc["textMargin"] = 5;
                oc["buttonMargin"] = "4 4";
                oc["buttonType"] = "RadioButton";
                oc["sizeIconToButton"] = true;
                oc["makeIconSquare"] = true;
                oc["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc["command"] = command;
                oc["altCommand"] = altCommand;
                oc["useMouseEvents"] = true;

                ObjectCreator oc1 = new ObjectCreator("GuiBitmapButtonCtrl");
                oc1["bitmap"] = "tools/gui/images/delete";
                oc1["buttonType"] = "PushButton";
                oc1["HorizSizing"] = "left";
                oc1["VertSizing"] = "bottom";
                oc1["position"] = (listWidth.AsInt() - 20) + " 26";
                oc1["Extent"] = "17 17";
                //Copyright Winterleaf Entertainment L.L.C. 2013
                oc1["command"] = "TerrainPainter.showMaterialDeleteDlg( " + matInternalName + " );";
                //Copyright Winterleaf Entertainment L.L.C. 2013

                oc["#1"] = oc1;

                EPainterIconBtn ctrl = oc.Create();

                ctrl.setText(matInternalName);
                ctrl.setBitmap(mat.diffuseMap);

                string tooltip = matInternalName;

                if (i < 9)
                    tooltip = tooltip + " (" + (i + 1) + ")";
                else if (i == 9)
                    tooltip = tooltip + " (0)";

                ctrl.tooltip = tooltip;

                //stack.add(ctrl);
                matList.add(ctrl);
                }

            //int matCount = ETerrainEditor.getMaterialCount();
            int matCount = matList.getCount();
            // Add one more layer as the 'add new' layer.
            ObjectCreator ocb = new ObjectCreator("GuiIconButtonCtrl");
            ocb["profile"] = "GuiCreatorIconButtonProfile";
            ocb["iconBitmap"] = "tools/worldEditor/images/terrainpainter/new_layer_icon";
            ocb["iconLocation"] = "Left";
            ocb["textLocation"] = "Right";
            ocb["extent"] = listWidth + " 46";
            ocb["textMargin"] = 5;
            ocb["buttonMargin"] = "4 4";
            ocb["buttonType"] = "PushButton";
            ocb["sizeIconToButton"] = true;
            ocb["makeIconSquare"] = true;
            ocb["tooltipprofile"] = "ToolsGuiToolTipProfile";
            ocb["text"] = "New Layer";
            ocb["tooltip"] = "New Layer";
            ocb["command"] = "TerrainMaterialDlg.show( " + matCount + ", 0, EPainter_TerrainMaterialAddCallback );";
            GuiIconButtonCtrl ictrl = ocb.Create();
            matList.add(ictrl);

            // Make sure our selection is valid and that we're
            // not selecting the 'New Layer' button.

            if (matIndex.AsInt() < 0)
                return;
            if (matIndex.AsInt() >= matCount)
                matIndex = "0";

            // To make things simple... click the paint material button to
            // active it and initialize other state.

            ictrl = matList.getObject(matIndex.AsUint());
            //ictrl = matList.findObjectByInternalName("EPainterMaterialButton" + matIndex, true);
            
            ictrl.call("performClick");
            }

        //TerrainPainterAddition
        [ConsoleInteraction]
        public void removeOtherSelections(EPainterIconBtn currentCtrl)
        {
           if( this["lastActiveButton"].isObject() && this["lastActiveButton"] != currentCtrl )
           {
              if( ((GuiIconButtonCtrl)this["lastActiveButton"]).getParent() != currentCtrl.getParent() )
                 ((GuiIconButtonCtrl)this["lastActiveButton"]).setStateOn(false);
           }
        }

        //TerrainPainterAddition
        [TypeConverter(typeof(TypeConverterGeneric<TerrainSelectorTextEdit>))]
        public class TerrainSelectorTextEdit : GuiTextEditCtrl
        {
            [ConsoleInteraction]
            public override void onReturn()
            {
                TerrainEditor ETerrainEditor = "ETerrainEditor";

                TerrainPainter TerrainPainter = "TerrainPainter";
                string text = this.getText();
                if( text == "" )
                    this.reset();
                else
                {
                    TerrainPainter.filter = text;
                    TerrainPainter.updateLayers( ETerrainEditor.paintIndex.AsString() );
                }

            }

            //TerrainPainterAddition
            [ConsoleInteraction]
            public void reset( )
            {
                TerrainEditor ETerrainEditor = "ETerrainEditor";

                TerrainPainter TerrainPainter = "TerrainPainter";
                this.setText( "Filter..." );
                TerrainPainter.filter = "";
                TerrainPainter.updateLayers( ETerrainEditor.paintIndex.AsString() );
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TerrainSelectorTextEdit ts, string simobjectid)
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
                return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(TerrainSelectorTextEdit ts, string simobjectid)
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
            public static implicit operator string(TerrainSelectorTextEdit ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TerrainSelectorTextEdit(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (TerrainSelectorTextEdit)Omni.self.getSimObject(simobjectid, typeof(TerrainSelectorTextEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TerrainSelectorTextEdit ts)
            {
                return (int)ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TerrainSelectorTextEdit(int simobjectid)
            {
                return (TerrainSelectorTextEdit)Omni.self.getSimObject((uint)simobjectid, typeof(TerrainSelectorTextEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TerrainSelectorTextEdit ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TerrainSelectorTextEdit(uint simobjectid)
            {
                return (TerrainSelectorTextEdit)Omni.self.getSimObject(simobjectid, typeof(TerrainSelectorTextEdit));
            }

            #endregion
        }
        
        //TerrainPainterAddition
        public class TerrainSelectorClearButton : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ((TerrainSelectorTextEdit)this["textCtrl"]).reset();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TerrainSelectorClearButton ts, string simobjectid)
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
                return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(TerrainSelectorClearButton ts, string simobjectid)
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
            public static implicit operator string(TerrainSelectorClearButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TerrainSelectorClearButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (TerrainSelectorClearButton)Omni.self.getSimObject(simobjectid, typeof(TerrainSelectorClearButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TerrainSelectorClearButton ts)
            {
                return (int)ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TerrainSelectorClearButton(int simobjectid)
            {
                return (TerrainSelectorClearButton)Omni.self.getSimObject((uint)simobjectid, typeof(TerrainSelectorClearButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TerrainSelectorClearButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TerrainSelectorClearButton(uint simobjectid)
            {
                return (TerrainSelectorClearButton)Omni.self.getSimObject(simobjectid, typeof(TerrainSelectorClearButton));
            }

            #endregion
        }
        

        [ConsoleInteraction]
        public void showMaterialDeleteDlg(string matInternalName)
            {
            messageBox.MessageBoxYesNo("Confirmation",
                "Really remove material '" + matInternalName + "' from the terrain?",
                this + ".removeMaterial( \"" + matInternalName + "\" );", "");
            }

        [ConsoleInteraction]
        public void removeMaterial(string matInternalName)
            {
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            int selIndex = ETerrainEditor.paintIndex - 1;

            // Remove the material from the terrain.

            int index = ETerrainEditor.getMaterialIndex(matInternalName);

            if (index != -1)
                ETerrainEditor.removeMaterial(index);

            this.updateLayers(selIndex.AsString());
            }

        [ConsoleInteraction]
        public void setup(int matIndex)
            {
            this.updateLayers(matIndex.AsString());
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            ETerrainEditor["currentMode"] = "paint";
            ETerrainEditor.selectionHidden = true;
            ETerrainEditor.currentAction = "paintMaterial";
            ETerrainEditor["currentActionDesc"] = "Paint material on terrain";
            ETerrainEditor.setAction(ETerrainEditor.currentAction);
            ((EditorGui.EditorGuiStatusBar) "EditorGuiStatusBar").setInfo(ETerrainEditor["currentActionDesc"]);
            ETerrainEditor.renderVertexSelection = true;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainPainter ts, string simobjectid)
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
        public static bool operator !=(TerrainPainter ts, string simobjectid)
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
        public static implicit operator string(TerrainPainter ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TerrainPainter(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (TerrainPainter) Omni.self.getSimObject(simobjectid, typeof (TerrainPainter));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TerrainPainter ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainPainter(int simobjectid)
            {
            return (TerrainPainter) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainPainter));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TerrainPainter ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainPainter(uint simobjectid)
            {
            return (TerrainPainter) Omni.self.getSimObject(simobjectid, typeof (TerrainPainter));
            }

        #endregion
        }
    }