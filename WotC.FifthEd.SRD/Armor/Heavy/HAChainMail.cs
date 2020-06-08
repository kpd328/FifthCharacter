using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Armor.Heavy {
    public class HAChainMail : AHeavyArmor {
        public override string Name => "Chain Mail";
        public override string ID => "SRD.Armor.Heavy.ChainMail";
        public override string Cost => "75 gp";
        public override string Weight => "55 lbs.";
        public override int ArmorClass => 16 + Bonus;
        public override bool CanWear => AbilityManager.StrengthScore >= 13;

        public override IArmor GetInstance() => new HAChainMail();
    }
}
