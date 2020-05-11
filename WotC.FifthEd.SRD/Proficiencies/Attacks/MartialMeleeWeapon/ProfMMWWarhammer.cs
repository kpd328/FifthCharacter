using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWWarhammer : AProfWeapon {
        public override string Name => "Warhammer";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Warhammer";

        internal ProfMMWWarhammer() { }

        public ProfMMWWarhammer(string source) {
            Source = source;
        }
    }
}
