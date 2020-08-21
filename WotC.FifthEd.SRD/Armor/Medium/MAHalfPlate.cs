using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;

namespace WotC.FifthEd.SRD.Armor.Medium {
    public class MAHalfPlate : AMediumArmor {
        public override string Name => "Half Plate Armor";
        public override string ID => "SRD.Armor.Medium.HalfPlate";
        public override string Cost => "750 gp";
        public override string Weight => "40 lbs.";
        protected override int ArmorClassNoDexRestrict => 15 + Math.Min(3, AbilityManager.DexterityMod) + Bonus;
        protected override int ArmorClassDexRestrict => 15 + Math.Min(2, AbilityManager.DexterityMod) + Bonus;
        public override bool StealthDisadvantage => true; //TODO: set this to false if the PHB Medium Armor Master feat is enabled

        public override string Description => ArmorDescriptionText.HalfPlate;

        public override IArmor GetInstance() => new MAHalfPlate();
    }
}
