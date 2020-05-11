using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Attacks {
    public class ProfSimpleMeleeWeapon : AProfWeapon {
        public override string Name => "Simple Melee Weapons";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleMelee";
        public ProfSimpleMeleeWeapon(string source) {
            Source = source;
        }
    }
}
