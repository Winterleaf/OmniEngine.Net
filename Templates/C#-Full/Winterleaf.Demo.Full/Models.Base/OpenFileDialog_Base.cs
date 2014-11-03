


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
    [TypeConverter(typeof(TypeConverterGeneric<OpenFileDialog_Base>))]
    public partial class OpenFileDialog_Base: FileDialog
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(OpenFileDialog_Base ts, string simobjectid)
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
        public static bool operator !=(OpenFileDialog_Base ts, string simobjectid)
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
        public static implicit operator string( OpenFileDialog_Base ts)
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
        public static implicit operator OpenFileDialog_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (OpenFileDialog_Base) Omni.self.getSimObject(simobjectid,typeof(OpenFileDialog_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( OpenFileDialog_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator OpenFileDialog_Base(int simobjectid)
            {
            return  (OpenFileDialog) Omni.self.getSimObject((uint)simobjectid,typeof(OpenFileDialog_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( OpenFileDialog_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator OpenFileDialog_Base(uint simobjectid)
            {
            return  (OpenFileDialog_Base) Omni.self.getSimObject(simobjectid,typeof(OpenFileDialog_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// True/False whether multiple files may be selected and returned or not 
/// </summary>
[MemberGroup("")]
public bool MultipleFiles
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MultipleFiles").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MultipleFiles", value.AsString());
          }
       }
/// <summary>
/// True/False whether the file returned must exist or not 
/// </summary>
[MemberGroup("")]
public bool MustExist
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MustExist").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MustExist", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public OpenFileDialog_Base (){}
}}
