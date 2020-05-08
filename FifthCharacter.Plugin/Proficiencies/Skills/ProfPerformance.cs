using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfPerformance : AProfSkill {
        public override string Name => "Performance";
        public override string Source { get; }
        public override string ID => "Skill.Proficiency.Performance";
        public ProfPerformance(string source) {
            Source = source;
        }
    }
}
