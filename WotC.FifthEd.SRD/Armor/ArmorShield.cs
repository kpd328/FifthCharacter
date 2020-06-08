using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Armor {
    public class ArmorShield : AShield {
        public override string Name => "Shield";
        public override string ID => "SRD.Armor.Shield";
        public override string Cost => "10 gp";
        public override string Weight => "6 lbs.";
        public override int Bonus { get; set; } = 2;

        public override IArmor GetInstance() => new ArmorShield();
    }
}
