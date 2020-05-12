using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Attacks {
    public class ProfSimpleWeapon : AProfWeapon {
        public override string Name => "Simple Weapons";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.AllSimple";

        internal ProfSimpleWeapon() { }

        public ProfSimpleWeapon(string source) {
            Source = source;
        }
    }
}
