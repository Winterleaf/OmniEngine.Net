


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
    [TypeConverter(typeof(TypeConverterGeneric<SimComponent_Base>))]
    public partial class SimComponent_Base: NetObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SimComponent_Base ts, string simobjectid)
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
        public static bool operator !=(SimComponent_Base ts, string simobjectid)
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
        public static implicit operator string( SimComponent_Base ts)
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
        public static implicit operator SimComponent_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SimComponent_Base) Omni.self.getSimObject(simobjectid,typeof(SimComponent_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SimComponent_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SimComponent_Base(int simobjectid)
            {
            return  (SimComponent) Omni.self.getSimObject((uint)simobjectid,typeof(SimComponent_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SimComponent_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SimComponent_Base(uint simobjectid)
            {
            return  (SimComponent_Base) Omni.self.getSimObject(simobjectid,typeof(SimComponent_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Places the object in a component set for later use in new levels. 
/// </summary>
[MemberGroup("Component")]
public bool Template
       {
       get
          {
          return Omni.self.GetVar(_ID + ".Template").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".Template", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// (idx) Get the component corresponding to the given index.
/// 			  @param idx An integer index value corresponding to the desired component.
/// 			  @return The id of the component at the given index as an integer)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getComponent(int idx){

return pInvokes.m_ts.fn_SimComponent_getComponent(_ID, idx);
}
/// <summary>
/// () Get the current component count
/// 			  @return The number of components in the list as an integer)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getComponentCount(){

return pInvokes.m_ts.fn_SimComponent_getComponentCount(_ID);
}
/// <summary>
/// () Check whether SimComponent is currently a template
/// 			  @return true if is a template and false if not)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getIsTemplate(){

return pInvokes.m_ts.fn_SimComponent_getIsTemplate(_ID);
}
/// <summary>
/// () Check whether SimComponent is currently enabled
/// 			  @return true if enabled and false if not)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  bool isEnabled(){

return pInvokes.m_ts.fn_SimComponent_isEnabled(_ID);
}
/// <summary>
/// (enabled) Sets or unsets the enabled flag
/// 			  @param enabled Boolean value
/// 			  @return No return value)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void setEnabled(bool enabled){

pInvokes.m_ts.fn_SimComponent_setEnabled(_ID, enabled);
}
/// <summary>
/// (template) Sets or unsets the template flag
/// 			  @param template Boolean value
/// 			  @return No return value)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setIsTemplate(bool templateFlag){

pInvokes.m_ts.fn_SimComponent_setIsTemplate(_ID, templateFlag);
}
/// <summary>
/// ( SimComponent, addComponents, bool, 3, 64, %obj.addComponents( %compObjName, %compObjName2, ... );
/// 			  Adds additional components to current list.
/// 			  @param Up to 62 component names
/// 			  @return Returns true on success, false otherwise.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool addComponents(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= "", string a20= "", string a21= "", string a22= "", string a23= "", string a24= "", string a25= "", string a26= "", string a27= "", string a28= "", string a29= "", string a30= "", string a31= "", string a32= "", string a33= "", string a34= "", string a35= "", string a36= "", string a37= "", string a38= "", string a39= "", string a40= "", string a41= "", string a42= "", string a43= "", string a44= "", string a45= "", string a46= "", string a47= "", string a48= "", string a49= "", string a50= "", string a51= "", string a52= "", string a53= "", string a54= "", string a55= "", string a56= "", string a57= "", string a58= "", string a59= "", string a60= "", string a61= "", string a62= "", string a63= ""){

return pInvokes.m_ts.fnSimComponent_addComponents(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63);
}
/// <summary>
/// ( SimComponent, removeComponents, bool, 3, 64, %obj.removeComponents( %compObjName, %compObjName2, ... );
/// 			  Removes components by name from current list.
/// 			  @param objNamex Up to 62 component names
/// 			  @return Returns true on success, false otherwise.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool removeComponents(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= "", string a20= "", string a21= "", string a22= "", string a23= "", string a24= "", string a25= "", string a26= "", string a27= "", string a28= "", string a29= "", string a30= "", string a31= "", string a32= "", string a33= "", string a34= "", string a35= "", string a36= "", string a37= "", string a38= "", string a39= "", string a40= "", string a41= "", string a42= "", string a43= "", string a44= "", string a45= "", string a46= "", string a47= "", string a48= "", string a49= "", string a50= "", string a51= "", string a52= "", string a53= "", string a54= "", string a55= "", string a56= "", string a57= "", string a58= "", string a59= "", string a60= "", string a61= "", string a62= "", string a63= ""){

return pInvokes.m_ts.fnSimComponent_removeComponents(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when a component is removed.   @targetId target ID   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onComponentAdd(string targetId){}

        /// <summary>
        /// Called when a component is removed.   @targetId target ID   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onComponentRemove(string targetId){}

#endregion
public SimComponent_Base (){}
}}
