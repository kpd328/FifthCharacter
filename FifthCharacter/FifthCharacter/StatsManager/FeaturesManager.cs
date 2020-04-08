using FifthCharacter.Plugin.Interface;
using System.Collections.ObjectModel;

namespace FifthCharacter.StatsManager {
    public static class FeaturesManager {
        public static ObservableCollection<IFeature> Features { get; private set; }

        static FeaturesManager() {
            Features = new ObservableCollection<IFeature>() {
                App.Plugins.Features["Fighting Style (Dueling)"].GetInstance(),
                App.Plugins.Features["Second Wind"].GetInstance(),
                App.Plugins.Features["Action Surge"].GetInstance()
            };
        }
    }
}
