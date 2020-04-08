using FifthCharacter.Plugin.Interface;
using System.Collections.ObjectModel;

namespace FifthCharacter.StatsManager {
    public static class MagicManager {
        public static ObservableCollection<SpellLevelGroup> SpellsKnown { get; private set; }
        public static bool IsPreparedCaster { get; private set; } = true; //The value of this should be pulled from the spellcasting class

        static MagicManager() {
            SpellsKnown = new ObservableCollection<SpellLevelGroup>() {
                new SpellLevelGroup("Cantrips", new IMagic[]{
                    App.Plugins.Magic["Fire Bolt"].GetInstance(),
                    App.Plugins.Magic["Acid Splash"].GetInstance()
                }),
                new SpellLevelGroup("1st Level", new IMagic[]{
                    App.Plugins.Magic["Animal Friendship"].GetInstance(),
                    App.Plugins.Magic["Alarm"].GetInstance()
                }),
                new SpellLevelGroup("2nd Level", new IMagic[]{
                    App.Plugins.Magic["Alter Self"].GetInstance(),
                    App.Plugins.Magic["Aid"].GetInstance()
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
