using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfSurvival : AProfSkill {
        public override string Name => "Survival";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Survival";

        internal ProfSurvival() { }

        public ProfSurvival(string source) {
            Source = source;
        }
    }
}
