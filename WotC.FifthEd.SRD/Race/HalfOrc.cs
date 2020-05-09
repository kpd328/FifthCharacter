using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Skills;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.HalfOrc;

namespace WotC.FifthEd.SRD.Race {
    public class HalfOrc : IRace {
        private const string SOURCE_TEXT = "Race Half-Orc";
        public string Name => "Half-Orc";
        public string ID => "SRD.Race.HalfOrc";

        public HalfOrc() { }

        protected HalfOrc(bool isRace) {
            CharacterManager.Speed = 30;
            FeaturesManager.Features.Add(new FHalfOrcAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FHalfOrcDarkvision());
            FeaturesManager.Features.Add(new FHalfOrcRelentlessEndurance());
            FeaturesManager.Features.Add(new FHalfOrcSavageAttacks());
            ProficiencyManager.Proficiencies.Add(new ProfIntimidation(SOURCE_TEXT));
            //TODO: add languages
        }

        public IRace GetInstance() => new HalfOrc(true);
    }
}
