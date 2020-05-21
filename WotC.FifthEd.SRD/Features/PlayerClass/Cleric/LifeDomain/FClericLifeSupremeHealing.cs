using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain {
    public class FClericLifeSupremeHealing : AFeatureClericLifeDomain {
        public override string Name => "Supreme Healing";
        public override string Text => FeatureClericLifeDomainText.Supreme_Healing;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FClericLifeSupremeHealing();
    }
}
