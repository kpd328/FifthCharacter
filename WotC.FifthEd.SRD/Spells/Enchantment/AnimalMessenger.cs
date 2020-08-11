using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Spells.Enchantment {
    public class AnimalMessenger : ASchoolEnchantment {
        public override SpellLevel SpellLevel => SpellLevel.FIRST_LEVEL;
        public override bool Ritual => true;
        public override string CastingTime => "1 action";
        public override string Range => "30 feet";
        public override IList<string> Components => new List<string>() { 
            "V",
            "S",
            "M (a morsel if food)"
        };
        public override string Duration => "24 hours";
        public override string Targets => "A tiny beast you can see within range";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Animal Friendship";

        public override string Description => SpellDescriptions.AnimalMessenger;
        public new string AtHigherLevels => AtHigherLevelsDescriptions.AnimalMessenger;

        public override IMagic GetInstance() => new AnimalMessenger();
    }
}
