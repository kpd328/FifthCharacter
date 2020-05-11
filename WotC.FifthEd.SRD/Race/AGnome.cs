using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Gnome;

namespace WotC.FifthEd.SRD.Race {
    public abstract class AGnome : IRace {
        public virtual string Name => "Gnome";
        public abstract string ID { get; }
        public virtual bool HasChoices => false;

        protected AGnome() {
            CharacterManager.Speed = 25;
            FeaturesManager.Features.Add(new FGnomeAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FGnomeDarkvision());
            FeaturesManager.Features.Add(new FGnomeGnomeCunning());
            //TODO: add languages
        }

        public abstract IRace GetInstance();

        public virtual void BuildPopup(PopupNCRaceOptions raceOptions) { }

        public void ConfirmPopup() { }
    }
}
