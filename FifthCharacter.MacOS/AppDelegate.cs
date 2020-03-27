using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;
using AppKit;
using Foundation;

namespace FifthCharacter.MacOS {
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate {
        NSWindow window;

        public AppDelegate() {
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

            var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
            window = new NSWindow(rect, style, NSBackingStore.Buffered, false) {
                Title = "Fifth Character",
                TitleVisibility = NSWindowTitleVisibility.Hidden
            };
        }

        public override NSWindow MainWindow => window;

        public override void DidFinishLaunching(NSNotification notification) {
            Forms.Init();
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification) {
            // Insert code here to tear down your application
        }
    }
}
