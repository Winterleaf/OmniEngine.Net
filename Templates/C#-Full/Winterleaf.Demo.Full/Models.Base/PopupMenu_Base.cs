


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
    [TypeConverter(typeof(TypeConverterGeneric<PopupMenu_Base>))]
    public partial class PopupMenu_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PopupMenu_Base ts, string simobjectid)
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
        public static bool operator !=(PopupMenu_Base ts, string simobjectid)
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
        public static implicit operator string( PopupMenu_Base ts)
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
        public static implicit operator PopupMenu_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (PopupMenu_Base) Omni.self.getSimObject(simobjectid,typeof(PopupMenu_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( PopupMenu_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PopupMenu_Base(int simobjectid)
            {
            return  (PopupMenu) Omni.self.getSimObject((uint)simobjectid,typeof(PopupMenu_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( PopupMenu_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PopupMenu_Base(uint simobjectid)
            {
            return  (PopupMenu_Base) Omni.self.getSimObject(simobjectid,typeof(PopupMenu_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// the title of this menu when attached to a menu bar
/// </summary>
[MemberGroup("")]
public String barTitle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".barTitle").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".barTitle", value.AsString());
          }
       }
/// <summary>
/// true if this is a pop-up/context menu. defaults to false.
/// </summary>
[MemberGroup("")]
public bool isPopup
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isPopup").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isPopup", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// (GuiCanvas, pos, title))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void attachToMenuBar(string canvasName, int pos, string title){

pInvokes.m_ts.fn_PopupMenu_attachToMenuBar(_ID, canvasName, pos, title);
}
/// <summary>
/// (pos, checked))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void checkItem(int pos, bool checkedx){

pInvokes.m_ts.fn_PopupMenu_checkItem(_ID, pos, checkedx);
}
/// <summary>
/// (firstPos, lastPos, checkPos))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void checkRadioItem(int firstPos, int lastPos, int checkPos){

pInvokes.m_ts.fn_PopupMenu_checkRadioItem(_ID, firstPos, lastPos, checkPos);
}
/// <summary>
/// (pos, enabled))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void enableItem(int pos, bool enabled){

pInvokes.m_ts.fn_PopupMenu_enableItem(_ID, pos, enabled);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getItemCount(){

return pInvokes.m_ts.fn_PopupMenu_getItemCount(_ID);
}
/// <summary>
/// , ), (pos[, title][, accelerator]))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int insertItem(int pos, string title = "", string accelerator = ""){

return pInvokes.m_ts.fn_PopupMenu_insertItem(_ID, pos, title, accelerator);
}
/// <summary>
/// (pos, title, subMenu))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int insertSubMenu(int pos, string title, string subMenu){

return pInvokes.m_ts.fn_PopupMenu_insertSubMenu(_ID, pos, title, subMenu);
}
/// <summary>
/// (pos))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isItemChecked(int pos){

return pInvokes.m_ts.fn_PopupMenu_isItemChecked(_ID, pos);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeFromMenuBar(){

pInvokes.m_ts.fn_PopupMenu_removeFromMenuBar(_ID);
}
/// <summary>
/// (pos))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeItem(int pos){

pInvokes.m_ts.fn_PopupMenu_removeItem(_ID, pos);
}
/// <summary>
/// ), (pos, title[, accelerator]))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setItem(int pos, string title, string accelerator = ""){

return pInvokes.m_ts.fn_PopupMenu_setItem(_ID, pos, title, accelerator);
}
/// <summary>
/// (Canvas,[x, y]))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void showPopup(string canvasName, int x = -1, int y = -1){

pInvokes.m_ts.fn_PopupMenu_showPopup(_ID, canvasName, x, y);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemove(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMenuSelect(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemoveFromMenuBar(string canvas){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAttachToMenuBar(string canvas, string pos, string title){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  bool onMessageReceived(string queue, string eventx, string data){return "0".AsBool();}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  bool onSelectItem(int pos, string text){return "0".AsBool();}

#endregion
public PopupMenu_Base (){}
}}
