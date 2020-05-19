using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian.PathOfTheBerserker {
    public class FBarbBerserkerRetaliation : AFeatureBarbarianPathOfTheBerserker {
        public override string Name => "Retaliation";
        public override string Text => FeatureBarbarianPathOfTheBerserkerText.Retaliation;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbBerserkerRetaliation();
    }
}
