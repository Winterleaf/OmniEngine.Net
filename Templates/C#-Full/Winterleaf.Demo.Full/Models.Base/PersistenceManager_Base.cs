


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
    [TypeConverter(typeof(TypeConverterGeneric<PersistenceManager_Base>))]
    public partial class PersistenceManager_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PersistenceManager_Base ts, string simobjectid)
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
        public static bool operator !=(PersistenceManager_Base ts, string simobjectid)
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
        public static implicit operator string( PersistenceManager_Base ts)
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
        public static implicit operator PersistenceManager_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (PersistenceManager_Base) Omni.self.getSimObject(simobjectid,typeof(PersistenceManager_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( PersistenceManager_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PersistenceManager_Base(int simobjectid)
            {
            return  (PersistenceManager) Omni.self.getSimObject((uint)simobjectid,typeof(PersistenceManager_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( PersistenceManager_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PersistenceManager_Base(uint simobjectid)
            {
            return  (PersistenceManager_Base) Omni.self.getSimObject(simobjectid,typeof(PersistenceManager_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ()
///               Clears all the tracked objects without saving them. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearAll(){

pInvokes.m_ts.fn_PersistenceManager_clearAll(_ID);
}
/// <summary>
/// ( fileName )
///               Delete all of the objects that are created from the given file. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteObjectsFromFile(string fileName){

pInvokes.m_ts.fn_PersistenceManager_deleteObjectsFromFile(_ID, fileName);
}
/// <summary>
/// ( index )
///               Returns the ith dirty object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getDirtyObject(int index){

return pInvokes.m_ts.fn_PersistenceManager_getDirtyObject(_ID, index);
}
/// <summary>
/// ()
///               Returns the number of dirty objects. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getDirtyObjectCount(){

return pInvokes.m_ts.fn_PersistenceManager_getDirtyObjectCount(_ID);
}
/// <summary>
/// ()
///               Returns true if the manager has dirty objects to save. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool hasDirty(){

return pInvokes.m_ts.fn_PersistenceManager_hasDirty(_ID);
}
/// <summary>
/// (SimObject object)
///               Returns true if the SimObject is on the dirty list.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isDirty(string objName){

return pInvokes.m_ts.fn_PersistenceManager_isDirty(_ID, objName);
}
/// <summary>
/// ()
///               Prints the dirty list to the console.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void listDirty(){

pInvokes.m_ts.fn_PersistenceManager_listDirty(_ID);
}
/// <summary>
/// (SimObject object)
///               Remove a SimObject from the dirty list.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeDirty(string objName){

pInvokes.m_ts.fn_PersistenceManager_removeDirty(_ID, objName);
}
/// <summary>
/// (SimObject object, string fieldName)
///               Remove a specific field from an object declaration.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeField(string objName, string fieldName){

pInvokes.m_ts.fn_PersistenceManager_removeField(_ID, objName, fieldName);
}
/// <summary>
/// ) , (SimObject object, [filename])
///               Remove an existing SimObject from a file (can optionally specify a different file than \
///                the one it was created in.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeObjectFromFile(string objName, string filename = ""){

pInvokes.m_ts.fn_PersistenceManager_removeObjectFromFile(_ID, objName, filename);
}
/// <summary>
/// ()
///               Saves all of the SimObject's on the dirty list to their respective files.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool saveDirty(){

return pInvokes.m_ts.fn_PersistenceManager_saveDirty(_ID);
}
/// <summary>
/// (SimObject object)
///               Save a dirty SimObject to it's file.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool saveDirtyObject(string objName){

return pInvokes.m_ts.fn_PersistenceManager_saveDirtyObject(_ID, objName);
}
/// <summary>
/// ), (SimObject object, [filename])
///               Mark an existing SimObject as dirty (will be written out when saveDirty() is called).)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDirty(string objName, string fileName = ""){

pInvokes.m_ts.fn_PersistenceManager_setDirty(_ID, objName, fileName);
}

#endregion
#region T3D Callbacks

#endregion
public PersistenceManager_Base (){}
}}
