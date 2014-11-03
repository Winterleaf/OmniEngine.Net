


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
    [TypeConverter(typeof(TypeConverterGeneric<SimSet_Base>))]
    public partial class SimSet_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SimSet_Base ts, string simobjectid)
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
        public static bool operator !=(SimSet_Base ts, string simobjectid)
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
        public static implicit operator string( SimSet_Base ts)
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
        public static implicit operator SimSet_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SimSet_Base) Omni.self.getSimObject(simobjectid,typeof(SimSet_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SimSet_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SimSet_Base(int simobjectid)
            {
            return  (SimSet) Omni.self.getSimObject((uint)simobjectid,typeof(SimSet_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SimSet_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SimSet_Base(uint simobjectid)
            {
            return  (SimSet_Base) Omni.self.getSimObject(simobjectid,typeof(SimSet_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// () Delete all objects in the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteAllObjects(){

pInvokes.m_ts.fn_SimSet_deleteAllObjects(_ID);
}
/// <summary>
/// () Get the number of direct and indirect child objects contained in the set.
///    @return The number of objects contained in the set as well as in other sets contained directly or indirectly in the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getFullCount(){

return pInvokes.m_ts.fn_SimSet_getFullCount(_ID);
}
/// <summary>
/// ( string callbackFunction ) Sort the objects in the set using the given comparison function.
///    @param callbackFunction Name of a function that takes two object arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sort(string callbackFunction){

pInvokes.m_ts.fn_SimSet_sort(_ID, callbackFunction);
}
/// <summary>
/// Test whether the given object may be added to the set.
///    @param obj The object to test for potential membership.
///    @return True if the object may be added to the set, false otherwise. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool acceptsAsChild(string obj){

return pInvokes.m_ts.fnSimSet_acceptsAsChild(_ID, obj);
}
/// <summary>
/// ( SimSet, add, void, 3, 0,
///    ( SimObject objects... ) Add the given objects to the set.
///    @param objects The objects to add to the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void add(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){

pInvokes.m_ts.fnSimSet_add(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Make the given object the first object in the set.
///    @param obj The object to bring to the frontmost position.  Must be contained in the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void bringToFront(string obj){

pInvokes.m_ts.fnSimSet_bringToFront(_ID, obj);
}
/// <summary>
/// ( SimSet, callOnChildren, void, 3, 0,
///    ( string method, string args... ) Call a method on all objects contained in the set.
///    @param method The name of the method to call.
///    @param args The arguments to the method.
///    @note This method recurses into all SimSets that are children to the set.
///    @see callOnChildrenNoRecurse )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void callOnChildren(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){

pInvokes.m_ts.fnSimSet_callOnChildren(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// ( SimSet, callOnChildrenNoRecurse, void, 3, 0,
///    ( string method, string args... ) Call a method on all objects contained in the set.
///    @param method The name of the method to call.
///    @param args The arguments to the method.
///    @note This method does not recurse into child SimSets.
///    @see callOnChildren )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void callOnChildrenNoRecurse(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){

pInvokes.m_ts.fnSimSet_callOnChildrenNoRecurse(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Remove all objects from the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clear(){

pInvokes.m_ts.fnSimSet_clear(_ID);
}
/// <summary>
/// Find an object in the set by its internal name.
///    @param internalName The internal name of the object to look for.
///    @param searchChildren If true, SimSets contained in the set will be recursively searched for the object.
///    @return The object with the given internal name or 0 if no match was found. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string findObjectByInternalName(string internalName, bool searchChildren = false){

return pInvokes.m_ts.fnSimSet_findObjectByInternalName(_ID, internalName, searchChildren);
}
/// <summary>
/// Get the number of objects contained in the set.
///    @return The number of objects contained in the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getCount(){

return pInvokes.m_ts.fnSimSet_getCount(_ID);
}
/// <summary>
/// Get the object at the given index.
///    @param index The object index.
///    @return The object at the given index or -1 if index is out of range. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getObject(uint index){

return pInvokes.m_ts.fnSimSet_getObject(_ID, index);
}
/// <summary>
/// Return the index of the given object in this set.
///    @param obj The object for which to return the index.  Must be contained in the set.
///    @return The index of the object or -1 if the object is not contained in the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getObjectIndex(string obj){

return pInvokes.m_ts.fnSimSet_getObjectIndex(_ID, obj);
}
/// <summary>
/// Return a random object from the set.
///    @return A randomly selected object from the set or -1 if the set is empty. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getRandom(){

return pInvokes.m_ts.fnSimSet_getRandom(_ID);
}
/// <summary>
/// Test whether the given object belongs to the set.
///    @param obj The object.
///    @return True if the object is contained in the set; false otherwise. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isMember(string obj){

return pInvokes.m_ts.fnSimSet_isMember(_ID, obj);
}
/// <summary>
/// Dump a list of all objects contained in the set to the console. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void listObjects(){

pInvokes.m_ts.fnSimSet_listObjects(_ID);
}
/// <summary>
/// Make the given object the last object in the set.
///    @param obj The object to bring to the last position.  Must be contained in the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pushToBack(string obj){

pInvokes.m_ts.fnSimSet_pushToBack(_ID, obj);
}
/// <summary>
/// ( SimSet, remove, void, 3, 0,
///    ( SimObject objects... ) Remove the given objects from the set.
///    @param objects The objects to remove from the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void remove(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){

pInvokes.m_ts.fnSimSet_remove(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Make sure child1 is ordered right before child2 in the set.
///    @param child1 The first child.  The object must already be contained in the set.
///    @param child2 The second child.  The object must already be contained in the set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reorderChild(string child1, string child2){

pInvokes.m_ts.fnSimSet_reorderChild(_ID, child1, child2);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when an object is added to the set.   @param object The object that was added. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onObjectAdded(SimObject objectx){}

        /// <summary>
        /// Called when an object is removed from the set.   @param object The object that was removed. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onObjectRemoved(SimObject objectx){}

#endregion
public SimSet_Base (){}
}}
