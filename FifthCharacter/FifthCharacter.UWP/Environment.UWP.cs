using FifthCharacter.Utilities;
using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;

[assembly: Xamarin.Forms.Dependency(typeof(FifthCharacter.UWP.Environment))]
namespace FifthCharacter.UWP {
    public class Environment : IEnvironment {
        public Theme GetOperatingSystemTheme() {
            var currentTheme = App.Current.RequestedTheme;
            switch (currentTheme) {
            case ApplicationTheme.Dark:
                return Theme.Dark;
            case ApplicationTheme.Light:
                return Theme.Light;
            default:
                throw new NotSupportedException($"UIUserInterfaceStyle {currentTheme} not supported");
            }
            throw new NotImplementedException();
        }

        public Task<Theme> GetOperatingSystemThemeAsync() => Task.FromResult(GetOperatingSystemTheme());
    }
}
