using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWLance : AProfWeapon {
        public override string Name => "Lance";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Lance";

        public ProfMMWLance(string source) {
            Source = source;
        }
    }
}
