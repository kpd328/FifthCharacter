namespace FifthCharacter.Plugin.StatsManager {
    /// <summary>
    /// As a note, this is very TEMPORARY.
    /// PLEASE, reimplement with something
    /// more sophisticated, integrating
    /// into player class classes ((eww))
    /// </summary>
    public static class ClassManager {
        public static int ArtificerLevels { get; private set; } = 0;
        public static int BarbarianLevels { get; private set; } = 0;
        public static int BardLevels { get; private set; } = 0;
        public static int ClericLevels { get; private set; } = 0;
        public static int DruidLevels { get; private set; } = 0;
        public static int FighterLevels { get; private set; } = 0;
        public static int MonkLevels { get; private set; } = 0;
        public static int PaladinLevels { get; private set; } = 0;
        public static int RangerLevels { get; private set; } = 0;
        public static int RogueLevels { get; private set; } = 0;
        public static int SorcererLevels { get; private set; } = 0;
        public static int WarlockLevels { get; private set; } = 0;
        public static int WizardLevels { get; private set; } = 0;

        internal static void LevelUp(Classes getLevel) {
            switch (getLevel) {
                case Classes.ARTIFICER:
                    ArtificerLevels++;
                    return;
                case Classes.BARBARIAN:
                    BarbarianLevels++;
                    return;
                case Classes.BARD:
                    BardLevels++;
                    return;
                case Classes.CLERIC:
                    ClericLevels++;
                    return;
                case Classes.DRUID:
                    DruidLevels++;
                    return;
                case Classes.FIGHTER:
                    FighterLevels++;
                    return;
                case Classes.MONK:
                    MonkLevels++;
                    return;
                case Classes.PALADIN:
                    PaladinLevels++;
                    return;
                case Classes.RANGER:
                    RangerLevels++;
                    return;
                case Classes.ROGUE:
                    RogueLevels++;
                    return;
                case Classes.SORCERER:
                    SorcererLevels++;
                    return;
                case Classes.WARLOCK:
                    WarlockLevels++;
                    return;
                case Classes.WIZARD:
                    WizardLevels++;
                    return;
            }
        }
    }

    public enum Classes {
        ARTIFICER,
        BARBARIAN,
        BARD,
        CLERIC,
        DRUID,
        FIGHTER,
        MONK,
        PALADIN,
        RANGER,
        ROGUE,
        SORCERER,
        WARLOCK,
        WIZARD
    }
}
