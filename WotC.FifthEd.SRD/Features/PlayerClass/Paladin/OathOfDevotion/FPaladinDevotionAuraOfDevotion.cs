using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin.OathOfDevotion {
    public class FPaladinDevotionAuraOfDevotion : AFeaturePaladinOathOfDevotion {
        public override string Name => "Aura of Devotion";
        public override string Text => FeaturePaladinOathOfDevotionText.Aura_of_Devotion;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FPaladinDevotionAuraOfDevotion();
    }
}
