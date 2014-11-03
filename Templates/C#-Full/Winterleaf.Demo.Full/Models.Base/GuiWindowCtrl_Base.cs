


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiWindowCtrl_Base>))]
    public partial class GuiWindowCtrl_Base: GuiContainer
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiWindowCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiWindowCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiWindowCtrl_Base ts)
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
        public static implicit operator GuiWindowCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiWindowCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiWindowCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiWindowCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiWindowCtrl_Base(int simobjectid)
            {
            return  (GuiWindowCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiWindowCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiWindowCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiWindowCtrl_Base(uint simobjectid)
            {
            return  (GuiWindowCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiWindowCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Whether the window can be poped out.
/// </summary>
[MemberGroup("PopOut")]
public bool AllowPopWindow
       {
       get
          {
          return Omni.self.GetVar(_ID + ".AllowPopWindow").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".AllowPopWindow", value.AsString());
          }
       }
/// <summary>
/// Whether the window has a close button. 
/// </summary>
[MemberGroup("Window")]
public bool canClose
       {
       get
          {
          return Omni.self.GetVar(_ID + ".canClose").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".canClose", value.AsString());
          }
       }
/// <summary>
/// Whether the window can be collapsed by clicking its title bar. 
/// </summary>
[MemberGroup("Window")]
public bool canCollapse
       {
       get
          {
          return Omni.self.GetVar(_ID + ".canCollapse").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".canCollapse", value.AsString());
          }
       }
/// <summary>
/// Whether the window has a maximize button. 
/// </summary>
[MemberGroup("Window")]
public bool canMaximize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".canMaximize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".canMaximize", value.AsString());
          }
       }
/// <summary>
/// Whether the window has a minimize button. 
/// </summary>
[MemberGroup("Window")]
public bool canMinimize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".canMinimize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".canMinimize", value.AsString());
          }
       }
/// <summary>
/// Whether the window can be moved by dragging its titlebar. 
/// </summary>
[MemberGroup("Window")]
public bool canMove
       {
       get
          {
          return Omni.self.GetVar(_ID + ".canMove").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".canMove", value.AsString());
          }
       }
/// <summary>
/// Script code to execute when the window is closed. 
/// </summary>
[MemberGroup("Window")]
public String closeCommand
       {
       get
          {
          return Omni.self.GetVar(_ID + ".closeCommand").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".closeCommand", value.AsString());
          }
       }
/// <summary>
/// If true, the window will snap to the edges of other windows when moved close to them. 
/// </summary>
[MemberGroup("Window")]
public bool edgeSnap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".edgeSnap").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".edgeSnap", value.AsString());
          }
       }
/// <summary>
/// If the windowctrl is being shown on own canvas
/// </summary>
[MemberGroup("PopOut")]
public bool isInPopup
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isInPopup").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isInPopup", value.AsString());
          }
       }
/// <summary>
/// Whether the window can be resized vertically. 
/// </summary>
[MemberGroup("Window")]
public bool resizeHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".resizeHeight").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".resizeHeight", value.AsString());
          }
       }
/// <summary>
/// Whether the window can be resized horizontally. 
/// </summary>
[MemberGroup("Window")]
public bool resizeWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".resizeWidth").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".resizeWidth", value.AsString());
          }
       }
/// <summary>
/// Allows the user to set the title of the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool setTitle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".setTitle").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".setTitle", value.AsString());
          }
       }
/// <summary>
/// Whether the Title Ctrl will show. 
/// </summary>
[MemberGroup("PopOut")]
public bool ShowTitle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ShowTitle").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ShowTitle", value.AsString());
          }
       }
/// <summary>
/// Text label to display in titlebar. 
/// </summary>
[MemberGroup("Window")]
public String text
       {
       get
          {
          return Omni.self.GetVar(_ID + ".text").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".text", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void attachTo(string window){

pInvokes.m_ts.fnGuiWindowCtrl_attachTo(_ID, window);
}
/// <summary>
/// Puts the guiwindow back on the main canvas. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void ClosePopOut(){

pInvokes.m_ts.fnGuiWindowCtrl_ClosePopOut(_ID);
}
/// <summary>
/// Returns the title of the window. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getWindowTitle(){

return pInvokes.m_ts.fnGuiWindowCtrl_getWindowTitle(_ID);
}
/// <summary>
/// Returns if the title can be set or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isTitleSet(){

return pInvokes.m_ts.fnGuiWindowCtrl_isTitleSet(_ID);
}
/// <summary>
/// Puts the guiwindow on a new canvas. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void OpenPopOut(){

pInvokes.m_ts.fnGuiWindowCtrl_OpenPopOut(_ID);
}
/// <summary>
/// Bring the window to the front. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectWindow(){

pInvokes.m_ts.fnGuiWindowCtrl_selectWindow(_ID);
}
/// <summary>
/// Set the window's collapsing state. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCollapseGroup(bool state){

pInvokes.m_ts.fnGuiWindowCtrl_setCollapseGroup(_ID, state);
}
/// <summary>
/// Displays the option to set the title of the window. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextTitle(bool title){

pInvokes.m_ts.fnGuiWindowCtrl_setContextTitle(_ID, title);
}
/// <summary>
/// Sets the title of the window. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setWindowTitle(string title){

pInvokes.m_ts.fnGuiWindowCtrl_setWindowTitle(_ID, title);
}
/// <summary>
/// Toggle the window collapsing. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggleCollapseGroup(){

pInvokes.m_ts.fnGuiWindowCtrl_toggleCollapseGroup(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the close button has been pressed. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onClose(){}

        /// <summary>
        /// Called when the window has been minimized. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMinimize(){}

        /// <summary>
        /// Called when the window has been maximized. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMaximize(){}

        /// <summary>
        /// Called when the window is collapsed by clicking its title bar. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onCollapse(){}

        /// <summary>
        /// Called when the window is restored from minimized, maximized, or collapsed state. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRestore(){}

        /// <summary>
        /// When the canvas the window is on loses focus)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLoseFocus(){}

        /// <summary>
        /// When the canvas the window is on loses focus)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onGainFocus(){}

        /// <summary>
        /// Called when the window is Popped out of the main canvas. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPopWindow(){}

        /// <summary>
        /// Called when the window is Popped back into the main canvas. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPopWindowClosed(){}

#endregion
public GuiWindowCtrl_Base (){}
}}
