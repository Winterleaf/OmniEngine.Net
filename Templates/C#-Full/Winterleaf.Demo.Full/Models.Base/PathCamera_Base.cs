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
    [TypeConverter(typeof (TypeConverterGeneric<PathCamera_Base>))]
    public partial class PathCamera_Base : ShapeBase
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PathCamera_Base ts, string simobjectid)
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
        public static bool operator !=(PathCamera_Base ts, string simobjectid)
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
        public static implicit operator string(PathCamera_Base ts)
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
        public static implicit operator PathCamera_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (PathCamera_Base) Omni.self.getSimObject(simobjectid, typeof (PathCamera_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(PathCamera_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PathCamera_Base(int simobjectid)
        {
            return (PathCamera) Omni.self.getSimObject((uint) simobjectid, typeof (PathCamera_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(PathCamera_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PathCamera_Base(uint simobjectid)
        {
            return (PathCamera_Base) Omni.self.getSimObject(simobjectid, typeof (PathCamera_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// Removes the knot at the front of the camera's path.													@tsexample														// Remove the first knot in the camera's path.														%pathCamera.popFront();													@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void popFront()
        {
            m_ts.fnPathCamera_popFront(_ID);
        }

        /// <summary>
        /// Normal, Linear), 											      @brief Adds a new knot to the back of a path camera's path.													@param transform Transform for the new knot.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()													@param speed Speed setting for this knot.													@param type Knot type (Normal, Position Only, Kink).													@param path %Path type (Linear, Spline).													@tsexample														// Transform vector for new knot. (Pos_X Pos_Y Pos_Z Rot_X Rot_Y Rot_Z Angle)														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"														// Speed setting for knot.														%speed = \"1.0\"														// Knot type. (Normal, Position Only, Kink)														%type = \"Normal\";														// Path Type. (Linear, Spline)														%path = \"Linear\";														// Inform the path camera to add a new knot to the back of its path														%pathCamera.pushBack(%transform,%speed,%type,%path);													@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pushBack(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear")
        {
            m_ts.fnPathCamera_pushBack(_ID, transform.AsString(), speed, type, path);
        }

        /// <summary>
        /// Normal, Linear), 											      @brief Adds a new knot to the front of a path camera's path.													@param transform Transform for the new knot. In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()													@param speed Speed setting for this knot.													@param type Knot type (Normal, Position Only, Kink).													@param path %Path type (Linear, Spline).													@tsexample														// Transform vector for new knot. (Pos_X,Pos_Y,Pos_Z,Rot_X,Rot_Y,Rot_Z,Angle)														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"														// Speed setting for knot.														%speed = \"1.0\";														// Knot type. (Normal, Position Only, Kink)														%type = \"Normal\";														// Path Type. (Linear, Spline)														%path = \"Linear\";														// Inform the path camera to add a new knot to the front of its path														%pathCamera.pushFront(%transform, %speed, %type, %path);													@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pushFront(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear")
        {
            m_ts.fnPathCamera_pushFront(_ID, transform.AsString(), speed, type, path);
        }

        /// <summary>
        /// @brief Clear the camera's path and set the camera's current transform as the start of the new path.                                       What specifically occurs is a new knot is created from the camera's current transform.  Then the current path                                        is cleared and the new knot is pushed onto the path.  Any previous target is cleared and the camera's movement                                        state is set to Forward.  The camera is now ready for a new path to be defined.													@param speed Speed for the camera to move along its path after being reset.													@tsexample														//Determine the new movement speed of this camera. If not set, the speed will default to 1.0.														%speed = \"0.50\";														// Inform the path camera to start a new path at                                          // the camera's current position, and set the new                                           // path's speed value.														%pathCamera.reset(%speed);                                       @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void reset(float speed = 1.0f)
        {
            m_ts.fnPathCamera_reset(_ID, speed);
        }

        /// <summary>
        /// Set the current position of the camera along the path.													@param position Position along the path, from 0.0 (path start) - 1.0 (path end), to place the camera.													@tsexample                                          // Set the camera on a position along its path from 0.0 - 1.0.														%position = \"0.35\";														// Force the pathCamera to its new position along the path.														%pathCamera.setPosition(%position);													@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setPosition(float position = 0.0f)
        {
            m_ts.fnPathCamera_setPosition(_ID, position);
        }

        /// <summary>
        /// forward), Set the movement state for this path camera.													@param newState New movement state type for this camera. Forward, Backward or Stop.													@tsexample														// Set the state type (forward, backward, stop).                                          // In this example, the camera will travel from the first node                                          // to the last node (or target if given with setTarget())														%state = \"forward\";														// Inform the pathCamera to change its movement state to the defined value.														%pathCamera.setState(%state);													@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setState(string newState = "forward")
        {
            m_ts.fnPathCamera_setState(_ID, newState);
        }

        /// <summary>
        /// @brief Set the movement target for this camera along its path.                                       The camera will attempt to move along the path to the given target in the direction provided                                        by setState() (the default is forwards).  Once the camera moves past this target it will come                                        to a stop, and the target state will be cleared.													@param position Target position, between 0.0 (path start) and 1.0 (path end), for the camera to move to along its path.													@tsexample                                          // Set the position target, between 0.0 (path start) and 1.0 (path end), for this camera to move to.														%position = \"0.50\";														// Inform the pathCamera of the new target position it will move to.														%pathCamera.setTarget(%position);													@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setTarget(float position = 1.0f)
        {
            m_ts.fnPathCamera_setTarget(_ID, position);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// A script callback that indicates the path camera has arrived at a specific node in its path.  Server side only.					@param Node Unique ID assigned to this node.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onNode(string node)
        {
        }

        #endregion

        public PathCamera_Base()
        {
        }
    }
}