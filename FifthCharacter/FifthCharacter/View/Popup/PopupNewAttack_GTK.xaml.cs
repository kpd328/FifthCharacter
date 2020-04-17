using FifthCharacter.Viewmodel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupNewAttack_GTK : ContentPage {
        public PopupNewAttack_GTK(NewAttackVM viewmodel) {
            InitializeComponent();
            viewmodel.Bind(this);
        }
    }
}