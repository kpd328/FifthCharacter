using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkEvasion : AFeatureMonk {
        public override string Name => "Evasion";
        public override string Text => FeatureMonkText.Evasion;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkEvasion();
    }
}
