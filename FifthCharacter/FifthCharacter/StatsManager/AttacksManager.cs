using FifthCharacter.Attacks.SimpleMeleeWeapon;
using FifthCharacter.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FifthCharacter.StatsManager {
    public static class AttacksManager {
        public static ObservableCollection<IAttack> Attacks { get; private set; }

        static AttacksManager() {
            Attacks = new ObservableCollection<IAttack>();
            Attacks.Add(new SMWClub());
        }
    }
}
