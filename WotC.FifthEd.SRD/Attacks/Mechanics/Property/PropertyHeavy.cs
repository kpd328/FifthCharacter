using FifthCharacter.Plugin.Attacks.Abstract;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyHeavy : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Heavy;
        public string PropertyName => WeapPropName.Heavy;
    }
}
