using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWRapier : AProfWeapon {
        public override string Name => "Rapier";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Rapier";

        internal ProfMMWRapier() { }

        public ProfMMWRapier(string source) {
            Source = source;
        }
    }
}
