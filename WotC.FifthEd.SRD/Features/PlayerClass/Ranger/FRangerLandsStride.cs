using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerLandsStride : AFeatureRanger {
        public override string Name => "Land's Stride";
        public override string Text => FeatureRangerText.Land_s_Stride;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerLandsStride();
    }
}
