using FifthCharacter.Plugin.Attacks.Abstract;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyThrown : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Thrown;
        public string PropertyName => WeapPropName.Thrown;
        private int RangeOpt { get; set; }
        private int RangeMax { get; set; }

        public PropertyThrown(int opt, int max) {
            RangeOpt = opt;
            RangeMax = max;
        }
    }
}
