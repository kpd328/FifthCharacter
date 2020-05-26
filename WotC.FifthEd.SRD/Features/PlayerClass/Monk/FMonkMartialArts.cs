using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkMartialArts : AFeatureMonk {
        public override string Name => "Martial Arts";
        public override string Text => FeatureMonkText.Martial_Arts;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkMartialArts();
    }
}
