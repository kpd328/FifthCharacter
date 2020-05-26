using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkStillnessOfMind : AFeatureMonk {
        public override string Name => "Stillness of Mind";
        public override string Text => FeatureMonkText.Stillness_of_Mind;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkStillnessOfMind();
    }
}
