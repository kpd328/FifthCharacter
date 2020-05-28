using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerVanish : AFeatureRanger {
        public override string Name => "Vanish";
        public override string Text => FeatureRangerText.Vanish;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerVanish();
    }
}
