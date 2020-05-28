using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger.Hunter {
    public class FRangerHunterSuperiorHuntersDefense : AFeatureRangerHunter {
        public override string Name => Feature switch {
            SuperiorHuntersDefenseFeature.EVASION => "Superior Hunter's Defense (Evasion)",
            SuperiorHuntersDefenseFeature.STAND_AGAINST_THE_TIDE => "Superior Hunter's Defense (Stand Against the Tide)",
            SuperiorHuntersDefenseFeature.UNCANNY_DODGE => "Superior Hunter's Defense (Uncanny Dodge)",
            _ => "Superior Hunter's Defense"
        };
        public override string Text => Feature switch {
            SuperiorHuntersDefenseFeature.EVASION => FeatureRangerHunterText.Superior_Hunter_s_Defense__Evasion,
            SuperiorHuntersDefenseFeature.STAND_AGAINST_THE_TIDE => FeatureRangerHunterText.Superior_Hunter_s_Defense__Stand_Against_the_Tide,
            SuperiorHuntersDefenseFeature.UNCANNY_DODGE => FeatureRangerHunterText.Superior_Hunter_s_Defense__Uncanny_Dodge,
            _ => FeatureRangerHunterText.Superior_Hunter_s_Defense
        };
        public SuperiorHuntersDefenseFeature Feature;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FRangerHunterSuperiorHuntersDefense() { }

        public FRangerHunterSuperiorHuntersDefense(bool isTaken) {
            //TODO: Prompt to pick feature
        }

        public override IFeature GetInstance() => new FRangerHunterSuperiorHuntersDefense(true);
    }

    public enum SuperiorHuntersDefenseFeature {
        EVASION,
        STAND_AGAINST_THE_TIDE,
        UNCANNY_DODGE
    }
}
