using FifthCharacter.Viewmodel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeaturesList : ContentView {
        internal FeaturesListVM Viewmodel;

        public FeaturesList(FeaturesListVM features) {
            InitializeComponent();
            features.Bind(this);
            Viewmodel = features;
        }
    }
}