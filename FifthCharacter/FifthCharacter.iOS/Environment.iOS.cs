using FifthCharacter.Utilities;
using System;
using System.Linq;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(FifthCharacter.iOS.Environment))]
namespace FifthCharacter.iOS {
    class Environment : IEnvironment {
        public Theme GetOperatingSystemTheme() {
            if (UIDevice.CurrentDevice.CheckSystemVersion(12, 0)) {
                var currentUIViewController = GetVisibleViewController();

                var userInterfaceStyle = currentUIViewController.TraitCollection.UserInterfaceStyle;

                switch (userInterfaceStyle) {
                case UIUserInterfaceStyle.Light:
                    return Theme.Light;
                case UIUserInterfaceStyle.Dark:
                    return Theme.Dark;
                default:
                    throw new NotSupportedException($"UIUserInterfaceStyle {userInterfaceStyle} not supported");
                }
            } else {
                return Theme.Light;
            }
        }

        public Task<Theme> GetOperatingSystemThemeAsync() => Device.InvokeOnMainThreadAsync(GetOperatingSystemTheme);

        static UIViewController GetVisibleViewController() {
            UIViewController viewController = null;

            var window = UIApplication.SharedApplication.KeyWindow;

            if (window.WindowLevel == UIWindowLevel.Normal) {
                viewController = window.RootViewController;
            }

            if (viewController is null) {
                window = UIApplication.SharedApplication
                    .Windows
                    .OrderByDescending(w => w.WindowLevel)
                    .FirstOrDefault(w => w.RootViewController != null && w.WindowLevel == UIWindowLevel.Normal);

                viewController = window?.RootViewController ?? throw new InvalidOperationException("Could not find current view controller.");
            }

            while (viewController.PresentedViewController != null) {
                viewController = viewController.PresentedViewController;
            }

            return viewController;
        }
    }
}