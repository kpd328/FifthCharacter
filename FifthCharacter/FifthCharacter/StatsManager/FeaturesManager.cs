using FifthCharacter.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FifthCharacter.StatsManager {
    public static class FeaturesManager {
        public static ObservableCollection<IFeature> Features { get; private set; }

        static FeaturesManager() {
            Features = new ObservableCollection<IFeature>();
        }
    }
}
