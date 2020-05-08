using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Elf;

namespace WotC.FifthEd.SRD.Race {
    public abstract class AElf : IRace {
        private const string SOURCE_TEXT = "Race Elf";

        public string Name => "Elf";
        public abstract string ID { get; }

        protected AElf() {
            CharacterManager.Speed = 30;

            //TODO: Add Perception Proficiency

            FeaturesManager.Features.Add(new FElfAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FElfDarkvision());
            FeaturesManager.Features.Add(new FElfFeyAncestry());
            FeaturesManager.Features.Add(new FElfTrance());

            //TODO: Add Languages
        }

        public abstract IRace GetInstance();
    }
}
