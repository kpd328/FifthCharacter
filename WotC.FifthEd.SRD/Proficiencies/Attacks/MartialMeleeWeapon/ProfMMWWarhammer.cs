using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWWarhammer : AProfWeapon {
        public override string Name => "Warhammer";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Warhammer";

        public ProfMMWWarhammer(string source) {
            Source = source;
        }
    }
}
