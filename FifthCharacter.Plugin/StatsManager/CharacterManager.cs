using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Tools;

namespace FifthCharacter.Plugin.StatsManager {
    public static class CharacterManager {
        //TODO: Save information to static location

        //Character information, assignments are temporary
        public static string CharacterName { get; set; }
        public static string ClassLevel => ClassManager.ClassAndLevelText;
        public static IBackground Background { get; set; }
        public static string PlayerName { get; set; }
        public static IRace Race { get; set; }
        public static Alignment Alignment { get; set; }
        public static string AlignmentText => Alignment.DisplayString();
        public static int ExperiecePoints { get; set; } //TODO: integrate with XP manager

        //Combat information
        public static int ArmorClass { get; set; } //TODO: integrate with systems to produce value based on armor, race, class, dex, etc.
        private static int InitiativeBonus { get; set; } //TODO: integrate with systems to produce value based on dex, class, etc.
        public static string Initiative => InitiativeBonus.ToString("+0;-#");
        public static int Speed { get; set; } //TODO: integrate with systems to produce value based on race, class, etc.
        public static int HitPointMaximum { get; set; } //TODO: integrate with systems to produce value based on class, etc.
        public static int HitPointCurrent { get; set; } //TODO: integrate with health system to fire off dying sequence when dropping to 0
        public static int HitPointTemporary { get; set; } //TODO: integrate with health system to be used before HitPointCurrent when taking damage
        public static int HitPointShowing => HitPointCurrent + HitPointTemporary;
        public static bool HasTempHitPoints => HitPointTemporary > 0;

        //TODO: implement death saves feature
    }
}
