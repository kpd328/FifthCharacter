using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Halfling;
using WotC.FifthEd.SRD.Proficiencies.Languages;

namespace WotC.FifthEd.SRD.Race {
    public abstract class AHalfling : IRace {
        private const string SOURCE_TEXT = "Race Halfling";
        public virtual string Name => "Halfling";
        public abstract string ID { get; }
        public virtual bool HasChoices => false;

        protected AHalfling() {
            CharacterManager.Speed = 25;
            FeaturesManager.Features.Add(new FHalflingAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FHalflingLucky());
            FeaturesManager.Features.Add(new FHalflingBrave());
            FeaturesManager.Features.Add(new FHalflingHalflingNimbleness());
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangHalfling(SOURCE_TEXT));
        }

        public abstract IRace GetInstance();

        public virtual void BuildPopup(PopupNCRaceOptions raceOptions) { }
        
        public virtual void BuildPopup(PopupNCRaceOptions_GTK raceOptions) { }

        public virtual void ConfirmPopup() { }

        
    }
}
