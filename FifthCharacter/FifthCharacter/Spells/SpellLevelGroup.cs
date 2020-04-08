using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FifthCharacter.Spells {
    public class SpellLevelGroup : ObservableCollection<IMagic> {
        public string Level { get; private set; }
        public SpellLevelGroup(string level) : base() {
            Level = level;
        }
        public SpellLevelGroup(string level, IEnumerable<IMagic> source) : base(source) {
            Level = level;
        }
    }
}
