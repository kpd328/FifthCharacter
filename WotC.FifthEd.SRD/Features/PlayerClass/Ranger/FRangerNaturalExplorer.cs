using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerNaturalExplorer : AFeatureRanger {
        public override string Name => "Natural Explorer";
        public override string Text => FeatureRangerText.Natural_Explorer;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerNaturalExplorer();
    }
}
