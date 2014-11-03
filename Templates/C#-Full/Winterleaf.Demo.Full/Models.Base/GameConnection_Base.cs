


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
    [TypeConverter(typeof(TypeConverterGeneric<GameConnection_Base>))]
    public partial class GameConnection_Base: NetConnection
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GameConnection_Base ts, string simobjectid)
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
        public static bool operator !=(GameConnection_Base ts, string simobjectid)
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
        public static implicit operator string( GameConnection_Base ts)
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
        public static implicit operator GameConnection_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GameConnection_Base) Omni.self.getSimObject(simobjectid,typeof(GameConnection_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GameConnection_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GameConnection_Base(int simobjectid)
            {
            return  (GameConnection) Omni.self.getSimObject((uint)simobjectid,typeof(GameConnection_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GameConnection_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GameConnection_Base(uint simobjectid)
            {
            return  (GameConnection_Base) Omni.self.getSimObject(simobjectid,typeof(GameConnection_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Called by the server during phase 2 of the mission download to start sending ghosts to the client.
///    
///    Ghosts represent objects on the server that are in scope for the client.  These need 
///    to be synchronized with the client in order for the client to see and interact with them.  
///    This is typically done during the standard mission start phase 2 when following Torque's 
///    example mission startup sequence.
/// 
///    @tsexample
///    function serverCmdMissionStartPhase2Ack(%client, %seq, %playerDB)
///    {
///       // Make sure to ignore calls from a previous mission load
///       if (%seq != $missionSequence || !$MissionRunning)
///          return;
///       if (%client.currentPhase != 1.5)
///          return;
///       %client.currentPhase = 2;
///    
///       // Set the player datablock choice
///       %client.playerDB = %playerDB;
///    
///       // Update mod paths, this needs to get there before the objects.
///       %client.transmitPaths();
///    
///       // Start ghosting objects to the client
///       %client.activateGhosting();
///    }
///    @endtsexample
/// 
///    @see @ref ghosting_scoping for a description of the ghosting system.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void activateGhosting(){

pInvokes.m_ts.fnGameConnection_activateGhosting(_ID);
}
/// <summary>
/// @brief Sets the size of the chase camera's matrix queue.
///    @note This sets the queue size across all GameConnections.
///    @note This is not currently hooked up.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool chaseCam(int size){

return pInvokes.m_ts.fnGameConnection_chaseCam(_ID, size);
}
/// <summary>
/// @brief Clear the connection's camera object reference.
///    
///    @see GameConnection::setCameraObject() and GameConnection::getCameraObject())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearCameraObject(){

pInvokes.m_ts.fnGameConnection_clearCameraObject(_ID);
}
/// <summary>
/// @brief Clear any display device.
///    A display device may define a number of properties that are used during rendering.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearDisplayDevice(){

pInvokes.m_ts.fnGameConnection_clearDisplayDevice(_ID);
}
/// <summary>
/// ),
///    @brief On the server, disconnect a client and pass along an optional reason why.
/// 
///    This method performs two operations: it disconnects a client connection from the server, 
///    and it deletes the connection object.  The optional reason is sent in the disconnect packet 
///    and is often displayed to the user so they know why they've been disconnected.
///    
///    @param reason [optional] The reason why the user has been disconnected from the server.
///    
///    @tsexample
///    function kick(%client)
///    {
///       messageAll( 'MsgAdminForce', '\\c2The Admin has kicked %1.', %client.playerName);
///    
///       if (!%client.isAIControlled())
///          BanList::add(%client.guid, %client.getAddress(), $Pref::Server::KickBanTime);
///       %client.delete(\"You have been kicked from this server\");
///    }
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void delete(string reason = ""){

pInvokes.m_ts.fnGameConnection_delete(_ID, reason);
}
/// <summary>
/// @brief Returns the connection's camera object used when not viewing through the control object.
///    
///    @see GameConnection::setCameraObject() and GameConnection::clearCameraObject())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getCameraObject(){

return pInvokes.m_ts.fnGameConnection_getCameraObject(_ID);
}
/// <summary>
/// @brief Returns the default field of view as used by the control object's camera.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getControlCameraDefaultFov(){

return pInvokes.m_ts.fnGameConnection_getControlCameraDefaultFov(_ID);
}
/// <summary>
/// @brief Returns the field of view as used by the control object's camera.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getControlCameraFov(){

return pInvokes.m_ts.fnGameConnection_getControlCameraFov(_ID);
}
/// <summary>
/// @brief On the server, returns the object that the client is controlling.
///    By default the control object is an instance of the Player class, but can also be an instance 
///    of Camera (when editing the mission, for example), or any other ShapeBase derived class as 
///    appropriate for the game.
///    @see GameConnection::setControlObject())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getControlObject(){

return pInvokes.m_ts.fnGameConnection_getControlObject(_ID);
}
/// <summary>
/// @brief Get the connection's control scheme absolute rotation property.
///    
///    @return True if the connection's control object should use an absolute rotation control scheme.
///    @see GameConnection::setControlSchemeParameters())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getControlSchemeAbsoluteRotation(){

return pInvokes.m_ts.fnGameConnection_getControlSchemeAbsoluteRotation(_ID);
}
/// <summary>
/// @brief On the client, get the control object's damage flash level.
///    @return flash level)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getDamageFlash(){

return pInvokes.m_ts.fnGameConnection_getDamageFlash(_ID);
}
/// <summary>
/// @brief On the client, get the control object's white-out level.
///    @return white-out level)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getWhiteOut(){

return pInvokes.m_ts.fnGameConnection_getWhiteOut(_ID);
}
/// <summary>
/// @brief Returns true if this connection is AI controlled.
///    @see AIConnection)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isAIControlled(){

return pInvokes.m_ts.fnGameConnection_isAIControlled(_ID);
}
/// <summary>
/// @brief Returns true if the object being controlled by the client is making use 
///    of a rotation damped camera.
///    @see Camera)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isControlObjectRotDampedCamera(){

return pInvokes.m_ts.fnGameConnection_isControlObjectRotDampedCamera(_ID);
}
/// <summary>
/// @brief Returns true if a previously recorded demo file is now playing.
///    
///    @see GameConnection::playDemo())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isDemoPlaying(){

return pInvokes.m_ts.fnGameConnection_isDemoPlaying(_ID);
}
/// <summary>
/// @brief Returns true if a demo file is now being recorded.
///    
///    @see GameConnection::startRecording(), GameConnection::stopRecording())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isDemoRecording(){

return pInvokes.m_ts.fnGameConnection_isDemoRecording(_ID);
}
/// <summary>
/// @brief Returns true if this connection is in first person mode.
/// 
///    @note Transition to first person occurs over time via mCameraPos, so this 
///    won't immediately return true after a set.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isFirstPerson(){

return pInvokes.m_ts.fnGameConnection_isFirstPerson(_ID);
}
/// <summary>
/// @brief List all of the classes that this connection knows about, and what their IDs are. Useful for debugging network problems.
///    @note The list is sent to the console.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void listClassIDs(){

pInvokes.m_ts.fnGameConnection_listClassIDs(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool LoadDatablocksFromFile(uint crc){

return pInvokes.m_ts.fnGameConnection_LoadDatablocksFromFile(_ID, crc);
}
/// <summary>
/// @brief Used on the server to play a 2D sound that is not attached to any object.
/// 
///    @param profile The SFXProfile that defines the sound to play.
/// 
///    @tsexample
///    function ServerPlay2D(%profile)
///    {
///       // Play the given sound profile on every client.
///       // The sounds will be transmitted as an event, not attached to any object.
///       for(%idx = 0; %idx  ClientGroup.getCount(); %idx++)
///          ClientGroup.getObject(%idx).play2D(%profile);
///    }
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool play2D(string profile){

return pInvokes.m_ts.fnGameConnection_play2D(_ID, profile);
}
/// <summary>
/// @brief Used on the server to play a 3D sound that is not attached to any object.
///    
///    @param profile The SFXProfile that defines the sound to play.
///    @param location The position and orientation of the 3D sound given in the form of \"x y z ax ay az aa\".
/// 
///    @tsexample
///    function ServerPlay3D(%profile,%transform)
///    {
///       // Play the given sound profile at the given position on every client
///       // The sound will be transmitted as an event, not attached to any object.
///       for(%idx = 0; %idx  ClientGroup.getCount(); %idx++)
///          ClientGroup.getObject(%idx).play3D(%profile,%transform);
///    }
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool play3D(string profile, TransformF location){

return pInvokes.m_ts.fnGameConnection_play3D(_ID, profile, location.AsString());
}
/// <summary>
/// @brief On the client, play back a previously recorded game session.
///    
///    It is often useful to play back a game session.  This could be for producing a 
///    demo of the game that will be shown at a later time, or for debugging a game.  
///    By recording the entire network stream it is possible to later play game the game 
///    exactly as it unfolded during the actual play session.  This is because all user 
///    control and server results pass through the connection.
/// 
///    @returns True if the playback was successful.  False if there was an issue, such as 
///    not being able to open the demo file for playback.
///    
///    @see GameConnection::startRecording(), GameConnection::stopRecording())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool playDemo(string demoFileName){

return pInvokes.m_ts.fnGameConnection_playDemo(_ID, demoFileName);
}
/// <summary>
/// @brief On the server, resets the connection to indicate that ghosting has been disabled.
/// 
///    Typically when a mission has ended on the server, all connected clients are informed of this change 
///    and their connections are reset back to a starting state.  This method resets a connection on the 
///    server to indicate that ghosts are no longer being transmitted.  On the client end, all ghost 
///    information will be deleted.
/// 
///    @tsexample
///       // Inform the clients
///       for (%clientIndex = 0; %clientIndex  ClientGroup.getCount(); %clientIndex++)
///       {
///          // clear ghosts and paths from all clients
///          %cl = ClientGroup.getObject(%clientIndex);
///          %cl.endMission();
///          %cl.resetGhosting();
///          %cl.clearPaths();
///       }
///    @endtsexample
/// 
///    @see @ref ghosting_scoping for a description of the ghosting system.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void resetGhosting(){

pInvokes.m_ts.fnGameConnection_resetGhosting(_ID);
}
/// <summary>
/// @brief On the server, sets the client's 3D display to fade to black.
///    @param doFade Set to true to fade to black, and false to fade from black.
///    @param timeMS Time it takes to perform the fade as measured in ms.
///    @note Not currently hooked up, and is not synchronized over the network.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBlackOut(bool doFade, int timeMS){

pInvokes.m_ts.fnGameConnection_setBlackOut(_ID, doFade, timeMS);
}
/// <summary>
/// @brief On the server, set the connection's camera object used when not viewing 
///    through the control object.
///    
///    @see GameConnection::getCameraObject() and GameConnection::clearCameraObject())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setCameraObject(string camera){

return pInvokes.m_ts.fnGameConnection_setCameraObject(_ID, camera);
}
/// <summary>
/// (GameConnection, setConnectArgs, void, 3, 17,
///    (const char* args) @brief On the client, pass along a variable set of parameters to the server.
///    
///    Once the connection is established with the server, the server calls its onConnect() method 
///    with the client's passed in parameters as aruments.
///    
///    @see GameConnection::onConnect())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setConnectArgs(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= ""){

pInvokes.m_ts.fnGameConnection_setConnectArgs(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16);
}
/// <summary>
/// @brief On the server, sets the control object's camera's field of view.
///    @param newFOV New field of view (in degrees) to force the control object's camera to use.  This value 
///    is clamped to be within the range of 1 to 179 degrees.
///    @note When transmitted over the network to the client, the resolution is limited to 
///    one degree.  Any fraction is dropped.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setControlCameraFov(float newFOV){

pInvokes.m_ts.fnGameConnection_setControlCameraFov(_ID, newFOV);
}
/// <summary>
/// @brief On the server, sets the object that the client will control.
///    By default the control object is an instance of the Player class, but can also be an instance 
///    of Camera (when editing the mission, for example), or any other ShapeBase derived class as 
///    appropriate for the game.
///    @param ctrlObj The GameBase object on the server to control.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setControlObject(string ctrlObj){

return pInvokes.m_ts.fnGameConnection_setControlObject(_ID, ctrlObj);
}
/// <summary>
/// @brief Set the control scheme that may be used by a connection's control object.
///    
///    @param absoluteRotation Use absolute rotation values from client, likely through ExtendedMove.
///    @param addYawToAbsRot Add relative yaw control to the absolute rotation calculation.  Only useful when absoluteRotation is true. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setControlSchemeParameters(bool absoluteRotation, bool addYawToAbsRot, bool addPitchToAbsRot){

pInvokes.m_ts.fnGameConnection_setControlSchemeParameters(_ID, absoluteRotation, addYawToAbsRot, addPitchToAbsRot);
}
/// <summary>
/// @brief On the server, sets this connection into or out of first person mode.
///    
///    @param firstPerson Set to true to put the connection into first person mode.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFirstPerson(bool firstPerson){

pInvokes.m_ts.fnGameConnection_setFirstPerson(_ID, firstPerson);
}
/// <summary>
/// @brief On the client, set the password that will be passed to the server.
///               
///               On the server, this password is compared with what is stored in $pref::Server::Password.  
///               If $pref::Server::Password is empty then the client's sent password is ignored.  Otherwise, 
///               if the passed in client password and the server password do not match, the CHR_PASSWORD 
///               error string is sent back to the client and the connection is immediately terminated.
///               
///               This password checking is performed quite early on in the connection request process so as 
///               to minimize the impact of multiple failed attempts -- also known as hacking.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setJoinPassword(string password){

pInvokes.m_ts.fnGameConnection_setJoinPassword(_ID, password);
}
/// <summary>
/// @brief On the server, transmits the mission file's CRC value to the client.
/// 
///    Typically, during the standard mission start phase 1, the mission file's CRC value 
///    on the server is send to the client.  This allows the client to determine if the mission 
///    has changed since the last time it downloaded this mission and act appropriately, such as 
///    rebuilt cached lightmaps.
/// 
///    @param CRC The mission file's CRC value on the server.
/// 
///    @tsexample
///    function serverCmdMissionStartPhase1Ack(%client, %seq)
///    {
///       // Make sure to ignore calls from a previous mission load
///       if (%seq != $missionSequence || !$MissionRunning)
///          return;
///       if (%client.currentPhase != 0)
///          return;
///       %client.currentPhase = 1;
///    
///       // Start with the CRC
///       %client.setMissionCRC( $missionCRC );
///    
///       // Send over the datablocks...
///       // OnDataBlocksDone will get called when have confirmation
///       // that they've all been received.
///       %client.transmitDataBlocks($missionSequence);
///    }
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMissionCRC(int CRC){

pInvokes.m_ts.fnGameConnection_setMissionCRC(_ID, CRC);
}
/// <summary>
/// @brief On the client, starts recording the network connection's traffic to a demo file.
///    
///    It is often useful to play back a game session.  This could be for producing a 
///    demo of the game that will be shown at a later time, or for debugging a game.  
///    By recording the entire network stream it is possible to later play game the game 
///    exactly as it unfolded during the actual play session.  This is because all user 
///    control and server results pass through the connection.
///    
///    @param fileName The file name to use for the demo recording.
///    
///    @see GameConnection::stopRecording(), GameConnection::playDemo())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void startRecording(string fileName){

pInvokes.m_ts.fnGameConnection_startRecording(_ID, fileName);
}
/// <summary>
/// @brief On the client, stops the recording of a connection's network traffic to a file.
///    
///    @see GameConnection::startRecording(), GameConnection::playDemo())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void stopRecording(){

pInvokes.m_ts.fnGameConnection_stopRecording(_ID);
}
/// <summary>
/// @brief Sent by the server during phase 1 of the mission download to send the datablocks to the client.
///    
///    SimDataBlocks, also known as just datablocks, need to be transmitted to the client 
///    prior to the client entering the game world.  These represent the static data that 
///    most objects in the world reference.  This is typically done during the standard 
///    mission start phase 1 when following Torque's example mission startup sequence.
/// 
///    When the datablocks have all been transmitted, onDataBlocksDone() is called to move 
///    the mission start process to the next phase.
/// 
///    @param sequence The sequence is common between the server and client and ensures 
///    that the client is acting on the most recent mission start process.  If an errant 
///    network packet (one that was lost but has now been found) is received by the client 
///    with an incorrect sequence, it is just ignored.  This sequence number is updated on 
///    the server every time a mission is loaded.
/// 
///    @tsexample
///    function serverCmdMissionStartPhase1Ack(%client, %seq)
///    {
///       // Make sure to ignore calls from a previous mission load
///       if (%seq != $missionSequence || !$MissionRunning)
///          return;
///       if (%client.currentPhase != 0)
///          return;
///       %client.currentPhase = 1;
///    
///       // Start with the CRC
///       %client.setMissionCRC( $missionCRC );
///    
///       // Send over the datablocks...
///       // OnDataBlocksDone will get called when have confirmation
///       // that they've all been received.
///       %client.transmitDataBlocks($missionSequence);
///    }
///    @endtsexample
///    
///    @see GameConnection::onDataBlocksDone())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void transmitDataBlocks(int sequence){

pInvokes.m_ts.fnGameConnection_transmitDataBlocks(_ID, sequence);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called on the client when the connection to the server times out.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnectionTimedOut(){}

        /// <summary>
        /// @brief Called on the client when the connection to the server has been established.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnectionAccepted(){}

        /// <summary>
        /// @brief Called when connection attempts have timed out.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnectRequestTimedOut(){}

        /// <summary>
        /// @brief Called on the client when the connection to the server has been dropped.   @param reason The reason why the connection was dropped.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnectionDropped(string reason){}

        /// <summary>
        /// @brief Called on the client when the connection to the server has been rejected.   @param reason The reason why the connection request was rejected.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnectRequestRejected(string reason){}

        /// <summary>
        /// @brief Called on the client when there is an error with the connection to the server.   @param errorString The connection error text.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnectionError(string errorString){}

        /// <summary>
        /// @brief Called on the server when the client's connection has been dropped.   @param disconnectReason The reason why the connection was dropped.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDrop(string disconnectReason){}

        /// <summary>
        /// @brief Called on the client when the first control object has been set by the    server and we are now ready to go.   A common action to perform when this callback is called is to switch the GUI    canvas from the loading screen and over to the 3D game GUI.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void initialControlSet(){}

        /// <summary>
        /// @brief Called on the client when the control object has been changed by the    server.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onControlObjectChange(){}

        /// <summary>
        /// @brief Called on the client to display the lag icon.   When the connection with the server is lagging, this callback is called to    allow the game GUI to display some indicator to the player.   @param state Set to true if the lag icon should be displayed.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void setLagIcon(bool state){}

        /// <summary>
        /// @brief Called on the server when all datablocks has been sent to the client.   During phase 1 of the mission download, all datablocks are sent from the server    to the client.  Once all datablocks have been sent, this callback is called and    the mission download procedure may move on to the next phase.   @param sequence The sequence is common between the server and client and ensures    that the client is acting on the most recent mission start process.  If an errant    network packet (one that was lost but has now been found) is received by the client    with an incorrect sequence, it is just ignored.  This sequence number is updated on    the server every time a mission is loaded.   @see GameConnection::transmitDataBlocks())
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDataBlocksDone(uint sequence){}

        /// <summary>
        /// @brief Called on the client when the damage flash or white out states change.   When the server changes the damage flash or white out values, this callback is called    either is on or both are off.  Typically this is used to enable the flash postFx.   @param state Set to true if either the damage flash or white out conditions are active.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onFlash(bool state){}

#endregion
public GameConnection_Base (){}
}}
