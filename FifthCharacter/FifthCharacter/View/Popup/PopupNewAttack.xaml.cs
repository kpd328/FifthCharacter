using FifthCharacter.Viewmodel;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupNewAttack : PopupPage {
        public PopupNewAttack(NewAttackVM viewmodel) {
            InitializeComponent();
            viewmodel.Bind(this);
        }
    }
}