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
    [TypeConverter(typeof (TypeConverterGeneric<GuiParticleGraphCtrl_Base>))]
    public partial class GuiParticleGraphCtrl_Base : GuiControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiParticleGraphCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiParticleGraphCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiParticleGraphCtrl_Base ts)
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
        public static implicit operator GuiParticleGraphCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiParticleGraphCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiParticleGraphCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiParticleGraphCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiParticleGraphCtrl_Base(int simobjectid)
        {
            return (GuiParticleGraphCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiParticleGraphCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiParticleGraphCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiParticleGraphCtrl_Base(uint simobjectid)
        {
            return (GuiParticleGraphCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiParticleGraphCtrl_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// (int plotID, float x, float y, bool setAdded = true;)              Add a data point to the given plot.			  @return)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string addPlotPoint(int plotID, float x, float y, bool setAdded = true)
        {
            return m_ts.fn_GuiParticleGraphCtrl_addPlotPoint(_ID, plotID, x, y, setAdded);
        }

        /// <summary>
        /// (int plotID, int i, float x, float y)              Change a data point to the given plot and plot position.			  @param plotID The plot you want to access			  @param i The data point.			  @param x,y The plot position.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string changePlotPoint(int plotID, int i, float x, float y)
        {
            return m_ts.fn_GuiParticleGraphCtrl_changePlotPoint(_ID, plotID, i, x, y);
        }

        /// <summary>
        /// ()              Clear all of the graphs.			  @return No return value)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearAllGraphs()
        {
            m_ts.fn_GuiParticleGraphCtrl_clearAllGraphs(_ID);
        }

        /// <summary>
        /// (int plotID)              Clear the graph of the given plot.			  @return No return value)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearGraph(int plotID)
        {
            m_ts.fn_GuiParticleGraphCtrl_clearGraph(_ID, plotID);
        }

        /// <summary>
        /// (int plotID)              Get the color of the graph passed.			  @return Returns the color of the graph as a string of RGB values formatted as \"R G B\")
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getGraphColor(int plotID)
        {
            return m_ts.fn_GuiParticleGraphCtrl_getGraphColor(_ID, plotID);
        }

        /// <summary>
        /// (int plotID) 			  Get the maximum values of the graph ranges.			  @return Returns the maximum of the range formatted as \"x-max y-max\")
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getGraphMax(int plotID)
        {
            return m_ts.fn_GuiParticleGraphCtrl_getGraphMax(_ID, plotID);
        }

        /// <summary>
        /// (int plotID)               Get the minimum values of the graph ranges.			  @return Returns the minimum of the range formatted as \"x-min y-min\")
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getGraphMin(int plotID)
        {
            return m_ts.fn_GuiParticleGraphCtrl_getGraphMin(_ID, plotID);
        }

        /// <summary>
        /// (int plotID)               Get the name of the graph passed.			  @return Returns the name of the plot)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getGraphName(int plotID)
        {
            return m_ts.fn_GuiParticleGraphCtrl_getGraphName(_ID, plotID);
        }

        /// <summary>
        /// (int plotID, float x, float y)              Gets the index of the point passed on the plotID passed (graph ID).			  @param plotID The plot you wish to check.			  @param x,y The coordinates of the point to get.			  @return Returns the index of the point.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getPlotIndex(int plotID, float x, float y)
        {
            return m_ts.fn_GuiParticleGraphCtrl_getPlotIndex(_ID, plotID, x, y);
        }

        /// <summary>
        /// (int plotID, int samples)              Get a data point from the plot specified, samples from the start of the graph.			  @return The data point ID)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getPlotPoint(int plotID, int samples)
        {
            return m_ts.fn_GuiParticleGraphCtrl_getPlotPoint(_ID, plotID, samples);
        }

        /// <summary>
        /// ()               Gets the selected Plot (a.k.a. graph).			  @return The plot's ID.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getSelectedPlot()
        {
            return m_ts.fn_GuiParticleGraphCtrl_getSelectedPlot(_ID);
        }

        /// <summary>
        /// ()              Gets the selected Point on the Plot (a.k.a. graph).			  @return The last selected point ID)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getSelectedPoint()
        {
            return m_ts.fn_GuiParticleGraphCtrl_getSelectedPoint(_ID);
        }

        /// <summary>
        /// (int plotID, int i, float x, float y)              Insert a data point to the given plot and plot position.			  @param plotID The plot you want to access			  @param i The data point.			  @param x,y The plot position.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void insertPlotPoint(int plotID, int i, float x, float y)
        {
            m_ts.fn_GuiParticleGraphCtrl_insertPlotPoint(_ID, plotID, i, x, y);
        }

        /// <summary>
        /// (int plotID, int samples)              @return Returns true or false whether or not the point in the plot passed is an existing point.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string isExistingPoint(int plotID, int samples)
        {
            return m_ts.fn_GuiParticleGraphCtrl_isExistingPoint(_ID, plotID, samples);
        }

        /// <summary>
        /// ()			  This will reset the currently selected point to nothing.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void resetSelectedPoint()
        {
            m_ts.fn_GuiParticleGraphCtrl_resetSelectedPoint(_ID);
        }

        /// <summary>
        /// (bool autoMax) 			  Set whether the max will automatically be set when adding points 			  (ie if you add a value over the current max, the max is increased to that value).			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setAutoGraphMax(bool autoMax)
        {
            m_ts.fn_GuiParticleGraphCtrl_setAutoGraphMax(_ID, autoMax);
        }

        /// <summary>
        /// (bool autoRemove) 			  Set whether or not a point should be deleted when you drag another one over it.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setAutoRemove(bool autoRemove)
        {
            m_ts.fn_GuiParticleGraphCtrl_setAutoRemove(_ID, autoRemove);
        }

        /// <summary>
        /// (int plotID, bool isHidden)			  Set whether the graph number passed is hidden or not.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGraphHidden(int plotID, bool isHidden)
        {
            m_ts.fn_GuiParticleGraphCtrl_setGraphHidden(_ID, plotID, isHidden);
        }

        /// <summary>
        /// (int plotID, float maxX, float maxY) 			  Set the max values of the graph of plotID.			  @param plotID The plot to modify			  @param maxX,maxY The maximum bound of the value range.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGraphMax(int plotID, float maxX, float maxY)
        {
            m_ts.fn_GuiParticleGraphCtrl_setGraphMax(_ID, plotID, maxX, maxY);
        }

        /// <summary>
        /// (int plotID, float maxX)			  Set the max X value of the graph of plotID.			  @param plotID The plot to modify.			  @param maxX The maximum x value.			  @return No return Value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGraphMaxX(int plotID, float maxX)
        {
            m_ts.fn_GuiParticleGraphCtrl_setGraphMaxX(_ID, plotID, maxX);
        }

        /// <summary>
        /// (int plotID, float maxY)			  Set the max Y value of the graph of plotID.			  @param plotID The plot to modify.			  @param maxY The maximum y value.			  @return No return Value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGraphMaxY(int plotID, float maxX)
        {
            m_ts.fn_GuiParticleGraphCtrl_setGraphMaxY(_ID, plotID, maxX);
        }

        /// <summary>
        /// (int plotID, float minX, float minY) 			  Set the min values of the graph of plotID.			  @param plotID The plot to modify			  @param minX,minY The minimum bound of the value range.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGraphMin(int plotID, float minX, float minY)
        {
            m_ts.fn_GuiParticleGraphCtrl_setGraphMin(_ID, plotID, minX, minY);
        }

        /// <summary>
        /// (int plotID, float minX) 			  Set the min X value of the graph of plotID.			  @param plotID The plot to modify.			  @param minX The minimum x value.			  @return No return Value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGraphMinX(int plotID, float minX)
        {
            m_ts.fn_GuiParticleGraphCtrl_setGraphMinX(_ID, plotID, minX);
        }

        /// <summary>
        /// (int plotID, float minY) 			  Set the min Y value of the graph of plotID.			  @param plotID The plot to modify.			  @param minY The minimum y value.			  @return No return Value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGraphMinY(int plotID, float minX)
        {
            m_ts.fn_GuiParticleGraphCtrl_setGraphMinY(_ID, plotID, minX);
        }

        /// <summary>
        /// (int plotID, string graphName) 			  Set the name of the given plot.			  @param plotID The plot to modify.			  @param graphName The name to set on the plot.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGraphName(int plotID, string graphName)
        {
            m_ts.fn_GuiParticleGraphCtrl_setGraphName(_ID, plotID, graphName);
        }

        /// <summary>
        /// (bool clamped)			  Set whether the x position of the selected graph point should be clamped			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setPointXMovementClamped(bool autoRemove)
        {
            m_ts.fn_GuiParticleGraphCtrl_setPointXMovementClamped(_ID, autoRemove);
        }

        /// <summary>
        /// (bool renderAll)			  Set whether or not a position should be rendered on every point or just the last selected.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setRenderAll(bool autoRemove)
        {
            m_ts.fn_GuiParticleGraphCtrl_setRenderAll(_ID, autoRemove);
        }

        /// <summary>
        /// (bool renderGraphTooltip)			  Set whether or not to render the graph tooltip.			  @return No return value.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setRenderGraphTooltip(bool autoRemove)
        {
            m_ts.fn_GuiParticleGraphCtrl_setRenderGraphTooltip(_ID, autoRemove);
        }

        /// <summary>
        /// (int plotID)              Set the selected plot (a.k.a. graph).			  @return No return value )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelectedPlot(int plotID)
        {
            m_ts.fn_GuiParticleGraphCtrl_setSelectedPlot(_ID, plotID);
        }

        /// <summary>
        /// (int point)              Set the selected point on the graph.			  @return No return value)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelectedPoint(int point)
        {
            m_ts.fn_GuiParticleGraphCtrl_setSelectedPoint(_ID, point);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onSetSelected(string buffer)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseDragged(string buffer)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseMove(string buffer)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPlotPointSelected(string buffer)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPlotPointSelectedMouseDown(string buffer)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPlotPointInserted(string buffer1, string buffer2)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPlotPointRemoved(string buffer1, string buffer2, string buffer3)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPlotPointAdded(string buffer1, string buffer2, string buffer3)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPlotPointChangedMove(string buffer1, string buffer2, string buffer3)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPlotPointChangedUp(string buffer1, string buffer2, string buffer3, string buffer4)
        {
        }

        #endregion

        public GuiParticleGraphCtrl_Base()
        {
        }
    }
}