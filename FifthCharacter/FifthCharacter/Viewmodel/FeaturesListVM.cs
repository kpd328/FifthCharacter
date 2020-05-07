using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.View;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FifthCharacter.Viewmodel {
    public class FeaturesListVM : INotifyPropertyChanged {
        private FeaturesList View;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<IFeature> Features => FeaturesManager.Features;

        public void Bind(FeaturesList view) {
            this.View = view;
            View.BindingContext = this;
        }

        public virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
