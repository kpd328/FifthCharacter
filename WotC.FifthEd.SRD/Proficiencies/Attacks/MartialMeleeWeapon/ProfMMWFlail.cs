using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWFlail : AProfWeapon {
        public override string Name => "Flail";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Flail";

        internal ProfMMWFlail() { }

        public ProfMMWFlail(string source) {
            Source = source;
        }
    }
}
