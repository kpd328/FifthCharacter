using FifthCharacter.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterDefense : ContentView {
        public CharacterDefense(CharacterDefenseVM viewModel) {
            InitializeComponent();
            viewModel.Bind(this);
        }
    }
}