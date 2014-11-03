


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
    [TypeConverter(typeof(TypeConverterGeneric<FieldBrushObject_Base>))]
    public partial class FieldBrushObject_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(FieldBrushObject_Base ts, string simobjectid)
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
        public static bool operator !=(FieldBrushObject_Base ts, string simobjectid)
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
        public static implicit operator string( FieldBrushObject_Base ts)
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
        public static implicit operator FieldBrushObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (FieldBrushObject_Base) Omni.self.getSimObject(simobjectid,typeof(FieldBrushObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( FieldBrushObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FieldBrushObject_Base(int simobjectid)
            {
            return  (FieldBrushObject) Omni.self.getSimObject((uint)simobjectid,typeof(FieldBrushObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( FieldBrushObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FieldBrushObject_Base(uint simobjectid)
            {
            return  (FieldBrushObject_Base) Omni.self.getSimObject(simobjectid,typeof(FieldBrushObject_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String description
       {
       get
          {
          return Omni.self.GetVar(_ID + ".description").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".description", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String sortName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sortName").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sortName", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ), (simObject, [fieldList]) Copy selected static-fields for selected object./
///                                                         @param simObject Object to copy static-fields from.
///                                                         @param fieldList fields to filter static-fields against.
/// 			                                            @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void copyFields(string simObjName, string pFieldList = ""){

pInvokes.m_ts.fn_FieldBrushObject_copyFields(_ID, simObjName, pFieldList);
}
/// <summary>
/// (simObject) Paste copied static-fields to selected object./
///                                                         @param simObject Object to paste static-fields to.
/// 			                                            @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pasteFields(string simObjName){

pInvokes.m_ts.fn_FieldBrushObject_pasteFields(_ID, simObjName);
}
/// <summary>
/// ), (simObject, [groupList]) Query available static-fields for selected object./
///                                                                 @param simObject Object to query static-fields on.
///                                                                 @param groupList groups to filter static-fields against.
/// 			                                                    @return Space-seperated static-field list.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string queryFields(string simObjName, string groupList = ""){

return pInvokes.m_ts.fn_FieldBrushObject_queryFields(_ID, simObjName, groupList);
}
/// <summary>
/// (simObject) Query available static-field groups for selected object./
///                                                                 @param simObject Object to query static-field groups on.
/// 			                                                    @return Space-seperated static-field group list.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string queryGroups(string simObjName){

return pInvokes.m_ts.fn_FieldBrushObject_queryGroups(_ID, simObjName);
}

#endregion
#region T3D Callbacks

#endregion
public FieldBrushObject_Base (){}
}}
