using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Plugin.Interface {
    public interface IMagic {
        string Name { get; }
        string ID { get; }
        SpellLevel SpellLevel { get; }
        bool Ritual { get; }
        string CastingTime { get; }
        string Range { get; }
        IList<string> Components { get; }
        string Duration { get; }
        string Targets { get; }
        string AreaOfEffect { get; }

        IMagic GetInstance();
    }

    public enum SpellLevel {
        CANTRIP = 0,
        FIRST_LEVEL = 1,
        SECOND_LEVEL = 2,
        THIRD_LEVEL = 3,
        FOURTH_LEVEL = 4,
        FIFTH_LEVEL = 5,
        SIXTH_LEVEL = 6,
        SEVENTH_LEVEL = 7,
        EIGHTH_LEVEL = 8,
        NINTH_LEVEL = 9
    }
}
