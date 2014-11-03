


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiTabBookCtrl_Base>))]
    public partial class GuiTabBookCtrl_Base: GuiContainer
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTabBookCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTabBookCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiTabBookCtrl_Base ts)
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
        public static implicit operator GuiTabBookCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTabBookCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTabBookCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTabBookCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTabBookCtrl_Base(int simobjectid)
            {
            return  (GuiTabBookCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTabBookCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTabBookCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTabBookCtrl_Base(uint simobjectid)
            {
            return  (GuiTabBookCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTabBookCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Whether reordering tabs with the mouse is allowed. 
/// </summary>
[MemberGroup("TabBook")]
public bool allowReorder
       {
       get
          {
          return Omni.self.GetVar(_ID + ".allowReorder").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".allowReorder", value.AsString());
          }
       }
/// <summary>
/// Index of page to select on first onWake() call (-1 to disable). 
/// </summary>
[MemberGroup("TabBook")]
public int defaultPage
       {
       get
          {
          return Omni.self.GetVar(_ID + ".defaultPage").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".defaultPage", value.AsString());
          }
       }
/// <summary>
/// X offset of first tab page header. 
/// </summary>
[MemberGroup("TabBook")]
public int frontTabPadding
       {
       get
          {
          return Omni.self.GetVar(_ID + ".frontTabPadding").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".frontTabPadding", value.AsString());
          }
       }
/// <summary>
/// Minimum width allocated to a tab page header. 
/// </summary>
[MemberGroup("TabBook")]
public int minTabWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minTabWidth").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minTabWidth", value.AsString());
          }
       }
/// <summary>
/// Index of currently selected page. 
/// </summary>
[MemberGroup("TabBook")]
public int selectedPage
       {
       get
          {
          return Omni.self.GetVar(_ID + ".selectedPage").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".selectedPage", value.AsString());
          }
       }
/// <summary>
/// Height of tab page headers. 
/// </summary>
[MemberGroup("TabBook")]
public int tabHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tabHeight").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tabHeight", value.AsString());
          }
       }
/// <summary>
/// Spacing to put between individual tab page headers. 
/// </summary>
[MemberGroup("TabBook")]
public int tabMargin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tabMargin").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tabMargin", value.AsString());
          }
       }
/// <summary>
/// Where to place the tab page headers. 
/// </summary>
[MemberGroup("TabBook")]
public TypeGuiTabPosition tabPosition
       {
       get
          {          return (TypeGuiTabPosition) Omni.self.GetVar(_ID + ".tabPosition");
          }
       set
          {
          Omni.self.SetVar(_ID + ".tabPosition", value.ToString());
          }
       }

#endregion
#region Member Functions
/// <summary>
///  ),
///    Add a new tab page to the control.
///    @param title Title text for the tab page header. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addPage(string title = ""){

pInvokes.m_ts.fnGuiTabBookCtrl_addPage(_ID, title);
}
/// <summary>
/// Get the index of the currently selected tab page.
///    @return Index of the selected tab page or -1 if no tab page is selected. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedPage(){

return pInvokes.m_ts.fnGuiTabBookCtrl_getSelectedPage(_ID);
}
/// <summary>
/// Set the selected tab page.
///    @param index Index of the tab page. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectPage(int index){

pInvokes.m_ts.fnGuiTabBookCtrl_selectPage(_ID, index);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when a new tab page is selected.   @param text Text of the page header for the tab that is being selected.   @param index Index of the tab page being selected. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTabSelected(string text, uint index){}

        /// <summary>
        /// Called when the user right-clicks on a tab page header.   @param text Text of the page header for the tab that is being selected.   @param index Index of the tab page being selected. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTabRightClick(string text, uint index){}

#endregion
public GuiTabBookCtrl_Base (){}
}}
