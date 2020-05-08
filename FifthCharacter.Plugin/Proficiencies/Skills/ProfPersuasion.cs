using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfPersuasion : AProfSkill {
        public override string Name => "Persuasion";
        public override string Source { get; }
        public override string ID => "Skill.Proficiency.Persuasion";
        public ProfPersuasion(string source) {
            Source = source;
        }
    }
}
