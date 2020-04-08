using FifthCharacter.Plugin.Attacks.Abstract;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyLight : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Light;
        public string PropertyName => WeapPropName.Light;
    }
}
