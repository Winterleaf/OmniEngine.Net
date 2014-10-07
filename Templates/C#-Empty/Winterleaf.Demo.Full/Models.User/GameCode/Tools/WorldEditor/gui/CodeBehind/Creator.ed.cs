using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
{
    public class Creator
    {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static int alphaIconCompare(SimObject a, SimObject b)
        {
            if (a["class"] == "CreatorFolderIconBtn")
                if (b["class"] != "CreatorFolderIconBtn")
                    return -1;

            if (b["class"] == "CreatorFolderIconBtn")
                if (a["class"] != "CreatorFolderIconBtn")
                    return 1;

            int result = omni.Util.stricmp(a["text"], b["text"]);
            return result;
        }

        // Generic create object helper for use from the console.
        [ConsoleInteraction]
        public static string genericCreateObject(string className)
        {
            EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";

            if (!omni.Util.isClass(className))
            {
                omni.Util._warn("createObject( " + className + " ) - Was not a valid class.");
                return "";
            }

            string cmd = "return new " + className + "();";

            string obj = EWCreatorWindow.createObject(cmd);

            // In case the caller wants it.
            return obj;
        }

        [TypeConverter(typeof(TypeConverterGeneric<CreatorPopupMenu>))]
        public class CreatorPopupMenu : GuiPopUpMenuCtrl
        {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
            {
                EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";

                string split = Util.strreplace(text, "/", " ");
                EWCreatorWindow.navigate(split);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(CreatorPopupMenu ts, string simobjectid)
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
                return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(CreatorPopupMenu ts, string simobjectid)
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
            public static implicit operator string(CreatorPopupMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator CreatorPopupMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (CreatorPopupMenu)Omni.self.getSimObject(simobjectid, typeof(CreatorPopupMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(CreatorPopupMenu ts)
            {
                return (int)ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator CreatorPopupMenu(int simobjectid)
            {
                return (CreatorPopupMenu)Omni.self.getSimObject((uint)simobjectid, typeof(CreatorPopupMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(CreatorPopupMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator CreatorPopupMenu(uint simobjectid)
            {
                return (CreatorPopupMenu)Omni.self.getSimObject(simobjectid, typeof(CreatorPopupMenu));
            }

            #endregion
        }

        [TypeConverter(typeof(CreatorTabBook))]
        public class CreatorTabBook : GuiTabBookCtrl
        {
            [ConsoleInteraction]
            public override void onTabSelected(string text, uint index)
            {
                EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";

                if (this.isAwake())
                {
                    EWCreatorWindow.tab = text;
                    EWCreatorWindow.navigate("");
                }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(CreatorTabBook ts, string simobjectid)
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
                return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(CreatorTabBook ts, string simobjectid)
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
            public static implicit operator string(CreatorTabBook ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator CreatorTabBook(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (CreatorTabBook)Omni.self.getSimObject(simobjectid, typeof(CreatorTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(CreatorTabBook ts)
            {
                return (int)ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator CreatorTabBook(int simobjectid)
            {
                return (CreatorTabBook)Omni.self.getSimObject((uint)simobjectid, typeof(CreatorTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(CreatorTabBook ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator CreatorTabBook(uint simobjectid)
            {
                return (CreatorTabBook)Omni.self.getSimObject(simobjectid, typeof(CreatorTabBook));
            }

            #endregion
        }

        [TypeConverter(typeof(EWCreatorWindow))]
        public class EWCreatorWindow : GuiTabPageCtrl
        {
            public ArrayObject array
            {
                get { return this["array"]; }
                set { this["array"] = value; }
            }

            public bool isList
            {
                get { return this["isList"].AsBool(); }
                set { this["isList"] = value.AsString(); }
            }

            public string currentGroup
            {
                get { return this["currentGroup"]; }
                set { this["currentGroup"] = value; }
            }

            public string tab
            {
                get { return this["tab"]; }
                set { this["tab"] = value; }
            }

            public string address
            {
                get { return this["address"]; }
                set { this["address"] = value; }
            }

            public SimGroup objectGroup
            {
                get { return this["objectGroup"]; }
                set { this["objectGroup"] = value; }
            }

            public GuiControl contentCtrl
            {
                get { return this["contentCtrl"]; }
                set { this["contentCtrl"] = value; }
            }

            [ConsoleInteraction]
            public void init()
            {
                // Just so we can recall this method for testing changes
                // without restarting.
                if (this.array.isObject())
                    this.array.delete();

                this.array = new ObjectCreator("ArrayObject").Create();
                this.array.caseSensitive = true;
                this.setListView(true);

                this.beginGroup("Environment");

                // Removed Prefab as there doesn't really seem to be a point in creating a blank one
                //this.registerMissionObject( "Prefab",              "Prefab" );
                this.registerMissionObject("SkyBox", "Sky Box", "", "");
                this.registerMissionObject("CloudLayer", "Cloud Layer", "", "");
                this.registerMissionObject("BasicClouds", "Basic Clouds", "", "");
                this.registerMissionObject("ScatterSky", "Scatter Sky", "", "");
                this.registerMissionObject("Sun", "Basic Sun", "", "");
                this.registerMissionObject("Lightning", "", "", "");
                this.registerMissionObject("WaterBlock", "Water Block", "", "");
                this.registerMissionObject("SFXEmitter", "Sound Emitter", "", "");
                this.registerMissionObject("Precipitation", "", "", "");
                this.registerMissionObject("ParticleEmitterNode", "Particle Emitter", "", "");

                this.registerMissionObject("VolumetricFog", "Volumetric Fog", "", "");

                // Legacy features. Users should use Ground Cover and the Forest Editor.   
                //this.registerMissionObject("fxShapeReplicator", "Shape Replicator", "", "");
                //this.registerMissionObject("fxFoliageReplicator", "Foliage Replicator", "", "");

                this.registerMissionObject("PointLight", "Point Light", "", "");
                this.registerMissionObject("SpotLight", "Spot Light", "", "");
                this.registerMissionObject("GroundCover", "Ground Cover", "", "");
                this.registerMissionObject("TerrainBlock", "Terrain Block", "", "");
                this.registerMissionObject("GroundPlane", "Ground Plane", "", "");
                this.registerMissionObject("WaterPlane", "Water Plane", "", "");
                this.registerMissionObject("ForestWindEmitter", "Wind Emitter", "", "");

                //These objects no longer exist in the code base.
                //this.registerMissionObject("PxCloth", "Cloth", "", "");
                //this.registerMissionObject("DustEmitter", "Dust Emitter", "", "");
                //this.registerMissionObject("DustSimulation", "Dust Simulation", "", "");
                //this.registerMissionObject("DustEffecter", "Dust Effecter", "", "");

                this.endGroup("");

                this.beginGroup("Level");

                this.registerMissionObject("MissionArea", "Mission Area", "", "");
                this.registerMissionObject("Path", "", "", "");
                this.registerMissionObject("Marker", "Path Node", "", "");
                this.registerMissionObject("Trigger", "", "", "");
                this.registerMissionObject("PhysicalZone", "Physical Zone", "", "");
                this.registerMissionObject("Camera", "", "", "");
                this.registerMissionObject("LevelInfo", "Level Info", "", "");
                this.registerMissionObject("TimeOfDay", "Time of Day", "", "");
                this.registerMissionObject("Zone", "Zone", "", "");
                this.registerMissionObject("Portal", "Zone Portal", "", "");
                this.registerMissionObject("SpawnSphere", "Player Spawn Sphere", "PlayerDropPoint", "");
                this.registerMissionObject("SpawnSphere", "Observer Spawn Sphere", "ObserverDropPoint", "");
                this.registerMissionObject("SFXSpace", "Sound Space", "", "");
                this.registerMissionObject("OcclusionVolume", "Occlusion Volume", "", "");

                this.endGroup("");

                this.beginGroup("System");

                this.registerMissionObject("SimGroup", "", "", "");

                this.endGroup("");

                this.beginGroup("ExampleObjects");

                this.registerMissionObject("RenderObjectExample", "", "", "");
                this.registerMissionObject("RenderMeshExample", "", "", "");
                this.registerMissionObject("RenderShapeExample", "", "", "");

                this.endGroup("");

                this.beginGroup("Walkable Shapes");

                this.registerMissionObject("TSAttachable", "Attachable Object", "", "");
                this.registerMissionObject("TSPathShape", "PathShape Object", "", "");

                this.endGroup("");

            }

            [ConsoleInteraction]
            public override void onWake()
            {
                CreatorTabBook CreatorTabBook = "CreatorTabBook";

                CreatorTabBook.selectPage(0);
                CreatorTabBook.onTabSelected("Scripted", 0);
            }

            [ConsoleInteraction]
            public void beginGroup(string group)
            {
                this.currentGroup = group;
            }

            [ConsoleInteraction]
            public void endGroup(string group)
            {
                this.currentGroup = "";
            }

            [ConsoleInteraction]
            public string getCreateObjectPosition()
            {
                GameConnection LocalClientConnection = "LocalClientConnection";
                string focusPoint = ((ShapeBase)LocalClientConnection.getControlObject()).getLookAtPoint();
                if (focusPoint == "")
                    return "0 0 0";
                else
                    return Util.getWord(focusPoint, 1) + " " + Util.getWord(focusPoint, 2) + " " +
                           Util.getWord(focusPoint, 3);
            }

            [ConsoleInteraction]
            public void registerMissionObject(string className, string name, string buildfunc, string group)
            {
                if (!Util.isClass(className))
                    return;

                if (name == "")
                    name = className;
                if (this.currentGroup != "" && group == "")
                    group = this.currentGroup;

                if (className == "" || group == "")
                {
                    Util._warn("EWCreatorWindow::registerMissionObject, invalid parameters!");
                    return;
                }

                ObjectCreator argsCreator = new ObjectCreator("ScriptObject");
                argsCreator["val[0]"] = className;
                argsCreator["val[1]"] = name;
                argsCreator["val[2]"] = buildfunc;

                ScriptObject args = argsCreator.Create();

                this.array.push_back(group, args);
            }

            [ConsoleInteraction]
            public string getNewObjectGroup()
            {
                return this.objectGroup;
            }

            [ConsoleInteraction]
            public void setNewObjectGroup(string group)
            {
                EditorTree EditorTree = "EditorTree";

                if (this.objectGroup != 0)
                {
                    int oldItemId = EditorTree.findItemByObjectId(this.objectGroup);
                    if (oldItemId > 0)
                        EditorTree.markItem(oldItemId, false);
                }

                //group = group.getID().AsString();
                if (group != "-1")
                {
                    this.objectGroup = group;
                    int itemId = EditorTree.findItemByObjectId(group.AsInt());
                    EditorTree.markItem(itemId);
                }
            }

            [ConsoleInteraction]
            public string createStatic(string file)
            {
                SimGroup MissionGroup = "MissionGroup";

                if (!bGlobal["$missionRunning"])
                    return "";


                if (!this.objectGroup.isObject())
                    this.setNewObjectGroup(MissionGroup);

                ObjectCreator objectCreator = new ObjectCreator("TSStatic");
                objectCreator["shapeName"] = file;
                objectCreator["position"] = this.getCreateObjectPosition();
                objectCreator["parentGroup"] = this.objectGroup;

                TSStatic objId = objectCreator.Create();

                this.onObjectCreated(objId);
                return objId;
            }

            [ConsoleInteraction]
            public string createPrefab(string file)
            {
                SimGroup MissionGroup = "MissionGroup";

                if (!bGlobal["$missionRunning"])
                    return "";


                if (!this.objectGroup.isObject())
                    this.setNewObjectGroup(MissionGroup);

                ObjectCreator objectCreator = new ObjectCreator("Prefab");
                objectCreator["filename"] = file;
                objectCreator["position"] = this.getCreateObjectPosition();
                objectCreator["parentGroup"] = this.objectGroup;

                Prefab objId = objectCreator.Create();

                this.onObjectCreated(objId);
                return objId;
            }

            [ConsoleInteraction]
            public string createObject(string cmd)
            {
                SimGroup MissionGroup = "MissionGroup";

                if (!bGlobal["$missionRunning"])
                    return "";


                if (!this.objectGroup.isObject())
                    this.setNewObjectGroup(MissionGroup);

                Util.pushInstantGroup();
                SimObject objId = Util.eval(cmd);
                Util.popInstantGroup();

                if (objId.isObject())
                    this.onFinishCreateObject(objId);

                return objId;
            }

            [ConsoleInteraction]
            public void onFinishCreateObject(SimObject objId)
            {
                this.objectGroup.add(objId);

                if (objId.isMemberOfClass("SceneObject"))
                {
                    objId["position"] = this.getCreateObjectPosition();

                    //flush new position
                    objId.call("setTransform", objId.call("getTransform"));
                }

                this.onObjectCreated(objId);
            }

            [ConsoleInteraction]
            public void onObjectCreated(SimObject objId)
            {
                EditorTree EditorTree = "EditorTree";
                EWorldEditor EWorldEditor = "EWorldEditor";

                // Can we submit an undo action?
                if (objId.isObject())
                    Extendable.MECreateUndoAction.submit(objId);

                EditorTree.clearSelection();
                EWorldEditor.clearSelection();
                EWorldEditor.selectObject(objId);

                // When we drop the selection don't store undo
                // state for it... the creation deals with it.
                EWorldEditor.dropSelection(true);
            }

            [ConsoleInteraction]
            public void navigate(string address)
            {
                GuiDynamicCtrlArrayControl CreatorIconArray = "CreatorIconArray";
                CreatorPopupMenu CreatorPopupMenu = "CreatorPopupMenu";

                CreatorIconArray.frozen = true;
                CreatorIconArray.clear();
                CreatorPopupMenu.clear();

                if (this.tab.ToLower() == "Scripted".ToLower())
                {
                    string category = Util.getWord(address, 1);
                    SimSet dataGroup = "DataBlockGroup";

                    for (uint i = 0; i < dataGroup.getCount(); i++)
                    {
                        SimObject obj = dataGroup.getObject(i);
                        // echo ("Obj: " + obj.getName() + " - " + obj.category );

                        if (obj["category"] == "" && obj["category"].AsInt() == 0)
                            continue;

                        // Add category to popup menu if not there already
                        if (CreatorPopupMenu.findText(obj["category"]) == -1)
                            CreatorPopupMenu.add(obj["category"]);

                        if (address == "")
                        {
                            string ctrl = this.findIconCtrl(obj["category"]);
                            if (ctrl == "-1")
                            {
                                this.addFolderIcon(obj["category"]);
                            }
                        }
                        else if (address.ToLower() == obj["category"].ToLower())
                        {
                            string ctrl = this.findIconCtrl(obj.getName());
                            if (ctrl == "-1")
                                this.addShapeIcon(obj);
                        }
                    }
                }

                if (this.tab.ToLower() == "Meshes".ToLower())
                {
                    string fullPath =
                        Util.findFirstFileMultiExpr("*.dts" + '\t' + "*.dae" + '\t' + "*.kmz" + '\t' + "*.dif", true);

                    while (fullPath != "")
                    {
                        if (Util.strstr(fullPath, "cached.dts") != -1)
                        {
                            fullPath =
                                Util.findNextFileMultiExpr("*.dts" + '\t' + "*.dae" + '\t' + "*.kmz" + '\t' + "*.dif");
                            continue;
                        }

                        fullPath = Util.makeRelativePath(fullPath, Util.getMainDotCsDir());
                        string splitPath = Util.strreplace(fullPath, "/", " ");
                        if (Util.getWord(splitPath, 0) == "tools")
                        {
                            fullPath =
                                Util.findNextFileMultiExpr("*.dts" + '\t' + "*.dae" + '\t' + "*.kmz" + '\t' + "*.dif");
                            continue;
                        }

                        int dirCount = Util.getWordCount(splitPath) - 1;

                        string pathFolders = Util.getWords(splitPath, 0, dirCount - 1);

                        // Add this file's path (parent folders) to the
                        // popup menu if it isn't there yet.
                        string temp = Util.strreplace(pathFolders, " ", "/");
                        int re = CreatorPopupMenu.findText(temp);
                        if (re == -1)
                        {
                            CreatorPopupMenu.add(temp);
                        }

                        // Is this file in the current folder?        
                        if (Util.stricmp(pathFolders, address) == 0)
                        {
                            this.addStaticIcon(fullPath);
                        }
                        // Then is this file in a subfolder we need to add
                        // a folder icon for?
                        else
                        {
                            int wordIdx = 0;
                            bool add = false;

                            if (address == "")
                            {
                                add = true;
                                wordIdx = 0;
                            }
                            else
                            {
                                for (; wordIdx < dirCount; wordIdx++)
                                {
                                    temp = Util.getWords(splitPath, 0, wordIdx);
                                    if (Util.stricmp(temp, address) == 0)
                                    {
                                        add = true;
                                        wordIdx++;
                                        break;
                                    }
                                }
                            }

                            if (add == true)
                            {
                                string folder = Util.getWord(splitPath, wordIdx);

                                SimObject ctrl = this.findIconCtrl(folder);
                                if (ctrl == 0)
                                    this.addFolderIcon(folder);
                            }
                        }

                        fullPath = Util.findNextFileMultiExpr("*.dts" + '\t' + "*.dae" + '\t' + "*.kmz" + '\t' + "*.dif");
                    }
                }

                if (this.tab.ToLower() == "Level".ToLower())
                {
                    // Add groups to popup menu
                    array = this.array;
                    array.sortk(false);

                    int count = array.count();

                    if (count > 0)
                    {
                        string lastGroup = "";

                        for (int i = 0; i < count; i++)
                        {
                            string group = array.getKey(i);

                            if (group != lastGroup)
                            {
                                CreatorPopupMenu.add(group);

                                if (address == "")
                                    this.addFolderIcon(group);
                            }

                            if (address.ToLower() == group.ToLower())
                            {
                                ScriptObject args = array.getValue(i);
                                string className = args["val[0]"];
                                string name = args["val[1]"];
                                string func = args["val[2]"];

                                this.addMissionObjectIcon(className, name, func);
                            }

                            lastGroup = group;
                        }
                    }
                }

                if (this.tab.ToLower() == "Prefabs".ToLower())
                {
                    string expr = "*.prefab";
                    string fullPath = Util.findFirstFile(expr);

                    while (fullPath != "")
                    {
                        fullPath = Util.makeRelativePath(fullPath, Util.getMainDotCsDir());
                        string splitPath = Util.strreplace(fullPath, "/", " ");
                        if (Util.getWord(splitPath, 0) == "tools")
                        {
                            fullPath = Util.findNextFile(expr);
                            continue;
                        }

                        int dirCount = Util.getWordCount(splitPath) - 1;

                        string pathFolders = Util.getWords(splitPath, 0, dirCount - 1);

                        // Add this file's path (parent folders) to the
                        // popup menu if it isn't there yet.
                        string temp = Util.strreplace(pathFolders, " ", "/");
                        int re = CreatorPopupMenu.findText(temp);
                        if (re == -1)
                        {
                            CreatorPopupMenu.add(temp);
                        }

                        // Is this file in the current folder?        
                        if (Util.stricmp(pathFolders, address) == 0)
                        {
                            this.addPrefabIcon(fullPath);
                        }
                        // Then is this file in a subfolder we need to add
                        // a folder icon for?
                        else
                        {
                            int wordIdx = 0;
                            bool add = false;

                            if (address == "")
                            {
                                add = true;
                                wordIdx = 0;
                            }
                            else
                            {
                                for (; wordIdx < dirCount; wordIdx++)
                                {
                                    temp = Util.getWords(splitPath, 0, wordIdx);
                                    if (Util.stricmp(temp, address) == 0)
                                    {
                                        add = true;
                                        wordIdx++;
                                        break;
                                    }
                                }
                            }

                            if (add == true)
                            {
                                string folder = Util.getWord(splitPath, wordIdx);

                                SimObject ctrl = this.findIconCtrl(folder);
                                if (ctrl == 0)
                                    this.addFolderIcon(folder);
                            }
                        }

                        fullPath = Util.findNextFile(expr);
                    }
                }

                CreatorIconArray.sort("alphaIconCompare");

                for (uint i = 0; i < CreatorIconArray.getCount(); i++)
                {
                    ((SimObject)CreatorIconArray.getObject(i))["autoSize"] = false.AsString();
                }

                CreatorIconArray.frozen = false;
                CreatorIconArray.refresh();

                // Recalculate the array for the parent guiScrollCtrl
                CreatorIconArray.getParent().call("computeSizes");

                this.address = address;

                CreatorPopupMenu.sort();

                string str = Util.strreplace(address, " ", "/");
                if (str != "")
                {
                    int r = CreatorPopupMenu.findText(str);
                    if (r != -1)
                        CreatorPopupMenu.setSelected(r, false);
                    else
                        CreatorPopupMenu.setText(str);
                }
                else
                {
                    CreatorPopupMenu.setText("");
                }
                CreatorPopupMenu.tooltip = str;
            }

            [ConsoleInteraction]
            public void navigateDown(string folder)
            {
                string address;

                if (this.address == "")
                    address = folder;
                else
                    address = this.address + ' ' + folder;

                // Because this is called from an IconButton::onClick command
                // we have to wait a tick before actually calling navigate, else
                // we would delete the button out from under itself.
                this.schedule("1", "navigate", address);
            }

            [ConsoleInteraction]
            public void navigateUp()
            {
                string address;

                int count = Util.getWordCount(this.address);

                if (count == 0)
                    return;

                if (count == 1)
                    address = "";
                else
                    address = Util.getWords(this.address, 0, count - 2);

                this.navigate(address);
            }

            [ConsoleInteraction]
            public void setListView(bool noupdate)
            {
                GuiDynamicCtrlArrayControl CreatorIconArray = "CreatorIconArray";

                //CreatorIconArray.clear();
                //CreatorIconArray.setVisible( false );

                CreatorIconArray.setVisible(true);
                this.contentCtrl = CreatorIconArray;
                this.isList = true;

                if (noupdate)
                    this.navigate(this.address);
            }

            //function EWCreatorWindow::setIconView( this )
            //{
            //echo( "setIconView" );
            //
            //CreatorIconStack.clear();
            //CreatorIconStack.setVisible( false );
            //
            //CreatorIconArray.setVisible( true );
            //this.contentCtrl = CreatorIconArray;
            //this.isList = false;
            //
            //this.navigate( this.address );
            //}

            [ConsoleInteraction]
            public string findIconCtrl(string name)
            {
                for (uint i = 0; i < this.contentCtrl.getCount(); i++)
                {
                    SimObject ctrl = this.contentCtrl.getObject(i);
                    if (ctrl["text"] == name)
                        return ctrl;
                }

                return "-1";
            }

            [ConsoleInteraction]
            public string createIcon()
            {
                ObjectCreator ctrlCreator = new ObjectCreator("GuiIconButtonCtrl");
                ctrlCreator["profile"] = "GuiCreatorIconButtonProfile";
                ctrlCreator["buttonType"] = "RadioButton";
                ctrlCreator["groupNum"] = "-1";

                GuiIconButtonCtrl ctrl = ctrlCreator.Create();
                ctrl["profile"] = "GuiCreatorIconButtonProfile";

                if (this.isList)
                {
                    ctrl.iconLocation = "Left";
                    ctrl.textLocation = "Right";
                    ctrl.extent = "348 19".AsPoint2I();
                    ctrl.textMargin = 8;
                    ctrl.buttonMargin = "2 2".AsPoint2I();
                    ctrl.autoSize = true;
                }
                else
                {
                    ctrl.iconLocation = "Center";
                    ctrl.textLocation = "Bottom";
                    ctrl.extent = "40 40".AsPoint2I();
                }

                return ctrl;
            }

            [ConsoleInteraction]
            public void addFolderIcon(string text)
            {
                GuiIconButtonCtrl ctrl = this.createIcon();

                ctrl.altCommand = "EWCreatorWindow.navigateDown(\"" + text + "\");";
                ctrl.iconBitmap = "tools/gui/images/folder.png";
                ctrl.text = text;
                ctrl.tooltip = text;
                ctrl["class"] = "CreatorFolderIconBtn";

                ctrl.buttonType = "RadioButton";
                ctrl.groupNum = -1;

                this.contentCtrl.addGuiControl(ctrl);
            }

            [ConsoleInteraction]
            public void addMissionObjectIcon(string className, string name, string buildfunc)
            {
                objectBuilderGui ObjectBuilderGui = "ObjectBuilderGui";
                GuiIconButtonCtrl ctrl = this.createIcon();


                // If we don't find a specific function for building an
                // object then fall back to the stock one
                string method = "build" + buildfunc;
                if (!ObjectBuilderGui.isMethod(method))
                    method = "build" + className;

                string cmd;

                if (!ObjectBuilderGui.isMethod(method))
                    cmd = "return new " + className + "();";
                else
                    cmd = "ObjectBuilderGui." + method + "();";

                ctrl.altCommand =
                    "ObjectBuilderGui.newObjectCallback = \"EWCreatorWindow.onFinishCreateObject\"; EWCreatorWindow.createObject( \"" +
                    cmd + "\" );";
                ctrl.iconBitmap = console.Call_Classname("EditorIconRegistry", "findIconByClassName",
                    new string[] { className });
                ctrl.text = name;
                ctrl["class"] = "CreatorMissionObjectIconBtn";
                ctrl.tooltip = className;

                ctrl.buttonType = "RadioButton";
                ctrl.groupNum = -1;

                this.contentCtrl.addGuiControl(ctrl);
            }

            [ConsoleInteraction]
            public void addShapeIcon(SimObject datablock)
            {
                GuiIconButtonCtrl ctrl = this.createIcon();

                string name = datablock.getName();
                string className = datablock.getClassName();
                string cmd = className + "::create(" + name + ");";

                string shapePath = (datablock["shapeFile"] != "") ? datablock["shapeFile"] : datablock["shapeName"];

                string createCmd = "EWCreatorWindow.createObject( \\\"" + cmd + "\\\" );";
                ctrl.altCommand = "ColladaImportDlg.showDialog( \"" + shapePath + "\", \"" + createCmd + "\" );";

                ctrl.iconBitmap = console.Call_Classname("EditorIconRegistry", "findIconByClassName",
                    new string[] { className });
                ctrl.text = name;
                //ctrl["class"] = "CreatorShapeIconBtn";
                ctrl.tooltip = name;

                ctrl.buttonType = "RadioButton";
                ctrl.groupNum = -1;

                this.contentCtrl.addGuiControl(ctrl);
            }

            [ConsoleInteraction]
            public void addStaticIcon(string fullPath)
            {
                GuiIconButtonCtrl ctrl = this.createIcon();

                string ext = Util.fileExt(fullPath);
                string file = Util.fileBase(fullPath);
                string fileLong = file + ext;
                string tip = fileLong + '\n' +
                             "Size: " + Util.fileSize(fullPath) / 1000.0 + ' ' + "KB" + '\n' +
                             "Date Created: " + Util.fileCreatedTime(fullPath) + '\n' +
                             "Last Modified: " + Util.fileModifiedTime(fullPath);

                string createCmd = "EWCreatorWindow.createStatic( \\\"" + fullPath + "\\\" );";
                ctrl.altCommand = "ColladaImportDlg.showDialog( \"" + fullPath + "\", \"" + createCmd + "\" );";

                ctrl.iconBitmap = ((ext == ".dts")
                    ? console.Call_Classname("EditorIconRegistry", "findIconByClassName", new string[] { "TSStatic" })
                    : "tools/gui/images/iconCollada");
                ctrl.text = file;
                ctrl["class"] = "CreatorStaticIconBtn";
                ctrl.tooltip = tip;

                ctrl.buttonType = "RadioButton";
                ctrl.groupNum = -1;

                this.contentCtrl.addGuiControl(ctrl);
            }

            [ConsoleInteraction]
            public void addPrefabIcon(string fullPath)
            {
                GuiIconButtonCtrl ctrl = this.createIcon();

                string ext = Util.fileExt(fullPath);
                string file = Util.fileBase(fullPath);
                string fileLong = file + ext;
                string tip = fileLong + '\n' +
                             "Size: " + Util.fileSize(fullPath) / 1000.0 + ' ' + "KB" + '\n' +
                             "Date Created: " + Util.fileCreatedTime(fullPath) + '\n' +
                             "Last Modified: " + Util.fileModifiedTime(fullPath);

                ctrl.altCommand = "EWCreatorWindow.createPrefab( \"" + fullPath + "\" );";
                ctrl.iconBitmap = console.Call_Classname("EditorIconRegistry", "findIconByClassName",
                    new string[] { "Prefab" });
                ctrl.text = file;
                ctrl["class"] = "CreatorPrefabIconBtn";
                ctrl.tooltip = tip;

                ctrl.buttonType = "RadioButton";
                ctrl.groupNum = -1;

                this.contentCtrl.addGuiControl(ctrl);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWCreatorWindow ts, string simobjectid)
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
                return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EWCreatorWindow ts, string simobjectid)
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
            public static implicit operator string(EWCreatorWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWCreatorWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EWCreatorWindow)Omni.self.getSimObject(simobjectid, typeof(EWCreatorWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWCreatorWindow ts)
            {
                return (int)ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWCreatorWindow(int simobjectid)
            {
                return (EWCreatorWindow)Omni.self.getSimObject((uint)simobjectid, typeof(EWCreatorWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWCreatorWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWCreatorWindow(uint simobjectid)
            {
                return (EWCreatorWindow)Omni.self.getSimObject(simobjectid, typeof(EWCreatorWindow));
            }

            #endregion
        }
    }
}