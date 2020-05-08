using FifthCharacter.Plugin.Interface;
using System.Windows.Input;

namespace WotC.FifthEd.SRD.Features.PlayerClass {
    /// <summary>
    /// Use this class to help develop "Ability Score Improvement" classes using the content shared between different versions
    /// </summary>
    public static class FAbilityScoreImprovement {
        public static string Name => "Ability Score Improvement";
        public static bool IsActive => false;
        public static int ActiveUses => 0;
        public static bool IsAbilityMod => true;

        public static void ModAbility() {
            //TODO: prompt to pick ability(s) to improve or feat to take
        }
    }
}
