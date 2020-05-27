using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinLayOnHands : AFeaturePaladin {
        public override string Name => "Lay on Hands";
        public override string Text => FeaturePaladinText.Lay_on_Hands;
        public override bool IsActive => true;
        public override int ActiveUses => ClassManager.ClassLevel("Paladin") * 5;

        public override IFeature GetInstance() => new FPaladinLayOnHands();
    }
}
