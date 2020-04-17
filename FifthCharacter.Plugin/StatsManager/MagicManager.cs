using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace FifthCharacter.Plugin.StatsManager {
    public static class MagicManager {
        //Constants
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

        //Properties
        private static double _spellcasterLevel;
        /// <summary>
        /// This should be set to <c>true</c> if and only if the character is either a primary caster or is multiclassing 
        /// </summary>
        public static bool IsMulticlassing { get; set; }
        public static int SpellcasterLevel {
            get {
                if (IsMulticlassing) {
                    return (int)Math.Floor(_spellcasterLevel);
                } else {
                    return (int)Math.Ceiling(_spellcasterLevel);
                }
            }
        }
        public static ObservableCollection<SpellLevelGroup> SpellsKnown { get; private set; } = new ObservableCollection<SpellLevelGroup>();
        public static ObservableCollection<SpellSlot> SpellSlots { get; private set; } = new ObservableCollection<SpellSlot>();
        public static bool IsPreparedCaster { get; private set; } = true; //The value of this should be pulled from the spellcasting class

        //Public Methods
        public static void AddSpellcasterLevel(SpellcasterClass spellcaster) {
            switch (spellcaster) {
                case SpellcasterClass.PRIMARY:
                    _spellcasterLevel++;
                    break;
                case SpellcasterClass.SECONDARY:
                    _spellcasterLevel += 0.5;
                    break;
                case SpellcasterClass.TERTIARY:
                    _spellcasterLevel += (1.0 / 3.0);
                    break;
                case SpellcasterClass.NONE:
                    break;
            }

            switch (SpellcasterLevel) {
                case 1:
                    SpellSlots.Add(new SpellSlot() { SpellLevel = 1, TotalSlots = 2 }) ;
                    break;
                case 2:
                    SpellSlots.Where(l => l.SpellLevel == 1).FirstOrDefault().TotalSlots++;
                    break;
                case 3:
                    SpellSlots.Where(l => l.SpellLevel == 1).FirstOrDefault().TotalSlots++;
                    SpellSlots.Add(new SpellSlot() { SpellLevel = 2, TotalSlots = 2 });
                    break;
                case 4:
                    SpellSlots.Where(l => l.SpellLevel == 2).FirstOrDefault().TotalSlots++;
                    break;
                case 5:
                    SpellSlots.Add(new SpellSlot() { SpellLevel = 3, TotalSlots = 2 });
                    break;
                case 6:
                    SpellSlots.Where(l => l.SpellLevel == 3).FirstOrDefault().TotalSlots++;
                    break;
                case 7:
                    SpellSlots.Add(new SpellSlot() { SpellLevel = 4, TotalSlots = 1 });
                    break;
                case 8:
                    SpellSlots.Where(l => l.SpellLevel == 4).FirstOrDefault().TotalSlots++;
                    break;
                case 9:
                    SpellSlots.Add(new SpellSlot() { SpellLevel = 5, TotalSlots = 1 });
                    break;
                case 10:
                    SpellSlots.Where(l => l.SpellLevel == 5).FirstOrDefault().TotalSlots++;
                    break;
                case 11:
                    SpellSlots.Add(new SpellSlot() { SpellLevel = 6, TotalSlots = 1 });
                    break;
                case 13:
                    SpellSlots.Add(new SpellSlot() { SpellLevel = 7, TotalSlots = 1 });
                    break;
                case 15:
                    SpellSlots.Add(new SpellSlot() { SpellLevel = 8, TotalSlots = 1 });
                    break;
                case 17:
                    SpellSlots.Add(new SpellSlot() { SpellLevel = 9, TotalSlots = 1 });
                    break;
                case 18:
                    SpellSlots.Where(l => l.SpellLevel == 5).FirstOrDefault().TotalSlots++;
                    break;
                case 19:
                    SpellSlots.Where(l => l.SpellLevel == 6).FirstOrDefault().TotalSlots++;
                    break;
                case 20:
                    SpellSlots.Where(l => l.SpellLevel == 7).FirstOrDefault().TotalSlots++;
                    break;
                default:
                    break;
            }
            
        }

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

        //Private Methods
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

    public enum SpellcasterClass {
        PRIMARY,
        SECONDARY,
        TERTIARY,
        NONE
    }
}
