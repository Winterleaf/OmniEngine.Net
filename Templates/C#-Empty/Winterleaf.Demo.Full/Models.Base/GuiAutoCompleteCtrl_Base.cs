


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiAutoCompleteCtrl_Base>))]
    public partial class GuiAutoCompleteCtrl_Base: GuiTextEditCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiAutoCompleteCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiAutoCompleteCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiAutoCompleteCtrl_Base ts)
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
        public static implicit operator GuiAutoCompleteCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiAutoCompleteCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiAutoCompleteCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiAutoCompleteCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiAutoCompleteCtrl_Base(int simobjectid)
            {
            return  (GuiAutoCompleteCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiAutoCompleteCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiAutoCompleteCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiAutoCompleteCtrl_Base(uint simobjectid)
            {
            return  (GuiAutoCompleteCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiAutoCompleteCtrl_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ( GuiAutoCompleteCtrl, add, void, 3, 5, (string name, int idNum, int scheme=0))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void add(string a2, string a3= "", string a4= ""){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_add(_ID, a2, a3, a4);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, addScheme, void, 6, 6, (int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addScheme(string a2, string a3, string a4, string a5){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_addScheme(_ID, a2, a3, a4, a5);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, changeTextById, void, 4, 4, ( int id, string text ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void changeTextById(string a2, string a3){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_changeTextById(_ID, a2, a3);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, clear, void, 2, 2, Clear the popup list.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void clear(){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_clear(_ID);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, clearEntry, void, 3, 3, (S32 entry))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearEntry(string a2){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_clearEntry(_ID, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, findText, S32, 3, 3, (string text)
///               Returns the position of the first entry containing the specified text.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findText(string a2){

return pInvokes.m_ts.fnGuiAutoCompleteCtrl_findText(_ID, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, forceClose, void, 2, 2, )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void forceClose(){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_forceClose(_ID);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, forceOnAction, void, 2, 2, )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void forceOnAction(){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_forceOnAction(_ID);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, getSelected, S32, 2, 2, )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelected(){

return pInvokes.m_ts.fnGuiAutoCompleteCtrl_getSelected(_ID);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, getText, void, 2, 2, )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void getText(){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_getText(_ID);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, getTextById, const char*, 3, 3,  (int id))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTextById(string a2){

return pInvokes.m_ts.fnGuiAutoCompleteCtrl_getTextById(_ID, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, replaceText, void, 3, 3, (bool doReplaceText))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void replaceText(string a2){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_replaceText(_ID, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, setEnumContent, void, 4, 4, (string class, string enum)
///               This fills the popup with a classrep's field enumeration type info.
///               More of a helper function than anything.   If console access to the field list is added, 
///               at least for the enumerated types, then this should go away..)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setEnumContent(string a2, string a3){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_setEnumContent(_ID, a2, a3);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, setFirstSelected, void, 2, 3, ([scriptCallback=true]))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFirstSelected(string a2= ""){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_setFirstSelected(_ID, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, setNoneSelected, void, 2, 2, )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNoneSelected(){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_setNoneSelected(_ID);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, setSelected, void, 3, 4, (int id, [scriptCallback=true]))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelected(string a2, string a3= ""){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_setSelected(_ID, a2, a3);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, size, S32, 2, 2, Get the size of the menu - the number of entries in it.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int size(){

return pInvokes.m_ts.fnGuiAutoCompleteCtrl_size(_ID);
}
/// <summary>
/// (GuiAutoCompleteCtrl, sort, void, 2, 2, Sort the list alphabetically.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sort(){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_sort(_ID);
}
/// <summary>
/// (GuiAutoCompleteCtrl, sortID, void, 2, 2, Sort the list by ID.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortID(){

pInvokes.m_ts.fnGuiAutoCompleteCtrl_sortID(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiAutoCompleteCtrl_Base (){}
}}
