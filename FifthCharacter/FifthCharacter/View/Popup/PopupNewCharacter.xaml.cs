using FifthCharacter.Viewmodel;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupNewCharacter : PopupPage {
        private NewCharacterVM Viewmodel;

        public PopupNewCharacter(NewCharacterVM viewmodel) {
            InitializeComponent();
            Viewmodel = viewmodel;
            Viewmodel.Bind(this);
        }
    }
}