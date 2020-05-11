using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfMedicine : AProfSkill {
        public override string Name => "Medicine";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Medicine";
        public ProfMedicine(string source) {
            Source = source;
        }
    }
}
