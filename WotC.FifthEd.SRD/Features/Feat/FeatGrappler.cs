using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;

namespace WotC.FifthEd.SRD.Features.Feat {
    public class FeatGrappler : AFeat {
        public override string Name => "Grappler";
        public override string ID => "SRD.Feature.Feat.Grappler";
        public override string Source { get; set; }
        public override string Text => FeatureFeatText.Grappler;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public override bool IsAbilityMod => false;

        public override IFeature GetInstance() => new FeatGrappler();

        public override bool MeetsPrerequisite() => AbilityManager.StrengthScore >= 13;

        public override void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
}
