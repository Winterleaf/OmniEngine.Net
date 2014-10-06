


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiScriptNotifyCtrl_Base>))]
    public partial class GuiScriptNotifyCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiScriptNotifyCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiScriptNotifyCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiScriptNotifyCtrl_Base ts)
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
        public static implicit operator GuiScriptNotifyCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiScriptNotifyCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiScriptNotifyCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiScriptNotifyCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiScriptNotifyCtrl_Base(int simobjectid)
            {
            return  (GuiScriptNotifyCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiScriptNotifyCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiScriptNotifyCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiScriptNotifyCtrl_Base(uint simobjectid)
            {
            return  (GuiScriptNotifyCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiScriptNotifyCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Enables/disables onChildAdded callback 
/// </summary>
[MemberGroup("Callbacks")]
public bool onChildAddedx
       {
       get
          {
          return Omni.self.GetVar(_ID + ".onChildAdded").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".onChildAdded", value.AsString());
          }
       }
/// <summary>
/// Enables/disables onChildRemoved callback 
/// </summary>
[MemberGroup("Callbacks")]
public bool onChildRemovedx
       {
       get
          {
          return Omni.self.GetVar(_ID + ".onChildRemoved").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".onChildRemoved", value.AsString());
          }
       }
/// <summary>
/// Enables/disables onChildResized callback 
/// </summary>
[MemberGroup("Callbacks")]
public bool onChildResizedx
       {
       get
          {
          return Omni.self.GetVar(_ID + ".onChildResized").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".onChildResized", value.AsString());
          }
       }
/// <summary>
/// Enables/disables onGainFirstResponder callback 
/// </summary>
[MemberGroup("Callbacks")]
public bool onGainFirstResponder
       {
       get
          {
          return Omni.self.GetVar(_ID + ".onGainFirstResponder").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".onGainFirstResponder", value.AsString());
          }
       }
/// <summary>
/// Enables/disables onLoseFirstResponder callback 
/// </summary>
[MemberGroup("Callbacks")]
public bool onLoseFirstResponder
       {
       get
          {
          return Omni.self.GetVar(_ID + ".onLoseFirstResponder").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".onLoseFirstResponder", value.AsString());
          }
       }
/// <summary>
/// Enables/disables onParentResized callback 
/// </summary>
[MemberGroup("Callbacks")]
public bool onParentResizedx
       {
       get
          {
          return Omni.self.GetVar(_ID + ".onParentResized").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".onParentResized", value.AsString());
          }
       }
/// <summary>
/// Enables/disables onResize callback 
/// </summary>
[MemberGroup("Callbacks")]
public bool onResizex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".onResize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".onResize", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when this GUI is resized.	@param ID Unique object ID assigned when created (%this in script).)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onResize(string ID){}

        /// <summary>
        /// Called when a child is added to this GUI.	@param ID Unique object ID assigned when created (%this in script).	@param childID Unique object ID of child being added.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onChildAdded(string ID, string childID){}

        /// <summary>
        /// Called when a child is removed from this GUI.	@param ID Unique object ID assigned when created (%this in script).	@param childID Unique object ID of child being removed.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onChildRemoved(string ID, string childID){}

        /// <summary>
        /// Called when a child is of this GUI is being resized.	@param ID Unique object ID assigned when created (%this in script).	@param childID Unique object ID of child being resized.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onChildResized(string ID, string childID){}

        /// <summary>
        /// Called when this GUI's parent is resized.	@param ID Unique object ID assigned when created (%this in script).)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onParentResized(string ID){}

#endregion
public GuiScriptNotifyCtrl_Base (){}
}}
