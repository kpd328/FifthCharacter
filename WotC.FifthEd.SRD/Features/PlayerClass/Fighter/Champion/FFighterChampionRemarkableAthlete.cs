using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter.Champion {
    public class FFighterChampionRemarkableAthlete : AFeatureFighterChampion {
        public override string Name => "Remarkable Athlete";
        public override string Text => FeatureFighterChampionText.Remarkable_Athlete;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FFighterChampionRemarkableAthlete();
    }
}
