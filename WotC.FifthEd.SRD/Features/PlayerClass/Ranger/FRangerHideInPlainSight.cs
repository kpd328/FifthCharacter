using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerHideInPlainSight : AFeatureRanger {
        public override string Name => "Hide in Plain Sight";
        public override string Text => FeatureRangerText.Hide_in_Plain_Sight;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerHideInPlainSight();
    }
}
