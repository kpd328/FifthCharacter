using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.View;
using System.Collections.ObjectModel;

namespace FifthCharacter.Viewmodel {
    public class FeaturesListVM {
        private FeaturesList View;

        public ObservableCollection<IFeature> Features => FeaturesManager.Features;

        public void Bind(FeaturesList view) {
            this.View = view;
            View.BindingContext = this;
        }
    }
}
