using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;

namespace WotC.FifthEd.SRD.Armor.Medium {
    public class MAChainShirt : AMediumArmor {
        public override string Name => "Chain Shirt";
        public override string ID => "SRD.Armor.Medium.ChainShirt";
        public override string Cost => "50 gp";
        public override string Weight => "20 lbs.";
        protected override int ArmorClassNoDexRestrict => 13 + Math.Min(3, AbilityManager.DexterityMod) + Bonus;
        protected override int ArmorClassDexRestrict => 13 + Math.Min(2, AbilityManager.DexterityMod) + Bonus;
        public override bool StealthDisadvantage => false;

        public override IArmor GetInstance() => new MAChainShirt();
    }
}
