using Rg.Plugins.Popup.Pages;
using System;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.Plugin.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupNCAbilityScores : PopupPage {
        public Action<string> Callback;

        public PopupNCAbilityScores() {
            InitializeComponent();
        }

        public PopupNCAbilityScores(Action<string> callback) {
            Callback = callback;
            InitializeComponent();
        }

        private void SfTabView_TabItemTapped(object sender, Syncfusion.XForms.TabView.TabItemTappedEventArgs e) {
            Callback(e.TabItem.Title);
        }
    }
}