using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue.Thief {
    public class FRogueThiefSecondStoryWork : AFeatureRogueThief {
        public override string Name => "Second-Story Work";
        public override string Text => FeatureRogueThiefText.Second_Story_Work;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueThiefSecondStoryWork();
    }
}
