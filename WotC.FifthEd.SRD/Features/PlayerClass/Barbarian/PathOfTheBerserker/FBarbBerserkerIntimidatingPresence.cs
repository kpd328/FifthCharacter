using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian.PathOfTheBerserker {
    public class FBarbBerserkerIntimidatingPresence : AFeatureBarbarianPathOfTheBerserker {
        public override string Name => "Intimidating Presence";
        public override string Text => FeatureBarbarianPathOfTheBerserkerText.Intimidating_Presence;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbBerserkerIntimidatingPresence();
    }
}
