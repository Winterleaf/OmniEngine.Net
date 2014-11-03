


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiControlArrayControl_Base>))]
    public partial class GuiControlArrayControl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiControlArrayControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiControlArrayControl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiControlArrayControl_Base ts)
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
        public static implicit operator GuiControlArrayControl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiControlArrayControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiControlArrayControl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiControlArrayControl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiControlArrayControl_Base(int simobjectid)
            {
            return  (GuiControlArrayControl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiControlArrayControl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiControlArrayControl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiControlArrayControl_Base(uint simobjectid)
            {
            return  (GuiControlArrayControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiControlArrayControl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Number of colums in the array. 
/// </summary>
[MemberGroup("Array")]
public int colCount
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colCount").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colCount", value.AsString());
          }
       }
/// <summary>
/// Size of each individual column. 
/// </summary>
[MemberGroup("Array")]
public VectorInt colSizes
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colSizes").AsVectorInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colSizes", value.AsString());
          }
       }
/// <summary>
/// Padding to put between columns. 
/// </summary>
[MemberGroup("Array")]
public int colSpacing
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colSpacing").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colSpacing", value.AsString());
          }
       }
/// <summary>
/// Heigth of a row in the array. 
/// </summary>
[MemberGroup("Array")]
public int rowSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rowSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rowSize", value.AsString());
          }
       }
/// <summary>
/// Padding to put between rows. 
/// </summary>
[MemberGroup("Array")]
public int rowSpacing
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rowSpacing").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rowSpacing", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiControlArrayControl_Base (){}
}}
