using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using Creator = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.Creator;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    [TypeConverter(typeof(TypeConverterGeneric<objectBuilderGui>))]
    public class objectBuilderGui : GuiControl
        {


        private string objectClassName
            {
            get { return this["objectClassName"]; }
            set { this["objectClassName"] = value; }
            }

        private string createCallback
            {
            get { return this["createCallback"]; }
            set { this["createCallback"] = value; }
            }

        private GuiTextEditCtrl OBObjectName
            {
            get { return "OBObjectName"; }
            }

        private int defaultFieldStep
            {
            get { return this["defaultFieldStep"].AsInt(); }
            set { this["defaultFieldStep"] = value.AsString(); }
            }

        private int columnOffset
            {
            get { return this["columnOffset"].AsInt(); }
            set { this["columnOffset"] = value.AsString(); }
            }

        private int curXPos
            {
            get { return this["curXPos"].AsInt(); }
            set { this["curXPos"] = value.AsString(); }
            }

        private int curYPos
            {
            get { return this["curYPos"].AsInt(); }
            set { this["curYPos"] = value.AsString(); }
            }

        public GuiBitmapBorderCtrl OBContentWindow
            {
            get { return "OBContentWindow"; }
            }

        private int numControls
            {
            get { return this["numControls"].AsInt(); }
            set { this["numControls"] = value.AsString(); }
            }

        private int numFields
            {
            get { return this["numFields"].AsInt(); }
            set { this["numFields"] = value.AsString(); }
            }

        [ConsoleInteraction(true, "objectBuilderGui_initialize")]
        public static void initialize()
            {
            #region GuiControl (ObjectBuilderGui, EditorGuiGroup)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "ObjectBuilderGui, EditorGuiGroup",
                typeof(objectBuilderGui));
            oc_Newobject7["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["extent"] = "800 600";
            oc_Newobject7["minExtent"] = "8 8";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["setFirstResponder"] = "0";
            oc_Newobject7["modal"] = "1";
            oc_Newobject7["helpTag"] = "0";

            #region GuiWindowCtrl (OBTargetWindow)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiWindowCtrl", "OBTargetWindow");
            oc_Newobject6["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject6["horizSizing"] = "center";
            oc_Newobject6["vertSizing"] = "center";
            oc_Newobject6["position"] = "384 205";
            oc_Newobject6["extent"] = "256 282";
            oc_Newobject6["minExtent"] = "256 8";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["setFirstResponder"] = "0";
            oc_Newobject6["modal"] = "1";
            oc_Newobject6["helpTag"] = "0";
            oc_Newobject6["resizeWidth"] = "1";
            oc_Newobject6["resizeHeight"] = "1";
            oc_Newobject6["canMove"] = "1";
            oc_Newobject6["canClose"] = "0";
            oc_Newobject6["canMinimize"] = "0";
            oc_Newobject6["canMaximize"] = "0";
            oc_Newobject6["minSize"] = "50 50";
            oc_Newobject6["text"] = "Create Object";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "GuiCenterTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "9 26";
            oc_Newobject1["extent"] = "84 16";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["setFirstResponder"] = "0";
            oc_Newobject1["modal"] = "1";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["text"] = "Object Name:";

            #endregion

            oc_Newobject6["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl (OBObjectName)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "OBObjectName");
            oc_Newobject2["class"] = new ObjectCreator.StringNoQuote("ObjectBuilderGuiTextEditCtrl");
            oc_Newobject2["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["horizSizing"] = "width";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "78 26";
            oc_Newobject2["extent"] = "172 18";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["setFirstResponder"] = "0";
            oc_Newobject2["modal"] = "1";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["historySize"] = "0";

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapBorderCtrl (OBContentWindow)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapBorderCtrl", "OBContentWindow");
            oc_Newobject3["profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject3["horizSizing"] = "width";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "7 51";
            oc_Newobject3["extent"] = "243 193";
            oc_Newobject3["minExtent"] = "0 0";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["setFirstResponder"] = "0";
            oc_Newobject3["modal"] = "1";
            oc_Newobject3["helpTag"] = "0";

            #endregion

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiButtonCtrl (OBOKButton)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiButtonCtrl", "OBOKButton");
            oc_Newobject4["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["horizSizing"] = "width";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "7 250";
            oc_Newobject4["extent"] = "156 24";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["setFirstResponder"] = "0";
            oc_Newobject4["modal"] = "1";
            oc_Newobject4["command"] = "ObjectBuilderGui.onOK();";
            oc_Newobject4["helpTag"] = "0";
            oc_Newobject4["text"] = "Create New";
            oc_Newobject4["Accelerator"] = "return";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiButtonCtrl (OBCancelButton)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiButtonCtrl", "OBCancelButton");
            oc_Newobject5["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["horizSizing"] = "left";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "170 250";
            oc_Newobject5["extent"] = "80 24";
            oc_Newobject5["minExtent"] = "8 8";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["setFirstResponder"] = "0";
            oc_Newobject5["modal"] = "1";
            oc_Newobject5["command"] = "ObjectBuilderGui.onCancel();";
            oc_Newobject5["helpTag"] = "0";
            oc_Newobject5["text"] = "Cancel";
            oc_Newobject5["Accelerator"] = "escape";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject7.Create();

            GenerateScriptObjectCreators();
            }


        public static void GenerateScriptObjectCreators()
            {
            const string toeval = @"

function PhysicsEntityData::create(%data)
{
   %obj = new PhysicsEntity() {
      dataBlock = %data;
      parentGroup = EWCreatorWindow.objectGroup;
   };
   return %obj;
}

function StaticShapeData::create(%data)
{
   %obj = new StaticShape() {
      dataBlock = %data;
      parentGroup = EWCreatorWindow.objectGroup;
   };
   return %obj;
}

function MissionMarkerData::create(%block)
{
   switch$(%block)
   {
      case ""WayPointMarker"":
         %obj = new WayPoint() {
            dataBlock = %block;
            parentGroup = EWCreatorWindow.objectGroup;
         };
         return(%obj);
      case ""SpawnSphereMarker"":
         %obj = new SpawnSphere() {
            datablock = %block;
            parentGroup = EWCreatorWindow.objectGroup;
         };
         return(%obj);
   }

   return(-1);
}

function ItemData::create(%data)
{
   %obj = new Item()
   {
      dataBlock = %data;
      parentGroup = EWCreatorWindow.objectGroup;
      static = true;
      rotate = true;
   };
   return %obj;
}

function TurretShapeData::create(%block)
{
   %obj = new TurretShape() {
      dataBlock = %block;
      static = true;
      respawn = true;
      parentGroup = EWCreatorWindow.objectGroup;
   };
   return %obj;
}

function AITurretShapeData::create(%block)
{
   %obj = new AITurretShape() {
      dataBlock = %block;
      static = true;
      respawn = true;
      parentGroup = EWCreatorWindow.objectGroup;
   };
   return %obj;
}

function WheeledVehicleData::create(%block)
{
   %obj = new WheeledVehicle() {
      dataBlock = %block;
      parentGroup = EWCreatorWindow.objectGroup;
   };
   return %obj;
}

function FlyingVehicleData::create(%block)
{
   %obj = new FlyingVehicle()
   {
      dataBlock = %block;
      parentGroup = EWCreatorWindow.objectGroup;
   };
   return(%obj);
}

function HoverVehicleData::create(%block)
{
   %obj = new HoverVehicle()
   {
      dataBlock = %block;
      parentGroup = EWCreatorWindow.objectGroup;
   };
   return(%obj);
}

function RigidShapeData::create(%data)
{
   %obj = new RigidShape() {
      dataBlock = %data;
      parentGroup = EWCreatorWindow.objectGroup;
   };
   return %obj;
}

function PhysicsShapeData::create( %datablock )
{
   %obj = new PhysicsShape()
   {
		dataBlock = %datablock;
		parentGroup = EWCreatorWindow.objectGroup;
		
      invulnerable = false;
      damageRadius = 0;
      areaImpulse = 0;
      radiusDamage = 0;
      minDamageAmount = 0;         
   };

   return %obj;
}

function ProximityMineData::create( %datablock )
{
   %obj = new ProximityMine()
   {
      dataBlock = %dataBlock;
      parentGroup = EWCreatorWindow.objectGroup;
      static = true;    // mines created by the editor are static, and armed immediately
   };

   return %obj;
}
";

            omni.Util.eval(toeval);
            }


        [ConsoleInteraction]
        public void init()
            {
            this["baseOffsetX"] = "5";
            this["baseOffsetY"] = "5";
            this["defaultObjectName"] = "";
            defaultFieldStep = 22;
            columnOffset = 110;

            this["fieldNameExtent"] = "105 18";
            this["textEditExtent"] = "122 18";
            this["checkBoxExtent"] = "13 18";
            this["popupMenuExtent"] = "122 18";
            this["fileButtonExtent"] = "122 18";
            this["matButtonExtent"] = "17 18";
            this["numControls"] = "0";

            this["lastPath"] = "";

            reset();
            }

        [ConsoleInteraction]
        public void reset()
            {
            this["objectGroup"] = "";
            this["curXPos"] = this["baseOffsetX"];
            this["curYPos"] = this["baseOffsetY"];
            this["createFunction"] = "";
            this["createCallback"] = "";
            this["currentControl"] = "0";
            GuiTextEditCtrl OBObjectName = "OBObjectName";
            OBObjectName.setValue(this["defaultObjectName"]);
            this["newObject"] = "0";
            this["objectClassName"] = "";
            numFields = 0;

            for (int i = 0; i < numControls; i++)
                {
                this["textControls[" + i + "]"].delete();
                this["controls[" + i + "]"].delete();
                }
            numControls = 0;
            }


        [ConsoleInteraction]
        public void createFileType(int index)
            {
            if (index >= numFields || this["field[" + index + ", name]"] == "")
                {
                Util._error("ObjectBuilderGui::createFileType: invalid field");
                return;
                }

            string nname = this["field[" + index + ",text]"] == ""
                ? this["field[" + index + ",name]"]
                : this["field[" + index + ",text]"];


            ObjectCreator oc = new ObjectCreator("GuiTextCtrl");
            oc["profile"] = "ToolsGuiTextRightProfile";
            oc["text"] = nname;
            oc["extent"] = this["fieldNameExtent"];
            oc["position"] = curXPos + " " + curYPos;
            oc["modal"] = "1";


            this["textControls[" + numControls + "]"] = oc.Create().AsString();


            oc = new ObjectCreator("GuiButtonCtrl");
            oc["HorizSizing"] = "width";
            oc["profile"] = "ToolsGuiButtonProfile";
            oc["extent"] = this["fileButtonExtent"];
            oc["position"] = (curXPos + columnOffset) + " " + curYPos;
            oc["modal"] = "1";
            oc["command"] = this + ".getFileName(" + index + ");";

            this["controls[" + numControls + "]"] = oc.Create().AsString();

            this["field[" + index + ",button]"] = this["controls[" + numControls + "]"];

            numControls++;

            string val = this["field[" + index + "," + this["value"] + "]"];

            ((GuiButtonCtrl)this["controls[" + numControls + "]"]).setValue(Util.fileBase(val) + Util.fileExt(val));



            curYPos += defaultFieldStep;
            }

        [ConsoleInteraction]
        public void getFileName(int index)
            {
            if (index >= numFields || this["field[" + index + ",name]"] == "")
                {
                Util._error("ObjectBuilderGui::getFileName: invalid field");
                return;
                }

            string val = this["field[" + index + ",ext]"];

            this["currentControl"] = index.AsString();

            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.OpenFileDialog.getLoadFilename(val + "|" + val, this.getName() + ".gotFileName", this["lastPath"]);
            }

        [ConsoleInteraction]
        public void gotFileName(string name)
            {
            int index = this["currentControl"].AsInt();

            name = Util.makeRelativePath(name, Util.getWorkingDirectory());

            this["field[" + index + ",value]"] = name;

            ((GuiButtonCtrl)this["field[" + index + ",button]"]).setText(Util.fileBase(name) +
                                                                              Util.fileExt(name));

            this["lastPath"] = name;

            // This doesn't work for button controls as getValue returns their state!
            //%this.controls[%this.currentControl].setValue(%name);
            }

        [ConsoleInteraction]
        public void createMaterialNameType(int index)
            {
            if (index >= numFields || this["field[" + index + ",name]"] == "")
                {
                Util._error("ObjectBuilderGui::createMaterialNameType: invalid field");
                return;
                }

            string nname = this["field[" + index + ",text]"] == ""
                ? this["field[" + index + ",name]"]
                : this["field[" + index + ",text]"];

            ObjectCreator oc = new ObjectCreator("GuiTextCtrl");
            oc["profile"] = "ToolsGuiTextRightProfile";
            oc["text"] = nname;
            oc["extent"] = this["fieldNameExtent"];
            oc["position"] = curXPos + " " + curYPos;
            oc["modal"] = "1";


            this["textControls[" + numControls + "]"] = oc.Create().AsString();

            oc = new ObjectCreator("GuiControl");
            oc["HorizSizing"] = "width";
            oc["profile"] = "ToolsGuiDefaultProfile";
            oc["extent"] = this["textEditExtent"];
            oc["position"] = (curXPos + columnOffset) + " " + curYPos;
            oc["modal"] = "1";

            this["controls[" + numControls + "]"] = oc.Create().AsString();

            oc = new ObjectCreator("GuiTextEditCtrl");
            oc["class"] = "ObjectBuilderGuiTextEditCtrl";
            oc["internalName"] = "MatText";
            oc["HorizSizing"] = "width";
            oc["profile"] = "ToolsGuiTextEditProfile";
            oc["extent"] = (Util.getWord(this["textEditExtent"], 0).AsInt() -
                            Util.getWord(this["matButtonExtent"], 0).AsInt() - 2) + " " +
                           Util.getWord(this["textEditExtent"], 1);
            oc["text"] = new ObjectCreator.StringNoQuote(this["field[" + index + ",value]"]);
            oc["position"] = "0 0";
            oc["modal"] = "1";

            string text = oc.Create().AsString();

            this["controls[" + numControls + "]"].call("addGuiControl", new string[] { text });

            oc = new ObjectCreator("GuiBitmapButtonCtrl");
            oc["internalName"] = "MatButton";
            oc["HorizSizing"] = "left";
            oc["profile"] = "ToolsGuiButtonProfile";
            oc["extent"] = this["matButtonExtent"];
            oc["position"] = (Util.getWord(this["textEditExtent"], 0).AsInt() -
                              Util.getWord(this["matButtonExtent"], 0).AsInt()) + " 0";
            oc["modal"] = "1";
            oc["command"] = (this + ".getMaterialName(" + index + ");");

            GuiBitmapButtonCtrl button = oc.Create().AsString();

            button.setBitmap("tools/materialEditor/gui/change-material-btn");

            this["controls[" + numControls + "]"].call("addGuiControl", new string[] { button });

            numControls += 1;

            curYPos += defaultFieldStep;
            }

        [ConsoleInteraction]
        public void getMaterialName(int index)
            {
            if (index >= numFields || this["field[" + index + ",name]"] == "")
                {
                Util._error("ObjectBuilderGui::getMaterialName: invalid field");
                return;
                }

            this["currentControl"] = index.AsString();

            "materialSelector".call("showDialog", new[] { this + ".gotMaterialName", name });
            }

        [ConsoleInteraction]
        public void gotMaterialName(SimObject name)
            {
            int index = this["currentControl"].AsInt();

            this["field[" + index + ",value]"] = name.getName();

            ((GuiControl)this["controls[" + index + "]"]).findObjectByInternalName("MatText", true)
                .call("setText", new string[] { name.getName() });
            }

        [ConsoleInteraction]
        public void createDataBlockType(int index)
            {
            if (index >= numFields || this["field[" + index + ",name]"] == "")
                {
                Util._error("ObjectBuilderGui::createDataBlockType: invalid field");
                return;
                }

            string nname = this["field[" + index + ",text]"] == ""
                ? this["field[" + index + ",name]"]
                : this["field[" + index + ",text]"];

            ObjectCreator oc = new ObjectCreator("GuiTextCtrl");
            oc["profile"] = "ToolsGuiTextRightProfile";
            oc["text"] = nname;
            oc["extent"] = this["fieldNameExtent"];
            oc["position"] = curXPos + " " + curYPos;
            oc["modal"] = "1";

            this["textControls[" + numControls + "]"] = oc.Create().AsString();


            oc = new ObjectCreator("GuiPopupMenuCtrl");
            oc["HorizSizing"] = "width";
            oc["profile"] = "ToolsGuiPopUpMenuProfile";
            oc["extent"] = this["popupMenuExtent"];
            oc["position"] = (curXPos + columnOffset) + " " + curYPos;
            oc["modal"] = "1";
            oc["maxPopupHeight"] = "200";

            this["controls[" + numControls + "]"] = oc.Create().AsString();


            string classname = Util.getWord(this["field[" + index + ",value]"], 0);
            string classname_alt = Util.getWord(this["field[" + index + ",value]"], 1);

            this["controls[" + numControls + "]"].call("add", new string[] { "", "-1" });

            SimGroup DataBlockGroup = "DataBlockGroup";

            for (uint i = 0; i < DataBlockGroup.getCount(); i++)
                {
                SimDataBlock obj = DataBlockGroup.getObject(i);
                if (Util.isMemberOfClass(obj.getClassName(), classname) ||
                    Util.isMemberOfClass(obj.getClassName(), classname_alt))
                    this["controls[" + numControls + "]"].call("add", new string[] { obj.getName(), i.AsString() });
                }


            this["controls[" + numControls + "]"].call("setValue",
                new string[] { Util.getWord(this["field[" + index + ",value]"], 1) });

            numControls += 1;

            curYPos += defaultFieldStep;
            }

        [ConsoleInteraction]
        public void createBoolType(int index)
            {
            if (index >= numFields || this["field[" + index + ",name]"] == "")
                {
                Util._error("ObjectBuilderGui::createBoolType: invalid field");
                return;
                }

            string value = "0";
            if (this["field[" + index + ",value]"] == "")
                value = "0";
            else
                value = this["field[" + index + ",value]"];

            string nname = this["field[" + index + ",text]"] == ""
                ? this["field[" + index + ",name]"]
                : this["field[" + index + ",text]"];

            ObjectCreator oc = new ObjectCreator("GuiTextCtrl");
            oc["profile"] = "ToolsGuiTextRightProfile";
            oc["text"] = nname;
            oc["extent"] = this["fieldNameExtent"];
            oc["position"] = curXPos + " " + curYPos;
            oc["modal"] = "1";

            this["textControls[" + numControls + "]"] = oc.Create().AsString();

            oc = new ObjectCreator("GuiCheckBoxCtrl");
            oc["profile"] = "ToolsGuiCheckBoxProfile";
            oc["extent"] = this["checkBoxExtent"];
            oc["position"] = (curXPos + columnOffset) + " " + curYPos;
            oc["modal"] = "1";

            this["controls[" + numControls + "]"].call("setValue", new string[] { value });
            numControls += 1;

            curYPos += defaultFieldStep;
            }

        public override void onGainFirstResponder(string ID)
            {
            this.call("selectAllText");
            }

        //this["columnOffset"]

        [ConsoleInteraction]
        public void createStringType(int index)
            {
            if (index >= numFields || this["field[" + index + ",name]"] == "")
                {
                Util._error("ObjectBuilderGui::createBoolType: invalid field");
                return;
                }
            string nname = this["field[" + index + ",text]"] == ""
                ? this["field[" + index + ",name]"]
                : this["field[" + index + ",text]"];

            ObjectCreator oc = new ObjectCreator("GuiTextCtrl");
            oc["profile"] = "ToolsGuiTextRightProfile";
            oc["text"] = nname;
            oc["extent"] = this["fieldNameExtent"];
            oc["position"] = curXPos + " " + curYPos;
            oc["modal"] = "1";

            this["textControls[" + numControls + "]"] = oc.Create().AsString();

            oc = new ObjectCreator("GuiTextEditCtrl");
            oc["class"] = "ObjectBuilderGuiTextEditCtrl";
            oc["HorizSizing"] = "width";
            oc["profile"] = "ToolsGuiTextEditProfile";
            oc["extent"] = this["textEditExtent"];
            oc["text"] = this["field[" + index + ",value]"];
            oc["position"] = (curXPos + columnOffset) + " " + curYPos;
            oc["modal"] = "1";

            this["controls[" + numControls + "]"] = oc.Create().AsString();
            numControls += 1;

            curYPos += defaultFieldStep;
            }

        [ConsoleInteraction]
        public void adjustSizes()
            {
            if (numControls == 0)
                curYPos = 0;

            GuiWindowCtrl OBTargetWindow = "OBTargetWindow";
            GuiBitmapBorderCtrl OBContentWindow = "OBContentWindow";
            GuiButtonCtrl OBOKButton = "OBOKButton";
            GuiButtonCtrl OBCancelButton = "OBCancelButton";

            OBTargetWindow.extent = new Point2I(OBTargetWindow.extent.x + " " + (curYPos + 88));
            OBContentWindow.extent = new Point2I(OBContentWindow.extent.x + " " + curYPos);
            OBOKButton.position = new Point2I(OBOKButton.position.x + " " + (curYPos + 57));
            OBCancelButton.position = new Point2I(OBCancelButton.position.x + " " + (curYPos + 57));
            }

        [ConsoleInteraction]
        public void process()
            {
            if (this["objectClassName"] == "")
                {
                Util._error("ObjectBuilderGui::process: classname is not specified");
                return;
                }
            GuiWindowCtrl OBTargetWindow = "OBTargetWindow";

            OBTargetWindow.text = "Create Object: " + this["objectClassName"];

            for (int i = 0; i < numFields; i++)
                {
                switch (this["field[" + i + ",type]"])
                    {
                    case "TypeBool":
                        this.createBoolType(i);
                        break;
                    case "TypeDataBlock":
                        this.createDataBlockType(i);
                        break;
                    case "TypeFile":
                        createFileType(i);
                        break;
                    case "TypeMaterialName":
                        createMaterialNameType(i);
                        break;

                    default:
                        createStringType(i);
                        break;
                    }
                }

            for (int i = 0; i < numControls; i++)
                {
                OBContentWindow.add(this["textControls[" + i + "]"]);
                OBContentWindow.add(this["Controls[" + i + "]"]);
                }

            adjustSizes();

            ((GuiCanvas)"canvas").pushDialog(this);
            }

        [ConsoleInteraction]
        public void processNewObject(string obj)
            {
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";
            if (this["createCallback"] != "")
                Util.eval(this["createCallback"]);

            // Skip out if nothing was created.   

            if (!obj.isObject())
                return;

            // Add the object to the group.

            if (this["objectGroup"] != "")
                ((SimGroup)this["objectGroup"]).add(obj);
            else
                EWCreatorWindow.objectGroup.add(obj);

            // If we were given a callback to call after the
            // object has been created, do so now.  Also clear
            // the callback to make sure it's valid only for
            // a single invocation.

            string callback = this["newObjectCallback"];
            this["newObjectCallback"] = "";

            if (callback != "")
                Util.eval(callback + "(" + obj + ");");
            }


        [ConsoleInteraction]
        public void onOk()
            {
            editor Editor = "Editor";
            // Error out if the given object name is not valid or not unique.
            string objectName = OBObjectName.getValue();

            if (!Editor.validateObjectName(objectName, false))
                return;

            // get current values
            for (int i = 0; i < numControls; i++)
                {
                // uses button type where getValue returns button state!
                if (this["field[" + i + ",type]"] == "TypeFile")
                    {
                    if (Util.strchr(this["field[" + i + ",value]"], "*") != "")
                        this["field[" + i + ",value]"] = "";
                    continue;
                    }

                if (this["field[" + i + ",type]"] == "TypeMaterialName")
                    {
                    this["field[" + i + ",value]"] =
                        ((GuiControl)
                            ((GuiControl)this["controls[" + i + "]"]).findObjectByInternalName("MatText", true))
                            .getValue();
                    continue;
                    }
                this["field[" + i + ",value]"] = ((GuiControl)this["controls[" + i + "]"]).getValue();
                }
            // If we have a special creation function then
            // let it do the construction.

            if (this["createFunction"] != "")
                Util.eval(this["createFunction"]);
            else
                {
                // Else we use the memento.
                string momento = buildMemento();
                Util.eval(momento);
                }
            if (this["newObject"].AsInt() != 0)
                this.processNewObject(this["newObject"]);

            reset();

            ((GuiCanvas)"Canvas").popDialog(this);
            }

        [ConsoleInteraction]
        public void onCancel()
            {
            reset();
            ((GuiCanvas)"Canvas").popDialog(this);
            }

        [ConsoleInteraction]
        public void addField(string name, string type, string text, string value, string ext = "")
            {
            this["field[" + numFields + ",name]"] = name;
            this["field[" + numFields + ",type]"] = type;
            this["field[" + numFields + ",text]"] = text;
            this["field[" + numFields + ",value]"] = value;
            this["field[" + numFields + ",ext]"] = ext;

            numFields++;
            }

        [ConsoleInteraction]
        public string buildMemento()
            {
            this["memento"] = this + ".newObject = new " + this["objectClassName"] + "(" + OBObjectName.getValue() +
                              ") {";
            for (int i = 0; i < numFields; i++)
                {
                this["memento"] = this["memento"] + this["field[" + i + ",name]"] + " = \"" +
                                  this["field[" + i + ",value]"] + "\"; ";
                }
            this["memento"] = this["memento"] + "};";
            return this["memento"];
            }

        //------------------------------------------------------------------------------
        // This function is used for objects that don't require any special
        // fields/functionality when being built
        //------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void buildObject(string className)
            {
            this["objectClassName"] = className;
            process();
            }

        //------------------------------------------------------------------------------
        // Environment
        //------------------------------------------------------------------------------

        // fxFoliageReplicator

        [ConsoleInteraction]
        public void buildVolumetricFog()
            {
            OBObjectName.setValue("");
            this.objectClassName = "VolumetricFog";
            this.addField("shapeName", "TypeFile", "Shape (Fog Volume)", "", "(Models) |*.dts;*.dae");
            this.addField("Scale", "TypePoint3", "Scale", "1 1 1");
            this.addField("FogColor", "TypeColorI", "FogColor", "200 200 200 128");
            this.process();
            }

        [ConsoleInteraction]
        public void buildfxFoliageReplicator()
            {
            this["objectClassName"] = "fxFoliageReplicator";
            process();
            }

        // fxShapeReplicator

        [ConsoleInteraction]
        public void buildfxShapeReplicator()
            {
            this["objectClassName"] = "fxShapeReplicator";
            process();
            }

        //WALKABLESHAPE
        [ConsoleInteraction]
        public void buildTSAttachable()
            {
            OBObjectName.setValue("");
            this.objectClassName = "TSAttachable";
            this.addField("shapeName", "TypeFile", "Shape File", "", "(Models) |*.dts;*.dae");
            this.process();
            }
        [ConsoleInteraction]
        public void buildTSPathShape()
            {
            OBObjectName.setValue("");
            this.objectClassName = "TSPathShape";
            this.addField("shapeName", "TypeFile", "Shape File", "", "(Models) |*.dts;*.dae");
            this.process();
            }
        //WALKABLESHAPE

        [ConsoleInteraction]
        public void buildScatterSky(bool dontWarnAboutSun)
            {
            if (!dontWarnAboutSun)
                {
                // Check for sun object already in the level.  If there is one,
                // warn the user.	
                Util.initContainerTypeSearch((uint)SceneObjectTypesAsUint.EnvironmentObjectType, false);
                while (true)
                    {
                    SimObject obj = Util.containerSearchNext(false);
                    if (!obj.isObject())
                        break;

                    if (obj.isMemberOfClass("Sun"))
                        {
                        messageBox.MessageBoxYesNo("Warning",
                            "A ScatterSky object will conflict with the Sun object that is already in the level.  Do you still want to create a ScatterSky object?",
                            this + ".buildScatterSky(true);", "");
                        return;
                        }
                    }
                }
            this["objectClassName"] = "ScatterSky";

            this.addField("rayleighScattering", "TypeFloat", "Rayleigh Scattering", "0.0035");
            this.addField("mieScattering", "TypeFloat", "Mie Scattering", "0.0045");
            this.addField("skyBrightness", "TypeFloat", "Sky Brightness", "25");

            this.process();

            // This is a trick... any fields added after process won't show
            // up as controls, but will be applied to the created object.
            this.addField("flareType", "TypeLightFlareDataPtr", "Flare", "ScatterSkyFlareExample");
            this.addField("moonMat", "TypeMaterialName", "Moon Material", "Moon_Glow_Mat");
            this.addField("nightCubemap", "TypeCubemapName", "Night Cubemap", "NightCubemap");
            this.addField("useNightCubemap", "TypeBool", "Use Night Cubemap", "true");
            }

        [ConsoleInteraction]
        public void buildCloudLayer()
            {
            OBObjectName.setValue("");
            this["objectClassName"] = "CloudLayer";
            this.addField("texture", "TypeImageFilename", "Texture", "art/skies/clouds/clouds_normal_displacement");
            this.process();
            }

        [ConsoleInteraction]
        public void buildBasicClouds()
            {
            OBObjectName.setValue("");
            this["objectClassName"] = "BasicClouds";
            this.process();

            // This is a trick... any fields added after process won't show
            // up as controls, but will be applied to the created object.
            this.addField("texture[0]", "TypeImageFilename", "Texture", "art/skies/clouds/cloud1");
            this.addField("texture[1]", "TypeImageFilename", "Texture", "art/skies/clouds/cloud2");
            this.addField("texture[2]", "TypeImageFilename", "Texture", "art/skies/clouds/cloud3");
            }

        [ConsoleInteraction]
        public bool checkExists(string classname)
            {
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";

            SimGroup grp = EWCreatorWindow.objectGroup;
            for (uint i = 0; i < grp.getCount(); i++)
                {
                SimObject obj = grp.getObject(i);
                if (obj.getClassName() == classname)
                    return true;
                }
            return false;
            }

        [ConsoleInteraction]
        public void buildsgMissionLightingFilter()
            {
            this.objectClassName = "sgMissionLightingFilter";
            this.addField("dataBlock", "TypeDataBlock", "sgMissionLightingFilter Data", "sgMissionFilterData");
            this.process();
            }

        [ConsoleInteraction]
        public void buildsgDecalProjector()
            {
            this.objectClassName = "sgDecalProjector";
            this.addField("dataBlock", "TypeDataBlock", "DecalData Data", "DecalData");
            this.process();
            }

        [ConsoleInteraction]
        public void buildsgLightObject()
            {
            this.objectClassName = "sgLightObject";
            this.addField("dataBlock", "TypeDataBlock", "LightObject Data", "sgLightObjectData");
            this.process();
            }

        [ConsoleInteraction]
        public void buildSun(bool dontWarnAboutScatterSky = false)
            {
            if (!dontWarnAboutScatterSky)
                {
                // Check for sun object already in the level.  If there is one,
                // warn the user.	
                Util.initContainerTypeSearch((uint)SceneObjectTypesAsUint.EnvironmentObjectType, false);
                while (true)
                    {
                    SimObject obj = Util.containerSearchNext(false);
                    if (!obj.isObject())
                        break;

                    if (obj.isMemberOfClass("ScatterSky"))
                        {
                        messageBox.MessageBoxYesNo("Warning",
                            "A Sun object will conflict with the ScatterSky object that is already in the level.  Do you still want to create a Sun object?",
                            this + ".buildSun(true);", "");
                        return;
                        }
                    }
                }
            this.objectClassName = "Sun";

            this.addField("direction", "TypeVector", "Direction", "1 1 -1");
            this.addField("color", "TypeColor", "Sun color", "0.8 0.8 0.8");
            this.addField("ambient", "TypeColor", "Ambient color", "0.2 0.2 0.2");

            this.process();

            // This is a trick... any fields added after process won't show
            // up as controls, but will be applied to the created object.
            this.addField("coronaMaterial", "TypeMaterialName", "Corona Material", "Corona_Mat");
            this.addField("flareType", "TypeLightFlareDataPtr", "Flare", "SunFlareExample");
            }

        [ConsoleInteraction]
        public void buildLightning()
            {
            this.objectClassName = "Lightning";
            this.addField("dataBlock", "TypeDataBlock", "Data block", "LightningData DefaultStorm");
            this.process();
            }

        [ConsoleInteraction]
        public void addWaterObjectFields()
            {
            this.addField("rippleDir[0]", "TypePoint2", "Ripple Direction", "0.000000 1.000000");
            this.addField("rippleDir[1]", "TypePoint2", "Ripple Direction", "0.707000 0.707000");
            this.addField("rippleDir[2]", "TypePoint2", "Ripple Direction", "0.500000 0.860000");
            this.addField("rippleTexScale[0]", "TypePoint2", "Ripple Texture Scale", "7.140000 7.140000");
            this.addField("rippleTexScale[1]", "TypePoint2", "Ripple Texture Scale", "6.250000 12.500000");
            this.addField("rippleTexScale[2]", "TypePoint2", "Ripple Texture Scale", "50.000000 50.000000");
            this.addField("rippleSpeed[0]", "TypeFloat", "Ripple Speed", "0.065");
            this.addField("rippleSpeed[1]", "TypeFloat", "Ripple Speed", "0.09");
            this.addField("rippleSpeed[2]", "TypeFloat", "Ripple Speed", "0.04");
            this.addField("rippleMagnitude[0]", "TypeFloat", "Ripple Magnitude", "1.0");
            this.addField("rippleMagnitude[1]", "TypeFloat", "Ripple Magnitude", "1.0");
            this.addField("rippleMagnitude[2]", "TypeFloat", "Ripple Magnitude", "0.3");
            this.addField("overallRippleMagnitude", "TypeFloat", "Overall Ripple Magnitude", "1.0");

            this.addField("waveDir[0]", "TypePoint2", "Wave Direction", "0.000000 1.000000");
            this.addField("waveDir[1]", "TypePoint2", "Wave Direction", "0.707000 0.707000");
            this.addField("waveDir[2]", "TypePoint2", "Wave Direction", "0.500000 0.860000");
            this.addField("waveMagnitude[0]", "TypePoint2", "Wave Magnitude", "0.2");
            this.addField("waveMagnitude[1]", "TypePoint2", "Wave Magnitude", "0.2");
            this.addField("waveMagnitude[2]", "TypePoint2", "Wave Magnitude", "0.2");
            this.addField("waveSpeed[0]", "TypeFloat", "Wave Speed", "1");
            this.addField("waveSpeed[1]", "TypeFloat", "Wave Speed", "1");
            this.addField("waveSpeed[2]", "TypeFloat", "Wave Speed", "1");
            this.addField("overallWaveMagnitude", "TypeFloat", "Overall Wave Magnitude", "1.0");

            this.addField("rippleTex", "TypeImageFilename", "Ripple Texture", "art/water/ripple");
            this.addField("depthGradientTex", "TypeImageFilename", "Depth Gradient Texture", "art/water/depthcolor_ramp");
            this.addField("foamTex", "TypeImageFilename", "Foam Texture", "art/water/foam");
            }

        [ConsoleInteraction]
        public void buildWaterBlock()
            {
            this.objectClassName = "WaterBlock";
            this.addField("baseColor", "TypeColorI", "Base Color", "45 108 171 255");
            this.process();

            // This is a trick... any fields added after process won't show
            // up as controls, but will be applied to the created object.
            this.addWaterObjectFields();
            }

        [ConsoleInteraction]
        public void buildWaterPlane()
            {
            this.objectClassName = "WaterPlane";
            this.addField("baseColor", "TypeColorI", "Base Color", "45 108 171 255");
            this.process();

            // This is a trick... any fields added after process won't show
            // up as controls, but will be applied to the created object.
            this.addWaterObjectFields();
            }

        [ConsoleInteraction]
        public void buildTerrainBlock()
            {
            this.objectClassName = "TerrainBlock";
            this.createCallback = "ETerrainEditor.attachTerrain();";

            this.addField("terrainFile", "TypeFile", "Terrain file", "", "(Terrains)|*.ter");
            this.addField("squareSize", "TypeInt", "Square size", "8");

            this.process();
            }

        [ConsoleInteraction]
        public void buildGroundCover()
            {
            this.objectClassName = "GroundCover";
            this.addField("material", "TypeMaterialName", "Material Name", "");
            this.addField("shapeFilename[0]", "TypeFile", "Shape File [Optional]", "", "(ALL)|*.*");
            this.process();

            // This is a trick... any fields added after process won't show
            // up as controls, but will be applied to the created object.
            this.addField("probability[0]", "TypeFloat", "Probability", "1");
            }

        [ConsoleInteraction]
        public void buildPrecipitation()
            {
            this.objectClassName = "Precipitation";
            this.addField("dataBlock", "TypeDataBlock", "Precipitation data", "PrecipitationData");
            this.process();
            }

        [ConsoleInteraction]
        public void buildParticleEmitterNode()
            {
            this.objectClassName = "ParticleEmitterNode";
            this.addField("dataBlock", "TypeDataBlock", "datablock", "ParticleEmitterNodeData");
            this.addField("emitter", "TypeDataBlock", "Particle data", "ParticleEmitterData");
            this.process();
            }

        [ConsoleInteraction]
        public void buildParticleSimulation()
            {
            this.objectClassName = "ParticleSimulation";
            this.addField("datablock", "TypeDataBlock", "datablock", "ParticleSimulationData");
            this.process();
            }

        //------------------------------------------------------------------------------
        // Mission
        //------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void buildTrigger()
            {
            this.objectClassName = "Trigger";
            this.addField("dataBlock", "TypeDataBlock", "Data Block", "TriggerData defaultTrigger");
            this.addField("polyhedron", "TypeTriggerPolyhedron", "Polyhedron",
                "-0.5 0.5 0.0 1.0 0.0 0.0 0.0 -1.0 0.0 0.0 0.0 1.0");
            this.process();
            }

        [ConsoleInteraction]
        public void buildPhysicalZone()
            {
            this.objectClassName = "PhysicalZone";
            this.addField("polyhedron", "TypeTriggerPolyhedron", "Polyhedron",
                "-0.5 0.5 0.0 1.0 0.0 0.0 0.0 -1.0 0.0 0.0 0.0 1.0");
            this.process();
            }

        [ConsoleInteraction]
        public void buildCamera()
            {
            this.objectClassName = "Camera";

            this.addField("position", "TypePoint3", "Position", "0 0 0");
            this.addField("rotation", "TypePoint4", "Rotation", "1 0 0 0");
            this.addField("dataBlock", "TypeDataBlock", "Data block", "CameraData Observer");
            this.addField("team", "TypeInt", "Team", "0");

            this.process();
            }

        [ConsoleInteraction]
        public void buildLevelInfo()
            {
            if (checkExists("LevelInfo"))
                {
                GenericPromptDialog GenericPromptDialog = "GenericPromptDialog";
                GuiWindowCtrl GenericPromptWindow = GenericPromptDialog.FOT("GenericPromptWindow");
                GuiTextCtrl GenericPromptText = GenericPromptDialog.FOT("GenericPromptText");
                GenericPromptWindow.text = "Warning";
                GenericPromptText.text =
                    "There is already an existing LevelInfo in the scene.";
                ((GuiCanvas)"Canvas").pushDialog(GenericPromptDialog);
                return;
                }

            OBObjectName.setValue("theLevelInfo");
            this.objectClassName = "LevelInfo";
            this.process();
            }

        [ConsoleInteraction]
        public void buildTimeOfDay()
            {
            if (checkExists("TimeOfDay"))
                {
                GenericPromptDialog GenericPromptDialog = "GenericPromptDialog";
                GuiWindowCtrl GenericPromptWindow = GenericPromptDialog.FOT("GenericPromptWindow");
                GuiTextCtrl GenericPromptText = GenericPromptDialog.FOT("GenericPromptText");
                GenericPromptWindow.text = "Warning";
                GenericPromptText.text =
                    "There is already an existing TimeOfDay in the scene.";
                ((GuiCanvas)"Canvas").pushDialog(GenericPromptDialog);
                return;
                }
            this.objectClassName = "TimeOfDay";
            this.process();
            }

        [ConsoleInteraction]
        public void buildPlayerDropPoint()
            {
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";

            this.objectClassName = "SpawnSphere";
            this.addField("dataBlock", "TypeDataBlock", "dataBlock", "MissionMarkerData SpawnSphereMarker");
            this.addField("radius", "TypeFloat", "Radius", "1");
            this.addField("sphereWeight", "TypeFloat", "Sphere Weight", "1");

            this.addField("spawnClass", "TypeString", "Spawn Class", "Player");
            this.addField("spawnDatablock", "TypeDataBlock", "Spawn Data", "PlayerData DefaultPlayerData");


            if (EWCreatorWindow.objectGroup.getId() == "MissionGroup".getID())
                {
                if (!"PlayerDropPoints".isObject())
                    ((SimGroup)"MissionGroup").add(
                        new ObjectCreator("SimGroup", "PlayerDropPoints").Create().AsString());
                this["objectGroup"] = "PlayerDropPoints";
                }

            this.process();
            }

        [ConsoleInteraction]
        public void buildObserverDropPoint()
            {
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";

            this.objectClassName = "SpawnSphere";
            this.addField("dataBlock", "TypeDataBlock", "dataBlock", "MissionMarkerData SpawnSphereMarker");
            this.addField("radius", "TypeFloat", "Radius", "1");
            this.addField("sphereWeight", "TypeFloat", "Sphere Weight", "1");

            this.addField("spawnClass", "TypeString", "Spawn Class", "Camera");
            this.addField("spawnDatablock", "TypeDataBlock", "Spawn Data", "CameraData Observer");


            if (EWCreatorWindow.objectGroup.getId() == "MissionGroup".getID())
                {
                if (!"ObserverDropPoints".isObject())
                    ((SimGroup)"MissionGroup").add(
                        new ObjectCreator("SimGroup", "ObserverDropPoints").Create().AsString());
                this["objectGroup"] = "ObserverDropPoints";
                }
            this.process();
            }

        //------------------------------------------------------------------------------
        // System
        //------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void buildPhysicsEntity()
            {
            this.objectClassName = "PhysicsEntity";
            this.addField("dataBlock", "TypeDataBlock", "Data block", "PhysicsEntityData");
            this.process();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(objectBuilderGui ts, string simobjectid)
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
        public static bool operator !=(objectBuilderGui ts, string simobjectid)
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
        public static implicit operator string(objectBuilderGui ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator objectBuilderGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (objectBuilderGui)Omni.self.getSimObject(simobjectid, typeof(objectBuilderGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(objectBuilderGui ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator objectBuilderGui(int simobjectid)
            {
            return (objectBuilderGui)Omni.self.getSimObject((uint)simobjectid, typeof(objectBuilderGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(objectBuilderGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator objectBuilderGui(uint simobjectid)
            {
            return (objectBuilderGui)Omni.self.getSimObject(simobjectid, typeof(objectBuilderGui));
            }

        #endregion

        //------------------------------------------------------------------------------
        // Functions to allow scripted/datablock objects to be instantiated
        //------------------------------------------------------------------------------
        }
    }