


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiRectHandles_Base>))]
    public partial class GuiRectHandles_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiRectHandles_Base ts, string simobjectid)
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
        public static bool operator !=(GuiRectHandles_Base ts, string simobjectid)
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
        public static implicit operator string( GuiRectHandles_Base ts)
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
        public static implicit operator GuiRectHandles_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiRectHandles_Base) Omni.self.getSimObject(simobjectid,typeof(GuiRectHandles_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiRectHandles_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiRectHandles_Base(int simobjectid)
            {
            return  (GuiRectHandles) Omni.self.getSimObject((uint)simobjectid,typeof(GuiRectHandles_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiRectHandles_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiRectHandles_Base(uint simobjectid)
            {
            return  (GuiRectHandles_Base) Omni.self.getSimObject(simobjectid,typeof(GuiRectHandles_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Use given custom color for handles. 
/// </summary>
[MemberGroup("")]
public ColorI handleColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".handleColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".handleColor", value.AsString());
          }
       }
/// <summary>
/// RectF of handle's box. 
/// </summary>
[MemberGroup("")]
public RectF handleRect
       {
       get
          {
          return Omni.self.GetVar(_ID + ".handleRect").AsRectF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".handleRect", value.AsString());
          }
       }
/// <summary>
/// Size of handles in pixels. 
/// </summary>
[MemberGroup("")]
public int handleSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".handleSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".handleSize", value.AsString());
          }
       }
/// <summary>
/// Use given custom color for handles. 
/// </summary>
[MemberGroup("")]
public bool useCustomColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useCustomColor").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useCustomColor", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onHandleRectChange(){}

#endregion
public GuiRectHandles_Base (){}
}}
