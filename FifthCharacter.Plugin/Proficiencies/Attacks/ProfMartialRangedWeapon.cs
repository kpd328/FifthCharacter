using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Attacks {
    public class ProfMartialRangedWeapon : AProfWeapon {
        public override string Name => "Martial Ranged Weapons";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialRanged";

        internal ProfMartialRangedWeapon() { }

        public ProfMartialRangedWeapon(string source) {
            Source = source;
        }
    }
}
