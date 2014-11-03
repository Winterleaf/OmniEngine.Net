


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
    [TypeConverter(typeof(TypeConverterGeneric<EditManager_Base>))]
    public partial class EditManager_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditManager_Base ts, string simobjectid)
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
        public static bool operator !=(EditManager_Base ts, string simobjectid)
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
        public static implicit operator string( EditManager_Base ts)
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
        public static implicit operator EditManager_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (EditManager_Base) Omni.self.getSimObject(simobjectid,typeof(EditManager_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( EditManager_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditManager_Base(int simobjectid)
            {
            return  (EditManager) Omni.self.getSimObject((uint)simobjectid,typeof(EditManager_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( EditManager_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditManager_Base(uint simobjectid)
            {
            return  (EditManager_Base) Omni.self.getSimObject(simobjectid,typeof(EditManager_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Perform the onEditorDisabled callback on all SimObjects and set gEditingMission false )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void editorDisabled(){

pInvokes.m_ts.fn_EditManager_editorDisabled(_ID);
}
/// <summary>
/// Perform the onEditorEnabled callback on all SimObjects and set gEditingMission true )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void editorEnabled(){

pInvokes.m_ts.fn_EditManager_editorEnabled(_ID);
}
/// <summary>
/// (int slot))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void gotoBookmark(int val){

pInvokes.m_ts.fn_EditManager_gotoBookmark(_ID, val);
}
/// <summary>
/// Return the value of gEditingMission. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isEditorEnabled(){

return pInvokes.m_ts.fn_EditManager_isEditorEnabled(_ID);
}
/// <summary>
/// (int slot))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBookmark(int val){

pInvokes.m_ts.fn_EditManager_setBookmark(_ID, val);
}

#endregion
#region T3D Callbacks

#endregion
public EditManager_Base (){}
}}
