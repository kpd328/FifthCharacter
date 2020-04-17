using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.View;
using FifthCharacter.View.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace FifthCharacter.Viewmodel {
    public class AttacksListVM {
        private AttacksList View;

        public ObservableCollection<IAttack> Attacks => AttacksManager.Attacks;

        public void Bind(AttacksList view) {
            View = view;
            View.BindingContext = this;
        }

        private ICommand _addAttack;
        public ICommand AddAttack => _addAttack ?? (_addAttack = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PushAsync(new PopupNewAttack(new NewAttackVM()));
                    break;
                case Device.GTK:
                    DependencyService.Get<IPopup>().PushAsync(new PopupNewAttack_GTK(new NewAttackVM()));
                    break;
                default:
                    throw new NotImplementedException();
            }
            
        }));
    }
}
