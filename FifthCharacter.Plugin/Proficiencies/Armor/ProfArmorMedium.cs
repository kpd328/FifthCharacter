using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Armor {
    public class ProfArmorMedium : AProfArmor {
        public override string Name => "Medium Armor";
        public override string Source { get; set; }
        public override string ID => "Armor.Proficiency.Medium";
        
        public ProfArmorMedium(string source) {
            Source = source;
        }
    }
}
