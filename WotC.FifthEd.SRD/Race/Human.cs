using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Human;

namespace WotC.FifthEd.SRD.Race {
    public class Human : IRace {
        public string Name => "Human";
        public string ID => "SRD.Race.Human";

        public Human() { }

        protected Human(bool isRace) {
            FeaturesManager.Features.Add(new FHumanAbilityScoreIncrease());
            CharacterManager.Speed = 30;
            //TODO: add languages
        }

        public IRace GetInstance() => new Human(true);
    }
}
