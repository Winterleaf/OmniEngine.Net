


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiPopUpMenuCtrlEx_Base>))]
    public partial class GuiPopUpMenuCtrlEx_Base: GuiTextCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiPopUpMenuCtrlEx_Base ts, string simobjectid)
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
        public static bool operator !=(GuiPopUpMenuCtrlEx_Base ts, string simobjectid)
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
        public static implicit operator string( GuiPopUpMenuCtrlEx_Base ts)
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
        public static implicit operator GuiPopUpMenuCtrlEx_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiPopUpMenuCtrlEx_Base) Omni.self.getSimObject(simobjectid,typeof(GuiPopUpMenuCtrlEx_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiPopUpMenuCtrlEx_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiPopUpMenuCtrlEx_Base(int simobjectid)
            {
            return  (GuiPopUpMenuCtrlEx) Omni.self.getSimObject((uint)simobjectid,typeof(GuiPopUpMenuCtrlEx_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiPopUpMenuCtrlEx_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiPopUpMenuCtrlEx_Base(uint simobjectid)
            {
            return  (GuiPopUpMenuCtrlEx_Base) Omni.self.getSimObject(simobjectid,typeof(GuiPopUpMenuCtrlEx_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// , -1, 0), (string name, int idNum, int scheme=0))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void add(string name = "", int idNum = -1, uint scheme = 0){

pInvokes.m_ts.fn_GuiPopUpMenuCtrlEx_add(_ID, name, idNum, scheme);
}
/// <summary>
/// (S32 entry))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearEntry(int entry){

pInvokes.m_ts.fn_GuiPopUpMenuCtrlEx_clearEntry(_ID, entry);
}
/// <summary>
/// (string text)
///               Returns the id of the first entry containing the specified text or -1 if not found.
/// 			  @param text String value used for the query
/// 			  @return Numerical ID of entry containing the text.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findText(string text){

return pInvokes.m_ts.fn_GuiPopUpMenuCtrlEx_findText(_ID, text);
}
/// <summary>
/// @brief Get color of an entry's box
/// 			  @param id ID number of entry to query
/// 			  @return ColorI in the format of \"Red Green Blue Alpha\", each of with is a value between 0 - 255)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  ColorI getColorById(int id){

return new ColorI ( pInvokes.m_ts.fn_GuiPopUpMenuCtrlEx_getColorById(_ID, id));
}
/// <summary>
/// @brief Flag that causes each new text addition to replace the current entry
/// 			  @param True to turn on replacing, false to disable it)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void replaceText(int boolVal){

pInvokes.m_ts.fn_GuiPopUpMenuCtrlEx_replaceText(_ID, boolVal);
}
/// <summary>
/// @brief This fills the popup with a classrep's field enumeration type info.
///               More of a helper function than anything.   If console access to the field list is added, 
///               at least for the enumerated types, then this should go away.
/// 			  @param class Name of the class containing the enum
/// 			  @param enum Name of the enum value to acces)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setEnumContent(string className, string enumName){

pInvokes.m_ts.fn_GuiPopUpMenuCtrlEx_setEnumContent(_ID, className, enumName);
}
/// <summary>
/// ([scriptCallback=true])
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFirstSelected(bool scriptCallback = true){

pInvokes.m_ts.fn_GuiPopUpMenuCtrlEx_setFirstSelected(_ID, scriptCallback);
}
/// <summary>
/// (int id, [scriptCallback=true])
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelected(int id, bool scriptCallback = true){

pInvokes.m_ts.fn_GuiPopUpMenuCtrlEx_setSelected(_ID, id, scriptCallback);
}
/// <summary>
/// @brief Get the size of the menu
/// 			  @return Number of entries in the menu)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int size(){

return pInvokes.m_ts.fn_GuiPopUpMenuCtrlEx_size(_ID);
}
/// <summary>
/// @brief Add a category to the list.
/// 
/// 				   Acts as a separator between entries, allowing for sub-lists
/// 
/// 				   @param text Name of the new category)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addCategory(string text){

pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_addCategory(_ID, text);
}
/// <summary>
/// @brief Create a new scheme and add it to the list of choices for when a new text entry is added.
/// 				   @param id Numerical id associated with this scheme
/// 				   @param fontColor The base text font color. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.
/// 				   @param fontColorHL Color of text when being highlighted. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.
/// 				   @param fontColorSel Color of text when being selected. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addScheme(int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL){

pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_addScheme(_ID, id, fontColor.AsString(), fontColorHL.AsString(), fontColorSEL.AsString());
}
/// <summary>
/// @brief Clear the popup list.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void clear(){

pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_clear(_ID);
}
/// <summary>
/// @brief Manually force this control to collapse and close.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void forceClose(){

pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_forceClose(_ID);
}
/// <summary>
/// @brief Manually for the onAction function, which updates everything in this control.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void forceOnAction(){

pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_forceOnAction(_ID);
}
/// <summary>
/// @brief Get the current selection of the menu.
/// 				   @return Returns the ID of the currently selected entry)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelected(){

return pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_getSelected(_ID);
}
/// <summary>
/// @brief Get the.
/// 
/// 				   Detailed description
/// 
/// 				   @param param Description
/// 
/// 				   @tsexample
/// 				   // Comment
/// 				   code();
/// 				   @endtsexample
/// 
/// 				   @return Returns current text in string format)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getText(){

return pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_getText(_ID);
}
/// <summary>
/// @brief Get the text of an entry based on an ID.
/// 				   @param id The ID assigned to the entry being queried
/// 				   @return String contained by the specified entry, NULL if empty or bad ID)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTextById(int id){

return pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_getTextById(_ID, id);
}
/// <summary>
/// @brief Clears selection in the menu.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNoneSelected(int param){

pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_setNoneSelected(_ID, param);
}
/// <summary>
/// @brief Set the current text to a specified value.
/// 				   @param text String containing new text to set)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void setText(string text){

pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_setText(_ID, text);
}
/// <summary>
/// @brief Sort the list alphabetically.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sort(){

pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_sort(_ID);
}
/// <summary>
/// @brief Sort the list by ID.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortID(){

pInvokes.m_ts.fnGuiPopUpMenuCtrlEx_sortID(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onHotTrackItem(string id){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelect(string id, string text){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onCancel(){}

#endregion
public GuiPopUpMenuCtrlEx_Base (){}
}}
