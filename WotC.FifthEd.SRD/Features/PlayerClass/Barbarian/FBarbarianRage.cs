using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianRage : AFeatureBarbarian {
        public override string Name => "Rage";
        public override string Text => FeatureBarbarianText.Rage;
        public override bool IsActive => true;
        /// <summary>
        /// if returns <c>-1</c>, treat as infinite
        /// </summary>
        public override int ActiveUses {
            get => ClassManager.ClassLevel("Barbarian") switch {
                 1 => 2,  2 => 2,  3 => 3,  4 => 3,  5 => 3,
                 6 => 4,  7 => 4,  8 => 4,  9 => 4, 10 => 4,
                11 => 4, 12 => 5, 13 => 5, 14 => 5, 15 => 5,
                16 => 5, 17 => 6, 18 => 6, 19 => 6, 20 => -1,
                 _ => 0
            };
        }

        public override IFeature GetInstance() => new FBarbarianRage();
    }
}
