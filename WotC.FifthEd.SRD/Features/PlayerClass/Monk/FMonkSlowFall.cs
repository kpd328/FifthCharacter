using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkSlowFall : AFeatureMonk {
        public override string Name => "Slow Fall";
        public override string Text => FeatureMonkText.Slow_Fall;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkSlowFall();
    }
}
