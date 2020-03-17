using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.Utilities.PlatformFonts {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UWPFonts : ResourceDictionary {
        public UWPFonts() {
            InitializeComponent();
        }
    }
}