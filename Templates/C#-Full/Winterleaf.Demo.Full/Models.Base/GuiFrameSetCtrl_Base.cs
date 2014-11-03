


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiFrameSetCtrl_Base>))]
    public partial class GuiFrameSetCtrl_Base: GuiContainer
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiFrameSetCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiFrameSetCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiFrameSetCtrl_Base ts)
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
        public static implicit operator GuiFrameSetCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiFrameSetCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFrameSetCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiFrameSetCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiFrameSetCtrl_Base(int simobjectid)
            {
            return  (GuiFrameSetCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiFrameSetCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiFrameSetCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiFrameSetCtrl_Base(uint simobjectid)
            {
            return  (GuiFrameSetCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFrameSetCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true, row and column offsets are automatically scaled to match the    new extents when the control is resized. 
/// </summary>
[MemberGroup("")]
public bool autoBalance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".autoBalance").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".autoBalance", value.AsString());
          }
       }
/// <summary>
/// Color of interior borders between cells. 
/// </summary>
[MemberGroup("")]
public ColorI borderColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderColor", value.AsString());
          }
       }
/// <summary>
/// Controls whether frame borders are enabled.\n\nFrames use this value    unless overridden for that frame using i%ctrl.frameBorder(index)/i 
/// </summary>
[MemberGroup("")]
public TypeGuiFrameState borderEnable
       {
       get
          {          return (TypeGuiFrameState) Omni.self.GetVar(_ID + ".borderEnable");
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderEnable", value.ToString());
          }
       }
/// <summary>
/// Controls whether borders can be dynamically repositioned with the mouse    by the user.\n\nFrames use this value unless overridden for that frame    using i%ctrl.frameMovable(index)/i 
/// </summary>
[MemberGroup("")]
public TypeGuiFrameState borderMovable
       {
       get
          {          return (TypeGuiFrameState) Omni.self.GetVar(_ID + ".borderMovable");
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderMovable", value.ToString());
          }
       }
/// <summary>
/// Width of interior borders between cells in pixels. 
/// </summary>
[MemberGroup("")]
public int borderWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderWidth").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderWidth", value.AsString());
          }
       }
/// <summary>
/// A vector of column offsets (determines the width of each column). 
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
/// Offset for row and column dividers in pixels 
/// </summary>
[MemberGroup("")]
public int fudgeFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fudgeFactor").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fudgeFactor", value.AsString());
          }
       }
/// <summary>
/// A vector of row offsets (determines the height of each row). 
/// </summary>
[MemberGroup("")]
public VectorInt rows
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rows").AsVectorInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rows", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Add a new column. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addColumn(){

pInvokes.m_ts.fnGuiFrameSetCtrl_addColumn(_ID);
}
/// <summary>
/// Add a new row. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addRow(){

pInvokes.m_ts.fnGuiFrameSetCtrl_addRow(_ID);
}
/// <summary>
/// dynamic ),
///    Override the i>borderEnable/i> setting for this frame.
///    @param index  Index of the frame to modify
///    @param state  New borderEnable state: \"on\", \"off\" or \"dynamic\" )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void frameBorder(int index, string state = "dynamic"){

pInvokes.m_ts.fnGuiFrameSetCtrl_frameBorder(_ID, index, state);
}
/// <summary>
/// Set the minimum width and height for the frame. It will not be possible 
///    for the user to resize the frame smaller than this.
///    @param index  Index of the frame to modify
///    @param width  Minimum width in pixels
///    @param height Minimum height in pixels )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void frameMinExtent(int index, int width, int height){

pInvokes.m_ts.fnGuiFrameSetCtrl_frameMinExtent(_ID, index, width, height);
}
/// <summary>
/// dynamic ),
///    Override the i>borderMovable/i> setting for this frame.
///    @param index  Index of the frame to modify
///    @param state  New borderEnable state: \"on\", \"off\" or \"dynamic\" )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void frameMovable(int index, string state = "dynamic"){

pInvokes.m_ts.fnGuiFrameSetCtrl_frameMovable(_ID, index, state);
}
/// <summary>
/// Set the padding for this frame. Padding introduces blank space on the inside 
///    edge of the frame.
///    @param index     Index of the frame to modify
///    @param padding   Frame top, bottom, left, and right padding )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void framePadding(int index, RectSpacingI padding){

pInvokes.m_ts.fnGuiFrameSetCtrl_framePadding(_ID, index, padding.AsString());
}
/// <summary>
/// Get the number of columns.
///    @return The number of columns )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getColumnCount(){

return pInvokes.m_ts.fnGuiFrameSetCtrl_getColumnCount(_ID);
}
/// <summary>
/// Get the horizontal offset of a column.
///    @param index Index of the column to query
///    @return Column offset in pixels )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getColumnOffset(int index){

return pInvokes.m_ts.fnGuiFrameSetCtrl_getColumnOffset(_ID, index);
}
/// <summary>
/// Get the padding for this frame.
///    @param index     Index of the frame to query )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  RectSpacingI getFramePadding(int index){

return new RectSpacingI ( pInvokes.m_ts.fnGuiFrameSetCtrl_getFramePadding(_ID, index));
}
/// <summary>
/// Get the number of rows.
///    @return The number of rows )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getRowCount(){

return pInvokes.m_ts.fnGuiFrameSetCtrl_getRowCount(_ID);
}
/// <summary>
/// Get the vertical offset of a row.
///    @param index Index of the row to query
///    @return Row offset in pixels )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getRowOffset(int index){

return pInvokes.m_ts.fnGuiFrameSetCtrl_getRowOffset(_ID, index);
}
/// <summary>
/// Remove the last (rightmost) column. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeColumn(){

pInvokes.m_ts.fnGuiFrameSetCtrl_removeColumn(_ID);
}
/// <summary>
/// Remove the last (bottom) row. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeRow(){

pInvokes.m_ts.fnGuiFrameSetCtrl_removeRow(_ID);
}
/// <summary>
/// Set the horizontal offset of a column.
///    Note that column offsets must always be in increasing order, and therefore 
///    this offset must be between the offsets of the colunns either side.
///    @param index  Index of the column to modify
///    @param offset New column offset )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setColumnOffset(int index, int offset){

pInvokes.m_ts.fnGuiFrameSetCtrl_setColumnOffset(_ID, index, offset);
}
/// <summary>
/// Set the vertical offset of a row.
///    Note that row offsets must always be in increasing order, and therefore 
///    this offset must be between the offsets of the rows either side.
///    @param index  Index of the row to modify
///    @param offset New row offset )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRowOffset(int index, int offset){

pInvokes.m_ts.fnGuiFrameSetCtrl_setRowOffset(_ID, index, offset);
}
/// <summary>
/// Recalculates child control sizes. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void updateSizes(){

pInvokes.m_ts.fnGuiFrameSetCtrl_updateSizes(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiFrameSetCtrl_Base (){}
}}
