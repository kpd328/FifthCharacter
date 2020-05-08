using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfSurvival : AProfSkill {
        public override string Name => "Survival";
        public override string Source { get; }
        public override string ID => "Skill.Proficiency.Survival";
        public ProfSurvival(string source) {
            Source = source;
        }
    }
}
