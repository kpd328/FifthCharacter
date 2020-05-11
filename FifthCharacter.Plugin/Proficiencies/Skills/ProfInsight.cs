using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfInsight : AProfSkill {
        public override string Name => "Insight";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Insight";
        public ProfInsight(string source) {
            Source = source;
        }
    }
}
