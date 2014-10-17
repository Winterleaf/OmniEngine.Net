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
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiObjectView_Base>))]
    public partial class GuiObjectView_Base : GuiTSCtrl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiObjectView_Base ts, string simobjectid)
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
        public static bool operator !=(GuiObjectView_Base ts, string simobjectid)
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
        public static implicit operator string(GuiObjectView_Base ts)
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
        public static implicit operator GuiObjectView_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiObjectView_Base) Omni.self.getSimObject(simobjectid, typeof (GuiObjectView_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiObjectView_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiObjectView_Base(int simobjectid)
        {
            return (GuiObjectView) Omni.self.getSimObject((uint) simobjectid, typeof (GuiObjectView_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiObjectView_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiObjectView_Base(uint simobjectid)
        {
            return (GuiObjectView_Base) Omni.self.getSimObject(simobjectid, typeof (GuiObjectView_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// The animation sequence to play on the model. 
        /// </summary>
        [MemberGroup("Animation")]
        public String animSequence
        {
            get { return Omni.self.GetVar(_ID + ".animSequence").AsString(); }
            set { Omni.self.SetVar(_ID + ".animSequence", value.AsString()); }
        }

        /// <summary>
        /// Set the camera rotation. 
        /// </summary>
        [MemberGroup("Camera")]
        public Point3F cameraRotation
        {
            get { return Omni.self.GetVar(_ID + ".cameraRotation").AsPoint3F(); }
            set { Omni.self.SetVar(_ID + ".cameraRotation", value.AsString()); }
        }

        /// <summary>
        /// Multiplier for mouse camera operations. 
        /// </summary>
        [MemberGroup("Camera")]
        public float cameraSpeed
        {
            get { return Omni.self.GetVar(_ID + ".cameraSpeed").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".cameraSpeed", value.AsString()); }
        }

        /// <summary>
        /// Ambient color of the sunlight used to render the model. 
        /// </summary>
        [MemberGroup("Lighting")]
        public ColorF lightAmbient
        {
            get { return Omni.self.GetVar(_ID + ".lightAmbient").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".lightAmbient", value.AsString()); }
        }

        /// <summary>
        /// Diffuse color of the sunlight used to render the model. 
        /// </summary>
        [MemberGroup("Lighting")]
        public ColorF lightColor
        {
            get { return Omni.self.GetVar(_ID + ".lightColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".lightColor", value.AsString()); }
        }

        /// <summary>
        /// Direction from which the model is illuminated. 
        /// </summary>
        [MemberGroup("Lighting")]
        public Point3F lightDirection
        {
            get { return Omni.self.GetVar(_ID + ".lightDirection").AsPoint3F(); }
            set { Omni.self.SetVar(_ID + ".lightDirection", value.AsString()); }
        }

        /// <summary>
        /// Minimum distance below which the camera will not zoom in further. 
        /// </summary>
        [MemberGroup("Camera")]
        public float maxOrbitDiststance
        {
            get { return Omni.self.GetVar(_ID + ".maxOrbitDiststance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".maxOrbitDiststance", value.AsString()); }
        }

        /// <summary>
        /// Maxiumum distance to which the camera can be zoomed out. 
        /// </summary>
        [MemberGroup("Camera")]
        public float minOrbitDiststance
        {
            get { return Omni.self.GetVar(_ID + ".minOrbitDiststance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".minOrbitDiststance", value.AsString()); }
        }

        /// <summary>
        /// Name of node on primary model to which to mount the secondary shape. 
        /// </summary>
        [MemberGroup("Mounting")]
        public String mountedNode
        {
            get { return Omni.self.GetVar(_ID + ".mountedNode").AsString(); }
            set { Omni.self.SetVar(_ID + ".mountedNode", value.AsString()); }
        }

        /// <summary>
        /// Optional shape file to mount on the primary model (e.g. weapon). 
        /// </summary>
        [MemberGroup("Mounting")]
        public String mountedShapeFile
        {
            get { return Omni.self.GetVar(_ID + ".mountedShapeFile").AsString(); }
            set { Omni.self.SetVar(_ID + ".mountedShapeFile", value.AsString()); }
        }

        /// <summary>
        /// Skin name used on mounted shape file. 
        /// </summary>
        [MemberGroup("Mounting")]
        public String mountedSkin
        {
            get { return Omni.self.GetVar(_ID + ".mountedSkin").AsString(); }
            set { Omni.self.SetVar(_ID + ".mountedSkin", value.AsString()); }
        }

        /// <summary>
        /// Distance from which to render the model. 
        /// </summary>
        [MemberGroup("Camera")]
        public float orbitDiststance
        {
            get { return Omni.self.GetVar(_ID + ".orbitDiststance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".orbitDiststance", value.AsString()); }
        }

        /// <summary>
        /// The object model shape file to show in the view. 
        /// </summary>
        [MemberGroup("Model")]
        public String shapeFile
        {
            get { return Omni.self.GetVar(_ID + ".shapeFile").AsString(); }
            set { Omni.self.SetVar(_ID + ".shapeFile", value.AsString()); }
        }

        /// <summary>
        /// The skin to use on the object model. 
        /// </summary>
        [MemberGroup("Model")]
        public String skin
        {
            get { return Omni.self.GetVar(_ID + ".skin").AsString(); }
            set { Omni.self.SetVar(_ID + ".skin", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Return the current multiplier for camera zooming and rotation.   @tsexample   // Request the current camera zooming and rotation multiplier value   %multiplier = %thisGuiObjectView.getCameraSpeed();   @endtsexample   @return Camera zooming / rotation multiplier value.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getCameraSpeed()
        {
            return m_ts.fnGuiObjectView_getCameraSpeed(_ID);
        }

        /// <summary>
        /// @brief Return the model displayed in this view.   @tsexample   // Request the displayed model name from the GuiObjectView object.   %modelName = %thisGuiObjectView.getModel();   @endtsexample   @return Name of the displayed model.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getModel()
        {
            return m_ts.fnGuiObjectView_getModel(_ID);
        }

        /// <summary>
        /// @brief Return the name of the mounted model.   @tsexample   // Request the name of the mounted model from the GuiObjectView object   %mountedModelName = %thisGuiObjectView.getMountedModel();   @endtsexample   @return Name of the mounted model.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getMountedModel()
        {
            return m_ts.fnGuiObjectView_getMountedModel(_ID);
        }

        /// <summary>
        /// @brief Return the name of skin used on the mounted model.   @tsexample   // Request the skin name from the model mounted on to the main model in the control   %mountModelSkin = %thisGuiObjectView.getMountSkin();   @endtsexample   @return Name of the skin used on the mounted model.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getMountSkin(int param1, int param2)
        {
            return m_ts.fnGuiObjectView_getMountSkin(_ID, param1, param2);
        }

        /// <summary>
        /// @brief Return the current distance at which the camera orbits the object.   @tsexample   // Request the current orbit distance   %orbitDistance = %thisGuiObjectView.getOrbitDistance();   @endtsexample   @return The distance at which the camera orbits the object.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getOrbitDistance()
        {
            return m_ts.fnGuiObjectView_getOrbitDistance(_ID);
        }

        /// <summary>
        /// @brief Return the name of skin used on the primary model.   @tsexample   // Request the name of the skin used on the primary model in the control   %skinName = %thisGuiObjectView.getSkin();   @endtsexample   @return Name of the skin used on the primary model.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getSkin()
        {
            return m_ts.fnGuiObjectView_getSkin(_ID);
        }

        /// <summary>
        /// @brief Sets the multiplier for the camera rotation and zoom speed.   @param factor Multiplier for camera rotation and zoom speed.   @tsexample   // Set the factor value   %factor = \"0.75\";   // Inform the GuiObjectView object to set the camera speed.   %thisGuiObjectView.setCameraSpeed(%factor);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setCameraSpeed(float factor)
        {
            m_ts.fnGuiObjectView_setCameraSpeed(_ID, factor);
        }

        /// <summary>
        /// @brief Set the light ambient color on the sun object used to render the model.   @param color Ambient color of sunlight.   @tsexample   // Define the sun ambient color value   %color = \"1.0 0.4 0.6\";   // Inform the GuiObjectView object to set the sun ambient color to the requested value   %thisGuiObjectView.setLightAmbient(%color);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setLightAmbient(ColorF color)
        {
            m_ts.fnGuiObjectView_setLightAmbient(_ID, color.AsString());
        }

        /// <summary>
        /// @brief Set the light color on the sun object used to render the model.   @param color Color of sunlight.   @tsexample   // Set the color value for the sun   %color = \"1.0 0.4 0.5\";   // Inform the GuiObjectView object to change the sun color to the defined value   %thisGuiObjectView.setLightColor(%color);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setLightColor(ColorF color)
        {
            m_ts.fnGuiObjectView_setLightColor(_ID, color.AsString());
        }

        /// <summary>
        /// @brief Set the light direction from which to light the model.   @param direction XYZ direction from which the light will shine on the model   @tsexample   // Set the light direction   %direction = \"1.0 0.2 0.4\"   // Inform the GuiObjectView object to change the light direction to the defined value   %thisGuiObjectView.setLightDirection(%direction);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setLightDirection(Point3F direction)
        {
            m_ts.fnGuiObjectView_setLightDirection(_ID, direction.AsString());
        }

        /// <summary>
        /// @brief Sets the model to be displayed in this control.   @param shapeName Name of the model to display.   @tsexample   // Define the model we want to display   %shapeName = \"gideon.dts\";   // Tell the GuiObjectView object to display the defined model   %thisGuiObjectView.setModel(%shapeName);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setModel(string shapeName)
        {
            m_ts.fnGuiObjectView_setModel(_ID, shapeName);
        }

        /// <summary>
        /// @brief Mounts the given model to the specified mount point of the primary model displayed in this control.   Detailed description   @param shapeName Name of the model to mount.   @param mountNodeIndexOrName Index or name of the mount point to be mounted to. If index, corresponds to \"mountN\" in your shape where N is the number passed here.   @tsexample   // Set the shapeName to mount   %shapeName = \"GideonGlasses.dts\"   // Set the mount node of the primary model in the control to mount the new shape at   %mountNodeIndexOrName = \"3\";   //OR:   %mountNodeIndexOrName = \"Face\";   // Inform the GuiObjectView object to mount the shape at the specified node.   %thisGuiObjectView.setMount(%shapeName,%mountNodeIndexOrName);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setMount(string shapeName, string mountNodeIndexOrName)
        {
            m_ts.fnGuiObjectView_setMount(_ID, shapeName, mountNodeIndexOrName);
        }

        /// <summary>
        /// @brief Sets the model to be mounted on the primary model.   @param shapeName Name of the model to mount.   @tsexample   // Define the model name to mount   %modelToMount = \"GideonGlasses.dts\";   // Inform the GuiObjectView object to mount the defined model to the existing model in the control   %thisGuiObjectView.setMountedModel(%modelToMount);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setMountedModel(string shapeName)
        {
            m_ts.fnGuiObjectView_setMountedModel(_ID, shapeName);
        }

        /// <summary>
        /// @brief Sets the skin to use on the mounted model.   @param skinName Name of the skin to set on the model mounted to the main model in the control   @tsexample   // Define the name of the skin   %skinName = \"BronzeGlasses\";   // Inform the GuiObjectView Control of the skin to use on the mounted model   %thisGuiObjectViewCtrl.setMountSkin(%skinName);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setMountSkin(string skinName)
        {
            m_ts.fnGuiObjectView_setMountSkin(_ID, skinName);
        }

        /// <summary>
        /// @brief Sets the distance at which the camera orbits the object. Clamped to the acceptable range defined in the class by min and max orbit distances.   Detailed description   @param distance The distance to set the orbit to (will be clamped).   @tsexample   // Define the orbit distance value   %orbitDistance = \"1.5\";   // Inform the GuiObjectView object to set the orbit distance to the defined value   %thisGuiObjectView.setOrbitDistance(%orbitDistance);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setOrbitDistance(float distance)
        {
            m_ts.fnGuiObjectView_setOrbitDistance(_ID, distance);
        }

        /// <summary>
        /// @brief Sets the animation to play for the viewed object.   @param indexOrName The index or name of the animation to play.   @tsexample   // Set the animation index value, or animation sequence name.   %indexVal = \"3\";   //OR:   %indexVal = \"idle\";   // Inform the GuiObjectView object to set the animation sequence of the object in the control.   %thisGuiObjectVew.setSeq(%indexVal);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSeq(string indexOrName)
        {
            m_ts.fnGuiObjectView_setSeq(_ID, indexOrName);
        }

        /// <summary>
        /// @brief Sets the skin to use on the model being displayed.   @param skinName Name of the skin to use.   @tsexample   // Define the skin we want to apply to the main model in the control   %skinName = \"disco_gideon\";   // Inform the GuiObjectView control to update the skin the to defined skin   %thisGuiObjectView.setSkin(%skinName);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSkin(string skinName)
        {
            m_ts.fnGuiObjectView_setSkin(_ID, skinName);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief Called whenever the mouse enters the control.   @tsexample   // The mouse has entered the control, causing the callback to occur   GuiObjectView::onMouseEnter(%this)   	{   		// Code to run when the mouse enters this control   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseEnter()
        {
        }

        /// <summary>
        /// @brief Called whenever the mouse leaves the control.   @tsexample   // The mouse has left the control, causing the callback to occur   GuiObjectView::onMouseLeave(%this)   	{   		// Code to run when the mouse leaves this control   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseLeave()
        {
        }

        #endregion

        public GuiObjectView_Base()
        {
        }
    }
}