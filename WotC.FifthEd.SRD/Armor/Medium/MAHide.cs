using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Armor.Medium {
    public class MAHide : AMediumArmor {
        public override string Name => "Hide Armor";
        public override string ID => "SRD.Armor.Medium.Hide";
        public override ACurrency Cost => new GoldPiece(10);
        public override string Weight => "12 lbs.";
        protected override int ArmorClassNoDexRestrict => 12 + Math.Min(3, AbilityManager.DexterityMod) + Bonus;
        protected override int ArmorClassDexRestrict => 12 + Math.Min(2, AbilityManager.DexterityMod) + Bonus;
        public override bool StealthDisadvantage => false;

        public override string Description => ArmorDescriptionText.Hide;

        public override IArmor GetInstance() => new MAHide();
    }
}
