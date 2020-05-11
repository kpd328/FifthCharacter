using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWScimitar : AProfWeapon {
        public override string Name => "Scimitar";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Scimitar";

        internal ProfMMWScimitar() { }

        public ProfMMWScimitar(string source) {
            Source = source;
        }
    }
}
