


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiFilterCtrl_Base>))]
    public partial class GuiFilterCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiFilterCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiFilterCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiFilterCtrl_Base ts)
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
        public static implicit operator GuiFilterCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiFilterCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFilterCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiFilterCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiFilterCtrl_Base(int simobjectid)
            {
            return  (GuiFilterCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiFilterCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiFilterCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiFilterCtrl_Base(uint simobjectid)
            {
            return  (GuiFilterCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiFilterCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Total number of control points in the spline curve. 
/// </summary>
[MemberGroup("")]
public int controlPoints
       {
       get
          {
          return Omni.self.GetVar(_ID + ".controlPoints").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".controlPoints", value.AsString());
          }
       }
/// <summary>
/// Vector of control points. 
/// </summary>
[MemberGroup("")]
public VectorFloat filter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".filter").AsVectorFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".filter", value.AsString());
          }
       }
/// <summary>
/// @internal
/// </summary>
[MemberGroup("")]
public Point2F identity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".identity").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".identity", value.AsString());
          }
       }
/// <summary>
/// @internal 
/// </summary>
[MemberGroup("")]
public bool showIdentity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showIdentity").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showIdentity", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Return a tuple containing all the values in the filter.
/// 			  @internal)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  string getValue(){

return pInvokes.m_ts.fn_GuiFilterCtrl_getValue(_ID);
}
/// <summary>
/// Reset the filtering.
/// 			  @internal)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void identityX(){

pInvokes.m_ts.fn_GuiFilterCtrl_identity(_ID);
}
/// <summary>
/// ( GuiFilterCtrl, setValue, void, 3, 20, (f1, f2, ...)
///               Reset the filter to use the specified points, spread equidistantly across the domain.
/// 			  @internal)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setValue(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){

pInvokes.m_ts.fnGuiFilterCtrl_setValue(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}

#endregion
#region T3D Callbacks

#endregion
public GuiFilterCtrl_Base (){}
}}
