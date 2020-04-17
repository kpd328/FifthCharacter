using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWRapier : AProfWeapon {
        public override string Name => "Rapier";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Rapier";

        public ProfMMWRapier(string source) {
            Source = source;
        }
    }
}
