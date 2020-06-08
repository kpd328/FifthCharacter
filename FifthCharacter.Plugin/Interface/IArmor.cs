namespace FifthCharacter.Plugin.Interface {
    public interface IArmor {
        string Name { get; }
        string ID { get; }
        ArmorWeightClass ArmorWeightClass { get; }
        string Cost { get; }
        string Weight { get; }
        /// <summary>
        /// This boolean is used to determine if the strength requirement is met, set to <c>true</c> if so, <c>false</c> otherwise.
        /// If there is no strength requirement, always have set to <c>true</c>.
        /// </summary>
        bool CanWear { get; }
        /// <summary>
        /// This boolean is used to determine whether or not the armor grants disadvantage to stealth checks
        /// (<c>true</c> if has disadvantage, <c>false</c> otherwise).
        /// </summary>
        bool StealthDisadvantage { get; }
        /// <summary>
        /// This should be set to 0 by default and added to <c>ArmorClass</c> in its implementation,
        /// this provides a place to put magic armor AC bonuses on a set of armor without having to
        /// create a new set of armor in code.
        /// </summary>
        int Bonus { get; set; }

        IArmor GetInstance();
    }

    public enum ArmorWeightClass {
        LIGHT,
        MEDIUM,
        HEAVY,
        SHIELD
    }
}
