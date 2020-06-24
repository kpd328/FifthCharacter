﻿using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Armor.Abstract {
    public abstract class ALightArmor : IArmor, IArmorClass {
        public abstract string Name { get; }
        public abstract string ID { get; }
        public ArmorWeightClass ArmorWeightClass => ArmorWeightClass.LIGHT;
        public abstract string Cost { get; }
        public abstract string Weight { get; }
        public abstract int ArmorClass { get; }
        public virtual bool CanWear => true;
        public abstract bool StealthDisadvantage { get; }
        public int Bonus { get; set; } = 0;

        public abstract IArmor GetInstance();
    }
}