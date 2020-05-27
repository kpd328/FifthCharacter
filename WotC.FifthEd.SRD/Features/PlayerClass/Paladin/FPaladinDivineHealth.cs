using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinDivineHealth : AFeaturePaladin {
        public override string Name => "Divine Health";
        public override string Text => FeaturePaladinText.Divine_Health;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FPaladinDivineHealth();
    }
}
