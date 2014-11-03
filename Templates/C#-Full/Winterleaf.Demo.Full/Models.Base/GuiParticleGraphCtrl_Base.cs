


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiParticleGraphCtrl_Base>))]
    public partial class GuiParticleGraphCtrl_Base: GuiControl
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
        public static bool operator !=(GuiParticleGraphCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiParticleGraphCtrl_Base ts)
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
        public static implicit operator GuiParticleGraphCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiParticleGraphCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiParticleGraphCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiParticleGraphCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiParticleGraphCtrl_Base(int simobjectid)
            {
            return  (GuiParticleGraphCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiParticleGraphCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiParticleGraphCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiParticleGraphCtrl_Base(uint simobjectid)
            {
            return  (GuiParticleGraphCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiParticleGraphCtrl_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// (int plotID, float x, float y, bool setAdded = true;)
///               Add a data point to the given plot.
/// 			  @return)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string addPlotPoint(int plotID, float x, float y, bool setAdded = true){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_addPlotPoint(_ID, plotID, x, y, setAdded);
}
/// <summary>
/// (int plotID, int i, float x, float y)
///               Change a data point to the given plot and plot position.
/// 			  @param plotID The plot you want to access
/// 			  @param i The data point.
/// 			  @param x,y The plot position.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string changePlotPoint(int plotID, int i, float x, float y){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_changePlotPoint(_ID, plotID, i, x, y);
}
/// <summary>
/// ()
///               Clear all of the graphs.
/// 			  @return No return value)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearAllGraphs(){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_clearAllGraphs(_ID);
}
/// <summary>
/// (int plotID)
///               Clear the graph of the given plot.
/// 			  @return No return value)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearGraph(int plotID){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_clearGraph(_ID, plotID);
}
/// <summary>
/// (int plotID)
///               Get the color of the graph passed.
/// 			  @return Returns the color of the graph as a string of RGB values formatted as \"R G B\")
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getGraphColor(int plotID){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_getGraphColor(_ID, plotID);
}
/// <summary>
/// (int plotID) 
/// 			  Get the maximum values of the graph ranges.
/// 			  @return Returns the maximum of the range formatted as \"x-max y-max\")
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getGraphMax(int plotID){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_getGraphMax(_ID, plotID);
}
/// <summary>
/// (int plotID) 
///               Get the minimum values of the graph ranges.
/// 			  @return Returns the minimum of the range formatted as \"x-min y-min\")
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getGraphMin(int plotID){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_getGraphMin(_ID, plotID);
}
/// <summary>
/// (int plotID) 
///               Get the name of the graph passed.
/// 			  @return Returns the name of the plot)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getGraphName(int plotID){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_getGraphName(_ID, plotID);
}
/// <summary>
/// (int plotID, float x, float y)
///               Gets the index of the point passed on the plotID passed (graph ID).
/// 			  @param plotID The plot you wish to check.
/// 			  @param x,y The coordinates of the point to get.
/// 			  @return Returns the index of the point.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getPlotIndex(int plotID, float x, float y){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_getPlotIndex(_ID, plotID, x, y);
}
/// <summary>
/// (int plotID, int samples)
///               Get a data point from the plot specified, samples from the start of the graph.
/// 			  @return The data point ID)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getPlotPoint(int plotID, int samples){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_getPlotPoint(_ID, plotID, samples);
}
/// <summary>
/// () 
///               Gets the selected Plot (a.k.a. graph).
/// 			  @return The plot's ID.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSelectedPlot(){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_getSelectedPlot(_ID);
}
/// <summary>
/// ()
///               Gets the selected Point on the Plot (a.k.a. graph).
/// 			  @return The last selected point ID)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSelectedPoint(){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_getSelectedPoint(_ID);
}
/// <summary>
/// (int plotID, int i, float x, float y)
///               Insert a data point to the given plot and plot position.
/// 			  @param plotID The plot you want to access
/// 			  @param i The data point.
/// 			  @param x,y The plot position.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void insertPlotPoint(int plotID, int i, float x, float y){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_insertPlotPoint(_ID, plotID, i, x, y);
}
/// <summary>
/// (int plotID, int samples)
///               @return Returns true or false whether or not the point in the plot passed is an existing point.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string isExistingPoint(int plotID, int samples){

return pInvokes.m_ts.fn_GuiParticleGraphCtrl_isExistingPoint(_ID, plotID, samples);
}
/// <summary>
/// ()
/// 			  This will reset the currently selected point to nothing.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void resetSelectedPoint(){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_resetSelectedPoint(_ID);
}
/// <summary>
/// (bool autoMax) 
/// 			  Set whether the max will automatically be set when adding points 
/// 			  (ie if you add a value over the current max, the max is increased to that value).
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAutoGraphMax(bool autoMax){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setAutoGraphMax(_ID, autoMax);
}
/// <summary>
/// (bool autoRemove) 
/// 			  Set whether or not a point should be deleted when you drag another one over it.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAutoRemove(bool autoRemove){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setAutoRemove(_ID, autoRemove);
}
/// <summary>
/// (int plotID, bool isHidden)
/// 			  Set whether the graph number passed is hidden or not.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGraphHidden(int plotID, bool isHidden){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setGraphHidden(_ID, plotID, isHidden);
}
/// <summary>
/// (int plotID, float maxX, float maxY) 
/// 			  Set the max values of the graph of plotID.
/// 			  @param plotID The plot to modify
/// 			  @param maxX,maxY The maximum bound of the value range.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGraphMax(int plotID, float maxX, float maxY){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setGraphMax(_ID, plotID, maxX, maxY);
}
/// <summary>
/// (int plotID, float maxX)
/// 			  Set the max X value of the graph of plotID.
/// 			  @param plotID The plot to modify.
/// 			  @param maxX The maximum x value.
/// 			  @return No return Value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGraphMaxX(int plotID, float maxX){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setGraphMaxX(_ID, plotID, maxX);
}
/// <summary>
/// (int plotID, float maxY)
/// 			  Set the max Y value of the graph of plotID.
/// 			  @param plotID The plot to modify.
/// 			  @param maxY The maximum y value.
/// 			  @return No return Value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGraphMaxY(int plotID, float maxX){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setGraphMaxY(_ID, plotID, maxX);
}
/// <summary>
/// (int plotID, float minX, float minY) 
/// 			  Set the min values of the graph of plotID.
/// 			  @param plotID The plot to modify
/// 			  @param minX,minY The minimum bound of the value range.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGraphMin(int plotID, float minX, float minY){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setGraphMin(_ID, plotID, minX, minY);
}
/// <summary>
/// (int plotID, float minX) 
/// 			  Set the min X value of the graph of plotID.
/// 			  @param plotID The plot to modify.
/// 			  @param minX The minimum x value.
/// 			  @return No return Value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGraphMinX(int plotID, float minX){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setGraphMinX(_ID, plotID, minX);
}
/// <summary>
/// (int plotID, float minY) 
/// 			  Set the min Y value of the graph of plotID.
/// 			  @param plotID The plot to modify.
/// 			  @param minY The minimum y value.
/// 			  @return No return Value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGraphMinY(int plotID, float minX){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setGraphMinY(_ID, plotID, minX);
}
/// <summary>
/// (int plotID, string graphName) 
/// 			  Set the name of the given plot.
/// 			  @param plotID The plot to modify.
/// 			  @param graphName The name to set on the plot.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGraphName(int plotID, string graphName){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setGraphName(_ID, plotID, graphName);
}
/// <summary>
/// (bool clamped)
/// 			  Set whether the x position of the selected graph point should be clamped
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPointXMovementClamped(bool autoRemove){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setPointXMovementClamped(_ID, autoRemove);
}
/// <summary>
/// (bool renderAll)
/// 			  Set whether or not a position should be rendered on every point or just the last selected.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRenderAll(bool autoRemove){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setRenderAll(_ID, autoRemove);
}
/// <summary>
/// (bool renderGraphTooltip)
/// 			  Set whether or not to render the graph tooltip.
/// 			  @return No return value.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRenderGraphTooltip(bool autoRemove){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setRenderGraphTooltip(_ID, autoRemove);
}
/// <summary>
/// (int plotID)
///               Set the selected plot (a.k.a. graph).
/// 			  @return No return value )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelectedPlot(int plotID){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setSelectedPlot(_ID, plotID);
}
/// <summary>
/// (int point)
///               Set the selected point on the graph.
/// 			  @return No return value)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelectedPoint(int point){

pInvokes.m_ts.fn_GuiParticleGraphCtrl_setSelectedPoint(_ID, point);
}

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSetSelected(string buffer){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseDragged(string buffer){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseMove(string buffer){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPlotPointSelected(string buffer){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPlotPointSelectedMouseDown(string buffer){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPlotPointInserted(string buffer1, string buffer2){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPlotPointRemoved(string buffer1, string buffer2, string buffer3){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPlotPointAdded(string buffer1, string buffer2, string buffer3){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPlotPointChangedMove(string buffer1, string buffer2, string buffer3){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPlotPointChangedUp(string buffer1, string buffer2, string buffer3, string buffer4){}

#endregion
public GuiParticleGraphCtrl_Base (){}
}}
