#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<LuminanceVisPostEffect>))]
    public class LuminanceVisPostEffect : PostEffect
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void setShaderConsts()
            {
            setShaderConst("$brightPassThreshold", sGlobal["$HDRPostFX::brightPassThreshold"]);
            }

        public override bool onEnabled()
            {
            PostEffect HDRPostFX = "HDRPostFX";
            if (!HDRPostFX.isEnabledX())
                HDRPostFX.enable();
            HDRPostFX["skip"] = true.AsString();
            return true;
            }

        public override void onDisabled()
            {
            PostEffect HDRPostFX = "HDRPostFX";
            HDRPostFX["skip"] = false.AsString();
            }
        }
    }