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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiTSCtrl_Base>))]
    public partial class GuiTSCtrl_Base : GuiContainer
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTSCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTSCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiTSCtrl_Base ts)
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
        public static implicit operator GuiTSCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiTSCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTSCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiTSCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTSCtrl_Base(int simobjectid)
        {
            return (GuiTSCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiTSCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiTSCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTSCtrl_Base(uint simobjectid)
        {
            return (GuiTSCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTSCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// . 
        /// </summary>
        [MemberGroup("Camera")]
        public float cameraRoll
        {
            get { return Omni.self.GetVar(_ID + ".cameraRoll").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".cameraRoll", value.AsString()); }
        }

        /// <summary>
        /// Z rotation angle of camera. 
        /// </summary>
        [MemberGroup("Camera")]
        public float cameraZRot
        {
            get { return Omni.self.GetVar(_ID + ".cameraZRot").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".cameraZRot", value.AsString()); }
        }

        /// <summary>
        /// . 
        /// </summary>
        [MemberGroup("Camera")]
        public bool enableAugmentations
        {
            get { return Omni.self.GetVar(_ID + ".enableAugmentations").AsBool(); }
            set { Omni.self.SetVar(_ID + ".enableAugmentations", value.AsString()); }
        }

        /// <summary>
        /// . 
        /// </summary>
        [MemberGroup("Camera")]
        public float forceAspect
        {
            get { return Omni.self.GetVar(_ID + ".forceAspect").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".forceAspect", value.AsString()); }
        }

        /// <summary>
        /// The vertical field of view in degrees or zero to use the normal camera FOV. 
        /// </summary>
        [MemberGroup("Camera")]
        public float forceFOV
        {
            get { return Omni.self.GetVar(_ID + ".forceFOV").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".forceFOV", value.AsString()); }
        }

        /// <summary>
        /// . 
        /// </summary>
        [MemberGroup("Camera")]
        public Point4F forceFrustumOffset
        {
            get { return Omni.self.GetVar(_ID + ".forceFrustumOffset").AsPoint4F(); }
            set { Omni.self.SetVar(_ID + ".forceFrustumOffset", value.AsString()); }
        }

        /// <summary>
        /// The share of the per-frame reflection update work this control's rendering should run.\n     The reflect update priorities of all visible GuiTSCtrls are added together and each control is assigned      a share of the per-frame reflection update time according to its percentage of the total priority value. 
        /// </summary>
        [MemberGroup("Rendering")]
        public float reflectPriority
        {
            get { return Omni.self.GetVar(_ID + ".reflectPriority").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".reflectPriority", value.AsString()); }
        }

        /// <summary>
        /// Indicates how this control should render its contents. 
        /// </summary>
        [MemberGroup("Rendering")]
        public TypeGuiTSRenderStyles renderStyle
        {
            get { return (TypeGuiTSRenderStyles) Omni.self.GetVar(_ID + ".renderStyle"); }
            set { Omni.self.SetVar(_ID + ".renderStyle", value.ToString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Given the camera's current FOV, get the distance from the camera's viewpoint at which the given radius will fit in the render area.   @param radius Radius in world-space units which should fit in the view.   @return The distance from the viewpoint at which the given radius would be fully visible. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float calculateViewDistance(float radius)
        {
            return m_ts.fnGuiTSCtrl_calculateViewDistance(_ID, radius);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getClickVector(Point2I mousePoint)
        {
            return m_ts.fnGuiTSCtrl_getClickVector(_ID, mousePoint.AsString());
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getWorldPosition(Point2I mousePoint)
        {
            return m_ts.fnGuiTSCtrl_getWorldPosition(_ID, mousePoint.AsString());
        }

        /// <summary>
        /// Get the ratio between world-space units and pixels.   @return The amount of world-space units covered by the extent of a single pixel. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point2F getWorldToScreenScale()
        {
            return new Point2F(m_ts.fnGuiTSCtrl_getWorldToScreenScale(_ID));
        }

        /// <summary>
        /// Transform world-space coordinates to screen-space (x, y, depth) coordinates.   @param worldPosition The world-space position to transform to screen-space.   @return The  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F project(Point3F worldPosition)
        {
            return new Point3F(m_ts.fnGuiTSCtrl_project(_ID, worldPosition.AsString()));
        }

        /// <summary>
        /// Transform 3D screen-space coordinates (x, y, depth) to world space.   This method can be, for example, used to find the world-space position relating to the current mouse cursor position.   @param screenPosition The x/y position on the screen plus the depth from the screen-plane outwards.   @return The world-space position corresponding to the given screen-space coordinates. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F unproject(Point3F screenPosition)
        {
            return new Point3F(m_ts.fnGuiTSCtrl_unproject(_ID, screenPosition.AsString()));
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public GuiTSCtrl_Base()
        {
        }
    }
}