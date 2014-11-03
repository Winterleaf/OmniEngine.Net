


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiInspector_Base>))]
    public partial class GuiInspector_Base: GuiStackControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiInspector_Base ts, string simobjectid)
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
        public static bool operator !=(GuiInspector_Base ts, string simobjectid)
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
        public static implicit operator string( GuiInspector_Base ts)
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
        public static implicit operator GuiInspector_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiInspector_Base) Omni.self.getSimObject(simobjectid,typeof(GuiInspector_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiInspector_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiInspector_Base(int simobjectid)
            {
            return  (GuiInspector) Omni.self.getSimObject((uint)simobjectid,typeof(GuiInspector_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiInspector_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiInspector_Base(uint simobjectid)
            {
            return  (GuiInspector_Base) Omni.self.getSimObject(simobjectid,typeof(GuiInspector_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ( id object, (bool autoSync = true) ) - Add the object to the list of objects being inspected. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addInspect(string className, bool autoSync = true){

pInvokes.m_ts.fn_GuiInspector_addInspect(_ID, className, autoSync);
}
/// <summary>
/// apply() - Force application of inspected object's attributes )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void apply(){

pInvokes.m_ts.fn_GuiInspector_apply(_ID);
}
/// <summary>
/// getInspectObject( int index=0 ) - Returns currently inspected object )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getInspectObject(uint index = 0){

return pInvokes.m_ts.fn_GuiInspector_getInspectObject(_ID, index);
}
/// <summary>
/// () - Return the number of objects currently being inspected. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNumInspectObjects(){

return pInvokes.m_ts.fn_GuiInspector_getNumInspectObjects(_ID);
}
/// <summary>
/// Inspect(Object))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void inspect(string className){

pInvokes.m_ts.fn_GuiInspector_inspect(_ID, className);
}
/// <summary>
/// Reinspect the currently selected object. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void refresh(){

pInvokes.m_ts.fn_GuiInspector_refresh(_ID);
}
/// <summary>
/// ( id object ) - Remove the object from the list of objects being inspected. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeInspect(string obj){

pInvokes.m_ts.fn_GuiInspector_removeInspect(_ID, obj);
}
/// <summary>
/// setName(NewObjectName))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void setName(string newObjectName){

pInvokes.m_ts.fn_GuiInspector_setName(_ID, newObjectName);
}
/// <summary>
/// setObjectField( fieldname, data ) - Set a named fields value on the inspected object if it exists. This triggers all the usual callbacks that would occur if the field had been changed through the gui. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setObjectField(string fieldname, string data){

pInvokes.m_ts.fn_GuiInspector_setObjectField(_ID, fieldname, data);
}

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onClear(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void beginCompoundUndo(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void endCompoundUndo(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onBeginCompoundEdit(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEndCompoundEdit(){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onFieldRightClick(string field){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onFieldAdded(string objectx, string fieldName){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onFieldRemoved(string objectx, string fieldName){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onFieldRenameAlreadyDefined(string objectx, string oldFieldName, string newFieldName){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onFieldRenamed(string objectx, string oldFieldName, string newFieldName){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue){}

#endregion
public GuiInspector_Base (){}
}}
