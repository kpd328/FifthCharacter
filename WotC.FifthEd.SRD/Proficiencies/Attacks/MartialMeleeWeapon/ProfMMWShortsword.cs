using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWShortsword : AProfWeapon {
        public override string Name => "Shortsword";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Shortsword";

        public ProfMMWShortsword(string source) {
            Source = source;
        }
    }
}
