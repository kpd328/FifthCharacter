using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWScimitar : AProfWeapon {
        public override string Name => "Scimitar";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Scimitar";

        public ProfMMWScimitar(string source) {
            Source = source;
        }
    }
}
