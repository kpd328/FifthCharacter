using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FifthCharacter.Plugin {
    public static class Constants {
        //The folder name which contains the plugin DLLs
        public const string FolderName = "Plugins";
        public static string FolderPath {
            get {
                switch (Device.RuntimePlatform) {
                    case Device.Android:
                        return Path.Combine("/storage/emulated/0/Android/data", AppInfo.PackageName ,"files", FolderName);
                    case Device.UWP:
                    case Device.GTK:
                        return FolderName;
                    default:
                        return FolderName;
                }
            }
        }
    }
}
