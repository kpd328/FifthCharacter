﻿using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Armor.Abstract {
    public abstract class AHeavyArmor : IArmor, IArmorClass, IEquipment {
        public abstract string Name { get; }
        public abstract string ID { get; }
        public ArmorWeightClass ArmorWeightClass => ArmorWeightClass.HEAVY;
        public abstract ACurrency Cost { get; }
        public abstract string Weight { get; }
        public abstract int ArmorClass { get; }
        public abstract bool CanWear { get; }
        public virtual bool StealthDisadvantage => true;
        public int Bonus { get; set; } = 0;
        public abstract string Description { get; }
        public int Count { get; set; }

        public abstract IArmor GetInstance();
    }
}
