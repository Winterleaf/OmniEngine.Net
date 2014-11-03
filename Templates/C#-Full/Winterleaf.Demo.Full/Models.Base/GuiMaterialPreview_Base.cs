


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiMaterialPreview_Base>))]
    public partial class GuiMaterialPreview_Base: GuiTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiMaterialPreview_Base ts, string simobjectid)
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
        public static bool operator !=(GuiMaterialPreview_Base ts, string simobjectid)
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
        public static implicit operator string( GuiMaterialPreview_Base ts)
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
        public static implicit operator GuiMaterialPreview_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiMaterialPreview_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMaterialPreview_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiMaterialPreview_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiMaterialPreview_Base(int simobjectid)
            {
            return  (GuiMaterialPreview) Omni.self.getSimObject((uint)simobjectid,typeof(GuiMaterialPreview_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiMaterialPreview_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiMaterialPreview_Base(uint simobjectid)
            {
            return  (GuiMaterialPreview_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMaterialPreview_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Deletes the preview model.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteModel(){

pInvokes.m_ts.fnGuiMaterialPreview_deleteModel(_ID);
}
/// <summary>
/// Resets the viewport to default zoom, pan, rotate and lighting.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reset(){

pInvokes.m_ts.fnGuiMaterialPreview_reset(_ID);
}
/// <summary>
/// Sets the color of the ambient light in the scene.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAmbientLightColor(ColorF color){

pInvokes.m_ts.fnGuiMaterialPreview_setAmbientLightColor(_ID, color.AsString());
}
/// <summary>
/// Sets the color of the light in the scene.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setLightColor(ColorF color){

pInvokes.m_ts.fnGuiMaterialPreview_setLightColor(_ID, color.AsString());
}
/// <summary>
/// Sets the model to be displayed in this control
///    @param shapeName Name of the model to display.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setModel(string shapeName){

pInvokes.m_ts.fnGuiMaterialPreview_setModel(_ID, shapeName);
}
/// <summary>
/// Sets the distance at which the camera orbits the object. Clamped to the 
///    acceptable range defined in the class by min and max orbit distances.
///    @param distance The distance to set the orbit to (will be clamped).)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setOrbitDistance(float distance){

pInvokes.m_ts.fnGuiMaterialPreview_setOrbitDistance(_ID, distance);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseEnter(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseLeave(){}

#endregion
public GuiMaterialPreview_Base (){}
}}
