


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
    [TypeConverter(typeof(TypeConverterGeneric<DynamicConsoleMethodComponent_Base>))]
    public partial class DynamicConsoleMethodComponent_Base: SimComponent
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DynamicConsoleMethodComponent_Base ts, string simobjectid)
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
        public static bool operator !=(DynamicConsoleMethodComponent_Base ts, string simobjectid)
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
        public static implicit operator string( DynamicConsoleMethodComponent_Base ts)
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
        public static implicit operator DynamicConsoleMethodComponent_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (DynamicConsoleMethodComponent_Base) Omni.self.getSimObject(simobjectid,typeof(DynamicConsoleMethodComponent_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( DynamicConsoleMethodComponent_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DynamicConsoleMethodComponent_Base(int simobjectid)
            {
            return  (DynamicConsoleMethodComponent) Omni.self.getSimObject((uint)simobjectid,typeof(DynamicConsoleMethodComponent_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( DynamicConsoleMethodComponent_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DynamicConsoleMethodComponent_Base(uint simobjectid)
            {
            return  (DynamicConsoleMethodComponent_Base) Omni.self.getSimObject(simobjectid,typeof(DynamicConsoleMethodComponent_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ( DynamicConsoleMethodComponent, callMethod, void, 3, 64 , (methodName, argi) Calls script defined method
/// 			  @param methodName The method's name as a string
/// 			  @param argi Any arguments to pass to the method
/// 			  @return No return value
/// 			  @note %obj.callMethod( %methodName, %arg1, %arg2, ... );)
/// 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void callMethod(string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= "", string a20= "", string a21= "", string a22= "", string a23= "", string a24= "", string a25= "", string a26= "", string a27= "", string a28= "", string a29= "", string a30= "", string a31= "", string a32= "", string a33= "", string a34= "", string a35= "", string a36= "", string a37= "", string a38= "", string a39= "", string a40= "", string a41= "", string a42= "", string a43= "", string a44= "", string a45= "", string a46= "", string a47= "", string a48= "", string a49= "", string a50= "", string a51= "", string a52= "", string a53= "", string a54= "", string a55= "", string a56= "", string a57= "", string a58= "", string a59= "", string a60= "", string a61= "", string a62= "", string a63= ""){

pInvokes.m_ts.fnDynamicConsoleMethodComponent_callMethod(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63);
}

#endregion
#region T3D Callbacks

#endregion
public DynamicConsoleMethodComponent_Base (){}
}}
