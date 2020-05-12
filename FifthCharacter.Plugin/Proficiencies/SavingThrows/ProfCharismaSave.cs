using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.SavingThrows {
    public class ProfCharismaSave : AProfSave {
        public override string Name => "Charisma Saving Throw";
        public override string Source { get; set; }
        public override string ID => "SavingThrow.Proficiency.Charisma";

        internal ProfCharismaSave() { }

        public ProfCharismaSave(string source) {
            Source = source;
        }
    }
}
