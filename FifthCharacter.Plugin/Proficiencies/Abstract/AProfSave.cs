using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Proficiencies.Abstract {
    public abstract class AProfSave : IProficiency {
        public abstract string Name { get; }
        public abstract string Source { get; set; }
        public abstract string ID { get; }
        public ProficiencyType ProficiencyType => ProficiencyType.SAVING_THROW;
    }
}
