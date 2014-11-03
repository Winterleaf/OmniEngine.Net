


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiControlProfile_Base>))]
    public partial class GuiControlProfile_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiControlProfile_Base ts, string simobjectid)
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
        public static bool operator !=(GuiControlProfile_Base ts, string simobjectid)
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
        public static implicit operator string( GuiControlProfile_Base ts)
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
        public static implicit operator GuiControlProfile_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiControlProfile_Base) Omni.self.getSimObject(simobjectid,typeof(GuiControlProfile_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiControlProfile_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiControlProfile_Base(int simobjectid)
            {
            return  (GuiControlProfile) Omni.self.getSimObject((uint)simobjectid,typeof(GuiControlProfile_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiControlProfile_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiControlProfile_Base(uint simobjectid)
            {
            return  (GuiControlProfile_Base) Omni.self.getSimObject(simobjectid,typeof(GuiControlProfile_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Automatically adjust height of control to fit contents. 
/// </summary>
[MemberGroup("Text")]
public bool autoSizeHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".autoSizeHeight").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".autoSizeHeight", value.AsString());
          }
       }
/// <summary>
/// Automatically adjust width of control to fit contents. 
/// </summary>
[MemberGroup("Text")]
public bool autoSizeWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".autoSizeWidth").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".autoSizeWidth", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Appearance")]
public ColorI bevelColorHL
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bevelColorHL").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bevelColorHL", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Appearance")]
public ColorI bevelColorLL
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bevelColorLL").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bevelColorLL", value.AsString());
          }
       }
/// <summary>
/// Texture to use for rendering control. 
/// </summary>
[MemberGroup("Misc")]
public String bitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bitmap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bitmap", value.AsString());
          }
       }
/// <summary>
/// Border type (0=no border). 
/// </summary>
[MemberGroup("Appearance")]
public int border
       {
       get
          {
          return Omni.self.GetVar(_ID + ".border").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".border", value.AsString());
          }
       }
/// <summary>
/// Color to draw border with. 
/// </summary>
[MemberGroup("Appearance")]
public ColorI borderColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Appearance")]
public ColorI borderColorHL
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderColorHL").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderColorHL", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Appearance")]
public ColorI borderColorNA
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderColorNA").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderColorNA", value.AsString());
          }
       }
/// <summary>
/// Thickness of border in pixels. 
/// </summary>
[MemberGroup("Appearance")]
public int borderThickness
       {
       get
          {
          return Omni.self.GetVar(_ID + ".borderThickness").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".borderThickness", value.AsString());
          }
       }
/// <summary>
/// Whether the control can have the keyboard focus. 
/// </summary>
[MemberGroup("Behavior")]
public bool canKeyFocus
       {
       get
          {
          return Omni.self.GetVar(_ID + ".canKeyFocus").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".canKeyFocus", value.AsString());
          }
       }
/// <summary>
/// Category under which the profile will appear in the editor.  
/// </summary>
[MemberGroup("")]
public String category
       {
       get
          {
          return Omni.self.GetVar(_ID + ".category").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".category", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Behavior")]
public TypeGuiControl controlBound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".controlBound").AsTypeGuiControl();
          }
       set
          {
          Omni.self.SetVar(_ID + ".controlBound", value.AsString());
          }
       }
/// <summary>
/// Color to use for the text cursor. 
/// </summary>
[MemberGroup("Text")]
public ColorI cursorColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cursorColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cursorColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Appearance")]
public ColorI fillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fillColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fillColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Appearance")]
public ColorI fillColorHL
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fillColorHL").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fillColorHL", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Appearance")]
public ColorI fillColorNA
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fillColorNA").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fillColorNA", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Appearance")]
public ColorI fillColorSEL
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fillColorSEL").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fillColorSEL", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Text")]
public TypeGuiFontCharset fontCharset
       {
       get
          {          return (TypeGuiFontCharset) Omni.self.GetVar(_ID + ".fontCharset");
          }
       set
          {
          Omni.self.SetVar(_ID + ".fontCharset", value.ToString());
          }
       }
/// <summary>
/// Font color for normal text (same as fontColors[0]). 
/// </summary>
[MemberGroup("Text")]
public ColorI fontColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fontColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fontColor", value.AsString());
          }
       }
/// <summary>
/// Font color for highlighted text (same as fontColors[1]). 
/// </summary>
[MemberGroup("Text")]
public ColorI fontColorHL
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fontColorHL").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fontColorHL", value.AsString());
          }
       }
/// <summary>
/// Font color for links in text (same as fontColors[4]). 
/// </summary>
[MemberGroup("Text")]
public ColorI fontColorLink
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fontColorLink").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fontColorLink", value.AsString());
          }
       }
/// <summary>
/// Font color for highlighted links in text (same as fontColors[5]). 
/// </summary>
[MemberGroup("Text")]
public ColorI fontColorLinkHL
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fontColorLinkHL").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fontColorLinkHL", value.AsString());
          }
       }
/// <summary>
/// Font color when control is not active/disabled (same as fontColors[2]). 
/// </summary>
[MemberGroup("Text")]
public ColorI fontColorNA
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fontColorNA").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fontColorNA", value.AsString());
          }
       }
[MemberGroup("Text")]
public arrayObject<ColorI> fontColors;
/// <summary>
/// Font color for selected text (same as fontColors[3]). 
/// </summary>
[MemberGroup("Text")]
public ColorI fontColorSEL
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fontColorSEL").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fontColorSEL", value.AsString());
          }
       }
/// <summary>
/// Font size in points. 
/// </summary>
[MemberGroup("Text")]
public int fontSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fontSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fontSize", value.AsString());
          }
       }
/// <summary>
/// Name of font family and typeface (e.g. \Arial Bold\). 
/// </summary>
[MemberGroup("Text")]
public String fontType
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fontType").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fontType", value.AsString());
          }
       }
/// <summary>
/// If true, 'bitmap' is an array of images. 
/// </summary>
[MemberGroup("Misc")]
public bool hasBitmapArray
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hasBitmapArray").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hasBitmapArray", value.AsString());
          }
       }
/// <summary>
/// Horizontal alignment for text. 
/// </summary>
[MemberGroup("Text")]
public TypeGuiAlignmentType justify
       {
       get
          {          return (TypeGuiAlignmentType) Omni.self.GetVar(_ID + ".justify");
          }
       set
          {
          Omni.self.SetVar(_ID + ".justify", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Behavior")]
public bool modal
       {
       get
          {
          return Omni.self.GetVar(_ID + ".modal").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".modal", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Behavior")]
public bool mouseOverSelected
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mouseOverSelected").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mouseOverSelected", value.AsString());
          }
       }
/// <summary>
/// Whether control should only accept numerical data (GuiTextEditCtrl). 
/// </summary>
[MemberGroup("Text")]
public bool numbersOnly
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numbersOnly").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numbersOnly", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Appearance")]
public bool opaque
       {
       get
          {
          return Omni.self.GetVar(_ID + ".opaque").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".opaque", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Misc")]
public String profileForChildren
       {
       get
          {
          return Omni.self.GetVar(_ID + ".profileForChildren").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".profileForChildren", value.AsString());
          }
       }
/// <summary>
/// Whether to add automatic tab event when return is pressed so focus moves on to next control (GuiTextEditCtrl). 
/// </summary>
[MemberGroup("Text")]
public bool returnTab
       {
       get
          {
          return Omni.self.GetVar(_ID + ".returnTab").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".returnTab", value.AsString());
          }
       }
/// <summary>
/// Sound to play when mouse has been pressed on control. 
/// </summary>
[MemberGroup("Misc")]
public TypeSFXTrackName soundButtonDown
       {
       get
          {
          return Omni.self.GetVar(_ID + ".soundButtonDown").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".soundButtonDown", value.AsString());
          }
       }
/// <summary>
/// Sound to play when mouse is hovering over control. 
/// </summary>
[MemberGroup("Misc")]
public TypeSFXTrackName soundButtonOver
       {
       get
          {
          return Omni.self.GetVar(_ID + ".soundButtonOver").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".soundButtonOver", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Behavior")]
public bool tab
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tab").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tab", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Text")]
public Point2I textOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textOffset").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textOffset", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ( pString ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getStringWidth(string pString){

return pInvokes.m_ts.fn_GuiControlProfile_getStringWidth(_ID, pString);
}

#endregion
#region T3D Callbacks

#endregion
public GuiControlProfile_Base (){fontColors = new arrayObject<ColorI>(10,"fontColors","TypeVariable",false,this);    
}
}}
