using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Armor.Light {
    public class LAStuddedLeather : ALightArmor {
        public override string Name => "Studded Leather Armor";
        public override string ID => "SRD.Armor.Light.StuddedLeather";
        public override string Cost => "45 gp";
        public override string Weight => "13 lbs.";
        public override int ArmorClass => 12 + AbilityManager.DexterityMod + Bonus;
        public override bool StealthDisadvantage => false;

        public override string Description => ArmorDescriptionText.StuddedLeather;

        public override IArmor GetInstance() => new LAStuddedLeather();
    }
}
