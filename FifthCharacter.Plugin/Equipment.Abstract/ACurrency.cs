using FifthCharacter.Plugin.Interface;

namespace FifthCharacter.Plugin.Equipment.Abstract {
    public abstract class ACurrency : IEquipment {
        public abstract string Name { get; }
        public abstract string ID { get; }
        public abstract string ShortName { get; }
        /// <summary>
        /// This should be used to convey it's value in Copper Pieces (cp).
        /// </summary>
        public abstract ACurrency Cost { get; }
        /// <summary>
        /// For all SRD currency this is 1/3 oz per piece, but may be overridden by other modules
        /// </summary>
        public virtual string Weight => "1/3 oz";
        /// <summary>
        /// This is not used for currency, but may be overridden by other modules
        /// </summary>
        public virtual string Description => "";
        public int Count { get; set; }

        public override string ToString() => string.Format("{0} {1}", Count, ShortName);
    }
}
