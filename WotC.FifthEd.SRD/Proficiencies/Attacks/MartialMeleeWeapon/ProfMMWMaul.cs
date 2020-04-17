using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWMaul : AProfWeapon {
        public override string Name => "Maul";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Maul";

        public ProfMMWMaul(string source) {
            Source = source;
        }
    }
}
