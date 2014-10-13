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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiGraphCtrl_Base>))]
    public partial class GuiGraphCtrl_Base : GuiControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiGraphCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiGraphCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiGraphCtrl_Base ts)
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
        public static implicit operator GuiGraphCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiGraphCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiGraphCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiGraphCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiGraphCtrl_Base(int simobjectid)
        {
            return (GuiGraphCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiGraphCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiGraphCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiGraphCtrl_Base(uint simobjectid)
        {
            return (GuiGraphCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiGraphCtrl_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("Graph")] public arrayObject<ColorF> plotColor;
        [MemberGroup("Graph")] public arrayObject<int> plotInterval;
        [MemberGroup("Graph")] public arrayObject<int> plotType;
        [MemberGroup("Graph")] public arrayObject<String> plotVariable;

        /// <summary>
        /// Ratio of where to place the center coordinate of the graph on the Y axis. 0.5=middle height of control.\n\n     This allows to account for graphs that have only positive or only negative data points, for example. 
        /// </summary>
        [MemberGroup("Graph")]
        public float centerY
        {
            get { return Omni.self.GetVar(_ID + ".centerY").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".centerY", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Sets up the given plotting curve to automatically plot the value of the @a variable with a    frequency of @a updateFrequency.   @param plotId Index of the plotting curve.  Must be 0=plotId6.   @param variable Name of the global variable.   @param updateFrequency Frequency with which to add new data points to the plotting curve (in milliseconds).   @tsexample   // Plot FPS counter at 1 second intervals.   %graph.addAutoPlot( 0, \"fps::real\", 1000 );   @endtsexample )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addAutoPlot(int plotId, string variable, int updateFrequency)
        {
            m_ts.fnGuiGraphCtrl_addAutoPlot(_ID, plotId, variable, updateFrequency);
        }

        /// <summary>
        /// Add a data point to the plot's curve.   @param plotId Index of the plotting curve to which to add the data point.  Must be 0=plotId6.   @param value Value of the data point to add to the curve.   @note Data values are added to the @b left end of the plotting curve.   @note A maximum number of 200 data points can be added to any single plotting curve at any one time.  If       this limit is exceeded, data points on the right end of the curve are culled. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addDatum(int plotId, float value)
        {
            m_ts.fnGuiGraphCtrl_addDatum(_ID, plotId, value);
        }

        /// <summary>
        /// Get a data point on the given plotting curve.   @param plotId Index of the plotting curve from which to fetch the data point.  Must be 0=plotId6.   @param index Index of the data point on the curve.   @return The value of the data point or -1 if @a plotId or @a index are out of range. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getDatum(int plotId, int index)
        {
            return m_ts.fnGuiGraphCtrl_getDatum(_ID, plotId, index);
        }

        /// <summary>
        /// Stop automatic variable plotting for the given curve.   @param plotId Index of the plotting curve.  Must be 0=plotId6. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeAutoPlot(int plotId)
        {
            m_ts.fnGuiGraphCtrl_removeAutoPlot(_ID, plotId);
        }

        /// <summary>
        /// Change the charting type of the given plotting curve.   @param plotId Index of the plotting curve.  Must be 0=plotId6.   @param graphType Charting type to use for the curve.   @note Instead of calling this method, you can directly assign to #plotType. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGraphType(int plotId, TypeGuiGraphType graphType)
        {
            m_ts.fnGuiGraphCtrl_setGraphType(_ID, plotId, (int) graphType);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public GuiGraphCtrl_Base()
        {
            plotColor = new arrayObject<ColorF>(6, "plotColor", "TypeVariable", false, this);
            plotInterval = new arrayObject<int>(6, "plotInterval", "TypeVariable", false, this);
            plotType = new arrayObject<int>(6, "plotType", "TypeVariable", false, this);
            plotVariable = new arrayObject<String>(6, "plotVariable", "TypeVariable", false, this);
        }
    }
}