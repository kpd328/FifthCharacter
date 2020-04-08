using FifthCharacter.Plugin.Attacks.Abstract;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyLoading : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Loading;
        public string PropertyName => WeapPropName.Loading;
    }
}
