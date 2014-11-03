


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiTerrPreviewCtrl_Base>))]
    public partial class GuiTerrPreviewCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTerrPreviewCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTerrPreviewCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiTerrPreviewCtrl_Base ts)
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
        public static implicit operator GuiTerrPreviewCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTerrPreviewCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTerrPreviewCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTerrPreviewCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTerrPreviewCtrl_Base(int simobjectid)
            {
            return  (GuiTerrPreviewCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTerrPreviewCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTerrPreviewCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTerrPreviewCtrl_Base(uint simobjectid)
            {
            return  (GuiTerrPreviewCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTerrPreviewCtrl_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Return a Point2F containing the position of the origin.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point2F getOrigin(){

return new Point2F ( pInvokes.m_ts.fn_GuiTerrPreviewCtrl_getOrigin(_ID));
}
/// <summary>
/// Return a Point2F representing the position of the root.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  Point2F getRoot(){

return new Point2F ( pInvokes.m_ts.fn_GuiTerrPreviewCtrl_getRoot(_ID));
}
/// <summary>
/// Returns a 4-tuple containing: root_x root_y origin_x origin_y)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  string getValue(){

return pInvokes.m_ts.fn_GuiTerrPreviewCtrl_getValue(_ID);
}
/// <summary>
/// Reset the view of the terrain.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reset(){

pInvokes.m_ts.fn_GuiTerrPreviewCtrl_reset(_ID);
}
/// <summary>
/// (float x, float y)
///               Set the origin of the view.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setOrigin(Point2F pos){

pInvokes.m_ts.fn_GuiTerrPreviewCtrl_setOrigin(_ID, pos.AsString());
}
/// <summary>
/// Add the origin to the root and reset the origin.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setRoot(){

pInvokes.m_ts.fn_GuiTerrPreviewCtrl_setRoot(_ID);
}
/// <summary>
/// Accepts a 4-tuple in the same form as getValue returns.
///               @see GuiTerrPreviewCtrl::getValue())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void setValue(string tuple){

pInvokes.m_ts.fn_GuiTerrPreviewCtrl_setValue(_ID, tuple);
}

#endregion
#region T3D Callbacks

#endregion
public GuiTerrPreviewCtrl_Base (){}
}}
