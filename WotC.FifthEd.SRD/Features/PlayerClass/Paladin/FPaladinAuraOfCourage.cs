using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinAuraOfCourage : AFeaturePaladin {
        public override string Name => "Aura of Courage";
        public override string Text => FeaturePaladinText.Aura_of_Courage;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FPaladinAuraOfCourage();
    }
}
