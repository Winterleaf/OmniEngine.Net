


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
    [TypeConverter(typeof(TypeConverterGeneric<ForestSelectionTool_Base>))]
    public partial class ForestSelectionTool_Base: ForestTool
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ForestSelectionTool_Base ts, string simobjectid)
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
        public static bool operator !=(ForestSelectionTool_Base ts, string simobjectid)
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
        public static implicit operator string( ForestSelectionTool_Base ts)
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
        public static implicit operator ForestSelectionTool_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ForestSelectionTool_Base) Omni.self.getSimObject(simobjectid,typeof(ForestSelectionTool_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ForestSelectionTool_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestSelectionTool_Base(int simobjectid)
            {
            return  (ForestSelectionTool) Omni.self.getSimObject((uint)simobjectid,typeof(ForestSelectionTool_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ForestSelectionTool_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestSelectionTool_Base(uint simobjectid)
            {
            return  (ForestSelectionTool_Base) Omni.self.getSimObject(simobjectid,typeof(ForestSelectionTool_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearSelection(){

pInvokes.m_ts.fn_ForestSelectionTool_clearSelection(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void copySelection(){

pInvokes.m_ts.fn_ForestSelectionTool_copySelection(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void cutSelection(){

pInvokes.m_ts.fn_ForestSelectionTool_cutSelection(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteSelection(){

pInvokes.m_ts.fn_ForestSelectionTool_deleteSelection(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectionCount(){

return pInvokes.m_ts.fn_ForestSelectionTool_getSelectionCount(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pasteSelection(){

pInvokes.m_ts.fn_ForestSelectionTool_pasteSelection(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public ForestSelectionTool_Base (){}
}}
