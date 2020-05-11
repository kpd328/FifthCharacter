using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWTrident : AProfWeapon {
        public override string Name => "Trident";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Trident";

        internal ProfMMWTrident() { }

        public ProfMMWTrident(string source) {
            Source = source;
        }
    }
}
