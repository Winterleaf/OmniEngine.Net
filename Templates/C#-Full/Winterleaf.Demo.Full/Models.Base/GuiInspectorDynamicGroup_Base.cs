


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiInspectorDynamicGroup_Base>))]
    public partial class GuiInspectorDynamicGroup_Base: GuiInspectorGroup
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiInspectorDynamicGroup_Base ts, string simobjectid)
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
        public static bool operator !=(GuiInspectorDynamicGroup_Base ts, string simobjectid)
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
        public static implicit operator string( GuiInspectorDynamicGroup_Base ts)
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
        public static implicit operator GuiInspectorDynamicGroup_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiInspectorDynamicGroup_Base) Omni.self.getSimObject(simobjectid,typeof(GuiInspectorDynamicGroup_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiInspectorDynamicGroup_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiInspectorDynamicGroup_Base(int simobjectid)
            {
            return  (GuiInspectorDynamicGroup) Omni.self.getSimObject((uint)simobjectid,typeof(GuiInspectorDynamicGroup_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiInspectorDynamicGroup_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiInspectorDynamicGroup_Base(uint simobjectid)
            {
            return  (GuiInspectorDynamicGroup_Base) Omni.self.getSimObject(simobjectid,typeof(GuiInspectorDynamicGroup_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// obj.addDynamicField(); )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addDynamicField(){

pInvokes.m_ts.fn_GuiInspectorDynamicGroup_addDynamicField(_ID);
}
/// <summary>
/// Refreshes the dynamic fields in the inspector.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool inspectGroup(){

return pInvokes.m_ts.fn_GuiInspectorDynamicGroup_inspectGroup(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeDynamicField(){

pInvokes.m_ts.fn_GuiInspectorDynamicGroup_removeDynamicField(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiInspectorDynamicGroup_Base (){}
}}
