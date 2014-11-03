


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiTableControl_Base>))]
    public partial class GuiTableControl_Base: GuiScrollCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTableControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTableControl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiTableControl_Base ts)
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
        public static implicit operator GuiTableControl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTableControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTableControl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTableControl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTableControl_Base(int simobjectid)
            {
            return  (GuiTableControl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTableControl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTableControl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTableControl_Base(uint simobjectid)
            {
            return  (GuiTableControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTableControl_Base));
            }
#endregion
#region Init Persists
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
/// <summary>
/// The size of the heading.\n 
/// </summary>
[MemberGroup("")]
public int headingSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".headingSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".headingSize", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addChildRow(string text, int index){

pInvokes.m_ts.fnGuiTableControl_addChildRow(_ID, text, index);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addHeading(string text, int index){

pInvokes.m_ts.fnGuiTableControl_addHeading(_ID, text, index);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearChildren(){

pInvokes.m_ts.fnGuiTableControl_clearChildren(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findColumnTextIndex(int columnId, string columnText){

return pInvokes.m_ts.fnGuiTableControl_findColumnTextIndex(_ID, columnId, columnText);
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

return pInvokes.m_ts.fnGuiTableControl_getSelectedRow(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setColumnSort(int column, bool ascending){

pInvokes.m_ts.fnGuiTableControl_setColumnSort(_ID, column, ascending);
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

pInvokes.m_ts.fnGuiTableControl_setSelectedRow(_ID, rowNum);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Callback when the column is sorted. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSortedColumn(int columnId, string columnName, bool increasing){}

        /// <summary>
        /// @brief Called whenever an item in the list is selected.   @param cellid The ID of the cell that was selected   @param text The text in the selected cel   @tsexample   // A cel in the control was selected, causing the callback to occur   GuiTextListCtrl::onSelect(%this,%callid,%text)   	{   		// Code to run when a cel item is selected   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelect(string cellid, string text){}

#endregion
public GuiTableControl_Base (){}
}}
