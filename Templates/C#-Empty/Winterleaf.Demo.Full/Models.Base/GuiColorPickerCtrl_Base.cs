


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiColorPickerCtrl_Base>))]
    public partial class GuiColorPickerCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiColorPickerCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiColorPickerCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiColorPickerCtrl_Base ts)
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
        public static implicit operator GuiColorPickerCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiColorPickerCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiColorPickerCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiColorPickerCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiColorPickerCtrl_Base(int simobjectid)
            {
            return  (GuiColorPickerCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiColorPickerCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiColorPickerCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiColorPickerCtrl_Base(uint simobjectid)
            {
            return  (GuiColorPickerCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiColorPickerCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("ColorPicker")]
public bool actionOnMove
       {
       get
          {
          return Omni.self.GetVar(_ID + ".actionOnMove").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".actionOnMove", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("ColorPicker")]
public ColorF baseColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".baseColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".baseColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("ColorPicker")]
public TypeGuiColorPickMode displayMode
       {
       get
          {          return (TypeGuiColorPickMode) Omni.self.GetVar(_ID + ".displayMode");
          }
       set
          {
          Omni.self.SetVar(_ID + ".displayMode", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("ColorPicker")]
public ColorF pickColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".pickColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".pickColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("ColorPicker")]
public int selectorGap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".selectorGap").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".selectorGap", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("ColorPicker")]
public bool showReticle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showReticle").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showReticle", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Gets the current position of the selector)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2I getSelectorPos(){

return new Point2I ( pInvokes.m_ts.fn_GuiColorPickerCtrl_getSelectorPos(_ID));
}
/// <summary>
/// Sets the current position of the selector)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelectorPos(Point2I newPos){

pInvokes.m_ts.fn_GuiColorPickerCtrl_setSelectorPos(_ID, newPos.AsString());
}
/// <summary>
/// Forces update of pick color)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void updateColor(){

pInvokes.m_ts.fn_GuiColorPickerCtrl_updateColor(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiColorPickerCtrl_Base (){}
}}
