using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Attacks {
    public class ProfMartialMeleeWeapon : AProfWeapon {
        public override string Name => "Martial Melee Weapons";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee";

        internal ProfMartialMeleeWeapon() { }

        public ProfMartialMeleeWeapon(string source) {
            Source = source;
        }
    }
}
