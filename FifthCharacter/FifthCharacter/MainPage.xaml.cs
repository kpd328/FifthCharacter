using FifthCharacter.Utilities;
using FifthCharacter.Viewmodel;
using Rg.Plugins.Popup.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace FifthCharacter {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage {
        private ToolbarVM Toolbar;

        public MainPage() {
            InitializeComponent();
            Toolbar = new ToolbarVM(this);
        }
    }
}
