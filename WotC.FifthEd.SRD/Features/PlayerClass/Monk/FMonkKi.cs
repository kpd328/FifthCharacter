using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkKi : AFeatureMonk {
        public override string Name => "Ki";
        public override string Text => FeatureMonkText.Ki;
        public override bool IsActive => true;
        public override int ActiveUses => ClassManager.ClassLevel("Monk");

        public override IFeature GetInstance() => new FMonkKi();
    }
}
