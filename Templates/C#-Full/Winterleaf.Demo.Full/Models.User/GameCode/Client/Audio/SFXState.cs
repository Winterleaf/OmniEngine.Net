#region

using WinterLeaf.Demo.Full.Models.Base;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    partial class SFXState : SFXState_Base
        {
        public override void onActivate()
            {
            if (getId() != ((SFXState) "AudioStateNone").getId())
                ((SFXState) "AudioStateNone").disable();
            }

        public override void onDeactivate()
            {
            if (getId() != ((SFXState) "AudioStateNone").getId())
                ((SFXState) "AudioStateNone").enable();
            }
        }
    }