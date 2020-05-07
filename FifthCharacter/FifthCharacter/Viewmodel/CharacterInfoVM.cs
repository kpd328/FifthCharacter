using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.View;
using FifthCharacter.Plugin.Tools;
using System.ComponentModel;

namespace FifthCharacter.Viewmodel {
    public class CharacterInfoVM : INotifyPropertyChanged {
        public string CharacterName => CharacterManager.CharacterName;
        public string ClassLevel => CharacterManager.ClassLevel;
        public string Background => CharacterManager.Background;
        public string PlayerName => CharacterManager.PlayerName;
        public string Race => CharacterManager.Race != null ? CharacterManager.Race.Name : "";
        public string Alignment => CharacterManager.Alignment.DisplayString();
        public string ExperiencePoints => CharacterManager.ExperiecePoints.ToString();

        private CharacterInfo View;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Bind(CharacterInfo view) {
            View = view;
            View.BindingContext = this;
        }

        internal virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
