using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Armor.Abstract {
    public abstract class AShield : IArmor {
        public abstract string Name { get; }
        public abstract string ID { get; }
        public ArmorWeightClass ArmorWeightClass => ArmorWeightClass.SHIELD;
        public abstract string Cost { get; }
        public abstract string Weight { get; }
        public virtual bool CanWear => true;
        public virtual bool StealthDisadvantage => false;
        public virtual int Bonus { get; set; } = 0;

        public abstract IArmor GetInstance();
    }
}
