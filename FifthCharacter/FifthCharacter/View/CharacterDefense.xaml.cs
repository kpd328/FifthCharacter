using FifthCharacter.Viewmodel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterDefense : ContentView {
        internal CharacterDefenseVM Viewmodel;

        public CharacterDefense(CharacterDefenseVM viewmodel) {
            InitializeComponent();
            viewmodel.Bind(this);
            Viewmodel = viewmodel;
        }
    }
}