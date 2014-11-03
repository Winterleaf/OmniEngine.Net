


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
    [TypeConverter(typeof(TypeConverterGeneric<ForestBrushElement_Base>))]
    public partial class ForestBrushElement_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ForestBrushElement_Base ts, string simobjectid)
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
        public static bool operator !=(ForestBrushElement_Base ts, string simobjectid)
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
        public static implicit operator string( ForestBrushElement_Base ts)
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
        public static implicit operator ForestBrushElement_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ForestBrushElement_Base) Omni.self.getSimObject(simobjectid,typeof(ForestBrushElement_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ForestBrushElement_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestBrushElement_Base(int simobjectid)
            {
            return  (ForestBrushElement) Omni.self.getSimObject((uint)simobjectid,typeof(ForestBrushElement_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ForestBrushElement_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestBrushElement_Base(uint simobjectid)
            {
            return  (ForestBrushElement_Base) Omni.self.getSimObject(simobjectid,typeof(ForestBrushElement_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The max world space elevation this item will be placed. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float elevationMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".elevationMax").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".elevationMax", value.AsString());
          }
       }
/// <summary>
/// The min world space elevation this item will be placed. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float elevationMin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".elevationMin").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".elevationMin", value.AsString());
          }
       }
/// <summary>
/// The type of ForestItem this element holds placement parameters for. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public ForestItemData forestItemData
       {
       get
          {
          return Omni.self.GetVar(_ID + ".forestItemData");
          }
       set
          {
          Omni.self.SetVar(_ID + ".forestItemData", value.ToString());
          }
       }
/// <summary>
/// The probability that this element will be created during an editor brush stroke      is the sum of all element probabilities in the brush divided by the probability      of this element. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float probability
       {
       get
          {
          return Omni.self.GetVar(_ID + ".probability").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".probability", value.AsString());
          }
       }
/// <summary>
/// The max rotation in degrees that items will be placed. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float rotationRange
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rotationRange").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rotationRange", value.AsString());
          }
       }
/// <summary>
/// An exponent used to bias between the minimum and maximum random sizes. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float scaleExponent
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scaleExponent").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scaleExponent", value.AsString());
          }
       }
/// <summary>
/// The maximum random size of each item. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float scaleMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scaleMax").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scaleMax", value.AsString());
          }
       }
/// <summary>
/// The minimum random size for each item. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float scaleMin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scaleMin").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scaleMin", value.AsString());
          }
       }
/// <summary>
/// Max variation in the sink radius. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float sinkMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sinkMax").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sinkMax", value.AsString());
          }
       }
/// <summary>
/// Min variation in the sink radius. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float sinkMin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sinkMin").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sinkMin", value.AsString());
          }
       }
/// <summary>
/// This is the radius used to calculate how much to sink the trunk at      its base and is used to sink the tree into the ground when its on a slope. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float sinkRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sinkRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sinkRadius", value.AsString());
          }
       }
/// <summary>
/// The max surface slope in degrees this item will be placed on. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float slopeMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".slopeMax").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".slopeMax", value.AsString());
          }
       }
/// <summary>
/// The min surface slope in degrees this item will be placed on. 
/// </summary>
[MemberGroup("ForestBrushElement")]
public float slopeMin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".slopeMin").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".slopeMin", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public ForestBrushElement_Base (){}
}}
