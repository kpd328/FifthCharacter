using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Armor.Abstract {
    public abstract class AMediumArmor : IArmor, IArmorClass, IEquipment {
        public abstract string Name { get; }
        public abstract string ID { get; }
        public ArmorWeightClass ArmorWeightClass => ArmorWeightClass.MEDIUM;
        public abstract string Cost { get; }
        public abstract string Weight { get; }
        public int ArmorClass => IsDexRestricted ? ArmorClassDexRestrict : ArmorClassNoDexRestrict;
        /// <summary>
        /// This is the armor class with the +2 dex cap lifted (or rather raised to +3 as per the PHB Feat "Medium Armor Master"
        /// </summary>
        protected abstract int ArmorClassNoDexRestrict { get; }
        /// <summary>
        /// This is the armor class with the +2 dex cap taken into account
        /// </summary>
        protected abstract int ArmorClassDexRestrict { get; }
        //TODO: determine when to set this to false (if Medium Armor Master is taken as a feat, the cap is raised from 2 to 3.
        private bool IsDexRestricted { get; } = true;
        public virtual bool CanWear => true;
        public abstract bool StealthDisadvantage { get; }
        public int Bonus { get; set; } = 0;
        public abstract string Description { get; }
        public int Count { get; set; }

        public abstract IArmor GetInstance();
    }
}
