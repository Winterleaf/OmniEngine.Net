using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<BL_ShadowFilterPostEffect>))]
    public class BL_ShadowFilterPostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("PostEffect", "BL_ShadowFilterPostFx",
                typeof (BL_ShadowFilterPostEffect));
            // Blur vertically
            ts["shader"] = "BL_ShadowFilterShaderV";
            ts["stateBlock"] = "PFX_DefaultStateBlock";
            //Todo See if there is a way to autodetect this.
            ts["targetClear"] = "\"PFXTargetClear_OnDraw\"";
            //No way to easily detect that this belongs in quotes, so gotta toss it in quotes manually.
            ts["targetClearColor"] = "0 0 0 0";
            ts["texture[0]"] = "$inTex";
            ts["target"] = "$outTex";

            // Blur horizontal
            ObjectCreator tch = new ObjectCreator("PostEffect");
            tch["shader"] = "BL_ShadowFilterShaderH";
            tch["stateBlock"] = "PFX_DefaultStateBlock";
            tch["texture[0]"] = "$inTex";
            tch["target"] = "$outTex";


            ts["#1"] = tch;


            ts.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }
        }
    }