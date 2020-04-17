using FifthCharacter.Plugin.Interface;
using FifthCharacter.View.Popup;
using Rg.Plugins.Popup.Services;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace FifthCharacter.Viewmodel {
    public class NewAttackVM {
        PopupNewAttack View;
        PopupNewAttack_GTK ViewGTK;

        public ObservableCollection<IAttack> AttacksList { get; private set; }

        private ICommand _addAttack;
        public ICommand AddAttack => _addAttack ?? (_addAttack = new Command(() => {
            PopupNavigation.Instance.PopAsync();
        }));

        public NewAttackVM() {
            AttacksList = new ObservableCollection<IAttack>(App.Plugins.Attacks.AsEnumerable());
        }

        public void Bind(PopupNewAttack popup) {
            View = popup;
            View.BindingContext = this;
        }

        public void Bind(PopupNewAttack_GTK popup) {
            ViewGTK = popup;
            ViewGTK.BindingContext = this;
        }
    }
}
