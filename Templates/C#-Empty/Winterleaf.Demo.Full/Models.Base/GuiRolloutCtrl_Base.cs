


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiRolloutCtrl_Base>))]
    public partial class GuiRolloutCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiRolloutCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiRolloutCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiRolloutCtrl_Base ts)
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
        public static implicit operator GuiRolloutCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiRolloutCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiRolloutCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiRolloutCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiRolloutCtrl_Base(int simobjectid)
            {
            return  (GuiRolloutCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiRolloutCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiRolloutCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiRolloutCtrl_Base(uint simobjectid)
            {
            return  (GuiRolloutCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiRolloutCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Whether to automatically collapse sibling rollouts.\n\n     If this is true, the rollout will automatically collapse all sibling rollout controls when it      is expanded. If this is false, the auto-collapse behavior can be triggered by CTRL (CMD on MAC)      clicking the rollout header. CTRL/CMD clicking also works if this is false, in which case the      auto-collapsing of sibling controls will be temporarily deactivated. 
/// </summary>
[MemberGroup("Rollout")]
public bool autoCollapseSiblings
       {
       get
          {
          return Omni.self.GetVar(_ID + ".autoCollapseSiblings").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".autoCollapseSiblings", value.AsString());
          }
       }
/// <summary>
/// Text label to display on the rollout header. 
/// </summary>
[MemberGroup("Rollout")]
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
/// Whether the rollout can be collapsed by clicking its header. 
/// </summary>
[MemberGroup("Rollout")]
public bool clickCollapse
       {
       get
          {
          return Omni.self.GetVar(_ID + ".clickCollapse").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".clickCollapse", value.AsString());
          }
       }
/// <summary>
/// Default height of the client area. This is used when no child control has been added to the rollout. 
/// </summary>
[MemberGroup("Rollout")]
public int defaultHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".defaultHeight").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".defaultHeight", value.AsString());
          }
       }
/// <summary>
/// The current rollout expansion state. 
/// </summary>
[MemberGroup("Rollout")]
public bool expanded
       {
       get
          {
          return Omni.self.GetVar(_ID + ".expanded").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".expanded", value.AsString());
          }
       }
/// <summary>
/// Whether to render the rollout header.\n\n     @note If this is false, the user cannot toggle the rollout state with the mouse. 
/// </summary>
[MemberGroup("Rollout")]
public bool hideHeader
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hideHeader").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hideHeader", value.AsString());
          }
       }
/// <summary>
/// Margin to put around child control. 
/// </summary>
[MemberGroup("Rollout")]
public RectI margin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".margin").AsRectI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".margin", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Collapse the rollout if it is currently expanded.  This will make the rollout's child control invisible.
///    @note The rollout will animate to collapsed state.  To instantly collapse without animation, use instantCollapse(). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void collapse(){

pInvokes.m_ts.fnGuiRolloutCtrl_collapse(_ID);
}
/// <summary>
/// Expand the rollout if it is currently collapsed.  This will make the rollout's child control visible.
///    @note The rollout will animate to expanded state.  To instantly expand without animation, use instantExpand(). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void expand(){

pInvokes.m_ts.fnGuiRolloutCtrl_expand(_ID);
}
/// <summary>
/// Instantly collapse the rollout without animation.  To smoothly slide the rollout to collapsed state, use collapse(). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void instantCollapse(){

pInvokes.m_ts.fnGuiRolloutCtrl_instantCollapse(_ID);
}
/// <summary>
/// Instantly expand the rollout without animation.  To smoothly slide the rollout to expanded state, use expand(). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void instantExpand(){

pInvokes.m_ts.fnGuiRolloutCtrl_instantExpand(_ID);
}
/// <summary>
/// Determine whether the rollout is currently expanded, i.e. whether the child control is visible.
///    @return True if the rollout is expanded, false if not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  bool isExpanded(){

return pInvokes.m_ts.fnGuiRolloutCtrl_isExpanded(_ID);
}
/// <summary>
/// Resize the rollout to exactly fit around its child control.  This can be used to manually trigger a recomputation of 
///    the rollout size. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sizeToContents(){

pInvokes.m_ts.fnGuiRolloutCtrl_sizeToContents(_ID);
}
/// <summary>
/// Toggle the current collapse state of the rollout.  If it is currently expanded, then collapse it.  If it 
///    is currently collapsed, then expand it. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggleCollapse(){

pInvokes.m_ts.fnGuiRolloutCtrl_toggleCollapse(_ID);
}
/// <summary>
/// Toggle the current expansion state of the rollout  If it is currently expanded, then collapse it.  If it 
///    is currently collapsed, then expand it.
///    @param instant If true, the rollout will toggle its state without animation.  Otherwise, the rollout will 
///       smoothly slide into the opposite state. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggleExpanded(bool instantly = false){

pInvokes.m_ts.fnGuiRolloutCtrl_toggleExpanded(_ID, instantly);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the user right-clicks on the rollout's header.  This is useful for implementing    context menus for rollouts. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onHeaderRightClick(){}

        /// <summary>
        /// Called when the rollout is expanded. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onExpanded(){}

        /// <summary>
        /// Called when the rollout is collapsed. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onCollapsed(){}

#endregion
public GuiRolloutCtrl_Base (){}
}}
