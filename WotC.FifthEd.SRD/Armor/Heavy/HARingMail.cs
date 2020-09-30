using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor.Heavy {
    public class HARingMail : AHeavyArmor {
        public override string Name => "Ring Mail";
        public override string ID => "SRD.Armor.Heavy.RingMail";
        public override ACurrency Cost => new GoldPiece(30);
        public override string Weight => "40 lbs.";
        public override int ArmorClass => 14 + Bonus;
        public override bool CanWear => true;

        public override string Description => ArmorDescriptionText.RingMail;

        public override IArmor GetInstance() => new HARingMail();
    }
}
