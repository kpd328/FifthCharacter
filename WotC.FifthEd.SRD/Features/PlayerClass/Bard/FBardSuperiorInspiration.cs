using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public class FBardSuperiorInspiration : AFeatureBard {
        public override string Name => "Superior Inspiration";
        public override string Text => FeatureBardText.Superior_Inspiration;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardSuperiorInspiration();
    }
}
