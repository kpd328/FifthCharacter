using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Equipment.Abstract {
    public abstract class ACurrency : IEquipment {
        public abstract string Name { get; }
        public abstract string ID { get; }
        /// <summary>
        /// This should be used to convey it's value in Gold Pieces (gp).
        /// </summary>
        public abstract string Cost { get; }
        /// <summary>
        /// For all SRD currency this is 1/3 oz per piece, but may be overridden by other modules
        /// </summary>
        public virtual string Weight => "1/3 oz";
        /// <summary>
        /// This is not used for currency, but may be overridden by other modules
        /// </summary>
        public virtual string Description => "";
        public int Count { get; set; }
    }
}
