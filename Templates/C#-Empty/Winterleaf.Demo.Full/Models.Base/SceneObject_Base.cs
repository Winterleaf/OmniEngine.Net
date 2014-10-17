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
    [TypeConverter(typeof (TypeConverterGeneric<SceneObject_Base>))]
    public partial class SceneObject_Base : NetObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SceneObject_Base ts, string simobjectid)
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
        public static bool operator !=(SceneObject_Base ts, string simobjectid)
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
        public static implicit operator string(SceneObject_Base ts)
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
        public static implicit operator SceneObject_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SceneObject_Base) Omni.self.getSimObject(simobjectid, typeof (SceneObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SceneObject_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SceneObject_Base(int simobjectid)
        {
            return (SceneObject) Omni.self.getSimObject((uint) simobjectid, typeof (SceneObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SceneObject_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SceneObject_Base(uint simobjectid)
        {
            return (SceneObject_Base) Omni.self.getSimObject(simobjectid, typeof (SceneObject_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Controls client-side rendering of the object.\n     @see isRenderable()\n 
        /// </summary>
        [MemberGroup("Editing")]
        public bool isRenderEnabled
        {
            get { return Omni.self.GetVar(_ID + ".isRenderEnabled").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isRenderEnabled", value.AsString()); }
        }

        /// <summary>
        /// Determines if the object may be selected from wihin the Tools.\n     @see isSelectable()\n 
        /// </summary>
        [MemberGroup("Editing")]
        public bool isSelectionEnabled
        {
            get { return Omni.self.GetVar(_ID + ".isSelectionEnabled").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isSelectionEnabled", value.AsString()); }
        }

        /// <summary>
        /// Node we are mounted to. 
        /// </summary>
        [MemberGroup("Mounting")]
        public int mountNode
        {
            get { return Omni.self.GetVar(_ID + ".mountNode").AsInt(); }
            set { Omni.self.SetVar(_ID + ".mountNode", value.AsString()); }
        }

        /// <summary>
        /// @brief PersistentID of object we are mounted to.\n\n     Unlike the SimObjectID that is determined at run time, the PersistentID of an object is saved with the level/mission and      may be used to form a link between objects. 
        /// </summary>
        [MemberGroup("Mounting")]
        public int mountPID
        {
            get { return Omni.self.GetVar(_ID + ".mountPID").AsInt(); }
            set { Omni.self.SetVar(_ID + ".mountPID", value.AsString()); }
        }

        /// <summary>
        /// Position we are mounted at ( object space of our mount object ). 
        /// </summary>
        [MemberGroup("Mounting")]
        public MatrixPosition mountPos
        {
            get { return Omni.self.GetVar(_ID + ".mountPos").AsMatrixPosition(); }
            set { Omni.self.SetVar(_ID + ".mountPos", value.AsString()); }
        }

        /// <summary>
        /// Rotation we are mounted at ( object space of our mount object ). 
        /// </summary>
        [MemberGroup("Mounting")]
        public AngAxisF mountRot
        {
            get { return Omni.self.GetVar(_ID + ".mountRot").AsAngAxisF(); }
            set { Omni.self.SetVar(_ID + ".mountRot", value.AsString()); }
        }

        /// <summary>
        /// Object world position. 
        /// </summary>
        [MemberGroup("Transform")]
        public MatrixPosition position
        {
            get { return Omni.self.GetVar(_ID + ".position").AsMatrixPosition(); }
            set { Omni.self.SetVar(_ID + ".position", value.AsString()); }
        }

        /// <summary>
        /// Object world orientation. 
        /// </summary>
        [MemberGroup("Transform")]
        public AngAxisF rotation
        {
            get { return Omni.self.GetVar(_ID + ".rotation").AsAngAxisF(); }
            set { Omni.self.SetVar(_ID + ".rotation", value.AsString()); }
        }

        /// <summary>
        /// Object world scale. 
        /// </summary>
        [MemberGroup("Transform")]
        public Point3F scale
        {
            get { return Omni.self.GetVar(_ID + ".scale").AsPoint3F(); }
            set { Omni.self.SetVar(_ID + ".scale", value.AsString()); }
        }

        /// <summary>
        /// Used to turn script counter server notifications on or off.
        /// </summary>
        [MemberGroup("Scripting")]
        public bool TickCounterNotifyServer
        {
            get { return Omni.self.GetVar(_ID + ".TickCounterNotifyServer").AsBool(); }
            set { Omni.self.SetVar(_ID + ".TickCounterNotifyServer", value.AsString()); }
        }

        /// <summary>
        /// Used to turn script tick after notifications on or off.
        /// </summary>
        [MemberGroup("Scripting")]
        public bool TickNotifyAfter
        {
            get { return Omni.self.GetVar(_ID + ".TickNotifyAfter").AsBool(); }
            set { Omni.self.SetVar(_ID + ".TickNotifyAfter", value.AsString()); }
        }

        /// <summary>
        /// Used to turn script tick before notifications on or off.
        /// </summary>
        [MemberGroup("Scripting")]
        public bool TickNotifyBefore
        {
            get { return Omni.self.GetVar(_ID + ".TickNotifyBefore").AsBool(); }
            set { Omni.self.SetVar(_ID + ".TickNotifyBefore", value.AsString()); }
        }

        /// <summary>
        /// Used to turn script tick client notifications on or off.
        /// </summary>
        [MemberGroup("Scripting")]
        public bool TickNotifyClient
        {
            get { return Omni.self.GetVar(_ID + ".TickNotifyClient").AsBool(); }
            set { Omni.self.SetVar(_ID + ".TickNotifyClient", value.AsString()); }
        }

        /// <summary>
        /// Used to turn script tick server notifications on or off.
        /// </summary>
        [MemberGroup("Scripting")]
        public bool TickNotifyServer
        {
            get { return Omni.self.GetVar(_ID + ".TickNotifyServer").AsBool(); }
            set { Omni.self.SetVar(_ID + ".TickNotifyServer", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Get Euler rotation of this object.   @return the orientation of the object in the form of rotations around the    X, Y and Z axes in degrees. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getEulerRotation()
        {
            return new Point3F(m_ts.fnSceneObject_getEulerRotation(_ID));
        }

        /// <summary>
        /// Get the direction this object is facing.   @return a vector indicating the direction this object is facing.   @note This is the object's y axis. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getForwardVector()
        {
            return new Point3F(m_ts.fnSceneObject_getForwardVector(_ID));
        }

        /// <summary>
        /// Get the object's inverse transform.   @return the inverse transform of the object )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public TransformF getInverseTransform()
        {
            return new TransformF(m_ts.fnSceneObject_getInverseTransform(_ID));
        }

        /// <summary>
        /// Get the object mounted at a particular slot.   @param slot mount slot index to query   @return ID of the object mounted in the slot, or 0 if no object. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getMountedObject(int slot)
        {
            return m_ts.fnSceneObject_getMountedObject(_ID, slot);
        }

        /// <summary>
        /// Get the number of objects mounted to us.   @return the number of mounted objects. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getMountedObjectCount()
        {
            return m_ts.fnSceneObject_getMountedObjectCount(_ID);
        }

        /// <summary>
        /// @brief Get the mount node index of the object mounted at our given slot.   @param slot mount slot index to query   @return index of the mount node used by the object mounted in this slot. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getMountedObjectNode(int slot)
        {
            return m_ts.fnSceneObject_getMountedObjectNode(_ID, slot);
        }

        /// <summary>
        /// @brief Get the object mounted at our given node index.   @param node mount node index to query   @return ID of the first object mounted at the node, or 0 if none found. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getMountNodeObject(int node)
        {
            return m_ts.fnSceneObject_getMountNodeObject(_ID, node);
        }

        /// <summary>
        /// Get the object's bounding box (relative to the object's origin).   @return six fields, two Point3Fs, containing the min and max points of the    objectbox. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Box3F getObjectBox()
        {
            return new Box3F(m_ts.fnSceneObject_getObjectBox(_ID));
        }

        /// <summary>
        /// @brief Get the object we are mounted to.   @return the SimObjectID of the object we're mounted to, or 0 if not mounted. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getObjectMount()
        {
            return m_ts.fnSceneObject_getObjectMount(_ID);
        }

        /// <summary>
        /// Get the object's world position.   @return the current world position of the object )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getPosition()
        {
            return new Point3F(m_ts.fnSceneObject_getPosition(_ID));
        }

        /// <summary>
        /// Get the right vector of the object.   @return a vector indicating the right direction of this object.   @note This is the object's x axis. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getRightVector()
        {
            return new Point3F(m_ts.fnSceneObject_getRightVector(_ID));
        }

        /// <summary>
        /// Get the object's scale.   @return object scale as a Point3F )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getScale()
        {
            return new Point3F(m_ts.fnSceneObject_getScale(_ID));
        }

        /// <summary>
        /// Get the object's transform.   @return the current transform of the object )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public TransformF getTransform()
        {
            return new TransformF(m_ts.fnSceneObject_getTransform(_ID));
        }

        /// <summary>
        /// Return the type mask for this object.   @return The numeric type mask for the object. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getType()
        {
            return m_ts.fnSceneObject_getType(_ID);
        }

        /// <summary>
        /// Get the up vector of the object.   @return a vector indicating the up direction of this object.   @note This is the object's z axis. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getUpVector()
        {
            return new Point3F(m_ts.fnSceneObject_getUpVector(_ID));
        }

        /// <summary>
        /// Get the object's world bounding box.   @return six fields, two Point3Fs, containing the min and max points of the    worldbox. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Box3F getWorldBox()
        {
            return new Box3F(m_ts.fnSceneObject_getWorldBox(_ID));
        }

        /// <summary>
        /// Get the center of the object's world bounding box.   @return the center of the world bounding box for this object. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getWorldBoxCenter()
        {
            return new Point3F(m_ts.fnSceneObject_getWorldBoxCenter(_ID));
        }

        /// <summary>
        /// Check if this object has a global bounds set.   If global bounds are set to be true, then the object is assumed to have an    infinitely large bounding box for collision and rendering purposes.   @return true if the object has a global bounds. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isGlobalBounds()
        {
            return m_ts.fnSceneObject_isGlobalBounds(_ID);
        }

        /// <summary>
        /// @brief Check if we are mounted to another object.   @return true if mounted to another object, false if not mounted. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isMounted()
        {
            return m_ts.fnSceneObject_isMounted(_ID);
        }

        /// <summary>
        /// @brief Mount objB to this object at the desired slot with optional transform.   @param objB  Object to mount onto us   @param slot  Mount slot ID   @param txfm (optional) mount offset transform   @return true if successful, false if failed (objB is not valid) )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool mountObject(string objB, int slot, TransformF txfm = null)
        {
            if (txfm == null)
                txfm = new TransformF("0.000000,0.000000,0.000000,1.000000,0.000000,0.000000,0.000000");

            return m_ts.fnSceneObject_mountObject(_ID, objB, slot, txfm.AsString());
        }

        /// <summary>
        /// Set the object's scale.   @param scale object scale to set )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setScale(Point3F scale)
        {
            m_ts.fnSceneObject_setScale(_ID, scale.AsString());
        }

        /// <summary>
        /// Set the object's transform (orientation and position).   @param txfm object transform to set )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setTransform(TransformF txfm)
        {
            m_ts.fnSceneObject_setTransform(_ID, txfm.AsString());
        }

        /// <summary>
        /// @brief Adds a new counter or updates an existing counter to be tracked via ticks.   @return true if successful, false if failed )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool TickCounterAdd(string countername, uint interval)
        {
            return m_ts.fnSceneObject_TickCounterAdd(_ID, countername, interval);
        }

        /// <summary>
        /// @brief returns the interval for a counter.   @return true if successful, false if failed )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public uint TickCounterGetInterval(string countername)
        {
            return m_ts.fnSceneObject_TickCounterGetInterval(_ID, countername);
        }

        /// <summary>
        /// @brief Checks to see if the counter exists.   @return true if successful, false if failed )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool TickCounterHas(string countername)
        {
            return m_ts.fnSceneObject_TickCounterHas(_ID, countername);
        }

        /// <summary>
        /// @brief Removes a counter to be tracked via ticks.   @return true if successful, false if failed )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool TickCounterRemove(string countername)
        {
            return m_ts.fnSceneObject_TickCounterRemove(_ID, countername);
        }

        /// <summary>
        /// @brief resets the current count for a counter.   @return true if successful, false if failed )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void TickCounterReset(string countername)
        {
            m_ts.fnSceneObject_TickCounterReset(_ID, countername);
        }

        /// <summary>
        /// @brief Clears all counters from the object.)   
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void TickCountersClear()
        {
            m_ts.fnSceneObject_TickCountersClear(_ID);
        }

        /// <summary>
        /// @brief Adds a new counter to be tracked via ticks.    )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void TickCounterSuspend(string countername, bool suspend)
        {
            m_ts.fnSceneObject_TickCounterSuspend(_ID, countername, suspend);
        }

        /// <summary>
        /// Unmount us from the currently mounted object if any. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void unmount()
        {
            m_ts.fnSceneObject_unmount(_ID);
        }

        /// <summary>
        /// @brief Unmount an object from ourselves.   @param target object to unmount   @return true if successful, false if failed )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool unmountObject(string target)
        {
            return m_ts.fnSceneObject_unmountObject(_ID, target);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onEditorRender(string editor, string selected, string expanded)
        {
        }

        /// <summary>
        /// @brif Called before this object is Ticked in the engine on the Client.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTickClientBefore()
        {
        }

        /// <summary>
        /// @brif Called after this object is Ticked in the engine on the Client.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTickClientAfter()
        {
        }

        /// <summary>
        /// @brif Called before this object is Ticked in the engine on the Server.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTickServerBefore()
        {
        }

        /// <summary>
        /// @brif Called after this object is Ticked in the engine on the Server.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTickServerAfter()
        {
        }

        /// <summary>
        /// @brif Called after this object is Ticked and a counter interval is reached.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTickCounter(string counterName)
        {
        }

        #endregion

        public SceneObject_Base()
        {
        }
    }
}