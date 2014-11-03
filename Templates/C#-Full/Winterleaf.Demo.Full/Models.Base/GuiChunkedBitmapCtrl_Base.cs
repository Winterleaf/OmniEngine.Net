


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiChunkedBitmapCtrl_Base>))]
    public partial class GuiChunkedBitmapCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiChunkedBitmapCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiChunkedBitmapCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiChunkedBitmapCtrl_Base ts)
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
        public static implicit operator GuiChunkedBitmapCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiChunkedBitmapCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiChunkedBitmapCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiChunkedBitmapCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiChunkedBitmapCtrl_Base(int simobjectid)
            {
            return  (GuiChunkedBitmapCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiChunkedBitmapCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiChunkedBitmapCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiChunkedBitmapCtrl_Base(uint simobjectid)
            {
            return  (GuiChunkedBitmapCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiChunkedBitmapCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// This is the bitmap to render to the control. 
/// </summary>
[MemberGroup("GuiChunkedBitmapCtrl")]
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
/// This is no longer in use
/// </summary>
[MemberGroup("GuiChunkedBitmapCtrl")]
public bool tile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tile").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tile", value.AsString());
          }
       }
/// <summary>
/// This decides whether to use the \bitmap\ file 	                                           or a bitmap stored in \variable\
/// </summary>
[MemberGroup("GuiChunkedBitmapCtrl")]
public bool useVariable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useVariable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useVariable", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Set the image rendered in this control.
///    @param filename The image name you want to set
///    @tsexample
///    ChunkedBitmap.setBitmap(\"images/background.png\");
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBitmap(string filename){

pInvokes.m_ts.fnGuiChunkedBitmapCtrl_setBitmap(_ID, filename);
}

#endregion
#region T3D Callbacks

#endregion
public GuiChunkedBitmapCtrl_Base (){}
}}
