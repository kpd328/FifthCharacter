using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWGreatclub : AProfWeapon {
        public override string Name => "Greatclub";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Greatclub";

        internal ProfSMWGreatclub() { }

        public ProfSMWGreatclub(string source) {
            Source = source;
        }
    }
}
