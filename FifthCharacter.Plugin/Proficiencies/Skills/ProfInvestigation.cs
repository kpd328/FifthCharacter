using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfInvestigation : AProfSkill {
        public override string Name => "Investigation";
        public override string Source { get; }
        public override string ID => "Skill.Proficiency.Investigation";
        public ProfInvestigation(string source) {
            Source = source;
        }
    }
}
