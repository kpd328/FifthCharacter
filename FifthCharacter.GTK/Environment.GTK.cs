using FifthCharacter.Utilities;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(FifthCharacter.GTK.Environment))]
namespace FifthCharacter.GTK {
    public class Environment : IEnvironment {
        public Theme GetOperatingSystemTheme() {
            return Theme.Light;
            //TODO: Find a way to set this in a gtk specific config file
        }

        public Task<Theme> GetOperatingSystemThemeAsync() => Task.FromResult(GetOperatingSystemTheme());
    }
}
