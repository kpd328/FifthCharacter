using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter.Champion {
    public class FFighterChampionImprovedCritical : AFeatureFighterChampion {
        public override string Name => "Improved Critical";
        public override string Text => FeatureFighterChampionText.Improved_Critical;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FFighterChampionImprovedCritical();
    }
}
