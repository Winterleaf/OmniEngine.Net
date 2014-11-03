


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiBitmapCtrl_Base>))]
    public partial class GuiBitmapCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiBitmapCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiBitmapCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiBitmapCtrl_Base ts)
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
        public static implicit operator GuiBitmapCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiBitmapCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiBitmapCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiBitmapCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiBitmapCtrl_Base(int simobjectid)
            {
            return  (GuiBitmapCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiBitmapCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiBitmapCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiBitmapCtrl_Base(uint simobjectid)
            {
            return  (GuiBitmapCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiBitmapCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The bitmap file to display in the control. 
/// </summary>
[MemberGroup("Bitmap")]
public TypeImageFilename bitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bitmap").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bitmap", value.AsString());
          }
       }
/// <summary>
/// Allows the user to set the bitmap of the control in the game. 
/// </summary>
[MemberGroup("Context Menu Options")]
public bool setBitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".setBitmap").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".setBitmap", value.AsString());
          }
       }
/// <summary>
/// If true, the bitmap is tiled inside the control rather than stretched to fit. 
/// </summary>
[MemberGroup("Bitmap")]
public bool wrap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".wrap").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".wrap", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ( String filename | String filename, bool resize ) Assign an image to the control.
///    @hide )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBitmapX(string fileRoot, bool resize = false){

pInvokes.m_ts.fn_GuiBitmapCtrl_setBitmap(_ID, fileRoot, resize);
}
/// <summary>
/// Set the offset of the bitmap within the control.
///    @param x The x-axis offset of the image.
///    @param y The y-axis offset of the image.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setValue(int x, int y){

pInvokes.m_ts.fnGuiBitmapCtrl_setValue(_ID, x, y);
}

#endregion
#region T3D Callbacks

#endregion
public GuiBitmapCtrl_Base (){}
}}
