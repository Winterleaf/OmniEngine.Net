


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiIconButtonCtrl_Base>))]
    public partial class GuiIconButtonCtrl_Base: GuiButtonCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiIconButtonCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiIconButtonCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiIconButtonCtrl_Base ts)
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
        public static implicit operator GuiIconButtonCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiIconButtonCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiIconButtonCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiIconButtonCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiIconButtonCtrl_Base(int simobjectid)
            {
            return  (GuiIconButtonCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiIconButtonCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiIconButtonCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiIconButtonCtrl_Base(uint simobjectid)
            {
            return  (GuiIconButtonCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiIconButtonCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true, the text and icon will be automatically sized to the size of the control.\n
/// </summary>
[MemberGroup("")]
public bool autoSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".autoSize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".autoSize", value.AsString());
          }
       }
/// <summary>
/// Margin area around the button.\n
/// </summary>
[MemberGroup("")]
public Point2I buttonMargin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".buttonMargin").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".buttonMargin", value.AsString());
          }
       }
/// <summary>
/// Bitmap file for the icon to display on the button.\n
/// </summary>
[MemberGroup("")]
public String iconBitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".iconBitmap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".iconBitmap", value.AsString());
          }
       }
/// <summary>
/// Where to place the icon on the control. Options are 0 (None), 1 (Left), 2 (Right), 3 (Center).\n
/// </summary>
[MemberGroup("")]
public TypeGuiIconButtonIconLocation iconLocation
       {
       get
          {          return (TypeGuiIconButtonIconLocation) Omni.self.GetVar(_ID + ".iconLocation");
          }
       set
          {
          Omni.self.SetVar(_ID + ".iconLocation", value.ToString());
          }
       }
/// <summary>
/// If true, will make sure the icon is square.\n
/// </summary>
[MemberGroup("")]
public bool makeIconSquare
       {
       get
          {
          return Omni.self.GetVar(_ID + ".makeIconSquare").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".makeIconSquare", value.AsString());
          }
       }
/// <summary>
/// If true, the icon will be scaled to be the same size as the button.\n
/// </summary>
[MemberGroup("")]
public bool sizeIconToButton
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sizeIconToButton").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sizeIconToButton", value.AsString());
          }
       }
/// <summary>
/// Where to place the text on the control.\n																										  Options are 0 (None), 1 (Bottom), 2 (Right), 3 (Top), 4 (Left), 5 (Center).\n
/// </summary>
[MemberGroup("")]
public TypeGuiIconButtonTextLocation textLocation
       {
       get
          {          return (TypeGuiIconButtonTextLocation) Omni.self.GetVar(_ID + ".textLocation");
          }
       set
          {
          Omni.self.SetVar(_ID + ".textLocation", value.ToString());
          }
       }
/// <summary>
/// Margin between the icon and the text.\n
/// </summary>
[MemberGroup("")]
public int textMargin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textMargin").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textMargin", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Set the bitmap to use for the button portion of this control.
///    @param buttonFilename Filename for the image
///    @tsexample
///    // Define the button filename
///    %buttonFilename = \"pearlButton\";
///    // Inform the GuiIconButtonCtrl control to update its main button graphic to the defined bitmap
///    %thisGuiIconButtonCtrl.setBitmap(%buttonFilename);
///    @endtsexample
///    @see GuiControl
///    @see GuiButtonCtrl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBitmap(string buttonFilename){

pInvokes.m_ts.fnGuiIconButtonCtrl_setBitmap(_ID, buttonFilename);
}

#endregion
#region T3D Callbacks

#endregion
public GuiIconButtonCtrl_Base (){}
}}
