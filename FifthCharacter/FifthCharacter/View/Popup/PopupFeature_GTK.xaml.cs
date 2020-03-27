using FifthCharacter.Interface;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View.Popup {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupFeature_GTK : ContentPage {
        private IFeature Context;
        
        public PopupFeature_GTK(IFeature feature) {
            InitializeComponent();
            Context = feature;
            BindingContext = Context;
        }
    }
}