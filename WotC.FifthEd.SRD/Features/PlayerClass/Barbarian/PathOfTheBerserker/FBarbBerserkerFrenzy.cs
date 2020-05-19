using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian.PathOfTheBerserker {
    public class FBarbBerserkerFrenzy : AFeatureBarbarian {
        public override string Name => "Frenzy";
        public override string Text => FeatureBarbarianPathOfTheBerserkerText.Frenzy;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbBerserkerFrenzy();
    }
}
