using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWLongsword : AProfWeapon {
        public override string Name => "Longsword";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Longsword";

        public ProfMMWLongsword(string source) {
            Source = source;
        }
    }
}
