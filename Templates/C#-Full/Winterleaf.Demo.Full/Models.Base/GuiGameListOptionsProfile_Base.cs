


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiGameListOptionsProfile_Base>))]
    public partial class GuiGameListOptionsProfile_Base: GuiGameListMenuProfile
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiGameListOptionsProfile_Base ts, string simobjectid)
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
        public static bool operator !=(GuiGameListOptionsProfile_Base ts, string simobjectid)
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
        public static implicit operator string( GuiGameListOptionsProfile_Base ts)
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
        public static implicit operator GuiGameListOptionsProfile_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiGameListOptionsProfile_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGameListOptionsProfile_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiGameListOptionsProfile_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiGameListOptionsProfile_Base(int simobjectid)
            {
            return  (GuiGameListOptionsProfile) Omni.self.getSimObject((uint)simobjectid,typeof(GuiGameListOptionsProfile_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiGameListOptionsProfile_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiGameListOptionsProfile_Base(uint simobjectid)
            {
            return  (GuiGameListOptionsProfile_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGameListOptionsProfile_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Padding between the leftmost edge of the control, and the row's left arrow. 
/// </summary>
[MemberGroup("")]
public int columnSplit
       {
       get
          {
          return Omni.self.GetVar(_ID + ".columnSplit").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".columnSplit", value.AsString());
          }
       }
/// <summary>
/// Padding between the rightmost edge of the control and the row's right arrow. 
/// </summary>
[MemberGroup("")]
public int rightPad
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rightPad").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rightPad", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiGameListOptionsProfile_Base (){}
}}
