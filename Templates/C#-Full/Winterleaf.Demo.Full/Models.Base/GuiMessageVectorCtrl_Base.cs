


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiMessageVectorCtrl_Base>))]
    public partial class GuiMessageVectorCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiMessageVectorCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiMessageVectorCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiMessageVectorCtrl_Base ts)
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
        public static implicit operator GuiMessageVectorCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiMessageVectorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMessageVectorCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiMessageVectorCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiMessageVectorCtrl_Base(int simobjectid)
            {
            return  (GuiMessageVectorCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiMessageVectorCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiMessageVectorCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiMessageVectorCtrl_Base(uint simobjectid)
            {
            return  (GuiMessageVectorCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMessageVectorCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public int lineContinuedIndex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lineContinuedIndex").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lineContinuedIndex", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public int lineSpacing
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lineSpacing").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lineSpacing", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public ColorI matchColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".matchColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".matchColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public int maxColorIndex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxColorIndex").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxColorIndex", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Push a line onto the back of the list.
/// 
/// 	   @param item The GUI element being pushed into the control
/// 
/// 	   @tsexample
/// 	   // All messages are stored in this HudMessageVector, the actual
/// 	   // MainChatHud only displays the contents of this vector.
/// 	   new MessageVector(HudMessageVector);
/// 	   // Attach the MessageVector to the chat control
/// 	   chatHud.attach(HudMessageVector);
/// 	   @endtsexample
/// 
/// 	   @return Value)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool attach(string item){

return pInvokes.m_ts.fnGuiMessageVectorCtrl_attach(_ID, item);
}
/// <summary>
/// @brief Stop listing messages from the MessageVector previously attached to, if any.
/// 
/// 				   Detailed description
/// 
/// 				   @param param Description
/// 
/// 				   @tsexample
/// 				   // Deatch the MessageVector from HudMessageVector
/// 				   // HudMessageVector will no longer render the text
/// 				   chatHud.detach();
/// 				   @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void detach(){

pInvokes.m_ts.fnGuiMessageVectorCtrl_detach(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void urlClickCallback(string url){}

#endregion
public GuiMessageVectorCtrl_Base (){}
}}
