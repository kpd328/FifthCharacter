using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Armor.Abstract {
    public abstract class ALightArmor : IArmor, IArmorClass, IEquipment {
        public abstract string Name { get; }
        public abstract string ID { get; }
        public ArmorWeightClass ArmorWeightClass => ArmorWeightClass.LIGHT;
        public abstract ACurrency Cost { get; }
        public abstract string Weight { get; }
        public abstract int ArmorClass { get; }
        public virtual bool CanWear => true;
        public abstract bool StealthDisadvantage { get; }
        public int Bonus { get; set; } = 0;
        public abstract string Description { get; }
        public int Count { get; set; }

        public abstract IArmor GetInstance();
    }
}
