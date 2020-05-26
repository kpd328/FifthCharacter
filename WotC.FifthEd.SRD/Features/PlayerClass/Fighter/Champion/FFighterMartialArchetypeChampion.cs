using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter.Champion {
    public class FFighterMartialArchetypeChampion : FFighterMartialArchetype {
        public override string Name => "Martial Archetype: Champion";
        public override string Text => FeatureFighterChampionText.Champion;
        public override MultiValueDictionary<int, IFeature> ArchetypeFeatures => new MultiValueDictionary<int, IFeature>() {
            { 3, new FFighterChampionImprovedCritical() },
            { 7, new FFighterChampionRemarkableAthlete() },
            { 10, new FFighterChampionAditionalFightingStyle() },
            { 15, new FFighterChampionSuperiorCritical() },
            { 18, new FFighterChampionSurvivor() }
        };

        public override IFeature GetInstance() => new FFighterMartialArchetypeChampion();
    }
}
