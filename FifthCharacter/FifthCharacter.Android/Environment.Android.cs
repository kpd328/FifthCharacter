using Android.Content.Res;
using Android.OS;
using FifthCharacter.Utilities;
using Plugin.CurrentActivity;
using System;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(FifthCharacter.Droid.Environment))]
namespace FifthCharacter.Droid {
    public class Environment : IEnvironment {
        public Theme GetOperatingSystemTheme() {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Froyo) {
                var uiModeFlags = CrossCurrentActivity.Current.AppContext.Resources.Configuration.UiMode & UiMode.NightMask;

                switch (uiModeFlags) {
                case UiMode.NightYes:
                    return Theme.Dark;
                case UiMode.NightNo:
                    return Theme.Light;
                default:
                    throw new NotSupportedException($"UiMode {uiModeFlags} not supported");
                }
            } else {
                return Theme.Light;
            }
        }

        public Task<Theme> GetOperatingSystemThemeAsync() => Task.FromResult(GetOperatingSystemTheme());
    }
}