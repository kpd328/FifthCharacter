using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor.Heavy {
    public class HASplint : AHeavyArmor {
        public override string Name => "Splint Armor";
        public override string ID => "SRD.Armor.Heavy.Splint";
        public override ACurrency Cost => new GoldPiece(200);
        public override string Weight => "60 lbs.";
        public override int ArmorClass => 17 + Bonus;
        public override bool CanWear => AbilityManager.StrengthScore >= 15;

        public override string Description => ArmorDescriptionText.Splint;

        public override IArmor GetInstance() => new HASplint();
    }
}
