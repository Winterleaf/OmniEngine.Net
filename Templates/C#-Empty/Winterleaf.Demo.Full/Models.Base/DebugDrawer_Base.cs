


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
    [TypeConverter(typeof(TypeConverterGeneric<DebugDrawer_Base>))]
    public partial class DebugDrawer_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DebugDrawer_Base ts, string simobjectid)
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
        public static bool operator !=(DebugDrawer_Base ts, string simobjectid)
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
        public static implicit operator string( DebugDrawer_Base ts)
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
        public static implicit operator DebugDrawer_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (DebugDrawer_Base) Omni.self.getSimObject(simobjectid,typeof(DebugDrawer_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( DebugDrawer_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DebugDrawer_Base(int simobjectid)
            {
            return  (DebugDrawer) Omni.self.getSimObject((uint)simobjectid,typeof(DebugDrawer_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( DebugDrawer_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DebugDrawer_Base(uint simobjectid)
            {
            return  (DebugDrawer_Base) Omni.self.getSimObject(simobjectid,typeof(DebugDrawer_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Draws an axis aligned box primitive within the two 3d points. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void drawBox(Point3F a, Point3F b, ColorF color = null ){
if (color== null) {color = new ColorF(1.0f, 1.0f, 1.0f,1.0f);}

pInvokes.m_ts.fnDebugDrawer_drawBox(_ID, a.AsString(), b.AsString(), color.AsString());
}
/// <summary>
/// Draws a line primitive between two 3d points. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void drawLine(Point3F a, Point3F b, ColorF color = null ){
if (color== null) {color = new ColorF(1.0f, 1.0f, 1.0f,1.0f);}

pInvokes.m_ts.fnDebugDrawer_drawLine(_ID, a.AsString(), b.AsString(), color.AsString());
}
/// <summary>
/// Sets the \"time to live\" (TTL) for the last rendered primitive. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setLastTTL(uint ms){

pInvokes.m_ts.fnDebugDrawer_setLastTTL(_ID, ms);
}
/// <summary>
/// Sets the z buffer reading state for the last rendered primitive. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setLastZTest(bool enabled){

pInvokes.m_ts.fnDebugDrawer_setLastZTest(_ID, enabled);
}
/// <summary>
/// Toggles the rendering of DebugDrawer primitives. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggleDrawing(){

pInvokes.m_ts.fnDebugDrawer_toggleDrawing(_ID);
}
/// <summary>
/// Toggles freeze mode which keeps the currently rendered primitives from expiring. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggleFreeze(){

pInvokes.m_ts.fnDebugDrawer_toggleFreeze(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public DebugDrawer_Base (){}
}}
