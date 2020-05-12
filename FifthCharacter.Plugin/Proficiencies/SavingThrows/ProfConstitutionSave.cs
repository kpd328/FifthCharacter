using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.SavingThrows {
    public class ProfConstitutionSave : AProfSave {
        public override string Name => "Constitution Saving Throws";
        public override string Source { get; set; }
        public override string ID => "SavingThrow.Proficiency.Constitution";

        internal ProfConstitutionSave() { }

        public ProfConstitutionSave(string source) {
            Source = source;
        }
    }
}
