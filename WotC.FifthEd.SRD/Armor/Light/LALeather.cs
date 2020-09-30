using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor.Light {
    public class LALeather : ALightArmor {
        public override string Name => "Leather Armor";
        public override string ID => "SRD.Armor.Light.Leather";
        public override ACurrency Cost => new GoldPiece(5);
        public override string Weight => "10 lbs.";
        public override int ArmorClass => 11 + AbilityManager.DexterityMod + Bonus;
        public override bool StealthDisadvantage => false;

        public override string Description => ArmorDescriptionText.Leather;

        public override IArmor GetInstance() => new LALeather();
    }
}
