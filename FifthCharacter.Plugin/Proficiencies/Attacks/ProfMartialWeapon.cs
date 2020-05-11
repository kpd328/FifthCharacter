using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Attacks {
    public class ProfMRWHandCrossbows : AProfWeapon {
        public override string Name => "Martial Weapons";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.AllMartial";
        public ProfMRWHandCrossbows(string source) {
            Source = source;
        }
    }
}
