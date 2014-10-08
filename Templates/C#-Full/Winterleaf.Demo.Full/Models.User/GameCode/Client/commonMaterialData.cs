using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class commonMaterialData
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void intialize()
            {
            //-----------------------------------------------------------------------------
            // Anim flag settings - must match material.h
            // These cannot be enumed through script becuase it cannot
            // handle the "|" operation for combining them together
            // ie. Scroll | Wave does not work.
            //-----------------------------------------------------------------------------
            omni.iGlobal["$scroll"] = 1;
            omni.iGlobal["$rotate"] = 2;
            omni.iGlobal["$wave"] = 4;
            omni.iGlobal["$scale"] = 8;
            omni.iGlobal["$sequence"] = 16;

            // Common stateblock definitions
            ObjectCreator oc = new ObjectCreator("GFXSamplerStateData", "SamplerClampLinear");
            oc["textureColorOp"] = "GFXTOPModulate";
            oc["addressModeU"] = "GFXAddressClamp";
            oc["addressModeV"] = "GFXAddressClamp";
            oc["addressModeW"] = "GFXAddressClamp";
            oc["magFilter"] = "GFXTextureFilterLinear";
            oc["minFilter"] = "GFXTextureFilterLinear";
            oc["mipFilter"] = "GFXTextureFilterLinear";
            oc.Create();

            oc = new ObjectCreator("GFXSamplerStateData", "SamplerClampPoint");
            oc["textureColorOp"] = "GFXTOPModulate";
            oc["addressModeU"] = "GFXAddressClamp";
            oc["addressModeV"] = "GFXAddressClamp";
            oc["addressModeW"] = "GFXAddressClamp";
            oc["magFilter"] = "GFXTextureFilterPoint";
            oc["minFilter"] = "GFXTextureFilterPoint";
            oc["mipFilter"] = "GFXTextureFilterPoint";
            oc.Create();

            oc = new ObjectCreator("GFXSamplerStateData", "SamplerWrapLinear");
            oc["textureColorOp"] = "GFXTOPModulate";
            oc["addressModeU"] = "GFXTextureAddressWrap";
            oc["addressModeV"] = "GFXTextureAddressWrap";
            oc["addressModeW"] = "GFXTextureAddressWrap";
            oc["magFilter"] = "GFXTextureFilterLinear";
            oc["minFilter"] = "GFXTextureFilterLinear";
            oc["mipFilter"] = "GFXTextureFilterLinear";
            oc.Create();

            oc = new ObjectCreator("GFXSamplerStateData", "SamplerWrapPoint");
            oc["textureColorOp"] = "GFXTOPModulate";
            oc["addressModeU"] = "GFXTextureAddressWrap";
            oc["addressModeV"] = "GFXTextureAddressWrap";
            oc["addressModeW"] = "GFXTextureAddressWrap";
            oc["magFilter"] = "GFXTextureFilterPoint";
            oc["minFilter"] = "GFXTextureFilterPoint";
            oc["mipFilter"] = "GFXTextureFilterPoint";
            oc.Create();
            }
        }
    }