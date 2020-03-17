using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterInfo : ContentView {
        public CharacterInfo(CharacterInfoVM character) {
            InitializeComponent();
            character.Bind(this);
        }
    }
}