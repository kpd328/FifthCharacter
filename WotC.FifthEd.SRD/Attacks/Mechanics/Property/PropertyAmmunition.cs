namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyAmmunition : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Ammunition;
        public string PropertyName => WeapPropName.Ammunition;
        private int RangeOpt { get; set; }
        private int RangeMax { get; set; }

        public PropertyAmmunition(int opt, int max) {
            RangeOpt = opt;
            RangeMax = max;
        }
    }
}
