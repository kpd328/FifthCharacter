using Xamarin.Forms;

namespace FifthCharacter.Plugin.Interface {
    public interface IPopup {
        void PushAsync(Page page);
        void PopAsync();
    }
}
