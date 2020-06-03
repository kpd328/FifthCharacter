using FifthCharacter.Plugin.Interface;
using FifthCharacter.View.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FifthCharacter.Viewmodel {
    public class ToolbarVM {
        private MainPage View;

        private ICommand _newCharacter;
        public ICommand NewCharacter => _newCharacter ??= new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PushAsync(new PopupNewCharacter(new NewCharacterVM(View)));
                    break;
                case Device.GTK:
                    DependencyService.Get<IPopup>().PushAsync(new PopupNewCharacter_GTK(new NewCharacterVM(View)));
                    break;
                default:
                    throw new NotImplementedException();
            }
        });

        public ToolbarVM(MainPage mainPage) {
            View = mainPage;
            View.BindingContext = this;
        }
    }
}
