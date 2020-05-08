using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfHistory : AProfSkill {
        public override string Name => "History";
        public override string Source { get; }
        public override string ID => "Skill.Proficiency.History";
        public ProfHistory(string source) {
            Source = source;
        }
    }
}
