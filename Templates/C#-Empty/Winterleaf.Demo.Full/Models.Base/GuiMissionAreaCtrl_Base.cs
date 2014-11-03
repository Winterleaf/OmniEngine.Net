


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiMissionAreaCtrl_Base>))]
    public partial class GuiMissionAreaCtrl_Base: GuiBitmapCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiMissionAreaCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiMissionAreaCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiMissionAreaCtrl_Base ts)
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
        public static implicit operator GuiMissionAreaCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiMissionAreaCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMissionAreaCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiMissionAreaCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiMissionAreaCtrl_Base(int simobjectid)
            {
            return  (GuiMissionAreaCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiMissionAreaCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiMissionAreaCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiMissionAreaCtrl_Base(uint simobjectid)
            {
            return  (GuiMissionAreaCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMissionAreaCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public ColorI cameraColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cameraColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cameraColor", value.AsString());
          }
       }
/// <summary>
/// Bitmap file for the mission area handles.\n
/// </summary>
[MemberGroup("")]
public String handleBitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".handleBitmap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".handleBitmap", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public ColorI missionBoundsColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".missionBoundsColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".missionBoundsColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool squareBitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".squareBitmap").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".squareBitmap", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Set the MissionArea to edit.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMissionArea(string area){

pInvokes.m_ts.fnGuiMissionAreaCtrl_setMissionArea(_ID, area);
}
/// <summary>
/// @brief Update the terrain bitmap.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void updateTerrain(){

pInvokes.m_ts.fnGuiMissionAreaCtrl_updateTerrain(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMissionAreaModified(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onUndo(){}

#endregion
public GuiMissionAreaCtrl_Base (){}
}}
