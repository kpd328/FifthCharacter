using FifthCharacter.Utilities;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestGTKPopup : ContentPage {
        public TestGTKPopup() {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {
            DependencyService.Get<IPopup>().PopAsync();
        }
    }
}