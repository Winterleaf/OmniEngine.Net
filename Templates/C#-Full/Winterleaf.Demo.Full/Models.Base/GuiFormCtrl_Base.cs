


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiFormCtrl_Base>))]
    public partial class GuiFormCtrl_Base: GuiPanel
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiFormCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiFormCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiFormCtrl_Base ts)
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
        public static implicit operator GuiFormCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiFormCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFormCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiFormCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiFormCtrl_Base(int simobjectid)
            {
            return  (GuiFormCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiFormCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiFormCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiFormCtrl_Base(uint simobjectid)
            {
            return  (GuiFormCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFormCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String caption
       {
       get
          {
          return Omni.self.GetVar(_ID + ".caption").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".caption", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String content
       {
       get
          {
          return Omni.self.GetVar(_ID + ".content").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".content", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String contentLibrary
       {
       get
          {
          return Omni.self.GetVar(_ID + ".contentLibrary").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".contentLibrary", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
[MemberGroup("")]
public bool hasMenu
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hasMenu").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hasMenu", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool movable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".movable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".movable", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Get the ID of this form's menu.
///    @return The ID of the form menu )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMenuID(){

return pInvokes.m_ts.fnGuiFormCtrl_getMenuID(_ID);
}
/// <summary>
/// Sets the title of the form.
///    @param caption Form caption )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCaption(string caption){

pInvokes.m_ts.fnGuiFormCtrl_setCaption(_ID, caption);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the control is resized. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onResize(){}

#endregion
public GuiFormCtrl_Base (){}
}}
