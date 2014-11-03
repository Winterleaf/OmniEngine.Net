


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiInspectorTypeBitMask32_Base>))]
    public partial class GuiInspectorTypeBitMask32_Base: GuiInspectorField
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiInspectorTypeBitMask32_Base ts, string simobjectid)
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
        public static bool operator !=(GuiInspectorTypeBitMask32_Base ts, string simobjectid)
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
        public static implicit operator string( GuiInspectorTypeBitMask32_Base ts)
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
        public static implicit operator GuiInspectorTypeBitMask32_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiInspectorTypeBitMask32_Base) Omni.self.getSimObject(simobjectid,typeof(GuiInspectorTypeBitMask32_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiInspectorTypeBitMask32_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiInspectorTypeBitMask32_Base(int simobjectid)
            {
            return  (GuiInspectorTypeBitMask32) Omni.self.getSimObject((uint)simobjectid,typeof(GuiInspectorTypeBitMask32_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiInspectorTypeBitMask32_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiInspectorTypeBitMask32_Base(uint simobjectid)
            {
            return  (GuiInspectorTypeBitMask32_Base) Omni.self.getSimObject(simobjectid,typeof(GuiInspectorTypeBitMask32_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ( GuiInspectorTypeBitMask32, applyBit, void, 2,2, apply(); )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void applyBit(){

pInvokes.m_ts.fnGuiInspectorTypeBitMask32_applyBit(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiInspectorTypeBitMask32_Base (){}
}}
