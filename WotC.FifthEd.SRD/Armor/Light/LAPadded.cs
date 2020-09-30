using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor.Light {
    public class LAPadded : ALightArmor {
        public override string Name => "Padded Armor";
        public override string ID => "SRD.Armor.Light.Padded";
        public override ACurrency Cost => new GoldPiece(5);
        public override string Weight => "8 lbs.";
        public override int ArmorClass => 11 + AbilityManager.DexterityMod + Bonus;
        public override bool StealthDisadvantage => true;

        public override string Description => ArmorDescriptionText.Padded;

        public override IArmor GetInstance() => new LAPadded();
    }
}
