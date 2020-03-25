using FifthCharacter.Attacks.MartialMeleeWeapon;
using FifthCharacter.Attacks.SimpleMeleeWeapon;
using FifthCharacter.Attacks.SimpleRangedWeapon;
using FifthCharacter.Interface;
using FifthCharacter.Spells.Evocation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FifthCharacter.StatsManager {
    public static class AttacksManager {
        public static ObservableCollection<IAttack> Attacks { get; private set; }

        static AttacksManager() {
            Attacks = new ObservableCollection<IAttack> {
                new SMWDagger(),
                new SMWHandaxe(),
                new MMWLongsword(),
                new FireBolt()
            };
        }
    }
}
