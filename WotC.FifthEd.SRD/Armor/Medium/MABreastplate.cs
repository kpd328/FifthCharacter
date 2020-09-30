using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor.Medium {
    public class MABreastplate : AMediumArmor {
        public override string Name => "Breastplate Armor";
        public override string ID => "SRD.Armor.Medium.Breastplate";
        public override ACurrency Cost => new GoldPiece(400);
        public override string Weight => "20 lbs.";
        protected override int ArmorClassNoDexRestrict => 14 + Math.Min(3, AbilityManager.DexterityMod) + Bonus;
        protected override int ArmorClassDexRestrict => 14 + Math.Min(2, AbilityManager.DexterityMod) + Bonus;
        public override bool StealthDisadvantage => false;

        public override string Description => ArmorDescriptionText.Breastplate;

        public override IArmor GetInstance() => new MABreastplate();
    }
}
