


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiInspectorField_Base>))]
    public partial class GuiInspectorField_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiInspectorField_Base ts, string simobjectid)
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
        public static bool operator !=(GuiInspectorField_Base ts, string simobjectid)
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
        public static implicit operator string( GuiInspectorField_Base ts)
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
        public static implicit operator GuiInspectorField_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiInspectorField_Base) Omni.self.getSimObject(simobjectid,typeof(GuiInspectorField_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiInspectorField_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiInspectorField_Base(int simobjectid)
            {
            return  (GuiInspectorField) Omni.self.getSimObject((uint)simobjectid,typeof(GuiInspectorField_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiInspectorField_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiInspectorField_Base(uint simobjectid)
            {
            return  (GuiInspectorField_Base) Omni.self.getSimObject(simobjectid,typeof(GuiInspectorField_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// , true), ( string newValue, bool callbacks=true ) - Set the field's value. Suppress callbacks for undo if callbacks=false. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void apply(string newValue = "", bool callbacks = true){

pInvokes.m_ts.fn_GuiInspectorField_apply(_ID, newValue, callbacks);
}
/// <summary>
/// () - Set field value without recording undo (same as 'apply( value, false )'). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void applyWithoutUndo(string data){

pInvokes.m_ts.fn_GuiInspectorField_applyWithoutUndo(_ID, data);
}
/// <summary>
/// () - Return the value currently displayed on the field. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getData(){

return pInvokes.m_ts.fn_GuiInspectorField_getData(_ID);
}
/// <summary>
/// () - Return the name of the field edited by this inspector field. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getInspectedFieldName(){

return pInvokes.m_ts.fn_GuiInspectorField_getInspectedFieldName(_ID);
}
/// <summary>
/// () - Return the type of the field edited by this inspector field. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getInspectedFieldType(){

return pInvokes.m_ts.fn_GuiInspectorField_getInspectedFieldType(_ID);
}
/// <summary>
/// () - Return the GuiInspector to which this field belongs. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getInspector(){

return pInvokes.m_ts.fn_GuiInspectorField_getInspector(_ID);
}
/// <summary>
/// () - Reset to default value. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reset(){

pInvokes.m_ts.fn_GuiInspectorField_reset(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiInspectorField_Base (){}
}}
