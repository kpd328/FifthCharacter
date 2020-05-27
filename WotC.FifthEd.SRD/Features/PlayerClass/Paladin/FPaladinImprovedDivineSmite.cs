using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinImprovedDivineSmite : AFeaturePaladin {
        public override string Name => "Improved Divine Smite";
        public override string Text => FeaturePaladinText.Improved_Divine_Smite;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FPaladinImprovedDivineSmite();
    }
}
