// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<ArrayObject_Base>))]
    public partial class ArrayObject_Base : SimObject
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
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ArrayObject_Base ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(ArrayObject_Base ts)
        {
            if (ReferenceEquals(ts, null))
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
            return (ArrayObject_Base) Omni.self.getSimObject(simobjectid, typeof (ArrayObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ArrayObject_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ArrayObject_Base(int simobjectid)
        {
            return (ArrayObject) Omni.self.getSimObject((uint) simobjectid, typeof (ArrayObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ArrayObject_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ArrayObject_Base(uint simobjectid)
        {
            return (ArrayObject_Base) Omni.self.getSimObject(simobjectid, typeof (ArrayObject_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Makes the keys and values case-sensitive.\n   By default, comparison of key and value strings will be case-insensitive. 
        /// </summary>
        [MemberGroup("")]
        public bool caseSensitive
        {
            get { return Omni.self.GetVar(_ID + ".caseSensitive").AsBool(); }
            set { Omni.self.SetVar(_ID + ".caseSensitive", value.AsString()); }
        }

        /// <summary>
        /// Helper field which allows you to add new key['keyname'] = value pairs. 
        /// </summary>
        [MemberGroup("")]
        public String key
        {
            get { return Omni.self.GetVar(_ID + ".key").AsString(); }
            set { Omni.self.SetVar(_ID + ".key", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        ///  ),   Adds a new element to the end of an array (same as push_back()).   @param key Key for the new element   @param value Value for the new element )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void add(string key, string value = "")
        {
            m_ts.fnArrayObject_add(_ID, key, value);
        }

        /// <summary>
        /// Appends the target array to the array object.   @param target ArrayObject to append to the end of this array )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool append(string target)
        {
            return m_ts.fnArrayObject_append(_ID, target);
        }

        /// <summary>
        /// Get the number of elements in the array. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int count()
        {
            return m_ts.fnArrayObject_count(_ID);
        }

        /// <summary>
        /// Get the number of times a particular key is found in the array.   @param key Key value to count )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int countKey(string key)
        {
            return m_ts.fnArrayObject_countKey(_ID, key);
        }

        /// <summary>
        /// Get the number of times a particular value is found in the array.   @param value Array element value to count )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int countValue(string value)
        {
            return m_ts.fnArrayObject_countValue(_ID, value);
        }

        /// <summary>
        /// Removes elements with matching keys from array.   @param target ArrayObject containing keys to remove from this array )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool crop(string target)
        {
            return m_ts.fnArrayObject_crop(_ID, target);
        }

        /// <summary>
        /// Alters array into an exact duplicate of the target array.   @param target ArrayObject to duplicate )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool duplicate(string target)
        {
            return m_ts.fnArrayObject_duplicate(_ID, target);
        }

        /// <summary>
        /// Echos the array contents to the console )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void echo()
        {
            m_ts.fnArrayObject_echo(_ID);
        }

        /// <summary>
        /// Emptys all elements from an array )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void empty()
        {
            m_ts.fnArrayObject_empty(_ID);
        }

        /// <summary>
        /// Removes an element at a specific position from the array.   @param index 0-based index of the element to remove )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void erase(int index)
        {
            m_ts.fnArrayObject_erase(_ID, index);
        }

        /// <summary>
        /// Gets the current pointer index )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getCurrent()
        {
            return m_ts.fnArrayObject_getCurrent(_ID);
        }

        /// <summary>
        /// Search the array from the current position for the key    @param value Array key to search for   @return Index of the first element found, or -1 if none )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getIndexFromKey(string key)
        {
            return m_ts.fnArrayObject_getIndexFromKey(_ID, key);
        }

        /// <summary>
        /// Search the array from the current position for the element    @param value Array value to search for   @return Index of the first element found, or -1 if none )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getIndexFromValue(string value)
        {
            return m_ts.fnArrayObject_getIndexFromValue(_ID, value);
        }

        /// <summary>
        /// Get the key of the array element at the submitted index.   @param index 0-based index of the array element to get   @return The key associated with the array element at the    specified index, or \"\" if the index is out of range )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getKey(int index)
        {
            return m_ts.fnArrayObject_getKey(_ID, index);
        }

        /// <summary>
        /// Get the value of the array element at the submitted index.   @param index 0-based index of the array element to get   @return The value of the array element at the specified index,    or \"\" if the index is out of range )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getValue(int index)
        {
            return m_ts.fnArrayObject_getValue(_ID, index);
        }

        /// <summary>
        /// Adds a new element to a specified position in the array.   - @a index = 0 will insert an element at the start of the array (same as push_front())   - @a index = %array.count() will insert an element at the end of the array (same as push_back())   @param key Key for the new element   @param value Value for the new element   @param index 0-based index at which to insert the new element )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void insert(string key, string value, int index)
        {
            m_ts.fnArrayObject_insert(_ID, key, value, index);
        }

        /// <summary>
        /// Moves array pointer to start of array   @return Returns the new array pointer )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int moveFirst()
        {
            return m_ts.fnArrayObject_moveFirst(_ID);
        }

        /// <summary>
        /// Moves array pointer to end of array   @return Returns the new array pointer )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int moveLast()
        {
            return m_ts.fnArrayObject_moveLast(_ID);
        }

        /// <summary>
        /// Moves array pointer to next position   @return Returns the new array pointer, or -1 if already at the end )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int moveNext()
        {
            return m_ts.fnArrayObject_moveNext(_ID);
        }

        /// <summary>
        /// Moves array pointer to prev position   @return Returns the new array pointer, or -1 if already at the start )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int movePrev()
        {
            return m_ts.fnArrayObject_movePrev(_ID);
        }

        /// <summary>
        /// Removes the last element from the array )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pop_back()
        {
            m_ts.fnArrayObject_pop_back(_ID);
        }

        /// <summary>
        /// Removes the first element from the array )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pop_front()
        {
            m_ts.fnArrayObject_pop_front(_ID);
        }

        /// <summary>
        ///  ),   Adds a new element to the end of an array.   @param key Key for the new element   @param value Value for the new element )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void push_back(string key, string value = "")
        {
            m_ts.fnArrayObject_push_back(_ID, key, value);
        }

        /// <summary>
        ///  ),   Adds a new element to the front of an array )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void push_front(string key, string value = "")
        {
            m_ts.fnArrayObject_push_front(_ID, key, value);
        }

        /// <summary>
        /// Sets the current pointer index.   @param index New 0-based pointer index )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setCurrent(int index)
        {
            m_ts.fnArrayObject_setCurrent(_ID, index);
        }

        /// <summary>
        /// Set the key at the given index.   @param key New key value   @param index 0-based index of the array element to update )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setKey(string key, int index)
        {
            m_ts.fnArrayObject_setKey(_ID, key, index);
        }

        /// <summary>
        /// Set the value at the given index.   @param value New array element value   @param index 0-based index of the array element to update )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setValue(string value, int index)
        {
            m_ts.fnArrayObject_setValue(_ID, value, index);
        }

        /// <summary>
        /// Alpha sorts the array by value   @param ascending [optional] True for ascending sort, false for descending sort )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sort(bool ascending = false)
        {
            m_ts.fnArrayObject_sort(_ID, ascending);
        }

        /// <summary>
        /// Alpha sorts the array by value in ascending order )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sorta()
        {
            m_ts.fnArrayObject_sorta(_ID);
        }

        /// <summary>
        /// Alpha sorts the array by value in descending order )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortd()
        {
            m_ts.fnArrayObject_sortd(_ID);
        }

        /// <summary>
        /// Sorts the array by value in ascending order using the given callback function.   @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.   @tsexample   function mySortCallback(%a, %b)   {      return strcmp( %a.name, %b.name );   }   %array.sortf( \"mySortCallback\" );   @endtsexample )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortf(string functionName)
        {
            m_ts.fnArrayObject_sortf(_ID, functionName);
        }

        /// <summary>
        /// Sorts the array by value in descending order using the given callback function.   @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.   @see sortf )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortfd(string functionName)
        {
            m_ts.fnArrayObject_sortfd(_ID, functionName);
        }

        /// <summary>
        /// Sorts the array by key in ascending order using the given callback function.   @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.   @see sortf )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortfk(string functionName)
        {
            m_ts.fnArrayObject_sortfk(_ID, functionName);
        }

        /// <summary>
        /// Sorts the array by key in descending order using the given callback function.   @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.   @see sortf )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortfkd(string functionName)
        {
            m_ts.fnArrayObject_sortfkd(_ID, functionName);
        }

        /// <summary>
        /// Alpha sorts the array by key   @param ascending [optional] True for ascending sort, false for descending sort )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortk(bool ascending = false)
        {
            m_ts.fnArrayObject_sortk(_ID, ascending);
        }

        /// <summary>
        /// Alpha sorts the array by key in ascending order )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortka()
        {
            m_ts.fnArrayObject_sortka(_ID);
        }

        /// <summary>
        /// Alpha sorts the array by key in descending order )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortkd()
        {
            m_ts.fnArrayObject_sortkd(_ID);
        }

        /// <summary>
        /// Numerically sorts the array by value   @param ascending [optional] True for ascending sort, false for descending sort )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortn(bool ascending = false)
        {
            m_ts.fnArrayObject_sortn(_ID, ascending);
        }

        /// <summary>
        /// Numerically sorts the array by value in ascending order ) 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortna()
        {
            m_ts.fnArrayObject_sortna(_ID);
        }

        /// <summary>
        /// Numerically sorts the array by value in descending order )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortnd()
        {
            m_ts.fnArrayObject_sortnd(_ID);
        }

        /// <summary>
        /// Numerically sorts the array by key   @param ascending [optional] True for ascending sort, false for descending sort )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortnk(bool ascending = false)
        {
            m_ts.fnArrayObject_sortnk(_ID, ascending);
        }

        /// <summary>
        /// Numerical sorts the array by key in ascending order )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortnka()
        {
            m_ts.fnArrayObject_sortnka(_ID);
        }

        /// <summary>
        /// Numerical sorts the array by key in descending order )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortnkd()
        {
            m_ts.fnArrayObject_sortnkd(_ID);
        }

        /// <summary>
        /// Removes any elements that have duplicated keys (leaving the first instance) )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void uniqueKey()
        {
            m_ts.fnArrayObject_uniqueKey(_ID);
        }

        /// <summary>
        /// Removes any elements that have duplicated values (leaving the first instance) )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void uniqueValue()
        {
            m_ts.fnArrayObject_uniqueValue(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public ArrayObject_Base()
        {
        }
    }
}