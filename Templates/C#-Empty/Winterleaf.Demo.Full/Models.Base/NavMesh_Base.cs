


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
    [TypeConverter(typeof(TypeConverterGeneric<NavMesh_Base>))]
    public partial class NavMesh_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NavMesh_Base ts, string simobjectid)
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
        public static bool operator !=(NavMesh_Base ts, string simobjectid)
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
        public static implicit operator string( NavMesh_Base ts)
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
        public static implicit operator NavMesh_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (NavMesh_Base) Omni.self.getSimObject(simobjectid,typeof(NavMesh_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( NavMesh_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NavMesh_Base(int simobjectid)
            {
            return  (NavMesh) Omni.self.getSimObject((uint)simobjectid,typeof(NavMesh_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( NavMesh_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NavMesh_Base(uint simobjectid)
            {
            return  (NavMesh_Base) Omni.self.getSimObject(simobjectid,typeof(NavMesh_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Add a link to this NavMesh between two points.
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int addLink(Point3F from, Point3F to, uint flags = 0){

return pInvokes.m_ts.fnNavMesh_addLink(_ID, from.AsString(), to.AsString(), flags);
}
/// <summary>
/// @brief Create a Recast nav mesh.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool build(bool background = true, bool save = false){

return pInvokes.m_ts.fnNavMesh_build(_ID, background, save);
}
/// <summary>
/// @brief Build tiles of this mesh where there are unsynchronised links.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void buildLinks(){

pInvokes.m_ts.fnNavMesh_buildLinks(_ID);
}
/// <summary>
/// @brief Rebuild the tiles overlapped by the input box.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void buildTiles(Box3F box){

pInvokes.m_ts.fnNavMesh_buildTiles(_ID, box.AsString());
}
/// <summary>
/// @brief Cancel the current NavMesh build.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void cancelBuild(){

pInvokes.m_ts.fnNavMesh_cancelBuild(_ID);
}
/// <summary>
/// @brief Create cover points for this NavMesh.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool createCoverPoints(){

return pInvokes.m_ts.fnNavMesh_createCoverPoints(_ID);
}
/// <summary>
/// @brief Remove all cover points for this NavMesh.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteCoverPoints(){

pInvokes.m_ts.fnNavMesh_deleteCoverPoints(_ID);
}
/// <summary>
/// Delete a given off-mesh link.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteLink(uint id){

pInvokes.m_ts.fnNavMesh_deleteLink(_ID, id);
}
/// <summary>
/// Deletes all off-mesh links on this NavMesh.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteLinks(){

pInvokes.m_ts.fnNavMesh_deleteLinks(_ID);
}
/// <summary>
/// Get the off-mesh link closest to a given world point.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getLink(Point3F pos){

return pInvokes.m_ts.fnNavMesh_getLink(_ID, pos.AsString());
}
/// <summary>
/// Return the number of links this mesh has.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getLinkCount(){

return pInvokes.m_ts.fnNavMesh_getLinkCount(_ID);
}
/// <summary>
/// Get the ending point of an off-mesh link.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getLinkEnd(uint id){

return new Point3F ( pInvokes.m_ts.fnNavMesh_getLinkEnd(_ID, id));
}
/// <summary>
/// Get the flags set for a particular off-mesh link.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getLinkFlags(uint id){

return pInvokes.m_ts.fnNavMesh_getLinkFlags(_ID, id);
}
/// <summary>
/// Get the starting point of an off-mesh link.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getLinkStart(uint id){

return new Point3F ( pInvokes.m_ts.fnNavMesh_getLinkStart(_ID, id));
}
/// <summary>
/// @brief Load this NavMesh from its file.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool load(){

return pInvokes.m_ts.fnNavMesh_load(_ID);
}
/// <summary>
/// @brief Save this NavMesh to its file.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void save(){

pInvokes.m_ts.fnNavMesh_save(_ID);
}
/// <summary>
/// Set the flags of a particular off-mesh link.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setLinkFlags(uint id, uint flags){

pInvokes.m_ts.fnNavMesh_setLinkFlags(_ID, id, flags);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )IMPLEMENT_CALLBACK(NavMesh, OnWalkaboutDemoSave, void, (), (), )NavMesh::NavMesh()
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void OnWalkaboutDemoLimit(){}

#endregion
public NavMesh_Base (){}
}}
