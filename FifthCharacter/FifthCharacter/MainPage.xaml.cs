using FifthCharacter.Utilities;
using Rg.Plugins.Popup.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace FifthCharacter {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {
            if(Device.RuntimePlatform == Device.GTK) {
                DependencyService.Get<IPopup>().PushAsync(new TestGTKPopup());
            } else {
                PopupNavigation.Instance.PushAsync(new TestPopup());
            }
        }
    }
}
