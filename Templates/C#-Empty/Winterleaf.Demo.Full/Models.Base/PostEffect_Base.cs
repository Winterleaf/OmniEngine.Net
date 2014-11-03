


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
    [TypeConverter(typeof(TypeConverterGeneric<PostEffect_Base>))]
    public partial class PostEffect_Base: SimGroup
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PostEffect_Base ts, string simobjectid)
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
        public static bool operator !=(PostEffect_Base ts, string simobjectid)
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
        public static implicit operator string( PostEffect_Base ts)
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
        public static implicit operator PostEffect_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (PostEffect_Base) Omni.self.getSimObject(simobjectid,typeof(PostEffect_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( PostEffect_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PostEffect_Base(int simobjectid)
            {
            return  (PostEffect) Omni.self.getSimObject((uint)simobjectid,typeof(PostEffect_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( PostEffect_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PostEffect_Base(uint simobjectid)
            {
            return  (PostEffect_Base) Omni.self.getSimObject(simobjectid,typeof(PostEffect_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Is this effect processed during reflection render passes. 
/// </summary>
[MemberGroup("")]
public bool allowReflectPass
       {
       get
          {
          return Omni.self.GetVar(_ID + ".allowReflectPass").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".allowReflectPass", value.AsString());
          }
       }
/// <summary>
/// Is the effect on. 
/// </summary>
[MemberGroup("")]
public bool isEnabled
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isEnabled").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isEnabled", value.AsString());
          }
       }
/// <summary>
/// Allows you to turn on a PostEffect for only a single frame. 
/// </summary>
[MemberGroup("")]
public bool oneFrameOnly
       {
       get
          {
          return Omni.self.GetVar(_ID + ".oneFrameOnly").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".oneFrameOnly", value.AsString());
          }
       }
/// <summary>
/// Allows you to turn on a PostEffect for only a single frame. 
/// </summary>
[MemberGroup("")]
public bool onThisFrame
       {
       get
          {
          return Omni.self.GetVar(_ID + ".onThisFrame").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".onThisFrame", value.AsString());
          }
       }
/// <summary>
/// Name of a renderBin, used if renderTime is PFXBeforeBin or PFXAfterBin. 
/// </summary>
[MemberGroup("")]
public String renderBin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderBin").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderBin", value.AsString());
          }
       }
/// <summary>
/// PostEffects are processed in DESCENDING order of renderPriority if more than one has the same renderBin/Time. 
/// </summary>
[MemberGroup("")]
public float renderPriority
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderPriority").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderPriority", value.AsString());
          }
       }
/// <summary>
/// When to process this effect during the frame. 
/// </summary>
[MemberGroup("")]
public TypePFXRenderTime renderTime
       {
       get
          {          return (TypePFXRenderTime) Omni.self.GetVar(_ID + ".renderTime");
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderTime", value.ToString());
          }
       }
/// <summary>
/// Name of a GFXShaderData for this effect. 
/// </summary>
[MemberGroup("")]
public String shader
       {
       get
          {
          return Omni.self.GetVar(_ID + ".shader").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".shader", value.AsString());
          }
       }
/// <summary>
/// Skip processing of this PostEffect and its children even if its parent    is enabled. Parent and sibling PostEffects in the chain are still processed. 
/// </summary>
[MemberGroup("")]
public bool skip
       {
       get
          {
          return Omni.self.GetVar(_ID + ".skip").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".skip", value.AsString());
          }
       }
/// <summary>
/// Name of a GFXStateBlockData for this effect. 
/// </summary>
[MemberGroup("")]
public GFXStateBlockData stateBlock
       {
       get
          {
          return Omni.self.GetVar(_ID + ".stateBlock");
          }
       set
          {
          Omni.self.SetVar(_ID + ".stateBlock", value.ToString());
          }
       }
/// <summary>
/// String identifier of this effect's target texture.\n   @see PFXTextureIdentifiers 
/// </summary>
[MemberGroup("")]
public String target
       {
       get
          {
          return Omni.self.GetVar(_ID + ".target").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".target", value.AsString());
          }
       }
/// <summary>
/// Describes when the target texture should be cleared. 
/// </summary>
[MemberGroup("")]
public TypePFXTargetClear targetClear
       {
       get
          {          return (TypePFXTargetClear) Omni.self.GetVar(_ID + ".targetClear");
          }
       set
          {
          Omni.self.SetVar(_ID + ".targetClear", value.ToString());
          }
       }
/// <summary>
/// Color to which the target texture is cleared before rendering. 
/// </summary>
[MemberGroup("")]
public ColorF targetClearColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".targetClearColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".targetClearColor", value.AsString());
          }
       }
/// <summary>
/// Optional string identifier for this effect's target depth/stencil texture.\n   @see PFXTextureIdentifiers 
/// </summary>
[MemberGroup("")]
public String targetDepthStencil
       {
       get
          {
          return Omni.self.GetVar(_ID + ".targetDepthStencil").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".targetDepthStencil", value.AsString());
          }
       }
/// <summary>
/// Format of the target texture, not applicable if writing to the backbuffer. 
/// </summary>
[MemberGroup("")]
public TypeGFXFormat targetFormat
       {
       get
          {          return (TypeGFXFormat) Omni.self.GetVar(_ID + ".targetFormat");
          }
       set
          {
          Omni.self.SetVar(_ID + ".targetFormat", value.ToString());
          }
       }
/// <summary>
/// If targetSize is zero this is used to set a relative size from the current target. 
/// </summary>
[MemberGroup("")]
public Point2F targetScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".targetScale").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".targetScale", value.AsString());
          }
       }
/// <summary>
/// If non-zero this is used as the absolute target size. 
/// </summary>
[MemberGroup("")]
public Point2I targetSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".targetSize").AsPoint2I();
          }
       set
          {
          Omni.self.SetVar(_ID + ".targetSize", value.AsString());
          }
       }
/// <summary>
/// Specifies how the viewport should be set up for a target texture. 
/// </summary>
[MemberGroup("")]
public TypePFXTargetViewport targetViewport
       {
       get
          {          return (TypePFXTargetViewport) Omni.self.GetVar(_ID + ".targetViewport");
          }
       set
          {
          Omni.self.SetVar(_ID + ".targetViewport", value.ToString());
          }
       }
[MemberGroup("")]
public arrayObject<TypeImageFilename> texture;

#endregion
#region Member Functions
/// <summary>
/// Remove all shader macros. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearShaderMacros(){

pInvokes.m_ts.fnPostEffect_clearShaderMacros(_ID);
}
/// <summary>
/// Disables the effect. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void disable(){

pInvokes.m_ts.fnPostEffect_disable(_ID);
}
/// <summary>
/// Dumps this PostEffect shader's disassembly to a temporary text file.
///    @return Full path to the dumped file or an empty string if failed. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string dumpShaderDisassembly(){

return pInvokes.m_ts.fnPostEffect_dumpShaderDisassembly(_ID);
}
/// <summary>
/// Enables the effect. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void enable(){

pInvokes.m_ts.fnPostEffect_enable(_ID);
}
/// <summary>
/// @return Width over height of the backbuffer. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getAspectRatio(){

return pInvokes.m_ts.fnPostEffect_getAspectRatio(_ID);
}
/// <summary>
/// @return True if the effect is enabled. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isEnabledX(){

return pInvokes.m_ts.fnPostEffect_isEnabled(_ID);
}
/// <summary>
/// Reloads the effect shader and textures. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reload(){

pInvokes.m_ts.fnPostEffect_reload(_ID);
}
/// <summary>
/// Remove a shader macro. This will usually be called within the preProcess callback.
///    @param key Macro to remove. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeShaderMacro(string key){

pInvokes.m_ts.fnPostEffect_removeShaderMacro(_ID, key);
}
/// <summary>
/// Sets the value of a uniform defined in the shader. This will usually 
///    be called within the setShaderConsts callback. Array type constants are 
///    not supported.    
///    @param name Name of the constanst, prefixed with '$'. 
///    @param value Value to set, space seperate values with more than one element.
///    @tsexample
///    function MyPfx::setShaderConsts( %this )
///    {
///       // example float4 uniform
///       %this.setShaderConst( \"$colorMod\", \"1.0 0.9 1.0 1.0\" );
///       // example float1 uniform
///       %this.setShaderConst( \"$strength\", \"3.0\" );
///       // example integer uniform
///       %this.setShaderConst( \"$loops\", \"5\" );
///    }
///    @endtsexample )   
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setShaderConst(string name, string value){

pInvokes.m_ts.fnPostEffect_setShaderConst(_ID, name, value);
}
/// <summary>
///  ),
///    Adds a macro to the effect's shader or sets an existing one's value. 
///    This will usually be called within the onAdd or preProcess callback.
///    @param key lval of the macro.
///    @param value rval of the macro, or may be empty.
///    @tsexample
///    function MyPfx::onAdd( %this )
///    {
///       %this.setShaderMacro( \"NUM_SAMPLES\", \"10\" );
///       %this.setShaderMacro( \"HIGH_QUALITY_MODE\" );
///       
///       // In the shader looks like... 
///       // #define NUM_SAMPLES 10
///       // #define HIGH_QUALITY_MODE
///    }
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setShaderMacro(string key, string value = ""){

pInvokes.m_ts.fnPostEffect_setShaderMacro(_ID, key, value);
}
/// <summary>
/// This is used to set the texture file and load the texture on a running effect. 
///    If the texture file is not different from the current file nothing is changed.  If 
///    the texture cannot be found a null texture is assigned.    
///    @param index The texture stage index. 
///    @param filePath The file name of the texture to set. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTexture(int index, string filePath){

pInvokes.m_ts.fnPostEffect_setTexture(_ID, index, filePath);
}
/// <summary>
/// Toggles the effect between enabled / disabled.
///    @return True if effect is enabled. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool toggle(){

return pInvokes.m_ts.fnPostEffect_toggle(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when this object is first created and registered.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(){}

        /// <summary>
        /// Called when an effect is processed but before textures are bound. This    allows the user to change texture related paramaters or macros at runtime.   @tsexample      function SSAOPostFx::preProcess( %this )   {         if ( $SSAOPostFx::quality !$= %this.quality )      {         %this.quality = mClamp( mRound( $SSAOPostFx::quality ), 0, 2 )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void preProcess(){}

        /// <summary>
        /// Called immediate before processing this effect. This is the user's chance    to set the value of shader uniforms (constants).   @see setShaderConst)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void setShaderConsts(){}

        /// <summary>
        /// Called when this effect becomes enabled. If the user returns false from    this callback the effect will not be enabled.   @return True to allow this effect to be enabled.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  bool onEnabled(){return "0".AsBool();}

        /// <summary>
        /// Called when this effect becomes disabled.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDisabled(){}

#endregion
public PostEffect_Base (){texture = new arrayObject<TypeImageFilename>(6,"texture","TypeVariable",false,this);    
}
}}
