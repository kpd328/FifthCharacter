using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public class FBardBardicInspiration : AFeatureBard {
        public override string Name => "Bardic Inspiration";
        public override string Text => FeatureBardText.Bardic_Inspiration;
        public override bool IsActive => true;
        public override int ActiveUses => Math.Max(1, AbilityManager.CharismaMod);

        public override IFeature GetInstance() => new FBardBardicInspiration();
    }
}
