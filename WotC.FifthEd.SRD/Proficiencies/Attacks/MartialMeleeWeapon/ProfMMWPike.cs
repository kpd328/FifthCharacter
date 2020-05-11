using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWPike : AProfWeapon {
        public override string Name => "Pike";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Pike";

        internal ProfMMWPike() { }

        public ProfMMWPike(string source) {
            Source = source;
        }
    }
}
