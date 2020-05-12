using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Gnome;
using WotC.FifthEd.SRD.Proficiencies.Languages;

namespace WotC.FifthEd.SRD.Race {
    public abstract class AGnome : IRace {
        private const string SOURCE_TEXT = "Race Gnome";
        public virtual string Name => "Gnome";
        public abstract string ID { get; }
        public virtual bool HasChoices => false;

        protected AGnome() {
            CharacterManager.Speed = 25;
            FeaturesManager.Features.Add(new FGnomeAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FGnomeDarkvision());
            FeaturesManager.Features.Add(new FGnomeGnomeCunning());
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangGnomish(SOURCE_TEXT));
        }

        public abstract IRace GetInstance();

        public virtual void BuildPopup(PopupNCRaceOptions raceOptions) { }
        
        public virtual void BuildPopup(PopupNCRaceOptions_GTK raceOptions) { }

        public virtual void ConfirmPopup() { }
    }
}
