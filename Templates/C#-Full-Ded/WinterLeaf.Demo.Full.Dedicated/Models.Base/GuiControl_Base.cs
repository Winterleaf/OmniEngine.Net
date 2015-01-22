


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiControl_Base>))]
    public partial class GuiControl_Base: SimGroup
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiControl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiControl_Base ts)
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
        public static implicit operator GuiControl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiControl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiControl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiControl_Base(int simobjectid)
            {
            return  (GuiControl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiControl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiControl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiControl_Base(uint simobjectid)
            {
            return  (GuiControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiControl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Key combination that triggers the control's primary action when the control is on the canvas. 
/// </summary>
[MemberGroup("Control")]
public String accelerator
       {
       get
          {
          return Omni.self.GetVar(_ID + ".accelerator").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".accelerator", value.AsString());
          }
       }
/// <summary>
/// Whether the control is enabled for user interaction. 
/// </summary>
[MemberGroup("Control")]
public bool active
       {
       get
          {
          return Omni.self.GetVar(_ID + ".active").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".active", value.AsString());
          }
       }
/// <summary>
/// Allows the user to move the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool alpha
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alpha").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alpha", value.AsString());
          }
       }
/// <summary>
/// Allows the user to move the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool alphaFade
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alphaFade").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaFade", value.AsString());
          }
       }
/// <summary>
/// Sets the alpha fade time of the object.
/// </summary>
[MemberGroup("Editing")]
public int alphaFadeTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alphaFadeTime").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaFadeTime", value.AsString());
          }
       }
/// <summary>
/// Sets the alpha value of the object.
/// </summary>
[MemberGroup("Editing")]
public float alphaValue
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alphaValue").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaValue", value.AsString());
          }
       }
/// <summary>
/// Command to execute on the secondary action of the control.\n\n     @note Within this script snippet, the control on which the #altCommand is being executed is bound to       the global variable $ThisControl. 
/// </summary>
[MemberGroup("Control")]
public String altCommand
       {
       get
          {
          return Omni.self.GetVar(_ID + ".altCommand").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".altCommand", value.AsString());
          }
       }
/// <summary>
/// The background color for the control 
/// </summary>
[MemberGroup("Control")]
public ColorI backgroundColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".backgroundColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".backgroundColor", value.AsString());
          }
       }
/// <summary>
/// Command to execute on the primary action of the control.\n\n     @note Within this script snippet, the control on which the #command is being executed is bound to       the global variable $ThisControl. 
/// </summary>
[MemberGroup("Control")]
public String command
       {
       get
          {
          return Omni.self.GetVar(_ID + ".command").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".command", value.AsString());
          }
       }
/// <summary>
/// Allows the user to change the background color of the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool contextBackColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".contextBackColor").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".contextBackColor", value.AsString());
          }
       }
/// <summary>
/// Allows the user to change the fill/body color of the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool contextFillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".contextFillColor").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".contextFillColor", value.AsString());
          }
       }
/// <summary>
/// Allows the user to change the text color of the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool contextFontColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".contextFontColor").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".contextFontColor", value.AsString());
          }
       }
/// <summary>
/// Allows the user to change the font size of the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool contextFontSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".contextFontSize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".contextFontSize", value.AsString());
          }
       }
/// <summary>
/// The fill color of the control. 
/// </summary>
[MemberGroup("Control")]
public ColorI controlFillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".controlFillColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".controlFillColor", value.AsString());
          }
       }
/// <summary>
/// The font color of the control. 
/// </summary>
[MemberGroup("Control")]
public ColorI controlFontColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".controlFontColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".controlFontColor", value.AsString());
          }
       }
/// <summary>
/// Changes the font size of the control. 
/// </summary>
[MemberGroup("Control")]
public int controlFontSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".controlFontSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".controlFontSize", value.AsString());
          }
       }
/// <summary>
/// The width and height of the control. 
/// </summary>
[MemberGroup("Layout")]
public Point2I extent
       {
       get
          {
          return Omni.self.GetVar(_ID + ".extent").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".extent", value.AsString());
          }
       }
/// <summary>
/// The horizontal resizing behavior. 
/// </summary>
[MemberGroup("Layout")]
public TypeGuiHorizontalSizing horizSizing
       {
       get
          {          return (TypeGuiHorizontalSizing) Omni.self.GetVar(_ID + ".horizSizing");
          }
       set
          {
          Omni.self.SetVar(_ID + ".horizSizing", value.ToString());
          }
       }
/// <summary>
/// Time for mouse to hover over control until tooltip is shown (in milliseconds). 
/// </summary>
[MemberGroup("ToolTip")]
public int hovertime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hovertime").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hovertime", value.AsString());
          }
       }
/// <summary>
/// If true, the control may contain child controls. 
/// </summary>
[MemberGroup("Editing")]
public bool isContainer
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isContainer").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isContainer", value.AsString());
          }
       }
/// <summary>
/// Name of string table to use for lookup of internationalized text. 
/// </summary>
[MemberGroup("Localization")]
public String langTableMod
       {
       get
          {
          return Omni.self.GetVar(_ID + ".langTableMod").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".langTableMod", value.AsString());
          }
       }
/// <summary>
/// Allows the user to move the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool lockControl
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lockControl").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lockControl", value.AsString());
          }
       }
/// <summary>
/// The maximum width and height of the control. The control will not be resized bigger than this. 
/// </summary>
[MemberGroup("Layout")]
public Point2I maxExtent
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxExtent").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxExtent", value.AsString());
          }
       }
/// <summary>
/// The minimum width and height of the control. The control will not be resized smaller than this. 
/// </summary>
[MemberGroup("Layout")]
public Point2I minExtent
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minExtent").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minExtent", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Control")]
public String modal
       {
       get
          {
          return Omni.self.GetVar(_ID + ".modal").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".modal", value.AsString());
          }
       }
/// <summary>
/// Allows the user to move the control in the game.
/// </summary>
[MemberGroup("Context Menu Options")]
public bool mouseOverAlpha
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mouseOverAlpha").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mouseOverAlpha", value.AsString());
          }
       }
/// <summary>
/// Sets the alpha value of the object.
/// </summary>
[MemberGroup("Editing")]
public float mouseOverAlphaValue
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mouseOverAlphaValue").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mouseOverAlphaValue", value.AsString());
          }
       }
/// <summary>
/// Allows the user to move the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool moveControl
       {
       get
          {
          return Omni.self.GetVar(_ID + ".moveControl").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".moveControl", value.AsString());
          }
       }
/// <summary>
/// The position relative to the parent control. 
/// </summary>
[MemberGroup("Layout")]
public Point2I position
       {
       get
          {
          return Omni.self.GetVar(_ID + ".position").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".position", value.AsString());
          }
       }
/// <summary>
/// The control profile that determines fill styles, font settings, etc. 
/// </summary>
[MemberGroup("Control")]
public GuiControlProfile profile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".profile");
          }
       set
          {
          Omni.self.SetVar(_ID + ".profile", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Control")]
public String setFirstResponder
       {
       get
          {
          return Omni.self.GetVar(_ID + ".setFirstResponder").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".setFirstResponder", value.AsString());
          }
       }
/// <summary>
/// String to show in tooltip for this control. 
/// </summary>
[MemberGroup("ToolTip")]
public String tooltip
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tooltip").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tooltip", value.AsString());
          }
       }
/// <summary>
/// Control profile to use when rendering tooltips for this control. 
/// </summary>
[MemberGroup("ToolTip")]
public GuiControlProfile tooltipProfile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tooltipProfile");
          }
       set
          {
          Omni.self.SetVar(_ID + ".tooltipProfile", value.ToString());
          }
       }
/// <summary>
/// Name of the variable to which the value of this control will be synchronized. 
/// </summary>
[MemberGroup("Control")]
public String variable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".variable").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".variable", value.AsString());
          }
       }
/// <summary>
/// The vertical resizing behavior. 
/// </summary>
[MemberGroup("Layout")]
public TypeGuiVerticalSizing vertSizing
       {
       get
          {          return (TypeGuiVerticalSizing) Omni.self.GetVar(_ID + ".vertSizing");
          }
       set
          {
          Omni.self.SetVar(_ID + ".vertSizing", value.ToString());
          }
       }
/// <summary>
/// Whether the control is visible or hidden. 
/// </summary>
[MemberGroup("Control")]
public bool visible
       {
       get
          {
          return Omni.self.GetVar(_ID + ".visible").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".visible", value.AsString());
          }
       }
/// <summary>
/// Allows the user to move the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool windowSettings
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windowSettings").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windowSettings", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  RectI getBounds(){

return new RectI ( pInvokes.m_ts.fn_GuiControl_getBounds(_ID));
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getValue(){

return pInvokes.m_ts.fn_GuiControl_getValue(_ID);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isActive(){

return pInvokes.m_ts.fn_GuiControl_isActive(_ID);
}
/// <summary>
/// (bool isFirst))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void makeFirstResponder(bool isFirst){

pInvokes.m_ts.fn_GuiControl_makeFirstResponder(_ID, isFirst);
}
/// <summary>
///  Set the width and height of the control.
///    @hide )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setExtent(Point2F ext){

pInvokes.m_ts.fn_GuiControl_setExtent(_ID, ext.AsString());
}
/// <summary>
/// Add the given control as a child to this control.
///    This is synonymous to calling SimGroup::addObject.
///    @param control The control to add as a child.
///    @note The control will retain its current position and size.
///    @see SimGroup::addObject
///    @ref GuiControl_Hierarchy )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addGuiControl(string control){

pInvokes.m_ts.fnGuiControl_addGuiControl(_ID, control);
}
/// <summary>
/// Returns if the control's background color can be changed in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool canChangeContextBackColor(){

return pInvokes.m_ts.fnGuiControl_canChangeContextBackColor(_ID);
}
/// <summary>
/// Returns if the control's fill color can be changed in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool canChangeContextFillColor(){

return pInvokes.m_ts.fnGuiControl_canChangeContextFillColor(_ID);
}
/// <summary>
/// Returns if the control's font color can be changed in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool canChangeContextFontColor(){

return pInvokes.m_ts.fnGuiControl_canChangeContextFontColor(_ID);
}
/// <summary>
/// Returns if the control's font size can be changed in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool canChangeContextFontSize(){

return pInvokes.m_ts.fnGuiControl_canChangeContextFontSize(_ID);
}
/// <summary>
/// Returns if the control's window settings can be changed in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool canShowContextWindowSettings(){

return pInvokes.m_ts.fnGuiControl_canShowContextWindowSettings(_ID);
}
/// <summary>
/// Clear this control from being the first responder in its hierarchy chain.
///    @param ignored Ignored.  Supported for backwards-compatibility. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearFirstResponder(bool ignored = false){

pInvokes.m_ts.fnGuiControl_clearFirstResponder(_ID, ignored);
}
/// <summary>
/// Test whether the given control is a direct or indirect child to this control.
///    @param control The potential child control.
///    @return True if the given control is a direct or indirect child to this control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool controlIsChild(string control){

return pInvokes.m_ts.fnGuiControl_controlIsChild(_ID, control);
}
/// <summary>
/// Test whether the given control is a sibling of this control.
///    @param control The potential sibling control.
///    @return True if the given control is a sibling of this control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool controlIsSibling(string control){

return pInvokes.m_ts.fnGuiControl_controlIsSibling(_ID, control);
}
/// <summary>
/// Find the topmost child control located at the given coordinates.
///    @note Only children that are both visible and have the 'modal' flag set in their profile will be considered in the search.
///    @param x The X coordinate in the control's own coordinate space.
///    @param y The Y coordinate in the control's own coordinate space.
///    @return The topmost child control at the given coordintes or the control on which the method was called if no matching child could be found.
///    @see GuiControlProfile::modal
///    @see findHitControls )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string findHitControl(int x, int y){

return pInvokes.m_ts.fnGuiControl_findHitControl(_ID, x, y);
}
/// <summary>
/// Find all visible child controls that intersect with the given rectangle.
///    @note Invisible child controls will not be included in the search.
///    @param x The X coordinate of the rectangle's upper left corner in the control's own coordinate space.
///    @param y The Y coordinate of the rectangle's upper left corner in the control's own coordinate space.
///    @param width The width of the search rectangle in pixels.
///    @param height The height of the search rectangle in pixels.
///    @return A space-separated list of the IDs of all visible control objects intersecting the given rectangle.
///    @tsexample
///    // Lock all controls in the rectangle at x=10 and y=10 and the extent width=100 and height=100.
///    foreach$( %ctrl in %this.findHitControls( 10, 10, 100, 100 ) )
///       %ctrl.setLocked( true );
///    @endtsexample
///    @see findHitControl )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string findHitControls(int x, int y, int width, int height){

return pInvokes.m_ts.fnGuiControl_findHitControls(_ID, x, y, width, height);
}
/// <summary>
/// Get the alpha fade time for the object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getAlphaFadeTime(){

return pInvokes.m_ts.fnGuiControl_getAlphaFadeTime(_ID);
}
/// <summary>
/// Get the alpha for the object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getAlphaValue(){

return pInvokes.m_ts.fnGuiControl_getAlphaValue(_ID);
}
/// <summary>
/// Get the aspect ratio of the control's extents.
///    @return The width of the control divided by its height.
///    @see getExtent )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getAspect(){

return pInvokes.m_ts.fnGuiControl_getAspect(_ID);
}
/// <summary>
/// Get the coordinate of the control's center point relative to its parent.
///    @return The coordinate of the control's center point in parent-relative coordinates. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getCenter(){

return new Point2I ( pInvokes.m_ts.fnGuiControl_getCenter(_ID));
}
/// <summary>
/// Sets the font size of a control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getControlFontSize(){

return pInvokes.m_ts.fnGuiControl_getControlFontSize(_ID);
}
/// <summary>
/// Returns if the control is locked or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getControlLock(){

return pInvokes.m_ts.fnGuiControl_getControlLock(_ID);
}
/// <summary>
/// Returns the filename of the texture of the control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getControlTextureFile(){

return pInvokes.m_ts.fnGuiControl_getControlTextureFile(_ID);
}
/// <summary>
/// Get the width and height of the control.
///    @return A point structure containing the width of the control in x and the height in y. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getExtent(){

return new Point2I ( pInvokes.m_ts.fnGuiControl_getExtent(_ID));
}
/// <summary>
/// Get the first responder set on this GuiControl tree.
///    @return The first responder set on the control's subtree.
///    @see isFirstResponder
///    @see makeFirstResponder
///    @see setFirstResponder
///    @ref GuiControl_FirstResponders )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getFirstResponder(){

return pInvokes.m_ts.fnGuiControl_getFirstResponder(_ID);
}
/// <summary>
/// Get the coordinate of the control's center point in coordinates relative to the root control in its control hierarchy.
///    @Return the center coordinate of the control in root-relative coordinates. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getGlobalCenter(){

return new Point2I ( pInvokes.m_ts.fnGuiControl_getGlobalCenter(_ID));
}
/// <summary>
/// Get the position of the control relative to the root of the GuiControl hierarchy it is contained in.
///    @return The control's current position in root-relative coordinates. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getGlobalPosition(){

return new Point2I ( pInvokes.m_ts.fnGuiControl_getGlobalPosition(_ID));
}
/// <summary>
/// Get the maximum allowed size of the control.
///    @return The maximum size to which the control can be shrunk.
///    @see maxExtent )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getMaxExtent(){

return new Point2I ( pInvokes.m_ts.fnGuiControl_getMaxExtent(_ID));
}
/// <summary>
/// Get the minimum allowed size of the control.
///    @return The minimum size to which the control can be shrunk.
///    @see minExtent )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getMinExtent(){

return new Point2I ( pInvokes.m_ts.fnGuiControl_getMinExtent(_ID));
}
/// <summary>
/// Get the mouse over alpha for the object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getMouseOverAlphaValue(){

return pInvokes.m_ts.fnGuiControl_getMouseOverAlphaValue(_ID);
}
/// <summary>
/// Get the immediate parent control of the control.
///    @return The immediate parent GuiControl or 0 if the control is not parented to a GuiControl. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getParent(){

return pInvokes.m_ts.fnGuiControl_getParent(_ID);
}
/// <summary>
/// Get the control's current position relative to its parent.
///    @return The coordinate of the control in its parent's coordinate space. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getPosition(){

return new Point2I ( pInvokes.m_ts.fnGuiControl_getPosition(_ID));
}
/// <summary>
/// Get the canvas on which the control is placed.
///    @return The canvas on which the control's hierarchy is currently placed or 0 if the control is not currently placed on a GuiCanvas.
///    @see GuiControl_Hierarchy )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getRoot(){

return pInvokes.m_ts.fnGuiControl_getRoot(_ID);
}
/// <summary>
/// Get root control )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getRootControl(){

return pInvokes.m_ts.fnGuiControl_getRootControl(_ID);
}
/// <summary>
/// Test whether the control is currently awake.
///    If a control is awake it means that it is part of the GuiControl hierarchy of a GuiCanvas.
///    @return True if the control is awake.
///    @ref GuiControl_Waking )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isAwake(){

return pInvokes.m_ts.fnGuiControl_isAwake(_ID);
}
/// <summary>
/// Returns if the control's alpha value can be changed in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isContextAlphaEnabled(){

return pInvokes.m_ts.fnGuiControl_isContextAlphaEnabled(_ID);
}
/// <summary>
/// Returns if the control's alpha fade value can be changed in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isContextAlphaFadeEnabled(){

return pInvokes.m_ts.fnGuiControl_isContextAlphaFadeEnabled(_ID);
}
/// <summary>
/// Returns if the control can be locked in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isContextLockable(){

return pInvokes.m_ts.fnGuiControl_isContextLockable(_ID);
}
/// <summary>
/// Returns if the control's mouse-over alpha value can be changed in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isContextMouseOverAlphaEnabled(){

return pInvokes.m_ts.fnGuiControl_isContextMouseOverAlphaEnabled(_ID);
}
/// <summary>
/// Returns if the control can be moved in the game or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isContextMovable(){

return pInvokes.m_ts.fnGuiControl_isContextMovable(_ID);
}
/// <summary>
/// Test whether the control is the current first responder.
///    @return True if the control is the current first responder.
///    @see makeFirstResponder
///    @see setFirstResponder
///    @ref GuiControl_FirstResponders )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isFirstResponder(){

return pInvokes.m_ts.fnGuiControl_isFirstResponder(_ID);
}
/// <summary>
/// Indicates if the mouse is locked in this control.
///    @return True if the mouse is currently locked. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isMouseLocked(){

return pInvokes.m_ts.fnGuiControl_isMouseLocked(_ID);
}
/// <summary>
/// Test whether the control is currently set to be visible.
///    @return True if the control is currently set to be visible.
///    @note This method does not tell anything about whether the control is actually visible to 
///       the user at the moment.
///    @ref GuiControl_VisibleActive )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isVisible(){

return pInvokes.m_ts.fnGuiControl_isVisible(_ID);
}
/// <summary>
/// Test whether the given point lies within the rectangle of the control.
///    @param x X coordinate of the point in parent-relative coordinates.
///    @param y Y coordinate of the point in parent-relative coordinates.
///    @return True if the point is within the control, false if not.
///    @see getExtent
///    @see getPosition )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool pointInControl(int x, int y){

return pInvokes.m_ts.fnGuiControl_pointInControl(_ID, x, y);
}
/// <summary>
/// Recalculates the position and size of this control and all its children. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void refresh(){

pInvokes.m_ts.fnGuiControl_refresh(_ID);
}
/// <summary>
/// Removes the plus cursor.
///    @param ignored Ignored.  Supported for backwards-compatibility. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void resetCur(){

pInvokes.m_ts.fnGuiControl_resetCur(_ID);
}
/// <summary>
/// Resize and reposition the control using the give coordinates and dimensions.  Child controls 
///    will resize according to their layout behaviors.
///    @param x The new X coordinate of the control in its parent's coordinate space.
///    @param y The new Y coordinate of the control in its parent's coordinate space.
///    @param width The new width to which the control should be resized.
///    @param height The new height to which the control should be resized. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void resize(int x, int y, int width, int height){

pInvokes.m_ts.fnGuiControl_resize(_ID, x, y, width, height);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setActive(bool state = true){

pInvokes.m_ts.fnGuiControl_setActive(_ID, state);
}
/// <summary>
/// Set the alpha for the object.
///    @param value Range 0, 1 for the transparency. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAlphaFadeTime(int fadeTime = 1000){

pInvokes.m_ts.fnGuiControl_setAlphaFadeTime(_ID, fadeTime);
}
/// <summary>
/// Set the alpha for the object.
///    @param value Range 0, 1 for the transparency. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAlphaValue(float alpha = 1){

pInvokes.m_ts.fnGuiControl_setAlphaValue(_ID, alpha);
}
/// <summary>
/// Set the control's position by its center point.
///    @param x The X coordinate of the new center point of the control relative to the control's parent.
///    @param y The Y coordinate of the new center point of the control relative to the control's parent. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCenter(int x, int y){

pInvokes.m_ts.fnGuiControl_setCenter(_ID, x, y);
}
/// <summary>
/// Displays the option to set the alpha of the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextAlpha(bool alpha){

pInvokes.m_ts.fnGuiControl_setContextAlpha(_ID, alpha);
}
/// <summary>
/// Displays the option to set the alpha fade value of the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextAlphaFade(bool fade){

pInvokes.m_ts.fnGuiControl_setContextAlphaFade(_ID, fade);
}
/// <summary>
/// Displays the option to set the background color of the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextBackColor(bool backColor){

pInvokes.m_ts.fnGuiControl_setContextBackColor(_ID, backColor);
}
/// <summary>
/// Displays the option to set the fill color of the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextFillColor(bool fillColor){

pInvokes.m_ts.fnGuiControl_setContextFillColor(_ID, fillColor);
}
/// <summary>
/// Displays the option to set the font color of the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextFontColor(bool fontColor){

pInvokes.m_ts.fnGuiControl_setContextFontColor(_ID, fontColor);
}
/// <summary>
/// Displays the option to set the font size of the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextFontSize(bool fontSize){

pInvokes.m_ts.fnGuiControl_setContextFontSize(_ID, fontSize);
}
/// <summary>
/// Displays the option to lock the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextLockControl(bool lockx){

pInvokes.m_ts.fnGuiControl_setContextLockControl(_ID, lockx);
}
/// <summary>
/// Displays the option to set the mouse-over alpha of the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextMouseOverAlpha(bool mouseOver){

pInvokes.m_ts.fnGuiControl_setContextMouseOverAlpha(_ID, mouseOver);
}
/// <summary>
/// Displays the option to move the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setContextMoveControl(bool move){

pInvokes.m_ts.fnGuiControl_setContextMoveControl(_ID, move);
}
/// <summary>
/// Set control background color. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setControlBackgroundColor(ColorI color){

pInvokes.m_ts.fnGuiControl_setControlBackgroundColor(_ID, color.AsString());
}
/// <summary>
/// Set control fill color. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setControlFillColor(ColorI color){

pInvokes.m_ts.fnGuiControl_setControlFillColor(_ID, color.AsString());
}
/// <summary>
/// Set control font color. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setControlFontColor(ColorI color){

pInvokes.m_ts.fnGuiControl_setControlFontColor(_ID, color.AsString());
}
/// <summary>
/// Sets the font size of a control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setControlFontSize(int fontSize){

pInvokes.m_ts.fnGuiControl_setControlFontSize(_ID, fontSize);
}
/// <summary>
/// Lock the control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setControlLock(bool lockedx){

pInvokes.m_ts.fnGuiControl_setControlLock(_ID, lockedx);
}
/// <summary>
/// Set control texture. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setControlTexture(string fileName){

pInvokes.m_ts.fnGuiControl_setControlTexture(_ID, fileName);
}
/// <summary>
/// Sets the cursor as a plus.
///    @param ignored Ignored.  Supported for backwards-compatibility. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCur(){

pInvokes.m_ts.fnGuiControl_setCur(_ID);
}
/// <summary>
/// Make this control the current first responder.
///    @note Only controls with a profile that has canKeyFocus enabled are able to become first responders.
///    @see GuiControlProfile::canKeyFocus
///    @see isFirstResponder
///    @ref GuiControl_FirstResponders )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFirstResponderX(){

pInvokes.m_ts.fnGuiControl_setFirstResponder(_ID);
}
/// <summary>
/// Set the alpha for the object.
///    @param value Range 0, 1 for the transparency. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMouseOverAlphaValue(float alpha = 1){

pInvokes.m_ts.fnGuiControl_setMouseOverAlphaValue(_ID, alpha);
}
/// <summary>
/// Position the control in the local space of the parent control.
///    @param x The new X coordinate of the control relative to its parent's upper left corner.
///    @param y The new Y coordinate of the control relative to its parent's upper left corner. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPosition(int x, int y){

pInvokes.m_ts.fnGuiControl_setPosition(_ID, x, y);
}
/// <summary>
/// Set position of the control relative to the root of the GuiControl hierarchy it is contained in.
///    @param x The new X coordinate of the control relative to the root's upper left corner.
///    @param y The new Y coordinate of the control relative to the root's upper left corner. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPositionGlobal(int x, int y){

pInvokes.m_ts.fnGuiControl_setPositionGlobal(_ID, x, y);
}
/// <summary>
/// Set the control profile for the control to use.
///    The profile used by a control determines a great part of its behavior and appearance.
///    @param profile The new profile the control should use.
///    @ref GuiControl_Profiles )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setProfile(string profile){

pInvokes.m_ts.fnGuiControl_setProfile(_ID, profile);
}
/// <summary>
/// Displays the option to set the window settings of the control in the game when true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setShowContextWindowSettings(bool lockx){

pInvokes.m_ts.fnGuiControl_setShowContextWindowSettings(_ID, lockx);
}
/// <summary>
/// Set the value associated with the control.
///    @param value The new value for the control. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setValue(string value){

pInvokes.m_ts.fnGuiControl_setValue(_ID, value);
}
/// <summary>
/// Set whether the control is visible or not.
///    @param state The new visiblity flag state for the control.
///    @ref GuiControl_VisibleActive )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setVisible(bool state = true){

pInvokes.m_ts.fnGuiControl_setVisible(_ID, state);
}
/// <summary>
/// Returns true if the control is transparent. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool transparentControlCheck(){

return pInvokes.m_ts.fnGuiControl_transparentControlCheck(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the control object is registered with the system after the control has been created. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(){}

        /// <summary>
        /// Called when the control object is removed from the system before it is deleted. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemove(){}

        /// <summary>
        /// Called when the control is woken up.   @ref GuiControl_Waking )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onWake(){}

        /// <summary>
        /// Called when the control is put to sleep.   @ref GuiControl_Waking )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSleep(){}

        /// <summary>
        /// Called when the control gains first responder status on the GuiCanvas.   @see setFirstResponder   @see makeFirstResponder   @see isFirstResponder   @ref GuiControl_FirstResponders )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onGainFirstResponder(string ID){}

        /// <summary>
        /// Called when the control loses first responder status on the GuiCanvas.   @see setFirstResponder   @see makeFirstResponder   @see isFirstResponder   @ref GuiControl_FirstResponders )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLoseFirstResponder(string ID){}

        /// <summary>
        /// Called when the control's associated action is triggered and no 'command' is defined for the control.   @ref GuiControl_Actions )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAction(){}

        /// <summary>
        /// Called when the control changes its visibility state, i.e. when going from visible to invisible or vice versa.   @param state The new visibility state.   @see isVisible   @see setVisible   @ref GuiControl_VisibleActive )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onVisible(bool state){}

        /// <summary>
        /// Called when the control changes its activeness state, i.e. when going from active to inactive or vice versa.   @param stat The new activeness state.   @see isActive   @see setActive   @ref GuiControl_VisibleActive )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onActive(bool state){}

        /// <summary>
        /// Called when the control is pushed as a dialog onto the canvas.   @see GuiCanvas::pushDialog )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDialogPush(){}

        /// <summary>
        /// Called when the control is removed as a dialog from the canvas.   @see GuiCanvas::popDialog )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDialogPop(){}

        /// <summary>
        /// Called when a drag&drop operation through GuiDragAndDropControl has entered the control.  This is only called for    topmost visible controls as the GuiDragAndDropControl moves over them.   @param control The payload of the drag operation.   @param dropPoint The point at which the payload would be dropped if it were released now.  Relative to the canvas. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onControlDragEnter(GuiControl control, string dropPoint){}

        /// <summary>
        /// Called when a drag&drop operation through GuiDragAndDropControl has exited the control and moved over a different control.  This is only called for    topmost visible controls as the GuiDragAndDropControl moves off of them.   @param control The payload of the drag operation.   @param dropPoint The point at which the payload would be dropped if it were released now.  Relative to the canvas. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onControlDragExit(GuiControl control, string dropPoint){}

        /// <summary>
        /// Called when a drag&drop operation through GuiDragAndDropControl is moving across the control after it has entered it.  This is only called for    topmost visible controls as the GuiDragAndDropControl moves across them.   @param control The payload of the drag operation.   @param dropPoint The point at which the payload would be dropped if it were released now.  Relative to the canvas. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onControlDragged(GuiControl control, string dropPoint){}

        /// <summary>
        /// Called when a drag&drop operation through GuiDragAndDropControl has completed and is dropping its payload onto the control.     This is only called for topmost visible controls as the GuiDragAndDropControl drops its payload on them.   @param control The control that is being dropped onto this control.   @param dropPoint The point at which the control is being dropped.  Relative to the canvas. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onControlDropped(GuiControl control, string dropPoint){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onUnsetContent(string newContent){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSetContent(string oldContent){}

        /// <summary>
        /// Called when right click is released and the control can be edited.    @param control The control that is being edited. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRightMouseUp(GuiControl control){}

#endregion
public GuiControl_Base (){}
}}
