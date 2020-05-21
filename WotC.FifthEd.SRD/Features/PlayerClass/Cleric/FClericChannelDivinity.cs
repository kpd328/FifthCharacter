using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric {
    public class FClericChannelDivinity : AFeatureCleric {
        public override string Name => "Channel Divinity";
        public override string Text => FeatureClericText.Channel_Divinity;
        public override bool IsActive => true;
        public override int ActiveUses => ClassManager.ClassLevel("Cleric") switch {
             1 => 1,  2 => 1,  3 => 1,  4 => 1,  5 => 1,
             6 => 2,  7 => 2,  8 => 2,  9 => 2, 10 => 2,
            11 => 2, 12 => 2, 13 => 2, 14 => 2, 15 => 2,
            16 => 2, 17 => 2, 18 => 3, 19 => 3, 20 => 3,
             _ => 0
        };

        public override IFeature GetInstance() => new FClericChannelDivinity();
    }
}
