


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiGraphCtrl_Base>))]
    public partial class GuiGraphCtrl_Base: GuiControl
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
        public static bool operator !=(GuiGraphCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiGraphCtrl_Base ts)
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
        public static implicit operator GuiGraphCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiGraphCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGraphCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiGraphCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiGraphCtrl_Base(int simobjectid)
            {
            return  (GuiGraphCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiGraphCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiGraphCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiGraphCtrl_Base(uint simobjectid)
            {
            return  (GuiGraphCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiGraphCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Ratio of where to place the center coordinate of the graph on the Y axis. 0.5=middle height of control.\n\n     This allows to account for graphs that have only positive or only negative data points, for example. 
/// </summary>
[MemberGroup("Graph")]
public float centerY
       {
       get
          {
          return Omni.self.GetVar(_ID + ".centerY").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".centerY", value.AsString());
          }
       }
[MemberGroup("Graph")]
public arrayObject<ColorF> plotColor;
[MemberGroup("Graph")]
public arrayObject<int> plotInterval;
[MemberGroup("Graph")]
public arrayObject<int> plotType;
[MemberGroup("Graph")]
public arrayObject<String> plotVariable;

#endregion
#region Member Functions
/// <summary>
/// Sets up the given plotting curve to automatically plot the value of the @a variable with a 
///    frequency of @a updateFrequency.
///    @param plotId Index of the plotting curve.  Must be 0=plotId6.
///    @param variable Name of the global variable.
///    @param updateFrequency Frequency with which to add new data points to the plotting curve (in milliseconds).
///    @tsexample
///    // Plot FPS counter at 1 second intervals.
///    %graph.addAutoPlot( 0, \"fps::real\", 1000 );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addAutoPlot(int plotId, string variable, int updateFrequency){

pInvokes.m_ts.fnGuiGraphCtrl_addAutoPlot(_ID, plotId, variable, updateFrequency);
}
/// <summary>
/// Add a data point to the plot's curve.
///    @param plotId Index of the plotting curve to which to add the data point.  Must be 0=plotId6.
///    @param value Value of the data point to add to the curve.
///    @note Data values are added to the @b left end of the plotting curve.
///    @note A maximum number of 200 data points can be added to any single plotting curve at any one time.  If 
///       this limit is exceeded, data points on the right end of the curve are culled. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addDatum(int plotId, float value){

pInvokes.m_ts.fnGuiGraphCtrl_addDatum(_ID, plotId, value);
}
/// <summary>
/// Get a data point on the given plotting curve.
///    @param plotId Index of the plotting curve from which to fetch the data point.  Must be 0=plotId6.
///    @param index Index of the data point on the curve.
///    @return The value of the data point or -1 if @a plotId or @a index are out of range. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getDatum(int plotId, int index){

return pInvokes.m_ts.fnGuiGraphCtrl_getDatum(_ID, plotId, index);
}
/// <summary>
/// Stop automatic variable plotting for the given curve.
///    @param plotId Index of the plotting curve.  Must be 0=plotId6. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeAutoPlot(int plotId){

pInvokes.m_ts.fnGuiGraphCtrl_removeAutoPlot(_ID, plotId);
}
/// <summary>
/// Change the charting type of the given plotting curve.
///    @param plotId Index of the plotting curve.  Must be 0=plotId6.
///    @param graphType Charting type to use for the curve.
///    @note Instead of calling this method, you can directly assign to #plotType. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGraphType(int plotId, TypeGuiGraphType graphType){

pInvokes.m_ts.fnGuiGraphCtrl_setGraphType(_ID, plotId, (int)graphType );
}

#endregion
#region T3D Callbacks

#endregion
public GuiGraphCtrl_Base (){plotColor = new arrayObject<ColorF>(6,"plotColor","TypeVariable",false,this);    
plotInterval = new arrayObject<int>(6,"plotInterval","TypeVariable",false,this);    
plotType = new arrayObject<int>(6,"plotType","TypeVariable",false,this);    
plotVariable = new arrayObject<String>(6,"plotVariable","TypeVariable",false,this);    
}
}}
