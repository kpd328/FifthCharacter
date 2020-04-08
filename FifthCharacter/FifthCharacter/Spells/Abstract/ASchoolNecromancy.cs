﻿using FifthCharacter.Plugin.Interface;
using FifthCharacter.StatsManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Spells.Abstract {
    public abstract class ASchoolNecromancy : IMagic {
        public abstract SpellLevel SpellLevel { get; }
        public abstract bool Ritual { get; }
        public abstract string CastingTime { get; }
        public abstract string Range { get; }
        public abstract IList<string> Components { get; }
        public abstract string Duration { get; }
        public abstract string Targets { get; }
        public abstract string AreaOfEffect { get; }
        public abstract string Name { get; }
        public bool PreparedCaster => MagicManager.IsPreparedCaster;
    }
}
