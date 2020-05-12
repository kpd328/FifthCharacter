using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfPerformance : AProfSkill {
        public override string Name => "Performance";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Performance";

        internal ProfPerformance() { }

        public ProfPerformance(string source) {
            Source = source;
        }
    }
}
