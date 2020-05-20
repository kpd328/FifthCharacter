using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public class FBardMagicalSecrets : AFeatureBard {
        public override string Name => "Magical Secrets";
        public override string Text => FeatureBardText.Magical_Secrets;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardMagicalSecrets();
    }
}
