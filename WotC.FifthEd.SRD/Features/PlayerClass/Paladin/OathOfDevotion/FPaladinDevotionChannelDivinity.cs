using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin.OathOfDevotion {
    public class FPaladinDevotionChannelDivinity : AFeaturePaladinOathOfDevotion {
        public override string Name => "Channel Divinity";
        public override string Text => FeaturePaladinOathOfDevotionText.Channel_Divinity;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FPaladinDevotionChannelDivinity();
    }
}
