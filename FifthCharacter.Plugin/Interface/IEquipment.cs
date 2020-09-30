using FifthCharacter.Plugin.Equipment.Abstract;

namespace FifthCharacter.Plugin.Interface {
    public interface IEquipment {
        string Name { get; }
        string ID { get; }
        ACurrency Cost { get; }
        string Weight { get; }
        string Description { get; }
        int Count { get; set; }
    }
}
