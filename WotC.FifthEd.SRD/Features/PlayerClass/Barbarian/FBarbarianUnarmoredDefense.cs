using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianUnarmoredDefense : AFeatureBarbarian {
        public override string Name => "Unarmored Defense";
        public override string Text => FeatureBarbarianText.Unarmored_Defense;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbarianUnarmoredDefense();
    }
}
