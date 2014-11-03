


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
    [TypeConverter(typeof(TypeConverterGeneric<ForestEditorCtrl_Base>))]
    public partial class ForestEditorCtrl_Base: EditTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ForestEditorCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(ForestEditorCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( ForestEditorCtrl_Base ts)
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
        public static implicit operator ForestEditorCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ForestEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(ForestEditorCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ForestEditorCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestEditorCtrl_Base(int simobjectid)
            {
            return  (ForestEditorCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(ForestEditorCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ForestEditorCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestEditorCtrl_Base(uint simobjectid)
            {
            return  (ForestEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(ForestEditorCtrl_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ( ForestItemData obj ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteMeshSafe(string obj){

pInvokes.m_ts.fn_ForestEditorCtrl_deleteMeshSafe(_ID, obj);
}
/// <summary>
/// () )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getActiveTool(){

return pInvokes.m_ts.fn_ForestEditorCtrl_getActiveTool(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isDirty(){

return pInvokes.m_ts.fn_ForestEditorCtrl_isDirty(_ID);
}
/// <summary>
/// ( ForestTool tool ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setActiveTool(string toolName){

pInvokes.m_ts.fn_ForestEditorCtrl_setActiveTool(_ID, toolName);
}
/// <summary>
/// () )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void updateActiveForest(){

pInvokes.m_ts.fn_ForestEditorCtrl_updateActiveForest(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onActiveForestUpdated(string forest, string createNew){}

#endregion
public ForestEditorCtrl_Base (){}
}}
