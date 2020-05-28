using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerPrimevalAwareness : AFeatureRanger {
        public override string Name => "Primeval Awareness";
        public override string Text => FeatureRangerText.Primeval_Awareness;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerPrimevalAwareness();
    }
}
