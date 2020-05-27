using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinDivineSmite : AFeaturePaladin {
        //TODO: add this as a 1st level spell for the Paladin
        public override string Name => "Divine Smite";
        public override string Text => FeaturePaladinText.Divine_Smite;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FPaladinDivineSmite();
    }
}
