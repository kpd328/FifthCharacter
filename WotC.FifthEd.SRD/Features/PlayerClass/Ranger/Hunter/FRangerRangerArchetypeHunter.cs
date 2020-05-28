using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger.Hunter {
    public class FRangerRangerArchetypeHunter : FRangerRangerArchetype {
        public override string Name => "Ranger Archetype: Hunter";
        public override string Text => FeatureRangerHunterText.Hunter;
        public override MultiValueDictionary<int, IFeature> ArchetypeFeatures => new MultiValueDictionary<int, IFeature>() {
            { 3, new FRangerHunterHuntersPrey() },
            { 7, new FRangerHunterDefensiveTactics() },
            { 11, new FRangerHunterMultiattack() },
            { 15, new FRangerHunterSuperiorHuntersDefense() }
        };

        public override IFeature GetInstance() => new FRangerRangerArchetypeHunter();
    }
}
