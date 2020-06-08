using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Armor.Abstract {
    public abstract class AHeavyArmor : IArmor, IArmorClass {
        public abstract string Name { get; }
        public abstract string ID { get; }
        public ArmorWeightClass ArmorWeightClass => ArmorWeightClass.HEAVY;
        public abstract string Cost { get; }
        public abstract string Weight { get; }
        public abstract int ArmorClass { get; }
        public abstract bool CanWear { get; }
        public virtual bool StealthDisadvantage => true;
        public int Bonus { get; set; } = 0;

        public abstract IArmor GetInstance();
    }
}
