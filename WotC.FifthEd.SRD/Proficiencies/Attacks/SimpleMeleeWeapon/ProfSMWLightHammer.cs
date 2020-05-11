using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWLightHammer : AProfWeapon {
        public override string Name => "Light Hammer";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.LightHammer";

        internal ProfSMWLightHammer() { }
        
        public ProfSMWLightHammer(string source) {
            Source = source;
        }
    }
}
