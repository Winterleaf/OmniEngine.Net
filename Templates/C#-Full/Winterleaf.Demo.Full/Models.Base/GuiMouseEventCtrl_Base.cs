


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiMouseEventCtrl_Base>))]
    public partial class GuiMouseEventCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiMouseEventCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiMouseEventCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiMouseEventCtrl_Base ts)
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
        public static implicit operator GuiMouseEventCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiMouseEventCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMouseEventCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiMouseEventCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiMouseEventCtrl_Base(int simobjectid)
            {
            return  (GuiMouseEventCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiMouseEventCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiMouseEventCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiMouseEventCtrl_Base(uint simobjectid)
            {
            return  (GuiMouseEventCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMouseEventCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Whether the control should lock the mouse between up and down button events. 
/// </summary>
[MemberGroup("Input")]
public bool lockMouse
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lockMouse").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lockMouse", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Callback that occurs whenever the mouse is pressed down while in this control.   @param modifier Key that was pressed during this callback. Values are:    $EventModifier::RSHIFT   $EventModifier::SHIFT   $EventModifier::LCTRL   $EventModifier::RCTRL   $EventModifier::CTRL   $EventModifier::CTRL   $EventModifier::RALT   $EventModifier::ALT   @param mousePoint X/Y location of the mouse point   @param mouseClickCount How many mouse clicks have occured for this event   @tsexample   // Mouse was pressed down in this control, causing the callback   GuiMouseEventCtrl::onMouseDown(%this,%modifier,%mousePoint,%mouseClickCount)   {   	// Code to call when a mouse event occurs.   }   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseDown(byte modifier, Point2I mousePoint, byte mouseClickCount){}

        /// <summary>
        /// @brief Callback that occurs whenever the mouse is released while in this control.   @param modifier Key that was pressed during this callback. Values are:    $EventModifier::RSHIFT   $EventModifier::SHIFT   $EventModifier::LCTRL   $EventModifier::RCTRL   $EventModifier::CTRL   $EventModifier::CTRL   $EventModifier::RALT   $EventModifier::ALT   @param mousePoint X/Y location of the mouse point   @param mouseClickCount How many mouse clicks have occured for this event   @tsexample   // Mouse was released in this control, causing the callback   GuiMouseEventCtrl::onMouseUp(%this,%modifier,%mousePoint,%mouseClickCount)   {   	// Code to call when a mouse event occurs.   }   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseUp(byte modifier, Point2I mousePoint, byte mouseClickCount){}

        /// <summary>
        /// @brief Callback that occurs whenever the mouse is moved (without dragging) while in this control.   @param modifier Key that was pressed during this callback. Values are:    $EventModifier::RSHIFT   $EventModifier::SHIFT   $EventModifier::LCTRL   $EventModifier::RCTRL   $EventModifier::CTRL   $EventModifier::CTRL   $EventModifier::RALT   $EventModifier::ALT   @param mousePoint X/Y location of the mouse point   @param mouseClickCount How many mouse clicks have occured for this event   @tsexample   // Mouse was moved in this control, causing the callback   GuiMouseEventCtrl::onMouseMove(%this,%modifier,%mousePoint,%mouseClickCount)   {   	// Code to call when a mouse event occurs.   }   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseMove(byte modifier, Point2I mousePoint, byte mouseClickCount){}

        /// <summary>
        /// @brief Callback that occurs whenever the mouse is dragged while in this control.   @param modifier Key that was pressed during this callback. Values are:    $EventModifier::RSHIFT   $EventModifier::SHIFT   $EventModifier::LCTRL   $EventModifier::RCTRL   $EventModifier::CTRL   $EventModifier::CTRL   $EventModifier::RALT   $EventModifier::ALT   @param mousePoint X/Y location of the mouse point   @param mouseClickCount How many mouse clicks have occured for this event   @tsexample   // Mouse was dragged in this control, causing the callback   GuiMouseEventCtrl::onMouseDragged(%this,%modifier,%mousePoint,%mouseClickCount)   {   	// Code to call when a mouse event occurs.   }   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseDragged(byte modifier, Point2I mousePoint, byte mouseClickCount){}

        /// <summary>
        /// @brief Callback that occurs whenever the mouse enters this control.   @param modifier Key that was pressed during this callback. Values are:    $EventModifier::RSHIFT   $EventModifier::SHIFT   $EventModifier::LCTRL   $EventModifier::RCTRL   $EventModifier::CTRL   $EventModifier::CTRL   $EventModifier::RALT   $EventModifier::ALT   @param mousePoint X/Y location of the mouse point   @param mouseClickCount How many mouse clicks have occured for this event   @tsexample   // Mouse entered this control, causing the callback   GuiMouseEventCtrl::onMouseEnter(%this,%modifier,%mousePoint,%mouseClickCount)   {   	// Code to call when a mouse event occurs.   }   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseEnter(byte modifier, Point2I mousePoint, byte mouseClickCount){}

        /// <summary>
        /// @brief Callback that occurs whenever the mouse leaves this control.   @param modifier Key that was pressed during this callback. Values are:    $EventModifier::RSHIFT   $EventModifier::SHIFT   $EventModifier::LCTRL   $EventModifier::RCTRL   $EventModifier::CTRL   $EventModifier::CTRL   $EventModifier::RALT   $EventModifier::ALT   @param mousePoint X/Y location of the mouse point   @param mouseClickCount How many mouse clicks have occured for this event   @tsexample   // Mouse left this control, causing the callback   GuiMouseEventCtrl::onMouseLeave(%this,%modifier,%mousePoint,%mouseClickCount)   {   	// Code to call when a mouse event occurs.   }   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseLeave(byte modifier, Point2I mousePoint, byte mouseClickCount){}

        /// <summary>
        /// @brief Callback that occurs whenever the right mouse button is pressed while in this control.   @param modifier Key that was pressed during this callback. Values are:    $EventModifier::RSHIFT   $EventModifier::SHIFT   $EventModifier::LCTRL   $EventModifier::RCTRL   $EventModifier::CTRL   $EventModifier::CTRL   $EventModifier::RALT   $EventModifier::ALT   @param mousePoint X/Y location of the mouse point   @param mouseClickCount How many mouse clicks have occured for this event   @tsexample   // Right mouse button was pressed in this control, causing the callback   GuiMouseEventCtrl::onRightMouseDown(%this,%modifier,%mousePoint,%mouseClickCount)   {   	// Code to call when a mouse event occurs.   }   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRightMouseDown(byte modifier, Point2I mousePoint, byte mouseClickCount){}

        /// <summary>
        /// @brief Callback that occurs whenever the right mouse button is released while in this control.   @param modifier Key that was pressed during this callback. Values are:    $EventModifier::RSHIFT   $EventModifier::SHIFT   $EventModifier::LCTRL   $EventModifier::RCTRL   $EventModifier::CTRL   $EventModifier::CTRL   $EventModifier::RALT   $EventModifier::ALT   @param mousePoint X/Y location of the mouse point   @param mouseClickCount How many mouse clicks have occured for this event   @tsexample   // Right mouse button was released in this control, causing the callback   GuiMouseEventCtrl::onRightMouseUp(%this,%modifier,%mousePoint,%mouseClickCount)   {   	// Code to call when a mouse event occurs.   }   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRightMouseUp(byte modifier, Point2I mousePoint, byte mouseClickCount){}

        /// <summary>
        /// @brief Callback that occurs whenever the mouse is dragged in this control while the right mouse button is pressed.   @param modifier Key that was pressed during this callback. Values are:    $EventModifier::RSHIFT   $EventModifier::SHIFT   $EventModifier::LCTRL   $EventModifier::RCTRL   $EventModifier::CTRL   $EventModifier::CTRL   $EventModifier::RALT   $EventModifier::ALT   @param mousePoint X/Y location of the mouse point   @param mouseClickCount How many mouse clicks have occured for this event   @tsexample   // Right mouse button was dragged in this control, causing the callback   GuiMouseEventCtrl::onRightMouseDragged(%this,%modifier,%mousePoint,%mouseClickCount)   {   	// Code to call when a mouse event occurs.   }   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRightMouseDragged(byte modifier, Point2I mousePoint, byte mouseClickCount){}

#endregion
public GuiMouseEventCtrl_Base (){}
}}
