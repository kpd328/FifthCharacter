using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public class FBardFontOfInspiration : AFeatureBard {
        public override string Name => "Font of Inspiration";
        public override string Text => FeatureBardText.Font_of_Inspiration;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardFontOfInspiration();
    }
}
