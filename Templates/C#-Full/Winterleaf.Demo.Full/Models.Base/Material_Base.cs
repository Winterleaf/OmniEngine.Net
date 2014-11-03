


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
    [TypeConverter(typeof(TypeConverterGeneric<Material_Base>))]
    public partial class Material_Base: BaseMaterialDefinition
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Material_Base ts, string simobjectid)
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
        public static bool operator !=(Material_Base ts, string simobjectid)
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
        public static implicit operator string( Material_Base ts)
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
        public static implicit operator Material_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Material_Base) Omni.self.getSimObject(simobjectid,typeof(Material_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Material_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Material_Base(int simobjectid)
            {
            return  (Material) Omni.self.getSimObject((uint)simobjectid,typeof(Material_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Material_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Material_Base(uint simobjectid)
            {
            return  (Material_Base) Omni.self.getSimObject(simobjectid,typeof(Material_Base));
            }
#endregion
#region Init Persists
[MemberGroup("")]
public arrayObject<float> accuCoverage;
[MemberGroup("")]
public arrayObject<float> accuDirection;
[MemberGroup("")]
public arrayObject<TypeImageFilename> accuMap;
[MemberGroup("")]
public arrayObject<float> accuScale;
[MemberGroup("")]
public arrayObject<float> accuSpecular;
[MemberGroup("")]
public arrayObject<float> accuStrength;
/// <summary>
/// The alpha reference value for alpha testing. Must be between 0 to 255.\n@see alphaTest\n 
/// </summary>
[MemberGroup("")]
public int alphaRef
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alphaRef").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaRef", value.AsString());
          }
       }
/// <summary>
/// Enables alpha test when rendering the material.\n@see alphaRef\n 
/// </summary>
[MemberGroup("")]
public bool alphaTest
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alphaTest").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaTest", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<TypeMaterialAnimType> animFlags;
/// <summary>
/// For backwards compatibility.\n@see diffuseMap\n 
/// </summary>
[MemberGroup("")]
public TypeImageFilename baseTex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".baseTex").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".baseTex", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<bool> bumpAtlas;
/// <summary>
/// For backwards compatibility.\n@see normalMap\n
/// </summary>
[MemberGroup("")]
public TypeImageFilename bumpTex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bumpTex").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bumpTex", value.AsString());
          }
       }
/// <summary>
/// If set to false the lighting system will not cast shadows from this material. 
/// </summary>
[MemberGroup("")]
public bool castShadows
       {
       get
          {
          return Omni.self.GetVar(_ID + ".castShadows").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".castShadows", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<Point2I> cellIndex;
[MemberGroup("")]
public arrayObject<Point2I> cellLayout;
[MemberGroup("")]
public arrayObject<int> cellSize;
/// <summary>
/// For backwards compatibility.\n@see diffuseColor\n
/// </summary>
[MemberGroup("")]
public ColorF colorMultiply
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colorMultiply").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorMultiply", value.AsString());
          }
       }
/// <summary>
/// The name of a CubemapData for environment mapping. 
/// </summary>
[MemberGroup("")]
public String cubemap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cubemap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cubemap", value.AsString());
          }
       }
/// <summary>
/// The sound to play when the player walks over the material. If this is set, it overrides #footstepSoundId. This field is      useful for directly assigning custom footstep sounds to materials without having to rely on the PlayerData sound assignment.\n\n     @warn Be aware that materials are client-side objects. This means that the SFXTracks assigned to materials must be client-side, too. 
/// </summary>
[MemberGroup("Behavioral")]
public TypeSFXTrackName customFootstepSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".customFootstepSound").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".customFootstepSound", value.AsString());
          }
       }
/// <summary>
/// The sound to play when the player impacts on the surface with a velocity equal or greater than PlayerData::groundImpactMinSpeed.      If this is set, it overrides #impactSoundId. This field is useful for directly assigning custom impact sounds to materials      without having to rely on the PlayerData sound assignment.\n\n     @warn Be aware that materials are client-side objects. This means that the SFXTracks assigned to materials must be client-side, too. 
/// </summary>
[MemberGroup("Behavioral")]
public TypeSFXTrackName customImpactSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".customImpactSound").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".customImpactSound", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<TypeImageFilename> detailMap;
[MemberGroup("")]
public arrayObject<TypeImageFilename> detailNormalMap;
[MemberGroup("")]
public arrayObject<float> detailNormalMapStrength;
[MemberGroup("")]
public arrayObject<Point2F> detailScale;
/// <summary>
/// For backwards compatibility.\n@see detailMap\n
/// </summary>
[MemberGroup("")]
public TypeImageFilename detailTex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailTex").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailTex", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<ColorF> diffuseColor;
[MemberGroup("")]
public arrayObject<TypeImageFilename> diffuseMap;
/// <summary>
/// 
/// </summary>
[MemberGroup("Behavioral")]
public float directSoundOcclusion
       {
       get
          {
          return Omni.self.GetVar(_ID + ".directSoundOcclusion").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".directSoundOcclusion", value.AsString());
          }
       }
/// <summary>
/// Disables backface culling casing surfaces to be double sided.      Note that the lighting on the backside will be a mirror of the front      side of the surface. 
/// </summary>
[MemberGroup("")]
public bool doubleSided
       {
       get
          {
          return Omni.self.GetVar(_ID + ".doubleSided").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".doubleSided", value.AsString());
          }
       }
/// <summary>
/// Enables the material to use the dynamic cubemap from the ShapeBase object its applied to. 
/// </summary>
[MemberGroup("")]
public bool dynamicCubemap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dynamicCubemap").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dynamicCubemap", value.AsString());
          }
       }
[MemberGroup("Behavioral")]
public arrayObject<ColorF> effectColor;
[MemberGroup("")]
public arrayObject<bool> emissive;
[MemberGroup("")]
public arrayObject<TypeImageFilename> envMap;
/// <summary>
/// For backwards compatibility.\n@see envMap\n
/// </summary>
[MemberGroup("")]
public TypeImageFilename envTex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".envTex").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".envTex", value.AsString());
          }
       }
/// <summary>
/// What sound to play from the PlayerData sound list when the player walks over the material. -1 (default) to not play any sound.\n     \n     The IDs are:\n\n     - 0: PlayerData::FootSoftSound\n     - 1: PlayerData::FootHardSound\n     - 2: PlayerData::FootMetalSound\n     - 3: PlayerData::FootSnowSound\n     - 4: PlayerData::FootShallowSound\n     - 5: PlayerData::FootWadingSound\n     - 6: PlayerData::FootUnderwaterSound\n     - 7: PlayerData::FootBubblesSound\n     - 8: PlayerData::movingBubblesSound\n     - 9: PlayerData::waterBreathSound\n     - 10: PlayerData::impactSoftSound\n     - 11: PlayerData::impactHardSound\n     - 12: PlayerData::impactMetalSound\n     - 13: PlayerData::impactSnowSound\n     - 14: PlayerData::impactWaterEasy\n     - 15: PlayerData::impactWaterMedium\n     - 16: PlayerData::impactWaterHard\n     - 17: PlayerData::exitingWater\n 
/// </summary>
[MemberGroup("Behavioral")]
public int footstepSoundId
       {
       get
          {
          return Omni.self.GetVar(_ID + ".footstepSoundId").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".footstepSoundId", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Behavioral")]
public float friction
       {
       get
          {
          return Omni.self.GetVar(_ID + ".friction").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".friction", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<bool> glow;
/// <summary>
/// What sound to play from the PlayerData sound list when the player impacts on the surface with a velocity equal or greater      than PlayerData::groundImpactMinSpeed.\n\n     For a list of IDs, see #footstepSoundId 
/// </summary>
[MemberGroup("Behavioral")]
public int impactSoundId
       {
       get
          {
          return Omni.self.GetVar(_ID + ".impactSoundId").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".impactSoundId", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<TypeImageFilename> lightMap;
/// <summary>
/// Used to map this material to the material name used by TSShape. 
/// </summary>
[MemberGroup("")]
public String mapTo
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mapTo").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mapTo", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<float> minnaertConstant;
[MemberGroup("")]
public arrayObject<TypeImageFilename> normalMap;
[MemberGroup("")]
public arrayObject<TypeImageFilename> overlayMap;
/// <summary>
/// For backwards compatibility.\n@see overlayMap\n
/// </summary>
[MemberGroup("")]
public TypeImageFilename overlayTex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".overlayTex").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".overlayTex", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<float> parallaxScale;
[MemberGroup("")]
public arrayObject<bool> pixelSpecular;
/// <summary>
/// @internal 
/// </summary>
[MemberGroup("")]
public bool planarReflection
       {
       get
          {
          return Omni.self.GetVar(_ID + ".planarReflection").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".planarReflection", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Behavioral")]
public float reverbSoundOcclusion
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reverbSoundOcclusion").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reverbSoundOcclusion", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<Point2F> rotPivotOffset;
[MemberGroup("")]
public arrayObject<float> rotSpeed;
[MemberGroup("")]
public arrayObject<Point2F> scrollDir;
[MemberGroup("")]
public arrayObject<float> scrollSpeed;
[MemberGroup("")]
public arrayObject<float> sequenceFramePerSec;
[MemberGroup("")]
public arrayObject<float> sequenceSegmentSize;
/// <summary>
/// Whether to emit dust particles from a shape moving over the material. This is, for example, used by      vehicles or players to decide whether to show dust trails. 
/// </summary>
[MemberGroup("Behavioral")]
public bool showDust
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showDust").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showDust", value.AsString());
          }
       }
/// <summary>
/// Whether to show player footprint decals on this material.\n\n     @see PlayerData::decalData 
/// </summary>
[MemberGroup("Behavioral")]
public bool showFootprints
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showFootprints").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showFootprints", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<ColorF> specular;
[MemberGroup("")]
public arrayObject<TypeImageFilename> specularMap;
[MemberGroup("")]
public arrayObject<float> specularPower;
[MemberGroup("")]
public arrayObject<float> specularStrength;
[MemberGroup("")]
public arrayObject<bool> subSurface;
[MemberGroup("")]
public arrayObject<ColorF> subSurfaceColor;
[MemberGroup("")]
public arrayObject<float> subSurfaceRolloff;
[MemberGroup("")]
public arrayObject<TypeImageFilename> toneMap;
/// <summary>
/// If true this material is translucent blended. 
/// </summary>
[MemberGroup("")]
public bool translucent
       {
       get
          {
          return Omni.self.GetVar(_ID + ".translucent").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".translucent", value.AsString());
          }
       }
/// <summary>
/// The type of blend operation to use when the material is translucent. 
/// </summary>
[MemberGroup("")]
public TypeMaterialBlendOp translucentBlendOp
       {
       get
          {          return (TypeMaterialBlendOp) Omni.self.GetVar(_ID + ".translucentBlendOp");
          }
       set
          {
          Omni.self.SetVar(_ID + ".translucentBlendOp", value.ToString());
          }
       }
/// <summary>
/// If enabled and the material is translucent it will write into the depth buffer. 
/// </summary>
[MemberGroup("")]
public bool translucentZWrite
       {
       get
          {
          return Omni.self.GetVar(_ID + ".translucentZWrite").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".translucentZWrite", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<bool> useAnisotropic;
[MemberGroup("")]
public arrayObject<bool> vertColor;
[MemberGroup("")]
public arrayObject<bool> vertLit;
[MemberGroup("")]
public arrayObject<float> waveAmp;
[MemberGroup("")]
public arrayObject<float> waveFreq;
[MemberGroup("")]
public arrayObject<TypeMaterialWaveType> waveType;

#endregion
#region Member Functions
/// <summary>
/// Dumps a formatted list of the currently allocated material instances for this material to the console. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void dumpInstances(){

pInvokes.m_ts.fn_Material_dumpInstances(_ID);
}
/// <summary>
/// Flushes all material instances that use this material. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void flush(){

pInvokes.m_ts.fn_Material_flush(_ID);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getAnimFlags(uint id){

return pInvokes.m_ts.fn_Material_getAnimFlags(_ID, id);
}
/// <summary>
/// Get filename of material)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  string getFilename(){

return pInvokes.m_ts.fn_Material_getFilename(_ID);
}
/// <summary>
/// Returns true if this Material was automatically generated by MaterialList::mapMaterials() )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isAutoGenerated(){

return pInvokes.m_ts.fn_Material_isAutoGenerated(_ID);
}
/// <summary>
/// Reloads all material instances that use this material. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reload(){

pInvokes.m_ts.fn_Material_reload(_ID);
}
/// <summary>
/// setAutoGenerated(bool isAutoGenerated): Set whether or not the Material is autogenerated. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAutoGenerated(bool isAutoGenerated){

pInvokes.m_ts.fn_Material_setAutoGenerated(_ID, isAutoGenerated);
}

#endregion
#region T3D Callbacks

#endregion
public Material_Base (){accuCoverage = new arrayObject<float>(4,"accuCoverage","TypeVariable",false,this);    
accuDirection = new arrayObject<float>(4,"accuDirection","TypeVariable",false,this);    
accuMap = new arrayObject<TypeImageFilename>(4,"accuMap","TypeVariable",false,this);    
accuScale = new arrayObject<float>(4,"accuScale","TypeVariable",false,this);    
accuSpecular = new arrayObject<float>(4,"accuSpecular","TypeVariable",false,this);    
accuStrength = new arrayObject<float>(4,"accuStrength","TypeVariable",false,this);    
animFlags = new arrayObject<TypeMaterialAnimType>(4,"animFlags","TypeEnumeration",false,this);    
bumpAtlas = new arrayObject<bool>(4,"bumpAtlas","TypeVariable",false,this);    
cellIndex = new arrayObject<Point2I>(4,"cellIndex","TypeVariable",false,this);    
cellLayout = new arrayObject<Point2I>(4,"cellLayout","TypeVariable",false,this);    
cellSize = new arrayObject<int>(4,"cellSize","TypeVariable",false,this);    
detailMap = new arrayObject<TypeImageFilename>(4,"detailMap","TypeVariable",false,this);    
detailNormalMap = new arrayObject<TypeImageFilename>(4,"detailNormalMap","TypeVariable",false,this);    
detailNormalMapStrength = new arrayObject<float>(4,"detailNormalMapStrength","TypeVariable",false,this);    
detailScale = new arrayObject<Point2F>(4,"detailScale","TypeVariable",false,this);    
diffuseColor = new arrayObject<ColorF>(4,"diffuseColor","TypeVariable",false,this);    
diffuseMap = new arrayObject<TypeImageFilename>(4,"diffuseMap","TypeVariable",false,this);    
effectColor = new arrayObject<ColorF>(2,"effectColor","TypeVariable",false,this);    
emissive = new arrayObject<bool>(4,"emissive","TypeVariable",false,this);    
envMap = new arrayObject<TypeImageFilename>(4,"envMap","TypeVariable",false,this);    
glow = new arrayObject<bool>(4,"glow","TypeVariable",false,this);    
lightMap = new arrayObject<TypeImageFilename>(4,"lightMap","TypeVariable",false,this);    
minnaertConstant = new arrayObject<float>(4,"minnaertConstant","TypeVariable",false,this);    
normalMap = new arrayObject<TypeImageFilename>(4,"normalMap","TypeVariable",false,this);    
overlayMap = new arrayObject<TypeImageFilename>(4,"overlayMap","TypeVariable",false,this);    
parallaxScale = new arrayObject<float>(4,"parallaxScale","TypeVariable",false,this);    
pixelSpecular = new arrayObject<bool>(4,"pixelSpecular","TypeVariable",false,this);    
rotPivotOffset = new arrayObject<Point2F>(4,"rotPivotOffset","TypeVariable",false,this);    
rotSpeed = new arrayObject<float>(4,"rotSpeed","TypeVariable",false,this);    
scrollDir = new arrayObject<Point2F>(4,"scrollDir","TypeVariable",false,this);    
scrollSpeed = new arrayObject<float>(4,"scrollSpeed","TypeVariable",false,this);    
sequenceFramePerSec = new arrayObject<float>(4,"sequenceFramePerSec","TypeVariable",false,this);    
sequenceSegmentSize = new arrayObject<float>(4,"sequenceSegmentSize","TypeVariable",false,this);    
specular = new arrayObject<ColorF>(4,"specular","TypeVariable",false,this);    
specularMap = new arrayObject<TypeImageFilename>(4,"specularMap","TypeVariable",false,this);    
specularPower = new arrayObject<float>(4,"specularPower","TypeVariable",false,this);    
specularStrength = new arrayObject<float>(4,"specularStrength","TypeVariable",false,this);    
subSurface = new arrayObject<bool>(4,"subSurface","TypeVariable",false,this);    
subSurfaceColor = new arrayObject<ColorF>(4,"subSurfaceColor","TypeVariable",false,this);    
subSurfaceRolloff = new arrayObject<float>(4,"subSurfaceRolloff","TypeVariable",false,this);    
toneMap = new arrayObject<TypeImageFilename>(4,"toneMap","TypeVariable",false,this);    
useAnisotropic = new arrayObject<bool>(4,"useAnisotropic","TypeVariable",false,this);    
vertColor = new arrayObject<bool>(4,"vertColor","TypeVariable",false,this);    
vertLit = new arrayObject<bool>(4,"vertLit","TypeVariable",false,this);    
waveAmp = new arrayObject<float>(4,"waveAmp","TypeVariable",false,this);    
waveFreq = new arrayObject<float>(4,"waveFreq","TypeVariable",false,this);    
waveType = new arrayObject<TypeMaterialWaveType>(4,"waveType","TypeEnumeration",false,this);    
}
}}
