using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock {
    public class FWarlockPactMagic : AFeatureWarlock {
        //TODO: use this to derive spell slots
        public override string Name => "Pact Magic";
        public override string Text => FeatureWarlockText.Pact_Magic;
        public override bool IsActive => true;
        public override int ActiveUses => ClassManager.ClassLevel("Warlock") switch {
             1 => 1,  2 => 2,  3 => 2,  4 => 2,  5 => 2,
             6 => 2,  7 => 2,  8 => 2,  9 => 2, 10 => 2,
            11 => 3, 12 => 3, 13 => 3, 14 => 3, 15 => 3,
            16 => 3, 17 => 4, 18 => 4, 19 => 4, 20 => 4,
             _ => 0
        };
        public int SpellSlotLevel => ClassManager.ClassLevel("Warlock") switch {
             1 => 1,  2 => 1,  3 => 2,  4 => 2,  5 => 3,
             6 => 3,  7 => 4,  8 => 4,  9 => 5, 10 => 5,
            11 => 5, 12 => 5, 13 => 5, 14 => 5, 15 => 5,
            16 => 5, 17 => 5, 18 => 5, 19 => 5, 20 => 5,
             _ => 0
        };

        public override IFeature GetInstance() => new FWarlockPactMagic();
    }
}
