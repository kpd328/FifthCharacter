using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.SavingThrows {
    public class ProfWisdomSave : AProfSave {
        public override string Name => "Wisdom Saving Throws";
        public override string Source { get; }
        public override string ID => "SavingThrow.Proficiency.Wisdom";
        public ProfWisdomSave(string source) {
            Source = source;
        }
    }
}
