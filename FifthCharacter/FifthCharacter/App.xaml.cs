using FifthCharacter.Utilities;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart() {
            base.OnStart();
            Theme theme = DependencyService.Get<IEnvironment>().GetOperatingSystemTheme();
            SetTheme(theme);
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
            base.OnResume();
            Theme theme = DependencyService.Get<IEnvironment>().GetOperatingSystemTheme();
            SetTheme(theme);
        }

        void SetTheme(Theme theme) {
            ICollection<ResourceDictionary> mergedDictionaries = Current.Resources.MergedDictionaries;
            mergedDictionaries.Clear();

            switch (theme) {
            case Theme.Light:
                mergedDictionaries.Add(new LightTheme());
                break;
            case Theme.Dark:
                mergedDictionaries.Add(new DarkTheme());
                break;
            }
        }
    }
}
