namespace FifthCharacter.Plugin.Interface {
    public interface IEquipment {
        string Name { get; }
        string ID { get; }
        string Cost { get; }
        string Weight { get; }
        string Description { get; }
        int Count { get; set; }
    }
}
