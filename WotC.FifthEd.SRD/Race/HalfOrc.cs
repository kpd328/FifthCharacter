using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.Proficiencies.Skills;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.HalfOrc;
using WotC.FifthEd.SRD.Proficiencies.Languages;

namespace WotC.FifthEd.SRD.Race {
    public class HalfOrc : IRace {
        private const string SOURCE_TEXT = "Race Half-Orc";
        public string Name => "Half-Orc";
        public string ID => "SRD.Race.HalfOrc";
        public bool HasChoices => false;

        public HalfOrc() { }

        protected HalfOrc(bool isRace) {
            CharacterManager.Speed = 30;
            FeaturesManager.Features.Add(new FHalfOrcAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FHalfOrcDarkvision());
            FeaturesManager.Features.Add(new FHalfOrcRelentlessEndurance());
            FeaturesManager.Features.Add(new FHalfOrcSavageAttacks());
            ProficiencyManager.Proficiencies.Add(new ProfIntimidation(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangOrc(SOURCE_TEXT));
        }

        public IRace GetInstance() => new HalfOrc(true);

        public void BuildPopup(PopupNCRaceOptions raceOptions) { }
        
        public void BuildPopup(PopupNCRaceOptions_GTK raceOptions) { }

        public void ConfirmPopup() { }
    }
}
