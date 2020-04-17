using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.SavingThrows {
    public class ProfCharismaSave : AProfSave {
        public override string Name => "Charisma Saving Throw";
        public override string Source { get; }
        public override string ID => "SavingThrow.Proficiency.Charisma";
        public ProfCharismaSave(string source) {
            Source = source;
        }
    }
}
