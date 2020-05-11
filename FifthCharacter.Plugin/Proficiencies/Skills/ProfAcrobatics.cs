using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfAcrobatics : AProfSkill {
        public override string Name => "Acrobatics";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Acrobatics";
        public ProfAcrobatics(string source) {
            Source = source;
        }
    }
}
