


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
    [TypeConverter(typeof(TypeConverterGeneric<RenderFormatToken_Base>))]
    public partial class RenderFormatToken_Base: RenderPassStateToken
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RenderFormatToken_Base ts, string simobjectid)
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
        public static bool operator !=(RenderFormatToken_Base ts, string simobjectid)
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
        public static implicit operator string( RenderFormatToken_Base ts)
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
        public static implicit operator RenderFormatToken_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (RenderFormatToken_Base) Omni.self.getSimObject(simobjectid,typeof(RenderFormatToken_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( RenderFormatToken_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RenderFormatToken_Base(int simobjectid)
            {
            return  (RenderFormatToken) Omni.self.getSimObject((uint)simobjectid,typeof(RenderFormatToken_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( RenderFormatToken_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RenderFormatToken_Base(uint simobjectid)
            {
            return  (RenderFormatToken_Base) Omni.self.getSimObject(simobjectid,typeof(RenderFormatToken_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// This PostEffect will be run when the render target is changed to the format specified    by this token. It is used to copy/format data into the token rendertarget
/// </summary>
[MemberGroup("")]
public PostEffect copyEffect
       {
       get
          {
          return Omni.self.GetVar(_ID + ".copyEffect");
          }
       set
          {
          Omni.self.SetVar(_ID + ".copyEffect", value.ToString());
          }
       }
/// <summary>
/// Sets the depth/stencil buffer format for this token.
/// </summary>
[MemberGroup("")]
public TypeGFXFormat depthFormat
       {
       get
          {          return (TypeGFXFormat) Omni.self.GetVar(_ID + ".depthFormat");
          }
       set
          {
          Omni.self.SetVar(_ID + ".depthFormat", value.ToString());
          }
       }
/// <summary>
/// Sets the color buffer format for this token.
/// </summary>
[MemberGroup("")]
public TypeGFXFormat format
       {
       get
          {          return (TypeGFXFormat) Omni.self.GetVar(_ID + ".format");
          }
       set
          {
          Omni.self.SetVar(_ID + ".format", value.ToString());
          }
       }
/// <summary>
/// This PostEffect will be run when the render target is changed back to the format    active prior to this token. It is used to copy/format data from the token rendertarget to the backbuffer.
/// </summary>
[MemberGroup("")]
public PostEffect resolveEffect
       {
       get
          {
          return Omni.self.GetVar(_ID + ".resolveEffect");
          }
       set
          {
          Omni.self.SetVar(_ID + ".resolveEffect", value.ToString());
          }
       }
/// <summary>
/// Anti-ailiasing level for the this token. 0 disables, -1 uses adapter default.
/// </summary>
[MemberGroup("")]
public int aaLevel
       {
       get
          {
          return Omni.self.GetVar(_ID + ".aaLevel").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".aaLevel", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public RenderFormatToken_Base (){}
}}
