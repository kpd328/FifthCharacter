using FifthCharacter.Plugin.Interface;
using FifthCharacter.StatsManager;
using FifthCharacter.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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
