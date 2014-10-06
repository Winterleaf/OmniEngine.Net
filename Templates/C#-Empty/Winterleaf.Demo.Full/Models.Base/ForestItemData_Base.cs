


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
    [TypeConverter(typeof(TypeConverterGeneric<ForestItemData_Base>))]
    public partial class ForestItemData_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ForestItemData_Base ts, string simobjectid)
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
        public static bool operator !=(ForestItemData_Base ts, string simobjectid)
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
        public static implicit operator string( ForestItemData_Base ts)
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
        public static implicit operator ForestItemData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ForestItemData_Base) Omni.self.getSimObject(simobjectid,typeof(ForestItemData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ForestItemData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestItemData_Base(int simobjectid)
            {
            return  (ForestItemData) Omni.self.getSimObject((uint)simobjectid,typeof(ForestItemData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ForestItemData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestItemData_Base(uint simobjectid)
            {
            return  (ForestItemData_Base) Omni.self.getSimObject(simobjectid,typeof(ForestItemData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Amplitude of the effect on larger branches. 
/// </summary>
[MemberGroup("Wind")]
public float branchAmp
       {
       get
          {
          return Omni.self.GetVar(_ID + ".branchAmp").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".branchAmp", value.AsString());
          }
       }
/// <summary>
/// Can other objects or spacial queries hit items of this type. 
/// </summary>
[MemberGroup("Media")]
public bool collidable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".collidable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".collidable", value.AsString());
          }
       }
/// <summary>
/// Coefficient used in calculating spring forces on the trunk.      Causes oscillation and forces to decay faster over time. 
/// </summary>
[MemberGroup("Wind")]
public float dampingCoefficient
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dampingCoefficient").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dampingCoefficient", value.AsString());
          }
       }
/// <summary>
/// Amplitude of the winds effect on leafs/fronds. 
/// </summary>
[MemberGroup("Wind")]
public float detailAmp
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailAmp").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailAmp", value.AsString());
          }
       }
/// <summary>
/// Frequency (speed) of the effect on leafs/fronds. 
/// </summary>
[MemberGroup("Wind")]
public float detailFreq
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailFreq").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailFreq", value.AsString());
          }
       }
/// <summary>
/// Mass used in calculating spring forces on the trunk. Generally how      springy a plant is. 
/// </summary>
[MemberGroup("Wind")]
public float mass
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mass").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mass", value.AsString());
          }
       }
/// <summary>
/// Radius used during placement to ensure items are not crowded. 
/// </summary>
[MemberGroup("Media")]
public float radius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".radius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".radius", value.AsString());
          }
       }
/// <summary>
/// Rigidity used in calculating spring forces on the trunk. How much the plant resists the wind force 
/// </summary>
[MemberGroup("Wind")]
public float rigidity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rigidity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rigidity", value.AsString());
          }
       }
/// <summary>
/// Shape file for this item type 
/// </summary>
[MemberGroup("Media")]
public TypeShapeFilename shapeFile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".shapeFile").AsTypeShapeFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".shapeFile", value.AsString());
          }
       }
/// <summary>
/// Coefficient used in calculating spring forces on the trunk.      How much the plant resists bending. 
/// </summary>
[MemberGroup("Wind")]
public float tightnessCoefficient
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tightnessCoefficient").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tightnessCoefficient", value.AsString());
          }
       }
/// <summary>
/// Overall bend amount of the tree trunk by wind and impacts. 
/// </summary>
[MemberGroup("Wind")]
public float trunkBendScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".trunkBendScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".trunkBendScale", value.AsString());
          }
       }
/// <summary>
/// Overall scale to the effect of wind. 
/// </summary>
[MemberGroup("Wind")]
public float windScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windScale", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public ForestItemData_Base (){}
}}
