using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger.Hunter {
    public class FRangerHunterDefensiveTactics : AFeatureRangerHunter {
        public override string Name => Feature switch {
            DefensiveTacticsFeature.ESCAPE_THE_HORDE => "Defensive Tactics (Escape the Horde)",
            DefensiveTacticsFeature.MULTIATTACK_DEFENSE => "Defensive Tactics (Multiattack Defense)",
            DefensiveTacticsFeature.STEEL_WILL => "Defensive Tactics (Steel Will)",
            _ => "Defensive Tactics"
        };
        public override string Text => Feature switch {
            DefensiveTacticsFeature.ESCAPE_THE_HORDE => FeatureRangerHunterText.Defensive_Tactics__Escape_the_Horde,
            DefensiveTacticsFeature.MULTIATTACK_DEFENSE => FeatureRangerHunterText.Defensive_Tactics__Multiattack_Defense,
            DefensiveTacticsFeature.STEEL_WILL => FeatureRangerHunterText.Defensive_Tactics__Steel_Will,
            _ => FeatureRangerHunterText.Defensive_Tactics
        };
        public DefensiveTacticsFeature Feature;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FRangerHunterDefensiveTactics() { }

        public FRangerHunterDefensiveTactics(bool isTaken) {
            //TODO: Prompt to pick feature
        }

        public override IFeature GetInstance() => new FRangerHunterDefensiveTactics(true);
    }

    public enum DefensiveTacticsFeature {
        ESCAPE_THE_HORDE,
        MULTIATTACK_DEFENSE,
        STEEL_WILL
    }
}
