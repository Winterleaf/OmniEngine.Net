


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
    [TypeConverter(typeof(TypeConverterGeneric<MenuBar_Base>))]
    public partial class MenuBar_Base: SimSet
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MenuBar_Base ts, string simobjectid)
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
        public static bool operator !=(MenuBar_Base ts, string simobjectid)
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
        public static implicit operator string( MenuBar_Base ts)
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
        public static implicit operator MenuBar_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (MenuBar_Base) Omni.self.getSimObject(simobjectid,typeof(MenuBar_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( MenuBar_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MenuBar_Base(int simobjectid)
            {
            return  (MenuBar) Omni.self.getSimObject((uint)simobjectid,typeof(MenuBar_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( MenuBar_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MenuBar_Base(uint simobjectid)
            {
            return  (MenuBar_Base) Omni.self.getSimObject(simobjectid,typeof(MenuBar_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// (GuiCanvas, pos))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void attachToCanvas(string canvas, int pos){

pInvokes.m_ts.fn_MenuBar_attachToCanvas(_ID, canvas, pos);
}
/// <summary>
/// (object, pos) insert object at position)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void insert(string pObject, int pos){

pInvokes.m_ts.fn_MenuBar_insert(_ID, pObject, pos);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeFromCanvas(){

pInvokes.m_ts.fn_MenuBar_removeFromCanvas(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public MenuBar_Base (){}
}}
