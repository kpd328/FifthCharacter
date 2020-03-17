using Xamarin.Forms;

namespace FifthCharacter.Utilities {
    public interface IPopup {
        void PushAsync(Page page);
        void PopAsync();
    }
}
