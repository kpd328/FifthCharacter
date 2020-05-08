using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfSleightOfHand : AProfSkill {
        public override string Name => "Sleight of Hand";
        public override string Source { get; }
        public override string ID => "Skill.Proficiency.SleightOfHand";
        public ProfSleightOfHand(string source) {
            Source = source;
        }
    }
}
