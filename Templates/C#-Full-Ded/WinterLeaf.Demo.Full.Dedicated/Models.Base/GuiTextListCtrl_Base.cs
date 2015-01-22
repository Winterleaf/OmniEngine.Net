


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiTextListCtrl_Base>))]
    public partial class GuiTextListCtrl_Base: GuiArrayCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTextListCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTextListCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiTextListCtrl_Base ts)
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
        public static implicit operator GuiTextListCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTextListCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTextListCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTextListCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTextListCtrl_Base(int simobjectid)
            {
            return  (GuiTextListCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTextListCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTextListCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTextListCtrl_Base(uint simobjectid)
            {
            return  (GuiTextListCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTextListCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true, text exceeding a column's given width will get clipped.\n 
/// </summary>
[MemberGroup("")]
public bool clipColumnText
       {
       get
          {
          return Omni.self.GetVar(_ID + ".clipColumnText").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".clipColumnText", value.AsString());
          }
       }
/// <summary>
/// A vector of column offsets. The number of values determines the number of columns in the table.\n 
/// </summary>
[MemberGroup("")]
public VectorInt columns
       {
       get
          {
          return Omni.self.GetVar(_ID + ".columns").AsVectorInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".columns", value.AsString());
          }
       }
/// <summary>
/// If true, the width of this control will match the width of its parent.\n
/// </summary>
[MemberGroup("")]
public bool fitParentWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fitParentWidth").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fitParentWidth", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ,-1),
///    @brief Adds a new row at end of the list with the defined id and text.
///    If index is used, then the new row is inserted at the row location of 'index'.
///    @param id Id of the new row.
///    @param text Text to display at the new row.
///    @param index Index to insert the new row at. If not used, new row will be placed at the end of the list.
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Define the text to display
///    %text = \"Display Text\"
///    // Define the index (optional)
///    %index = \"2\"
///    // Inform the GuiTextListCtrl control to add the new row with the defined information.
///    %rowIndex = %thisGuiTextListCtrl.addRow(%id,%text,%index);
///    @endtsexample
///    @return Returns the row index of the new row. If 'index' was defined, then this just returns the number of rows in the list.
///    @see References)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int addRow(int id = 0, string text = "", int index = -1){

return pInvokes.m_ts.fnGuiTextListCtrl_addRow(_ID, id, text, index);
}
/// <summary>
/// @brief Clear the list.
///    @tsexample
///    // Inform the GuiTextListCtrl control to clear its contents
///    %thisGuiTextListCtrl.clear();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void clear(){

pInvokes.m_ts.fnGuiTextListCtrl_clear(_ID);
}
/// <summary>
/// @brief Set the selection to nothing.
///    @tsexample
///    // Deselect anything that is currently selected
///    %thisGuiTextListCtrl.clearSelection();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearSelection(){

pInvokes.m_ts.fnGuiTextListCtrl_clearSelection(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findColumnTextIndex(int columnId, string columnText){

return pInvokes.m_ts.fnGuiTextListCtrl_findColumnTextIndex(_ID, columnId, columnText);
}
/// <summary>
/// @brief Find needle in the list, and return the row number it was found in.
///    @param needle Text to find in the list.
///    @tsexample
///    // Define the text to find in the list
///    %needle = \"Text To Find\";
///    // Request the row number that contains the defined text to find
///    %rowNumber = %thisGuiTextListCtrl.findTextIndex(%needle);
///    @endtsexample
///    @return Row number that the defined text was found in,
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findTextIndex(string needle){

return pInvokes.m_ts.fnGuiTextListCtrl_findTextIndex(_ID, needle);
}
/// <summary>
/// @brief Get the row ID for an index.
///    @param index Index to get the RowID at
///    @tsexample
///    // Define the index
///    %index = \"3\";
///    // Request the row ID at the defined index
///    %rowId = %thisGuiTextListCtrl.getRowId(%index);
///    @endtsexample
///    @return RowId at the defined index.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getRowId(int index){

return pInvokes.m_ts.fnGuiTextListCtrl_getRowId(_ID, index);
}
/// <summary>
/// @brief Get the row number for a specified id.
///    @param id Id to get the row number at
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Request the row number from the GuiTextListCtrl control at the defined id.
///    %rowNumber = %thisGuiTextListCtrl.getRowNumById(%id);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getRowNumById(int id){

return pInvokes.m_ts.fnGuiTextListCtrl_getRowNumById(_ID, id);
}
/// <summary>
/// @brief Get the text of the row with the specified index.
///    @param index Row index to acquire the text at.
///    @tsexample
///    // Define the row index
///    %index = \"5\";
///    // Request the text from the row at the defined index
///    %rowText = %thisGuiTextListCtrl.getRowText(%index);
///    @endtsexample
///    @return Text at the defined row index.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getRowText(int index){

return pInvokes.m_ts.fnGuiTextListCtrl_getRowText(_ID, index);
}
/// <summary>
/// @brief Get the text of a row with the specified id.
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Inform the GuiTextListCtrl control to return the text at the defined row id
///    %rowText = %thisGuiTextListCtrl.getRowTextById(%id);
///    @endtsexample
///    @return Row text at the requested row id.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getRowTextById(int id){

return pInvokes.m_ts.fnGuiTextListCtrl_getRowTextById(_ID, id);
}
/// <summary>
/// @brief Get the ID of the currently selected item.
///    @tsexample
///    // Acquire the ID of the selected item in the list.
///    %id = %thisGuiTextListCtrl.getSelectedId();
///    @endtsexample
///    @return The id of the selected item in the list.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedId(){

return pInvokes.m_ts.fnGuiTextListCtrl_getSelectedId(_ID);
}
/// <summary>
/// @brief Returns the selected row index (not the row ID).
///    @tsexample
///    // Acquire the selected row index
///    %rowIndex = %thisGuiTextListCtrl.getSelectedRow();
///    @endtsexample
///    @return Index of the selected row
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedRow(){

return pInvokes.m_ts.fnGuiTextListCtrl_getSelectedRow(_ID);
}
/// <summary>
/// @brief Check if the specified row is currently active or not.
///    @param rowNum Row number to check the active state.
///    @tsexample
///    // Define the row number
///    %rowNum = \"5\";
///    // Request the active state of the defined row number from the GuiTextListCtrl control.
///    %rowActiveState = %thisGuiTextListCtrl.isRowActive(%rowNum);
///    @endtsexample
///    @return Active state of the defined row number.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isRowActive(int rowNum){

return pInvokes.m_ts.fnGuiTextListCtrl_isRowActive(_ID, rowNum);
}
/// <summary>
/// @brief Remove a row from the table, based on its index.
///    @param index Row index to remove from the list.
///    @tsexample
///    // Define the row index
///    %index = \"4\";
///    // Inform the GuiTextListCtrl control to remove the row at the defined row index
///    %thisGuiTextListCtrl.removeRow(%index);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeRow(int index){

pInvokes.m_ts.fnGuiTextListCtrl_removeRow(_ID, index);
}
/// <summary>
/// @brief Remove row with the specified id.
///    @param id Id to remove the row entry at
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Inform the GuiTextListCtrl control to remove the row at the defined id
///    %thisGuiTextListCtrl.removeRowById(%id);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeRowById(int id){

pInvokes.m_ts.fnGuiTextListCtrl_removeRowById(_ID, id);
}
/// <summary>
/// @brief Get the number of rows.
///    @tsexample
///    // Get the number of rows in the list
///    %rowCount = %thisGuiTextListCtrl.rowCount();
///    @endtsexample
///    @return Number of rows in the list.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int rowCount(){

return pInvokes.m_ts.fnGuiTextListCtrl_rowCount(_ID);
}
/// <summary>
/// @brief Scroll so the specified row is visible
///    @param rowNum Row number to make visible
///    @tsexample
///    // Define the row number to make visible
///    %rowNum = \"4\";
///    // Inform the GuiTextListCtrl control to scroll the list so the defined rowNum is visible.
///    %thisGuiTextListCtrl.scrollVisible(%rowNum);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void scrollVisible(int rowNum){

pInvokes.m_ts.fnGuiTextListCtrl_scrollVisible(_ID, rowNum);
}
/// <summary>
/// @brief Mark a specified row as active/not.
///    @param rowNum Row number to change the active state.
///    @param active Boolean active state to set the row number.
///    @tsexample
///    // Define the row number
///    %rowNum = \"4\";
///    // Define the boolean active state
///    %active = \"true\";
///    // Informthe GuiTextListCtrl control to set the defined active state at the defined row number.
///    %thisGuiTextListCtrl.setRowActive(%rowNum,%active);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRowActive(int rowNum, bool active){

pInvokes.m_ts.fnGuiTextListCtrl_setRowActive(_ID, rowNum, active);
}
/// <summary>
/// @brief Sets the text at the defined id.
///    @param id Id to change.
///    @param text Text to use at the Id.
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Define the text
///    %text = \"Text To Display\";
///    // Inform the GuiTextListCtrl control to display the defined text at the defined id
///    %thisGuiTextListCtrl.setRowById(%id,%text);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRowById(int id, string text){

pInvokes.m_ts.fnGuiTextListCtrl_setRowById(_ID, id, text);
}
/// <summary>
/// @brief Finds the specified entry by id, then marks its row as selected.
///    @param id Entry within the text list to make selected.
///    @tsexample
///    // Define the id
///    %id = \"5\";
///    // Inform the GuiTextListCtrl control to set the defined id entry as selected
///    %thisGuiTextListCtrl.setSelectedById(%id);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelectedById(int id){

pInvokes.m_ts.fnGuiTextListCtrl_setSelectedById(_ID, id);
}
/// <summary>
/// @briefSelects the specified row.
///    @param rowNum Row number to set selected.
///    @tsexample
///    // Define the row number to set selected
///    %rowNum = \"4\";
///    %guiTextListCtrl.setSelectedRow(%rowNum);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelectedRow(int rowNum){

pInvokes.m_ts.fnGuiTextListCtrl_setSelectedRow(_ID, rowNum);
}
/// <summary>
/// @brief Performs a standard (alphabetical) sort on the values in the specified column.
///    @param columnId Column ID to perform the sort on.
///    @param increasing If false, sort will be performed in reverse.
///    @tsexample
///    // Define the columnId
///    %id = \"1\";
///    // Define if we are increasing or not
///    %increasing = \"false\";
///    // Inform the GuiTextListCtrl to perform the sort operation
///    %thisGuiTextListCtrl.sort(%id,%increasing);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sort(int columnId, bool increasing = true){

pInvokes.m_ts.fnGuiTextListCtrl_sort(_ID, columnId, increasing);
}
/// <summary>
/// @brief Perform a numerical sort on the values in the specified column.
///    Detailed description
///    @param columnId Column ID to perform the sort on.
///    @param increasing If false, sort will be performed in reverse.
///    @tsexample
///    // Define the columnId
///    %id = \"1\";
///    // Define if we are increasing or not
///    %increasing = \"false\";
///    // Inform the GuiTextListCtrl to perform the sort operation
///    %thisGuiTextListCtrl.sortNumerical(%id,%increasing);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortNumerical(int columnID, bool increasing = true){

pInvokes.m_ts.fnGuiTextListCtrl_sortNumerical(_ID, columnID, increasing);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when the delete key has been pressed.   @param id Id of the selected item in the list   @tsexample   // The delete key was pressed while the GuiTextListCtrl was in focus, causing the callback to occur.   GuiTextListCtrl::onDeleteKey(%this,%id)   	{   		// Code to run when the delete key is pressed   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDeleteKey(string id){}

#endregion
public GuiTextListCtrl_Base (){}
}}
