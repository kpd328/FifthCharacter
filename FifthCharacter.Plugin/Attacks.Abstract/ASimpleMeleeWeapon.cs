namespace FifthCharacter.Plugin.Attacks.Abstract {
    public abstract class ASimpleMeleeWeapon : ASimpleWeapon {
        public override string Range => "5 feet";
        public override string WeaponType => "Simple Melee Weapon";
    }
}
