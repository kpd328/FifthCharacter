using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinDivineSense : AFeaturePaladin {
        public override string Name => "Divine Sense";
        public override string Text => FeaturePaladinText.Divine_Sense;
        public override bool IsActive => true;
        public override int ActiveUses => AbilityManager.CharismaMod + 1;

        public override IFeature GetInstance() => new FPaladinDivineSense();
    }
}
