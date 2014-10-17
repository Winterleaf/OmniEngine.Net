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
    [TypeConverter(typeof (TypeConverterGeneric<NetConnection_Base>))]
    public partial class NetConnection_Base : SimGroup
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NetConnection_Base ts, string simobjectid)
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
        public static bool operator !=(NetConnection_Base ts, string simobjectid)
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
        public static implicit operator string(NetConnection_Base ts)
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
        public static implicit operator NetConnection_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (NetConnection_Base) Omni.self.getSimObject(simobjectid, typeof (NetConnection_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(NetConnection_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NetConnection_Base(int simobjectid)
        {
            return (NetConnection) Omni.self.getSimObject((uint) simobjectid, typeof (NetConnection_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(NetConnection_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NetConnection_Base(uint simobjectid)
        {
            return (NetConnection_Base) Omni.self.getSimObject(simobjectid, typeof (NetConnection_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Ensures that all configured packet rates and sizes meet minimum requirements.   This method is normally only called when a NetConnection class is first constructed.  It need    only be manually called if the global variables that set the packet rate or size have changed.   @note If @$pref::Net::PacketRateToServer, @$pref::Net::PacketRateToClient or @$pref::Net::PacketSize    have been changed since a NetConnection has been created, this method must be called on    all connections for them to follow the new rates or size.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void checkMaxRate()
        {
            m_ts.fnNetConnection_checkMaxRate(_ID);
        }

        /// <summary>
        /// @brief On the server, resets the connection to indicate that motion spline paths have not been transmitted.   Typically when a mission has ended on the server, all connected clients are informed of this change    and their connections are reset back to a starting state.  This method resets a connection on the    server to indicate that motion spline paths have not been transmitted.   @tsexample      // Inform the clients      for (%clientIndex = 0; %clientIndex  ClientGroup.getCount(); %clientIndex++)      {         // clear ghosts and paths from all clients         %cl = ClientGroup.getObject(%clientIndex);         %cl.endMission();         %cl.resetGhosting();         %cl.clearPaths();      }   @endtsexample      @see transmitPaths()   @see Path)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearPaths()
        {
            m_ts.fnNetConnection_clearPaths(_ID);
        }

        /// <summary>
        /// @brief Connects to the remote address.   Attempts to connect with another NetConnection on the given address.  Typically once    connected, a game's information is passed along from the server to the client, followed    by the player entering the game world.  The actual procedure is dependent on    the NetConnection subclass that is used.  i.e. GameConnection.   @param remoteAddress The address to connect to in the form of IP:address>:port    although the i>IP:/i> portion is optional.  The i>address/i> portion may be in the form    of w.x.y.z or as a host name, in which case a DNS lookup will be performed.  You may also    substitue the word i>broadcast/i> for the address to broadcast the connect request over    the local subnet.   @see NetConnection::connectLocal() to connect to a server running within the same process    as the client.   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void connect(string remoteAddress)
        {
            m_ts.fnNetConnection_connect(_ID, remoteAddress);
        }

        /// <summary>
        /// @brief Connects with the server that is running within the same process as the client.   @returns An error text message upon failure, or an empty string when successful.   @see See @ref local_connections for a description of local connections and their use.  See    NetConnection::connect() to connect to a server running in another process (on the same machine or not).)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string connectLocal()
        {
            return m_ts.fnNetConnection_connectLocal(_ID);
        }

        /// <summary>
        /// @brief Returns the far end network address for the connection.   The address will be in one of the following forms:   - b>IP:Broadcast:port>/b> for broadcast type addresses   - b>IP:address>:port>/b> for IP addresses   - b>local/b> when connected locally (server and client running in same process)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getAddress()
        {
            return m_ts.fnNetConnection_getAddress(_ID);
        }

        /// <summary>
        /// @brief On server or client, convert a real id to the ghost id for this connection.   Torque's network ghosting system only exchanges ghost ID's between the server and client.  Use    this method on the server or client to discover an object's ghost ID based on its real SimObject ID.   @param realID The real SimObject ID of the object.   @returns The ghost ID of the object for this connection, or -1 if it could not be resolved.   @see @ref ghosting_scoping for a description of the ghosting system.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getGhostID(int realID)
        {
            return m_ts.fnNetConnection_getGhostID(_ID, realID);
        }

        /// <summary>
        /// Returns the ghost-index for an object.
        /// 	@ingroup AFX)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int GetGhostIndex(string obj)
        {
            return m_ts.fnNetConnection_GetGhostIndex(_ID, obj);
        }

        /// <summary>
        /// @brief Provides the number of active ghosts on the connection.   @returns The number of active ghosts.   @see @ref ghosting_scoping for a description of the ghosting system.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getGhostsActive()
        {
            return m_ts.fnNetConnection_getGhostsActive(_ID);
        }

        /// <summary>
        /// @brief Returns the percentage of packets lost per tick.   @note This method is not yet hooked up.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getPacketLoss()
        {
            return m_ts.fnNetConnection_getPacketLoss(_ID);
        }

        /// <summary>
        /// @brief Returns the average round trip time (in ms) for the connection.   The round trip time is recalculated every time a notify packet is received.  Notify    packets are used to information the connection that the far end successfully received    the sent packet.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getPing()
        {
            return m_ts.fnNetConnection_getPing(_ID);
        }

        /// <summary>
        /// Resolves a ghost-index into an object ID.
        /// 	@ingroup AFX)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int ResolveGhost(int ghostIndex)
        {
            return m_ts.fnNetConnection_ResolveGhost(_ID, ghostIndex);
        }

        /// <summary>
        /// @brief On the client, convert a ghost ID from this connection to a real SimObject ID.   Torque's network ghosting system only exchanges ghost ID's between the server and client.  Use    this method on the client to discover an object's local SimObject ID when you only have a    ghost ID.   @param ghostID The ghost ID of the object as sent by the server.   @returns The SimObject ID of the object, or 0 if it could not be resolved.   @tsexample      %object = ServerConnection.resolveGhostID( %ghostId );   @endtsexample   @see @ref ghosting_scoping for a description of the ghosting system.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int resolveGhostID(int ghostID)
        {
            return m_ts.fnNetConnection_resolveGhostID(_ID, ghostID);
        }

        /// <summary>
        /// @brief On the server, convert a ghost ID from this connection to a real SimObject ID.   Torque's network ghosting system only exchanges ghost ID's between the server and client.  Use    this method on the server to discover an object's local SimObject ID when you only have a    ghost ID.   @param ghostID The ghost ID of the object as sent by the server.   @returns The SimObject ID of the object, or 0 if it could not be resolved.   @tsexample      %object = %client.resolveObjectFromGhostIndex( %ghostId );   @endtsexample   @see @ref ghosting_scoping for a description of the ghosting system.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int resolveObjectFromGhostIndex(int ghostID)
        {
            return m_ts.fnNetConnection_resolveObjectFromGhostIndex(_ID, ghostID);
        }

        /// <summary>
        /// @brief Simulate network issues on the connection for testing.   @param packetLoss The fraction of packets that will be lost.  Ranges from 0.0 (no loss) to 1.0 (complete loss)   @param delay Delays packets being transmitted by simulating a particular ping.  This is an absolute    integer, measured in ms.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSimulatedNetParams(float packetLoss, int delay)
        {
            m_ts.fnNetConnection_setSimulatedNetParams(_ID, packetLoss, delay);
        }

        /// <summary>
        /// @brief Sent by the server during phase 2 of the mission download to update motion spline paths.   The server transmits all spline motion paths that are within the mission (Path) separate from    other objects.  This is due to the potentially large number of nodes within each path, which may    saturate a packet sent to the client.  By managing this step separately, Torque has finer control    over how packets are organised vs. doing it during the ghosting stage.   Internally a PathManager is used to track all paths defined within a mission on the server, and each    one is transmitted using a PathManagerEvent.  The client side collects these events and builds the    given paths within its own PathManager.  This is typically done during the standard mission start    phase 2 when following Torque's example mission startup sequence.   When a mission is ended, all paths need to be cleared from their respective path managers.   @tsexample   function serverCmdMissionStartPhase2Ack(%client, %seq, %playerDB)   {      // Make sure to ignore calls from a previous mission load      if (%seq != $missionSequence || !$MissionRunning)         return;      if (%client.currentPhase != 1.5)         return;      %client.currentPhase = 2;         // Set the player datablock choice      %client.playerDB = %playerDB;         // Update mission paths (SimPath), this needs to get there before the objects.      %client.transmitPaths();         // Start ghosting objects to the client      %client.activateGhosting();   }   @endtsexample      @see clearPaths()   @see Path)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void transmitPaths()
        {
            m_ts.fnNetConnection_transmitPaths(_ID);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onGhostAlwaysObjectsReceived()
        {
        }

        #endregion

        public NetConnection_Base()
        {
        }
    }
}