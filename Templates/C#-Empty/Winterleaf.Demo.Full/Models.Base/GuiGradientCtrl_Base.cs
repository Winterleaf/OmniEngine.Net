


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiGradientCtrl_Base>))]
    public partial class GuiGradientCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiGradientCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiGradientCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiGradientCtrl_Base ts)
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
        public static implicit operator GuiGradientCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiGradientCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGradientCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiGradientCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiGradientCtrl_Base(int simobjectid)
            {
            return  (GuiGradientCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiGradientCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiGradientCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiGradientCtrl_Base(uint simobjectid)
            {
            return  (GuiGradientCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGradientCtrl_Base));
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
public TypeGuiGradientPickMode displayMode
       {
       get
          {          return (TypeGuiGradientPickMode) Omni.self.GetVar(_ID + ".displayMode");
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
/// <summary>
/// 
/// </summary>
[MemberGroup("ColorPicker")]
public int swatchFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".swatchFactor").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".swatchFactor", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Get color value)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  ColorF getColor(int idx){

return new ColorF ( pInvokes.m_ts.fn_GuiGradientCtrl_getColor(_ID, idx));
}
/// <summary>
/// Get color count)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getColorCount(){

return pInvokes.m_ts.fn_GuiGradientCtrl_getColorCount(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiGradientCtrl_Base (){}
}}
