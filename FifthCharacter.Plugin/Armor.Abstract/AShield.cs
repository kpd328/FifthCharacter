using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Armor.Abstract {
    public abstract class AShield : IArmor, IEquipment {
        public abstract string Name { get; }
        public abstract string ID { get; }
        public ArmorWeightClass ArmorWeightClass => ArmorWeightClass.SHIELD;
        public abstract ACurrency Cost { get; }
        public abstract string Weight { get; }
        public virtual bool CanWear => true;
        public virtual bool StealthDisadvantage => false;
        public virtual int Bonus { get; set; } = 0;
        public abstract string Description { get; }
        public int Count { get; set; }

        public abstract IArmor GetInstance();
    }
}
