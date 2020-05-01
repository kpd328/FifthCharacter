using FifthCharacter.Plugin.Interface;
using System.Collections.ObjectModel;

namespace FifthCharacter.Plugin.StatsManager {
    public static class FeaturesManager {
        public static ObservableCollection<IFeature> Features { get; private set; } = new ObservableCollection<IFeature>();
    }
}
