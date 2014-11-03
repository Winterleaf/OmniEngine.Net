


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiBitmapButtonCtrl_Base>))]
    public partial class GuiBitmapButtonCtrl_Base: GuiButtonCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiBitmapButtonCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiBitmapButtonCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiBitmapButtonCtrl_Base ts)
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
        public static implicit operator GuiBitmapButtonCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiBitmapButtonCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiBitmapButtonCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiBitmapButtonCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiBitmapButtonCtrl_Base(int simobjectid)
            {
            return  (GuiBitmapButtonCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiBitmapButtonCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiBitmapButtonCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiBitmapButtonCtrl_Base(uint simobjectid)
            {
            return  (GuiBitmapButtonCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiBitmapButtonCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true, the control's extents will be set to match the bitmap's extents when setting the bitmap.\n     The bitmap extents will always be taken from the default/normal bitmap (in case the extents of the various      bitmaps do not match up.) 
/// </summary>
[MemberGroup("Bitmap")]
public bool autoFitExtents
       {
       get
          {
          return Omni.self.GetVar(_ID + ".autoFitExtents").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".autoFitExtents", value.AsString());
          }
       }
/// <summary>
/// Texture file to display on this button.\n     If useStates is false, this will be the file that renders on the control. Otherwise, this will      specify the default texture name to which the various state and modifier suffixes are appended      to find the per-state and per-modifier (if enabled) textures. 
/// </summary>
[MemberGroup("Bitmap")]
public String bitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bitmap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bitmap", value.AsString());
          }
       }
/// <summary>
/// Behavior for fitting the bitmap to the control extents.\n     If set to 'Stretched', the bitmap will be stretched both verticall and horizontally to fit inside      the control's extents.\n\n     If set to 'Centered', the bitmap will stay at its original resolution centered in the control's      rectangle (getting clipped if the control is smaller than the texture). 
/// </summary>
[MemberGroup("Bitmap")]
public TypeGuiBitmapMode bitmapMode
       {
       get
          {          return (TypeGuiBitmapMode) Omni.self.GetVar(_ID + ".bitmapMode");
          }
       set
          {
          Omni.self.SetVar(_ID + ".bitmapMode", value.ToString());
          }
       }
/// <summary>
/// If true, per-modifier button functionality is enabled.\n     @ref guibitmapbutton_modifiers 
/// </summary>
[MemberGroup("Bitmap")]
public bool useModifiers
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useModifiers").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useModifiers", value.AsString());
          }
       }
/// <summary>
/// If true, per-mouse state button functionality is enabled.\n     Defaults to true.\n\n     If you do not use per-state images on this button set this to false to speed up the loading process      by inhibiting searches for the individual images. 
/// </summary>
[MemberGroup("Bitmap")]
public bool useStates
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useStates").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useStates", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Set the bitmap to show on the button.
///    @param path Path to the texture file in any of the supported formats. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBitmap(string path){

pInvokes.m_ts.fnGuiBitmapButtonCtrl_setBitmap(_ID, path);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when per-modifier functionality is enabled and the user clicks on the button without any modifier pressed.   @ref guibitmapbutton_modifiers )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDefaultClick(){}

        /// <summary>
        /// Called when per-modifier functionality is enabled and the user clicks on the button with the CTRL key pressed.   @ref guibitmapbutton_modifiers )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onCtrlClick(){}

        /// <summary>
        /// Called when per-modifier functionality is enabled and the user clicks on the button with the ALT key pressed.   @ref guibitmapbutton_modifiers )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAltClick(){}

        /// <summary>
        /// Called when per-modifier functionality is enabled and the user clicks on the button with the SHIFT key pressed.   @ref guibitmapbutton_modifiers )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onShiftClick(){}

#endregion
public GuiBitmapButtonCtrl_Base (){}
}}
