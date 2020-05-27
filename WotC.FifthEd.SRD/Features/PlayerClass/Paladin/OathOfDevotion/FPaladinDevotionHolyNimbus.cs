using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin.OathOfDevotion {
    public class FPaladinDevotionHolyNimbus : AFeaturePaladinOathOfDevotion {
        public override string Name => "Holy Nimbus";
        public override string Text => FeaturePaladinOathOfDevotionText.Holy_Nimbus;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FPaladinDevotionHolyNimbus();
    }
}
