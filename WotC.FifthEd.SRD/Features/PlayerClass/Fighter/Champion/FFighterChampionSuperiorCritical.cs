using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter.Champion {
    public class FFighterChampionSuperiorCritical : AFeatureFighterChampion {
        public override string Name => "Superior Critical";
        public override string Text => FeatureFighterChampionText.Superior_Critical;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FFighterChampionSuperiorCritical();
    }
}
