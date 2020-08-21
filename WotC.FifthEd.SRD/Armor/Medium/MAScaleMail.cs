using FifthCharacter.Plugin.Armor.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;

namespace WotC.FifthEd.SRD.Armor.Medium {
    public class MAScaleMail : AMediumArmor {
        public override string Name => "Scale Mail";
        public override string ID => "SRD.Armor.Medium.ScaleMail";
        public override string Cost => "50 gp";
        public override string Weight => "45 lbs.";
        protected override int ArmorClassNoDexRestrict => 14 + Math.Min(3, AbilityManager.DexterityMod) + Bonus;
        protected override int ArmorClassDexRestrict => 14 + Math.Min(2, AbilityManager.DexterityMod) + Bonus;
        public override bool StealthDisadvantage => true; //TODO: set this to false if the PHB Medium Armor Master feat is enabled

        public override string Description => ArmorDescriptionText.ScaleMail;

        public override IArmor GetInstance() => new MAScaleMail();
    }
}
