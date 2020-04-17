using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.View;

namespace FifthCharacter.Viewmodel {
    public class CharacterInfoVM {
        public string CharacterName => CharacterManager.CharacterName;
        public string ClassLevel => CharacterManager.ClassLevel;
        public string Background => CharacterManager.Background;
        public string PlayerName => CharacterManager.PlayerName;
        public string Race => CharacterManager.Race;
        public string Alignment => CharacterManager.Alignment;
        public string ExperiencePoints => CharacterManager.ExperiecePoints.ToString();

        private CharacterInfo View;

        public void Bind(CharacterInfo view) {
            View = view;
            View.BindingContext = this;
        }
    }
}
