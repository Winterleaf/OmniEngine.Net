


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiScrollCtrl_Base>))]
    public partial class GuiScrollCtrl_Base: GuiContainer
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiScrollCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiScrollCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiScrollCtrl_Base ts)
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
        public static implicit operator GuiScrollCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiScrollCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiScrollCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiScrollCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiScrollCtrl_Base(int simobjectid)
            {
            return  (GuiScrollCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiScrollCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiScrollCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiScrollCtrl_Base(uint simobjectid)
            {
            return  (GuiScrollCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiScrollCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Padding region to put around child contents. 
/// </summary>
[MemberGroup("Scolling")]
public Point2I childMargin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".childMargin").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".childMargin", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Scolling")]
public bool constantThumbHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".constantThumbHeight").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".constantThumbHeight", value.AsString());
          }
       }
/// <summary>
/// When to display the horizontal scrollbar.
/// </summary>
[MemberGroup("Scolling")]
public TypeGuiScrollBarBehavior hScrollBar
       {
       get
          {          return (TypeGuiScrollBarBehavior) Omni.self.GetVar(_ID + ".hScrollBar");
          }
       set
          {
          Omni.self.SetVar(_ID + ".hScrollBar", value.ToString());
          }
       }
/// <summary>
/// Horizontal scrolling not allowed if set.
/// </summary>
[MemberGroup("Scolling")]
public bool lockHorizScroll
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lockHorizScroll").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lockHorizScroll", value.AsString());
          }
       }
/// <summary>
/// Vertical scrolling not allowed if set.
/// </summary>
[MemberGroup("Scolling")]
public bool lockVertScroll
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lockVertScroll").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lockVertScroll", value.AsString());
          }
       }
/// <summary>
/// Pixels/Tick - if not positive then mousewheel scrolling occurs instantly (like other scrolling).
/// </summary>
[MemberGroup("Scolling")]
public int mouseWheelScrollSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mouseWheelScrollSpeed").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mouseWheelScrollSpeed", value.AsString());
          }
       }
/// <summary>
/// When to display the vertical scrollbar.
/// </summary>
[MemberGroup("Scolling")]
public TypeGuiScrollBarBehavior vScrollBar
       {
       get
          {          return (TypeGuiScrollBarBehavior) Omni.self.GetVar(_ID + ".vScrollBar");
          }
       set
          {
          Omni.self.SetVar(_ID + ".vScrollBar", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Scolling")]
public bool willFirstRespond
       {
       get
          {
          return Omni.self.GetVar(_ID + ".willFirstRespond").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".willFirstRespond", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Refresh sizing and positioning of child controls. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void computeSizes(){

pInvokes.m_ts.fnGuiScrollCtrl_computeSizes(_ID);
}
/// <summary>
/// Get the current coordinates of the scrolled content.
///    @return The current position of the scrolled content. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getScrollPosition(){

return new Point2I ( pInvokes.m_ts.fnGuiScrollCtrl_getScrollPosition(_ID));
}
/// <summary>
/// Get the current X coordinate of the scrolled content.
///    @return The current X coordinate of the scrolled content. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getScrollPositionX(){

return pInvokes.m_ts.fnGuiScrollCtrl_getScrollPositionX(_ID);
}
/// <summary>
/// Get the current Y coordinate of the scrolled content.
///    @return The current Y coordinate of the scrolled content. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getScrollPositionY(){

return pInvokes.m_ts.fnGuiScrollCtrl_getScrollPositionY(_ID);
}
/// <summary>
/// Scroll all the way to the bottom of the vertical scrollbar and the left of the horizontal bar. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void scrollToBottom(){

pInvokes.m_ts.fnGuiScrollCtrl_scrollToBottom(_ID);
}
/// <summary>
/// Scroll the control so that the given child @a control is visible.
///    @param control A child control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void scrollToObject(string control){

pInvokes.m_ts.fnGuiScrollCtrl_scrollToObject(_ID, control);
}
/// <summary>
/// Scroll all the way to the top of the vertical and left of the horizontal scrollbar. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void scrollToTop(){

pInvokes.m_ts.fnGuiScrollCtrl_scrollToTop(_ID);
}
/// <summary>
/// Set the position of the scrolled content.
///    @param x Position on X axis.
///    @param y Position on y axis. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setScrollPosition(int x, int y){

pInvokes.m_ts.fnGuiScrollCtrl_setScrollPosition(_ID, x, y);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called each time the child controls are scrolled by some amount. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onScroll(){}

#endregion
public GuiScrollCtrl_Base (){}
}}
