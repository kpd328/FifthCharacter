using FifthCharacter.Plugin.Popup;

namespace FifthCharacter.Plugin.Interface {
    public interface IBackground {
        string Name { get; }
        string ID { get; }
        bool HasChoices { get; }

        IBackground GetInstance();
        void BuildPopup(PopupNCBackgroundOptions backgroundOptions);
        void BuildPopup(PopupNCBackgroundOptions_GTK backgroundOptions);
        void ConfirmPopup();
    }
}
