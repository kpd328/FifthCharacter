using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWGreataxe : AProfWeapon {
        public override string Name => "Greataxe";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Greataxe";

        internal ProfMMWGreataxe() { }

        public ProfMMWGreataxe(string source) {
            Source = source;
        }
    }
}
