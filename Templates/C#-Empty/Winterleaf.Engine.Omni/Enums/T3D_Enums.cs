

// Copyright (C) 2012 Winterleaf Entertainment L,L,C.

#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using WinterLeaf.Engine.Interfaces;
#endregion

namespace WinterLeaf.Engine.Enums
    {

/// <summary>
/// R__Camera__CameraMotionMode
/// </summary>
public enum  R__Camera__CameraMotionMode{
/// <summary>
/// 
/// </summary>

 StationaryMode = 0,
/// <summary>
/// 
/// </summary>


 FreeRotateMode,
/// <summary>
/// 
/// </summary>

 FlyMode,
/// <summary>
/// 
/// </summary>

 OrbitObjectMode,
/// <summary>
/// 
/// </summary>

 OrbitPointMode,
/// <summary>
/// 
/// </summary>

 TrackObjectMode,
/// <summary>
/// 
/// </summary>

 OverheadMode,
/// <summary>
/// 
/// </summary>

 EditOrbitMode,
/// <summary>
/// 
/// </summary>
 
 CameraFirstMode = 0,
/// <summary>
/// 
/// </summary>

 CameraLastMode = EditOrbitMode
 };

/// <summary>
/// R__ColladaUtils__ImportOptions__eLodType
/// </summary>
public enum  R__ColladaUtils__ImportOptions__eLodType{
/// <summary>
/// 
/// </summary>

 DetectDTS = 0,
/// <summary>
/// 
/// </summary>

 SingleSize,
/// <summary>
/// 
/// </summary>

 TrailingNumber,
/// <summary>
/// 
/// </summary>

 NumLodTypes
 };

/// <summary>
/// R__ConsoleLogEntry__Level
/// </summary>
public enum  R__ConsoleLogEntry__Level{
/// <summary>
/// 
/// </summary>

 Normal = 0,
/// <summary>
/// 
/// </summary>

 Warning,
/// <summary>
/// 
/// </summary>

 Error,
/// <summary>
/// 
/// </summary>

 NUM_CLASS
 };

/// <summary>
/// R__CoverPoint__Size
/// </summary>
public enum  R__CoverPoint__Size{
/// <summary>
/// 
/// </summary>

 Prone,
/// <summary>
/// 
/// </summary>

 Crouch,
/// <summary>
/// 
/// </summary>

 Stand,
/// <summary>
/// 
/// </summary>

 NumSizes
 };

/// <summary>
/// R__Docking__DockingType
/// </summary>
public enum  R__Docking__DockingType: uint {
/// <summary>
/// 
/// </summary>

 dockNone = 0x00000000,
/// <summary>
/// 
/// </summary>
 dockClient = 0x00000001,
/// <summary>
/// 
/// </summary>
 dockTop = 0x00000002,
/// <summary>
/// 
/// </summary>
 dockBottom = 0x00000004,
/// <summary>
/// 
/// </summary>
 dockLeft = 0x00000008,
/// <summary>
/// 
/// </summary>
 dockRight = 0x00000010,
/// <summary>
/// 
/// </summary>
 dockInvalid = 0x00000020,
/// <summary>
/// 
/// </summary>
 dockAny = dockClient | dockTop | dockBottom | dockLeft | dockRight
 };

/// <summary>
/// R__domUpAxisType
/// </summary>
public enum  R__domUpAxisType{
/// <summary>
/// 
/// </summary>

	UPAXISTYPE_X_UP,
/// <summary>
/// 
/// </summary>

	UPAXISTYPE_Y_UP,
/// <summary>
/// 
/// </summary>

	UPAXISTYPE_Z_UP,
/// <summary>
/// 
/// </summary>

	UPAXISTYPE_COUNT = 3
};

/// <summary>
/// R__FontCharset
/// </summary>
public enum  R__FontCharset{
/// <summary>
/// 
/// </summary>

 TGE_ANSI_CHARSET = 0,
/// <summary>
/// 
/// </summary>

 TGE_SYMBOL_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_SHIFTJIS_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_HANGEUL_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_HANGUL_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_GB2312_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_CHINESEBIG5_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_OEM_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_JOHAB_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_HEBREW_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_ARABIC_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_GREEK_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_TURKISH_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_VIETNAMESE_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_THAI_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_EASTEUROPE_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_RUSSIAN_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_MAC_CHARSET,
/// <summary>
/// 
/// </summary>

 TGE_BALTIC_CHARSET
};

/// <summary>
/// R__ForestBrushTool__BrushMode
/// </summary>
public enum  R__ForestBrushTool__BrushMode{
/// <summary>
/// 
/// </summary>

 Paint = 0,
/// <summary>
/// 
/// </summary>

 Erase,
/// <summary>
/// 
/// </summary>

 EraseSelected,
/// <summary>
/// 
/// </summary>

	 DropToGround
 };

/// <summary>
/// R__GFXAdapterType
/// </summary>
public enum  R__GFXAdapterType{
/// <summary>
/// 
/// </summary>

 OpenGL = 0,
/// <summary>
/// 
/// </summary>

 Direct3D9,
/// <summary>
/// 
/// </summary>

 Direct3D8,
/// <summary>
/// 
/// </summary>

 NullDevice,
/// <summary>
/// 
/// </summary>

 Direct3D9_360,
/// <summary>
/// 
/// </summary>

 GFXAdapterType_Count
};

/// <summary>
/// R__GFXBlend
/// </summary>
public enum  R__GFXBlend{
/// <summary>
/// 
/// </summary>

 GFXBlend_FIRST = 0,
/// <summary>
/// 
/// </summary>

 GFXBlendZero = 0,
/// <summary>
/// 
/// </summary>
 GFXBlendOne,
/// <summary>
/// 
/// </summary>
 GFXBlendSrcColor,
/// <summary>
/// 
/// </summary>
 GFXBlendInvSrcColor,
/// <summary>
/// 
/// </summary>
 GFXBlendSrcAlpha,
/// <summary>
/// 
/// </summary>
 GFXBlendInvSrcAlpha,
/// <summary>
/// 
/// </summary>
 GFXBlendDestAlpha,
/// <summary>
/// 
/// </summary>
 GFXBlendInvDestAlpha,
/// <summary>
/// 
/// </summary>
 GFXBlendDestColor,
/// <summary>
/// 
/// </summary>
 GFXBlendInvDestColor,
/// <summary>
/// 
/// </summary>
 GFXBlendSrcAlphaSat,
/// <summary>
/// 
/// </summary>
 GFXBlend_COUNT
};

/// <summary>
/// R__GFXBlendOp
/// </summary>
public enum  R__GFXBlendOp{
/// <summary>
/// 
/// </summary>
 
 GFXBlendOp_FIRST = 0,
/// <summary>
/// 
/// </summary>

 GFXBlendOpAdd = 0,
/// <summary>
/// 
/// </summary>

 GFXBlendOpSubtract,
/// <summary>
/// 
/// </summary>

 GFXBlendOpRevSubtract,
/// <summary>
/// 
/// </summary>

 GFXBlendOpMin,
/// <summary>
/// 
/// </summary>

 GFXBlendOpMax,
/// <summary>
/// 
/// </summary>

 GFXBlendOp_COUNT
};

/// <summary>
/// R__GFXCmpFunc
/// </summary>
public enum  R__GFXCmpFunc{
/// <summary>
/// 
/// </summary>

 GFXCmp_FIRST = 0,
/// <summary>
/// 
/// </summary>

 GFXCmpNever = 0,
/// <summary>
/// 
/// </summary>

 GFXCmpLess,
/// <summary>
/// 
/// </summary>

 GFXCmpEqual,
/// <summary>
/// 
/// </summary>

 GFXCmpLessEqual,
/// <summary>
/// 
/// </summary>

 GFXCmpGreater,
/// <summary>
/// 
/// </summary>

 GFXCmpNotEqual,
/// <summary>
/// 
/// </summary>

 GFXCmpGreaterEqual,
/// <summary>
/// 
/// </summary>

 GFXCmpAlways,
/// <summary>
/// 
/// </summary>

 GFXCmp_COUNT
};

/// <summary>
/// R__GFXCullMode
/// </summary>
public enum  R__GFXCullMode{
/// <summary>
/// 
/// </summary>

 GFXCull_FIRST = 0,
/// <summary>
/// 
/// </summary>

 GFXCullNone = 0,
/// <summary>
/// 
/// </summary>

 GFXCullCW,
/// <summary>
/// 
/// </summary>

 GFXCullCCW,
/// <summary>
/// 
/// </summary>

 GFXCull_COUNT
};

/// <summary>
/// R__GFXFormat
/// </summary>
public enum  R__GFXFormat{
/// <summary>
/// 
/// </summary>

 GFXFormat_FIRST = 0,
/// <summary>
/// 
/// </summary>


 GFXFormatA8 = 0,
/// <summary>
/// 
/// </summary>
 GFXFormatL8,
/// <summary>
/// 
/// </summary>

 GFXFormatA4L4,
/// <summary>
/// 
/// </summary>


 GFXFormatR5G6B5,
/// <summary>
/// 
/// </summary>
 GFXFormatR5G5B5A1,
/// <summary>
/// 
/// </summary>

 GFXFormatR5G5B5X1,
/// <summary>
/// 
/// </summary>

 GFXFormatA8L8,
/// <summary>
/// 
/// </summary>

 GFXFormatL16,
/// <summary>
/// 
/// </summary>

 GFXFormatR16F,
/// <summary>
/// 
/// </summary>

 GFXFormatD16,
/// <summary>
/// 
/// </summary>


 GFXFormatR8G8B8,
/// <summary>
/// 
/// </summary>

 GFXFormatR8G8B8A8,
/// <summary>
/// 
/// </summary>
 GFXFormatR8G8B8X8,
/// <summary>
/// 
/// </summary>

 GFXFormatR32F,
/// <summary>
/// 
/// </summary>

 GFXFormatR16G16,
/// <summary>
/// 
/// </summary>

 GFXFormatR16G16F,
/// <summary>
/// 
/// </summary>

 GFXFormatR10G10B10A2,
/// <summary>
/// 
/// </summary>

 GFXFormatD32,
/// <summary>
/// 
/// </summary>

 GFXFormatD24X8,
/// <summary>
/// 
/// </summary>

 GFXFormatD24S8,
/// <summary>
/// 
/// </summary>
 
 GFXFormatD24FS8,
/// <summary>
/// 
/// </summary>


 GFXFormatR16G16B16A16,
/// <summary>
/// 
/// </summary>
 GFXFormatR16G16B16A16F,
/// <summary>
/// 
/// </summary>


 GFXFormatR32G32B32A32F,
/// <summary>
/// 
/// </summary>

 GFXFormatDXT1,
/// <summary>
/// 
/// </summary>
 GFXFormatDXT2,
/// <summary>
/// 
/// </summary>

 GFXFormatDXT3,
/// <summary>
/// 
/// </summary>

 GFXFormatDXT4,
/// <summary>
/// 
/// </summary>

 GFXFormatDXT5,
/// <summary>
/// 
/// </summary>


 GFXFormat_COUNT,
/// <summary>
/// 
/// </summary>


 GFXFormat_8BIT = GFXFormatA8,
/// <summary>
/// 
/// </summary>

 GFXFormat_16BIT = GFXFormatR5G6B5,
/// <summary>
/// 
/// </summary>

 GFXFormat_24BIT = GFXFormatR8G8B8,
/// <summary>
/// 
/// </summary>

 GFXFormat_32BIT = GFXFormatR8G8B8A8,
/// <summary>
/// 
/// </summary>

 GFXFormat_64BIT = GFXFormatR16G16B16A16,
/// <summary>
/// 
/// </summary>

 GFXFormat_128BIT = GFXFormatR32G32B32A32F,
/// <summary>
/// 
/// </summary>

 GFXFormat_UNKNOWNSIZE = GFXFormatDXT1,
/// <summary>
/// 
/// </summary>

};

/// <summary>
/// R__GFXStencilOp
/// </summary>
public enum  R__GFXStencilOp{
/// <summary>
/// 
/// </summary>

 GFXStencilOp_FIRST = 0,
/// <summary>
/// 
/// </summary>

 GFXStencilOpKeep = 0,
/// <summary>
/// 
/// </summary>

 GFXStencilOpZero,
/// <summary>
/// 
/// </summary>

 GFXStencilOpReplace,
/// <summary>
/// 
/// </summary>

 GFXStencilOpIncrSat,
/// <summary>
/// 
/// </summary>

 GFXStencilOpDecrSat,
/// <summary>
/// 
/// </summary>

 GFXStencilOpInvert,
/// <summary>
/// 
/// </summary>

 GFXStencilOpIncr,
/// <summary>
/// 
/// </summary>

 GFXStencilOpDecr,
/// <summary>
/// 
/// </summary>

 GFXStencilOp_COUNT
};

/// <summary>
/// R__GFXTextureAddressMode
/// </summary>
public enum  R__GFXTextureAddressMode{
/// <summary>
/// 
/// </summary>

 GFXAddress_FIRST = 0,
/// <summary>
/// 
/// </summary>

 GFXAddressWrap = 0,
/// <summary>
/// 
/// </summary>

 GFXAddressMirror,
/// <summary>
/// 
/// </summary>

 GFXAddressClamp,
/// <summary>
/// 
/// </summary>

 GFXAddressBorder,
/// <summary>
/// 
/// </summary>

 GFXAddressMirrorOnce,
/// <summary>
/// 
/// </summary>

 GFXAddress_COUNT
};

/// <summary>
/// R__GFXTextureArgument
/// </summary>
public enum  R__GFXTextureArgument{
/// <summary>
/// 
/// </summary>

 GFXTA_FIRST = 0,
/// <summary>
/// 
/// </summary>

 GFXTADiffuse = 0,
/// <summary>
/// 
/// </summary>

 GFXTACurrent,
/// <summary>
/// 
/// </summary>

 GFXTATexture,
/// <summary>
/// 
/// </summary>

 GFXTATFactor,
/// <summary>
/// 
/// </summary>

 GFXTASpecular,
/// <summary>
/// 
/// </summary>

 GFXTATemp,
/// <summary>
/// 
/// </summary>

 GFXTAConstant,
/// <summary>
/// 
/// </summary>

 GFXTA_COUNT,
/// <summary>
/// 
/// </summary>

 GFXTAComplement = 0x00000010,
/// <summary>
/// 
/// </summary>
 GFXTAAlphaReplicate = 0x00000020,
/// <summary>
/// 
/// </summary>
 };

/// <summary>
/// R__GFXTextureFilterType
/// </summary>
public enum  R__GFXTextureFilterType{
/// <summary>
/// 
/// </summary>

 GFXTextureFilter_FIRST = 0,
/// <summary>
/// 
/// </summary>

 GFXTextureFilterNone = 0,
/// <summary>
/// 
/// </summary>

 GFXTextureFilterPoint,
/// <summary>
/// 
/// </summary>

 GFXTextureFilterLinear,
/// <summary>
/// 
/// </summary>

 GFXTextureFilterAnisotropic,
/// <summary>
/// 
/// </summary>

 GFXTextureFilterPyramidalQuad,
/// <summary>
/// 
/// </summary>

 GFXTextureFilterGaussianQuad,
/// <summary>
/// 
/// </summary>

 GFXTextureFilter_COUNT
};

/// <summary>
/// R__GFXTextureOp
/// </summary>
public enum  R__GFXTextureOp{
/// <summary>
/// 
/// </summary>

 GFXTOP_FIRST = 0,
/// <summary>
/// 
/// </summary>

 GFXTOPDisable = 0,
/// <summary>
/// 
/// </summary>

 GFXTOPSelectARG1,
/// <summary>
/// 
/// </summary>

 GFXTOPSelectARG2,
/// <summary>
/// 
/// </summary>

 GFXTOPModulate,
/// <summary>
/// 
/// </summary>

 GFXTOPModulate2X,
/// <summary>
/// 
/// </summary>

 GFXTOPModulate4X,
/// <summary>
/// 
/// </summary>

 GFXTOPAdd,
/// <summary>
/// 
/// </summary>

 GFXTOPAddSigned,
/// <summary>
/// 
/// </summary>

 GFXTOPAddSigned2X,
/// <summary>
/// 
/// </summary>

 GFXTOPSubtract,
/// <summary>
/// 
/// </summary>

 GFXTOPAddSmooth,
/// <summary>
/// 
/// </summary>
 
 GFXTOPBlendDiffuseAlpha,
/// <summary>
/// 
/// </summary>

 GFXTOPBlendTextureAlpha,
/// <summary>
/// 
/// </summary>

 GFXTOPBlendFactorAlpha,
/// <summary>
/// 
/// </summary>

 GFXTOPBlendTextureAlphaPM,
/// <summary>
/// 
/// </summary>

 GFXTOPBlendCURRENTALPHA,
/// <summary>
/// 
/// </summary>

 GFXTOPPreModulate,
/// <summary>
/// 
/// </summary>

 GFXTOPModulateAlphaAddColor,
/// <summary>
/// 
/// </summary>

 GFXTOPModulateColorAddAlpha,
/// <summary>
/// 
/// </summary>

 GFXTOPModulateInvAlphaAddColor,
/// <summary>
/// 
/// </summary>

 GFXTOPModulateInvColorAddAlpha,
/// <summary>
/// 
/// </summary>

 GFXTOPBumpEnvMap,
/// <summary>
/// 
/// </summary>

 GFXTOPBumpEnvMapLuminance,
/// <summary>
/// 
/// </summary>

 GFXTOPDotProduct3,
/// <summary>
/// 
/// </summary>

 GFXTOPLERP,
/// <summary>
/// 
/// </summary>

 GFXTOP_COUNT
};

/// <summary>
/// R__GFXTextureTransformFlags
/// </summary>
public enum  R__GFXTextureTransformFlags{
/// <summary>
/// 
/// </summary>

 GFXTTFFDisable = 0,
/// <summary>
/// 
/// </summary>

 GFXTTFFCoord1D = 1,
/// <summary>
/// 
/// </summary>

 GFXTTFFCoord2D = 2,
/// <summary>
/// 
/// </summary>

 GFXTTFFCoord3D = 3,
/// <summary>
/// 
/// </summary>

 GFXTTFFCoord4D = 4,
/// <summary>
/// 
/// </summary>

 GFXTTFFProjected = 256,
/// <summary>
/// 
/// </summary>

};

/// <summary>
/// R__GizmoAlignment
/// </summary>
public enum  R__GizmoAlignment{
/// <summary>
/// 
/// </summary>

 World = 0,
/// <summary>
/// 
/// </summary>

 Object,
/// <summary>
/// 
/// </summary>

 AlignEnumCount
};

/// <summary>
/// R__GizmoMode
/// </summary>
public enum  R__GizmoMode{
/// <summary>
/// 
/// </summary>

 NoneMode = 0,
/// <summary>
/// 
/// </summary>

 MoveMode,
/// <summary>
/// 
/// </summary>
 RotateMode,
/// <summary>
/// 
/// </summary>
 ScaleMode,
/// <summary>
/// 
/// </summary>
 ModeEnumCount 
};

/// <summary>
/// R__GuiAutoScrollCtrl__Direction
/// </summary>
public enum  R__GuiAutoScrollCtrl__Direction{
/// <summary>
/// 
/// </summary>

 Up,
/// <summary>
/// 
/// </summary>

 Down,
/// <summary>
/// 
/// </summary>

 Left,
/// <summary>
/// 
/// </summary>

 Right
 };

/// <summary>
/// R__GuiBitmapButtonCtrl__BitmapMode
/// </summary>
public enum  R__GuiBitmapButtonCtrl__BitmapMode{
/// <summary>
/// 
/// </summary>

 BitmapStretched,
/// <summary>
/// 
/// </summary>

 BitmapCentered,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__GuiButtonBaseCtrl__ButtonType
/// </summary>
public enum  R__GuiButtonBaseCtrl__ButtonType{
/// <summary>
/// 
/// </summary>

 ButtonTypePush,
/// <summary>
/// 
/// </summary>

 ButtonTypeCheck,
/// <summary>
/// 
/// </summary>

 ButtonTypeRadio,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__GuiColorPickerCtrl__PickMode
/// </summary>
public enum  R__GuiColorPickerCtrl__PickMode{
/// <summary>
/// 
/// </summary>

 pPallet = 0,
/// <summary>
/// 
/// </summary>
		 pHorizColorRange,
/// <summary>
/// 
/// </summary>
		 pVertColorRange,
/// <summary>
/// 
/// </summary>
		 pHorizColorBrightnessRange,
/// <summary>
/// 
/// </summary>
 pVertColorBrightnessRange,
/// <summary>
/// 
/// </summary>
 pBlendColorRange,
/// <summary>
/// 
/// </summary>
		 pHorizAlphaRange,
/// <summary>
/// 
/// </summary>
		 pVertAlphaRange,
/// <summary>
/// 
/// </summary>
		 pDropperBackground		 };

/// <summary>
/// R__GuiControl__horizSizingOptions
/// </summary>
public enum  R__GuiControl__horizSizingOptions{
/// <summary>
/// 
/// </summary>

 horizResizeRight = 0,
/// <summary>
/// 
/// </summary>
 horizResizeWidth,
/// <summary>
/// 
/// </summary>
 horizResizeLeft,
/// <summary>
/// 
/// </summary>
 horizResizeCenter,
/// <summary>
/// 
/// </summary>

 horizResizeRelative,
/// <summary>
/// 
/// </summary>
 horizResizeWindowRelative };

/// <summary>
/// R__GuiControl__vertSizingOptions
/// </summary>
public enum  R__GuiControl__vertSizingOptions{
/// <summary>
/// 
/// </summary>

 vertResizeBottom = 0,
/// <summary>
/// 
/// </summary>
 vertResizeHeight,
/// <summary>
/// 
/// </summary>
 vertResizeTop,
/// <summary>
/// 
/// </summary>
 vertResizeCenter,
/// <summary>
/// 
/// </summary>

 vertResizeRelative,
/// <summary>
/// 
/// </summary>
 vertResizeWindowRelative };

/// <summary>
/// R__GuiControlProfile__AlignmentType
/// </summary>
public enum  R__GuiControlProfile__AlignmentType{
/// <summary>
/// 
/// </summary>

 LeftJustify,
/// <summary>
/// 
/// </summary>

 RightJustify,
/// <summary>
/// 
/// </summary>

 CenterJustify,
/// <summary>
/// 
/// </summary>

 TopJustify,
/// <summary>
/// 
/// </summary>

 BottomJustify
 };

/// <summary>
/// R__GuiFrameSetCtrl__FrameState
/// </summary>
public enum  R__GuiFrameSetCtrl__FrameState{
/// <summary>
/// 
/// </summary>

 FRAME_STATE_ON,
/// <summary>
/// 
/// </summary>
 FRAME_STATE_OFF,
/// <summary>
/// 
/// </summary>
 FRAME_STATE_AUTO,
/// <summary>
/// 
/// </summary>
 
 NO_HIT = -1,
/// <summary>
/// 
/// </summary>


 DEFAULT_BORDER_WIDTH = 4,
/// <summary>
/// 
/// </summary>

 DEFAULT_COLUMNS = 1,
/// <summary>
/// 
/// </summary>

 DEFAULT_ROWS = 1,
/// <summary>
/// 
/// </summary>

 DEFAULT_MIN_FRAME_EXTENT = 64
 };

/// <summary>
/// R__GuiGradientCtrl__PickMode
/// </summary>
public enum  R__GuiGradientCtrl__PickMode{
/// <summary>
/// 
/// </summary>

		pHorizColorRange,
/// <summary>
/// 
/// </summary>
				pHorizAlphaRange,
/// <summary>
/// 
/// </summary>
		 };

/// <summary>
/// R__GuiGraphCtrl__GraphType
/// </summary>
public enum  R__GuiGraphCtrl__GraphType{
/// <summary>
/// 
/// </summary>

 Point,
/// <summary>
/// 
/// </summary>

 Polyline,
/// <summary>
/// 
/// </summary>

 Filled,
/// <summary>
/// 
/// </summary>

 Bar
 };

/// <summary>
/// R__GuiIconButtonCtrl__IconLocation
/// </summary>
public enum  R__GuiIconButtonCtrl__IconLocation{
/// <summary>
/// 
/// </summary>

 IconLocNone,
/// <summary>
/// 
/// </summary>

 IconLocLeft,
/// <summary>
/// 
/// </summary>

 IconLocRight,
/// <summary>
/// 
/// </summary>

 IconLocCenter 
 };

/// <summary>
/// R__GuiIconButtonCtrl__TextLocation
/// </summary>
public enum  R__GuiIconButtonCtrl__TextLocation{
/// <summary>
/// 
/// </summary>

 TextLocNone,
/// <summary>
/// 
/// </summary>

 TextLocBottom,
/// <summary>
/// 
/// </summary>

 TextLocRight,
/// <summary>
/// 
/// </summary>

 TextLocTop,
/// <summary>
/// 
/// </summary>

 TextLocLeft,
/// <summary>
/// 
/// </summary>

 TextLocCenter,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__GuiParticleGraphCtrl__GraphType
/// </summary>
public enum  R__GuiParticleGraphCtrl__GraphType{
/// <summary>
/// 
/// </summary>

 Point,
/// <summary>
/// 
/// </summary>

 Polyline,
/// <summary>
/// 
/// </summary>

 Filled,
/// <summary>
/// 
/// </summary>

 Bar
 };

/// <summary>
/// R__GuiScrollCtrl__ScrollBarBehavior
/// </summary>
public enum  R__GuiScrollCtrl__ScrollBarBehavior{
/// <summary>
/// 
/// </summary>

 ScrollBarAlwaysOn = 0,
/// <summary>
/// 
/// </summary>

 ScrollBarAlwaysOff = 1,
/// <summary>
/// 
/// </summary>

 ScrollBarDynamic = 2
 };

/// <summary>
/// R__GuiSeparatorCtrl__separatorTypeOptions
/// </summary>
public enum  R__GuiSeparatorCtrl__separatorTypeOptions{
/// <summary>
/// 
/// </summary>

 separatorTypeVertical = 0,
/// <summary>
/// 
/// </summary>
 separatorTypeHorizontal };

/// <summary>
/// R__GuiSplitContainer__FixedPanel
/// </summary>
public enum  R__GuiSplitContainer__FixedPanel{
/// <summary>
/// 
/// </summary>

 None = 0,
/// <summary>
/// 
/// </summary>

 FirstPanel = 1,
/// <summary>
/// 
/// </summary>

 SecondPanel
 };

/// <summary>
/// R__GuiSplitContainer__Orientation
/// </summary>
public enum  R__GuiSplitContainer__Orientation{
/// <summary>
/// 
/// </summary>

 Vertical = 0,
/// <summary>
/// 
/// </summary>

 Horizontal = 1
 };

/// <summary>
/// R__GuiStackControl__HorizontalType
/// </summary>
public enum  R__GuiStackControl__HorizontalType{
/// <summary>
/// 
/// </summary>

 horizStackLeft = 0,
/// <summary>
/// 
/// </summary>
 horizStackRight,
/// <summary>
/// 
/// </summary>
 };

/// <summary>
/// R__GuiStackControl__StackingType
/// </summary>
public enum  R__GuiStackControl__StackingType{
/// <summary>
/// 
/// </summary>

 stackingTypeVert,
/// <summary>
/// 
/// </summary>
 stackingTypeHoriz,
/// <summary>
/// 
/// </summary>
 stackingTypeDyn };

/// <summary>
/// R__GuiStackControl__VerticalType
/// </summary>
public enum  R__GuiStackControl__VerticalType{
/// <summary>
/// 
/// </summary>

 vertStackTop,
/// <summary>
/// 
/// </summary>
 vertStackBottom,
/// <summary>
/// 
/// </summary>
 };

/// <summary>
/// R__GuiTabBookCtrl__TabPosition
/// </summary>
public enum  R__GuiTabBookCtrl__TabPosition{
/// <summary>
/// 
/// </summary>

 AlignTop,
/// <summary>
/// 
/// </summary>
 AlignBottom,
/// <summary>
/// 
/// </summary>
 		 AlignRight	 };

/// <summary>
/// R__GuiTSCtrl__RenderStyles
/// </summary>
public enum  R__GuiTSCtrl__RenderStyles{
/// <summary>
/// 
/// </summary>

 RenderStyleStandard = 0,
/// <summary>
/// 
/// </summary>

 RenderStyleStereoSideBySide = (1<<0),
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__Item__LightType
/// </summary>
public enum  R__Item__LightType{
/// <summary>
/// 
/// </summary>

 NoLight = 0,
/// <summary>
/// 
/// </summary>

 ConstantLight,
/// <summary>
/// 
/// </summary>

 PulsingLight,
/// <summary>
/// 
/// </summary>


 NumLightTypes,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__Marker__KnotType
/// </summary>
public enum  R__Marker__KnotType{
/// <summary>
/// 
/// </summary>

 KnotTypeNormal,
/// <summary>
/// 
/// </summary>

 KnotTypePositionOnly,
/// <summary>
/// 
/// </summary>

 KnotTypeKink,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__Marker__SmoothingType
/// </summary>
public enum  R__Marker__SmoothingType{
/// <summary>
/// 
/// </summary>

 SmoothingTypeLinear,
/// <summary>
/// 
/// </summary>

 SmoothingTypeSpline,
/// <summary>
/// 
/// </summary>

 SmoothingTypeAccelerate,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__Material__AnimType
/// </summary>
public enum  R__Material__AnimType{
/// <summary>
/// 
/// </summary>

 Scroll = 1,
/// <summary>
/// 
/// </summary>

 Rotate = 2,
/// <summary>
/// 
/// </summary>

 Wave = 4,
/// <summary>
/// 
/// </summary>

 Scale = 8,
/// <summary>
/// 
/// </summary>

 Sequence = 16,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__Material__BlendOp
/// </summary>
public enum  R__Material__BlendOp{
/// <summary>
/// 
/// </summary>

 None = 0,
/// <summary>
/// 
/// </summary>

 Mul,
/// <summary>
/// 
/// </summary>

 Add,
/// <summary>
/// 
/// </summary>

 AddAlpha,
/// <summary>
/// 
/// </summary>
 Sub,
/// <summary>
/// 
/// </summary>

 LerpAlpha,
/// <summary>
/// 
/// </summary>
 ToneMap,
/// <summary>
/// 
/// </summary>

 NumBlendTypes
 };

/// <summary>
/// R__Material__WaveType
/// </summary>
public enum  R__Material__WaveType{
/// <summary>
/// 
/// </summary>

 Sin = 0,
/// <summary>
/// 
/// </summary>

 Triangle,
/// <summary>
/// 
/// </summary>

 Square,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__MBButtons
/// </summary>
public enum  R__MBButtons{
/// <summary>
/// 
/// </summary>

 MBOk = 0,
/// <summary>
/// 
/// </summary>

 MBOkCancel,
/// <summary>
/// 
/// </summary>

 MBRetryCancel,
/// <summary>
/// 
/// </summary>

 MBSaveDontSave,
/// <summary>
/// 
/// </summary>

 MBSaveDontSaveCancel,
/// <summary>
/// 
/// </summary>

};

/// <summary>
/// R__MBIcons
/// </summary>
public enum  R__MBIcons{
/// <summary>
/// 
/// </summary>

 MIWarning = 0,
/// <summary>
/// 
/// </summary>

 MIInformation,
/// <summary>
/// 
/// </summary>

 MIQuestion,
/// <summary>
/// 
/// </summary>

 MIStop,
/// <summary>
/// 
/// </summary>

};

/// <summary>
/// R__MBReturnVal
/// </summary>
public enum  R__MBReturnVal{
/// <summary>
/// 
/// </summary>

 MROk = 1,
/// <summary>
/// 
/// </summary>
 MRCancel,
/// <summary>
/// 
/// </summary>

 MRRetry,
/// <summary>
/// 
/// </summary>

 MRDontSave,
/// <summary>
/// 
/// </summary>

};

/// <summary>
/// R__NavMesh__WaterMethod
/// </summary>
public enum  R__NavMesh__WaterMethod{
/// <summary>
/// 
/// </summary>

 Ignore,
/// <summary>
/// 
/// </summary>

 Solid,
/// <summary>
/// 
/// </summary>

 Impassable
 };

/// <summary>
/// R__OggTheoraDecoder__ETranscoder
/// </summary>
public enum  R__OggTheoraDecoder__ETranscoder{
/// <summary>
/// 
/// </summary>

 TRANSCODER_Auto,
/// <summary>
/// 
/// </summary>
 TRANSCODER_Generic,
/// <summary>
/// 
/// </summary>
 TRANSCODER_SSE2420RGBA,
/// <summary>
/// 
/// </summary>
 };

/// <summary>
/// R__ParticleRenderInst__BlendStyle
/// </summary>
public enum  R__ParticleRenderInst__BlendStyle{
/// <summary>
/// 
/// </summary>

 BlendUndefined = 0,
/// <summary>
/// 
/// </summary>

 BlendNormal,
/// <summary>
/// 
/// </summary>

 BlendAdditive,
/// <summary>
/// 
/// </summary>

 BlendSubtractive,
/// <summary>
/// 
/// </summary>

 BlendPremultAlpha,
/// <summary>
/// 
/// </summary>

 BlendGreyscale,
/// <summary>
/// 
/// </summary>

 BlendStyle_COUNT,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__PFXRenderTime
/// </summary>
public enum  R__PFXRenderTime{
/// <summary>
/// 
/// </summary>

 PFXBeforeBin,
/// <summary>
/// 
/// </summary>


 PFXAfterBin,
/// <summary>
/// 
/// </summary>


 PFXAfterDiffuse,
/// <summary>
/// 
/// </summary>


 PFXEndOfFrame,
/// <summary>
/// 
/// </summary>


 PFXTexGenOnDemand
};

/// <summary>
/// R__PFXTargetClear
/// </summary>
public enum  R__PFXTargetClear{
/// <summary>
/// 
/// </summary>

 PFXTargetClear_None,
/// <summary>
/// 
/// </summary>


 PFXTargetClear_OnCreate,
/// <summary>
/// 
/// </summary>


 PFXTargetClear_OnDraw,
/// <summary>
/// 
/// </summary>

};

/// <summary>
/// R__PFXTargetViewport
/// </summary>
public enum  R__PFXTargetViewport{
/// <summary>
/// 
/// </summary>

 PFXTargetViewport_TargetSize,
/// <summary>
/// 
/// </summary>


 PFXTargetViewport_GFXViewport,
/// <summary>
/// 
/// </summary>


 PFXTargetViewport_NamedInTexture0,
/// <summary>
/// 
/// </summary>

};

/// <summary>
/// R__PhysicsShapeData__SimType
/// </summary>
public enum  R__PhysicsShapeData__SimType{
/// <summary>
/// 
/// </summary>

 SimType_ClientOnly,
/// <summary>
/// 
/// </summary>


 SimType_ServerOnly,
/// <summary>
/// 
/// </summary>


 SimType_ClientServer,
/// <summary>
/// 
/// </summary>


 SimType_Bits = 3,
/// <summary>
/// 
/// </summary>


 };

/// <summary>
/// R__Player__Pose
/// </summary>
public enum  R__Player__Pose{
/// <summary>
/// 
/// </summary>

 StandPose = 0,
/// <summary>
/// 
/// </summary>

 SprintPose,
/// <summary>
/// 
/// </summary>

 CrouchPose,
/// <summary>
/// 
/// </summary>

 PronePose,
/// <summary>
/// 
/// </summary>

 SwimPose,
/// <summary>
/// 
/// </summary>

 NumPoseBits = 3
 };

/// <summary>
/// R__RenderTexTargetBinManager__TargetSizeType
/// </summary>
public enum  R__RenderTexTargetBinManager__TargetSizeType{
/// <summary>
/// 
/// </summary>

 WindowSize = 0,
/// <summary>
/// 
/// </summary>

 WindowSizeScaled,
/// <summary>
/// 
/// </summary>

 FixedSize
 };

/// <summary>
/// R__SFXChannel
/// </summary>
public enum  R__SFXChannel{
/// <summary>
/// 
/// </summary>

 SFXChannelVolume,
/// <summary>
/// 
/// </summary>

 SFXChannelPitch,
/// <summary>
/// 
/// </summary>

 SFXChannelPriority,
/// <summary>
/// 
/// </summary>

 SFXChannelPositionX,
/// <summary>
/// 
/// </summary>

 SFXChannelPositionY,
/// <summary>
/// 
/// </summary>

 SFXChannelPositionZ,
/// <summary>
/// 
/// </summary>

 SFXChannelRotationX,
/// <summary>
/// 
/// </summary>

 SFXChannelRotationY,
/// <summary>
/// 
/// </summary>

 SFXChannelRotationZ,
/// <summary>
/// 
/// </summary>

 SFXChannelVelocityX,
/// <summary>
/// 
/// </summary>

 SFXChannelVelocityY,
/// <summary>
/// 
/// </summary>

 SFXChannelVelocityZ,
/// <summary>
/// 
/// </summary>

 SFXChannelMinDistance,
/// <summary>
/// 
/// </summary>

 SFXChannelMaxDistance,
/// <summary>
/// 
/// </summary>

 SFXChannelConeInsideAngle,
/// <summary>
/// 
/// </summary>

 SFXChannelConeOutsideAngle,
/// <summary>
/// 
/// </summary>

 SFXChannelConeOutsideVolume,
/// <summary>
/// 
/// </summary>

 SFXChannelCursor,
/// <summary>
/// 
/// </summary>

 SFXChannelStatus,
/// <summary>
/// 
/// </summary>

 SFXChannelUser0,
/// <summary>
/// 
/// </summary>

 SFXChannelUser1,
/// <summary>
/// 
/// </summary>

 SFXChannelUser2,
/// <summary>
/// 
/// </summary>

 SFXChannelUser3,
/// <summary>
/// 
/// </summary>

 
 SFX_NUM_CHANNELS
};

/// <summary>
/// R__SFXDistanceModel
/// </summary>
public enum  R__SFXDistanceModel{
/// <summary>
/// 
/// </summary>

 SFXDistanceModelLinear,
/// <summary>
/// 
/// </summary>
 SFXDistanceModelLogarithmic,
/// <summary>
/// 
/// </summary>
 };

/// <summary>
/// R__SFXPlayList__ELoopMode
/// </summary>
public enum  R__SFXPlayList__ELoopMode{
/// <summary>
/// 
/// </summary>

 LOOP_All,
/// <summary>
/// 
/// </summary>


 LOOP_Single,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__SFXPlayList__ERandomMode
/// </summary>
public enum  R__SFXPlayList__ERandomMode{
/// <summary>
/// 
/// </summary>

 RANDOM_NotRandom,
/// <summary>
/// 
/// </summary>

 
 RANDOM_StrictRandom,
/// <summary>
/// 
/// </summary>

 
 RANDOM_OrderedRandom,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__SFXPlayList__EReplayMode
/// </summary>
public enum  R__SFXPlayList__EReplayMode{
/// <summary>
/// 
/// </summary>

 REPLAY_IgnorePlaying,
/// <summary>
/// 
/// </summary>

 
 REPLAY_RestartPlaying,
/// <summary>
/// 
/// </summary>

 
 REPLAY_KeepPlaying,
/// <summary>
/// 
/// </summary>

 
 REPLAY_StartNew,
/// <summary>
/// 
/// </summary>


 REPLAY_SkipIfPlaying,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__SFXPlayList__EStateMode
/// </summary>
public enum  R__SFXPlayList__EStateMode{
/// <summary>
/// 
/// </summary>

 STATE_StopInactive,
/// <summary>
/// 
/// </summary>

 
 STATE_PauseInactive,
/// <summary>
/// 
/// </summary>

 
 STATE_IgnoreInactive,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__SFXPlayList__ETransitionMode
/// </summary>
public enum  R__SFXPlayList__ETransitionMode{
/// <summary>
/// 
/// </summary>

 TRANSITION_None,
/// <summary>
/// 
/// </summary>


 TRANSITION_Wait,
/// <summary>
/// 
/// </summary>

 
 TRANSITION_WaitAll,
/// <summary>
/// 
/// </summary>


 TRANSITION_Stop,
/// <summary>
/// 
/// </summary>

 
 TRANSITION_StopAll,
/// <summary>
/// 
/// </summary>

 };

/// <summary>
/// R__SFXStatus
/// </summary>
public enum  R__SFXStatus{
/// <summary>
/// 
/// </summary>

 SFXStatusNull,
/// <summary>
/// 
/// </summary>


 SFXStatusPlaying,
/// <summary>
/// 
/// </summary>


 SFXStatusStopped,
/// <summary>
/// 
/// </summary>


 SFXStatusPaused,
/// <summary>
/// 
/// </summary>


 SFXStatusBlocked,
/// <summary>
/// 
/// </summary>


 SFXStatusTransition,
/// <summary>
/// 
/// </summary>

};

/// <summary>
/// R__ShadowFilterMode
/// </summary>
public enum  R__ShadowFilterMode{
/// <summary>
/// 
/// </summary>

 ShadowFilterMode_None,
/// <summary>
/// 
/// </summary>

 ShadowFilterMode_SoftShadow,
/// <summary>
/// 
/// </summary>

 ShadowFilterMode_SoftShadowHighQuality
};

/// <summary>
/// R__ShadowType
/// </summary>
public enum  R__ShadowType{
/// <summary>
/// 
/// </summary>
 
 ShadowType_None = -1,
/// <summary>
/// 
/// </summary>


 ShadowType_Spot,
/// <summary>
/// 
/// </summary>

 ShadowType_PSSM,
/// <summary>
/// 
/// </summary>


 ShadowType_Paraboloid,
/// <summary>
/// 
/// </summary>

 ShadowType_DualParaboloidSinglePass,
/// <summary>
/// 
/// </summary>

 ShadowType_DualParaboloid,
/// <summary>
/// 
/// </summary>

 ShadowType_CubeMap,
/// <summary>
/// 
/// </summary>


 ShadowType_Count,
/// <summary>
/// 
/// </summary>

};

/// <summary>
/// R__ShapeBaseImageData__LightType
/// </summary>
public enum  R__ShapeBaseImageData__LightType{
/// <summary>
/// 
/// </summary>

 NoLight = 0,
/// <summary>
/// 
/// </summary>

 ConstantLight,
/// <summary>
/// 
/// </summary>

 SpotLight,
/// <summary>
/// 
/// </summary>

 PulsingLight,
/// <summary>
/// 
/// </summary>

 WeaponFireLight,
/// <summary>
/// 
/// </summary>

 NumLightTypes
 };

/// <summary>
/// R__ShapeBaseImageData__StateData__LoadedState
/// </summary>
public enum  R__ShapeBaseImageData__StateData__LoadedState{
/// <summary>
/// 
/// </summary>

 IgnoreLoaded,
/// <summary>
/// 
/// </summary>
 Loaded,
/// <summary>
/// 
/// </summary>
 NotLoaded,
/// <summary>
/// 
/// </summary>
 NumLoadedBits = 3 };

/// <summary>
/// R__ShapeBaseImageData__StateData__RecoilState
/// </summary>
public enum  R__ShapeBaseImageData__StateData__RecoilState{
/// <summary>
/// 
/// </summary>

 NoRecoil,
/// <summary>
/// 
/// </summary>

 LightRecoil,
/// <summary>
/// 
/// </summary>

 MediumRecoil,
/// <summary>
/// 
/// </summary>

 HeavyRecoil,
/// <summary>
/// 
/// </summary>

 NumRecoilBits = 3
 };

/// <summary>
/// R__ShapeBaseImageData__StateData__SpinState
/// </summary>
public enum  R__ShapeBaseImageData__StateData__SpinState{
/// <summary>
/// 
/// </summary>

 IgnoreSpin,
/// <summary>
/// 
/// </summary>
 NoSpin,
/// <summary>
/// 
/// </summary>
 SpinUp,
/// <summary>
/// 
/// </summary>
 SpinDown,
/// <summary>
/// 
/// </summary>
 FullSpin,
/// <summary>
/// 
/// </summary>
 NumSpinBits = 3 };

/// <summary>
/// R__TSPathShape__MoveState
/// </summary>
public enum  R__TSPathShape__MoveState{
/// <summary>
/// 
/// </summary>

 Forward,
/// <summary>
/// 
/// </summary>

 Backward,
/// <summary>
/// 
/// </summary>

 Stop
 };

/// <summary>
/// R__TSStatic__MeshType
/// </summary>
public enum  R__TSStatic__MeshType{
/// <summary>
/// 
/// </summary>

 None = 0,
/// <summary>
/// 
/// </summary>
 Bounds = 1,
/// <summary>
/// 
/// </summary>
 CollisionMesh = 2,
/// <summary>
/// 
/// </summary>
 VisibleMesh = 3 };

/// <summary>
/// R__TurretShapeData__FireLinkType
/// </summary>
public enum  R__TurretShapeData__FireLinkType{
/// <summary>
/// 
/// </summary>

 FireTogether,
/// <summary>
/// 
/// </summary>
 GroupedFire,
/// <summary>
/// 
/// </summary>
 IndividualFire,
/// <summary>
/// 
/// </summary>
 NumFireLinkTypeBits = 2
 };

/// <summary>
/// R__WorldEditor__AlignmentType
/// </summary>
public enum  R__WorldEditor__AlignmentType{
/// <summary>
/// 
/// </summary>

 AlignNone = 0,
/// <summary>
/// 
/// </summary>

 AlignPosX,
/// <summary>
/// 
/// </summary>

 AlignPosY,
/// <summary>
/// 
/// </summary>

 AlignPosZ,
/// <summary>
/// 
/// </summary>

 AlignNegX,
/// <summary>
/// 
/// </summary>

 AlignNegY,
/// <summary>
/// 
/// </summary>

 AlignNegZ
 };

/// <summary>
/// R__WorldEditor__DropType
/// </summary>
public enum  R__WorldEditor__DropType{
/// <summary>
/// 
/// </summary>

 DropAtOrigin = 0,
/// <summary>
/// 
/// </summary>

 DropAtCamera,
/// <summary>
/// 
/// </summary>

 DropAtCameraWithRot,
/// <summary>
/// 
/// </summary>

 DropBelowCamera,
/// <summary>
/// 
/// </summary>

 DropAtScreenCenter,
/// <summary>
/// 
/// </summary>

 DropAtCentroid,
/// <summary>
/// 
/// </summary>

 DropToTerrain,
/// <summary>
/// 
/// </summary>

 DropBelowSelection
 };

/// <summary>
/// TypeCameraMotionMode
/// </summary>

 public sealed class TypeCameraMotionMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeCameraMotionMode> mdict = new Dictionary<int, TypeCameraMotionMode>();
        static readonly Dictionary<string, TypeCameraMotionMode> msdict = new Dictionary<string, TypeCameraMotionMode>();

        public static implicit operator TypeCameraMotionMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeCameraMotionMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeCameraMotionMode(string s)
            {
            return msdict[s];
            }


        private TypeCameraMotionMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeCameraMotionMode Stationary = new TypeCameraMotionMode((int)R__Camera__CameraMotionMode.StationaryMode,"Stationary","Camera does not rotate or move.");
      public static readonly TypeCameraMotionMode FreeRotate = new TypeCameraMotionMode((int)R__Camera__CameraMotionMode.FreeRotateMode,"FreeRotate","Camera may rotate but does not move.");
      public static readonly TypeCameraMotionMode Fly = new TypeCameraMotionMode((int)R__Camera__CameraMotionMode.FlyMode,"Fly","Camera may rotate and move freely.");
      public static readonly TypeCameraMotionMode OrbitObject = new TypeCameraMotionMode((int)R__Camera__CameraMotionMode.OrbitObjectMode,"OrbitObject","Camera orbits about a given object.  Damage flash and white out is determined by the object being orbited.  See Camera::setOrbitMode() to set the orbit object and other parameters.");
      public static readonly TypeCameraMotionMode OrbitPoint = new TypeCameraMotionMode((int)R__Camera__CameraMotionMode.OrbitPointMode,"OrbitPoint","Camera orbits about a given point.  See Camera::setOrbitMode() to set the orbit point and other parameters.");
      public static readonly TypeCameraMotionMode TrackObject = new TypeCameraMotionMode((int)R__Camera__CameraMotionMode.TrackObjectMode,"TrackObject","Camera always faces a given object.  See Camera::setTrackObject() to set the object to track and a distance to remain from the object.");
      public static readonly TypeCameraMotionMode Overhead = new TypeCameraMotionMode((int)R__Camera__CameraMotionMode.OverheadMode,"Overhead","Camera moves in the XY plane.");
      public static readonly TypeCameraMotionMode EditOrbit = new TypeCameraMotionMode((int)R__Camera__CameraMotionMode.EditOrbitMode,"EditOrbit","Used by the World Editor to orbit about a point.  When first activated, the camera is rotated to face the orbit point rather than move to it.");
      };

/// <summary>
/// TypeCoverPointSize
/// </summary>

 public sealed class TypeCoverPointSize  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeCoverPointSize> mdict = new Dictionary<int, TypeCoverPointSize>();
        static readonly Dictionary<string, TypeCoverPointSize> msdict = new Dictionary<string, TypeCoverPointSize>();

        public static implicit operator TypeCoverPointSize(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeCoverPointSize t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeCoverPointSize(string s)
            {
            return msdict[s];
            }


        private TypeCoverPointSize(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeCoverPointSize Prone = new TypeCoverPointSize((int)R__CoverPoint__Size.Prone,"Prone","Only provides cover when prone. n");
      public static readonly TypeCoverPointSize Crouch = new TypeCoverPointSize((int)R__CoverPoint__Size.Crouch,"Crouch","Only provides cover when crouching. n");
      public static readonly TypeCoverPointSize Stand = new TypeCoverPointSize((int)R__CoverPoint__Size.Stand,"Stand","Provides cover when standing. n");
      };

/// <summary>
/// TypeForestBrushMode
/// </summary>

 public sealed class TypeForestBrushMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeForestBrushMode> mdict = new Dictionary<int, TypeForestBrushMode>();
        static readonly Dictionary<string, TypeForestBrushMode> msdict = new Dictionary<string, TypeForestBrushMode>();

        public static implicit operator TypeForestBrushMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeForestBrushMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeForestBrushMode(string s)
            {
            return msdict[s];
            }


        private TypeForestBrushMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeForestBrushMode Paint = new TypeForestBrushMode((int)R__ForestBrushTool__BrushMode.Paint,"Paint","Creates Items based on the Elements you have selected. n");
      public static readonly TypeForestBrushMode Erase = new TypeForestBrushMode((int)R__ForestBrushTool__BrushMode.Erase,"Erase","Erases Items of any Mesh type. n");
      public static readonly TypeForestBrushMode EraseSelected = new TypeForestBrushMode((int)R__ForestBrushTool__BrushMode.EraseSelected,"EraseSelected","Erases items of a specific type. n");
      public static readonly TypeForestBrushMode DropToGround = new TypeForestBrushMode((int)R__ForestBrushTool__BrushMode.DropToGround,"DropToGround","Drops items of a specific type to the ground.n");
      };

/// <summary>
/// TypeGFXAdapterType
/// </summary>

 public sealed class TypeGFXAdapterType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXAdapterType> mdict = new Dictionary<int, TypeGFXAdapterType>();
        static readonly Dictionary<string, TypeGFXAdapterType> msdict = new Dictionary<string, TypeGFXAdapterType>();

        public static implicit operator TypeGFXAdapterType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXAdapterType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXAdapterType(string s)
            {
            return msdict[s];
            }


        private TypeGFXAdapterType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXAdapterType OpenGL = new TypeGFXAdapterType((int)R__GFXAdapterType.OpenGL,"OpenGL","OpenGL.");
      public static readonly TypeGFXAdapterType D3D8 = new TypeGFXAdapterType((int)R__GFXAdapterType.Direct3D8,"D3D8","Direct3D 8.");
      public static readonly TypeGFXAdapterType D3D9 = new TypeGFXAdapterType((int)R__GFXAdapterType.Direct3D9,"D3D9","Direct3D 9.");
      public static readonly TypeGFXAdapterType NullDevice = new TypeGFXAdapterType((int)R__GFXAdapterType.NullDevice,"NullDevice","Null device for dedicated servers.");
      public static readonly TypeGFXAdapterType Xenon = new TypeGFXAdapterType((int)R__GFXAdapterType.Direct3D9_360,"Xenon","Direct3D 9 on Xbox 360.");
      };

/// <summary>
/// TypeGFXBlend
/// </summary>

 public sealed class TypeGFXBlend  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXBlend> mdict = new Dictionary<int, TypeGFXBlend>();
        static readonly Dictionary<string, TypeGFXBlend> msdict = new Dictionary<string, TypeGFXBlend>();

        public static implicit operator TypeGFXBlend(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXBlend t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXBlend(string s)
            {
            return msdict[s];
            }


        private TypeGFXBlend(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXBlend GFXBlendZero = new TypeGFXBlend((int)R__GFXBlend.GFXBlendZero,"GFXBlendZero","(0, 0, 0, 0)");
      public static readonly TypeGFXBlend GFXBlendOne = new TypeGFXBlend((int)R__GFXBlend.GFXBlendOne,"GFXBlendOne","(1, 1, 1, 1)");
      public static readonly TypeGFXBlend GFXBlendSrcColor = new TypeGFXBlend((int)R__GFXBlend.GFXBlendSrcColor,"GFXBlendSrcColor","(Rs, Gs, Bs, As)");
      public static readonly TypeGFXBlend GFXBlendInvSrcColor = new TypeGFXBlend((int)R__GFXBlend.GFXBlendInvSrcColor,"GFXBlendInvSrcColor","(1 - Rs, 1 - Gs, 1 - Bs, 1 - As)");
      public static readonly TypeGFXBlend GFXBlendSrcAlpha = new TypeGFXBlend((int)R__GFXBlend.GFXBlendSrcAlpha,"GFXBlendSrcAlpha","(As, As, As, As)");
      public static readonly TypeGFXBlend GFXBlendInvSrcAlpha = new TypeGFXBlend((int)R__GFXBlend.GFXBlendInvSrcAlpha,"GFXBlendInvSrcAlpha","( 1 - As, 1 - As, 1 - As, 1 - As)");
      public static readonly TypeGFXBlend GFXBlendDestAlpha = new TypeGFXBlend((int)R__GFXBlend.GFXBlendDestAlpha,"GFXBlendDestAlpha","(Ad Ad Ad Ad)");
      public static readonly TypeGFXBlend GFXBlendInvDestAlpha = new TypeGFXBlend((int)R__GFXBlend.GFXBlendInvDestAlpha,"GFXBlendInvDestAlpha","(1 - Ad 1 - Ad 1 - Ad 1 - Ad)");
      public static readonly TypeGFXBlend GFXBlendDestColor = new TypeGFXBlend((int)R__GFXBlend.GFXBlendDestColor,"GFXBlendDestColor","(Rd, Gd, Bd, Ad)");
      public static readonly TypeGFXBlend GFXBlendInvDestColor = new TypeGFXBlend((int)R__GFXBlend.GFXBlendInvDestColor,"GFXBlendInvDestColor","(1 - Rd, 1 - Gd, 1 - Bd, 1 - Ad)");
      };

/// <summary>
/// TypeGFXBlendOp
/// </summary>

 public sealed class TypeGFXBlendOp  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXBlendOp> mdict = new Dictionary<int, TypeGFXBlendOp>();
        static readonly Dictionary<string, TypeGFXBlendOp> msdict = new Dictionary<string, TypeGFXBlendOp>();

        public static implicit operator TypeGFXBlendOp(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXBlendOp t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXBlendOp(string s)
            {
            return msdict[s];
            }


        private TypeGFXBlendOp(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXBlendOp GFXBlendOpAdd = new TypeGFXBlendOp((int)R__GFXBlendOp.GFXBlendOpAdd,"GFXBlendOpAdd","");
      public static readonly TypeGFXBlendOp GFXBlendOpSubtract = new TypeGFXBlendOp((int)R__GFXBlendOp.GFXBlendOpSubtract,"GFXBlendOpSubtract","");
      public static readonly TypeGFXBlendOp GFXBlendOpRevSubtract = new TypeGFXBlendOp((int)R__GFXBlendOp.GFXBlendOpRevSubtract,"GFXBlendOpRevSubtract","");
      public static readonly TypeGFXBlendOp GFXBlendOpMin = new TypeGFXBlendOp((int)R__GFXBlendOp.GFXBlendOpMin,"GFXBlendOpMin","");
      public static readonly TypeGFXBlendOp GFXBlendOpMax = new TypeGFXBlendOp((int)R__GFXBlendOp.GFXBlendOpMax,"GFXBlendOpMax","");
      };

/// <summary>
/// TypeGFXCmpFunc
/// </summary>

 public sealed class TypeGFXCmpFunc  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXCmpFunc> mdict = new Dictionary<int, TypeGFXCmpFunc>();
        static readonly Dictionary<string, TypeGFXCmpFunc> msdict = new Dictionary<string, TypeGFXCmpFunc>();

        public static implicit operator TypeGFXCmpFunc(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXCmpFunc t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXCmpFunc(string s)
            {
            return msdict[s];
            }


        private TypeGFXCmpFunc(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXCmpFunc GFXCmpNever = new TypeGFXCmpFunc((int)R__GFXCmpFunc.GFXCmpNever,"GFXCmpNever","");
      public static readonly TypeGFXCmpFunc GFXCmpLess = new TypeGFXCmpFunc((int)R__GFXCmpFunc.GFXCmpLess,"GFXCmpLess","");
      public static readonly TypeGFXCmpFunc GFXCmpEqual = new TypeGFXCmpFunc((int)R__GFXCmpFunc.GFXCmpEqual,"GFXCmpEqual","");
      public static readonly TypeGFXCmpFunc GFXCmpLessEqual = new TypeGFXCmpFunc((int)R__GFXCmpFunc.GFXCmpLessEqual,"GFXCmpLessEqual","");
      public static readonly TypeGFXCmpFunc GFXCmpGreater = new TypeGFXCmpFunc((int)R__GFXCmpFunc.GFXCmpGreater,"GFXCmpGreater","");
      public static readonly TypeGFXCmpFunc GFXCmpNotEqual = new TypeGFXCmpFunc((int)R__GFXCmpFunc.GFXCmpNotEqual,"GFXCmpNotEqual","");
      public static readonly TypeGFXCmpFunc GFXCmpGreaterEqual = new TypeGFXCmpFunc((int)R__GFXCmpFunc.GFXCmpGreaterEqual,"GFXCmpGreaterEqual","");
      public static readonly TypeGFXCmpFunc GFXCmpAlways = new TypeGFXCmpFunc((int)R__GFXCmpFunc.GFXCmpAlways,"GFXCmpAlways","");
      };

/// <summary>
/// TypeGFXCullMode
/// </summary>

 public sealed class TypeGFXCullMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXCullMode> mdict = new Dictionary<int, TypeGFXCullMode>();
        static readonly Dictionary<string, TypeGFXCullMode> msdict = new Dictionary<string, TypeGFXCullMode>();

        public static implicit operator TypeGFXCullMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXCullMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXCullMode(string s)
            {
            return msdict[s];
            }


        private TypeGFXCullMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXCullMode GFXCullNone = new TypeGFXCullMode((int)R__GFXCullMode.GFXCullNone,"GFXCullNone","");
      public static readonly TypeGFXCullMode GFXCullCW = new TypeGFXCullMode((int)R__GFXCullMode.GFXCullCW,"GFXCullCW","");
      public static readonly TypeGFXCullMode GFXCullCCW = new TypeGFXCullMode((int)R__GFXCullMode.GFXCullCCW,"GFXCullCCW","");
      };

/// <summary>
/// TypeGFXFormat
/// </summary>

 public sealed class TypeGFXFormat  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXFormat> mdict = new Dictionary<int, TypeGFXFormat>();
        static readonly Dictionary<string, TypeGFXFormat> msdict = new Dictionary<string, TypeGFXFormat>();

        public static implicit operator TypeGFXFormat(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXFormat t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXFormat(string s)
            {
            return msdict[s];
            }


        private TypeGFXFormat(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXFormat GFXFormatR8G8B8 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR8G8B8,"GFXFormatR8G8B8","");
      public static readonly TypeGFXFormat GFXFormatR8G8B8A8 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR8G8B8A8,"GFXFormatR8G8B8A8","");
      public static readonly TypeGFXFormat GFXFormatR8G8B8X8 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR8G8B8X8,"GFXFormatR8G8B8X8","");
      public static readonly TypeGFXFormat GFXFormatR32F = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR32F,"GFXFormatR32F","");
      public static readonly TypeGFXFormat GFXFormatR5G6B5 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR5G6B5,"GFXFormatR5G6B5","");
      public static readonly TypeGFXFormat GFXFormatR5G5B5A1 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR5G5B5A1,"GFXFormatR5G5B5A1","");
      public static readonly TypeGFXFormat GFXFormatR5G5B5X1 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR5G5B5X1,"GFXFormatR5G5B5X1","");
      public static readonly TypeGFXFormat GFXFormatA4L4 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatA4L4,"GFXFormatA4L4","");
      public static readonly TypeGFXFormat GFXFormatA8L8 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatA8L8,"GFXFormatA8L8","");
      public static readonly TypeGFXFormat GFXFormatA8 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatA8,"GFXFormatA8","");
      public static readonly TypeGFXFormat GFXFormatL8 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatL8,"GFXFormatL8","");
      public static readonly TypeGFXFormat GFXFormatDXT1 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatDXT1,"GFXFormatDXT1","");
      public static readonly TypeGFXFormat GFXFormatDXT2 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatDXT2,"GFXFormatDXT2","");
      public static readonly TypeGFXFormat GFXFormatDXT3 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatDXT3,"GFXFormatDXT3","");
      public static readonly TypeGFXFormat GFXFormatDXT4 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatDXT4,"GFXFormatDXT4","");
      public static readonly TypeGFXFormat GFXFormatDXT5 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatDXT5,"GFXFormatDXT5","");
      public static readonly TypeGFXFormat GFXFormatD32 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatD32,"GFXFormatD32","");
      public static readonly TypeGFXFormat GFXFormatD24X8 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatD24X8,"GFXFormatD24X8","");
      public static readonly TypeGFXFormat GFXFormatD24S8 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatD24S8,"GFXFormatD24S8","");
      public static readonly TypeGFXFormat GFXFormatD24FS8 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatD24FS8,"GFXFormatD24FS8","");
      public static readonly TypeGFXFormat GFXFormatD16 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatD16,"GFXFormatD16","");
      public static readonly TypeGFXFormat GFXFormatR32G32B32A32F = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR32G32B32A32F,"GFXFormatR32G32B32A32F","");
      public static readonly TypeGFXFormat GFXFormatR16G16B16A16F = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR16G16B16A16F,"GFXFormatR16G16B16A16F","");
      public static readonly TypeGFXFormat GFXFormatL16 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatL16,"GFXFormatL16","");
      public static readonly TypeGFXFormat GFXFormatR16G16B16A16 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR16G16B16A16,"GFXFormatR16G16B16A16","");
      public static readonly TypeGFXFormat GFXFormatR16G16 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR16G16,"GFXFormatR16G16","");
      public static readonly TypeGFXFormat GFXFormatR16F = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR16F,"GFXFormatR16F","");
      public static readonly TypeGFXFormat GFXFormatR16G16F = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR16G16F,"GFXFormatR16G16F","");
      public static readonly TypeGFXFormat GFXFormatR10G10B10A2 = new TypeGFXFormat((int)R__GFXFormat.GFXFormatR10G10B10A2,"GFXFormatR10G10B10A2","");
      };

/// <summary>
/// TypeGFXStencilOp
/// </summary>

 public sealed class TypeGFXStencilOp  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXStencilOp> mdict = new Dictionary<int, TypeGFXStencilOp>();
        static readonly Dictionary<string, TypeGFXStencilOp> msdict = new Dictionary<string, TypeGFXStencilOp>();

        public static implicit operator TypeGFXStencilOp(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXStencilOp t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXStencilOp(string s)
            {
            return msdict[s];
            }


        private TypeGFXStencilOp(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXStencilOp GFXStencilOpKeep = new TypeGFXStencilOp((int)R__GFXStencilOp.GFXStencilOpKeep,"GFXStencilOpKeep","");
      public static readonly TypeGFXStencilOp GFXStencilOpZero = new TypeGFXStencilOp((int)R__GFXStencilOp.GFXStencilOpZero,"GFXStencilOpZero","");
      public static readonly TypeGFXStencilOp GFXStencilOpReplace = new TypeGFXStencilOp((int)R__GFXStencilOp.GFXStencilOpReplace,"GFXStencilOpReplace","");
      public static readonly TypeGFXStencilOp GFXStencilOpIncrSat = new TypeGFXStencilOp((int)R__GFXStencilOp.GFXStencilOpIncrSat,"GFXStencilOpIncrSat","");
      public static readonly TypeGFXStencilOp GFXStencilOpDecrSat = new TypeGFXStencilOp((int)R__GFXStencilOp.GFXStencilOpDecrSat,"GFXStencilOpDecrSat","");
      public static readonly TypeGFXStencilOp GFXStencilOpInvert = new TypeGFXStencilOp((int)R__GFXStencilOp.GFXStencilOpInvert,"GFXStencilOpInvert","");
      public static readonly TypeGFXStencilOp GFXStencilOpIncr = new TypeGFXStencilOp((int)R__GFXStencilOp.GFXStencilOpIncr,"GFXStencilOpIncr","");
      public static readonly TypeGFXStencilOp GFXStencilOpDecr = new TypeGFXStencilOp((int)R__GFXStencilOp.GFXStencilOpDecr,"GFXStencilOpDecr","");
      };

/// <summary>
/// TypeGFXTextureAddressMode
/// </summary>

 public sealed class TypeGFXTextureAddressMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXTextureAddressMode> mdict = new Dictionary<int, TypeGFXTextureAddressMode>();
        static readonly Dictionary<string, TypeGFXTextureAddressMode> msdict = new Dictionary<string, TypeGFXTextureAddressMode>();

        public static implicit operator TypeGFXTextureAddressMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXTextureAddressMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXTextureAddressMode(string s)
            {
            return msdict[s];
            }


        private TypeGFXTextureAddressMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXTextureAddressMode GFXAddressWrap = new TypeGFXTextureAddressMode((int)R__GFXTextureAddressMode.GFXAddressWrap,"GFXAddressWrap","");
      public static readonly TypeGFXTextureAddressMode GFXAddressMirror = new TypeGFXTextureAddressMode((int)R__GFXTextureAddressMode.GFXAddressMirror,"GFXAddressMirror","");
      public static readonly TypeGFXTextureAddressMode GFXAddressClamp = new TypeGFXTextureAddressMode((int)R__GFXTextureAddressMode.GFXAddressClamp,"GFXAddressClamp","");
      public static readonly TypeGFXTextureAddressMode GFXAddressBorder = new TypeGFXTextureAddressMode((int)R__GFXTextureAddressMode.GFXAddressBorder,"GFXAddressBorder","");
      public static readonly TypeGFXTextureAddressMode GFXAddressMirrorOnce = new TypeGFXTextureAddressMode((int)R__GFXTextureAddressMode.GFXAddressMirrorOnce,"GFXAddressMirrorOnce","");
      };

/// <summary>
/// TypeGFXTextureArgument
/// </summary>

 public sealed class TypeGFXTextureArgument  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXTextureArgument> mdict = new Dictionary<int, TypeGFXTextureArgument>();
        static readonly Dictionary<string, TypeGFXTextureArgument> msdict = new Dictionary<string, TypeGFXTextureArgument>();

        public static implicit operator TypeGFXTextureArgument(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXTextureArgument t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXTextureArgument(string s)
            {
            return msdict[s];
            }


        private TypeGFXTextureArgument(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXTextureArgument GFXTADiffuse = new TypeGFXTextureArgument((int)R__GFXTextureArgument.GFXTADiffuse,"GFXTADiffuse","");
      public static readonly TypeGFXTextureArgument GFXTACurrent = new TypeGFXTextureArgument((int)R__GFXTextureArgument.GFXTACurrent,"GFXTACurrent","");
      public static readonly TypeGFXTextureArgument GFXTATexture = new TypeGFXTextureArgument((int)R__GFXTextureArgument.GFXTATexture,"GFXTATexture","");
      public static readonly TypeGFXTextureArgument GFXTATFactor = new TypeGFXTextureArgument((int)R__GFXTextureArgument.GFXTATFactor,"GFXTATFactor","");
      public static readonly TypeGFXTextureArgument GFXTASpecular = new TypeGFXTextureArgument((int)R__GFXTextureArgument.GFXTASpecular,"GFXTASpecular","");
      public static readonly TypeGFXTextureArgument GFXTATemp = new TypeGFXTextureArgument((int)R__GFXTextureArgument.GFXTATemp,"GFXTATemp","");
      public static readonly TypeGFXTextureArgument GFXTAConstant = new TypeGFXTextureArgument((int)R__GFXTextureArgument.GFXTAConstant,"GFXTAConstant","");
      public static readonly TypeGFXTextureArgument OneMinus = new TypeGFXTextureArgument((int)R__GFXTextureArgument.GFXTAComplement,"OneMinus","");
      public static readonly TypeGFXTextureArgument AlphaReplicate = new TypeGFXTextureArgument((int)R__GFXTextureArgument.GFXTAAlphaReplicate,"AlphaReplicate","");
      };

/// <summary>
/// TypeGFXTextureFilterType
/// </summary>

 public sealed class TypeGFXTextureFilterType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXTextureFilterType> mdict = new Dictionary<int, TypeGFXTextureFilterType>();
        static readonly Dictionary<string, TypeGFXTextureFilterType> msdict = new Dictionary<string, TypeGFXTextureFilterType>();

        public static implicit operator TypeGFXTextureFilterType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXTextureFilterType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXTextureFilterType(string s)
            {
            return msdict[s];
            }


        private TypeGFXTextureFilterType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXTextureFilterType GFXTextureFilterNone = new TypeGFXTextureFilterType((int)R__GFXTextureFilterType.GFXTextureFilterNone,"GFXTextureFilterNone","");
      public static readonly TypeGFXTextureFilterType GFXTextureFilterPoint = new TypeGFXTextureFilterType((int)R__GFXTextureFilterType.GFXTextureFilterPoint,"GFXTextureFilterPoint","");
      public static readonly TypeGFXTextureFilterType GFXTextureFilterLinear = new TypeGFXTextureFilterType((int)R__GFXTextureFilterType.GFXTextureFilterLinear,"GFXTextureFilterLinear","");
      public static readonly TypeGFXTextureFilterType GFXTextureFilterAnisotropic = new TypeGFXTextureFilterType((int)R__GFXTextureFilterType.GFXTextureFilterAnisotropic,"GFXTextureFilterAnisotropic","");
      public static readonly TypeGFXTextureFilterType GFXTextureFilterPyramidalQuad = new TypeGFXTextureFilterType((int)R__GFXTextureFilterType.GFXTextureFilterPyramidalQuad,"GFXTextureFilterPyramidalQuad","");
      public static readonly TypeGFXTextureFilterType GFXTextureFilterGaussianQuad = new TypeGFXTextureFilterType((int)R__GFXTextureFilterType.GFXTextureFilterGaussianQuad,"GFXTextureFilterGaussianQuad","");
      };

/// <summary>
/// TypeGFXTextureOp
/// </summary>

 public sealed class TypeGFXTextureOp  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXTextureOp> mdict = new Dictionary<int, TypeGFXTextureOp>();
        static readonly Dictionary<string, TypeGFXTextureOp> msdict = new Dictionary<string, TypeGFXTextureOp>();

        public static implicit operator TypeGFXTextureOp(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXTextureOp t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXTextureOp(string s)
            {
            return msdict[s];
            }


        private TypeGFXTextureOp(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXTextureOp GFXTOPDisable = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPDisable,"GFXTOPDisable","");
      public static readonly TypeGFXTextureOp GFXTOPSelectARG1 = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPSelectARG1,"GFXTOPSelectARG1","");
      public static readonly TypeGFXTextureOp GFXTOPSelectARG2 = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPSelectARG2,"GFXTOPSelectARG2","");
      public static readonly TypeGFXTextureOp GFXTOPModulate = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPModulate,"GFXTOPModulate","");
      public static readonly TypeGFXTextureOp GFXTOPModulate2X = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPModulate2X,"GFXTOPModulate2X","");
      public static readonly TypeGFXTextureOp GFXTOPModulate4X = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPModulate4X,"GFXTOPModulate4X","");
      public static readonly TypeGFXTextureOp GFXTOPAdd = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPAdd,"GFXTOPAdd","");
      public static readonly TypeGFXTextureOp GFXTOPAddSigned = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPAddSigned,"GFXTOPAddSigned","");
      public static readonly TypeGFXTextureOp GFXTOPAddSigned2X = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPAddSigned2X,"GFXTOPAddSigned2X","");
      public static readonly TypeGFXTextureOp GFXTOPSubtract = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPSubtract,"GFXTOPSubtract","");
      public static readonly TypeGFXTextureOp GFXTOPAddSmooth = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPAddSmooth,"GFXTOPAddSmooth","");
      public static readonly TypeGFXTextureOp GFXTOPBlendDiffuseAlpha = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPBlendDiffuseAlpha,"GFXTOPBlendDiffuseAlpha","");
      public static readonly TypeGFXTextureOp GFXTOPBlendTextureAlpha = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPBlendTextureAlpha,"GFXTOPBlendTextureAlpha","");
      public static readonly TypeGFXTextureOp GFXTOPBlendFactorAlpha = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPBlendFactorAlpha,"GFXTOPBlendFactorAlpha","");
      public static readonly TypeGFXTextureOp GFXTOPBlendTextureAlphaPM = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPBlendTextureAlphaPM,"GFXTOPBlendTextureAlphaPM","");
      public static readonly TypeGFXTextureOp GFXTOPBlendCURRENTALPHA = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPBlendCURRENTALPHA,"GFXTOPBlendCURRENTALPHA","");
      public static readonly TypeGFXTextureOp GFXTOPPreModulate = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPPreModulate,"GFXTOPPreModulate","");
      public static readonly TypeGFXTextureOp GFXTOPModulateAlphaAddColor = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPModulateAlphaAddColor,"GFXTOPModulateAlphaAddColor","");
      public static readonly TypeGFXTextureOp GFXTOPModulateColorAddAlpha = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPModulateColorAddAlpha,"GFXTOPModulateColorAddAlpha","");
      public static readonly TypeGFXTextureOp GFXTOPModulateInvAlphaAddColor = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPModulateInvAlphaAddColor,"GFXTOPModulateInvAlphaAddColor","");
      public static readonly TypeGFXTextureOp GFXTOPModulateInvColorAddAlpha = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPModulateInvColorAddAlpha,"GFXTOPModulateInvColorAddAlpha","");
      public static readonly TypeGFXTextureOp GFXTOPBumpEnvMap = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPBumpEnvMap,"GFXTOPBumpEnvMap","");
      public static readonly TypeGFXTextureOp GFXTOPBumpEnvMapLuminance = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPBumpEnvMapLuminance,"GFXTOPBumpEnvMapLuminance","");
      public static readonly TypeGFXTextureOp GFXTOPDotProduct3 = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPDotProduct3,"GFXTOPDotProduct3","");
      public static readonly TypeGFXTextureOp GFXTOPLERP = new TypeGFXTextureOp((int)R__GFXTextureOp.GFXTOPLERP,"GFXTOPLERP","");
      };

/// <summary>
/// TypeGFXTextureTransformFlags
/// </summary>

 public sealed class TypeGFXTextureTransformFlags  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGFXTextureTransformFlags> mdict = new Dictionary<int, TypeGFXTextureTransformFlags>();
        static readonly Dictionary<string, TypeGFXTextureTransformFlags> msdict = new Dictionary<string, TypeGFXTextureTransformFlags>();

        public static implicit operator TypeGFXTextureTransformFlags(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGFXTextureTransformFlags t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGFXTextureTransformFlags(string s)
            {
            return msdict[s];
            }


        private TypeGFXTextureTransformFlags(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGFXTextureTransformFlags GFXTTFDisable = new TypeGFXTextureTransformFlags((int)R__GFXTextureTransformFlags.GFXTTFFDisable,"GFXTTFDisable","");
      public static readonly TypeGFXTextureTransformFlags GFXTTFFCoord1D = new TypeGFXTextureTransformFlags((int)R__GFXTextureTransformFlags.GFXTTFFCoord1D,"GFXTTFFCoord1D","");
      public static readonly TypeGFXTextureTransformFlags GFXTTFFCoord2D = new TypeGFXTextureTransformFlags((int)R__GFXTextureTransformFlags.GFXTTFFCoord2D,"GFXTTFFCoord2D","");
      public static readonly TypeGFXTextureTransformFlags GFXTTFFCoord3D = new TypeGFXTextureTransformFlags((int)R__GFXTextureTransformFlags.GFXTTFFCoord3D,"GFXTTFFCoord3D","");
      public static readonly TypeGFXTextureTransformFlags GFXTTFFCoord4D = new TypeGFXTextureTransformFlags((int)R__GFXTextureTransformFlags.GFXTTFFCoord4D,"GFXTTFFCoord4D","");
      public static readonly TypeGFXTextureTransformFlags GFXTTFProjected = new TypeGFXTextureTransformFlags((int)R__GFXTextureTransformFlags.GFXTTFFProjected,"GFXTTFProjected","");
      };

/// <summary>
/// TypeGizmoAlignment
/// </summary>

 public sealed class TypeGizmoAlignment  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGizmoAlignment> mdict = new Dictionary<int, TypeGizmoAlignment>();
        static readonly Dictionary<string, TypeGizmoAlignment> msdict = new Dictionary<string, TypeGizmoAlignment>();

        public static implicit operator TypeGizmoAlignment(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGizmoAlignment t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGizmoAlignment(string s)
            {
            return msdict[s];
            }


        private TypeGizmoAlignment(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGizmoAlignment World = new TypeGizmoAlignment((int)R__GizmoAlignment.World,"World","Align the gizmo with the world. n");
      public static readonly TypeGizmoAlignment Object = new TypeGizmoAlignment((int)R__GizmoAlignment.Object,"Object","Align the gizmo with the object. n");
      };

/// <summary>
/// TypeGizmoMode
/// </summary>

 public sealed class TypeGizmoMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGizmoMode> mdict = new Dictionary<int, TypeGizmoMode>();
        static readonly Dictionary<string, TypeGizmoMode> msdict = new Dictionary<string, TypeGizmoMode>();

        public static implicit operator TypeGizmoMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGizmoMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGizmoMode(string s)
            {
            return msdict[s];
            }


        private TypeGizmoMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGizmoMode None = new TypeGizmoMode((int)R__GizmoMode.NoneMode,"None","");
      public static readonly TypeGizmoMode Move = new TypeGizmoMode((int)R__GizmoMode.MoveMode,"Move","");
      public static readonly TypeGizmoMode Rotate = new TypeGizmoMode((int)R__GizmoMode.RotateMode,"Rotate","");
      public static readonly TypeGizmoMode Scale = new TypeGizmoMode((int)R__GizmoMode.ScaleMode,"Scale","");
      };

/// <summary>
/// TypeGuiAlignmentType
/// </summary>

 public sealed class TypeGuiAlignmentType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiAlignmentType> mdict = new Dictionary<int, TypeGuiAlignmentType>();
        static readonly Dictionary<string, TypeGuiAlignmentType> msdict = new Dictionary<string, TypeGuiAlignmentType>();

        public static implicit operator TypeGuiAlignmentType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiAlignmentType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiAlignmentType(string s)
            {
            return msdict[s];
            }


        private TypeGuiAlignmentType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiAlignmentType Left = new TypeGuiAlignmentType((int)R__GuiControlProfile__AlignmentType.LeftJustify,"Left","");
      public static readonly TypeGuiAlignmentType Center = new TypeGuiAlignmentType((int)R__GuiControlProfile__AlignmentType.CenterJustify,"Center","");
      public static readonly TypeGuiAlignmentType Right = new TypeGuiAlignmentType((int)R__GuiControlProfile__AlignmentType.RightJustify,"Right","");
      public static readonly TypeGuiAlignmentType Top = new TypeGuiAlignmentType((int)R__GuiControlProfile__AlignmentType.TopJustify,"Top","");
      public static readonly TypeGuiAlignmentType Bottom = new TypeGuiAlignmentType((int)R__GuiControlProfile__AlignmentType.BottomJustify,"Bottom","");
      };

/// <summary>
/// TypeGuiAutoScrollDirection
/// </summary>

 public sealed class TypeGuiAutoScrollDirection  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiAutoScrollDirection> mdict = new Dictionary<int, TypeGuiAutoScrollDirection>();
        static readonly Dictionary<string, TypeGuiAutoScrollDirection> msdict = new Dictionary<string, TypeGuiAutoScrollDirection>();

        public static implicit operator TypeGuiAutoScrollDirection(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiAutoScrollDirection t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiAutoScrollDirection(string s)
            {
            return msdict[s];
            }


        private TypeGuiAutoScrollDirection(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiAutoScrollDirection Up = new TypeGuiAutoScrollDirection((int)R__GuiAutoScrollCtrl__Direction.Up,"Up","Scroll from bottom towards top.");
      public static readonly TypeGuiAutoScrollDirection Down = new TypeGuiAutoScrollDirection((int)R__GuiAutoScrollCtrl__Direction.Down,"Down","Scroll from top towards bottom.");
      public static readonly TypeGuiAutoScrollDirection Left = new TypeGuiAutoScrollDirection((int)R__GuiAutoScrollCtrl__Direction.Left,"Left","Scroll from right towards left.");
      public static readonly TypeGuiAutoScrollDirection Right = new TypeGuiAutoScrollDirection((int)R__GuiAutoScrollCtrl__Direction.Right,"Right","Scroll from left towards right.");
      };

/// <summary>
/// TypeGuiBitmapMode
/// </summary>

 public sealed class TypeGuiBitmapMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiBitmapMode> mdict = new Dictionary<int, TypeGuiBitmapMode>();
        static readonly Dictionary<string, TypeGuiBitmapMode> msdict = new Dictionary<string, TypeGuiBitmapMode>();

        public static implicit operator TypeGuiBitmapMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiBitmapMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiBitmapMode(string s)
            {
            return msdict[s];
            }


        private TypeGuiBitmapMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiBitmapMode Stretched = new TypeGuiBitmapMode((int)R__GuiBitmapButtonCtrl__BitmapMode.BitmapStretched,"Stretched","Stretch bitmap to fit control extents.");
      public static readonly TypeGuiBitmapMode Centered = new TypeGuiBitmapMode((int)R__GuiBitmapButtonCtrl__BitmapMode.BitmapCentered,"Centered","Center bitmap in control.");
      };

/// <summary>
/// TypeGuiButtonType
/// </summary>

 public sealed class TypeGuiButtonType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiButtonType> mdict = new Dictionary<int, TypeGuiButtonType>();
        static readonly Dictionary<string, TypeGuiButtonType> msdict = new Dictionary<string, TypeGuiButtonType>();

        public static implicit operator TypeGuiButtonType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiButtonType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiButtonType(string s)
            {
            return msdict[s];
            }


        private TypeGuiButtonType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiButtonType PushButton = new TypeGuiButtonType((int)R__GuiButtonBaseCtrl__ButtonType.ButtonTypePush,"PushButton","A button that triggers an action when clicked.");
      public static readonly TypeGuiButtonType ToggleButton = new TypeGuiButtonType((int)R__GuiButtonBaseCtrl__ButtonType.ButtonTypeCheck,"ToggleButton","A button that is toggled between on and off state.");
      public static readonly TypeGuiButtonType RadioButton = new TypeGuiButtonType((int)R__GuiButtonBaseCtrl__ButtonType.ButtonTypeRadio,"RadioButton","A button placed in groups for presenting choices.");
      };

/// <summary>
/// TypeGuiColorPickMode
/// </summary>

 public sealed class TypeGuiColorPickMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiColorPickMode> mdict = new Dictionary<int, TypeGuiColorPickMode>();
        static readonly Dictionary<string, TypeGuiColorPickMode> msdict = new Dictionary<string, TypeGuiColorPickMode>();

        public static implicit operator TypeGuiColorPickMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiColorPickMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiColorPickMode(string s)
            {
            return msdict[s];
            }


        private TypeGuiColorPickMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiColorPickMode Pallete = new TypeGuiColorPickMode((int)R__GuiColorPickerCtrl__PickMode.pPallet,"Pallete","");
      public static readonly TypeGuiColorPickMode HorizColor = new TypeGuiColorPickMode((int)R__GuiColorPickerCtrl__PickMode.pHorizColorRange,"HorizColor","");
      public static readonly TypeGuiColorPickMode VertColor = new TypeGuiColorPickMode((int)R__GuiColorPickerCtrl__PickMode.pVertColorRange,"VertColor","");
      public static readonly TypeGuiColorPickMode HorizBrightnessColor = new TypeGuiColorPickMode((int)R__GuiColorPickerCtrl__PickMode.pHorizColorBrightnessRange,"HorizBrightnessColor","");
      public static readonly TypeGuiColorPickMode VertBrightnessColor = new TypeGuiColorPickMode((int)R__GuiColorPickerCtrl__PickMode.pVertColorBrightnessRange,"VertBrightnessColor","");
      public static readonly TypeGuiColorPickMode BlendColor = new TypeGuiColorPickMode((int)R__GuiColorPickerCtrl__PickMode.pBlendColorRange,"BlendColor","");
      public static readonly TypeGuiColorPickMode HorizAlpha = new TypeGuiColorPickMode((int)R__GuiColorPickerCtrl__PickMode.pHorizAlphaRange,"HorizAlpha","");
      public static readonly TypeGuiColorPickMode VertAlpha = new TypeGuiColorPickMode((int)R__GuiColorPickerCtrl__PickMode.pVertAlphaRange,"VertAlpha","");
      public static readonly TypeGuiColorPickMode Dropper = new TypeGuiColorPickMode((int)R__GuiColorPickerCtrl__PickMode.pDropperBackground,"Dropper","");
      };

/// <summary>
/// TypeGuiDockingType
/// </summary>

 public sealed class TypeGuiDockingType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiDockingType> mdict = new Dictionary<int, TypeGuiDockingType>();
        static readonly Dictionary<string, TypeGuiDockingType> msdict = new Dictionary<string, TypeGuiDockingType>();

        public static implicit operator TypeGuiDockingType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiDockingType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiDockingType(string s)
            {
            return msdict[s];
            }


        private TypeGuiDockingType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiDockingType None = new TypeGuiDockingType((int)R__Docking__DockingType.dockNone,"None","");
      public static readonly TypeGuiDockingType Client = new TypeGuiDockingType((int)R__Docking__DockingType.dockClient,"Client","");
      public static readonly TypeGuiDockingType Top = new TypeGuiDockingType((int)R__Docking__DockingType.dockTop,"Top","");
      public static readonly TypeGuiDockingType Bottom = new TypeGuiDockingType((int)R__Docking__DockingType.dockBottom,"Bottom","");
      public static readonly TypeGuiDockingType Left = new TypeGuiDockingType((int)R__Docking__DockingType.dockLeft,"Left","");
      public static readonly TypeGuiDockingType Right = new TypeGuiDockingType((int)R__Docking__DockingType.dockRight,"Right","");
      };

/// <summary>
/// TypeGuiFontCharset
/// </summary>

 public sealed class TypeGuiFontCharset  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiFontCharset> mdict = new Dictionary<int, TypeGuiFontCharset>();
        static readonly Dictionary<string, TypeGuiFontCharset> msdict = new Dictionary<string, TypeGuiFontCharset>();

        public static implicit operator TypeGuiFontCharset(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiFontCharset t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiFontCharset(string s)
            {
            return msdict[s];
            }


        private TypeGuiFontCharset(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiFontCharset ANSI = new TypeGuiFontCharset((int)R__FontCharset.TGE_ANSI_CHARSET,"ANSI","");
      public static readonly TypeGuiFontCharset SYMBOL = new TypeGuiFontCharset((int)R__FontCharset.TGE_SYMBOL_CHARSET,"SYMBOL","");
      public static readonly TypeGuiFontCharset SHIFTJIS = new TypeGuiFontCharset((int)R__FontCharset.TGE_SHIFTJIS_CHARSET,"SHIFTJIS","");
      public static readonly TypeGuiFontCharset HANGEUL = new TypeGuiFontCharset((int)R__FontCharset.TGE_HANGEUL_CHARSET,"HANGEUL","");
      public static readonly TypeGuiFontCharset HANGUL = new TypeGuiFontCharset((int)R__FontCharset.TGE_HANGUL_CHARSET,"HANGUL","");
      public static readonly TypeGuiFontCharset GB2312 = new TypeGuiFontCharset((int)R__FontCharset.TGE_GB2312_CHARSET,"GB2312","");
      public static readonly TypeGuiFontCharset CHINESEBIG5 = new TypeGuiFontCharset((int)R__FontCharset.TGE_CHINESEBIG5_CHARSET,"CHINESEBIG5","");
      public static readonly TypeGuiFontCharset OEM = new TypeGuiFontCharset((int)R__FontCharset.TGE_OEM_CHARSET,"OEM","");
      public static readonly TypeGuiFontCharset JOHAB = new TypeGuiFontCharset((int)R__FontCharset.TGE_JOHAB_CHARSET,"JOHAB","");
      public static readonly TypeGuiFontCharset HEBREW = new TypeGuiFontCharset((int)R__FontCharset.TGE_HEBREW_CHARSET,"HEBREW","");
      public static readonly TypeGuiFontCharset ARABIC = new TypeGuiFontCharset((int)R__FontCharset.TGE_ARABIC_CHARSET,"ARABIC","");
      public static readonly TypeGuiFontCharset GREEK = new TypeGuiFontCharset((int)R__FontCharset.TGE_GREEK_CHARSET,"GREEK","");
      public static readonly TypeGuiFontCharset TURKISH = new TypeGuiFontCharset((int)R__FontCharset.TGE_TURKISH_CHARSET,"TURKISH","");
      public static readonly TypeGuiFontCharset VIETNAMESE = new TypeGuiFontCharset((int)R__FontCharset.TGE_VIETNAMESE_CHARSET,"VIETNAMESE","");
      public static readonly TypeGuiFontCharset THAI = new TypeGuiFontCharset((int)R__FontCharset.TGE_THAI_CHARSET,"THAI","");
      public static readonly TypeGuiFontCharset EASTEUROPE = new TypeGuiFontCharset((int)R__FontCharset.TGE_EASTEUROPE_CHARSET,"EASTEUROPE","");
      public static readonly TypeGuiFontCharset RUSSIAN = new TypeGuiFontCharset((int)R__FontCharset.TGE_RUSSIAN_CHARSET,"RUSSIAN","");
      public static readonly TypeGuiFontCharset MAC = new TypeGuiFontCharset((int)R__FontCharset.TGE_MAC_CHARSET,"MAC","");
      public static readonly TypeGuiFontCharset BALTIC = new TypeGuiFontCharset((int)R__FontCharset.TGE_BALTIC_CHARSET,"BALTIC","");
      };

/// <summary>
/// TypeGuiFrameState
/// </summary>

 public sealed class TypeGuiFrameState  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiFrameState> mdict = new Dictionary<int, TypeGuiFrameState>();
        static readonly Dictionary<string, TypeGuiFrameState> msdict = new Dictionary<string, TypeGuiFrameState>();

        public static implicit operator TypeGuiFrameState(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiFrameState t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiFrameState(string s)
            {
            return msdict[s];
            }


        private TypeGuiFrameState(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiFrameState alwaysOn = new TypeGuiFrameState((int)R__GuiFrameSetCtrl__FrameState.FRAME_STATE_ON,"alwaysOn","");
      public static readonly TypeGuiFrameState alwaysOff = new TypeGuiFrameState((int)R__GuiFrameSetCtrl__FrameState.FRAME_STATE_OFF,"alwaysOff","");
      public static readonly TypeGuiFrameState dynamic = new TypeGuiFrameState((int)R__GuiFrameSetCtrl__FrameState.FRAME_STATE_AUTO,"dynamic","");
      };

/// <summary>
/// TypeGuiGradientPickMode
/// </summary>

 public sealed class TypeGuiGradientPickMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiGradientPickMode> mdict = new Dictionary<int, TypeGuiGradientPickMode>();
        static readonly Dictionary<string, TypeGuiGradientPickMode> msdict = new Dictionary<string, TypeGuiGradientPickMode>();

        public static implicit operator TypeGuiGradientPickMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiGradientPickMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiGradientPickMode(string s)
            {
            return msdict[s];
            }


        private TypeGuiGradientPickMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiGradientPickMode HorizColor = new TypeGuiGradientPickMode((int)R__GuiGradientCtrl__PickMode.pHorizColorRange,"HorizColor","");
      public static readonly TypeGuiGradientPickMode HorizAlpha = new TypeGuiGradientPickMode((int)R__GuiGradientCtrl__PickMode.pHorizAlphaRange,"HorizAlpha","");
      };

/// <summary>
/// TypeGuiGraphType
/// </summary>

 public sealed class TypeGuiGraphType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiGraphType> mdict = new Dictionary<int, TypeGuiGraphType>();
        static readonly Dictionary<string, TypeGuiGraphType> msdict = new Dictionary<string, TypeGuiGraphType>();

        public static implicit operator TypeGuiGraphType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiGraphType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiGraphType(string s)
            {
            return msdict[s];
            }


        private TypeGuiGraphType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiGraphType Bar = new TypeGuiGraphType((int)R__GuiGraphCtrl__GraphType.Bar,"Bar","Plot the curve as a bar chart.");
      public static readonly TypeGuiGraphType Filled = new TypeGuiGraphType((int)R__GuiGraphCtrl__GraphType.Filled,"Filled","Plot a filled poly graph that connects the data points on the curve.");
      public static readonly TypeGuiGraphType Point = new TypeGuiGraphType((int)R__GuiGraphCtrl__GraphType.Point,"Point","Plot each data point on the curve as a single dot.");
      public static readonly TypeGuiGraphType PolyLine = new TypeGuiGraphType((int)R__GuiGraphCtrl__GraphType.Polyline,"PolyLine","Plot straight lines through the data points of the curve.");
      };

/// <summary>
/// TypeGuiHorizontalSizing
/// </summary>

 public sealed class TypeGuiHorizontalSizing  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiHorizontalSizing> mdict = new Dictionary<int, TypeGuiHorizontalSizing>();
        static readonly Dictionary<string, TypeGuiHorizontalSizing> msdict = new Dictionary<string, TypeGuiHorizontalSizing>();

        public static implicit operator TypeGuiHorizontalSizing(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiHorizontalSizing t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiHorizontalSizing(string s)
            {
            return msdict[s];
            }


        private TypeGuiHorizontalSizing(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiHorizontalSizing right = new TypeGuiHorizontalSizing((int)R__GuiControl__horizSizingOptions.horizResizeRight,"right","");
      public static readonly TypeGuiHorizontalSizing width = new TypeGuiHorizontalSizing((int)R__GuiControl__horizSizingOptions.horizResizeWidth,"width","");
      public static readonly TypeGuiHorizontalSizing left = new TypeGuiHorizontalSizing((int)R__GuiControl__horizSizingOptions.horizResizeLeft,"left","");
      public static readonly TypeGuiHorizontalSizing center = new TypeGuiHorizontalSizing((int)R__GuiControl__horizSizingOptions.horizResizeCenter,"center","");
      public static readonly TypeGuiHorizontalSizing relative = new TypeGuiHorizontalSizing((int)R__GuiControl__horizSizingOptions.horizResizeRelative,"relative","");
      public static readonly TypeGuiHorizontalSizing windowRelative = new TypeGuiHorizontalSizing((int)R__GuiControl__horizSizingOptions.horizResizeWindowRelative,"windowRelative","");
      };

/// <summary>
/// TypeGuiHorizontalStackingType
/// </summary>

 public sealed class TypeGuiHorizontalStackingType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiHorizontalStackingType> mdict = new Dictionary<int, TypeGuiHorizontalStackingType>();
        static readonly Dictionary<string, TypeGuiHorizontalStackingType> msdict = new Dictionary<string, TypeGuiHorizontalStackingType>();

        public static implicit operator TypeGuiHorizontalStackingType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiHorizontalStackingType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiHorizontalStackingType(string s)
            {
            return msdict[s];
            }


        private TypeGuiHorizontalStackingType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiHorizontalStackingType Left_to_Right = new TypeGuiHorizontalStackingType((int)R__GuiStackControl__HorizontalType.horizStackLeft,"Left to Right","Child controls are positioned in order from left to right (left-most control is first)");
      public static readonly TypeGuiHorizontalStackingType Right_to_Left = new TypeGuiHorizontalStackingType((int)R__GuiStackControl__HorizontalType.horizStackRight,"Right to Left","Child controls are positioned in order from right to left (right-most control is first)");
      };

/// <summary>
/// TypeGuiIconButtonIconLocation
/// </summary>

 public sealed class TypeGuiIconButtonIconLocation  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiIconButtonIconLocation> mdict = new Dictionary<int, TypeGuiIconButtonIconLocation>();
        static readonly Dictionary<string, TypeGuiIconButtonIconLocation> msdict = new Dictionary<string, TypeGuiIconButtonIconLocation>();

        public static implicit operator TypeGuiIconButtonIconLocation(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiIconButtonIconLocation t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiIconButtonIconLocation(string s)
            {
            return msdict[s];
            }


        private TypeGuiIconButtonIconLocation(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiIconButtonIconLocation None = new TypeGuiIconButtonIconLocation((int)R__GuiIconButtonCtrl__IconLocation.IconLocNone,"None","");
      public static readonly TypeGuiIconButtonIconLocation Left = new TypeGuiIconButtonIconLocation((int)R__GuiIconButtonCtrl__IconLocation.IconLocLeft,"Left","");
      public static readonly TypeGuiIconButtonIconLocation Right = new TypeGuiIconButtonIconLocation((int)R__GuiIconButtonCtrl__IconLocation.IconLocRight,"Right","");
      public static readonly TypeGuiIconButtonIconLocation Center = new TypeGuiIconButtonIconLocation((int)R__GuiIconButtonCtrl__IconLocation.IconLocCenter,"Center","");
      };

/// <summary>
/// TypeGuiIconButtonTextLocation
/// </summary>

 public sealed class TypeGuiIconButtonTextLocation  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiIconButtonTextLocation> mdict = new Dictionary<int, TypeGuiIconButtonTextLocation>();
        static readonly Dictionary<string, TypeGuiIconButtonTextLocation> msdict = new Dictionary<string, TypeGuiIconButtonTextLocation>();

        public static implicit operator TypeGuiIconButtonTextLocation(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiIconButtonTextLocation t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiIconButtonTextLocation(string s)
            {
            return msdict[s];
            }


        private TypeGuiIconButtonTextLocation(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiIconButtonTextLocation None = new TypeGuiIconButtonTextLocation((int)R__GuiIconButtonCtrl__TextLocation.TextLocNone,"None","");
      public static readonly TypeGuiIconButtonTextLocation Bottom = new TypeGuiIconButtonTextLocation((int)R__GuiIconButtonCtrl__TextLocation.TextLocBottom,"Bottom","");
      public static readonly TypeGuiIconButtonTextLocation Right = new TypeGuiIconButtonTextLocation((int)R__GuiIconButtonCtrl__TextLocation.TextLocRight,"Right","");
      public static readonly TypeGuiIconButtonTextLocation Top = new TypeGuiIconButtonTextLocation((int)R__GuiIconButtonCtrl__TextLocation.TextLocTop,"Top","");
      public static readonly TypeGuiIconButtonTextLocation Left = new TypeGuiIconButtonTextLocation((int)R__GuiIconButtonCtrl__TextLocation.TextLocLeft,"Left","");
      public static readonly TypeGuiIconButtonTextLocation Center = new TypeGuiIconButtonTextLocation((int)R__GuiIconButtonCtrl__TextLocation.TextLocCenter,"Center","");
      };

/// <summary>
/// TypeGuiParticleGraphType
/// </summary>

 public sealed class TypeGuiParticleGraphType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiParticleGraphType> mdict = new Dictionary<int, TypeGuiParticleGraphType>();
        static readonly Dictionary<string, TypeGuiParticleGraphType> msdict = new Dictionary<string, TypeGuiParticleGraphType>();

        public static implicit operator TypeGuiParticleGraphType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiParticleGraphType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiParticleGraphType(string s)
            {
            return msdict[s];
            }


        private TypeGuiParticleGraphType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiParticleGraphType bar = new TypeGuiParticleGraphType((int)R__GuiParticleGraphCtrl__GraphType.Bar,"bar","");
      public static readonly TypeGuiParticleGraphType filled = new TypeGuiParticleGraphType((int)R__GuiParticleGraphCtrl__GraphType.Filled,"filled","");
      public static readonly TypeGuiParticleGraphType point = new TypeGuiParticleGraphType((int)R__GuiParticleGraphCtrl__GraphType.Point,"point","");
      public static readonly TypeGuiParticleGraphType polyline = new TypeGuiParticleGraphType((int)R__GuiParticleGraphCtrl__GraphType.Polyline,"polyline","");
      };

/// <summary>
/// TypeGuiScrollBarBehavior
/// </summary>

 public sealed class TypeGuiScrollBarBehavior  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiScrollBarBehavior> mdict = new Dictionary<int, TypeGuiScrollBarBehavior>();
        static readonly Dictionary<string, TypeGuiScrollBarBehavior> msdict = new Dictionary<string, TypeGuiScrollBarBehavior>();

        public static implicit operator TypeGuiScrollBarBehavior(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiScrollBarBehavior t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiScrollBarBehavior(string s)
            {
            return msdict[s];
            }


        private TypeGuiScrollBarBehavior(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiScrollBarBehavior alwaysOn = new TypeGuiScrollBarBehavior((int)R__GuiScrollCtrl__ScrollBarBehavior.ScrollBarAlwaysOn,"alwaysOn","Always visible.");
      public static readonly TypeGuiScrollBarBehavior alwaysOff = new TypeGuiScrollBarBehavior((int)R__GuiScrollCtrl__ScrollBarBehavior.ScrollBarAlwaysOff,"alwaysOff","Never visible.");
      public static readonly TypeGuiScrollBarBehavior dynamic = new TypeGuiScrollBarBehavior((int)R__GuiScrollCtrl__ScrollBarBehavior.ScrollBarDynamic,"dynamic","Only visible when actually needed, i.e. when the child control(s) exceed the visible space on the given axis.");
      };

/// <summary>
/// TypeGuiSeparatorType
/// </summary>

 public sealed class TypeGuiSeparatorType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiSeparatorType> mdict = new Dictionary<int, TypeGuiSeparatorType>();
        static readonly Dictionary<string, TypeGuiSeparatorType> msdict = new Dictionary<string, TypeGuiSeparatorType>();

        public static implicit operator TypeGuiSeparatorType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiSeparatorType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiSeparatorType(string s)
            {
            return msdict[s];
            }


        private TypeGuiSeparatorType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiSeparatorType Vertical = new TypeGuiSeparatorType((int)R__GuiSeparatorCtrl__separatorTypeOptions.separatorTypeVertical,"Vertical","");
      public static readonly TypeGuiSeparatorType Horizontal = new TypeGuiSeparatorType((int)R__GuiSeparatorCtrl__separatorTypeOptions.separatorTypeHorizontal,"Horizontal","");
      };

/// <summary>
/// TypeGuiSplitFixedPanel
/// </summary>

 public sealed class TypeGuiSplitFixedPanel  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiSplitFixedPanel> mdict = new Dictionary<int, TypeGuiSplitFixedPanel>();
        static readonly Dictionary<string, TypeGuiSplitFixedPanel> msdict = new Dictionary<string, TypeGuiSplitFixedPanel>();

        public static implicit operator TypeGuiSplitFixedPanel(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiSplitFixedPanel t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiSplitFixedPanel(string s)
            {
            return msdict[s];
            }


        private TypeGuiSplitFixedPanel(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiSplitFixedPanel None = new TypeGuiSplitFixedPanel((int)R__GuiSplitContainer__FixedPanel.None,"None","Allow both childs to resize (default).");
      public static readonly TypeGuiSplitFixedPanel FirstPanel = new TypeGuiSplitFixedPanel((int)R__GuiSplitContainer__FixedPanel.FirstPanel,"FirstPanel","Keep ");
      public static readonly TypeGuiSplitFixedPanel SecondPanel = new TypeGuiSplitFixedPanel((int)R__GuiSplitContainer__FixedPanel.SecondPanel,"SecondPanel","");
      };

/// <summary>
/// TypeGuiSplitOrientation
/// </summary>

 public sealed class TypeGuiSplitOrientation  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiSplitOrientation> mdict = new Dictionary<int, TypeGuiSplitOrientation>();
        static readonly Dictionary<string, TypeGuiSplitOrientation> msdict = new Dictionary<string, TypeGuiSplitOrientation>();

        public static implicit operator TypeGuiSplitOrientation(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiSplitOrientation t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiSplitOrientation(string s)
            {
            return msdict[s];
            }


        private TypeGuiSplitOrientation(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiSplitOrientation Vertical = new TypeGuiSplitOrientation((int)R__GuiSplitContainer__Orientation.Vertical,"Vertical","Divide vertically placing one child left and one child right.");
      public static readonly TypeGuiSplitOrientation Horizontal = new TypeGuiSplitOrientation((int)R__GuiSplitContainer__Orientation.Horizontal,"Horizontal","Divide horizontally placing one child on top and one child below.");
      };

/// <summary>
/// TypeGuiStackingType
/// </summary>

 public sealed class TypeGuiStackingType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiStackingType> mdict = new Dictionary<int, TypeGuiStackingType>();
        static readonly Dictionary<string, TypeGuiStackingType> msdict = new Dictionary<string, TypeGuiStackingType>();

        public static implicit operator TypeGuiStackingType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiStackingType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiStackingType(string s)
            {
            return msdict[s];
            }


        private TypeGuiStackingType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiStackingType Vertical = new TypeGuiStackingType((int)R__GuiStackControl__StackingType.stackingTypeVert,"Vertical","Stack children vertically by setting their Y position");
      public static readonly TypeGuiStackingType Horizontal = new TypeGuiStackingType((int)R__GuiStackControl__StackingType.stackingTypeHoriz,"Horizontal","Stack children horizontall by setting their X position");
      public static readonly TypeGuiStackingType Dynamic = new TypeGuiStackingType((int)R__GuiStackControl__StackingType.stackingTypeDyn,"Dynamic","Automatically switch between           Vertical and Horizontal stacking. Vertical stacking is chosen when the           stack control is taller than it is wide, horizontal stacking is chosen           when the stack control is wider than it is tall.  ");
      };

/// <summary>
/// TypeGuiTabPosition
/// </summary>

 public sealed class TypeGuiTabPosition  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiTabPosition> mdict = new Dictionary<int, TypeGuiTabPosition>();
        static readonly Dictionary<string, TypeGuiTabPosition> msdict = new Dictionary<string, TypeGuiTabPosition>();

        public static implicit operator TypeGuiTabPosition(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiTabPosition t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiTabPosition(string s)
            {
            return msdict[s];
            }


        private TypeGuiTabPosition(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiTabPosition Top = new TypeGuiTabPosition((int)R__GuiTabBookCtrl__TabPosition.AlignTop,"Top","Tab headers on top edge.");
      public static readonly TypeGuiTabPosition Bottom = new TypeGuiTabPosition((int)R__GuiTabBookCtrl__TabPosition.AlignBottom,"Bottom","Tab headers on bottom edge.");
      public static readonly TypeGuiTabPosition Right = new TypeGuiTabPosition((int)R__GuiTabBookCtrl__TabPosition.AlignRight,"Right","Tab headers on right edge.");
      };

/// <summary>
/// TypeGuiTheoraTranscoder
/// </summary>

 public sealed class TypeGuiTheoraTranscoder  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiTheoraTranscoder> mdict = new Dictionary<int, TypeGuiTheoraTranscoder>();
        static readonly Dictionary<string, TypeGuiTheoraTranscoder> msdict = new Dictionary<string, TypeGuiTheoraTranscoder>();

        public static implicit operator TypeGuiTheoraTranscoder(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiTheoraTranscoder t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiTheoraTranscoder(string s)
            {
            return msdict[s];
            }


        private TypeGuiTheoraTranscoder(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiTheoraTranscoder Auto = new TypeGuiTheoraTranscoder((int)R__OggTheoraDecoder__ETranscoder.TRANSCODER_Auto,"Auto","Automatically detect most appropriate setting.");
      public static readonly TypeGuiTheoraTranscoder Generic = new TypeGuiTheoraTranscoder((int)R__OggTheoraDecoder__ETranscoder.TRANSCODER_Generic,"Generic","Slower but beneric transcoder that can convert all Y'CbCr input formats to RGB or RGBA output.");
      public static readonly TypeGuiTheoraTranscoder SSE2420RGBA = new TypeGuiTheoraTranscoder((int)R__OggTheoraDecoder__ETranscoder.TRANSCODER_SSE2420RGBA,"SSE2420RGBA","Fast SSE2-based transcoder with fixed conversion from 4:2:0 Y'CbCr to RGBA.");
      };

/// <summary>
/// TypeGuiTSRenderStyles
/// </summary>

 public sealed class TypeGuiTSRenderStyles  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiTSRenderStyles> mdict = new Dictionary<int, TypeGuiTSRenderStyles>();
        static readonly Dictionary<string, TypeGuiTSRenderStyles> msdict = new Dictionary<string, TypeGuiTSRenderStyles>();

        public static implicit operator TypeGuiTSRenderStyles(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiTSRenderStyles t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiTSRenderStyles(string s)
            {
            return msdict[s];
            }


        private TypeGuiTSRenderStyles(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiTSRenderStyles standard = new TypeGuiTSRenderStyles((int)R__GuiTSCtrl__RenderStyles.RenderStyleStandard,"standard","");
      public static readonly TypeGuiTSRenderStyles stereo_side_by_side = new TypeGuiTSRenderStyles((int)R__GuiTSCtrl__RenderStyles.RenderStyleStereoSideBySide,"stereo side by side","");
      };

/// <summary>
/// TypeGuiVerticalSizing
/// </summary>

 public sealed class TypeGuiVerticalSizing  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiVerticalSizing> mdict = new Dictionary<int, TypeGuiVerticalSizing>();
        static readonly Dictionary<string, TypeGuiVerticalSizing> msdict = new Dictionary<string, TypeGuiVerticalSizing>();

        public static implicit operator TypeGuiVerticalSizing(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiVerticalSizing t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiVerticalSizing(string s)
            {
            return msdict[s];
            }


        private TypeGuiVerticalSizing(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiVerticalSizing bottom = new TypeGuiVerticalSizing((int)R__GuiControl__vertSizingOptions.vertResizeBottom,"bottom","");
      public static readonly TypeGuiVerticalSizing height = new TypeGuiVerticalSizing((int)R__GuiControl__vertSizingOptions.vertResizeHeight,"height","");
      public static readonly TypeGuiVerticalSizing top = new TypeGuiVerticalSizing((int)R__GuiControl__vertSizingOptions.vertResizeTop,"top","");
      public static readonly TypeGuiVerticalSizing center = new TypeGuiVerticalSizing((int)R__GuiControl__vertSizingOptions.vertResizeCenter,"center","");
      public static readonly TypeGuiVerticalSizing relative = new TypeGuiVerticalSizing((int)R__GuiControl__vertSizingOptions.vertResizeRelative,"relative","");
      public static readonly TypeGuiVerticalSizing windowRelative = new TypeGuiVerticalSizing((int)R__GuiControl__vertSizingOptions.vertResizeWindowRelative,"windowRelative","");
      };

/// <summary>
/// TypeGuiVerticalStackingType
/// </summary>

 public sealed class TypeGuiVerticalStackingType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeGuiVerticalStackingType> mdict = new Dictionary<int, TypeGuiVerticalStackingType>();
        static readonly Dictionary<string, TypeGuiVerticalStackingType> msdict = new Dictionary<string, TypeGuiVerticalStackingType>();

        public static implicit operator TypeGuiVerticalStackingType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeGuiVerticalStackingType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeGuiVerticalStackingType(string s)
            {
            return msdict[s];
            }


        private TypeGuiVerticalStackingType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeGuiVerticalStackingType Top_to_Bottom = new TypeGuiVerticalStackingType((int)R__GuiStackControl__VerticalType.vertStackTop,"Top to Bottom","Child controls are positioned in order from top to bottom (top-most control is first)");
      public static readonly TypeGuiVerticalStackingType Bottom_to_Top = new TypeGuiVerticalStackingType((int)R__GuiStackControl__VerticalType.vertStackBottom,"Bottom to Top","Child controls are positioned in order from bottom to top (bottom-most control is first)");
      };

/// <summary>
/// TypeItemLightType
/// </summary>

 public sealed class TypeItemLightType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeItemLightType> mdict = new Dictionary<int, TypeItemLightType>();
        static readonly Dictionary<string, TypeItemLightType> msdict = new Dictionary<string, TypeItemLightType>();

        public static implicit operator TypeItemLightType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeItemLightType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeItemLightType(string s)
            {
            return msdict[s];
            }


        private TypeItemLightType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeItemLightType NoLight = new TypeItemLightType((int)R__Item__LightType.NoLight,"NoLight","The item has no light attached. n");
      public static readonly TypeItemLightType ConstantLight = new TypeItemLightType((int)R__Item__LightType.ConstantLight,"ConstantLight","The item has a constantly emitting light attached. n");
      public static readonly TypeItemLightType PulsingLight = new TypeItemLightType((int)R__Item__LightType.PulsingLight,"PulsingLight","The item has a pulsing light attached. n");
      };

/// <summary>
/// TypeLogLevel
/// </summary>

 public sealed class TypeLogLevel  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeLogLevel> mdict = new Dictionary<int, TypeLogLevel>();
        static readonly Dictionary<string, TypeLogLevel> msdict = new Dictionary<string, TypeLogLevel>();

        public static implicit operator TypeLogLevel(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeLogLevel t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeLogLevel(string s)
            {
            return msdict[s];
            }


        private TypeLogLevel(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeLogLevel normal = new TypeLogLevel((int)R__ConsoleLogEntry__Level.Normal,"normal","Lowest priority level, no highlighting.");
      public static readonly TypeLogLevel warning = new TypeLogLevel((int)R__ConsoleLogEntry__Level.Warning,"warning","Mid level priority, tags and highlights possible issues in blue.");
      public static readonly TypeLogLevel error = new TypeLogLevel((int)R__ConsoleLogEntry__Level.Error,"error","Highest priority level, extreme emphasis on this entry. Highlighted in red.");
      };

/// <summary>
/// TypeMarkerKnotType
/// </summary>

 public sealed class TypeMarkerKnotType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeMarkerKnotType> mdict = new Dictionary<int, TypeMarkerKnotType>();
        static readonly Dictionary<string, TypeMarkerKnotType> msdict = new Dictionary<string, TypeMarkerKnotType>();

        public static implicit operator TypeMarkerKnotType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeMarkerKnotType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeMarkerKnotType(string s)
            {
            return msdict[s];
            }


        private TypeMarkerKnotType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeMarkerKnotType Normal = new TypeMarkerKnotType((int)R__Marker__KnotType.KnotTypeNormal,"Normal","Knot will have a smooth camera translation/rotation effect. n");
      public static readonly TypeMarkerKnotType Position_Only = new TypeMarkerKnotType((int)R__Marker__KnotType.KnotTypePositionOnly,"Position Only","Will do the same for translations, leaving rotation un-touched. n");
      public static readonly TypeMarkerKnotType Kink = new TypeMarkerKnotType((int)R__Marker__KnotType.KnotTypeKink,"Kink","The rotation will take effect immediately for an abrupt rotation change. n");
      };

/// <summary>
/// TypeMarkerSmoothingType
/// </summary>

 public sealed class TypeMarkerSmoothingType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeMarkerSmoothingType> mdict = new Dictionary<int, TypeMarkerSmoothingType>();
        static readonly Dictionary<string, TypeMarkerSmoothingType> msdict = new Dictionary<string, TypeMarkerSmoothingType>();

        public static implicit operator TypeMarkerSmoothingType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeMarkerSmoothingType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeMarkerSmoothingType(string s)
            {
            return msdict[s];
            }


        private TypeMarkerSmoothingType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeMarkerSmoothingType Spline = new TypeMarkerSmoothingType((int)R__Marker__SmoothingType.SmoothingTypeSpline,"Spline","Marker will cause the movements of the pathed object to be smooth. n");
      public static readonly TypeMarkerSmoothingType Linear = new TypeMarkerSmoothingType((int)R__Marker__SmoothingType.SmoothingTypeLinear,"Linear","Marker will have no smoothing effect. n");
      };

/// <summary>
/// TypeMaterialAnimType
/// </summary>

 public sealed class TypeMaterialAnimType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeMaterialAnimType> mdict = new Dictionary<int, TypeMaterialAnimType>();
        static readonly Dictionary<string, TypeMaterialAnimType> msdict = new Dictionary<string, TypeMaterialAnimType>();

        public static implicit operator TypeMaterialAnimType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeMaterialAnimType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeMaterialAnimType(string s)
            {
            return msdict[s];
            }


        private TypeMaterialAnimType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeMaterialAnimType Scroll = new TypeMaterialAnimType((int)R__Material__AnimType.Scroll,"Scroll","Scroll the material along the X/Y axis. n");
      public static readonly TypeMaterialAnimType Rotate = new TypeMaterialAnimType((int)R__Material__AnimType.Rotate,"Rotate","Rotate the material around a point. n");
      public static readonly TypeMaterialAnimType Wave = new TypeMaterialAnimType((int)R__Material__AnimType.Wave,"Wave","Warps the material with an animation using Sin, Triangle or Square mathematics. n");
      public static readonly TypeMaterialAnimType Scale = new TypeMaterialAnimType((int)R__Material__AnimType.Scale,"Scale","Scales the material larger and smaller with a pulsing effect. n");
      public static readonly TypeMaterialAnimType Sequence = new TypeMaterialAnimType((int)R__Material__AnimType.Sequence,"Sequence","Enables the material to have multiple frames of animation in its imagemap. n");
      };

/// <summary>
/// TypeMaterialBlendOp
/// </summary>

 public sealed class TypeMaterialBlendOp  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeMaterialBlendOp> mdict = new Dictionary<int, TypeMaterialBlendOp>();
        static readonly Dictionary<string, TypeMaterialBlendOp> msdict = new Dictionary<string, TypeMaterialBlendOp>();

        public static implicit operator TypeMaterialBlendOp(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeMaterialBlendOp t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeMaterialBlendOp(string s)
            {
            return msdict[s];
            }


        private TypeMaterialBlendOp(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeMaterialBlendOp None = new TypeMaterialBlendOp((int)R__Material__BlendOp.None,"None","Disable blending for this material.");
      public static readonly TypeMaterialBlendOp Mul = new TypeMaterialBlendOp((int)R__Material__BlendOp.Mul,"Mul","Multiplicative blending.");
      public static readonly TypeMaterialBlendOp Add = new TypeMaterialBlendOp((int)R__Material__BlendOp.Add,"Add","Adds the color of the material to the frame buffer with full alpha for each pixel.");
      public static readonly TypeMaterialBlendOp AddAlpha = new TypeMaterialBlendOp((int)R__Material__BlendOp.AddAlpha,"AddAlpha","The color is modulated by the alpha channel before being added to the frame buffer.");
      public static readonly TypeMaterialBlendOp Sub = new TypeMaterialBlendOp((int)R__Material__BlendOp.Sub,"Sub","Subtractive Blending. Reverses the color model, causing dark colors to have a stronger visual effect.");
      public static readonly TypeMaterialBlendOp LerpAlpha = new TypeMaterialBlendOp((int)R__Material__BlendOp.LerpAlpha,"LerpAlpha","Linearly interpolates between Material color and frame buffer color based on alpha.");
      };

/// <summary>
/// TypeMaterialWaveType
/// </summary>

 public sealed class TypeMaterialWaveType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeMaterialWaveType> mdict = new Dictionary<int, TypeMaterialWaveType>();
        static readonly Dictionary<string, TypeMaterialWaveType> msdict = new Dictionary<string, TypeMaterialWaveType>();

        public static implicit operator TypeMaterialWaveType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeMaterialWaveType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeMaterialWaveType(string s)
            {
            return msdict[s];
            }


        private TypeMaterialWaveType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeMaterialWaveType Sin = new TypeMaterialWaveType((int)R__Material__WaveType.Sin,"Sin","Warps the material along a curved Sin Wave.");
      public static readonly TypeMaterialWaveType Triangle = new TypeMaterialWaveType((int)R__Material__WaveType.Triangle,"Triangle","Warps the material along a sharp Triangle Wave.");
      public static readonly TypeMaterialWaveType Square = new TypeMaterialWaveType((int)R__Material__WaveType.Square,"Square","Warps the material along a wave which transitions between two oppposite states. As a Square Wave, the transition is quick and sudden.");
      };

/// <summary>
/// TypeMBButtons
/// </summary>

 public sealed class TypeMBButtons  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeMBButtons> mdict = new Dictionary<int, TypeMBButtons>();
        static readonly Dictionary<string, TypeMBButtons> msdict = new Dictionary<string, TypeMBButtons>();

        public static implicit operator TypeMBButtons(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeMBButtons t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeMBButtons(string s)
            {
            return msdict[s];
            }


        private TypeMBButtons(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeMBButtons Ok = new TypeMBButtons((int)R__MBButtons.MBOk,"Ok","");
      public static readonly TypeMBButtons OkCancel = new TypeMBButtons((int)R__MBButtons.MBOkCancel,"OkCancel","");
      public static readonly TypeMBButtons RetryCancel = new TypeMBButtons((int)R__MBButtons.MBRetryCancel,"RetryCancel","");
      public static readonly TypeMBButtons SaveDontSave = new TypeMBButtons((int)R__MBButtons.MBSaveDontSave,"SaveDontSave","");
      public static readonly TypeMBButtons SaveDontSaveCancel = new TypeMBButtons((int)R__MBButtons.MBSaveDontSaveCancel,"SaveDontSaveCancel","");
      };

/// <summary>
/// TypeMBIcons
/// </summary>

 public sealed class TypeMBIcons  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeMBIcons> mdict = new Dictionary<int, TypeMBIcons>();
        static readonly Dictionary<string, TypeMBIcons> msdict = new Dictionary<string, TypeMBIcons>();

        public static implicit operator TypeMBIcons(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeMBIcons t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeMBIcons(string s)
            {
            return msdict[s];
            }


        private TypeMBIcons(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeMBIcons Information = new TypeMBIcons((int)R__MBIcons.MIInformation,"Information","");
      public static readonly TypeMBIcons Warning = new TypeMBIcons((int)R__MBIcons.MIWarning,"Warning","");
      public static readonly TypeMBIcons Stop = new TypeMBIcons((int)R__MBIcons.MIStop,"Stop","");
      public static readonly TypeMBIcons Question = new TypeMBIcons((int)R__MBIcons.MIQuestion,"Question","");
      };

/// <summary>
/// TypeMBReturnVal
/// </summary>

 public sealed class TypeMBReturnVal  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeMBReturnVal> mdict = new Dictionary<int, TypeMBReturnVal>();
        static readonly Dictionary<string, TypeMBReturnVal> msdict = new Dictionary<string, TypeMBReturnVal>();

        public static implicit operator TypeMBReturnVal(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeMBReturnVal t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeMBReturnVal(string s)
            {
            return msdict[s];
            }


        private TypeMBReturnVal(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeMBReturnVal OK = new TypeMBReturnVal((int)R__MBReturnVal.MROk,"OK","");
      public static readonly TypeMBReturnVal Cancelled = new TypeMBReturnVal((int)R__MBReturnVal.MRCancel,"Cancelled","");
      public static readonly TypeMBReturnVal Retry = new TypeMBReturnVal((int)R__MBReturnVal.MRRetry,"Retry","");
      public static readonly TypeMBReturnVal DontSave = new TypeMBReturnVal((int)R__MBReturnVal.MRDontSave,"DontSave","");
      };

/// <summary>
/// TypeNavMeshWaterMethod
/// </summary>

 public sealed class TypeNavMeshWaterMethod  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeNavMeshWaterMethod> mdict = new Dictionary<int, TypeNavMeshWaterMethod>();
        static readonly Dictionary<string, TypeNavMeshWaterMethod> msdict = new Dictionary<string, TypeNavMeshWaterMethod>();

        public static implicit operator TypeNavMeshWaterMethod(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeNavMeshWaterMethod t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeNavMeshWaterMethod(string s)
            {
            return msdict[s];
            }


        private TypeNavMeshWaterMethod(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeNavMeshWaterMethod Ignore = new TypeNavMeshWaterMethod((int)R__NavMesh__WaterMethod.Ignore,"Ignore","Ignore all water surfaces. n");
      public static readonly TypeNavMeshWaterMethod Solid = new TypeNavMeshWaterMethod((int)R__NavMesh__WaterMethod.Solid,"Solid","Treat water surfaces as solid and walkable. n");
      public static readonly TypeNavMeshWaterMethod Impassable = new TypeNavMeshWaterMethod((int)R__NavMesh__WaterMethod.Impassable,"Impassable","Treat water as an impassable obstacle. n");
      };

/// <summary>
/// TypeParticleBlendStyle
/// </summary>

 public sealed class TypeParticleBlendStyle  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeParticleBlendStyle> mdict = new Dictionary<int, TypeParticleBlendStyle>();
        static readonly Dictionary<string, TypeParticleBlendStyle> msdict = new Dictionary<string, TypeParticleBlendStyle>();

        public static implicit operator TypeParticleBlendStyle(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeParticleBlendStyle t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeParticleBlendStyle(string s)
            {
            return msdict[s];
            }


        private TypeParticleBlendStyle(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeParticleBlendStyle NORMAL = new TypeParticleBlendStyle((int)R__ParticleRenderInst__BlendStyle.BlendNormal,"NORMAL","No blending style. n");
      public static readonly TypeParticleBlendStyle ADDITIVE = new TypeParticleBlendStyle((int)R__ParticleRenderInst__BlendStyle.BlendAdditive,"ADDITIVE","Adds the color of the pixel to the frame buffer with full alpha for each pixel. n");
      public static readonly TypeParticleBlendStyle SUBTRACTIVE = new TypeParticleBlendStyle((int)R__ParticleRenderInst__BlendStyle.BlendSubtractive,"SUBTRACTIVE","Subtractive Blending. Reverses the color model, causing dark colors to have a stronger visual effect. n");
      public static readonly TypeParticleBlendStyle PREMULTALPHA = new TypeParticleBlendStyle((int)R__ParticleRenderInst__BlendStyle.BlendPremultAlpha,"PREMULTALPHA","Color blends with the colors of the imagemap rather than the alpha. n");
      };

/// <summary>
/// TypePathShapeState
/// </summary>

 public sealed class TypePathShapeState  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypePathShapeState> mdict = new Dictionary<int, TypePathShapeState>();
        static readonly Dictionary<string, TypePathShapeState> msdict = new Dictionary<string, TypePathShapeState>();

        public static implicit operator TypePathShapeState(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypePathShapeState t)
            {
            return t.realEnum;
            }

        public static implicit operator TypePathShapeState(string s)
            {
            return msdict[s];
            }


        private TypePathShapeState(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypePathShapeState Forward = new TypePathShapeState((int)R__TSPathShape__MoveState.Forward,"Forward","Move forward along the path.");
      public static readonly TypePathShapeState Backward = new TypePathShapeState((int)R__TSPathShape__MoveState.Backward,"Backward","Move backward along the path");
      public static readonly TypePathShapeState Stop = new TypePathShapeState((int)R__TSPathShape__MoveState.Stop,"Stop","Stop shape movement.");
      };

/// <summary>
/// TypePFXRenderTime
/// </summary>

 public sealed class TypePFXRenderTime  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypePFXRenderTime> mdict = new Dictionary<int, TypePFXRenderTime>();
        static readonly Dictionary<string, TypePFXRenderTime> msdict = new Dictionary<string, TypePFXRenderTime>();

        public static implicit operator TypePFXRenderTime(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypePFXRenderTime t)
            {
            return t.realEnum;
            }

        public static implicit operator TypePFXRenderTime(string s)
            {
            return msdict[s];
            }


        private TypePFXRenderTime(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypePFXRenderTime PFXBeforeBin = new TypePFXRenderTime((int)R__PFXRenderTime.PFXBeforeBin,"PFXBeforeBin","Before a RenderInstManager bin. n");
      public static readonly TypePFXRenderTime PFXAfterBin = new TypePFXRenderTime((int)R__PFXRenderTime.PFXAfterBin,"PFXAfterBin","After a RenderInstManager bin. n");
      public static readonly TypePFXRenderTime PFXAfterDiffuse = new TypePFXRenderTime((int)R__PFXRenderTime.PFXAfterDiffuse,"PFXAfterDiffuse","After the diffuse rendering pass. n");
      public static readonly TypePFXRenderTime PFXEndOfFrame = new TypePFXRenderTime((int)R__PFXRenderTime.PFXEndOfFrame,"PFXEndOfFrame","When the end of the frame is reached. n");
      public static readonly TypePFXRenderTime PFXTexGenOnDemand = new TypePFXRenderTime((int)R__PFXRenderTime.PFXTexGenOnDemand,"PFXTexGenOnDemand","This PostEffect is not processed by the manager. It will generate its texture when it is requested. n");
      };

/// <summary>
/// TypePFXTargetClear
/// </summary>

 public sealed class TypePFXTargetClear  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypePFXTargetClear> mdict = new Dictionary<int, TypePFXTargetClear>();
        static readonly Dictionary<string, TypePFXTargetClear> msdict = new Dictionary<string, TypePFXTargetClear>();

        public static implicit operator TypePFXTargetClear(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypePFXTargetClear t)
            {
            return t.realEnum;
            }

        public static implicit operator TypePFXTargetClear(string s)
            {
            return msdict[s];
            }


        private TypePFXTargetClear(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypePFXTargetClear PFXTargetClear_None = new TypePFXTargetClear((int)R__PFXTargetClear.PFXTargetClear_None,"PFXTargetClear_None","Never clear the PostEffect target. n");
      public static readonly TypePFXTargetClear PFXTargetClear_OnCreate = new TypePFXTargetClear((int)R__PFXTargetClear.PFXTargetClear_OnCreate,"PFXTargetClear_OnCreate","Clear once on create. n");
      public static readonly TypePFXTargetClear PFXTargetClear_OnDraw = new TypePFXTargetClear((int)R__PFXTargetClear.PFXTargetClear_OnDraw,"PFXTargetClear_OnDraw","Clear before every draw. n");
      };

/// <summary>
/// TypePFXTargetViewport
/// </summary>

 public sealed class TypePFXTargetViewport  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypePFXTargetViewport> mdict = new Dictionary<int, TypePFXTargetViewport>();
        static readonly Dictionary<string, TypePFXTargetViewport> msdict = new Dictionary<string, TypePFXTargetViewport>();

        public static implicit operator TypePFXTargetViewport(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypePFXTargetViewport t)
            {
            return t.realEnum;
            }

        public static implicit operator TypePFXTargetViewport(string s)
            {
            return msdict[s];
            }


        private TypePFXTargetViewport(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypePFXTargetViewport PFXTargetViewport_TargetSize = new TypePFXTargetViewport((int)R__PFXTargetViewport.PFXTargetViewport_TargetSize,"PFXTargetViewport_TargetSize","Set viewport to match target size (default). n");
      public static readonly TypePFXTargetViewport PFXTargetViewport_GFXViewport = new TypePFXTargetViewport((int)R__PFXTargetViewport.PFXTargetViewport_GFXViewport,"PFXTargetViewport_GFXViewport","Use the current GFX viewport (scaled to match target size). n");
      };

/// <summary>
/// TypePhysicsSimType
/// </summary>

 public sealed class TypePhysicsSimType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypePhysicsSimType> mdict = new Dictionary<int, TypePhysicsSimType>();
        static readonly Dictionary<string, TypePhysicsSimType> msdict = new Dictionary<string, TypePhysicsSimType>();

        public static implicit operator TypePhysicsSimType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypePhysicsSimType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypePhysicsSimType(string s)
            {
            return msdict[s];
            }


        private TypePhysicsSimType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypePhysicsSimType ClientOnly = new TypePhysicsSimType((int)R__PhysicsShapeData__SimType.SimType_ClientOnly,"ClientOnly","Only handle physics on the client. n");
      public static readonly TypePhysicsSimType ServerOnly = new TypePhysicsSimType((int)R__PhysicsShapeData__SimType.SimType_ServerOnly,"ServerOnly","Only handle physics on the server. n");
      public static readonly TypePhysicsSimType ClientServer = new TypePhysicsSimType((int)R__PhysicsShapeData__SimType.SimType_ClientServer,"ClientServer","Handle physics on both the client and server. n");
      };

/// <summary>
/// TypePlayerPose
/// </summary>

 public sealed class TypePlayerPose  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypePlayerPose> mdict = new Dictionary<int, TypePlayerPose>();
        static readonly Dictionary<string, TypePlayerPose> msdict = new Dictionary<string, TypePlayerPose>();

        public static implicit operator TypePlayerPose(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypePlayerPose t)
            {
            return t.realEnum;
            }

        public static implicit operator TypePlayerPose(string s)
            {
            return msdict[s];
            }


        private TypePlayerPose(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypePlayerPose Stand = new TypePlayerPose((int)R__Player__Pose.StandPose,"Stand","Standard movement pose. n");
      public static readonly TypePlayerPose Sprint = new TypePlayerPose((int)R__Player__Pose.SprintPose,"Sprint","Sprinting pose. n");
      public static readonly TypePlayerPose Crouch = new TypePlayerPose((int)R__Player__Pose.CrouchPose,"Crouch","Crouch pose. n");
      public static readonly TypePlayerPose Prone = new TypePlayerPose((int)R__Player__Pose.PronePose,"Prone","Prone pose. n");
      public static readonly TypePlayerPose Swim = new TypePlayerPose((int)R__Player__Pose.SwimPose,"Swim","Swimming pose. n");
      };

/// <summary>
/// TypeRenderTexTargetSize
/// </summary>

 public sealed class TypeRenderTexTargetSize  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeRenderTexTargetSize> mdict = new Dictionary<int, TypeRenderTexTargetSize>();
        static readonly Dictionary<string, TypeRenderTexTargetSize> msdict = new Dictionary<string, TypeRenderTexTargetSize>();

        public static implicit operator TypeRenderTexTargetSize(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeRenderTexTargetSize t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeRenderTexTargetSize(string s)
            {
            return msdict[s];
            }


        private TypeRenderTexTargetSize(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeRenderTexTargetSize windowsize = new TypeRenderTexTargetSize((int)R__RenderTexTargetBinManager__TargetSizeType.WindowSize,"windowsize","Render to the size of the window. n");
      public static readonly TypeRenderTexTargetSize windowsizescaled = new TypeRenderTexTargetSize((int)R__RenderTexTargetBinManager__TargetSizeType.WindowSizeScaled,"windowsizescaled","Render to the size of the window, scaled to the render target's size. n");
      public static readonly TypeRenderTexTargetSize fixedsize = new TypeRenderTexTargetSize((int)R__RenderTexTargetBinManager__TargetSizeType.FixedSize,"fixedsize","Don't scale the target texture, and render to its default size. n");
      };

/// <summary>
/// TypeSFXChannel
/// </summary>

 public sealed class TypeSFXChannel  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeSFXChannel> mdict = new Dictionary<int, TypeSFXChannel>();
        static readonly Dictionary<string, TypeSFXChannel> msdict = new Dictionary<string, TypeSFXChannel>();

        public static implicit operator TypeSFXChannel(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeSFXChannel t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeSFXChannel(string s)
            {
            return msdict[s];
            }


        private TypeSFXChannel(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeSFXChannel Volume = new TypeSFXChannel((int)R__SFXChannel.SFXChannelVolume,"Volume","Channel controls volume level of attached sound sources. n          @see SFXDescription::volume  ");
      public static readonly TypeSFXChannel Pitch = new TypeSFXChannel((int)R__SFXChannel.SFXChannelPitch,"Pitch","Channel controls pitch of attached sound sources. n          @see SFXDescription::pitch  ");
      public static readonly TypeSFXChannel Priority = new TypeSFXChannel((int)R__SFXChannel.SFXChannelPriority,"Priority","Channel controls virtualizaton priority level of attached sound sources. n          @see SFXDescription::priority  ");
      public static readonly TypeSFXChannel PositionX = new TypeSFXChannel((int)R__SFXChannel.SFXChannelPositionX,"PositionX","         Channel controls X coordinate of 3D sound position of attached sources.  ");
      public static readonly TypeSFXChannel PositionY = new TypeSFXChannel((int)R__SFXChannel.SFXChannelPositionY,"PositionY","         Channel controls Y coordinate of 3D sound position of attached sources.  ");
      public static readonly TypeSFXChannel PositionZ = new TypeSFXChannel((int)R__SFXChannel.SFXChannelPositionZ,"PositionZ","         Channel controls Z coordinate of 3D sound position of attached sources.  ");
      public static readonly TypeSFXChannel RotationX = new TypeSFXChannel((int)R__SFXChannel.SFXChannelRotationX,"RotationX","         Channel controls X rotation (in degrees) of 3D sound orientation of attached sources.  ");
      public static readonly TypeSFXChannel RotationY = new TypeSFXChannel((int)R__SFXChannel.SFXChannelRotationY,"RotationY","         Channel controls Y rotation (in degrees) of 3D sound orientation of attached sources.  ");
      public static readonly TypeSFXChannel RotationZ = new TypeSFXChannel((int)R__SFXChannel.SFXChannelRotationZ,"RotationZ","         Channel controls Z rotation (in degrees) of 3D sound orientation of attached sources.  ");
      public static readonly TypeSFXChannel VelocityX = new TypeSFXChannel((int)R__SFXChannel.SFXChannelVelocityX,"VelocityX","         Channel controls X coordinate of 3D sound velocity vector of attached sources.  ");
      public static readonly TypeSFXChannel VelocityY = new TypeSFXChannel((int)R__SFXChannel.SFXChannelVelocityY,"VelocityY","         Channel controls Y coordinate of 3D sound velocity vector of attached sources.  ");
      public static readonly TypeSFXChannel VelocityZ = new TypeSFXChannel((int)R__SFXChannel.SFXChannelVelocityZ,"VelocityZ","         Channel controls Z coordinate of 3D sound velocity vector of attached sources.  ");
      public static readonly TypeSFXChannel ReferenceDistance = new TypeSFXChannel((int)R__SFXChannel.SFXChannelMinDistance,"ReferenceDistance","Channel controls reference distance of 3D sound of attached sources. n          @see SFXDescription::referenceDistance  ");
      public static readonly TypeSFXChannel MaxDistance = new TypeSFXChannel((int)R__SFXChannel.SFXChannelMaxDistance,"MaxDistance","Channel controls max volume attenuation distance of 3D sound of attached sources. n          @see SFXDescription::maxDistance  ");
      public static readonly TypeSFXChannel ConeInsideAngle = new TypeSFXChannel((int)R__SFXChannel.SFXChannelConeInsideAngle,"ConeInsideAngle","Channel controls angle (in degrees) of 3D sound inner volume cone of attached sources. n          @see SFXDescription::coneInsideAngle  ");
      public static readonly TypeSFXChannel ConeOutsideAngle = new TypeSFXChannel((int)R__SFXChannel.SFXChannelConeOutsideAngle,"ConeOutsideAngle","Channel controls angle (in degrees) of 3D sound outer volume cone of attached sources. n          @see SFXDescription::coneOutsideAngle  ");
      public static readonly TypeSFXChannel ConeOutsideVolume = new TypeSFXChannel((int)R__SFXChannel.SFXChannelConeOutsideVolume,"ConeOutsideVolume","Channel controls volume outside of 3D sound outer cone of attached sources. n          @see SFXDescription::coneOutsideVolume  ");
      public static readonly TypeSFXChannel Cursor = new TypeSFXChannel((int)R__SFXChannel.SFXChannelCursor,"Cursor","Channel controls playback cursor of attached sound sources. n n          @note Be aware that different types of sound sources interpret play cursor positions differently              or do not actually have play cursors (these sources will ignore the channel).  ");
      public static readonly TypeSFXChannel Status = new TypeSFXChannel((int)R__SFXChannel.SFXChannelStatus,"Status","Channel controls playback status of attached sound sources. n n          The channel's value is rounded down to the nearest integer and interpreted in the following way: n          - 1: Play n          - 2: Stop n          - 3: Pause n n  ");
      public static readonly TypeSFXChannel User0 = new TypeSFXChannel((int)R__SFXChannel.SFXChannelUser0,"User0","Channel available for custom use.  By default ignored by sources. n n          @note For FMOD Designer event sources (SFXFMODEventSource), this channel is used for event parameters              defined in FMOD Designer and should not be used otherwise. n n          @see SFXSource::onParameterValueChange  ");
      public static readonly TypeSFXChannel User1 = new TypeSFXChannel((int)R__SFXChannel.SFXChannelUser1,"User1","Channel available for custom use.  By default ignored by sources. n n          @see SFXSource::onParameterValueChange  ");
      public static readonly TypeSFXChannel User2 = new TypeSFXChannel((int)R__SFXChannel.SFXChannelUser2,"User2","Channel available for custom use.  By default ignored by sources. n n          @see SFXSource::onParameterValueChange  ");
      public static readonly TypeSFXChannel User3 = new TypeSFXChannel((int)R__SFXChannel.SFXChannelUser3,"User3","Channel available for custom use.  By default ignored by sources. n n          @see SFXSource::onParameterValueChange  ");
      };

/// <summary>
/// TypeSFXDistanceModel
/// </summary>

 public sealed class TypeSFXDistanceModel  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeSFXDistanceModel> mdict = new Dictionary<int, TypeSFXDistanceModel>();
        static readonly Dictionary<string, TypeSFXDistanceModel> msdict = new Dictionary<string, TypeSFXDistanceModel>();

        public static implicit operator TypeSFXDistanceModel(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeSFXDistanceModel t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeSFXDistanceModel(string s)
            {
            return msdict[s];
            }


        private TypeSFXDistanceModel(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeSFXDistanceModel Linear = new TypeSFXDistanceModel((int)R__SFXDistanceModel.SFXDistanceModelLinear,"Linear","         Volume attenuates linearly from the references distance onwards to max distance where it reaches zero.  ");
      public static readonly TypeSFXDistanceModel Logarithmic = new TypeSFXDistanceModel((int)R__SFXDistanceModel.SFXDistanceModelLogarithmic,"Logarithmic","Volume attenuates logarithmically starting from the reference distance and halving every reference distance step from there on.           Attenuation stops at max distance but volume won't reach zero.  ");
      };

/// <summary>
/// TypeSFXPlayListLoopMode
/// </summary>

 public sealed class TypeSFXPlayListLoopMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeSFXPlayListLoopMode> mdict = new Dictionary<int, TypeSFXPlayListLoopMode>();
        static readonly Dictionary<string, TypeSFXPlayListLoopMode> msdict = new Dictionary<string, TypeSFXPlayListLoopMode>();

        public static implicit operator TypeSFXPlayListLoopMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeSFXPlayListLoopMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeSFXPlayListLoopMode(string s)
            {
            return msdict[s];
            }


        private TypeSFXPlayListLoopMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeSFXPlayListLoopMode All = new TypeSFXPlayListLoopMode((int)R__SFXPlayList__ELoopMode.LOOP_All,"All","         Loop over all slots, i.e. jump from last to first slot after all slots have played.  ");
      public static readonly TypeSFXPlayListLoopMode Single = new TypeSFXPlayListLoopMode((int)R__SFXPlayList__ELoopMode.LOOP_Single,"Single","         Loop infinitely over the current slot.  Only useful in combination with either states or manual playlist control.  ");
      };

/// <summary>
/// TypeSFXPlayListRandomMode
/// </summary>

 public sealed class TypeSFXPlayListRandomMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeSFXPlayListRandomMode> mdict = new Dictionary<int, TypeSFXPlayListRandomMode>();
        static readonly Dictionary<string, TypeSFXPlayListRandomMode> msdict = new Dictionary<string, TypeSFXPlayListRandomMode>();

        public static implicit operator TypeSFXPlayListRandomMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeSFXPlayListRandomMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeSFXPlayListRandomMode(string s)
            {
            return msdict[s];
            }


        private TypeSFXPlayListRandomMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeSFXPlayListRandomMode NotRandom = new TypeSFXPlayListRandomMode((int)R__SFXPlayList__ERandomMode.RANDOM_NotRandom,"NotRandom","         Play slots in sequential order.  No randomization.  ");
      public static readonly TypeSFXPlayListRandomMode StrictRandom = new TypeSFXPlayListRandomMode((int)R__SFXPlayList__ERandomMode.RANDOM_StrictRandom,"StrictRandom","Play a strictly random selection of slots. n n          In this mode, a set of numSlotsToPlay random numbers between 0 and numSlotsToPlay-1 (inclusive), i.e. in the range of valid slot indices, is           generated and playlist slots are played back in the order of this list.  This allows the same slot to occur multiple times in a list and,           consequentially, allows for other slots to not appear at all in a given slot ordering.  ");
      public static readonly TypeSFXPlayListRandomMode OrderedRandom = new TypeSFXPlayListRandomMode((int)R__SFXPlayList__ERandomMode.RANDOM_OrderedRandom,"OrderedRandom","Play all slots in the list in a random order. n n          In this mode, the @c numSlotsToPlay slots from the list with valid tracks assigned are put into a random order and played.  This guarantees           that each slots is played exactly once albeit at a random position in the total ordering.  ");
      };

/// <summary>
/// TypeSFXPlayListReplayMode
/// </summary>

 public sealed class TypeSFXPlayListReplayMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeSFXPlayListReplayMode> mdict = new Dictionary<int, TypeSFXPlayListReplayMode>();
        static readonly Dictionary<string, TypeSFXPlayListReplayMode> msdict = new Dictionary<string, TypeSFXPlayListReplayMode>();

        public static implicit operator TypeSFXPlayListReplayMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeSFXPlayListReplayMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeSFXPlayListReplayMode(string s)
            {
            return msdict[s];
            }


        private TypeSFXPlayListReplayMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeSFXPlayListReplayMode IgnorePlaying = new TypeSFXPlayListReplayMode((int)R__SFXPlayList__EReplayMode.REPLAY_IgnorePlaying,"IgnorePlaying","         Ignore any sources that may already be playing on the slot and just create a new source.  ");
      public static readonly TypeSFXPlayListReplayMode RestartPlaying = new TypeSFXPlayListReplayMode((int)R__SFXPlayList__EReplayMode.REPLAY_RestartPlaying,"RestartPlaying","         Restart all sources that was last created for the slot.  ");
      public static readonly TypeSFXPlayListReplayMode KeepPlaying = new TypeSFXPlayListReplayMode((int)R__SFXPlayList__EReplayMode.REPLAY_KeepPlaying,"KeepPlaying","Keep playing the current source(s) as if the source started last on the slot was created in this cycle.  For this,           the sources associated with the slot are brought to the top of the play stack.  ");
      public static readonly TypeSFXPlayListReplayMode StartNew = new TypeSFXPlayListReplayMode((int)R__SFXPlayList__EReplayMode.REPLAY_StartNew,"StartNew","         Stop all sources currently playing on the slot and then create a new source.  ");
      public static readonly TypeSFXPlayListReplayMode SkipIfPlaying = new TypeSFXPlayListReplayMode((int)R__SFXPlayList__EReplayMode.REPLAY_SkipIfPlaying,"SkipIfPlaying","         If there are sources already playing on the slot, skip the play stage.  ");
      };

/// <summary>
/// TypeSFXPlayListStateMode
/// </summary>

 public sealed class TypeSFXPlayListStateMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeSFXPlayListStateMode> mdict = new Dictionary<int, TypeSFXPlayListStateMode>();
        static readonly Dictionary<string, TypeSFXPlayListStateMode> msdict = new Dictionary<string, TypeSFXPlayListStateMode>();

        public static implicit operator TypeSFXPlayListStateMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeSFXPlayListStateMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeSFXPlayListStateMode(string s)
            {
            return msdict[s];
            }


        private TypeSFXPlayListStateMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeSFXPlayListStateMode StopWhenDeactivated = new TypeSFXPlayListStateMode((int)R__SFXPlayList__EStateMode.STATE_StopInactive,"StopWhenDeactivated","Stop the sources playing on the slot when a state changes to a setting that is incompatible with           the slot's state setting.  ");
      public static readonly TypeSFXPlayListStateMode PauseWhenDeactivated = new TypeSFXPlayListStateMode((int)R__SFXPlayList__EStateMode.STATE_PauseInactive,"PauseWhenDeactivated","Pause all sources playing on the slot when a state changes to a setting that is incompatible with the           slot's state setting. n n          When the slot's state is reactivated again, the sources will resume playback.  ");
      public static readonly TypeSFXPlayListStateMode IgnoreWhenDeactivated = new TypeSFXPlayListStateMode((int)R__SFXPlayList__EStateMode.STATE_IgnoreInactive,"IgnoreWhenDeactivated","Ignore when a state changes to a setting incompatible with the slot's state setting and just keep           playing sources attached to the slot.  ");
      };

/// <summary>
/// TypeSFXPlayListTransitionMode
/// </summary>

 public sealed class TypeSFXPlayListTransitionMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeSFXPlayListTransitionMode> mdict = new Dictionary<int, TypeSFXPlayListTransitionMode>();
        static readonly Dictionary<string, TypeSFXPlayListTransitionMode> msdict = new Dictionary<string, TypeSFXPlayListTransitionMode>();

        public static implicit operator TypeSFXPlayListTransitionMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeSFXPlayListTransitionMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeSFXPlayListTransitionMode(string s)
            {
            return msdict[s];
            }


        private TypeSFXPlayListTransitionMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeSFXPlayListTransitionMode None = new TypeSFXPlayListTransitionMode((int)R__SFXPlayList__ETransitionMode.TRANSITION_None,"None","         No transition.  Immediately move on to processing the slot or immediately move on to the next slot.  ");
      public static readonly TypeSFXPlayListTransitionMode Wait = new TypeSFXPlayListTransitionMode((int)R__SFXPlayList__ETransitionMode.TRANSITION_Wait,"Wait","         Wait for the sound source spawned last by this playlist to finish playing.  Then proceed.  ");
      public static readonly TypeSFXPlayListTransitionMode WaitAll = new TypeSFXPlayListTransitionMode((int)R__SFXPlayList__ETransitionMode.TRANSITION_WaitAll,"WaitAll","         Wait for all sound sources currently spawned by the playlist to finish playing.  Then proceed.  ");
      public static readonly TypeSFXPlayListTransitionMode Stop = new TypeSFXPlayListTransitionMode((int)R__SFXPlayList__ETransitionMode.TRANSITION_Stop,"Stop","         Stop the sound source spawned last by this playlist.  Then proceed.  ");
      public static readonly TypeSFXPlayListTransitionMode StopAll = new TypeSFXPlayListTransitionMode((int)R__SFXPlayList__ETransitionMode.TRANSITION_StopAll,"StopAll","         Stop all sound sources spawned by the playlist.  Then proceed.  ");
      };

/// <summary>
/// TypeSFXStatus
/// </summary>

 public sealed class TypeSFXStatus  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeSFXStatus> mdict = new Dictionary<int, TypeSFXStatus>();
        static readonly Dictionary<string, TypeSFXStatus> msdict = new Dictionary<string, TypeSFXStatus>();

        public static implicit operator TypeSFXStatus(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeSFXStatus t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeSFXStatus(string s)
            {
            return msdict[s];
            }


        private TypeSFXStatus(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeSFXStatus Playing = new TypeSFXStatus((int)R__SFXStatus.SFXStatusPlaying,"Playing","         The source is currently playing.  ");
      public static readonly TypeSFXStatus Stopped = new TypeSFXStatus((int)R__SFXStatus.SFXStatusStopped,"Stopped","Playback of the source is stopped.  When transitioning to Playing state, playback will start at the beginning              of the source.  ");
      public static readonly TypeSFXStatus Paused = new TypeSFXStatus((int)R__SFXStatus.SFXStatusPaused,"Paused","         Playback of the source is paused.  Resuming playback will play from the current playback position.  ");
      };

/// <summary>
/// TypeShadowFilterMode
/// </summary>

 public sealed class TypeShadowFilterMode  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeShadowFilterMode> mdict = new Dictionary<int, TypeShadowFilterMode>();
        static readonly Dictionary<string, TypeShadowFilterMode> msdict = new Dictionary<string, TypeShadowFilterMode>();

        public static implicit operator TypeShadowFilterMode(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeShadowFilterMode t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeShadowFilterMode(string s)
            {
            return msdict[s];
            }


        private TypeShadowFilterMode(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeShadowFilterMode None = new TypeShadowFilterMode((int)R__ShadowFilterMode.ShadowFilterMode_None,"None","@brief Simple point sampled filtering. n          This is the fastest and lowest quality mode.  ");
      public static readonly TypeShadowFilterMode SoftShadow = new TypeShadowFilterMode((int)R__ShadowFilterMode.ShadowFilterMode_SoftShadow,"SoftShadow","@brief A variable tap rotated poisson disk soft shadow filter. n          It performs 4 taps to classify the point as in shadow, out of shadow, or along a           shadow edge.  Samples on the edge get an additional 8 taps to soften them.  ");
      public static readonly TypeShadowFilterMode SoftShadowHighQuality = new TypeShadowFilterMode((int)R__ShadowFilterMode.ShadowFilterMode_SoftShadowHighQuality,"SoftShadowHighQuality","@brief A 12 tap rotated poisson disk soft shadow filter. n          It performs all the taps for every point without any early rejection.  ");
      };

/// <summary>
/// TypeShadowType
/// </summary>

 public sealed class TypeShadowType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeShadowType> mdict = new Dictionary<int, TypeShadowType>();
        static readonly Dictionary<string, TypeShadowType> msdict = new Dictionary<string, TypeShadowType>();

        public static implicit operator TypeShadowType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeShadowType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeShadowType(string s)
            {
            return msdict[s];
            }


        private TypeShadowType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeShadowType Spot = new TypeShadowType((int)R__ShadowType.ShadowType_Spot,"Spot","");
      public static readonly TypeShadowType PSSM = new TypeShadowType((int)R__ShadowType.ShadowType_PSSM,"PSSM","");
      public static readonly TypeShadowType Paraboloid = new TypeShadowType((int)R__ShadowType.ShadowType_Paraboloid,"Paraboloid","");
      public static readonly TypeShadowType DualParaboloidSinglePass = new TypeShadowType((int)R__ShadowType.ShadowType_DualParaboloidSinglePass,"DualParaboloidSinglePass","");
      public static readonly TypeShadowType DualParaboloid = new TypeShadowType((int)R__ShadowType.ShadowType_DualParaboloid,"DualParaboloid","");
      public static readonly TypeShadowType CubeMap = new TypeShadowType((int)R__ShadowType.ShadowType_CubeMap,"CubeMap","");
      };

/// <summary>
/// TypeShapeBaseImageLightType
/// </summary>

 public sealed class TypeShapeBaseImageLightType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeShapeBaseImageLightType> mdict = new Dictionary<int, TypeShapeBaseImageLightType>();
        static readonly Dictionary<string, TypeShapeBaseImageLightType> msdict = new Dictionary<string, TypeShapeBaseImageLightType>();

        public static implicit operator TypeShapeBaseImageLightType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeShapeBaseImageLightType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeShapeBaseImageLightType(string s)
            {
            return msdict[s];
            }


        private TypeShapeBaseImageLightType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeShapeBaseImageLightType NoLight = new TypeShapeBaseImageLightType((int)R__ShapeBaseImageData__LightType.NoLight,"NoLight","No light is attached. n");
      public static readonly TypeShapeBaseImageLightType ConstantLight = new TypeShapeBaseImageLightType((int)R__ShapeBaseImageData__LightType.ConstantLight,"ConstantLight","A constant emitting light is attached. n");
      public static readonly TypeShapeBaseImageLightType SpotLight = new TypeShapeBaseImageLightType((int)R__ShapeBaseImageData__LightType.SpotLight,"SpotLight","A spotlight is attached. n");
      public static readonly TypeShapeBaseImageLightType PulsingLight = new TypeShapeBaseImageLightType((int)R__ShapeBaseImageData__LightType.PulsingLight,"PulsingLight","A pusling light is attached. n");
      public static readonly TypeShapeBaseImageLightType WeaponFireLight = new TypeShapeBaseImageLightType((int)R__ShapeBaseImageData__LightType.WeaponFireLight,"WeaponFireLight","Light emits when the weapon is fired, then dissipates. n");
      };

/// <summary>
/// TypeShapeBaseImageLoadedState
/// </summary>

 public sealed class TypeShapeBaseImageLoadedState  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeShapeBaseImageLoadedState> mdict = new Dictionary<int, TypeShapeBaseImageLoadedState>();
        static readonly Dictionary<string, TypeShapeBaseImageLoadedState> msdict = new Dictionary<string, TypeShapeBaseImageLoadedState>();

        public static implicit operator TypeShapeBaseImageLoadedState(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeShapeBaseImageLoadedState t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeShapeBaseImageLoadedState(string s)
            {
            return msdict[s];
            }


        private TypeShapeBaseImageLoadedState(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeShapeBaseImageLoadedState Ignore = new TypeShapeBaseImageLoadedState((int)R__ShapeBaseImageData__StateData__LoadedState.IgnoreLoaded,"Ignore","Ignore the loaded state. n");
      public static readonly TypeShapeBaseImageLoadedState Loaded = new TypeShapeBaseImageLoadedState((int)R__ShapeBaseImageData__StateData__LoadedState.Loaded,"Loaded","ShapeBaseImage is loaded. n");
      public static readonly TypeShapeBaseImageLoadedState Empty = new TypeShapeBaseImageLoadedState((int)R__ShapeBaseImageData__StateData__LoadedState.NotLoaded,"Empty","ShapeBaseImage is not loaded. n");
      };

/// <summary>
/// TypeShapeBaseImageRecoilState
/// </summary>

 public sealed class TypeShapeBaseImageRecoilState  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeShapeBaseImageRecoilState> mdict = new Dictionary<int, TypeShapeBaseImageRecoilState>();
        static readonly Dictionary<string, TypeShapeBaseImageRecoilState> msdict = new Dictionary<string, TypeShapeBaseImageRecoilState>();

        public static implicit operator TypeShapeBaseImageRecoilState(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeShapeBaseImageRecoilState t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeShapeBaseImageRecoilState(string s)
            {
            return msdict[s];
            }


        private TypeShapeBaseImageRecoilState(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeShapeBaseImageRecoilState NoRecoil = new TypeShapeBaseImageRecoilState((int)R__ShapeBaseImageData__StateData__RecoilState.NoRecoil,"NoRecoil","No recoil occurs. n");
      public static readonly TypeShapeBaseImageRecoilState LightRecoil = new TypeShapeBaseImageRecoilState((int)R__ShapeBaseImageData__StateData__RecoilState.LightRecoil,"LightRecoil","A light recoil occurs. n");
      public static readonly TypeShapeBaseImageRecoilState MediumRecoil = new TypeShapeBaseImageRecoilState((int)R__ShapeBaseImageData__StateData__RecoilState.MediumRecoil,"MediumRecoil","A medium recoil occurs. n");
      public static readonly TypeShapeBaseImageRecoilState HeavyRecoil = new TypeShapeBaseImageRecoilState((int)R__ShapeBaseImageData__StateData__RecoilState.HeavyRecoil,"HeavyRecoil","A heavy recoil occurs. n");
      };

/// <summary>
/// TypeShapeBaseImageSpinState
/// </summary>

 public sealed class TypeShapeBaseImageSpinState  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeShapeBaseImageSpinState> mdict = new Dictionary<int, TypeShapeBaseImageSpinState>();
        static readonly Dictionary<string, TypeShapeBaseImageSpinState> msdict = new Dictionary<string, TypeShapeBaseImageSpinState>();

        public static implicit operator TypeShapeBaseImageSpinState(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeShapeBaseImageSpinState t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeShapeBaseImageSpinState(string s)
            {
            return msdict[s];
            }


        private TypeShapeBaseImageSpinState(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeShapeBaseImageSpinState Ignore = new TypeShapeBaseImageSpinState((int)R__ShapeBaseImageData__StateData__SpinState.IgnoreSpin,"Ignore","No changes to the spin sequence. n");
      public static readonly TypeShapeBaseImageSpinState Stop = new TypeShapeBaseImageSpinState((int)R__ShapeBaseImageData__StateData__SpinState.NoSpin,"Stop","Stops the spin sequence at its current position n");
      public static readonly TypeShapeBaseImageSpinState SpinUp = new TypeShapeBaseImageSpinState((int)R__ShapeBaseImageData__StateData__SpinState.SpinUp,"SpinUp","Increase spin sequence timeScale from 0 (on state entry) to 1 (after stateTimeoutValue seconds). n");
      public static readonly TypeShapeBaseImageSpinState SpinDown = new TypeShapeBaseImageSpinState((int)R__ShapeBaseImageData__StateData__SpinState.SpinDown,"SpinDown","Decrease spin sequence timeScale from 1 (on state entry) to 0 (after stateTimeoutValue seconds). n");
      };

/// <summary>
/// TypeTSMeshType
/// </summary>

 public sealed class TypeTSMeshType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeTSMeshType> mdict = new Dictionary<int, TypeTSMeshType>();
        static readonly Dictionary<string, TypeTSMeshType> msdict = new Dictionary<string, TypeTSMeshType>();

        public static implicit operator TypeTSMeshType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeTSMeshType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeTSMeshType(string s)
            {
            return msdict[s];
            }


        private TypeTSMeshType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeTSMeshType None = new TypeTSMeshType((int)R__TSStatic__MeshType.None,"None","No mesh data.");
      public static readonly TypeTSMeshType Bounds = new TypeTSMeshType((int)R__TSStatic__MeshType.Bounds,"Bounds","Bounding box of the shape.");
      public static readonly TypeTSMeshType Collision_Mesh = new TypeTSMeshType((int)R__TSStatic__MeshType.CollisionMesh,"Collision Mesh","Specifically desingated   collision   meshes.  ");
      public static readonly TypeTSMeshType Visible_Mesh = new TypeTSMeshType((int)R__TSStatic__MeshType.VisibleMesh,"Visible Mesh","Rendered mesh polygons.");
      };

/// <summary>
/// TypeTSShapeConstructorLodType
/// </summary>

 public sealed class TypeTSShapeConstructorLodType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeTSShapeConstructorLodType> mdict = new Dictionary<int, TypeTSShapeConstructorLodType>();
        static readonly Dictionary<string, TypeTSShapeConstructorLodType> msdict = new Dictionary<string, TypeTSShapeConstructorLodType>();

        public static implicit operator TypeTSShapeConstructorLodType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeTSShapeConstructorLodType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeTSShapeConstructorLodType(string s)
            {
            return msdict[s];
            }


        private TypeTSShapeConstructorLodType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeTSShapeConstructorLodType DetectDTS = new TypeTSShapeConstructorLodType((int)R__ColladaUtils__ImportOptions__eLodType.DetectDTS,"DetectDTS","");
      public static readonly TypeTSShapeConstructorLodType SingleSize = new TypeTSShapeConstructorLodType((int)R__ColladaUtils__ImportOptions__eLodType.SingleSize,"SingleSize","");
      public static readonly TypeTSShapeConstructorLodType TrailingNumber = new TypeTSShapeConstructorLodType((int)R__ColladaUtils__ImportOptions__eLodType.TrailingNumber,"TrailingNumber","");
      };

/// <summary>
/// TypeTSShapeConstructorUpAxis
/// </summary>

 public sealed class TypeTSShapeConstructorUpAxis  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeTSShapeConstructorUpAxis> mdict = new Dictionary<int, TypeTSShapeConstructorUpAxis>();
        static readonly Dictionary<string, TypeTSShapeConstructorUpAxis> msdict = new Dictionary<string, TypeTSShapeConstructorUpAxis>();

        public static implicit operator TypeTSShapeConstructorUpAxis(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeTSShapeConstructorUpAxis t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeTSShapeConstructorUpAxis(string s)
            {
            return msdict[s];
            }


        private TypeTSShapeConstructorUpAxis(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeTSShapeConstructorUpAxis X_AXIS = new TypeTSShapeConstructorUpAxis((int)R__domUpAxisType.UPAXISTYPE_X_UP,"X_AXIS","");
      public static readonly TypeTSShapeConstructorUpAxis Y_AXIS = new TypeTSShapeConstructorUpAxis((int)R__domUpAxisType.UPAXISTYPE_Y_UP,"Y_AXIS","");
      public static readonly TypeTSShapeConstructorUpAxis Z_AXIS = new TypeTSShapeConstructorUpAxis((int)R__domUpAxisType.UPAXISTYPE_Z_UP,"Z_AXIS","");
      public static readonly TypeTSShapeConstructorUpAxis DEFAULT = new TypeTSShapeConstructorUpAxis((int)R__domUpAxisType.UPAXISTYPE_COUNT,"DEFAULT","");
      };

/// <summary>
/// TypeTurretShapeFireLinkType
/// </summary>

 public sealed class TypeTurretShapeFireLinkType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeTurretShapeFireLinkType> mdict = new Dictionary<int, TypeTurretShapeFireLinkType>();
        static readonly Dictionary<string, TypeTurretShapeFireLinkType> msdict = new Dictionary<string, TypeTurretShapeFireLinkType>();

        public static implicit operator TypeTurretShapeFireLinkType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeTurretShapeFireLinkType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeTurretShapeFireLinkType(string s)
            {
            return msdict[s];
            }


        private TypeTurretShapeFireLinkType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeTurretShapeFireLinkType FireTogether = new TypeTurretShapeFireLinkType((int)R__TurretShapeData__FireLinkType.FireTogether,"FireTogether","All weapons fire under trigger 0. n");
      public static readonly TypeTurretShapeFireLinkType GroupedFire = new TypeTurretShapeFireLinkType((int)R__TurretShapeData__FireLinkType.GroupedFire,"GroupedFire","Weapon mounts 0,2 fire under trigger 0, mounts 1,3 fire under trigger 1. n");
      public static readonly TypeTurretShapeFireLinkType IndividualFire = new TypeTurretShapeFireLinkType((int)R__TurretShapeData__FireLinkType.IndividualFire,"IndividualFire","Each weapon mount fires under its own trigger 0-3. n");
      };

/// <summary>
/// TypeWorldEditorAlignmentType
/// </summary>

 public sealed class TypeWorldEditorAlignmentType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeWorldEditorAlignmentType> mdict = new Dictionary<int, TypeWorldEditorAlignmentType>();
        static readonly Dictionary<string, TypeWorldEditorAlignmentType> msdict = new Dictionary<string, TypeWorldEditorAlignmentType>();

        public static implicit operator TypeWorldEditorAlignmentType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeWorldEditorAlignmentType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeWorldEditorAlignmentType(string s)
            {
            return msdict[s];
            }


        private TypeWorldEditorAlignmentType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeWorldEditorAlignmentType None = new TypeWorldEditorAlignmentType((int)R__WorldEditor__AlignmentType.AlignNone,"None","No alignement type. n");
      public static readonly TypeWorldEditorAlignmentType PlusX = new TypeWorldEditorAlignmentType((int)R__WorldEditor__AlignmentType.AlignPosX,"+X","Snap towards the higher position on the X plane. n");
      public static readonly TypeWorldEditorAlignmentType PlusY = new TypeWorldEditorAlignmentType((int)R__WorldEditor__AlignmentType.AlignPosY,"+Y","Snap towards the higher position on the Y plane. n");
      public static readonly TypeWorldEditorAlignmentType PlusZ = new TypeWorldEditorAlignmentType((int)R__WorldEditor__AlignmentType.AlignPosZ,"+Z","Snap towards the higher position on the Z plane. n");
      public static readonly TypeWorldEditorAlignmentType MinusX = new TypeWorldEditorAlignmentType((int)R__WorldEditor__AlignmentType.AlignNegX,"-X","Snap towards the lower position on the X plane. n");
      public static readonly TypeWorldEditorAlignmentType MinusY = new TypeWorldEditorAlignmentType((int)R__WorldEditor__AlignmentType.AlignNegY,"-Y","Snap towards the lower position on the Y plane. n");
      public static readonly TypeWorldEditorAlignmentType MinusZ = new TypeWorldEditorAlignmentType((int)R__WorldEditor__AlignmentType.AlignNegZ,"-Z","Snap towards the lower position on the Z plane. n");
      };

/// <summary>
/// TypeWorldEditorDropType
/// </summary>

 public sealed class TypeWorldEditorDropType  : iEnum
        {
         readonly int realEnum;
        readonly string tag;
        readonly string description;

        static readonly Dictionary<int, TypeWorldEditorDropType> mdict = new Dictionary<int, TypeWorldEditorDropType>();
        static readonly Dictionary<string, TypeWorldEditorDropType> msdict = new Dictionary<string, TypeWorldEditorDropType>();

        public static implicit operator TypeWorldEditorDropType(int i)
            {
            return mdict[i];
            }

        public static implicit operator int(TypeWorldEditorDropType t)
            {
            return t.realEnum;
            }

        public static implicit operator TypeWorldEditorDropType(string s)
            {
            return msdict[s];
            }


        private TypeWorldEditorDropType(int realEnum, String tag,string description)
            {
            mdict.Add(realEnum,this);
            msdict.Add(tag,this);
            this.realEnum = realEnum;
            this.tag = tag;
            this.description = description;
            }

        public int RealEnum
            {
            get { return realEnum; }
            }

        public string Description
            {
            get { return description; }
            }

        public string Tag
            {
            get { return tag; }
            }

        public override String ToString()
            {
            return Tag;
            }

        public string AsString()
            {
            return tag;
            }

        public List<string> keyList
            {
            get { return msdict.Keys.ToList(); }
            }
        public object this[string key]
            {
            get { return msdict[key]; }
            }

      public static readonly TypeWorldEditorDropType atOrigin = new TypeWorldEditorDropType((int)R__WorldEditor__DropType.DropAtOrigin,"atOrigin","Place at the scene origin (usually 0,0,0) n");
      public static readonly TypeWorldEditorDropType atCamera = new TypeWorldEditorDropType((int)R__WorldEditor__DropType.DropAtCamera,"atCamera","Places at the same position as the camera, without rotation. n");
      public static readonly TypeWorldEditorDropType atCameraRot = new TypeWorldEditorDropType((int)R__WorldEditor__DropType.DropAtCameraWithRot,"atCameraRot","Places at the same position as the camera, with the camera's rotation. n");
      public static readonly TypeWorldEditorDropType belowCamera = new TypeWorldEditorDropType((int)R__WorldEditor__DropType.DropBelowCamera,"belowCamera","Places below the camera. n");
      public static readonly TypeWorldEditorDropType screenCenter = new TypeWorldEditorDropType((int)R__WorldEditor__DropType.DropAtScreenCenter,"screenCenter","Places at a position projected outwards from the screen's center. n");
      public static readonly TypeWorldEditorDropType atCentroid = new TypeWorldEditorDropType((int)R__WorldEditor__DropType.DropAtCentroid,"atCentroid","Places at the center position of the current centroid. n");
      public static readonly TypeWorldEditorDropType toTerrain = new TypeWorldEditorDropType((int)R__WorldEditor__DropType.DropToTerrain,"toTerrain","Places on the terrain. n");
      public static readonly TypeWorldEditorDropType belowSelection = new TypeWorldEditorDropType((int)R__WorldEditor__DropType.DropBelowSelection,"belowSelection","Places at a position below the selected object. n");
      };
}