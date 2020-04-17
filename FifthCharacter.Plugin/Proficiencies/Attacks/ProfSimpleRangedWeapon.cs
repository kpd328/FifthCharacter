using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Attacks {
    public class ProfSimpleRangedWeapon : AProfWeapon {
        public override string Name => "Simple Ranged Weapons";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleRanged";
        public ProfSimpleRangedWeapon(string source) {
            Source = source;
        }
    }
}
