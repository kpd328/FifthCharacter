using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;

namespace WotC.FifthEd.SRD.Backgrounds {
    public class NoBackground : IBackground {
        public string Name => "No Background";
        public string ID => "SRD.Background.None";
        public bool HasChoices => false;

        public IBackground GetInstance() => new NoBackground();

        public void BuildPopup(PopupNCBackgroundOptions backgroundOptions) { }
        public void BuildPopup(PopupNCBackgroundOptions_GTK backgroundOptions) { }
        public void ConfirmPopup() { }
    }
}
