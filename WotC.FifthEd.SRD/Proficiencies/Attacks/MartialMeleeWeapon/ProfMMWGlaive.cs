using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWGlaive : AProfWeapon {
        public override string Name => "Glaive";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Glaive";

        public ProfMMWGlaive(string source) {
            Source = source;
        }
    }
}
