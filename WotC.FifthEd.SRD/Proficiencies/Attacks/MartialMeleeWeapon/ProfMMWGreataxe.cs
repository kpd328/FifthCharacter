using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWGreataxe : AProfWeapon {
        public override string Name => "Greataxe";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Greataxe";

        public ProfMMWGreataxe(string source) {
            Source = source;
        }
    }
}
