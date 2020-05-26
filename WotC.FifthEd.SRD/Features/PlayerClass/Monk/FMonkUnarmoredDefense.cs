using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkUnarmoredDefense : AFeatureMonk {
        public override string Name => "Unarmored Defense";
        public override string Text => FeatureMonkText.Unarmored_Defense;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkUnarmoredDefense();
    }
}
