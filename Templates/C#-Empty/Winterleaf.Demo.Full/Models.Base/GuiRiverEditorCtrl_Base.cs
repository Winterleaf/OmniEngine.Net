


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiRiverEditorCtrl_Base>))]
    public partial class GuiRiverEditorCtrl_Base: EditTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiRiverEditorCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiRiverEditorCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiRiverEditorCtrl_Base ts)
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
        public static implicit operator GuiRiverEditorCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiRiverEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiRiverEditorCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiRiverEditorCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiRiverEditorCtrl_Base(int simobjectid)
            {
            return  (GuiRiverEditorCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiRiverEditorCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiRiverEditorCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiRiverEditorCtrl_Base(uint simobjectid)
            {
            return  (GuiRiverEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiRiverEditorCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public float DefaultDepth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".DefaultDepth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".DefaultDepth", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public Point3F DefaultNormal
       {
       get
          {
          return Omni.self.GetVar(_ID + ".DefaultNormal").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".DefaultNormal", value.AsString());
          }
       }
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

pInvokes.m_ts.fn_GuiRiverEditorCtrl_deleteNode(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMode(){

return pInvokes.m_ts.fn_GuiRiverEditorCtrl_getMode(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getNodeDepth(){

return pInvokes.m_ts.fn_GuiRiverEditorCtrl_getNodeDepth(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getNodeNormal(){

return new Point3F ( pInvokes.m_ts.fn_GuiRiverEditorCtrl_getNodeNormal(_ID));
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getNodePosition(){

return new Point3F ( pInvokes.m_ts.fn_GuiRiverEditorCtrl_getNodePosition(_ID));
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getNodeWidth(){

return pInvokes.m_ts.fn_GuiRiverEditorCtrl_getNodeWidth(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectedRiver(){

return pInvokes.m_ts.fn_GuiRiverEditorCtrl_getSelectedRiver(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void regenerate(){

pInvokes.m_ts.fn_GuiRiverEditorCtrl_regenerate(_ID);
}
/// <summary>
/// setMode( String mode ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMode(string mode){

pInvokes.m_ts.fn_GuiRiverEditorCtrl_setMode(_ID, mode);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNodeDepth(float depth){

pInvokes.m_ts.fn_GuiRiverEditorCtrl_setNodeDepth(_ID, depth);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNodeNormal(Point3F normal){

pInvokes.m_ts.fn_GuiRiverEditorCtrl_setNodeNormal(_ID, normal.AsString());
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNodePosition(Point3F pos){

pInvokes.m_ts.fn_GuiRiverEditorCtrl_setNodePosition(_ID, pos.AsString());
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNodeWidth(float width){

pInvokes.m_ts.fn_GuiRiverEditorCtrl_setNodeWidth(_ID, width);
}
/// <summary>
/// ),  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setSelectedRiver(string objName = ""){

pInvokes.m_ts.fn_GuiRiverEditorCtrl_setSelectedRiver(_ID, objName);
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
public virtual  void onNodeSelected(string nodeIdx){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void paletteSync(string mode){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRiverSelected(string road){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  string createRiver(){return "0".AsString();}

#endregion
public GuiRiverEditorCtrl_Base (){}
}}
