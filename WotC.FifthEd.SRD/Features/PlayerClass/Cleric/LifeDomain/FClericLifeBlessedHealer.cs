using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain {
    public class FClericLifeBlessedHealer : AFeatureClericLifeDomain {
        public override string Name => "Blessed Healer";
        public override string Text => FeatureClericLifeDomainText.Blessed_Healer;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FClericLifeBlessedHealer();
    }
}
