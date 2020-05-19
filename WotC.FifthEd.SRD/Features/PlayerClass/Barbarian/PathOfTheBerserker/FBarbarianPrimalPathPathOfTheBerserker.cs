using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian.PathOfTheBerserker {
    public class FBarbarianPrimalPathPathOfTheBerserker : FBarbarianPrimalPath {
        public override string Name => "Primal Path: Path of the Berserker";

        public override IFeature GetInstance() => new FBarbarianPrimalPathPathOfTheBerserker();
    }
}
