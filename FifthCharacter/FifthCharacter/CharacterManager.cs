using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter {
    public static class CharacterManager {
        //TODO: Save information to static location

        //Character information, assignments are temporary
        public static string CharacterName { get; set; } = "Hero";
        public static string ClassLevel { get; set; } = "Fighter 4"; //TODO: retrieve from character class(es)
        public static string Background { get; set; } = "Military Veteran"; //TODO: retrieve from character background
        public static string PlayerName { get; set; } = "John Doe";
        public static string Race { get; set; } = "Human"; //TODO: retrieve from character race
        public static string Alignment { get; set; } = "LG"; //TODO: retrieve from enum
        public static int ExperiecePoints { get; set; } = 1200; //TODO: integrate with XP manager

        //Combat information
        public static int ArmorClass { get; set; } //TODO: integrate with systems to produce value based on armor, race, class, dex, etc.
        private static int InitiativeBonus { get; set; } //TODO: integrate with systems to produce value based on dex, class, etc.
        public static string Initiative => InitiativeBonus.ToString("+0;-#");
        public static int Speed { get; set; } //TODO: integrate with systems to produce value based on race, class, etc.
        public static int HitPointMaximum { get; set; } //TODO: integrate with systems to produce value based on class, etc.
        public static int HitPointCurrent { get; set; } //TODO: integrate with health system to fire off dying sequence when dropping to 0
        public static int HitPointTemporary { get; set; } //TODO: integrate with health system to be used before HitPointCurrent when taking damage
        public static string HitDiceTotal { get; set; } //TODO: retrieve from character class(es)
        public static string HitDiceCurrent { get; set; } //TODO: integrate with health system to be expendable

        //TODO: implement death saves feature
    }
}
