using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.View;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FifthCharacter.Viewmodel {
    public class ProficienciesListVM : INotifyPropertyChanged {
        private ProficienciesList View;
        public event PropertyChangedEventHandler PropertyChanged;
        private ProficiencyType Type;

        public ObservableCollection<IProficiency> Proficiencies => ProficiencyManager.AllProficienciesOfType(Type);

        public ProficienciesListVM(ProficiencyType type) {
            this.Type = type;
        }

        public void Bind(ProficienciesList view) {
            this.View = view;
            View.BindingContext = this;
        }

        public virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
