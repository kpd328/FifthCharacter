using FifthCharacter.Plugin.Interface;
using System.Collections.ObjectModel;

namespace FifthCharacter.Plugin.StatsManager {
    public static class AttacksManager {
        public static ObservableCollection<IAttack> Attacks { get; private set; } = new ObservableCollection<IAttack>();
    }
}
