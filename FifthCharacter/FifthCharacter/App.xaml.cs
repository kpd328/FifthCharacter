using FifthCharacter.Plugin;
using FifthCharacter.Utilities;
using FifthCharacter.Utilities.PlatformFonts;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter {
    public partial class App : Application {
        internal static PluginLoader Plugins;

        public App() {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk1ODI0QDMxMzgyZTMyMmUzMGxXdW1FampZaXhHUUJQY0E4bkZNK3E0d0JmL0doTElSYmcrTHFGKzZONXc9");

            InitializeComponent();

            try {
                Plugins = PluginLoader.GetLoader();
                Plugins.LoadPlugins();
            } catch(Exception e) {
                System.Diagnostics.Debug.WriteLine(string.Format("Plugins could not be loaded: {0}", e.Message));
            }

            MainPage = new NavigationPage(new MainPage());
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
                SetFonts(mergedDictionaries);
                break;
            case Theme.Dark:
                mergedDictionaries.Add(new DarkTheme());
                SetFonts(mergedDictionaries);
                break;
            }

            mergedDictionaries.Add(new XamMaterialIcons());
        }

        void SetFonts(ICollection<ResourceDictionary> mergedDictionaries) {
            switch (Device.RuntimePlatform) {
            case Device.iOS:
                mergedDictionaries.Add(new iOSFonts());
                break;
            case Device.Android:
                mergedDictionaries.Add(new AndroidFonts());
                break;
            case Device.UWP:
                mergedDictionaries.Add(new UWPFonts());
                break;
            case Device.GTK:
                mergedDictionaries.Add(new UWPFonts());
                break;
            default:
                mergedDictionaries.Add(new FallbackFonts());
                break;
            }
        }
    }
}
