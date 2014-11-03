


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
    [TypeConverter(typeof(TypeConverterGeneric<ArrayObject_Base>))]
    public partial class ArrayObject_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ArrayObject_Base ts, string simobjectid)
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
        public static bool operator !=(ArrayObject_Base ts, string simobjectid)
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
        public static implicit operator string( ArrayObject_Base ts)
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
        public static implicit operator ArrayObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ArrayObject_Base) Omni.self.getSimObject(simobjectid,typeof(ArrayObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ArrayObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ArrayObject_Base(int simobjectid)
            {
            return  (ArrayObject) Omni.self.getSimObject((uint)simobjectid,typeof(ArrayObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ArrayObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ArrayObject_Base(uint simobjectid)
            {
            return  (ArrayObject_Base) Omni.self.getSimObject(simobjectid,typeof(ArrayObject_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Makes the keys and values case-sensitive.\n   By default, comparison of key and value strings will be case-insensitive. 
/// </summary>
[MemberGroup("")]
public bool caseSensitive
       {
       get
          {
          return Omni.self.GetVar(_ID + ".caseSensitive").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".caseSensitive", value.AsString());
          }
       }
/// <summary>
/// Helper field which allows you to add new key['keyname'] = value pairs. 
/// </summary>
[MemberGroup("")]
public String key
       {
       get
          {
          return Omni.self.GetVar(_ID + ".key").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".key", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
///  ),
///    Adds a new element to the end of an array (same as push_back()).
///    @param key Key for the new element
///    @param value Value for the new element )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void add(string key, string value = ""){

pInvokes.m_ts.fnArrayObject_add(_ID, key, value);
}
/// <summary>
/// Appends the target array to the array object.
///    @param target ArrayObject to append to the end of this array )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool append(string target){

return pInvokes.m_ts.fnArrayObject_append(_ID, target);
}
/// <summary>
/// Get the number of elements in the array. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int count(){

return pInvokes.m_ts.fnArrayObject_count(_ID);
}
/// <summary>
/// Get the number of times a particular key is found in the array.
///    @param key Key value to count )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int countKey(string key){

return pInvokes.m_ts.fnArrayObject_countKey(_ID, key);
}
/// <summary>
/// Get the number of times a particular value is found in the array.
///    @param value Array element value to count )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int countValue(string value){

return pInvokes.m_ts.fnArrayObject_countValue(_ID, value);
}
/// <summary>
/// Removes elements with matching keys from array.
///    @param target ArrayObject containing keys to remove from this array )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool crop(string target){

return pInvokes.m_ts.fnArrayObject_crop(_ID, target);
}
/// <summary>
/// Alters array into an exact duplicate of the target array.
///    @param target ArrayObject to duplicate )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool duplicate(string target){

return pInvokes.m_ts.fnArrayObject_duplicate(_ID, target);
}
/// <summary>
/// Echos the array contents to the console )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void echo(){

pInvokes.m_ts.fnArrayObject_echo(_ID);
}
/// <summary>
/// Emptys all elements from an array )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void empty(){

pInvokes.m_ts.fnArrayObject_empty(_ID);
}
/// <summary>
/// Removes an element at a specific position from the array.
///    @param index 0-based index of the element to remove )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void erase(int index){

pInvokes.m_ts.fnArrayObject_erase(_ID, index);
}
/// <summary>
/// Gets the current pointer index )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getCurrent(){

return pInvokes.m_ts.fnArrayObject_getCurrent(_ID);
}
/// <summary>
/// Search the array from the current position for the key 
///    @param value Array key to search for
///    @return Index of the first element found, or -1 if none )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getIndexFromKey(string key){

return pInvokes.m_ts.fnArrayObject_getIndexFromKey(_ID, key);
}
/// <summary>
/// Search the array from the current position for the element 
///    @param value Array value to search for
///    @return Index of the first element found, or -1 if none )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getIndexFromValue(string value){

return pInvokes.m_ts.fnArrayObject_getIndexFromValue(_ID, value);
}
/// <summary>
/// Get the key of the array element at the submitted index.
///    @param index 0-based index of the array element to get
///    @return The key associated with the array element at the 
///    specified index, or \"\" if the index is out of range )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getKey(int index){

return pInvokes.m_ts.fnArrayObject_getKey(_ID, index);
}
/// <summary>
/// Get the value of the array element at the submitted index.
///    @param index 0-based index of the array element to get
///    @return The value of the array element at the specified index, 
///    or \"\" if the index is out of range )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getValue(int index){

return pInvokes.m_ts.fnArrayObject_getValue(_ID, index);
}
/// <summary>
/// Adds a new element to a specified position in the array.
///    - @a index = 0 will insert an element at the start of the array (same as push_front())
///    - @a index = %array.count() will insert an element at the end of the array (same as push_back())
///    @param key Key for the new element
///    @param value Value for the new element
///    @param index 0-based index at which to insert the new element )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void insert(string key, string value, int index){

pInvokes.m_ts.fnArrayObject_insert(_ID, key, value, index);
}
/// <summary>
/// Moves array pointer to start of array
///    @return Returns the new array pointer )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int moveFirst(){

return pInvokes.m_ts.fnArrayObject_moveFirst(_ID);
}
/// <summary>
/// Moves array pointer to end of array
///    @return Returns the new array pointer )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int moveLast(){

return pInvokes.m_ts.fnArrayObject_moveLast(_ID);
}
/// <summary>
/// Moves array pointer to next position
///    @return Returns the new array pointer, or -1 if already at the end )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int moveNext(){

return pInvokes.m_ts.fnArrayObject_moveNext(_ID);
}
/// <summary>
/// Moves array pointer to prev position
///    @return Returns the new array pointer, or -1 if already at the start )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int movePrev(){

return pInvokes.m_ts.fnArrayObject_movePrev(_ID);
}
/// <summary>
/// Removes the last element from the array )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pop_back(){

pInvokes.m_ts.fnArrayObject_pop_back(_ID);
}
/// <summary>
/// Removes the first element from the array )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pop_front(){

pInvokes.m_ts.fnArrayObject_pop_front(_ID);
}
/// <summary>
///  ),
///    Adds a new element to the end of an array.
///    @param key Key for the new element
///    @param value Value for the new element )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void push_back(string key, string value = ""){

pInvokes.m_ts.fnArrayObject_push_back(_ID, key, value);
}
/// <summary>
///  ),
///    Adds a new element to the front of an array )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void push_front(string key, string value = ""){

pInvokes.m_ts.fnArrayObject_push_front(_ID, key, value);
}
/// <summary>
/// Sets the current pointer index.
///    @param index New 0-based pointer index )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCurrent(int index){

pInvokes.m_ts.fnArrayObject_setCurrent(_ID, index);
}
/// <summary>
/// Set the key at the given index.
///    @param key New key value
///    @param index 0-based index of the array element to update )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setKey(string key, int index){

pInvokes.m_ts.fnArrayObject_setKey(_ID, key, index);
}
/// <summary>
/// Set the value at the given index.
///    @param value New array element value
///    @param index 0-based index of the array element to update )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setValue(string value, int index){

pInvokes.m_ts.fnArrayObject_setValue(_ID, value, index);
}
/// <summary>
/// Alpha sorts the array by value
///    @param ascending [optional] True for ascending sort, false for descending sort )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sort(bool ascending = false){

pInvokes.m_ts.fnArrayObject_sort(_ID, ascending);
}
/// <summary>
/// Alpha sorts the array by value in ascending order )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sorta(){

pInvokes.m_ts.fnArrayObject_sorta(_ID);
}
/// <summary>
/// Alpha sorts the array by value in descending order )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortd(){

pInvokes.m_ts.fnArrayObject_sortd(_ID);
}
/// <summary>
/// Sorts the array by value in ascending order using the given callback function.
///    @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.
///    @tsexample
///    function mySortCallback(%a, %b)
///    {
///       return strcmp( %a.name, %b.name );
///    }
///    %array.sortf( \"mySortCallback\" );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortf(string functionName){

pInvokes.m_ts.fnArrayObject_sortf(_ID, functionName);
}
/// <summary>
/// Sorts the array by value in descending order using the given callback function.
///    @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.
///    @see sortf )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortfd(string functionName){

pInvokes.m_ts.fnArrayObject_sortfd(_ID, functionName);
}
/// <summary>
/// Sorts the array by key in ascending order using the given callback function.
///    @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.
///    @see sortf )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortfk(string functionName){

pInvokes.m_ts.fnArrayObject_sortfk(_ID, functionName);
}
/// <summary>
/// Sorts the array by key in descending order using the given callback function.
///    @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.
///    @see sortf )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortfkd(string functionName){

pInvokes.m_ts.fnArrayObject_sortfkd(_ID, functionName);
}
/// <summary>
/// Alpha sorts the array by key
///    @param ascending [optional] True for ascending sort, false for descending sort )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortk(bool ascending = false){

pInvokes.m_ts.fnArrayObject_sortk(_ID, ascending);
}
/// <summary>
/// Alpha sorts the array by key in ascending order )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortka(){

pInvokes.m_ts.fnArrayObject_sortka(_ID);
}
/// <summary>
/// Alpha sorts the array by key in descending order )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortkd(){

pInvokes.m_ts.fnArrayObject_sortkd(_ID);
}
/// <summary>
/// Numerically sorts the array by value
///    @param ascending [optional] True for ascending sort, false for descending sort )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortn(bool ascending = false){

pInvokes.m_ts.fnArrayObject_sortn(_ID, ascending);
}
/// <summary>
/// Numerically sorts the array by value in ascending order ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortna(){

pInvokes.m_ts.fnArrayObject_sortna(_ID);
}
/// <summary>
/// Numerically sorts the array by value in descending order )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortnd(){

pInvokes.m_ts.fnArrayObject_sortnd(_ID);
}
/// <summary>
/// Numerically sorts the array by key
///    @param ascending [optional] True for ascending sort, false for descending sort )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortnk(bool ascending = false){

pInvokes.m_ts.fnArrayObject_sortnk(_ID, ascending);
}
/// <summary>
/// Numerical sorts the array by key in ascending order )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortnka(){

pInvokes.m_ts.fnArrayObject_sortnka(_ID);
}
/// <summary>
/// Numerical sorts the array by key in descending order )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void sortnkd(){

pInvokes.m_ts.fnArrayObject_sortnkd(_ID);
}
/// <summary>
/// Removes any elements that have duplicated keys (leaving the first instance) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void uniqueKey(){

pInvokes.m_ts.fnArrayObject_uniqueKey(_ID);
}
/// <summary>
/// Removes any elements that have duplicated values (leaving the first instance) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void uniqueValue(){

pInvokes.m_ts.fnArrayObject_uniqueValue(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public ArrayObject_Base (){}
}}
