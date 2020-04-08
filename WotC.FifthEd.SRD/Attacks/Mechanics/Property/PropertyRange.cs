using FifthCharacter.Plugin.Attacks.Abstract;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyRange : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Range;
        public string PropertyName => WeapPropName.Range;
    }
}
