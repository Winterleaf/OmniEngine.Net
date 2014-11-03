


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiDragAndDropControl_Base>))]
    public partial class GuiDragAndDropControl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiDragAndDropControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiDragAndDropControl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiDragAndDropControl_Base ts)
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
        public static implicit operator GuiDragAndDropControl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiDragAndDropControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDragAndDropControl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiDragAndDropControl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiDragAndDropControl_Base(int simobjectid)
            {
            return  (GuiDragAndDropControl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiDragAndDropControl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiDragAndDropControl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiDragAndDropControl_Base(uint simobjectid)
            {
            return  (GuiDragAndDropControl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDragAndDropControl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true, the control deletes itself when the left mouse button is released.\n\n   If at this point, the draganddrop control still contains its payload, it will be deleted along with the control. 
/// </summary>
[MemberGroup("")]
public bool deleteOnMouseUp
       {
       get
          {
          return Omni.self.GetVar(_ID + ".deleteOnMouseUp").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".deleteOnMouseUp", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Start the drag operation.
///    @param x X coordinate for the mouse pointer offset which the drag control should position itself.
///    @param y Y coordinate for the mouse pointer offset which the drag control should position itself.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void startDragging(int x = 0, int y = 0){

pInvokes.m_ts.fnGuiDragAndDropControl_startDragging(_ID, x, y);
}

#endregion
#region T3D Callbacks

#endregion
public GuiDragAndDropControl_Base (){}
}}
