using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.Plugin.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupFeature : PopupPage {
        private IFeature Context;

        public PopupFeature(IFeature feature) {
            InitializeComponent();
            Context = feature;
            BindingContext = Context;
        }

        private void CloseButton_Clicked(object sender, EventArgs e) {
            PopupNavigation.Instance.PopAsync();
        }
    }
}