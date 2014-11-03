


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiStackControl_Base>))]
    public partial class GuiStackControl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiStackControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiStackControl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiStackControl_Base ts)
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
        public static implicit operator GuiStackControl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiStackControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiStackControl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiStackControl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiStackControl_Base(int simobjectid)
            {
            return  (GuiStackControl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiStackControl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiStackControl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiStackControl_Base(uint simobjectid)
            {
            return  (GuiStackControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiStackControl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Determines whether to reposition child controls.\n\n   If true, horizontally stacked children are aligned along the top edge of    the stack control. Vertically stacked children are aligned along the left    edge of the stack control. If false, horizontally stacked children retain    their Y position, and vertically stacked children retain their X position. 
/// </summary>
[MemberGroup("Stacking")]
public bool changeChildPosition
       {
       get
          {
          return Omni.self.GetVar(_ID + ".changeChildPosition").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".changeChildPosition", value.AsString());
          }
       }
/// <summary>
/// Determines whether to resize child controls.\n\n   If true, horizontally stacked children keep their width, but have their    height set to the stack control height. Vertically stacked children keep    their height, but have their width set to the stack control width. If    false, child controls are not resized. 
/// </summary>
[MemberGroup("Stacking")]
public bool changeChildSizeToFit
       {
       get
          {
          return Omni.self.GetVar(_ID + ".changeChildSizeToFit").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".changeChildSizeToFit", value.AsString());
          }
       }
/// <summary>
/// Determines whether to resize the stack control along the non-stack axis (change    height for horizontal stacking, change width for vertical stacking). No effect    if dynamicSize is false.\n\n   If true, the stack will be resized to the maximum of the child control widths/heights.    If false, the stack will not be resized. 
/// </summary>
[MemberGroup("Stacking")]
public bool dynamicNonStackExtent
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dynamicNonStackExtent").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dynamicNonStackExtent", value.AsString());
          }
       }
/// <summary>
/// Determines whether to reposition the stack along the stack axis when it is    auto-resized. No effect if dynamicSize is false.\n\n   If true, the stack will grow left for horizontal stacking, and grow up for vertical stacking.\n   If false, the stack will grow right for horizontal stacking, and grow down for vertical stacking.\n 
/// </summary>
[MemberGroup("Stacking")]
public bool dynamicPos
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dynamicPos").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dynamicPos", value.AsString());
          }
       }
/// <summary>
/// Determines whether to resize the stack control along the stack axis (change    width for horizontal stacking, change height for vertical stacking).\n\n   If true, the stack width/height will be resized to the sum of the child control widths/heights.    If false, the stack will not be resized. 
/// </summary>
[MemberGroup("Stacking")]
public bool dynamicSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dynamicSize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dynamicSize", value.AsString());
          }
       }
/// <summary>
/// Controls the type of horizontal stacking to use (iLeft to Right/i or    iRight to Left/i) 
/// </summary>
[MemberGroup("Stacking")]
public TypeGuiHorizontalStackingType horizStacking
       {
       get
          {          return (TypeGuiHorizontalStackingType) Omni.self.GetVar(_ID + ".horizStacking");
          }
       set
          {
          Omni.self.SetVar(_ID + ".horizStacking", value.ToString());
          }
       }
/// <summary>
/// Distance (in pixels) between stacked child controls. 
/// </summary>
[MemberGroup("Stacking")]
public int padding
       {
       get
          {
          return Omni.self.GetVar(_ID + ".padding").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".padding", value.AsString());
          }
       }
/// <summary>
/// Determines the method used to position the child controls.\n\n 
/// </summary>
[MemberGroup("Stacking")]
public TypeGuiStackingType stackingType
       {
       get
          {          return (TypeGuiStackingType) Omni.self.GetVar(_ID + ".stackingType");
          }
       set
          {
          Omni.self.SetVar(_ID + ".stackingType", value.ToString());
          }
       }
/// <summary>
/// Controls the type of vertical stacking to use (iTop to Bottom/i or    iBottom to Top/i) 
/// </summary>
[MemberGroup("Stacking")]
public TypeGuiVerticalStackingType vertStacking
       {
       get
          {          return (TypeGuiVerticalStackingType) Omni.self.GetVar(_ID + ".vertStacking");
          }
       set
          {
          Omni.self.SetVar(_ID + ".vertStacking", value.ToString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Prevents control from restacking - useful when adding or removing child controls
///    @param freeze True to freeze the control, false to unfreeze it
///    @tsexample
///    %stackCtrl.freeze(true);
///    // add controls to stack
///    %stackCtrl.freeze(false);
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void freeze(bool freeze){

pInvokes.m_ts.fnGuiStackControl_freeze(_ID, freeze);
}
/// <summary>
/// Return whether or not this control is frozen )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isFrozen(){

return pInvokes.m_ts.fnGuiStackControl_isFrozen(_ID);
}
/// <summary>
/// Restack the child controls. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void updateStack(){

pInvokes.m_ts.fnGuiStackControl_updateStack(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiStackControl_Base (){}
}}
