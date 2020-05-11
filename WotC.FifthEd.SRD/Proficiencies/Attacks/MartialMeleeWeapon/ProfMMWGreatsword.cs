using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWGreatsword : AProfWeapon {
        public override string Name => "Greatsword";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Greatsword";

        internal ProfMMWGreatsword() { }

        public ProfMMWGreatsword(string source) {
            Source = source;
        }
    }
}
