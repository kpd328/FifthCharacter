using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace FifthCharacter {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPopup : PopupPage {
        public TestPopup() {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {
            PopupNavigation.Instance.PopAsync();
        }
    }
}