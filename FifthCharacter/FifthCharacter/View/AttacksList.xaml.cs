using FifthCharacter.Viewmodel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AttacksList : ContentView {
        public AttacksList(AttacksListVM attacksList) {
            InitializeComponent();
            attacksList.Bind(this);
        }
    }
}