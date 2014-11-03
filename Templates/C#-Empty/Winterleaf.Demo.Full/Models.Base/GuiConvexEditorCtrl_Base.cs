


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiConvexEditorCtrl_Base>))]
    public partial class GuiConvexEditorCtrl_Base: EditTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiConvexEditorCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiConvexEditorCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiConvexEditorCtrl_Base ts)
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
        public static implicit operator GuiConvexEditorCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiConvexEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiConvexEditorCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiConvexEditorCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiConvexEditorCtrl_Base(int simobjectid)
            {
            return  (GuiConvexEditorCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiConvexEditorCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiConvexEditorCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiConvexEditorCtrl_Base(uint simobjectid)
            {
            return  (GuiConvexEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiConvexEditorCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool isDirty
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isDirty").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isDirty", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String materialName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".materialName").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".materialName", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void dropSelectionAtScreenCenter(){

pInvokes.m_ts.fn_GuiConvexEditorCtrl_dropSelectionAtScreenCenter(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void handleDelete(){

pInvokes.m_ts.fn_GuiConvexEditorCtrl_handleDelete(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void handleDeselect(){

pInvokes.m_ts.fn_GuiConvexEditorCtrl_handleDeselect(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int hasSelection(){

return pInvokes.m_ts.fn_GuiConvexEditorCtrl_hasSelection(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void hollowSelection(){

pInvokes.m_ts.fn_GuiConvexEditorCtrl_hollowSelection(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void recenterSelection(){

pInvokes.m_ts.fn_GuiConvexEditorCtrl_recenterSelection(_ID);
}
/// <summary>
/// ( ConvexShape ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectConvex(string convex){

pInvokes.m_ts.fn_GuiConvexEditorCtrl_selectConvex(_ID, convex);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void splitSelectedFace(){

pInvokes.m_ts.fn_GuiConvexEditorCtrl_splitSelectedFace(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelectionChanged(string shape, string face){}

#endregion
public GuiConvexEditorCtrl_Base (){}
}}
