using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Armor.Light {
    public class LAPadded : ALightArmor {
        public override string Name => "Padded Armor";
        public override string ID => "SRD.Armor.Light.Padded";
        public override string Cost => "5 gp";
        public override string Weight => "8 lbs.";
        public override int ArmorClass => 11 + AbilityManager.DexterityMod + Bonus;
        public override bool StealthDisadvantage => true;

        public override IArmor GetInstance() => new LAPadded();
    }
}
