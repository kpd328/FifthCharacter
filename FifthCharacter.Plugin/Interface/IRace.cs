using FifthCharacter.Plugin.Popup;

namespace FifthCharacter.Plugin.Interface {
    public interface IRace {
        string Name { get; }
        string ID { get; }
        bool HasChoices { get; }

        IRace GetInstance();
        void BuildPopup(PopupNCRaceOptions raceOptions);
        //void BuildPopup_GTK(PopupNCRaceOptions_GTK raceOptions);
        void ConfirmPopup();
    }
}
