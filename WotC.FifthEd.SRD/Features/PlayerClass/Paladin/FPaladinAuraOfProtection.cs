using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinAuraOfProtection : AFeaturePaladin {
        public override string Name => "Aura of Protection";
        public override string Text => FeaturePaladinText.Aura_of_Protection;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FPaladinAuraOfProtection();
    }
}
