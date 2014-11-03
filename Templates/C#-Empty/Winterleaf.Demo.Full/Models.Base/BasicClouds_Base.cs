


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
    [TypeConverter(typeof(TypeConverterGeneric<BasicClouds_Base>))]
    public partial class BasicClouds_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(BasicClouds_Base ts, string simobjectid)
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
        public static bool operator !=(BasicClouds_Base ts, string simobjectid)
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
        public static implicit operator string( BasicClouds_Base ts)
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
        public static implicit operator BasicClouds_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (BasicClouds_Base) Omni.self.getSimObject(simobjectid,typeof(BasicClouds_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( BasicClouds_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator BasicClouds_Base(int simobjectid)
            {
            return  (BasicClouds) Omni.self.getSimObject((uint)simobjectid,typeof(BasicClouds_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( BasicClouds_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator BasicClouds_Base(uint simobjectid)
            {
            return  (BasicClouds_Base) Omni.self.getSimObject(simobjectid,typeof(BasicClouds_Base));
            }
#endregion
#region Init Persists
[MemberGroup("BasicClouds")]
public arrayObject<float> height;
[MemberGroup("BasicClouds")]
public arrayObject<bool> layerEnabled;
[MemberGroup("BasicClouds")]
public arrayObject<Point2F> texDirection;
[MemberGroup("BasicClouds")]
public arrayObject<Point2F> texOffset;
[MemberGroup("BasicClouds")]
public arrayObject<float> texScale;
[MemberGroup("BasicClouds")]
public arrayObject<float> texSpeed;
[MemberGroup("BasicClouds")]
public arrayObject<TypeImageFilename> texture;

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public BasicClouds_Base (){height = new arrayObject<float>(3,"height","TypeVariable",false,this);    
layerEnabled = new arrayObject<bool>(3,"layerEnabled","TypeVariable",false,this);    
texDirection = new arrayObject<Point2F>(3,"texDirection","TypeVariable",false,this);    
texOffset = new arrayObject<Point2F>(3,"texOffset","TypeVariable",false,this);    
texScale = new arrayObject<float>(3,"texScale","TypeVariable",false,this);    
texSpeed = new arrayObject<float>(3,"texSpeed","TypeVariable",false,this);    
texture = new arrayObject<TypeImageFilename>(3,"texture","TypeVariable",false,this);    
}
}}
