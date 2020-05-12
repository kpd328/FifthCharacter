using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Halfling.Lightfoot;

namespace WotC.FifthEd.SRD.Race {
    public class LightfootHalfling : AHalfling {
        public override string Name => "Lightfoot Halfling";
        public override string ID => "SRD.Race.Halfling.Lightfoot";

        public LightfootHalfling() { }

        protected LightfootHalfling(bool isRace) : base() {
            FeaturesManager.Features.Add(new FLightfootHalflingAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FLightfootHalflingNaturallyStealthy());
        }

        public override IRace GetInstance() => new LightfootHalfling(true);
    }
}
