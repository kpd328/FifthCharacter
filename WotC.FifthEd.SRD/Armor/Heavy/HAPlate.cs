using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor.Heavy {
    public class HAPlate : AHeavyArmor {
        public override string Name => "Plate Armor";
        public override string ID => "SRD.Armor.Heavy.Plate";
        public override ACurrency Cost => new GoldPiece(1500);
        public override string Weight => "65 lbs.";
        public override int ArmorClass => 18 + Bonus;
        public override bool CanWear => AbilityManager.StrengthScore >= 15;

        public override string Description => ArmorDescriptionText.Plate;

        public override IArmor GetInstance() => new HAPlate();
    }
}
