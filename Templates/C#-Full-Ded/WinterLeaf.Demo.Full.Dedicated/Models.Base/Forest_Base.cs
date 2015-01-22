


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
    [TypeConverter(typeof(TypeConverterGeneric<Forest_Base>))]
    public partial class Forest_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Forest_Base ts, string simobjectid)
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
        public static bool operator !=(Forest_Base ts, string simobjectid)
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
        public static implicit operator string( Forest_Base ts)
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
        public static implicit operator Forest_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Forest_Base) Omni.self.getSimObject(simobjectid,typeof(Forest_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Forest_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Forest_Base(int simobjectid)
            {
            return  (Forest) Omni.self.getSimObject((uint)simobjectid,typeof(Forest_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Forest_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Forest_Base(uint simobjectid)
            {
            return  (Forest_Base) Omni.self.getSimObject(simobjectid,typeof(Forest_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The source forest data file. 
/// </summary>
[MemberGroup("")]
public String dataFile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dataFile").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dataFile", value.AsString());
          }
       }
/// <summary>
/// Scalar applied to the farclip distance when Forest renders into a reflection. 
/// </summary>
[MemberGroup("Lod")]
public float lodReflectScalar
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lodReflectScalar").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lodReflectScalar", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// () )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clear(){

pInvokes.m_ts.fn_Forest_clear(_ID);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isDirty(){

return pInvokes.m_ts.fn_Forest_isDirty(_ID);
}
/// <summary>
/// ())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void regenCells(){

pInvokes.m_ts.fn_Forest_regenCells(_ID);
}
/// <summary>
/// saveDataFile( [path] ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void saveDataFile(string path = null ){
if (path== null) {path = null;}

pInvokes.m_ts.fn_Forest_saveDataFile(_ID, path);
}
/// <summary>
/// .)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addItem(string data, Point3F position, float rotation, float scale){

pInvokes.m_ts.fnForest_addItem(_ID, data, position.AsString(), rotation, scale);
}
/// <summary>
/// .)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addItemWithTransform(string data, TransformF trans, float scale){

pInvokes.m_ts.fnForest_addItemWithTransform(_ID, data, trans.AsString(), scale);
}

#endregion
#region T3D Callbacks

#endregion
public Forest_Base (){}
}}
