using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian.PathOfTheBerserker {
    public class FBarbBerserkerMindlessRage : AFeatureBarbarianPathOfTheBerserker {
        public override string Name => "Mindless Rage";
        public override string Text => FeatureBarbarianPathOfTheBerserkerText.Mindless_Rage;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbBerserkerMindlessRage();
    }
}
