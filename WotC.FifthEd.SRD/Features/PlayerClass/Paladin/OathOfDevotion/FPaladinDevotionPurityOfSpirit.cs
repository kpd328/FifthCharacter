using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin.OathOfDevotion {
    public class FPaladinDevotionPurityOfSpirit : AFeaturePaladinOathOfDevotion {
        public override string Name => "Purity of Spirit";
        public override string Text => FeaturePaladinOathOfDevotionText.Purity_of_Spirit;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FPaladinDevotionPurityOfSpirit();
    }
}
