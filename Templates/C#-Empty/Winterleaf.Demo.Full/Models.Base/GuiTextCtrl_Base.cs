


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiTextCtrl_Base>))]
    public partial class GuiTextCtrl_Base: GuiContainer
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTextCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTextCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiTextCtrl_Base ts)
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
        public static implicit operator GuiTextCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTextCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTextCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTextCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTextCtrl_Base(int simobjectid)
            {
            return  (GuiTextCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTextCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTextCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTextCtrl_Base(uint simobjectid)
            {
            return  (GuiTextCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTextCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Defines the maximum length of the text. The default is 1024. 
/// </summary>
[MemberGroup("")]
public int maxLength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxLength").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxLength", value.AsString());
          }
       }
/// <summary>
/// The text to show on the control.
/// </summary>
[MemberGroup("")]
public String text
       {
       get
          {
          return Omni.self.GetVar(_ID + ".text").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".text", value.AsString());
          }
       }
/// <summary>
/// Maps the text of this control to a variable used in localization, rather than raw text.
/// </summary>
[MemberGroup("")]
public String textID
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textID").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textID", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Sets the text in the control.
///    @param text Text to display in the control.
///    @tsexample
///    // Set the text to show in the control
///    %text = \"Gideon - Destroyer of World\";
///    // Inform the GuiTextCtrl control to change its text to the defined value
///    %thisGuiTextCtrl.setText(%text);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setText(string text){

pInvokes.m_ts.fnGuiTextCtrl_setText(_ID, text);
}
/// <summary>
/// @brief Maps the text ctrl to a variable used in localization, rather than raw text.
///    @param textID Name of variable text should be mapped to
///    @tsexample
///    // Inform the GuiTextCtrl control of the textID to use
///    %thisGuiTextCtrl.setTextID(\"STR_QUIT\");
///    @endtsexample
///    @see GuiControl
///    @see Localization)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTextID(string textID){

pInvokes.m_ts.fnGuiTextCtrl_setTextID(_ID, textID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiTextCtrl_Base (){}
}}
