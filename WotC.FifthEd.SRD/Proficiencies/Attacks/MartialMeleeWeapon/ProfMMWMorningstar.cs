using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWMorningstar : AProfWeapon {
        public override string Name => "Morningstar";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Morningstar";

        public ProfMMWMorningstar(string source) {
            Source = source;
        }
    }
}
