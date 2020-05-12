using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Armor {
    public class ProfArmorLight : AProfArmor {
        public override string Name => "Light Armor";
        public override string Source { get; set; }
        public override string ID => "Armor.Proficiency.Light";

        internal ProfArmorLight() { }
        
        public ProfArmorLight(string source) {
            Source = source;
        }
    }
}
