


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiDecalEditorCtrl_Base>))]
    public partial class GuiDecalEditorCtrl_Base: EditTSCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiDecalEditorCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiDecalEditorCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiDecalEditorCtrl_Base ts)
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
        public static implicit operator GuiDecalEditorCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiDecalEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDecalEditorCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiDecalEditorCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiDecalEditorCtrl_Base(int simobjectid)
            {
            return  (GuiDecalEditorCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiDecalEditorCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiDecalEditorCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiDecalEditorCtrl_Base(uint simobjectid)
            {
            return  (GuiDecalEditorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDecalEditorCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public DecalData currentDecalData
       {
       get
          {
          return Omni.self.GetVar(_ID + ".currentDecalData");
          }
       set
          {
          Omni.self.SetVar(_ID + ".currentDecalData", value.ToString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// deleteSelectedDecalDatablock( String datablock ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteDecalDatablock(string datablock){

pInvokes.m_ts.fn_GuiDecalEditorCtrl_deleteDecalDatablock(_ID, datablock);
}
/// <summary>
/// deleteSelectedDecal() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deleteSelectedDecal(){

pInvokes.m_ts.fn_GuiDecalEditorCtrl_deleteSelectedDecal(_ID);
}
/// <summary>
/// editDecalDetails( S32 )() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void editDecalDetails(uint id, Point3F pos, Point3F tan, float size){

pInvokes.m_ts.fn_GuiDecalEditorCtrl_editDecalDetails(_ID, id, pos.AsString(), tan.AsString(), size);
}
/// <summary>
/// getDecalCount() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getDecalCount(){

return pInvokes.m_ts.fn_GuiDecalEditorCtrl_getDecalCount(_ID);
}
/// <summary>
/// getDecalLookupName( S32 )() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getDecalLookupName(uint id){

return pInvokes.m_ts.fn_GuiDecalEditorCtrl_getDecalLookupName(_ID, id);
}
/// <summary>
/// getDecalTransform() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getDecalTransform(uint id){

return pInvokes.m_ts.fn_GuiDecalEditorCtrl_getDecalTransform(_ID, id);
}
/// <summary>
/// getMode() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMode(){

return pInvokes.m_ts.fn_GuiDecalEditorCtrl_getMode(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getSelectionCount(){

return pInvokes.m_ts.fn_GuiDecalEditorCtrl_getSelectionCount(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void retargetDecalDatablock(string dbFrom, string dbTo){

pInvokes.m_ts.fn_GuiDecalEditorCtrl_retargetDecalDatablock(_ID, dbFrom, dbTo);
}
/// <summary>
/// selectDecal( S32 )() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectDecal(uint id){

pInvokes.m_ts.fn_GuiDecalEditorCtrl_selectDecal(_ID, id);
}
/// <summary>
/// setMode( String mode )() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMode(string newMode){

pInvokes.m_ts.fn_GuiDecalEditorCtrl_setMode(_ID, newMode);
}

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void syncNodeDetails(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void rebuildInstanceTree(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void paletteSync(string mode){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void undoDeleteDecalDatablock(string datablock){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void redoDeleteDecalDatablock(string datablock){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void prepGizmoTransform(string decalId, string nodeDetails){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void completeGizmoTransform(string decalId, string nodeDetails){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSelectInstance(string decalId, string lookupName){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onCreateInstance(string decalId, string lookupName){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDeleteInstance(string decalId, string lookupName){}

#endregion
public GuiDecalEditorCtrl_Base (){}
}}
