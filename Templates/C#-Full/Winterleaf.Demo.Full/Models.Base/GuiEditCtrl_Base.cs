


#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using System.Threading;
using  WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Demo.Full.Models.User.Extendable;
#endregion

namespace WinterLeaf.Demo.Full.Models.Base
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<GuiEditCtrl_Base>))]
    public partial class GuiEditCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEditCtrl_Base ts, string simobjectid)
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
            
            return (this._ID ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(GuiEditCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiEditCtrl_Base ts)
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
        public static implicit operator GuiEditCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiEditCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiEditCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiEditCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditCtrl_Base(int simobjectid)
            {
            return  (GuiEditCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiEditCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiEditCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditCtrl_Base(uint simobjectid)
            {
            return  (GuiEditCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiEditCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true, lines will be drawn extending along the edges of selected objects. 
/// </summary>
[MemberGroup("Rendering")]
public bool drawBorderLines
       {
       get
          {
          return Omni.self.GetVar(_ID + ".drawBorderLines").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".drawBorderLines", value.AsString());
          }
       }
/// <summary>
/// If true, guides will be included in rendering. 
/// </summary>
[MemberGroup("Rendering")]
public bool drawGuides
       {
       get
          {
          return Omni.self.GetVar(_ID + ".drawGuides").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".drawGuides", value.AsString());
          }
       }
/// <summary>
/// If true, rectangle selection will only select controls fully inside the drag rectangle. 
/// </summary>
[MemberGroup("Selection")]
public bool fullBoxSelection
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fullBoxSelection").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fullBoxSelection", value.AsString());
          }
       }
/// <summary>
/// Distance in pixels that edge and center snapping will work across. 
/// </summary>
[MemberGroup("Snapping")]
public int snapSensitivity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".snapSensitivity").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".snapSensitivity", value.AsString());
          }
       }
/// <summary>
/// If true, edge and center snapping will work against canvas (toplevel control). 
/// </summary>
[MemberGroup("Snapping")]
public bool snapToCanvas
       {
       get
          {
          return Omni.self.GetVar(_ID + ".snapToCanvas").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".snapToCanvas", value.AsString());
          }
       }
/// <summary>
/// If true, selection centers will snap into alignment when moved or resized. 
/// </summary>
[MemberGroup("Snapping")]
public bool snapToCenters
       {
       get
          {
          return Omni.self.GetVar(_ID + ".snapToCenters").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".snapToCenters", value.AsString());
          }
       }
/// <summary>
/// If true, edge and center snapping will work against controls. 
/// </summary>
[MemberGroup("Snapping")]
public bool snapToControls
       {
       get
          {
          return Omni.self.GetVar(_ID + ".snapToControls").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".snapToControls", value.AsString());
          }
       }
/// <summary>
/// If true, selection edges will snap into alignment when moved or resized. 
/// </summary>
[MemberGroup("Snapping")]
public bool snapToEdges
       {
       get
          {
          return Omni.self.GetVar(_ID + ".snapToEdges").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".snapToEdges", value.AsString());
          }
       }
/// <summary>
/// If true, edge and center snapping will work against guides. 
/// </summary>
[MemberGroup("Snapping")]
public bool snapToGuides
       {
       get
          {
          return Omni.self.GetVar(_ID + ".snapToGuides").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".snapToGuides", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// (GuiControl ctrl))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addNewCtrl(string ctrl){

pInvokes.m_ts.fn_GuiEditCtrl_addNewCtrl(_ID, ctrl);
}
/// <summary>
/// selects a control.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addSelection(int id){

pInvokes.m_ts.fn_GuiEditCtrl_addSelection(_ID, id);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void bringToFront(){

pInvokes.m_ts.fn_GuiEditCtrl_bringToFront(_ID);
}
/// <summary>
/// ( [ int axis ] ) - Clear all currently set guide lines. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearGuides(int axis = -1){

pInvokes.m_ts.fn_GuiEditCtrl_clearGuides(_ID, axis);
}
/// <summary>
/// Clear selected controls list.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearSelection(){

pInvokes.m_ts.fn_GuiEditCtrl_clearSelection(_ID);
}
/// <summary>
/// () - Delete the selected controls.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteSelection(){

pInvokes.m_ts.fn_GuiEditCtrl_deleteSelection(_ID);
}
/// <summary>
/// ( bool width=true, bool height=true ) - Fit selected controls into their parents. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void fitIntoParents(bool width = true, bool height = true){

pInvokes.m_ts.fn_GuiEditCtrl_fitIntoParents(_ID, width, height);
}
/// <summary>
/// () - Return the toplevel control edited inside the GUI editor. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getContentControl(){

return pInvokes.m_ts.fn_GuiEditCtrl_getContentControl(_ID);
}
/// <summary>
/// Returns the set to which new controls will be added)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getCurrentAddSet(){

return pInvokes.m_ts.fn_GuiEditCtrl_getCurrentAddSet(_ID);
}
/// <summary>
/// () - Return the current mouse mode. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMouseMode(){

return pInvokes.m_ts.fn_GuiEditCtrl_getMouseMode(_ID);
}
/// <summary>
/// () - Return the number of controls currently selected. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNumSelected(){

return pInvokes.m_ts.fn_GuiEditCtrl_getNumSelected(_ID);
}
/// <summary>
/// () - Returns global bounds of current selection as vector 'x y width height'. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSelectionGlobalBounds(){

return pInvokes.m_ts.fn_GuiEditCtrl_getSelectionGlobalBounds(_ID);
}
/// <summary>
/// (int mode) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void justify(uint mode){

pInvokes.m_ts.fn_GuiEditCtrl_justify(_ID, mode);
}
/// <summary>
/// ( string fileName=null ) - Load selection from file or clipboard.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void loadSelection(string filename = null ){
if (filename== null) {filename = null;}

pInvokes.m_ts.fn_GuiEditCtrl_loadSelection(_ID, filename);
}
/// <summary>
/// Move all controls in the selection by (dx,dy) pixels.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void moveSelection(Point2I pos){

pInvokes.m_ts.fn_GuiEditCtrl_moveSelection(_ID, pos.AsString());
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pushToBack(){

pInvokes.m_ts.fn_GuiEditCtrl_pushToBack(_ID);
}
/// <summary>
/// ( GuiControl ctrl [, int axis ] ) - Read the guides from the given control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void readGuides(string ctrl, int axis = -1){

pInvokes.m_ts.fn_GuiEditCtrl_readGuides(_ID, ctrl, axis);
}
/// <summary>
/// deselects a control.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeSelection(int id){

pInvokes.m_ts.fn_GuiEditCtrl_removeSelection(_ID, id);
}
/// <summary>
/// ( string fileName=null ) - Save selection to file or clipboard.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void saveSelection(string filename = null ){
if (filename== null) {filename = null;}

pInvokes.m_ts.fn_GuiEditCtrl_saveSelection(_ID, filename);
}
/// <summary>
/// (GuiControl ctrl))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void select(string ctrl){

pInvokes.m_ts.fn_GuiEditCtrl_select(_ID, ctrl);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectAll(){

pInvokes.m_ts.fn_GuiEditCtrl_selectAll(_ID);
}
/// <summary>
/// ( bool addToSelection=false ) - Select children of currently selected controls. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectChildren(bool addToSelection = false){

pInvokes.m_ts.fn_GuiEditCtrl_selectChildren(_ID, addToSelection);
}
/// <summary>
/// ( bool addToSelection=false ) - Select parents of currently selected controls. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectParents(bool addToSelection = false){

pInvokes.m_ts.fn_GuiEditCtrl_selectParents(_ID, addToSelection);
}
/// <summary>
/// ( GuiControl ctrl ) - Set the toplevel control to edit in the GUI editor. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContentControl(string ctrl){

pInvokes.m_ts.fn_GuiEditCtrl_setContentControl(_ID, ctrl);
}
/// <summary>
/// (GuiControl ctrl))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCurrentAddSet(string addSet){

pInvokes.m_ts.fn_GuiEditCtrl_setCurrentAddSet(_ID, addSet);
}
/// <summary>
/// GuiEditCtrl.setSnapToGrid(gridsize))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSnapToGrid(uint gridsize){

pInvokes.m_ts.fn_GuiEditCtrl_setSnapToGrid(_ID, gridsize);
}
/// <summary>
/// Toggle activation.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggle(){

pInvokes.m_ts.fn_GuiEditCtrl_toggle(_ID);
}
/// <summary>
/// ( GuiControl ctrl [, int axis ] ) - Write the guides to the given control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void writeGuides(string ctrl, int axis = -1){

pInvokes.m_ts.fn_GuiEditCtrl_writeGuides(_ID, ctrl, axis);
}
/// <summary>
/// Gets the set of GUI controls currently selected in the editor. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSelection(){

return pInvokes.m_ts.fnGuiEditCtrl_getSelection(_ID);
}
/// <summary>
/// Gets the GUI controls(s) that are currently in the trash.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTrash(){

return pInvokes.m_ts.fnGuiEditCtrl_getTrash(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onHierarchyChanged(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDelete(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPreEdit(SimSet selection){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPostEdit(SimSet selection){}

        /// <summary>
        ///  )IMPLEMENT_CALLBACK( GuiEditCtrl, onSelect, void, ( GuiControl* control ), ( control ),    )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onClearSelected(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAddSelected(GuiControl control){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemoveSelected(GuiControl control){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPreSelectionNudged(SimSet selection){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPostSelectionNudged(SimSet selection){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelectionMoved(GuiControl control){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelectionCloned(SimSet selection){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTrashSelection(SimSet selection){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAddNewCtrl(GuiControl control){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAddNewCtrlSet(SimSet set){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelectionResized(GuiControl control){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onFitIntoParent(bool width, bool height){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseModeChange(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onControlInspectPreApply(GuiControl control){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onControlInspectPostApply(GuiControl control){}

#endregion
public GuiEditCtrl_Base (){}
}}
