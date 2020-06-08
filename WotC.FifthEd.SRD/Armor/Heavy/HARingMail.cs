using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Armor.Heavy {
    public class HARingMail : AHeavyArmor {
        public override string Name => "Ring Mail";
        public override string ID => "SRD.Armor.Heavy.RingMail";
        public override string Cost => "30 gp";
        public override string Weight => "40 lbs.";
        public override int ArmorClass => 14 + Bonus;
        public override bool CanWear => true;

        public override IArmor GetInstance() => new HARingMail();
    }
}
