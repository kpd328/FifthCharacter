using FifthCharacter.Plugin.Interface;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.Plugin.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupSpell_GTK : ContentPage {
        private IMagic Context;

        public PopupSpell_GTK(IMagic spell) {
            InitializeComponent();
            Context = spell;
            BindingContext = Context;
        }
    }
}