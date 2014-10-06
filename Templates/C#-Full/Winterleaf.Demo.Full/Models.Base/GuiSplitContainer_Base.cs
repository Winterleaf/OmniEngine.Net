


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiSplitContainer_Base>))]
    public partial class GuiSplitContainer_Base: GuiContainer
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiSplitContainer_Base ts, string simobjectid)
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
        public static bool operator !=(GuiSplitContainer_Base ts, string simobjectid)
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
        public static implicit operator string( GuiSplitContainer_Base ts)
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
        public static implicit operator GuiSplitContainer_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiSplitContainer_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSplitContainer_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiSplitContainer_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiSplitContainer_Base(int simobjectid)
            {
            return  (GuiSplitContainer) Omni.self.getSimObject((uint)simobjectid,typeof(GuiSplitContainer_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiSplitContainer_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiSplitContainer_Base(uint simobjectid)
            {
            return  (GuiSplitContainer_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSplitContainer_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Which (if any) side of the splitter to keep at a fixed size. 
/// </summary>
[MemberGroup("Splitter")]
public TypeGuiSplitFixedPanel fixedPanel
       {
       get
          {          return (TypeGuiSplitFixedPanel) Omni.self.GetVar(_ID + ".fixedPanel");
          }
       set
          {
          Omni.self.SetVar(_ID + ".fixedPanel", value.ToString());
          }
       }
/// <summary>
/// Width of the fixed panel specified by #fixedPanel (if any). 
/// </summary>
[MemberGroup("Splitter")]
public int fixedSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fixedSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fixedSize", value.AsString());
          }
       }
/// <summary>
/// Whether to split between top and bottom (horizontal) or between left and right (vertical). 
/// </summary>
[MemberGroup("Splitter")]
public TypeGuiSplitOrientation orientation
       {
       get
          {          return (TypeGuiSplitOrientation) Omni.self.GetVar(_ID + ".orientation");
          }
       set
          {
          Omni.self.SetVar(_ID + ".orientation", value.ToString());
          }
       }
/// <summary>
/// Point on control through which the splitter goes.\n\n     Changed relatively if size of control changes. 
/// </summary>
[MemberGroup("Splitter")]
public Point2I splitPoint
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splitPoint").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".splitPoint", value.AsString());
          }
       }
/// <summary>
/// Width of the splitter bar between the two sides. Default is 2. 
/// </summary>
[MemberGroup("Splitter")]
public int splitterSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splitterSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".splitterSize", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiSplitContainer_Base (){}
}}
