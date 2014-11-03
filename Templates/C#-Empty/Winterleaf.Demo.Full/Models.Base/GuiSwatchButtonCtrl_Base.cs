


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiSwatchButtonCtrl_Base>))]
    public partial class GuiSwatchButtonCtrl_Base: GuiButtonBaseCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiSwatchButtonCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiSwatchButtonCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiSwatchButtonCtrl_Base ts)
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
        public static implicit operator GuiSwatchButtonCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiSwatchButtonCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSwatchButtonCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiSwatchButtonCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiSwatchButtonCtrl_Base(int simobjectid)
            {
            return  (GuiSwatchButtonCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiSwatchButtonCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiSwatchButtonCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiSwatchButtonCtrl_Base(uint simobjectid)
            {
            return  (GuiSwatchButtonCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSwatchButtonCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The foreground color of GuiSwatchButtonCtrl 
/// </summary>
[MemberGroup("")]
public ColorF color
       {
       get
          {
          return Omni.self.GetVar(_ID + ".color").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".color", value.AsString());
          }
       }
/// <summary>
/// The bitmap used for the transparent grid 
/// </summary>
[MemberGroup("")]
public String gridBitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridBitmap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridBitmap", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Set the color of the swatch control.
///    @param newColor The new color string given to the swatch control in float format \"r g b a\".
///    @note It's also important to note that when setColor is called causes
///    the control's altCommand field to be executed. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setColor(string newColor){

pInvokes.m_ts.fnGuiSwatchButtonCtrl_setColor(_ID, newColor);
}

#endregion
#region T3D Callbacks

#endregion
public GuiSwatchButtonCtrl_Base (){}
}}
