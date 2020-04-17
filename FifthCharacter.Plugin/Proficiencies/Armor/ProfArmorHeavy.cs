using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Armor {
    public class ProfArmorHeavy : AProfArmor {
        public override string Name => "Heavy Armor";
        public override string Source { get; }
        public override string ID => "Armor.Proficiency.Heavy";
        
        public ProfArmorHeavy(string source) {
            Source = source;
        }
    }
}
