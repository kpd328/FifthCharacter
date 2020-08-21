using FifthCharacter.Plugin.Interface;
using System.Collections.ObjectModel;

namespace FifthCharacter.Plugin.StatsManager {
    public static class EquipmentManager {
        public static ObservableCollection<IEquipment> Equipment { get; private set; } = new ObservableCollection<IEquipment>();
    }
}
