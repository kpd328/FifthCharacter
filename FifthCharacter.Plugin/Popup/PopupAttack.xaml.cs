using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.Plugin.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupAttack : PopupPage {
        private IAttack Context;

        public PopupAttack(IAttack attack) {
            InitializeComponent();
            Context = attack;
            BindingContext = Context;
        }

        private void CloseButton_Clicked(object sender, EventArgs e) {
            PopupNavigation.Instance.PopAsync();
        }
    }
}