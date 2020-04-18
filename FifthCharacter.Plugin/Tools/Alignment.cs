using System;

namespace FifthCharacter.Plugin.Tools {
    public enum Alignment {
        NONE,
        LAWFUL_GOOD,
        NEUTRAL_GOOD,
        CHAOTIC_GOOD,
        LAWFUL_NEUTRAL,
        NEUTRAL,
        CHAOTIC_NEUTRAL,
        LAWFUL_EVIL,
        NEUTRAL_EVIL,
        CHAOTIC_EVIL
    }

    public static class AlignmentExtensions {
        public static string DisplayString(this Alignment alignment) => alignment switch {
            Alignment.LAWFUL_GOOD => "Lawful Good",
            Alignment.NEUTRAL_GOOD => "Neutral Good",
            Alignment.CHAOTIC_GOOD => "Chaotic Good",
            Alignment.LAWFUL_NEUTRAL => "Lawful Neutral",
            Alignment.NEUTRAL => "Neutral",
            Alignment.CHAOTIC_NEUTRAL => "Chaotic Neutral",
            Alignment.LAWFUL_EVIL => "Lawful Evil",
            Alignment.NEUTRAL_EVIL => "Neutral Evil",
            Alignment.CHAOTIC_EVIL => "Chaotic Evil",
            Alignment.NONE => null,
            _ => ""
        };

        public static Alignment ParseToAlignment(this string stringalignment) => stringalignment switch {
            "Lawful Good" => Alignment.LAWFUL_GOOD,
            "Neutral Good" => Alignment.NEUTRAL_GOOD,
            "Chaotic Good" => Alignment.CHAOTIC_GOOD,
            "Lawful Neutral" => Alignment.LAWFUL_NEUTRAL,
            "Neutral" => Alignment.NEUTRAL,
            "Chaotic Neutral" => Alignment.CHAOTIC_NEUTRAL,
            "Lawful Evil" => Alignment.LAWFUL_EVIL,
            "Neutral Evil" => Alignment.NEUTRAL_EVIL,
            "Chaotic Evil" => Alignment.CHAOTIC_EVIL,
            null => Alignment.NONE,
            _ => throw new InvalidCastException("Unable to convert string to alignment")
        };
    }
}
