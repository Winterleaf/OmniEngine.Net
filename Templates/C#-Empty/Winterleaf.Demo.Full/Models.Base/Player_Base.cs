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
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<Player_Base>))]
    public partial class Player_Base : ShapeBase
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Player_Base ts, string simobjectid)
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
        public static bool operator !=(Player_Base ts, string simobjectid)
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
        public static implicit operator string(Player_Base ts)
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
        public static implicit operator Player_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (Player_Base) Omni.self.getSimObject(simobjectid, typeof (Player_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Player_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Player_Base(int simobjectid)
        {
            return (Player) Omni.self.getSimObject((uint) simobjectid, typeof (Player_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Player_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Player_Base(uint simobjectid)
        {
            return (Player_Base) Omni.self.getSimObject(simobjectid, typeof (Player_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Allow all poses a chance to occur.   This method resets any poses that have manually been blocked from occuring.     This includes the regular pose states such as sprinting, crouch, being prone    and swimming.  It also includes being able to jump and jet jump.  While this    is allowing these poses to occur it doesn't mean that they all can due to other    conditions.  We're just not manually blocking them from being allowed.   @see allowJumping()   @see allowJetJumping()   @see allowSprinting()   @see allowCrouching()   @see allowProne()   @see allowSwimming() )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void allowAllPoses()
        {
            m_ts.fnPlayer_allowAllPoses(_ID);
        }

        /// <summary>
        /// @brief Set if the Player is allowed to crouch.   The default is to allow crouching unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow crouching    at any time.   @param state Set to true to allow crouching, false to disable it.   @see allowAllPoses() )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void allowCrouching(bool state)
        {
            m_ts.fnPlayer_allowCrouching(_ID, state);
        }

        /// <summary>
        /// @brief Set if the Player is allowed to jet jump.   The default is to allow jet jumping unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow jet jumping    at any time.   @param state Set to true to allow jet jumping, false to disable it.   @see allowAllPoses() )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void allowJetJumping(bool state)
        {
            m_ts.fnPlayer_allowJetJumping(_ID, state);
        }

        /// <summary>
        /// @brief Set if the Player is allowed to jump.   The default is to allow jumping unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow jumping    at any time.   @param state Set to true to allow jumping, false to disable it.   @see allowAllPoses() )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void allowJumping(bool state)
        {
            m_ts.fnPlayer_allowJumping(_ID, state);
        }

        /// <summary>
        /// @brief Set if the Player is allowed to go prone.   The default is to allow being prone unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow going prone    at any time.   @param state Set to true to allow being prone, false to disable it.   @see allowAllPoses() )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void allowProne(bool state)
        {
            m_ts.fnPlayer_allowProne(_ID, state);
        }

        /// <summary>
        /// @brief Set if the Player is allowed to sprint.   The default is to allow sprinting unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow sprinting    at any time.   @param state Set to true to allow sprinting, false to disable it.   @see allowAllPoses() )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void allowSprinting(bool state)
        {
            m_ts.fnPlayer_allowSprinting(_ID, state);
        }

        /// <summary>
        /// @brief Set if the Player is allowed to swim.   The default is to allow swimming unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow swimming    at any time.   @param state Set to true to allow swimming, false to disable it.   @see allowAllPoses() )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void allowSwimming(bool state)
        {
            m_ts.fnPlayer_allowSwimming(_ID, state);
        }

        /// <summary>
        /// @brief Check if it is safe to dismount at this position.   Internally this method casts a ray from oldPos to pos to determine if it hits the    terrain, an interior object, a water object, another player, a static shape,    a vehicle (exluding the one currently mounted), or physical zone.  If this ray    is in the clear, then the player's bounding box is also checked for a collision at    the pos position.  If this displaced bounding box is also in the clear, then    checkDismountPoint() returns true.   @param oldPos The player's current position   @param pos The dismount position to check   @return True if the dismount position is clear, false if not      @note The player must be already mounted for this method to not assert.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool checkDismountPoint(Point3F oldPos, Point3F pos)
        {
            return m_ts.fnPlayer_checkDismountPoint(_ID, oldPos.AsString(), pos.AsString());
        }

        /// <summary>
        /// @brief Clears the player's current control object.   Returns control to the player. This internally calls    Player::setControlObject(0).   @tsexample		%player.clearControlObject();      echo(%player.getControlObject()); //-- Returns 0, player assumes control      %player.setControlObject(%vehicle);      echo(%player.getControlObject()); //-- Returns %vehicle, player controls the vehicle now.	@endtsexample   @note If the player does not have a control object, the player will receive all moves    from its GameConnection.  If you're looking to remove control from the player itself    (i.e. stop sending moves to the player) use GameConnection::setControlObject() to transfer    control to another object, such as a camera.   @see setControlObject()   @see getControlObject()   @see GameConnection::setControlObject())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearControlObject()
        {
            m_ts.fnPlayer_clearControlObject(_ID);
        }

        /// <summary>
        /// @brief Get the current object we are controlling.   @return ID of the ShapeBase object we control, or 0 if not controlling an    object.   @see setControlObject()   @see clearControlObject())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getControlObject()
        {
            return m_ts.fnPlayer_getControlObject(_ID);
        }

        /// <summary>
        /// @brief Get the named damage location and modifier for a given world position.   the Player object can simulate different hit locations based on a pre-defined set    of PlayerData defined percentages.  These hit percentages divide up the Player's    bounding box into different regions.  The diagram below demonstrates how the various    PlayerData properties split up the bounding volume:   img src=\"images/player_damageloc.png\">   While you may pass in any world position and getDamageLocation() will provide a best-fit    location, you should be aware that this can produce some interesting results.  For example,    any position that is above PlayerData::boxHeadPercentage will be considered a 'head' hit, even    if the world position is high in the sky.  Therefore it may be wise to keep the passed in point    to somewhere on the surface of, or within, the Player's bounding volume.   @note This method will not return an accurate location when the player is    prone or swimming.   @param pos A world position for which to retrieve a body region on this player.   @return a string containing two words (space separated strings), where the    first is a location and the second is a modifier.   Posible locations:ul>   li>head/li>   li>torso/li>   li>legs/li>/ul>   Head modifiers:ul>   li>left_back/li>   li>middle_back/li>   li>right_back/li>   li>left_middle/li>   li>middle_middle/li>   li>right_middle/li>   li>left_front/li>   li>middle_front/li>   li>right_front/li>/ul>   Legs/Torso modifiers:ul>   li>front_left/li>   li>front_right/li>   li>back_left/li>   li>back_right/li>/ul>   @see PlayerData::boxHeadPercentage   @see PlayerData::boxHeadFrontPercentage   @see PlayerData::boxHeadBackPercentage   @see PlayerData::boxHeadLeftPercentage   @see PlayerData::boxHeadRightPercentage   @see PlayerData::boxTorsoPercentage   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getDamageLocation(Point3F pos)
        {
            return m_ts.fnPlayer_getDamageLocation(_ID, pos.AsString());
        }

        /// <summary>
        /// @brief Get the number of death animations available to this player.   Death animations are assumed to be named death1-N using consecutive indices. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getNumDeathAnimations()
        {
            return m_ts.fnPlayer_getNumDeathAnimations(_ID);
        }

        /// <summary>
        /// @brief Get the name of the player's current pose.   The pose is one of the following:ul>   li>Stand - Standard movement pose./li>   li>Sprint - Sprinting pose./li>   li>Crouch - Crouch pose./li>   li>Prone - Prone pose./li>   li>Swim - Swimming pose./li>/ul>   @return The current pose; one of: \"Stand\", \"Sprint\", \"Crouch\", \"Prone\", \"Swim\" )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getPose()
        {
            return m_ts.fnPlayer_getPose(_ID);
        }

        /// <summary>
        /// @brief Get the name of the player's current state.   The state is one of the following:ul>   li>Dead - The Player is dead./li>   li>Mounted - The Player is mounted to an object such as a vehicle./li>   li>Move - The Player is free to move.  The usual state./li>   li>Recover - The Player is recovering from a fall.  See PlayerData::recoverDelay./li>/ul>   @return The current state; one of: \"Dead\", \"Mounted\", \"Move\", \"Recover\" )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getState()
        {
            return m_ts.fnPlayer_getState(_ID);
        }

        /// <summary>
        /// @brief Set the main action sequence to play for this player.   @param name Name of the action sequence to set   @param hold Set to false to get a callback on the datablock when the sequence ends (PlayerData::animationDone()).     When set to true no callback is made.   @param fsp True if first person and none of the spine nodes in the shape should animate.  False will allow the shape's    spine nodes to animate.   @return True if succesful, false if failed      @note The spine nodes for the Player's shape are named as follows:ul>   li>Bip01 Pelvis/li>   li>Bip01 Spine/li>   li>Bip01 Spine1/li>   li>Bip01 Spine2/li>   li>Bip01 Neck/li>   li>Bip01 Head/li>/ul>      You cannot use setActionThread() to have the Player play one of the motion    determined action animation sequences.  These sequences are chosen based on how    the Player moves and the Player's current pose.  The names of these sequences are:ul>   li>root/li>   li>run/li>   li>side/li>   li>side_right/li>   li>crouch_root/li>   li>crouch_forward/li>   li>crouch_backward/li>   li>crouch_side/li>   li>crouch_right/li>   li>prone_root/li>   li>prone_forward/li>   li>prone_backward/li>   li>swim_root/li>   li>swim_forward/li>   li>swim_backward/li>   li>swim_left/li>   li>swim_right/li>   li>fall/li>   li>jump/li>   li>standjump/li>   li>land/li>   li>jet/li>/ul>      If the player moves in any direction then the animation sequence set using this    method will be cancelled and the chosen mation-based sequence will take over.  This makes    great for times when the Player cannot move, such as when mounted, or when it doesn't matter    if the action sequence changes, such as waving and saluting.      @tsexample      // Place the player in a sitting position after being mounted      %player.setActionThread( \"sitting\", true, true );	@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool setActionThread(string name, bool hold = false, bool fsp = true)
        {
            return m_ts.fnPlayer_setActionThread(_ID, name, hold, fsp);
        }

        /// <summary>
        /// @brief Set the sequence that controls the player's arms (dynamically adjusted    to match look direction).   @param name Name of the sequence to play on the player's arms.   @return true if successful, false if failed.   @note By default the 'look' sequence is used, if available.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool setArmThread(string name)
        {
            return m_ts.fnPlayer_setArmThread(_ID, name);
        }

        /// <summary>
        /// @brief Set the object to be controlled by this player   It is possible to have the moves sent to the Player object from the    GameConnection to be passed along to another object.  This happens, for example    when a player is mounted to a vehicle.  The move commands pass through the Player    and on to the vehicle (while the player remains stationary within the vehicle).     With setControlObject() you can have the Player pass along its moves to any object.     One possible use is for a player to move a remote controlled vehicle.  In this case    the player does not mount the vehicle directly, but still wants to be able to control it.   @param obj Object to control with this player   @return True if the object is valid, false if not   @see getControlObject()   @see clearControlObject()   @see GameConnection::setControlObject())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool setControlObject(string obj)
        {
            return m_ts.fnPlayer_setControlObject(_ID, obj);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public Player_Base()
        {
        }
    }
}