using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Armor.Heavy {
    public class HASplint : AHeavyArmor {
        public override string Name => "Splint Armor";
        public override string ID => "SRD.Armor.Heavy.Splint";
        public override string Cost => "200 gp";
        public override string Weight => "60 lbs.";
        public override int ArmorClass => 17 + Bonus;
        public override bool CanWear => AbilityManager.StrengthScore >= 15;

        public override IArmor GetInstance() => new HASplint();
    }
}
