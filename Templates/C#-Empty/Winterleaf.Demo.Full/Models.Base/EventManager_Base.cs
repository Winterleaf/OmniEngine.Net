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
    [TypeConverter(typeof (TypeConverterGeneric<EventManager_Base>))]
    public partial class EventManager_Base : SimObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EventManager_Base ts, string simobjectid)
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
        public static bool operator !=(EventManager_Base ts, string simobjectid)
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
        public static implicit operator string(EventManager_Base ts)
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
        public static implicit operator EventManager_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (EventManager_Base) Omni.self.getSimObject(simobjectid, typeof (EventManager_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EventManager_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EventManager_Base(int simobjectid)
        {
            return (EventManager) Omni.self.getSimObject((uint) simobjectid, typeof (EventManager_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EventManager_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EventManager_Base(uint simobjectid)
        {
            return (EventManager_Base) Omni.self.getSimObject(simobjectid, typeof (EventManager_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// List of events currently waiting 
        /// </summary>
        [MemberGroup("")]
        public String queue
        {
            get { return Omni.self.GetVar(_ID + ".queue").AsString(); }
            set { Omni.self.SetVar(_ID + ".queue", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// ()              Print all registered events to the console. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void dumpEvents()
        {
            m_ts.fn_EventManager_dumpEvents(_ID);
        }

        /// <summary>
        /// ), ( String event )              Print all subscribers to an event to the console.              @param event The event whose subscribers are to be printed. If this parameter isn't specified, all events will be dumped. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void dumpSubscribers(string listenerName = "")
        {
            m_ts.fn_EventManager_dumpSubscribers(_ID, listenerName);
        }

        /// <summary>
        /// ( String event )              Check if an event is registered or not.              @param event The event to check.              @return Whether or not the event exists. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isRegisteredEvent(string evt)
        {
            return m_ts.fn_EventManager_isRegisteredEvent(_ID, evt);
        }

        /// <summary>
        /// ), ( String event, String data )              ~Trigger an event.              @param event The event to trigger.              @param data The data associated with the event.              @return Whether or not the event was dispatched successfully. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool postEvent(string evt, string data = "")
        {
            return m_ts.fn_EventManager_postEvent(_ID, evt, data);
        }

        /// <summary>
        /// ( String event )              Register an event with the event manager.              @param event The event to register.              @return Whether or not the event was registered successfully. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool registerEvent(string evt)
        {
            return m_ts.fn_EventManager_registerEvent(_ID, evt);
        }

        /// <summary>
        /// ( SimObject listener, String event )              Remove a listener from an event.              @param listener The listener to remove.              @param event The event to be removed from.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void remove(string listenerName, string evt)
        {
            m_ts.fn_EventManager_remove(_ID, listenerName, evt);
        }

        /// <summary>
        /// ( SimObject listener )              Remove a listener from all events.              @param listener The listener to remove.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeAll(string listenerName)
        {
            m_ts.fn_EventManager_removeAll(_ID, listenerName);
        }

        /// <summary>
        /// ), ( SimObject listener, String event, String callback )              Subscribe a listener to an event.              @param listener The listener to subscribe.              @param event The event to subscribe to.              @param callback Optional method name to receive the event notification. If this is not specified, \"on[event]\" will be used.              @return Whether or not the subscription was successful. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool subscribe(string listenerName, string evt, string callback = "")
        {
            return m_ts.fn_EventManager_subscribe(_ID, listenerName, evt, callback);
        }

        /// <summary>
        /// ( String event )              Remove an event from the EventManager.              @param event The event to remove. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void unregisterEvent(string evt)
        {
            m_ts.fn_EventManager_unregisterEvent(_ID, evt);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public EventManager_Base()
        {
        }
    }
}