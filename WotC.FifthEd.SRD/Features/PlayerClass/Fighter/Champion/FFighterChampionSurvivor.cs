using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter.Champion {
    public class FFighterChampionSurvivor : AFeatureFighterChampion {
        public override string Name => "Survivor";
        public override string Text => FeatureFighterChampionText.Survivor;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FFighterChampionSurvivor();
    }
}
