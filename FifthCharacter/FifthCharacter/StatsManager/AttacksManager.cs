using FifthCharacter.Plugin.Interface;
using System.Collections.ObjectModel;

namespace FifthCharacter.StatsManager {
    public static class AttacksManager {
        public static ObservableCollection<IAttack> Attacks { get; private set; }

        static AttacksManager() {
            Attacks = new ObservableCollection<IAttack>() {
                App.Plugins.Attacks["Dagger"].GetInstance(),
                App.Plugins.Attacks["Handaxe"].GetInstance(),
                App.Plugins.Attacks["Longsword"].GetInstance(),
                App.Plugins.Attacks["Fire Bolt"].GetInstance()
            };
        }
    }
}
