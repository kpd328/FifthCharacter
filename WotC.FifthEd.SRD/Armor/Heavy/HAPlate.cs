using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Armor.Heavy {
    public class HAPlate : AHeavyArmor {
        public override string Name => "Plate Armor";
        public override string ID => "SRD.Armor.Heavy.Plate";
        public override string Cost => "1,500 gp";
        public override string Weight => "65 lbs.";
        public override int ArmorClass => 18 + Bonus;
        public override bool CanWear => AbilityManager.StrengthScore >= 15;

        public override IArmor GetInstance() => new HAPlate();
    }
}
