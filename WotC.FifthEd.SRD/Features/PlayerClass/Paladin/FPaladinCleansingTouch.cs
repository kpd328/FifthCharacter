using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinCleansingTouch : AFeaturePaladin {
        public override string Name => "Cleansing Touch";
        public override string Text => FeaturePaladinText.Cleansing_Touch;
        public override bool IsActive => true;
        public override int ActiveUses => Math.Max(1, AbilityManager.CharismaMod);

        public override IFeature GetInstance() => new FPaladinCleansingTouch();
    }
}
