using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor.Light {
    public class LAStuddedLeather : ALightArmor {
        public override string Name => "Studded Leather Armor";
        public override string ID => "SRD.Armor.Light.StuddedLeather";
        public override ACurrency Cost => new GoldPiece(45);
        public override string Weight => "13 lbs.";
        public override int ArmorClass => 12 + AbilityManager.DexterityMod + Bonus;
        public override bool StealthDisadvantage => false;

        public override string Description => ArmorDescriptionText.StuddedLeather;

        public override IArmor GetInstance() => new LAStuddedLeather();
    }
}
