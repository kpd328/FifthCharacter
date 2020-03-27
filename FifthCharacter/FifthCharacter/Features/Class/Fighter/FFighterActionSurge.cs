using FifthCharacter.StatsManager;

namespace FifthCharacter.Features.Class.Fighter {
    public class FFighterActionSurge : AFeatureFighter {
        public override string Name => "Action Surge";
        public override string Text => FeatureFighterText.ActionSurge;
        public override bool IsActive => true;
        public override int ActiveUses => ClassManager.FighterLevels >= 17 ? 2: 1;
    }
}
