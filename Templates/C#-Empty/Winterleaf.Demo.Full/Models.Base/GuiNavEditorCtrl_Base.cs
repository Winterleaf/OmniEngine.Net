


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiNavEditorCtrl_Base>))]
    public partial class GuiNavEditorCtrl_Base: EditTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiNavEditorCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiNavEditorCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiNavEditorCtrl_Base ts)
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
        public static implicit operator GuiNavEditorCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiNavEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiNavEditorCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiNavEditorCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiNavEditorCtrl_Base(int simobjectid)
            {
            return  (GuiNavEditorCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiNavEditorCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiNavEditorCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiNavEditorCtrl_Base(uint simobjectid)
            {
            return  (GuiNavEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiNavEditorCtrl_Base));
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
/// Class of object to spawn in test mode.
/// </summary>
[MemberGroup("")]
public String spawnClass
       {
       get
          {
          return Omni.self.GetVar(_ID + ".spawnClass").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".spawnClass", value.AsString());
          }
       }
/// <summary>
/// Datablock to give new objects in test mode.
/// </summary>
[MemberGroup("")]
public String spawnDatablock
       {
       get
          {
          return Omni.self.GetVar(_ID + ".spawnDatablock").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".spawnDatablock", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMode(){

return pInvokes.m_ts.fn_GuiNavEditorCtrl_getMode(_ID);
}
/// <summary>
/// setMode(String mode))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMode(string newMode){

pInvokes.m_ts.fn_GuiNavEditorCtrl_setMode(_ID, newMode);
}
/// <summary>
/// @brief Build the currently selected tile.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void buildTile(){

pInvokes.m_ts.fnGuiNavEditorCtrl_buildTile(_ID);
}
/// <summary>
/// @brief Delete the currently selected link.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteLink(){

pInvokes.m_ts.fnGuiNavEditorCtrl_deleteLink(_ID);
}
/// <summary>
/// @brief Deselect whatever is currently selected in the editor.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deselect(){

pInvokes.m_ts.fnGuiNavEditorCtrl_deselect(_ID);
}
/// <summary>
/// @brief Select a NavMesh object.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getMesh(){

return pInvokes.m_ts.fnGuiNavEditorCtrl_getMesh(_ID);
}
/// <summary>
/// @brief Select a NavMesh object.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getPlayer(){

return pInvokes.m_ts.fnGuiNavEditorCtrl_getPlayer(_ID);
}
/// <summary>
/// @brief Select a NavMesh object.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectMesh(int id){

pInvokes.m_ts.fnGuiNavEditorCtrl_selectMesh(_ID, id);
}
/// <summary>
/// @Brief Set jump and drop properties of the selected link.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setLinkFlags(uint flags){

pInvokes.m_ts.fnGuiNavEditorCtrl_setLinkFlags(_ID, flags);
}
/// <summary>
/// @brief Spawn an AIPlayer at the centre of the screen.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void spawnPlayer(){

pInvokes.m_ts.fnGuiNavEditorCtrl_spawnPlayer(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLinkDeselected(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPlayerDeselected(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPlayerSelected(int linkDataFlags){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLinkSelected(int linkDataFlags){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onModeSet(string mode){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void paletteSync(string mode){}

#endregion
public GuiNavEditorCtrl_Base (){}
}}
