using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor {
    public class ArmorShield : AShield {
        public override string Name => "Shield";
        public override string ID => "SRD.Armor.Shield";
        public override ACurrency Cost => new GoldPiece(10);
        public override string Weight => "6 lbs.";
        public override int Bonus { get; set; } = 2;

        public override string Description => ArmorDescriptionText.Shield;

        public override IArmor GetInstance() => new ArmorShield();
    }
}
