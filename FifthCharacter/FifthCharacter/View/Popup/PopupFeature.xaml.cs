using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View.Popup {
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