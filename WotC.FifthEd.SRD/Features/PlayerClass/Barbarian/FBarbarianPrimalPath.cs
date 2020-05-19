using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public abstract class FBarbarianPrimalPath : AFeatureBarbarian {
        public override string Name => "Primal Path";
        public override string Text => FeatureBarbarianText.Primal_Path;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
    }
}
