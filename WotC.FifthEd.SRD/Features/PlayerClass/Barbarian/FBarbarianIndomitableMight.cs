using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianIndomitableMight : AFeatureBarbarian {
        public override string Name => "Indomitable Might";
        public override string Text => FeatureBarbarianText.Indomitable_Might;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbarianIndomitableMight();
    }
}
