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
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<AIPlayer_Base>))]
    public partial class AIPlayer_Base : Player
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AIPlayer_Base ts, string simobjectid)
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
        public static bool operator !=(AIPlayer_Base ts, string simobjectid)
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
        public static implicit operator string(AIPlayer_Base ts)
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
        public static implicit operator AIPlayer_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (AIPlayer_Base) Omni.self.getSimObject(simobjectid, typeof (AIPlayer_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(AIPlayer_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator AIPlayer_Base(int simobjectid)
        {
            return (AIPlayer) Omni.self.getSimObject((uint) simobjectid, typeof (AIPlayer_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(AIPlayer_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator AIPlayer_Base(uint simobjectid)
        {
            return (AIPlayer_Base) Omni.self.getSimObject(simobjectid, typeof (AIPlayer_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Allow the character to use climb links.
        /// </summary>
        [MemberGroup("Pathfinding")]
        public bool allowClimb
        {
            get { return Omni.self.GetVar(_ID + ".allowClimb").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowClimb", value.AsString()); }
        }

        /// <summary>
        /// Allow the character to use drop links.
        /// </summary>
        [MemberGroup("Pathfinding")]
        public bool allowDrop
        {
            get { return Omni.self.GetVar(_ID + ".allowDrop").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowDrop", value.AsString()); }
        }

        /// <summary>
        /// Allow the character to use jump links.
        /// </summary>
        [MemberGroup("Pathfinding")]
        public bool allowJump
        {
            get { return Omni.self.GetVar(_ID + ".allowJump").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowJump", value.AsString()); }
        }

        /// <summary>
        /// Allow the character to jump ledges.
        /// </summary>
        [MemberGroup("Pathfinding")]
        public bool allowLedge
        {
            get { return Omni.self.GetVar(_ID + ".allowLedge").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowLedge", value.AsString()); }
        }

        /// <summary>
        /// Allow the character tomove in water.
        /// </summary>
        [MemberGroup("Pathfinding")]
        public bool allowSwim
        {
            get { return Omni.self.GetVar(_ID + ".allowSwim").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowSwim", value.AsString()); }
        }

        /// <summary>
        /// Allow the character to use teleporters.
        /// </summary>
        [MemberGroup("Pathfinding")]
        public bool allowTeleport
        {
            get { return Omni.self.GetVar(_ID + ".allowTeleport").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowTeleport", value.AsString()); }
        }

        /// <summary>
        /// Allow the character to walk on dry land.
        /// </summary>
        [MemberGroup("Pathfinding")]
        public bool allowWalk
        {
            get { return Omni.self.GetVar(_ID + ".allowWalk").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowWalk", value.AsString()); }
        }

        /// <summary>
        /// @brief Distance from destination before stopping.\n\n     When the AIPlayer is moving to a given destination it will move to within      this distance of the destination and then stop. By providing this tolerance      it helps the AIPlayer from never reaching its destination due to minor obstacles,      rounding errors on its position calculation, etc. By default it is set to 0.25.\n
        /// </summary>
        [MemberGroup("AI")]
        public float mMoveTolerance
        {
            get { return Omni.self.GetVar(_ID + ".mMoveTolerance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".mMoveTolerance", value.AsString()); }
        }

        /// <summary>
        /// @brief The number of ticks to wait before testing if the AIPlayer is stuck.\n\n     When the AIPlayer is asked to move, this property is the number of ticks to wait      before the AIPlayer starts to check if it is stuck. This delay allows the AIPlayer      to accelerate to full speed without its initial slow start being considered as stuck.\n     @note Set to zero to have the stuck test start immediately.\n
        /// </summary>
        [MemberGroup("AI")]
        public int moveStuckTestDelay
        {
            get { return Omni.self.GetVar(_ID + ".moveStuckTestDelay").AsInt(); }
            set { Omni.self.SetVar(_ID + ".moveStuckTestDelay", value.AsString()); }
        }

        /// <summary>
        /// @brief Distance tolerance on stuck check.\n\n     When the AIPlayer is moving to a given destination, if it ever moves less than      this tolerance during a single tick, the AIPlayer is considered stuck. At this point      the onMoveStuck() callback is called on the datablock.\n
        /// </summary>
        [MemberGroup("AI")]
        public float moveStuckTolerance
        {
            get { return Omni.self.GetVar(_ID + ".moveStuckTolerance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".moveStuckTolerance", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// ( GameBase obj, [Point3F offset] )              Sets the bot's target object. Optionally set an offset from target location.			  @hide)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setAimObject(string objName, Point3F offset = null)
        {
            if (offset == null)
                offset = new Point3F(0.0f, 0.0f, 0.0f);

            m_ts.fn_AIPlayer_setAimObject(_ID, objName, offset.AsString());
        }

        /// <summary>
        /// )	
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void AISearchSimSet(float fOV, float farDist, string ObjToSearch, string result)
        {
            m_ts.fnAIPlayer_AISearchSimSet(_ID, fOV, farDist, ObjToSearch, result);
        }

        /// <summary>
        /// @brief Use this to stop aiming at an object or a point.      @see setAimLocation()   @see setAimObject())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearAim()
        {
            m_ts.fnAIPlayer_clearAim(_ID);
        }

        /// <summary>
        /// @brief Tells the AI to find cover nearby.
        /// 
        ///    @param from   Location to find cover from (i.e., enemy position).
        ///    @param radius Distance to search for cover.
        ///    @return Cover point ID if cover was found, -1 otherwise.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int findCover(Point3F from, float radius)
        {
            return m_ts.fnAIPlayer_findCover(_ID, from.AsString(), radius);
        }

        /// <summary>
        /// @brief Get the NavMesh object this AIPlayer is currently using.
        /// 
        ///    @return The ID of the NavPath object this character is using for 
        ///    pathfinding. This is determined by the character's location, 
        ///    navigation type and other factors. Returns -1 if no NavMesh is 
        ///    found.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int findNavMesh()
        {
            return m_ts.fnAIPlayer_findNavMesh(_ID);
        }

        /// <summary>
        /// @brief Tell the AIPlayer to follow a path.
        /// 
        ///    @param obj ID of a NavPath object for the character to follow.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void followNavPath(uint obj)
        {
            m_ts.fnAIPlayer_followNavPath(_ID, obj);
        }

        /// <summary>
        /// @brief Tell the AIPlayer to follow another object.
        /// 
        ///    @param obj ID of the object to follow.
        ///    @param radius Maximum distance we let the target escape to.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void followObject(uint obj, float radius)
        {
            m_ts.fnAIPlayer_followObject(_ID, obj, radius);
        }

        /// <summary>
        /// @brief Returns the point the AIPlayer is aiming at.   This will reflect the position set by setAimLocation(),    or the position of the object that the bot is now aiming at.     If the bot is not aiming at anything, this value will    change to whatever point the bot's current line-of-sight intercepts.   @return World space coordinates of the object AI is aiming at. Formatted as \"X Y Z\".      @see setAimLocation()   @see setAimObject())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getAimLocation()
        {
            return new Point3F(m_ts.fnAIPlayer_getAimLocation(_ID));
        }

        /// <summary>
        /// @brief Gets the object the AIPlayer is targeting.   @return Returns -1 if no object is being aimed at,    or the SimObjectID of the object the AIPlayer is aiming at.      @see setAimObject())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getAimObject()
        {
            return m_ts.fnAIPlayer_getAimObject(_ID);
        }

        /// <summary>
        /// @brief Get the AIPlayer's current destination.   @return Returns a point containing the \"x y z\" position    of the AIPlayer's current move destination. If no move destination    has yet been set, this returns \"0 0 0\".      @see setMoveDestination())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getMoveDestination()
        {
            return new Point3F(m_ts.fnAIPlayer_getMoveDestination(_ID));
        }

        /// <summary>
        /// @brief Gets the move speed of an AI object.   @return A speed multiplier between 0.0 and 1.0.   @see setMoveSpeed())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getMoveSpeed()
        {
            return m_ts.fnAIPlayer_getMoveSpeed(_ID);
        }

        /// <summary>
        /// @brief Return the NavMesh this AIPlayer is using to navigate.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getNavMesh()
        {
            return m_ts.fnAIPlayer_getNavMesh(_ID);
        }

        /// <summary>
        /// @brief Return the size of NavMesh this character uses for pathfinding.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getNavSize()
        {
            return m_ts.fnAIPlayer_getNavSize(_ID);
        }

        /// <summary>
        /// @brief Get the AIPlayer's current pathfinding destination.
        /// 
        ///    @return Returns a point containing the \"x y z\" position 
        ///    of the AIPlayer's current path destination. If no path destination 
        ///    has yet been set, this returns \"0 0 0\".
        /// 
        ///    @see setPathDestination())
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getPathDestination()
        {
            return new Point3F(m_ts.fnAIPlayer_getPathDestination(_ID));
        }

        /// <summary>
        /// @brief Tells the AI to re-plan its path. Does nothing if the character 
        ///    has no path, or if it is following a mission path.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void repath()
        {
            m_ts.fnAIPlayer_repath(_ID);
        }

        /// <summary>
        /// @brief Tells the AIPlayer to aim at the location provided.   @param target An \"x y z\" position in the game world to target.      @see getAimLocation())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setAimLocation(Point3F target)
        {
            m_ts.fnAIPlayer_setAimLocation(_ID, target.AsString());
        }

        /// <summary>
        /// @brief Tells the AI to move to the location provided   @param goal Coordinates in world space representing location to move to.   @param slowDown A boolean value. If set to true, the bot will slow down    when it gets within 5-meters of its move destination. If false, the bot    will stop abruptly when it reaches the move destination. By default, this is true.   @note Upon reaching a move destination, the bot will clear its move destination and    calls to getMoveDestination will return \"0 0 0\".      @see getMoveDestination())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setMoveDestination(Point3F goal, bool slowDown = true)
        {
            m_ts.fnAIPlayer_setMoveDestination(_ID, goal.AsString(), slowDown);
        }

        /// <summary>
        /// @brief Sets the move speed for an AI object.   @param speed A speed multiplier between 0.0 and 1.0.     This is multiplied by the AIPlayer's base movement rates (as defined in    its PlayerData datablock)      @see getMoveDestination())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setMoveSpeed(float speed)
        {
            m_ts.fnAIPlayer_setMoveSpeed(_ID, speed);
        }

        /// <summary>
        /// @brief Set the size of NavMesh this character uses. One of \"Small\", \"Regular\" or \"Large\".)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNavSize(string size)
        {
            m_ts.fnAIPlayer_setNavSize(_ID, size);
        }

        /// <summary>
        /// @brief Tells the AI to find a path to the location provided
        /// 
        ///    @param goal Coordinates in world space representing location to move to.
        ///    @return True if a path was found.
        /// 
        ///    @see getPathDestination()
        ///    @see setMoveDestination())
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool setPathDestination(Point3F goal)
        {
            return m_ts.fnAIPlayer_setPathDestination(_ID, goal.AsString());
        }

        /// <summary>
        /// @brief Tells the AIPlayer to stop moving.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void stop()
        {
            m_ts.fnAIPlayer_stop(_ID);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief While in motion, if an AIPlayer has moved less than moveStuckTolerance within a single tick, this    callback is called.   @param AIPlayer Object   )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMoveStuck(AIPlayer obj)
        {
        }

        /// <summary>
        /// @brief Called when the player has reached its set destination using the setMoveDestination() method.   The actual point at which this callback is called is when the AIPlayer is within the mMoveTolerance.   @param AIPlayer Object   )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onReachDestination(AIPlayer obj)
        {
        }

        /// <summary>
        /// @brief When an object is being aimed at (following a call to setAimObject()) and the targeted object enters    the AIPlayer's line of sight, this callback is called.   @param AIPlayer Object   )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTargetEnterLOS(AIPlayer obj)
        {
        }

        /// <summary>
        /// @brief When an object is being aimed at (following a call to setAimObject()) and the targeted object leaves    the AIPlayer's line of sight, this callback is called.   @param AIPlayer Object   )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTargetExitLOS(AIPlayer obj)
        {
        }

        #endregion

        public AIPlayer_Base()
        {
        }
    }
}