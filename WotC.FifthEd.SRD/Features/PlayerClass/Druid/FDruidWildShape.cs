using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid {
    public class FDruidWildShape : AFeatureDruid {
        public override string Name => "Wild Shape";
        public override string Text => FeatureDruidText.Wild_Shape;
        public override bool IsActive => true;
        public override int ActiveUses => ClassManager.ClassLevel("Druid") switch {
             2 => 2,  3 => 2,  4 => 2,  5 => 2,  6 => 2,
             7 => 2,  8 => 2,  9 => 2, 10 => 2, 11 => 2,
            12 => 2, 13 => 2, 14 => 2, 15 => 2, 16 => 2,
            17 => 2, 18 => 2, 19 => 2, 20 => -1, _ => 0
        };

        public override IFeature GetInstance() => new FDruidWildShape();
    }
}
