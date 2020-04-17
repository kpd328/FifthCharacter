using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FifthCharacter.Plugin.StatsManager {
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
