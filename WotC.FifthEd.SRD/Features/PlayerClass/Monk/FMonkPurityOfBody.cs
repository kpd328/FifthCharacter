using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkPurityOfBody : AFeatureMonk {
        public override string Name => "Purity of Body";
        public override string Text => FeatureMonkText.Purity_of_Body;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkPurityOfBody();
    }
}
