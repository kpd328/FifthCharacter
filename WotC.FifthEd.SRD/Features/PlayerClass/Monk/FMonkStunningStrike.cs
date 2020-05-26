using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkStunningStrike : AFeatureMonk {
        public override string Name => "Stunning Strike";
        public override string Text => FeatureMonkText.Stunning_Strike;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkStunningStrike();
    }
}
