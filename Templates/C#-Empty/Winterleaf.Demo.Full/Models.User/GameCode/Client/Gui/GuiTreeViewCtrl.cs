#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    partial class GuiTreeViewCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onDefineIcons()
            {
            string icons = "core/art/gui/images/treeview/default:" + "core/art/gui/images/treeview/simgroup:" +
                           "core/art/gui/images/treeview/simgroup_closed:" +
                           "core/art/gui/images/treeview/simgroup_selected:" +
                           "core/art/gui/images/treeview/simgroup_selected_closed:" +
                           "core/art/gui/images/treeview/hidden:" +
                           "core/art/gui/images/treeview/shll_icon_passworded_hi:" +
                           "core/art/gui/images/treeview/shll_icon_passworded:" + "core/art/gui/images/treeview/default";

            this.buildIconTable(icons);
            }

        public override bool handleRenameObject(string newName, SimObject xobject)
            {
            GuiInspector inspector = console.Call_Classname("GuiInspector", "findByObject", new string[] {xobject});

            if (inspector.isObject())
                {
                string field = (this["renameInternal"].AsBool()) ? "internalName" : "name";
                inspector.setObjectField(field, newName);
                return true;
                }
            return false;
            }
        }
    }