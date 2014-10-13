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

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<SimSet_Base>))]
    public partial class SimSet_Base : SimObject
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
        public static bool operator !=(SimSet_Base ts, string simobjectid)
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
        public static implicit operator string(SimSet_Base ts)
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
        public static implicit operator SimSet_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SimSet_Base) Omni.self.getSimObject(simobjectid, typeof (SimSet_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SimSet_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SimSet_Base(int simobjectid)
        {
            return (SimSet) Omni.self.getSimObject((uint) simobjectid, typeof (SimSet_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SimSet_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SimSet_Base(uint simobjectid)
        {
            return (SimSet_Base) Omni.self.getSimObject(simobjectid, typeof (SimSet_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// () Delete all objects in the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void deleteAllObjects()
        {
            m_ts.fn_SimSet_deleteAllObjects(_ID);
        }

        /// <summary>
        /// () Get the number of direct and indirect child objects contained in the set.   @return The number of objects contained in the set as well as in other sets contained directly or indirectly in the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getFullCount()
        {
            return m_ts.fn_SimSet_getFullCount(_ID);
        }

        /// <summary>
        /// ( string callbackFunction ) Sort the objects in the set using the given comparison function.   @param callbackFunction Name of a function that takes two object arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sort(string callbackFunction)
        {
            m_ts.fn_SimSet_sort(_ID, callbackFunction);
        }

        /// <summary>
        /// Test whether the given object may be added to the set.   @param obj The object to test for potential membership.   @return True if the object may be added to the set, false otherwise. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool acceptsAsChild(string obj)
        {
            return m_ts.fnSimSet_acceptsAsChild(_ID, obj);
        }

        /// <summary>
        /// ( SimSet, add, void, 3, 0,   ( SimObject objects... ) Add the given objects to the set.   @param objects The objects to add to the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void add(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
        {
            m_ts.fnSimSet_add(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
        }

        /// <summary>
        /// Make the given object the first object in the set.   @param obj The object to bring to the frontmost position.  Must be contained in the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void bringToFront(string obj)
        {
            m_ts.fnSimSet_bringToFront(_ID, obj);
        }

        /// <summary>
        /// ( SimSet, callOnChildren, void, 3, 0,   ( string method, string args... ) Call a method on all objects contained in the set.   @param method The name of the method to call.   @param args The arguments to the method.   @note This method recurses into all SimSets that are children to the set.   @see callOnChildrenNoRecurse )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void callOnChildren(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
        {
            m_ts.fnSimSet_callOnChildren(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
        }

        /// <summary>
        /// ( SimSet, callOnChildrenNoRecurse, void, 3, 0,   ( string method, string args... ) Call a method on all objects contained in the set.   @param method The name of the method to call.   @param args The arguments to the method.   @note This method does not recurse into child SimSets.   @see callOnChildren )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void callOnChildrenNoRecurse(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
        {
            m_ts.fnSimSet_callOnChildrenNoRecurse(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
        }

        /// <summary>
        /// Remove all objects from the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clear()
        {
            m_ts.fnSimSet_clear(_ID);
        }

        /// <summary>
        /// Find an object in the set by its internal name.   @param internalName The internal name of the object to look for.   @param searchChildren If true, SimSets contained in the set will be recursively searched for the object.   @return The object with the given internal name or 0 if no match was found. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string findObjectByInternalName(string internalName, bool searchChildren = false)
        {
            return m_ts.fnSimSet_findObjectByInternalName(_ID, internalName, searchChildren);
        }

        /// <summary>
        /// Get the number of objects contained in the set.   @return The number of objects contained in the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getCount()
        {
            return m_ts.fnSimSet_getCount(_ID);
        }

        /// <summary>
        /// Get the object at the given index.   @param index The object index.   @return The object at the given index or -1 if index is out of range. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getObject(uint index)
        {
            return m_ts.fnSimSet_getObject(_ID, index);
        }

        /// <summary>
        /// Return the index of the given object in this set.   @param obj The object for which to return the index.  Must be contained in the set.   @return The index of the object or -1 if the object is not contained in the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getObjectIndex(string obj)
        {
            return m_ts.fnSimSet_getObjectIndex(_ID, obj);
        }

        /// <summary>
        /// Return a random object from the set.   @return A randomly selected object from the set or -1 if the set is empty. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getRandom()
        {
            return m_ts.fnSimSet_getRandom(_ID);
        }

        /// <summary>
        /// Test whether the given object belongs to the set.   @param obj The object.   @return True if the object is contained in the set; false otherwise. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isMember(string obj)
        {
            return m_ts.fnSimSet_isMember(_ID, obj);
        }

        /// <summary>
        /// Dump a list of all objects contained in the set to the console. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void listObjects()
        {
            m_ts.fnSimSet_listObjects(_ID);
        }

        /// <summary>
        /// Make the given object the last object in the set.   @param obj The object to bring to the last position.  Must be contained in the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pushToBack(string obj)
        {
            m_ts.fnSimSet_pushToBack(_ID, obj);
        }

        /// <summary>
        /// ( SimSet, remove, void, 3, 0,   ( SimObject objects... ) Remove the given objects from the set.   @param objects The objects to remove from the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void remove(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
        {
            m_ts.fnSimSet_remove(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
        }

        /// <summary>
        /// Make sure child1 is ordered right before child2 in the set.   @param child1 The first child.  The object must already be contained in the set.   @param child2 The second child.  The object must already be contained in the set. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void reorderChild(string child1, string child2)
        {
            m_ts.fnSimSet_reorderChild(_ID, child1, child2);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Called when an object is added to the set.   @param object The object that was added. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onObjectAdded(SimObject objectx)
        {
        }

        /// <summary>
        /// Called when an object is removed from the set.   @param object The object that was removed. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onObjectRemoved(SimObject objectx)
        {
        }

        #endregion

        public SimSet_Base()
        {
        }
    }
}