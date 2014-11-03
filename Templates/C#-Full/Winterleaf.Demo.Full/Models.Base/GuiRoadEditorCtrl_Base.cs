


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiRoadEditorCtrl_Base>))]
    public partial class GuiRoadEditorCtrl_Base: EditTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiRoadEditorCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiRoadEditorCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiRoadEditorCtrl_Base ts)
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
        public static implicit operator GuiRoadEditorCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiRoadEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiRoadEditorCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiRoadEditorCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiRoadEditorCtrl_Base(int simobjectid)
            {
            return  (GuiRoadEditorCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiRoadEditorCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiRoadEditorCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiRoadEditorCtrl_Base(uint simobjectid)
            {
            return  (GuiRoadEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiRoadEditorCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public float DefaultWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".DefaultWidth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".DefaultWidth", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public ColorI HoverNodeColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".HoverNodeColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".HoverNodeColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public ColorI HoverSplineColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".HoverSplineColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".HoverSplineColor", value.AsString());
          }
       }
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
/// Default Material used by the Road Editor on road creation. 
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
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public ColorI SelectedSplineColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".SelectedSplineColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".SelectedSplineColor", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// deleteNode() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteNode(){

pInvokes.m_ts.fn_GuiRoadEditorCtrl_deleteNode(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteRoad(){

pInvokes.m_ts.fn_GuiRoadEditorCtrl_deleteRoad(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMode(){

return pInvokes.m_ts.fn_GuiRoadEditorCtrl_getMode(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getNodePosition(){

return new Point3F ( pInvokes.m_ts.fn_GuiRoadEditorCtrl_getNodePosition(_ID));
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getNodeWidth(){

return pInvokes.m_ts.fn_GuiRoadEditorCtrl_getNodeWidth(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedNode(){

return pInvokes.m_ts.fn_GuiRoadEditorCtrl_getSelectedNode(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedRoad(){

return pInvokes.m_ts.fn_GuiRoadEditorCtrl_getSelectedRoad(_ID);
}
/// <summary>
/// setMode( String mode ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMode(string mode){

pInvokes.m_ts.fn_GuiRoadEditorCtrl_setMode(_ID, mode);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNodePosition(Point3F pos){

pInvokes.m_ts.fn_GuiRoadEditorCtrl_setNodePosition(_ID, pos.AsString());
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNodeWidth(float width){

pInvokes.m_ts.fn_GuiRoadEditorCtrl_setNodeWidth(_ID, width);
}
/// <summary>
/// ),  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelectedRoad(string pathRoad = ""){

pInvokes.m_ts.fn_GuiRoadEditorCtrl_setSelectedRoad(_ID, pathRoad);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onNodeModified(string nodeIdx){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onNodeSelected(string nodeIdx, string nodeWidth){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void paletteSync(string mode){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRoadCreation(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRoadSelected(string road){}

#endregion
public GuiRoadEditorCtrl_Base (){}
}}
