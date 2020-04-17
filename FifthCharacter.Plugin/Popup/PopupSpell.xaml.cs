using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.Plugin.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupSpell : PopupPage {
        private IMagic Context;

        public PopupSpell(IMagic spell) {
            InitializeComponent();
            Context = spell;
            BindingContext = Context;
        }

        private void CloseButton_Clicked(object sender, EventArgs e) {
            PopupNavigation.Instance.PopAsync();
        }
    }
}