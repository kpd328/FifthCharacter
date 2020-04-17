using FifthCharacter.Plugin.Interface;
using System.Collections.ObjectModel;

namespace FifthCharacter.Plugin.StatsManager {
    public static class MagicManager {
        private const string CANTRIP = "Cantrips";
        private const string FIRST_LEVEL = "1st Level";
        private const string SECOND_LEVEL = "2nd Level";
        private const string THIRD_LEVEL = "3rd Level";
        private const string FOURTH_LEVEL = "4th Level";
        private const string FIFTH_LEVEL = "5th Level";
        private const string SIXTH_LEVEL = "6th Level";
        private const string SEVENTH_LEVEL = "7th Level";
        private const string EIGHTH_LEVEL = "8th Level";
        private const string NINTH_LEVEL = "9th Level";

        public static ObservableCollection<SpellLevelGroup> SpellsKnown { get; private set; } = new ObservableCollection<SpellLevelGroup>();
        public static bool IsPreparedCaster { get; private set; } = true; //The value of this should be pulled from the spellcasting class
        public static void AddSpell(IMagic spell) {
            string _level = SpellLevelToString(spell.SpellLevel);
            if(_level == "") {
                throw new System.Exception("Invalid Spell level");
            }

            //Checking if the level is already in the collection
            foreach(SpellLevelGroup magics in SpellsKnown) {
                if(magics.Level == _level) {
                    magics.Add(spell);
                    return;
                }
            }

            //Adding the level in the right spot of the collection (right before the first one greater than it)
            for(int i = 0; i < SpellsKnown.Count; i++) {
                if(LevelTextToInt(_level) < LevelTextToInt(SpellsKnown[i].Level) || i == SpellsKnown.Count -1) {
                    SpellsKnown.Insert(i, new SpellLevelGroup(_level, new IMagic[] { spell }));
                    return;
                }
            }
        }

        private static int LevelTextToInt(string level) {
            switch (level) {
                case CANTRIP:
                    return 0;
                case FIRST_LEVEL:
                    return 1;
                case SECOND_LEVEL:
                    return 2;
                case THIRD_LEVEL:
                    return 3;
                case FOURTH_LEVEL:
                    return 4;
                case FIFTH_LEVEL:
                    return 5;
                case SIXTH_LEVEL:
                    return 6;
                case SEVENTH_LEVEL:
                    return 7;
                case EIGHTH_LEVEL:
                    return 8;
                case NINTH_LEVEL:
                    return 9;
                default:
                    return -1;
            }
        }

        private static string SpellLevelToString(SpellLevel level) {
            switch (level) {
                case SpellLevel.CANTRIP:
                    return CANTRIP;
                case SpellLevel.FIRST_LEVEL:
                    return FIRST_LEVEL;
                case SpellLevel.SECOND_LEVEL:
                    return SECOND_LEVEL;
                case SpellLevel.THIRD_LEVEL:
                    return THIRD_LEVEL;
                case SpellLevel.FOURTH_LEVEL:
                    return FOURTH_LEVEL;
                case SpellLevel.FIFTH_LEVEL:
                    return FIFTH_LEVEL;
                case SpellLevel.SIXTH_LEVEL:
                    return SIXTH_LEVEL;
                case SpellLevel.SEVENTH_LEVEL:
                    return SEVENTH_LEVEL;
                case SpellLevel.EIGHTH_LEVEL:
                    return EIGHTH_LEVEL;
                case SpellLevel.NINTH_LEVEL:
                    return NINTH_LEVEL;
            }
            return "";
        }
    }
}
