using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWTrident : AProfWeapon {
        public override string Name => "Trident";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Trident";

        public ProfMMWTrident(string source) {
            Source = source;
        }
    }
}
