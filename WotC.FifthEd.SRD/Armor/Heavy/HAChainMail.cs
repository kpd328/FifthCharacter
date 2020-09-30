using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor.Heavy {
    public class HAChainMail : AHeavyArmor {
        public override string Name => "Chain Mail";
        public override string ID => "SRD.Armor.Heavy.ChainMail";
        public override ACurrency Cost => new GoldPiece(75);
        public override string Weight => "55 lbs.";
        public override int ArmorClass => 16 + Bonus;
        public override bool CanWear => AbilityManager.StrengthScore >= 13;

        public override string Description => ArmorDescriptionText.ChainMail;

        public override IArmor GetInstance() => new HAChainMail();
    }
}
