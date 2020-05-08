using FifthCharacter.Viewmodel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbilityScore : ContentView {
        internal IAbilityVM Viewmodel;

        public AbilityScore(IAbilityVM ability) {
            InitializeComponent();
            ability.Bind(this);
            Viewmodel = ability;
        }
    }
}