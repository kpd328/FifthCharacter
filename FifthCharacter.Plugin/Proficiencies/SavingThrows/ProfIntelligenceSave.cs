using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.SavingThrows {
    public class ProfIntelligenceSave : AProfSave {
        public override string Name => "Intelligence Saving Throws";
        public override string Source { get; set; }
        public override string ID => "SavingThrow.Proficiency.Intelligence";
        public ProfIntelligenceSave(string source) {
            Source = source;
        }
    }
}
