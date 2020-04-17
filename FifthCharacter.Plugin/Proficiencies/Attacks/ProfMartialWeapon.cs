using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Attacks {
    public class ProfMartialWeapon : AProfWeapon {
        public override string Name => "Martial Weapons";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.AllMartial";
        public ProfMartialWeapon(string source) {
            Source = source;
        }
    }
}
