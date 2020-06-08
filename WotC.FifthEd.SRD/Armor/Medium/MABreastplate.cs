using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;

namespace WotC.FifthEd.SRD.Armor.Medium {
    public class MABreastplate : AMediumArmor {
        public override string Name => "Breastplate Armor";
        public override string ID => "SRD.Armor.Medium.Breastplate";
        public override string Cost => "400 gp";
        public override string Weight => "20 lbs.";
        protected override int ArmorClassNoDexRestrict => 14 + Math.Min(3, AbilityManager.DexterityMod) + Bonus;
        protected override int ArmorClassDexRestrict => 14 + Math.Min(2, AbilityManager.DexterityMod) + Bonus;
        public override bool StealthDisadvantage => false;

        public override IArmor GetInstance() => new MABreastplate();
    }
}
