using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianFeralInstinct : AFeatureBarbarian {
        public override string Name => "Feral Instinct";
        public override string Text => FeatureBarbarianText.Feral_Instinct;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbarianFeralInstinct();
    }
}
