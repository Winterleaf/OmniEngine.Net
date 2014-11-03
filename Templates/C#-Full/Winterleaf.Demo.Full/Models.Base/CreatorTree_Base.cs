


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
    [TypeConverter(typeof(TypeConverterGeneric<CreatorTree_Base>))]
    public partial class CreatorTree_Base: GuiArrayCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CreatorTree_Base ts, string simobjectid)
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
        public static bool operator !=(CreatorTree_Base ts, string simobjectid)
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
        public static implicit operator string( CreatorTree_Base ts)
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
        public static implicit operator CreatorTree_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (CreatorTree_Base) Omni.self.getSimObject(simobjectid,typeof(CreatorTree_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( CreatorTree_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CreatorTree_Base(int simobjectid)
            {
            return  (CreatorTree) Omni.self.getSimObject((uint)simobjectid,typeof(CreatorTree_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( CreatorTree_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CreatorTree_Base(uint simobjectid)
            {
            return  (CreatorTree_Base) Omni.self.getSimObject(simobjectid,typeof(CreatorTree_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// (string group, string name, string value))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int addGroup(int group, string name, string value){

return pInvokes.m_ts.fn_CreatorTree_addGroup(_ID, group, name, value);
}
/// <summary>
/// (Node group, string name, string value))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int addItem(int group, string name, string value){

return pInvokes.m_ts.fn_CreatorTree_addItem(_ID, group, name, value);
}
/// <summary>
/// Clear the tree.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void clear(){

pInvokes.m_ts.fn_CreatorTree_clear(_ID);
}
/// <summary>
/// (string world, string type, string filename))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool fileNameMatch(string world, string type, string filename){

return pInvokes.m_ts.fn_CreatorTree_fileNameMatch(_ID, world, type, filename);
}
/// <summary>
/// (Node item))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getName(string item){

return pInvokes.m_ts.fn_CreatorTree_getName(_ID, item);
}
/// <summary>
/// (Node n))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getParent(int nodeValue){

return pInvokes.m_ts.fn_CreatorTree_getParent(_ID, nodeValue);
}
/// <summary>
/// Return a handle to the currently selected item.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelected(){

return pInvokes.m_ts.fn_CreatorTree_getSelected(_ID);
}
/// <summary>
/// (Node n))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getValue(int nodeValue){

return pInvokes.m_ts.fn_CreatorTree_getValue(_ID, nodeValue);
}
/// <summary>
/// (Group g))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isGroup(string group){

return pInvokes.m_ts.fn_CreatorTree_isGroup(_ID, group);
}

#endregion
#region T3D Callbacks

#endregion
public CreatorTree_Base (){}
}}
