using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain {
    public class FClericLifeDivineStrike : AFeatureClericLifeDomain {
        public override string Name => "Divine Strike";
        public override string Text => FeatureClericLifeDomainText.Divine_Strike;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FClericLifeDivineStrike();
    }
}
