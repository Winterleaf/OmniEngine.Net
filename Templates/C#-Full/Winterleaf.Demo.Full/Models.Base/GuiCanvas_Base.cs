


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiCanvas_Base>))]
    public partial class GuiCanvas_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiCanvas_Base ts, string simobjectid)
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
        public static bool operator !=(GuiCanvas_Base ts, string simobjectid)
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
        public static implicit operator string( GuiCanvas_Base ts)
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
        public static implicit operator GuiCanvas_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiCanvas_Base) Omni.self.getSimObject(simobjectid,typeof(GuiCanvas_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiCanvas_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiCanvas_Base(int simobjectid)
            {
            return  (GuiCanvas) Omni.self.getSimObject((uint)simobjectid,typeof(GuiCanvas_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiCanvas_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiCanvas_Base(uint simobjectid)
            {
            return  (GuiCanvas_Base) Omni.self.getSimObject(simobjectid,typeof(GuiCanvas_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Deal with mouse buttons, even if the cursor is hidden. 
/// </summary>
[MemberGroup("Mouse Handling")]
public bool alwaysHandleMouseButtons
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alwaysHandleMouseButtons").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alwaysHandleMouseButtons", value.AsString());
          }
       }
/// <summary>
/// The number of GFX fences to use. 
/// </summary>
[MemberGroup("Canvas Rendering")]
public int numFences
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numFences").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numFences", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// () - Is this canvas currently fullscreen? )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isFullscreen(){

return pInvokes.m_ts.fn_GuiCanvas_isFullscreen(_ID);
}
/// <summary>
/// () )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isMaximized(){

return pInvokes.m_ts.fn_GuiCanvas_isMaximized(_ID);
}
/// <summary>
/// () )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isMinimized(){

return pInvokes.m_ts.fn_GuiCanvas_isMinimized(_ID);
}
/// <summary>
/// () - maximize this canvas' window. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void maximizeWindow(){

pInvokes.m_ts.fn_GuiCanvas_maximizeWindow(_ID);
}
/// <summary>
/// () - minimize this canvas' window. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void minimizeWindow(){

pInvokes.m_ts.fn_GuiCanvas_minimizeWindow(_ID);
}
/// <summary>
/// (GuiControl ctrl=NULL)
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void popDialog(string gui){

pInvokes.m_ts.fn_GuiCanvas_popDialog(_ID, gui);
}
/// <summary>
/// (int layer) 
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void popLayer(int layer = 0){

pInvokes.m_ts.fn_GuiCanvas_popLayer(_ID, layer);
}
/// <summary>
/// (GuiControl ctrl, int layer=0, bool center=false)
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pushDialog(string ctrlName, int layer = 0, bool center = false){

pInvokes.m_ts.fn_GuiCanvas_pushDialog(_ID, ctrlName, layer, center);
}
/// <summary>
/// () - restore this canvas' window. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void restoreWindow(){

pInvokes.m_ts.fn_GuiCanvas_restoreWindow(_ID);
}
/// <summary>
/// (Point2I pos)
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCursorPos(Point2I pos){

pInvokes.m_ts.fn_GuiCanvas_setCursorPos(_ID, pos.AsString());
}
/// <summary>
/// () - Claim OS input focus for this canvas' window.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFocus(){

pInvokes.m_ts.fn_GuiCanvas_setFocus(_ID);
}
/// <summary>
/// (int width, int height, bool fullscreen, [int bitDepth], [int refreshRate], [int antialiasLevel] )
///                Change the video mode of this canvas. This method has the side effect of setting the $pref::Video::mode to the new values.
///                \\param width The screen width to set.
///                \\param height The screen height to set.
///                \\param fullscreen Specify true to run fullscreen or false to run in a window
///                \\param bitDepth [optional] The desired bit-depth. Defaults to the current setting. This parameter is ignored if you are running in a window.
///                \\param refreshRate [optional] The desired refresh rate. Defaults to the current setting. This parameter is ignored if you are running in a window
/// 					\\param antialiasLevel [optional] The level of anti-aliasing to apply 0 = none )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setVideoMode(uint width, uint height, bool fullscreen = false, uint bitDepth = 0, uint refreshRate = 0, uint antialiasLevel = 0){

pInvokes.m_ts.fn_GuiCanvas_setVideoMode(_ID, width, height, fullscreen, bitDepth, refreshRate, antialiasLevel);
}
/// <summary>
/// Translate a coordinate from canvas window-space to screen-space.
///    @param coordinate The coordinate in window-space.
///    @return The given coordinate translated to screen-space. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I clientToScreen(Point2I coordinate){

return new Point2I ( pInvokes.m_ts.fnGuiCanvas_clientToScreen(_ID, coordinate.AsString()));
}
/// <summary>
/// @brief Turns on the mouse off.
/// 				   @tsexample
/// 				   Canvas.cursorOff();
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void cursorOff(){

pInvokes.m_ts.fnGuiCanvas_cursorOff(_ID);
}
/// <summary>
/// @brief Turns on the mouse cursor.
/// 				   @tsexample
/// 				   Canvas.cursorOn();
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void cursorOn(){

pInvokes.m_ts.fnGuiCanvas_cursorOn(_ID);
}
/// <summary>
/// @brief Find the first monitor index that matches the given name.
///                The actual match algorithm depends on the implementation.
///                @param name The name to search for.
/// 				   @return The number of monitors attached to the system, including the default monoitor.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int findFirstMatchingMonitor(string name){

return pInvokes.m_ts.fnGuiCanvas_findFirstMatchingMonitor(_ID, name);
}
/// <summary>
/// @brief Get the GuiControl which is being used as the content.
/// 
/// 				   @tsexample
/// 				   Canvas.getContent();
/// 				   @endtsexample
/// 
/// 				   @return ID of current content control)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getContent(){

return pInvokes.m_ts.fnGuiCanvas_getContent(_ID);
}
/// <summary>
/// @brief Get the current position of the cursor.
/// 				   @param param Description
/// 				   @tsexample
/// 				   %cursorPos = Canvas.getCursorPos();
/// 				   @endtsexample
/// 				   @return Screen coordinates of mouse cursor, in format \"X Y\")
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getCursorPos(){

return new Point2I ( pInvokes.m_ts.fnGuiCanvas_getCursorPos(_ID));
}
/// <summary>
/// @brief Returns the dimensions of the canvas
/// 
/// 				   @tsexample
/// 				   %extent = Canvas.getExtent();
/// 				   @endtsexample
/// 
/// 				   @return Width and height of canvas. Formatted as numerical values in a single string \"# #\")
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  Point2I getExtent(){

return new Point2I ( pInvokes.m_ts.fnGuiCanvas_getExtent(_ID));
}
/// <summary>
/// @brief Gets information on the specified mode of this device.
/// 				   @param modeId Index of the mode to get data from.
/// 				   @return A video mode string given an adapter and mode index.
/// 				   @see GuiCanvas::getVideoMode())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMode(int modeId){

return pInvokes.m_ts.fnGuiCanvas_getMode(_ID, modeId);
}
/// <summary>
/// @brief Gets the number of modes available on this device.
/// 
/// 				   @param param Description
/// 
/// 				   @tsexample
/// 				   %modeCount = Canvas.getModeCount()
/// 				   @endtsexample
/// 
/// 				   @return The number of video modes supported by the device)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getModeCount(){

return pInvokes.m_ts.fnGuiCanvas_getModeCount(_ID);
}
/// <summary>
/// @brief Gets the number of monitors attached to the system.
/// 
/// 				   @return The number of monitors attached to the system, including the default monoitor.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMonitorCount(){

return pInvokes.m_ts.fnGuiCanvas_getMonitorCount(_ID);
}
/// <summary>
/// @brief Gets the name of the requested monitor.
///                @param index The monitor index.
/// 				   @return The name of the requested monitor.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMonitorName(int index){

return pInvokes.m_ts.fnGuiCanvas_getMonitorName(_ID, index);
}
/// <summary>
/// @brief Gets the region of the requested monitor.
///                @param index The monitor index.
/// 				   @return The rectangular region of the requested monitor.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  RectI getMonitorRect(int index){

return new RectI ( pInvokes.m_ts.fnGuiCanvas_getMonitorRect(_ID, index));
}
/// <summary>
/// @brief Gets the gui control under the mouse.
/// 				   @tsexample
/// 				   %underMouse = Canvas.getMouseControl();
/// 				   @endtsexample
/// 
/// 				   @return ID of the gui control, if one was found. NULL otherwise)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMouseControl(){

return pInvokes.m_ts.fnGuiCanvas_getMouseControl(_ID);
}
/// <summary>
/// @brief Gets the current screen mode as a string.
/// 
/// 				   The return string will contain 5 values (width, height, fullscreen, bitdepth, refreshRate). 
/// 				   You will need to parse out each one for individual use.
/// 
/// 				   @tsexample
/// 				   %screenWidth = getWord(Canvas.getVideoMode(), 0);
/// 				   %screenHeight = getWord(Canvas.getVideoMode(), 1);
/// 				   %isFullscreen = getWord(Canvas.getVideoMode(), 2);
/// 				   %bitdepth = getWord(Canvas.getVideoMode(), 3);
/// 				   %refreshRate = getWord(Canvas.getVideoMode(), 4);
/// 				   @endtsexample
/// 
/// 				   @return String formatted with screen width, screen height, screen mode, bit depth, and refresh rate.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getVideoMode(){

return pInvokes.m_ts.fnGuiCanvas_getVideoMode(_ID);
}
/// <summary>
/// Get the current position of the platform window associated with the canvas.
///    @return The window position of the canvas in screen-space. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getWindowPosition(){

return new Point2I ( pInvokes.m_ts.fnGuiCanvas_getWindowPosition(_ID));
}
/// <summary>
/// @brief Disable rendering of the cursor.
/// 
/// 				   @tsexample
/// 				   Canvas.hideCursor();
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void hideCursor(){

pInvokes.m_ts.fnGuiCanvas_hideCursor(_ID);
}
/// <summary>
/// ( GuiCanvas, hideWindow, void, 2, 2,  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void hideWindow(){

pInvokes.m_ts.fnGuiCanvas_hideWindow(_ID);
}
/// <summary>
/// @brief Determines if mouse cursor is enabled.
/// 
/// 				   @tsexample
/// 				   // Is cursor on?
/// 				   if(Canvas.isCursorOn())
/// 				   	echo(\"Canvas cursor is on\");
/// 				   @endtsexample
/// 				   @return Returns true if the cursor is on.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isCursorOn(){

return pInvokes.m_ts.fnGuiCanvas_isCursorOn(_ID);
}
/// <summary>
/// @brief Determines if mouse cursor is rendering.
/// 
/// 				   @tsexample
/// 				   // Is cursor rendering?
/// 				   if(Canvas.isCursorShown())
/// 				   	echo(\"Canvas cursor is rendering\");
/// 				   @endtsexample
/// 				   @return Returns true if the cursor is rendering.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isCursorShown(){

return pInvokes.m_ts.fnGuiCanvas_isCursorShown(_ID);
}
/// <summary>
/// @brief This turns on/off front-buffer rendering.
/// 
/// 				   @param enable True if all rendering should be done to the front buffer
/// 
/// 				   @tsexample
/// 				   Canvas.renderFront(false);
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void renderFront(bool enable){

pInvokes.m_ts.fnGuiCanvas_renderFront(_ID, enable);
}
/// <summary>
/// @brief Force canvas to redraw.
///                If the elapsed time is greater than the time since the last paint 
///                then the repaint will be skipped.
///                @param elapsedMS The optional elapsed time in milliseconds.
/// 
/// 				   @tsexample
/// 				   Canvas.repaint();
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void repaint(int elapsedMS = 0){

pInvokes.m_ts.fnGuiCanvas_repaint(_ID, elapsedMS);
}
/// <summary>
/// @brief Reset the update regions for the canvas.
/// 
/// 				   @tsexample
/// 				   Canvas.reset();
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reset(){

pInvokes.m_ts.fnGuiCanvas_reset(_ID);
}
/// <summary>
/// Translate a coordinate from screen-space to canvas window-space.
///    @param coordinate The coordinate in screen-space.
///    @return The given coordinate translated to window-space. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I screenToClient(Point2I coordinate){

return new Point2I ( pInvokes.m_ts.fnGuiCanvas_screenToClient(_ID, coordinate.AsString()));
}
/// <summary>
/// @brief Set the content of the canvas to a specified control.
/// 
/// 				   @param ctrl ID or name of GuiControl to set content to
/// 
/// 				   @tsexample
/// 				   Canvas.setContent(PlayGui);
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContent(string ctrl){

pInvokes.m_ts.fnGuiCanvas_setContent(_ID, ctrl);
}
/// <summary>
/// @brief Sets the cursor for the canvas.
/// 
/// 				   @param cursor Name of the GuiCursor to use
/// 
/// 				   @tsexample
/// 				   Canvas.setCursor(\"DefaultCursor\");
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCursor(string cursor){

pInvokes.m_ts.fnGuiCanvas_setCursor(_ID, cursor);
}
/// <summary>
/// (bool shown) - Enabled when a context menu/popup menu is shown.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPopupShown(bool shown){

pInvokes.m_ts.fnGuiCanvas_setPopupShown(_ID, shown);
}
/// <summary>
/// Set the position of the platform window associated with the canvas.
///    @param position The new position of the window in screen-space. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setWindowPosition(Point2I position){

pInvokes.m_ts.fnGuiCanvas_setWindowPosition(_ID, position.AsString());
}
/// <summary>
/// @brief Change the title of the OS window.
/// 
/// 				   @param newTitle String containing the new name
/// 
/// 				   @tsexample
/// 				   Canvas.setWindowTitle(\"Documentation Rocks!\");
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setWindowTitle(string newTitle){

pInvokes.m_ts.fnGuiCanvas_setWindowTitle(_ID, newTitle);
}
/// <summary>
/// @brief Enable rendering of the cursor.
/// 
/// 				   @tsexample
/// 				   Canvas.showCursor();
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void showCursor(){

pInvokes.m_ts.fnGuiCanvas_showCursor(_ID);
}
/// <summary>
/// ( GuiCanvas, showWindow, void, 2, 2,  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void showWindow(){

pInvokes.m_ts.fnGuiCanvas_showWindow(_ID);
}
/// <summary>
/// @brief toggle canvas from fullscreen to windowed mode or back.
/// 
/// 				   @tsexample
/// 				   // If we are in windowed mode, the following will put is in fullscreen
/// 				   Canvas.toggleFullscreen();
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggleFullscreen(){

pInvokes.m_ts.fnGuiCanvas_toggleFullscreen(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onResize(string width, string height){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onCreateMenu(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDestroyMenu(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLoseFocus(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onGainFocus(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onWindowClose(){}

#endregion
public GuiCanvas_Base (){}
}}
