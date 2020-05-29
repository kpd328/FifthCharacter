using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue.Thief {
    public class FRogueThiefUseMagicDevice : AFeatureRogueThief {
        public override string Name => "Use Magic Device";
        public override string Text => FeatureRogueThiefText.Use_Magic_Device;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueThiefUseMagicDevice();
    }
}
