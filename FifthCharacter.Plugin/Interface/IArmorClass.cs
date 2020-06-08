namespace FifthCharacter.Plugin.Interface {
    /// <summary>
    /// This interface provides context for items, features, spells, etc. that provide an Armor Class
    /// calculation. Only one of these calculations can be used at a time and this interface lets the
    /// logic layer know what properties are from an Armor Class calculation (the ones from this interface)
    /// and which are bonuses to be added on top of an armor class calculation.
    /// </summary>
    public interface IArmorClass {
        int ArmorClass { get; }
    }
}
