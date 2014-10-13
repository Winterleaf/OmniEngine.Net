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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<TSPathShape_Base>))]
    public partial class TSPathShape_Base : TSDynamic
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TSPathShape_Base ts, string simobjectid)
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
        public static bool operator !=(TSPathShape_Base ts, string simobjectid)
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
        public static implicit operator string(TSPathShape_Base ts)
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
        public static implicit operator TSPathShape_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TSPathShape_Base) Omni.self.getSimObject(simobjectid, typeof (TSPathShape_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TSPathShape_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TSPathShape_Base(int simobjectid)
        {
            return (TSPathShape) Omni.self.getSimObject((uint) simobjectid, typeof (TSPathShape_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TSPathShape_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TSPathShape_Base(uint simobjectid)
        {
            return (TSPathShape_Base) Omni.self.getSimObject(simobjectid, typeof (TSPathShape_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// The shape movement direction/state. 
        /// </summary>
        [MemberGroup("Movement")]
        public TypePathShapeState movementState
        {
            get { return (TypePathShapeState) Omni.self.GetVar(_ID + ".movementState"); }
            set { Omni.self.SetVar(_ID + ".movementState", value.ToString()); }
        }

        /// <summary>
        /// Name of a Path to follow. 
        /// </summary>
        [MemberGroup("Movement")]
        public Path Path
        {
            get { return Omni.self.GetVar(_ID + ".Path"); }
            set { Omni.self.SetVar(_ID + ".Path", value.ToString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Returns the looping state for the shape.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool getLooping()
        {
            return m_ts.fnTSPathShape_getLooping(_ID);
        }

        /// <summary>
        /// Returns the number of nodes on the shape's path.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getNodeCount()
        {
            return m_ts.fnTSPathShape_getNodeCount(_ID);
        }

        /// <summary>
        /// Get the current position of the shape along the path (0.0 - lastNode - 1).)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getPathPosition()
        {
            return m_ts.fnTSPathShape_getPathPosition(_ID);
        }

        /// <summary>
        /// Removes the knot at the front of the shape's path.													@tsexample														// Remove the first knot in the shape's path.														%pathShape.popFront();													@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void popFront()
        {
            m_ts.fnTSPathShape_popFront(_ID);
        }

        /// <summary>
        /// Normal, Linear), 											      @brief Adds a new knot to the back of a shape's path.													@param transform Transform for the new knot.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()													@param speed Speed setting for this knot.													@param type Knot type (Normal, Position Only, Kink).													@param path %Path type (Linear, Spline).													@tsexample														// Transform vector for new knot. (Pos_X Pos_Y Pos_Z Rot_X Rot_Y Rot_Z Angle)														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"														// Speed setting for knot.														%speed = \"1.0\"														// Knot type. (Normal, Position Only, Kink)														%type = \"Normal\";														// Path Type. (Linear, Spline)														%path = \"Linear\";														// Inform the shape to add a new knot to the back of its path														%pathShape.pushBack(%transform,%speed,%type,%path);													@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pushBack(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear")
        {
            m_ts.fnTSPathShape_pushBack(_ID, transform.AsString(), speed, type, path);
        }

        /// <summary>
        /// Normal, Linear), 											      @brief Adds a new knot to the front of a path shape's path.													@param transform Transform for the new knot. In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()													@param speed Speed setting for this knot.													@param type Knot type (Normal, Position Only, Kink).													@param path %Path type (Linear, Spline).													@tsexample														// Transform vector for new knot. (Pos_X,Pos_Y,Pos_Z,Rot_X,Rot_Y,Rot_Z,Angle)														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"														// Speed setting for knot.														%speed = \"1.0\";														// Knot type. (Normal, Position Only, Kink)														%type = \"Normal\";														// Path Type. (Linear, Spline)														%path = \"Linear\";														// Inform the shape to add a new knot to the front of its path														%pathShape.pushFront(%transform, %speed, %type, %path);													@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pushFront(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear")
        {
            m_ts.fnTSPathShape_pushFront(_ID, transform.AsString(), speed, type, path);
        }

        /// <summary>
        /// @brief Clear the shapes's path and optionally initializes the first node with the shapes current transform and speed.         The shapes movement is stopped and any current path is cleared. The target and position values are both reset to 0.          When makeFirstKnot is true a new knot is created and pushed onto the path.         @param speed Speed for the first knot if created.         @param makeFirstKnot Initialize a new path with the current shape transform.         @param initFromPath Initialize the knot type and smoothing values from the current path.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void reset(float speed = 1.0f, bool makeFirstKnot = true, bool initFromPath = true)
        {
            m_ts.fnTSPathShape_reset(_ID, speed, makeFirstKnot, initFromPath);
        }

        /// <summary>
        /// Sets whether the path should loop or stop at the last node.													@param isLooping New loop flag true/false.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setLooping(bool isLooping = true)
        {
            m_ts.fnTSPathShape_setLooping(_ID, isLooping);
        }

        /// <summary>
        /// Set the movement state for this shape.													@param newState New movement state type for this shape. Forward, Backward or Stop.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setMoveState(TypePathShapeState newState = null)
        {
            if (newState == null)
                newState = TypePathShapeState.Forward;

            m_ts.fnTSPathShape_setMoveState(_ID, (int) newState);
        }

        /// <summary>
        /// Set the current position of the shape along the path.													@param position Position along the path, from 0.0 (path start) - 1.0 (path end), to place the shape.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setPathPosition(float position = 0.0f)
        {
            m_ts.fnTSPathShape_setPathPosition(_ID, position);
        }

        /// <summary>
        /// @brief Set the movement target for this shape along its path.                                       The shape will attempt to move along the path to the given target without going past the loop node.                                        Once the shape arrives at the target,the onTargetReached() callback will be triggered and the target                                        state will be cleared.													@param position Target position, between 0.0 (path start) and nodeCount - 1 (path end), for the                                        shape to move to along its path.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setTarget(float position = 1.0f)
        {
            m_ts.fnTSPathShape_setTarget(_ID, position);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Called when this TSPathShape is added to the system.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onAdd()
        {
        }

        /// <summary>
        /// Called when the path variable for this this TSPathShape has been changed from script or editor.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPathChange()
        {
        }

        /// <summary>
        /// A script callback that indicates the path shape has arrived at a specific node in its path.  Server side only.					@param Node The index number for the node reached.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onNode(int node)
        {
        }

        /// <summary>
        /// A script callback that indicates the path shape has arrived at it's target value.  Server side only.					@param value The current position value.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTargetReached(float value)
        {
        }

        #endregion

        public TSPathShape_Base()
        {
        }
    }
}