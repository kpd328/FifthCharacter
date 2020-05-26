using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter {
    public class FFighterIndomitable : AFeatureFighter {
        public override string Name => "Indomitable";
        public override string Text => FeatureFighterText.Indomitable;
        public override bool IsActive => true;
        public override int ActiveUses => ClassManager.ClassLevel("Fighter") switch {
             9 => 1, 10 => 1, 11 => 1, 12 => 1, 13 => 2,
            14 => 2, 15 => 2, 16 => 2, 17 => 3, 18 => 3,
            19 => 3, 20 => 3,  _ => 0
        };

        public override IFeature GetInstance() => new FFighterIndomitable();
    }
}
