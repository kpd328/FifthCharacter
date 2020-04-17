using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWWhip : AProfWeapon {
        public override string Name => "Whip";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Whip";

        public ProfMMWWhip(string source) {
            Source = source;
        }
    }
}
