


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiPaneControl_Base>))]
    public partial class GuiPaneControl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiPaneControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiPaneControl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiPaneControl_Base ts)
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
        public static implicit operator GuiPaneControl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiPaneControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiPaneControl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiPaneControl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiPaneControl_Base(int simobjectid)
            {
            return  (GuiPaneControl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiPaneControl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiPaneControl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiPaneControl_Base(uint simobjectid)
            {
            return  (GuiPaneControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiPaneControl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Whether to draw the bitmapped pane bar behind the header text, too. 
/// </summary>
[MemberGroup("Pane")]
public bool barBehindText
       {
       get
          {
          return Omni.self.GetVar(_ID + ".barBehindText").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".barBehindText", value.AsString());
          }
       }
/// <summary>
/// Text label to display as the pane header. 
/// </summary>
[MemberGroup("Pane")]
public String caption
       {
       get
          {
          return Omni.self.GetVar(_ID + ".caption").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".caption", value.AsString());
          }
       }
/// <summary>
/// String table text ID to use as caption string (overrides 'caption'). 
/// </summary>
[MemberGroup("Pane")]
public String captionID
       {
       get
          {
          return Omni.self.GetVar(_ID + ".captionID").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".captionID", value.AsString());
          }
       }
/// <summary>
/// Whether the pane can be collapsed by clicking its header. 
/// </summary>
[MemberGroup("Pane")]
public bool collapsable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".collapsable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".collapsable", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Collapse or un-collapse the control.
///    @param collapse True to collapse the control, false to un-collapse it )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCollapsed(bool collapse){

pInvokes.m_ts.fnGuiPaneControl_setCollapsed(_ID, collapse);
}

#endregion
#region T3D Callbacks

#endregion
public GuiPaneControl_Base (){}
}}
