using FifthCharacter.GTK;
using FifthCharacter.Utilities;
using Gtk;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;
using Xamarin.Forms.Platform.GTK.Extensions;

[assembly: Dependency(typeof(Popup))]
namespace FifthCharacter.GTK {
    public class Popup : IPopup {
        private Stack<Window> PopupStack = new Stack<Window>();

        public void PopAsync() {
            var _popup = PopupStack.Pop();
            _popup.Destroy();
        }

        public void PushAsync(Page page) {
            var _popup = page.CreateContainer();
            var _window = new Window(page.Title);
            _window.SetSize(255, 255);
            _window.Add(_popup);
            PopupStack.Push(_window);
            _window.Show();
        }
    }
}
