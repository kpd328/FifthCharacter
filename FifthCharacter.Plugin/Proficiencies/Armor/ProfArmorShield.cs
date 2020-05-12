using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Armor {
    public class ProfArmorShield : AProfArmor {
        public override string Name => "Shields";
        public override string Source { get; set; }
        public override string ID => "Armor.Proficiency.Shield";

        internal ProfArmorShield() { }

        public ProfArmorShield(string source) {
            Source = source;
        }
    }
}
