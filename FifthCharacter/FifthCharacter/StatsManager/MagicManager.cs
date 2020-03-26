using FifthCharacter.Interface;
using FifthCharacter.Spells;
using FifthCharacter.Spells.Abjuration;
using FifthCharacter.Spells.Conjuration;
using FifthCharacter.Spells.Enchantment;
using FifthCharacter.Spells.Evocation;
using FifthCharacter.Spells.Transmutation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FifthCharacter.StatsManager {
    public static class MagicManager {
        public static ObservableCollection<SpellLevelGroup> SpellsKnown { get; private set; }
        public static bool IsPreparedCaster { get; private set; } = true; //The value of this should be pulled from the spellcasting class

        static MagicManager() {
            SpellsKnown = new ObservableCollection<SpellLevelGroup>() {
                new SpellLevelGroup("Cantrips", new IMagic[]{
                    new FireBolt(),
                    new AcidSplash()
                }),
                new SpellLevelGroup("1st Level", new IMagic[]{
                    new AnimalFriendship(),
                    new Alarm()
                }),
                new SpellLevelGroup("2nd Level", new IMagic[]{
                    new AlterSelf(),
                    new Aid()
                }),
                new SpellLevelGroup("3rd Level"),
                new SpellLevelGroup("4th Level"),
                new SpellLevelGroup("5th Level"),
                new SpellLevelGroup("6th Level"),
                new SpellLevelGroup("7th Level"),
                new SpellLevelGroup("8th Level"),
                new SpellLevelGroup("9th Level")
            };
        }
    }
}
