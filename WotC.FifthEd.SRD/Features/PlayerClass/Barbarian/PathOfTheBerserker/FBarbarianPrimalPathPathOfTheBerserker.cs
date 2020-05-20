using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian.PathOfTheBerserker {
    public class FBarbarianPrimalPathPathOfTheBerserker : FBarbarianPrimalPath {
        public override string Name => "Primal Path: Path of the Berserker";
        public override string Text => FeatureBarbarianPathOfTheBerserkerText.Path_of_the_Berserker;

        public override IFeature GetInstance() => new FBarbarianPrimalPathPathOfTheBerserker();
    }
}
