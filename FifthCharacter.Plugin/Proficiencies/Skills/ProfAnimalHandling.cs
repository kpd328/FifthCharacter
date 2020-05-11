using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfAnimalHandling : AProfSkill {
        public override string Name => "Animal Handling";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.AnimalHandling";
        public ProfAnimalHandling(string source) {
            Source = source;
        }
    }
}
