using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public class FBardExpertise : AFeatureBard {
        public override string Name => "Expertise";
        public override string Text => FeatureBardText.Expertise;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardExpertise();
    }
}
