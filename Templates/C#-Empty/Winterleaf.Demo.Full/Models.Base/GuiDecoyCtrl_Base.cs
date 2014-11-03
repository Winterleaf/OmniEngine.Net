


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiDecoyCtrl_Base>))]
    public partial class GuiDecoyCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiDecoyCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiDecoyCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiDecoyCtrl_Base ts)
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
        public static implicit operator GuiDecoyCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiDecoyCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDecoyCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiDecoyCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiDecoyCtrl_Base(int simobjectid)
            {
            return  (GuiDecoyCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiDecoyCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiDecoyCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiDecoyCtrl_Base(uint simobjectid)
            {
            return  (GuiDecoyCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDecoyCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Sets this control to decoy mode
/// </summary>
[MemberGroup("")]
public bool isDecoy
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isDecoy").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isDecoy", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseEnter(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseLeave(){}

#endregion
public GuiDecoyCtrl_Base (){}
}}
