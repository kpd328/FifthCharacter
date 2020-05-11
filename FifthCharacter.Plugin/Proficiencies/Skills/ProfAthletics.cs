using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfAthletics : AProfSkill {
        public override string Name => "Athletics";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Athletics";
        public ProfAthletics(string source) {
            Source = source;
        }
    }
}
