using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Tiefling;
using WotC.FifthEd.SRD.Proficiencies.Languages;

namespace WotC.FifthEd.SRD.Race {
    public class Tiefling : IRace {
        private const string SOURCE_TEXT = "Race Tiefling";
        public string Name => "Tiefling";
        public string ID => "SRD.Race.Tiefling";
        public bool HasChoices => false;

        public Tiefling() { }

        protected Tiefling(bool isRace) {
            CharacterManager.Speed = 30;
            FeaturesManager.Features.Add(new FTieflingAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FTieflingDarkvision());
            FeaturesManager.Features.Add(new FTieflingHellishResistance());
            FeaturesManager.Features.Add(new FTieflingInfernalLegacy1st());
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangInfernal(SOURCE_TEXT));
            //TODO: add level tracker for infernal legacy
        }

        public IRace GetInstance() => new Tiefling(true);

        public void BuildPopup(PopupNCRaceOptions raceOptions) { }
        public void BuildPopup(PopupNCRaceOptions_GTK raceOptions) { }

        public void ConfirmPopup() { }
    }
}
