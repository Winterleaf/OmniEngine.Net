#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<FlashFxPostEffect>))]
    public class FlashFxPostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("ShaderData", "PFX_FlashShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/flashP.hlsl";

            ts["defines"] = "WHITE_COLOR=float4(1.0,1.0,1.0,0.0);MUL_COLOR=float4(1.0,0.25,0.25,0.0)";

            ts["pixVersion"] = 2.0;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "FlashFx", typeof (FlashFxPostEffect));
            ts["isEnabled"] = false;
            ts["allowReflectPass"] = false;

            ts["renderTime"] = "PFXAfterDiffuse";

            ts["shader"] = "PFX_FlashShader";
            ts["texture[0]"] = "$backBuffer";
            ts["renderPriority"] = 10;
            ts["stateBlock"] = "PFX_DefaultStateBlock";
            ts.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void setShaderConsts()
            {
            GameConnection serverConnection = "ServerConnection";

            if (console.isObject(this))
                {
                setShaderConst("$damageFlash", serverConnection.getDamageFlash().AsString());
                setShaderConst("$whiteOut", serverConnection.getWhiteOut().AsString());
                }
            else
                {
                setShaderConst("$damageFlash", "0");
                setShaderConst("$whiteOut", "0");
                }
            }
        }
    }