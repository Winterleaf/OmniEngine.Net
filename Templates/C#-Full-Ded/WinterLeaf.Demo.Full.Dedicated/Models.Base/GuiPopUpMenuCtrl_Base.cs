


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiPopUpMenuCtrl_Base>))]
    public partial class GuiPopUpMenuCtrl_Base: GuiTextCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiPopUpMenuCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiPopUpMenuCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiPopUpMenuCtrl_Base ts)
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
        public static implicit operator GuiPopUpMenuCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiPopUpMenuCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiPopUpMenuCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiPopUpMenuCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiPopUpMenuCtrl_Base(int simobjectid)
            {
            return  (GuiPopUpMenuCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiPopUpMenuCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiPopUpMenuCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiPopUpMenuCtrl_Base(uint simobjectid)
            {
            return  (GuiPopUpMenuCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiPopUpMenuCtrl_Base));
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

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_add(_ID, name, idNum, scheme);
}
/// <summary>
/// (int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addScheme(uint id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_addScheme(_ID, id, fontColor.AsString(), fontColorHL.AsString(), fontColorSEL.AsString());
}
/// <summary>
/// ( int id, string text ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void changeTextById(int id, string text){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_changeTextById(_ID, id, text);
}
/// <summary>
/// Clear the popup list.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void clear(){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_clear(_ID);
}
/// <summary>
/// (S32 entry))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearEntry(int entry){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_clearEntry(_ID, entry);
}
/// <summary>
/// (string text)
///               Returns the position of the first entry containing the specified text.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findText(string text){

return pInvokes.m_ts.fn_GuiPopUpMenuCtrl_findText(_ID, text);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void forceClose(){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_forceClose(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void forceOnAction(){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_forceOnAction(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelected(){

return pInvokes.m_ts.fn_GuiPopUpMenuCtrl_getSelected(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getText(){

return pInvokes.m_ts.fn_GuiPopUpMenuCtrl_getText(_ID);
}
/// <summary>
/// (int id))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTextById(int id){

return pInvokes.m_ts.fn_GuiPopUpMenuCtrl_getTextById(_ID, id);
}
/// <summary>
/// (bool doReplaceText))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void replaceText(bool doReplaceText){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_replaceText(_ID, doReplaceText);
}
/// <summary>
/// (string class, string enum)
///               This fills the popup with a classrep's field enumeration type info.
///               More of a helper function than anything.   If console access to the field list is added, 
///               at least for the enumerated types, then this should go away..)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setEnumContent(string className, string enumName){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_setEnumContent(_ID, className, enumName);
}
/// <summary>
/// ([scriptCallback=true]))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFirstSelected(bool scriptCallback = true){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_setFirstSelected(_ID, scriptCallback);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNoneSelected(){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_setNoneSelected(_ID);
}
/// <summary>
/// (int id, [scriptCallback=true]))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelected(int id, bool scriptCallback = true){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_setSelected(_ID, id, scriptCallback);
}
/// <summary>
/// Get the size of the menu - the number of entries in it.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int size(){

return pInvokes.m_ts.fn_GuiPopUpMenuCtrl_size(_ID);
}
/// <summary>
/// Sort the list alphabetically.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sort(){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_sort(_ID);
}
/// <summary>
/// Sort the list by ID.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortID(){

pInvokes.m_ts.fn_GuiPopUpMenuCtrl_sortID(_ID);
}

#endregion
#region T3D Callbacks

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
public GuiPopUpMenuCtrl_Base (){}
}}
