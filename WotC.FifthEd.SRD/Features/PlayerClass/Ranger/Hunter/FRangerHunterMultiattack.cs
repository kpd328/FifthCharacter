using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger.Hunter {
    public class FRangerHunterMultiattack : AFeatureRangerHunter {
        public override string Name => Feature switch {
            MultiattackFeature.VOLLEY => "Multiattack (Volley)",
            MultiattackFeature.WHIRLWIND_ATTACK => "Multiattack (Whirlwind Attack)",
            _ => "Multiattack"
        };
        public override string Text => Feature switch {
            MultiattackFeature.VOLLEY => FeatureRangerHunterText.Multiattack__Volley,
            MultiattackFeature.WHIRLWIND_ATTACK => FeatureRangerHunterText.Multiattack__Whirlwind_Attack,
            _ => FeatureRangerHunterText.Multiattack
        };
        public MultiattackFeature Feature;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FRangerHunterMultiattack() { }

        public FRangerHunterMultiattack(bool isTaken) {
            //TODO: Prompt to pick feature
        }

        public override IFeature GetInstance() => new FRangerHunterMultiattack(true);
    }

    public enum MultiattackFeature {
        VOLLEY,
        WHIRLWIND_ATTACK
    }
}
