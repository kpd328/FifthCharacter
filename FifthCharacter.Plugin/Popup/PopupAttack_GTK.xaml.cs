using FifthCharacter.Plugin.Interface;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.Plugin.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupAttack_GTK : ContentPage {
        private IAttack Context;

        public PopupAttack_GTK(IAttack attack) {
            InitializeComponent();
            Context = attack;
            BindingContext = Context;
        }
    }
}