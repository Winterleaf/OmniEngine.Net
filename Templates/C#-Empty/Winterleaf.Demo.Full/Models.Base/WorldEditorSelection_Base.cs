


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
    [TypeConverter(typeof(TypeConverterGeneric<WorldEditorSelection_Base>))]
    public partial class WorldEditorSelection_Base: SimPersistSet
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WorldEditorSelection_Base ts, string simobjectid)
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
        public static bool operator !=(WorldEditorSelection_Base ts, string simobjectid)
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
        public static implicit operator string( WorldEditorSelection_Base ts)
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
        public static implicit operator WorldEditorSelection_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (WorldEditorSelection_Base) Omni.self.getSimObject(simobjectid,typeof(WorldEditorSelection_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( WorldEditorSelection_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WorldEditorSelection_Base(int simobjectid)
            {
            return  (WorldEditorSelection) Omni.self.getSimObject((uint)simobjectid,typeof(WorldEditorSelection_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( WorldEditorSelection_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WorldEditorSelection_Base(uint simobjectid)
            {
            return  (WorldEditorSelection_Base) Omni.self.getSimObject(simobjectid,typeof(WorldEditorSelection_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ( WorldEditorSelection, containsGlobalBounds, bool, 2, 2, () - True if an object with global bounds is contained in the selection. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool containsGlobalBounds(){

return pInvokes.m_ts.fnWorldEditorSelection_containsGlobalBounds(_ID);
}
/// <summary>
/// ( WorldEditorSelection, getBoxCentroid, const char*, 2, 2, () - Return the center of the bounding box around the selection. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getBoxCentroid(){

return pInvokes.m_ts.fnWorldEditorSelection_getBoxCentroid(_ID);
}
/// <summary>
/// ( WorldEditorSelection, getCentroid, const char*, 2, 2, () - Return the median of all object positions in the selection. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getCentroid(){

return pInvokes.m_ts.fnWorldEditorSelection_getCentroid(_ID);
}
/// <summary>
/// ( WorldEditorSelection, offset, void, 3, 4, ( vector delta, float gridSnap=0 ) - Move all objects in the selection by the given delta. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void offset(string a2, string a3= ""){

pInvokes.m_ts.fnWorldEditorSelection_offset(_ID, a2, a3);
}
/// <summary>
/// ( WorldEditorSelection, subtract, void, 3, 3, ( SimSet ) - Remove all objects in the given set from this selection. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void subtract(string a2){

pInvokes.m_ts.fnWorldEditorSelection_subtract(_ID, a2);
}
/// <summary>
/// ( WorldEditorSelection, union, void, 3, 3, ( SimSet set ) - Add all objects in the given set to this selection. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void union(string a2){

pInvokes.m_ts.fnWorldEditorSelection_union(_ID, a2);
}

#endregion
#region T3D Callbacks

#endregion
public WorldEditorSelection_Base (){}
}}
