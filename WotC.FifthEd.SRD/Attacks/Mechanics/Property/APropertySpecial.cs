using FifthCharacter.Plugin.Attacks.Abstract;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public abstract class APropertySpecial : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Special;
        public string PropertyName => WeapPropName.Special;
    }
}
