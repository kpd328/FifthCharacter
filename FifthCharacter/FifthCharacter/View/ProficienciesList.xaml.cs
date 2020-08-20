using FifthCharacter.Viewmodel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProficienciesList : ContentView {
        internal ProficienciesListVM Viewmodel;

        public ProficienciesList(ProficienciesListVM proficiencies) {
            InitializeComponent();
            proficiencies.Bind(this);
            Viewmodel = proficiencies;
        }
    }
}