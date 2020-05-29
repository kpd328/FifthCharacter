using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue.Thief {
    public class FRogueThiefSupremeSneak : AFeatureRogueThief {
        public override string Name => "Supreme Sneak";
        public override string Text => FeatureRogueThiefText.Supreme_Sneak;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueThiefSupremeSneak();
    }
}
