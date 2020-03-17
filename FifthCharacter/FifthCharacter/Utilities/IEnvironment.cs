using System.Threading.Tasks;

namespace FifthCharacter.Utilities {
    public interface IEnvironment {
        Theme GetOperatingSystemTheme();
        Task<Theme> GetOperatingSystemThemeAsync();
    }

    public enum Theme { Light, Dark }
}
