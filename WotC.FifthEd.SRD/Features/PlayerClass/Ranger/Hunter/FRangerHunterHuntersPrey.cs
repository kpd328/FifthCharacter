using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger.Hunter {
    public class FRangerHunterHuntersPrey : AFeatureRangerHunter {
        public override string Name => Feature switch {
            HuntersPreyFeature.COLOSSUS_SLAYER => "Hunter's Prey (Colossus Slayer)",
            HuntersPreyFeature.GIANT_KILLER => "Hunter's Prey (Giant Killer)",
            HuntersPreyFeature.HORDE_BREAKER => "Hunter's Prey (Horde Breaker)",
            _ => "Hunter's Prey"
        };
        public override string Text => Feature switch {
            HuntersPreyFeature.COLOSSUS_SLAYER => FeatureRangerHunterText.Hunter_s_Prey__Colossus_Slayer,
            HuntersPreyFeature.GIANT_KILLER => FeatureRangerHunterText.Hunter_s_Prey__Giant_Killer,
            HuntersPreyFeature.HORDE_BREAKER => FeatureRangerHunterText.Hunter_s_Prey__Horde_Breaker,
            _ => FeatureRangerHunterText.Hunter_s_Prey
        };
        public HuntersPreyFeature Feature;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FRangerHunterHuntersPrey() { }

        public FRangerHunterHuntersPrey(bool isTaken) {
            //TODO: Prompt to pick feature
        }

        public override IFeature GetInstance() => new FRangerHunterHuntersPrey(true);
    }

    public enum HuntersPreyFeature {
        COLOSSUS_SLAYER,
        GIANT_KILLER,
        HORDE_BREAKER
    }
}
