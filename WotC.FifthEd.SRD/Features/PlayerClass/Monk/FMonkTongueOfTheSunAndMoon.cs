using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkTongueOfTheSunAndMoon : AFeatureMonk {
        public override string Name => "Tongue of the Sun and Moon";
        public override string Text => FeatureMonkText.Tongue_of_the_Sun_and_Moon;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkTongueOfTheSunAndMoon();
    }
}
