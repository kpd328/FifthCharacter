using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Halfling;

namespace WotC.FifthEd.SRD.Race {
    public abstract class AHalfling : IRace {
        public virtual string Name => "Halfling";
        public abstract string ID { get; }
        public virtual bool HasChoices => false;

        protected AHalfling() {
            CharacterManager.Speed = 25;
            FeaturesManager.Features.Add(new FHalflingAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FHalflingLucky());
            FeaturesManager.Features.Add(new FHalflingBrave());
            FeaturesManager.Features.Add(new FHalflingHalflingNimbleness());
            //TODO: add languages
        }

        public abstract IRace GetInstance();

        public virtual void BuildPopup(PopupNCRaceOptions raceOptions) { }

        public void ConfirmPopup() { }
    }
}
