


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
    [TypeConverter(typeof(TypeConverterGeneric<ForestBrushTool_Base>))]
    public partial class ForestBrushTool_Base: ForestTool
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ForestBrushTool_Base ts, string simobjectid)
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
        public static bool operator !=(ForestBrushTool_Base ts, string simobjectid)
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
        public static implicit operator string( ForestBrushTool_Base ts)
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
        public static implicit operator ForestBrushTool_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ForestBrushTool_Base) Omni.self.getSimObject(simobjectid,typeof(ForestBrushTool_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ForestBrushTool_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestBrushTool_Base(int simobjectid)
            {
            return  (ForestBrushTool) Omni.self.getSimObject((uint)simobjectid,typeof(ForestBrushTool_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ForestBrushTool_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestBrushTool_Base(uint simobjectid)
            {
            return  (ForestBrushTool_Base) Omni.self.getSimObject(simobjectid,typeof(ForestBrushTool_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Brush Hardness 
/// </summary>
[MemberGroup("ForestBrushTool")]
public float hardness
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hardness").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hardness", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("ForestBrushTool")]
public TypeForestBrushMode mode
       {
       get
          {          return (TypeForestBrushMode) Omni.self.GetVar(_ID + ".mode");
          }
       set
          {
          Omni.self.SetVar(_ID + ".mode", value.ToString());
          }
       }
/// <summary>
/// Brush Pressure 
/// </summary>
[MemberGroup("ForestBrushTool")]
public float pressure
       {
       get
          {
          return Omni.self.GetVar(_ID + ".pressure").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".pressure", value.AsString());
          }
       }
/// <summary>
/// Brush Size 
/// </summary>
[MemberGroup("ForestBrushTool")]
public float size
       {
       get
          {
          return Omni.self.GetVar(_ID + ".size").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".size", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void collectElements(){

pInvokes.m_ts.fn_ForestBrushTool_collectElements(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseDown(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onActivated(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDeactivated(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void syncBrushToolbar(){}

#endregion
public ForestBrushTool_Base (){}
}}
