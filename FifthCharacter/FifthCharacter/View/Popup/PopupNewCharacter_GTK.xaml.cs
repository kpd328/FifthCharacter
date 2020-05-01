using FifthCharacter.Viewmodel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupNewCharacter_GTK : ContentPage {
        private NewCharacterVM Viewmodel;

        public PopupNewCharacter_GTK(NewCharacterVM viewmodel) {
            InitializeComponent();
            Viewmodel = viewmodel;
            Viewmodel.Bind(this);
        }
    }
}