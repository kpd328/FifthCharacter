using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfDeception : AProfSkill {
        public override string Name => "Deception";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Deception";
        public ProfDeception(string source) {
            Source = source;
        }
    }
}
