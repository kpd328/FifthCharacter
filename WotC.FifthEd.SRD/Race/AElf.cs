using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.Proficiencies.Skills;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Elf;
using WotC.FifthEd.SRD.Proficiencies.Languages;

namespace WotC.FifthEd.SRD.Race {
    public abstract class AElf : IRace {
        private const string SOURCE_TEXT = "Race Elf";

        public virtual string Name => "Elf";
        public abstract string ID { get; }
        public virtual bool HasChoices => false;

        protected AElf() {
            CharacterManager.Speed = 30;
            ProficiencyManager.Proficiencies.Add(new ProfPerception(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangElvish(SOURCE_TEXT));
            FeaturesManager.Features.Add(new FElfAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FElfDarkvision());
            FeaturesManager.Features.Add(new FElfFeyAncestry());
            FeaturesManager.Features.Add(new FElfTrance());
        }

        public abstract IRace GetInstance();
        public virtual void BuildPopup(PopupNCRaceOptions raceOptions) { }

        public virtual void ConfirmPopup() { }
    }
}
