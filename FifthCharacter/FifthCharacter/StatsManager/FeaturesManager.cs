using FifthCharacter.Features.Class.Fighter;
using FifthCharacter.Plugin.Interface;
using System.Collections.ObjectModel;

namespace FifthCharacter.StatsManager {
    public static class FeaturesManager {
        public static ObservableCollection<IFeature> Features { get; private set; }

        static FeaturesManager() {
            Features = new ObservableCollection<IFeature>() {
                new FFighterFightingStyle(FightingStyle.DUELING),
                new FFighterSecondWind(),
                new FFighterActionSurge()
            };
        }
    }
}
