﻿using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Spells.Enchantment {
    public class AnimalFriendship : ASchoolEnchantment {
        public override SpellLevel SpellLevel => SpellLevel.FIRST_LEVEL;
        public override bool Ritual => false;
        public override string CastingTime => "1 Action";
        public override string Range => "30 feet";
        public override IList<string> Components => new List<string>() {
            "V",
            "S",
            "M (a morsel of food)"
        };
        public override string Duration => "24 Hours";
        public override string Targets => "A beast that you can see within range";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Animal Friendship";

        public override string Description => SpellDescriptions.AnimalFirendship;
        public new string AtHigherLevels => AtHigherLevelsDescriptions.AnimalFriendship;

        public override IMagic GetInstance() => new AnimalFriendship();
    }
}
