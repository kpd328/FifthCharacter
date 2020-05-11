using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWShortsword : AProfWeapon {
        public override string Name => "Shortsword";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Shortsword";

        internal ProfMMWShortsword() { }

        public ProfMMWShortsword(string source) {
            Source = source;
        }
    }
}
